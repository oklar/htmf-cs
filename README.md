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
                    <button class="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded" onclick="putData('https://localhost:7031/api/cart/b63a0a05-7678-41fc-b223-4346eb8d8d1e', 'id-a7917bea-fad8-441e-9ae9-c56994ebc142')">Add to cart</button>
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
