﻿How does templates in HTMF react to https verbs?

The HTTP requests manipulates the collection where the template element is located. 

1. Get -> Appends already existing resources in the collection

2. Post -> Appends a newly created resource in the collection

3. Put -> Updates existing resource or appends newly created resource in the collection 

4. Patch -> Updates specific fields on an existing resource in the collection

5. Delete -> Removes the resource from the collection 

Optionally send 204 No Content response from any of the verbs except POST, deletes the resource.

```csharp
var hf = new Htmf()

.Page("Hello HTMF!")
.Script("https://cdn.tailwindcss.com")
            
.Div().Css("flex flex-row justify-center space-x-64 h-full w-full")
    .Div("A list of products:");

foreach (Product product in Products)
{
    hf
        .Div()
            .H2($"Product: {product.Name}")._H2()
            .Div($"Price: {product.Price}").Css("text-green-500")._Div()
            .Button("Add to cart")
                .Css("bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded")
                .Put($"api/cart/{product.Id.ToString()}")._Button()
        ._Div();
}

hf
    .Close()
    .Div()
        .Div($"My Cart: {MyCart.Count} items")
                    
.CloseAll()
            
.Div().Css("flex justify-center h-full space-y-64 bg-gray-100")
    .Div("Footer");

return Content(hf.Render(), "text/html");

```
```html
<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <script src="https://cdn.tailwindcss.com"></script>
        <title>Hello HTMF!</title>
    </head>
    <body>
        <div class="flex flex-row justify-center space-x-64 h-full w-full">
            <div>
                A list of products:
                <div>
                    <h2>Product: P-49e3461c-7ca8-4320-9475-5875e1f15977</h2>
                    <div class="text-green-500">Price: 133</div>
                    <button class="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded" onclick="putData('api/cart/b63a0a05-7678-41fc-b223-4346eb8d8d1e', 'id-a7917bea-fad8-441e-9ae9-c56994ebc142')">Add to cart</button>
                </div>
            </div>
            <div>
                <div>My Cart: 0 items</div>
            </div>
        </div>
        <div class="flex justify-center h-full space-y-64 bg-gray-100">
            <div>Footer</div>
        </div>
    </body>
</html>
```

# Builder example: Is it improvable from the original?

```csharp
var hf = new Htmf("https://localhost:7031")
string myCartTemplateId = "my-cart-template-id";
foreach (Product product in Products)
{
    // original
    hf
        .Div("Product").Css("text-red-500")
            .H2($"Name: {product.Name}")._H2()
            .Div($"Price: {product.Price}").Css("text-green-500")
                .Button("Add to cart").Css("bg-blue-500 font-bold py-2 px-4 rounded")
                    .Put($"/api/items/products/{product.Id}")
                    .Target(myCartTemplateId)
                ._Button()
            ._Div()
        ._Div();

    // what about arrow functions?
    hf
        .Div("Product", (div) => {
            return div.Css("text-red-500").
                H2($"Product: {product.Name}").
                Div((div) => 
                    return div.Text($"Price: {product.Price}").Css("text-green-500")
                        Button("Add to cart").Css("bg-blue-500 font-bold py-2 px-4 rounded")
                            .Put($"/api/items/products/{product.Id}")
                            .Target(myCartTemplateId)
                )
            }
        );

    // remove return
    hf
        .Div("Product", (div) => div.Css("text-red-500").
            H2($"Product: {product.Name}").
            Div((div) => div.Text($"Price: {product.Price}").Css("text-green-500").
                Button("Add to cart").Css("bg-blue-500 font-bold py-2 px-4 rounded")
                    .Put($"/api/items/products/{product.Id}")
                    .Target(myCartTemplateId)
            )
        );

    // what if we only allowed arrow functions in element functions?
    hf
        .Div((div) => div.
            H2($"Product: {product.Name}").
            Div((div) => div.
                Button("Add to cart")
                    .Css("bg-blue-500 font-bold py-2 px-4 rounded")
                    .Put($"/api/items/products/{product.Id}")
                    .Target(myCartTemplateId)
            ).Text($"Price: {product.Price}").Css("text-green-500")
        ).Text("Product").Css("text-red-500");

    // what if element functions were recognized at top level?
    hf
        .Div(
            H2($"Product: {product.Name}").
            Div(
                Button("Add to cart")
                    .Css("bg-blue-500 font-bold py-2 px-4 rounded")
                    .Put($"/api/items/products/{product.Id}")
                    .Target(myCartTemplateId)
            ).Text($"Price: {product.Price}").Css("text-green-500")
        ).Text("Product").Css("text-red-500");

    // can we improve .Text()?
    hf
        .Div(
            Text("Product").Css("text-red-500").
            H2(Text($"Product: {product.Name}")).
            Div(
                Text($"Price: {product.Price}").
                Button(
                    Text("Add to cart")
                    .Css("bg-blue-500 font-bold py-2 px-4 rounded")
                    .Put($"/api/items/products/{product.Id}")
                    .Target(myCartTemplateId)
                )
            )
        );

    // can we improve .Css()?
    hf
        .Div("Product", "text-red-500",
            H2($"Product: {product.Name}").
            Div($"Price: {product.Price}", "text-green-500",
                Button(
                    Text("Add to cart")
                    .Css("bg-blue-500 font-bold py-2 px-4 rounded")
                    .Put($"/api/items/products/{product.Id}")
                    .Target(myCartTemplateId)
                )
            )
        );
    
    // what if .Css is at the end?
    hf
        .Div("Product",
            H2($"Product: {product.Name}").
            Div($"Price: {product.Price}",
                Button("Add to cart")
                .Css("bg-blue-500 font-bold py-2 px-4 rounded") // #
                .Put($"/api/items/products/{product.Id}")
                .Target(myCartTemplateId)
            ).Css("text-green-500")
        ).Css("text-red-500");

    // original -- close only when it is important?
    hf
        .Div("Product").Css("text-red-500")
            .H2($"Name: {product.Name}")._H2()
            .Div($"Price: {product.Price}").Css("text-green-500")
                .Button("Add to cart").Css("bg-blue-500 font-bold py-2 px-4 rounded")
                    .Put($"/api/items/products/{product.Id}")
                    .Target(myCartTemplateId)
                ._Button()
            ._Div()
        ._Div();

    // -->
    hf
        .Div("Product").Css("text-red-500")
            .H2($"Name: {product.Name}") // <h2>Name: Shoe</h2>
            .Div($"Price: {product.Price}").Css("text-green-500")
                .Button("Add to cart").Css("bg-blue-500 font-bold py-2 px-4 rounded")
                    .Put($"/api/items/products/{product.Id}")
                    .Target(myCartTemplateId)
                //.Close() // not needed as ._Div() is present
            ._Div()
        ._Div();

}
```