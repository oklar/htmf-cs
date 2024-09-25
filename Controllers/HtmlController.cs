using HtmfExample;
using Microsoft.AspNetCore.Mvc;

namespace HtmfExample.Controllers
{
    [ApiController]
    [Route("")]
    public class HtmlController : ControllerBase
    {
        public List<Product> Products = [
            new Product(),
            new Product(),
            new Product(),
            new Product(),
            new Product(),
            new Product()
        ];

        public List<Item> MyCart = [];


        [HttpGet]
        public ActionResult Home()
        {
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
                            .Put($"https://localhost:7031/api/cart/{product.Id.ToString()}")._Button()
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
        }

        [HttpPut]
        [Route("api/cart/{productId:guid}")]
        public ActionResult AddToCart(Guid productId)
        {
            Product? product = Products.FirstOrDefault(p => p.Id == productId);

            if (product is null)
            {
                return BadRequest();
            }

            Item? item = MyCart.FirstOrDefault(x => x.Product.Id == productId);
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
                
                MyCart.Add(item);
            }

            return Ok(item);
        }
    }

    public class Item
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }

    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
            Tags = new List<Tag>();
            Name = $"P-{Guid.NewGuid()}";
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
}
