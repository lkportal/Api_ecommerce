using WantWeb.Domain.Products.Products;

namespace WantWeb.Domain.DProducts;

public class Products:Entity {

    public string Name { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    public bool HasStock { get; set; }  



}
