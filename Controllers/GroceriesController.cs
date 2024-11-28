using Microsoft.AspNetCore.Mvc;

using static HtmfExample.MicroWind;

namespace HtmfExample.Controllers
{
    public class Item
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public int TotalPrice => Product.Price * Quantity;
    }

    public class Product
    {
        public Product(string name, string id)
        {
            Id = new Guid(id);
            Name = name;
            Price = (int)Random.Shared.NextInt64(5, 200);
        }

        public Guid Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
    }

    [ApiController]
    [Route("")]
    public class GroceriesController : ControllerBase
    {
        public static Product banana = new Product("Banana", "35965ad7-261c-47fb-adbf-4da74a6c5434");
        public static Product lime = new Product("Lime", "b86c3eef-01cc-4cc1-a409-8c7d304c216f");

        public static List<Product> Products = [
            banana,
            lime,
            new Product("Grapes","3eac00f5-3aa5-4014-90ee-e541ecff3e5b"),
            new Product("Pineapple", "b86c3eef-01cc-4cc1-a409-8c7d304c216f"),
            new Product("Apple", "aba9994a-508a-44cc-b063-8db6ea16cd9c"),
            new Product("Watermelon", "59e90e4f-d6fc-4d57-bd10-40f020cec65b")
        ];

        public static List<Item> Items = [
            new Item
            {
                Product = banana,
                Quantity = 1,
            },
            new Item
            {
                Product = lime,
                Quantity = 2,
            }
        ];

        [HttpGet]
        [Route("example")]
        public ActionResult ExamplePage()
        {
            return Content(new Htmf().Page().Div("Example page").Render(), "text/html");
        }

        [HttpGet]
        [Route("navigate")]
        public ActionResult NavigateExamplePage()
        {
            return Content(new Htmf("https://localhost:7031")
                .Page()
                .TailwindStyle()
                .Div("Click here to navigate to /example")
                .Navigate("/example")
                .Css("bg-blue-500 hover:bg-blue-700")
                .Render(), 
                "text/html"
            );
        }

        [HttpGet]
        [Route("testing")]
        public ActionResult GetItems()
        {
            var b = new Htmf2();
            var result = b
                .H1(b => b.Css("text-red-400")
                    .Div(b => b.Css("text-green-400")
                        .H1("hello").Css("text-blue-500")
                        .Div("world")
                    )
                )
                .Div("yes")
                .Build();

            return Content(
                result, 
                "text/html"
            );
        }

        [HttpGet]
        [Route("template")]
        public ActionResult GetTemplate()
        {
            var b = new Htmf2();
            var result = b
                //.Page("test")
                .CreateTemplate(Items, b => b
                    .Div(b => b
                        .Div(b => b
                            .H1("test312").Css(TextGreen700)
                        )
                    )
                    .DivT(item => $"Amount: {item.Quantity} | Total: {item.TotalPrice} | Name: {item.Product.Name}").Css(TextRed400)
                )
                .H1("hello, world!!").Css(TextLightBlue700);

            return Content(
                result.Build(),
                "text/html"
            );
        }

        [HttpGet]
        public ActionResult Home()
        {
            
            var f = new Htmf("https://localhost:7031")

            .Page("Hello HTMF!")
            //.TailwindStyle()
            
            .Div().Css("flex flex-row justify-center space-x-64 h-full w-full")
                .Div("A list of products:");

            string myCartTemplateId = "my-cart-template-id";
            foreach (Product product in Products)
            {
                f
                    .Div()
                        .H2($"Product: {product.Name}")._H2()
                        .Div($"Price: {product.Price}").Css("text-green-500")._Div()
                        .Button("Add to cart").Css("bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded")
                            .Put($"/api/items/products/{product.Id}")
                                .Target(myCartTemplateId)
                        ._Button()
                    ._Div();
            }

            f
                ._Div()

                .Div()
                    .Div($"My Cart has {Items.Sum(x => x.Quantity)} items")
                        .Template().Id(myCartTemplateId)
                            .Div<Item>(item => $"Amount: {item.Quantity} | Total: {item.TotalPrice} | Name: {item.Product.Name}").Css("text-blue-500")
                            ._Div()
                            .Button("Remove Quantity").Css("bg-red-500 hover:bg-red-700 text-white font-bold py-2 px-4 rounded")
                                .Delete<Item>(item => $"/api/items/{item.Id}/products")
                                    .Target(myCartTemplateId)
                            ._Button()
                        ._Template();

            // SSR
            foreach (Item item in Items)
            {
                f
                        .Div($"Amount: {item.Quantity} | Total: {item.TotalPrice} | Name: {item.Product.Name}").Css("text-blue-500")
                            .ResourceId(item.Id.ToString())
                        ._Div()
                        .Button("Remove Quantity").Css("bg-red-500 hover:bg-red-700 text-white font-bold py-2 px-4 rounded")
                            .Delete($"/api/items/{item.Id}/products")
                                .Target(myCartTemplateId)
                        ._Button();
                // hf.FromTemplate(myCartTemplateId);
            }

            f
            .CloseAll()
            
            .Div().Css("flex justify-center h-64 bg-gray-300")
                .Div("Home Page");

            return Content(f.Render(), "text/html");
        }

        [HttpPut]
        [Route("api/items/products/{productId:guid}")]
        public ActionResult AddToItem(Guid productId)
        {
            Product? product = Products.FirstOrDefault(p => p.Id == productId);

            if (product is null)
            {
                return BadRequest();
            }

            Item? item = Items.FirstOrDefault(x => x.Product.Id == productId);
            if (item is not null)
            {
                item.Quantity++;
            }
            else
            {
                item = new Item
                {
                    Product = product,
                    Quantity = 1,
                };
                
                Items.Add(item);
            }

            return Ok(item);
        }

        [HttpDelete]
        [Route("api/items/{itemsId:guid}/products")]
        public ActionResult RemoveOneQuantityFromItem(Guid itemsId)
        {
            Item? currentItem = Items.FirstOrDefault(x => x.Id == itemsId);
            if (currentItem is not null)
            {
                currentItem.Quantity--;
                if (currentItem.Quantity == 0)
                {
                    currentItem = null;
                    Items = Items.Where(item => item.Id != itemsId).ToList();
                }
            }

            return currentItem is null ? NoContent() : Ok(currentItem);
        }

        [HttpDelete]
        [Route("api/items/{itemsId:guid}")]
        public ActionResult DeleteItem(Guid itemsId)
        {
            Items = Items.Where(item => item.Id != itemsId).ToList();
            return NoContent();
        }
    }
}
