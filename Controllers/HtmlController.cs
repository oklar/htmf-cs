using HtmfExample;
using Microsoft.AspNetCore.Mvc;

namespace HtmfExample.Controllers
{
    public class Item
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public int Price { get; set; }
    }

    public class Product
    {
        public Product(string id)
        {
            Id = new Guid(id);
            Tags = [];
            Name = $"P-{Id}";
            Price = (int)Random.Shared.NextInt64(5, 200);
        }

        public Guid Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public List<Tag> Tags { get; set; }
    }

    public class Tag()
    {
        public string Text { get; set; }
    }

    [ApiController]
    [Route("")]
    public class HtmlController : ControllerBase
    {

        public static List<Product> Products = [
            new Product("35965ad7-261c-47fb-adbf-4da74a6c5434"),
            new Product("3eac00f5-3aa5-4014-90ee-e541ecff3e5b"),
            new Product("b86c3eef-01cc-4cc1-a409-8c7d304c216f"),
            new Product("56789640-1723-4a46-9c2d-5ccd3958afed"),
            new Product("aba9994a-508a-44cc-b063-8db6ea16cd9c"),
            new Product("59e90e4f-d6fc-4d57-bd10-40f020cec65b")
        ];

        public static List<Item> MyCartItems = [];

        [HttpGet]
        public ActionResult Home()
        {
            var hf = new Htmf()

            .Page("Hello HTMF!")
            .Script("https://cdn.tailwindcss.com")
            
            .Div().Css("flex flex-row justify-center space-x-64 h-full w-full")
                .Div("A list of products:");

            var target = Guid.NewGuid().ToString();
            foreach (Product product in Products)
            {
                var h2Id = Guid.NewGuid().ToString();
                var pId = Guid.NewGuid().ToString();
                
                hf
                    .Div()
                        .H2($"Product: {product.Name}").Id(h2Id)._H2()
                        .Div($"Price: {product.Price}").Id(pId).Css("text-green-500")._Div()
                        .Button("Add to cart").Css("bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded")
                            .Put($"https://localhost:7031/api/my-cart-products/{product.Id}")
                                .Target(target)
                        ._Button()
                    ._Div();
            }

            hf
                ._Div()

                .Div()
                    .Div($"My Cart: {MyCartItems.Count} items")
                        .Div<Item>(item => $"Amount: {item.Quantity} | Price: {item.Product.Price} | Name: {item.Product.Name}").Css("text-blue-500").Id(target)._Div().Close();

            foreach (Item item in MyCartItems)
            {
                hf
                        .Div($"Amount: {item.Quantity} | Price: {item.Product.Price} | Name: {item.Product.Name}").Css("text-blue-500").Id(target)._Div();
            }

            hf
            .CloseAll()
            
            .Div().Css("flex justify-center h-full space-y-64 bg-gray-100")
                .Div("Footer");

            return Content(hf.Render(), "text/html");
        }

        [HttpPut]
        [Route("api/my-cart-products/{productId:guid}")]
        public ActionResult AddToCart(Guid productId)
        {
            Product? product = Products.FirstOrDefault(p => p.Id == productId);

            if (product is null)
            {
                return BadRequest();
            }

            Item? item = MyCartItems.FirstOrDefault(x => x.Product.Id == productId);
            if (item is not null)
            {
                item.Quantity++;
            }
            else
            {
                item = new Item
                {
                    Product = product,
                    Quantity = 1
                };
                
                MyCartItems.Add(item);
            }

            return Ok(item);
        }
    }


}
