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
            return Content(new Htmf().Page().Div("Example page").Build(), "text/html");
        }

        [HttpGet]
        [Route("navigate")]
        public ActionResult NavigateExamplePage()
        {
            return Content(new Htmf()
                .Page()
                .Div("Click here to navigate to /example")
                .Navigate("/example")
                .Build(), 
                "text/html"
            );
        }

        [HttpGet]
        [Route("")]
        public ActionResult Home()
        {
            var b = new Htmf();
            string templateItemsId = "template-items-id";
            var result = b
                .Page("Groceries Shopping")
                .Div(b => b
                    .CreateTemplate(Items, b => b
                        .H1T(item => $"{item.Product.Name}").Css(TextGreen600)
                        .DivT(item => $"Amount: {item.Quantity} | Total: {item.TotalPrice}").Css(TextBlue500)
                        .Button("Remove").Css(TextRed600)
                            .DeleteT(item => $"/api/items/{item.Id}/products")
                                .TargetSelf()
                        .Button("Delete").Css(TextRed800)
                            .DeleteT(item => $"api/items/{item.Id}")
                                .TargetSelf()
                        ,
                        (templateId) => templateItemsId = templateId
                    )
                )
                .Div(b =>
                {
                    b
                    .H1("List of products:");
                    foreach (Product product in Products)
                    {
                        b
                        .Div(b => b
                            .H2($"{product.Name}")
                            .Div($"Price: {product.Price}").Css(TextGreen500)
                            .Button("Add to cart")
                                .Put($"/api/items/products/{product.Id}")
                                    .Target(templateItemsId)
                        );
                    }
                    return b;
                });

            return Content(
                result.Build(),
                "text/html"
            );
        }

        [HttpPut]
        [Route("api/items/products/{productId:guid}")]
        public ActionResult AddToItem(Guid productId)
        {
            Item? item = Items.FirstOrDefault(x => x.Product.Id == productId);
            if (item is null)
            {
                item = new Item
                {
                    Product = Products.Single(p => p.Id == productId),
                    Quantity = 1,
                };

                Items.Add(item);
            }
            else
            {
                item.Quantity++;
            }

            return Ok(item);
        }

        [HttpDelete]
        [Route("api/items/{itemsId:guid}/products")]
        public ActionResult RemoveOneQuantityFromItem(Guid itemsId)
        {
            Item? currentItem = Items.FirstOrDefault(x => x.Id == itemsId);

            if (currentItem is null) { return NoContent(); }

            currentItem.Quantity--;
            if (currentItem.Quantity <= 0)
            {
                Items = Items.Where(item => item.Id != itemsId).ToList();
                return NoContent();
            }

            return Ok(currentItem);
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
