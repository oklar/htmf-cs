using Microsoft.AspNetCore.Mvc;

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
            Tags = [];
            Name = name;
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
    public class GroceriesController : ControllerBase
    {

        public static List<Product> Products = [
            new Product("Banana", "35965ad7-261c-47fb-adbf-4da74a6c5434"),
            new Product("Grapes","3eac00f5-3aa5-4014-90ee-e541ecff3e5b"),
            new Product("Pineapple", "b86c3eef-01cc-4cc1-a409-8c7d304c216f"),
            new Product("Lime", "56789640-1723-4a46-9c2d-5ccd3958afed"),
            new Product("Apple", "aba9994a-508a-44cc-b063-8db6ea16cd9c"),
            new Product("Watermelon", "59e90e4f-d6fc-4d57-bd10-40f020cec65b")
        ];

        public static List<Item> Items = [];

        [HttpGet]
        public ActionResult Home()
        {
            var hf = new Htmf("https://localhost:7031")

            .Page("Hello HTMF!")
            .TailwindStyle()
            
            .Div().Css("flex flex-row justify-center space-x-64 h-full w-full")
                .Div("A list of products:");

            string myCartTemplateId = "my-cart-template-id";
            foreach (Product product in Products)
            {
                hf
                    .Div()
                        .H2($"Product: {product.Name}")._H2()
                        .Div($"Price: {product.Price}").Css("text-green-500")._Div()
                        .Button("Add to cart").Css("bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded")
                            .Put($"/api/items/products/{product.Id}")
                                .Target(myCartTemplateId)
                        ._Button()
                    ._Div();
            }

            hf
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
                hf
                        .Div($"Amount: {item.Quantity} | Total: {item.TotalPrice} | Name: {item.Product.Name}").Css("text-blue-500")
                            .ResourceId(item.Id.ToString())
                        ._Div()
                        .Button("Remove Quantity").Css("bg-red-500 hover:bg-red-700 text-white font-bold py-2 px-4 rounded")
                            .Delete($"/api/items/{item.Id}/products")
                                .Target(myCartTemplateId)
                        ._Button();
                // hf.FromTemplate(myCartTemplateId);
            }

            hf
            .CloseAll()
            
            .Div().Css("flex justify-center h-64 bg-gray-300")
                .Div("Home Page");

            return Content(hf.Render(), "text/html");
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
