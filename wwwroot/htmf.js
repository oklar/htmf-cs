/**
 * Initializes the HTMF functionality when the DOM is fully loaded.
 */
document.addEventListener("DOMContentLoaded", () => {
  update(document.querySelectorAll("[hf-put],[hf-delete],[hf-trigger]"));
});

/**
 * Updates elements with 'hf-put', 'hf-delete', or 'hf-trigger' attributes by adding event listeners.
 * These listeners handle PUT and DELETE requests, and update target elements with the response data.
 * @async
 * @function update
 * @param {NodeList} elements - The list of elements to update.
 * @returns {Promise<void>}
 */
async function update(elements) {
  for (let i = 0; i < elements.length; i++) {
    const element = elements[i];
    const hfPut = element.getAttribute("hf-put");
    const hfDelete = element.getAttribute("hf-delete");
    const hfTrigger = element.getAttribute("hf-trigger");
    const hfTarget = element.getAttribute("hf-target");

    if (hfPut) {
      element.addEventListener(hfTrigger || "click", async () => {
        const data = await putData(hfPut);
        if (hfTarget) {
          updateTargetElement(hfTarget, data);
        }
      });
    } else if (hfDelete) {
      element.addEventListener(hfTrigger || "click", async () => {
        const data = await deleteData(hfDelete);
        if (hfTarget) {
          updateTargetElement(hfTarget, data, element);
        }
      });
    }
  }
}

/**
 * Updates the target element with new data.
 * @param {string} targetId - The ID of the target template element.
 * @param {Object|null} data - The data object to update the element with, or null if the element was deleted.
 * @param {Element} [element] - The element that triggered the update, or null if the update was not triggered by an element.
 */
function updateTargetElement(targetId, data, element) {
  if (data === null) {
    deleteTemplateElement(document.getElementById(targetId), element);
    return;
  }

  const targetTemplate = document.getElementById(targetId);
  const parentElement = targetTemplate.parentNode;
  const clone = targetTemplate.content.cloneNode(true);

  updateClonedElements(clone, data);
  replaceOrAppendClone(parentElement, clone, data?.id);
}

/**
 * Deletes a template element and its associated elements from the DOM.
 * @param {HTMLTemplateElement} templateElement - The template and associated elements.
 * @param {Element} element - The element that triggered the deletion.
 */
function deleteTemplateElement(templateElement, element) {
  if (templateElement.parentElement === null) {
    return;
  }

  const parentElement = templateElement.parentElement;
  let currentElement = element;
  while (!currentElement.hasAttribute("id")) {
    currentElement = currentElement.previousElementSibling;
    if (currentElement === null) break;
  }

  if (templateElement.content.children.length === 1) {
    parentElement.querySelector(`[id="${currentElement.id}"]`).remove();
    return;
  }

  for (let i = 0; i < templateElement.content.children.length; i++) {
    var nextElementSibling = currentElement.nextElementSibling;
    parentElement.removeChild(currentElement);
    currentElement = nextElementSibling;
  }
}

/**
 * Updates cloned elements with data from the response.
 * @param {DocumentFragment} clone - The cloned content to update.
 * @param {Object} data - The data object containing values to insert.
 */
function updateClonedElements(clone, data) {
  const clonedElementsWithProps = clone.querySelectorAll("[hf-prop]");

  clonedElementsWithProps.forEach((clonedElement) => {
    const hfProp = clonedElement.getAttribute("hf-prop");
    const props = hfProp.split(";");
    let text = clonedElement.innerText;

    props.forEach((prop, index) => {
      const value = getNestedPropertyValue(data, prop);
      text = text.replace(`{${index}}`, value !== undefined ? value : "");
    });
    clonedElement.innerText = text;
    //clonedElement.removeAttribute("hf-prop");

    if (data.id !== undefined || data.Id !== undefined) {
      clonedElement.setAttribute("id", data.id || data.Id);
    }
  });
}

/**
 * Retrieves a nested property value from an object.
 * @param {Object} obj - The object to search.
 * @param {string} propPath - The property path (e.g., "user.address.street").
 * @returns {*} The value of the nested property, or undefined if not found.
 */
function getNestedPropertyValue(obj, propPath) {
  const props = propPath.split(".");
  let value = obj;

  for (const prop of props) {
    if (value && typeof value === "object" && prop in value) {
      value = value[prop];
    } else {
      const lowerCaseProp = prop.charAt(0).toLowerCase() + prop.slice(1);
      if (value && typeof value === "object" && lowerCaseProp in value) {
        value = value[lowerCaseProp];
      } else {
        return undefined;
      }
    }
  }

  return value;
}

/**
 * Replaces existing elements or appends new elements based on the cloned content and template structure.
 * @param {HTMLElement} parentElement - The parent element to append to or replace within.
 * @param {DocumentFragment} clone - The cloned content to insert.
 * @param {string|number} [id] - The ID of the first element, if available.
 */
function replaceOrAppendClone(parentElement, clone, id) {
  // const cloneChildCount = clone.children.length;
  update(clone.children);
  if (id) {
    // query selector all, but only top level children
    const childrenWithId = parentElement.querySelectorAll(`[id="${id}"]`);

    if (childrenWithId.length > 0) {
      const hfPropsClones = clone.querySelectorAll("[hf-prop]");

      for (let i = 0; i < childrenWithId.length; i++) {
        parentElement.replaceChild(hfPropsClones[i], childrenWithId[i]);
        //update(hfPropsClones[i]);
      }

      /*
      if (cloneChildCount == 1) {
        parentElement.replaceChild(clone.children[0], existingElement);
      } else {
        
        let nextElement = existingElement.nextElementSibling;
        parentElement.replaceChild(clone.children[0], existingElement);

        for (let i = 1; i < cloneChildCount; i++) {
          // todo: how to handle this without a reflow for each element?
          if (nextElement === null || nextElement === undefined) {
            parentElement.appendChild(clone.children[i]);
          } else if (nextElement.hasAttribute("id")) {
            parentElement.insertBefore(clone.children[i], nextElement);
          } else {
            let currentElement = nextElement;
            nextElement = nextElement.nextElementSibling;
            parentElement.replaceChild(clone.children[i], currentElement);
          }
        }
      }
      */
    } else {
      parentElement.appendChild(clone);
    }
  } else {
    parentElement.appendChild(clone);
  }
}

/**
 * Sends a PUT request to the specified URL with the given data.
 * @async
 * @param {string} url - The URL to send the PUT request to.
 * @param {Object} [data={}] - The data to send in the request body.
 * @returns {Promise<Object>} The parsed JSON response from the server.
 * @throws {Error} If the network response is not successful.
 */
async function putData(url = "", data = {}) {
  try {
    const response = await fetch(url, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(data),
    });

    // Check if the response is OK (status 200-299)
    if (!response.ok) {
      throw new Error(`HTTP error! status: ${response.status}`);
    }

    // Parse and return the JSON response
    return await response.json();
  } catch (error) {
    console.error("Error:", error); // Handle any errors
    throw error;
  }
}

/**
 * Sends a DELETE request to the specified URL.
 * @async
 * @param {string} url - The URL to send the DELETE request to.
 * @returns {Promise<Object>} The parsed JSON response from the server.
 * @throws {Error} If the network response is not successful.
 */
async function deleteData(url = "") {
  try {
    const response = await fetch(url, {
      method: "DELETE",
      headers: {
        "Content-Type": "application/json",
      },
    });

    // Check if the response is OK (status 200-299)
    if (!response.ok) {
      throw new Error(`HTTP error! status: ${response.status}`);
    }

    if (response.status === 204) {
      return null;
    }

    return await response.json();
  } catch (error) {
    console.error("Error:", error); // Handle any errors
    throw error;
  }
}
