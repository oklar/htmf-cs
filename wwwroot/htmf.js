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
    const hfNavigate = element.getAttribute("hf-nav");
    const hfPut = element.getAttribute("hf-put");
    const hfGet = element.getAttribute("hf-get");
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
    } else if (hfGet) {
      element.addEventListener(hfTrigger || "click", async () => {
        const data = await getData(hfGet);
        if (hfTarget) {
          updateTargetElement(hfTarget, data, element);
        }
      });
    } else if (hfNavigate) {
      element.addEventListener(hfTrigger || "click", async () => {
        window.location.href = hfNavigate;
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
 * @param {Element} triggeredElement - The element that triggered the deletion.
 */
function deleteTemplateElement(templateElement, triggeredElement) {
  if (templateElement.parentElement === null) {
    return;
  }
  // todo: improvments

  // Find the sibling element of templateElement that contains the triggeredElement
  let siblingToRemove = templateElement.nextElementSibling;
  let currentFirstElementResource = null;
  while (siblingToRemove) {
    currentFirstElementResource = siblingToRemove.hasAttribute("hf-id")
      ? siblingToRemove
      : currentFirstElementResource;
    if (
      siblingToRemove === triggeredElement ||
      siblingToRemove.contains(triggeredElement)
    ) {
      break;
    }
    siblingToRemove = siblingToRemove.nextElementSibling;
  }

  // remove all related children;
  let nextElement = currentFirstElementResource.nextElementSibling;
  for (let i = 0; i < templateElement.content.children.length; i++) {
    if (currentFirstElementResource === null) {
      break;
    }

    currentFirstElementResource.remove();
    currentFirstElementResource = nextElement;
    nextElement = nextElement?.nextElementSibling;
  }
}

/**
 * Updates cloned elements with data from the response.
 * @param {DocumentFragment} clone - The cloned content to update.
 * @param {Object} data - The data object containing values to insert.
 */
function updateClonedElements(clone, data) {
  const clonedElementsWithProps = clone.querySelectorAll(
    "[hf-prop],[hf-prop-action]"
  );

  const replaceProps = (text, props) => {
    return props.reduce((acc, prop, index) => {
      const value = getNestedPropertyValue(data, prop);
      return acc.replace(`{${index}}`, value !== undefined ? value : "");
    }, text);
  };

  clonedElementsWithProps.forEach((clonedElement, index) => {
    const hfPropAction = clonedElement.getAttribute("hf-prop-action");

    if (hfPropAction) {
      // todo: this will only take the first found hf attribute method
      const httpMethods = ["get", "post", "put", "patch", "delete"];
      const url = httpMethods.reduce(
        (acc, method) => acc || clonedElement.getAttribute(`hf-${method}`),
        null
      );

      if (url) {
        const props = hfPropAction.split(";");
        const updatedUrl = replaceProps(url, props);

        const method = httpMethods.find((m) =>
          clonedElement.hasAttribute(`hf-${m}`)
        );
        clonedElement.setAttribute(`hf-${method}`, updatedUrl);
      }
    }

    const hfProp = clonedElement.getAttribute("hf-prop");
    if (hfProp) {
      const props = hfProp.split(";");
      clonedElement.innerText = replaceProps(clonedElement.innerText, props);
    }

    const id = data.id ?? data.Id;
    if (id !== undefined && index === 0) {
      clonedElement.setAttribute("hf-id", id);
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
  if (id === null || id === undefined) {
    parentElement.appendChild(clone);
    console.warn("No resource identifier found. Appending to list...");
    return;
  }

  // query selector all, but only top level children
  let firstElement = parentElement.querySelector(`[hf-id="${id}"]`);

  if (firstElement === null) {
    parentElement.appendChild(clone);
    return;
  }

  var nextElement = firstElement.nextElementSibling;
  while (clone.children.length !== 0) {
    parentElement.replaceChild(clone.children[0], firstElement);
    firstElement = nextElement;
    nextElement = firstElement?.nextElementSibling;
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

    if (response.status === 204) {
      return null;
    }

    if (response.redirected || response.type === "opaqueredirect") {
      return undefined;
    }

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

    if (response.status === 204) {
      return null;
    }

    if (response.redirected || response.type === "opaqueredirect") {
      return undefined;
    }

    // Check if the response is OK (status 200-299)
    if (!response.ok) {
      throw new Error(`HTTP error! status: ${response.status}`);
    }

    return await response.json();
  } catch (error) {
    console.error("Error:", error); // Handle any errors
    throw error;
  }
}

async function getData(url = "") {
  try {
    const response = await fetch(url, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
    });

    // todo: better return handling on all the http verbs

    if (response.status === 204) {
      return null;
    }

    if (response.redirected || response.type === "opaqueredirect") {
      return undefined;
    }

    // Check if the response is OK (status 200-299)
    if (!response.ok) {
      throw new Error(`HTTP error! status: ${response.status}`);
    }

    return await response.json();
  } catch (error) {
    console.error("Error:", error); // Handle any errors
    throw error;
  }
}
