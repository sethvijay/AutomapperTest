using Domain;

namespace Automapper.UI.Services
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> productList=new List<Product>()
        {
            new Product { ProductId = 1, ProductName = "p1", DistributionCentreId = 1, DistributionCentreName = "d1", DCProductCode = "001", FriendlyName = "f1", SupplierName = "S1", FieldName = "F", FieldNewName = "FN1", FieldOldName = "FO1", FieldOldUOM = "Fog", FieldNewUOM = "", PurchaseUnit = "pu1", ItemSize = "cartoon", ItemsPerPack = 10, PacksPerCarton = 5, RRUom = "gm", SCOldUom = string.Empty, SCNewUom = string.Empty, CreatedDate = DateTime.Now, AcceptedDate = DateTime.Now, MajorCategoryName = string.Empty, MinorCategoryName = string.Empty, KeyIngredient = string.Empty, ParentProduct = string.Empty, ProductCategoryName = string.Empty, Count = 1,MasterRecipeCount=10,MyRecipeCount=3 },
            new Product { ProductId = 1, ProductName = "p2", DistributionCentreId = 1, DistributionCentreName = "d2", DCProductCode = "002", FriendlyName = "f1", SupplierName = "S1", FieldName = "F", FieldNewName = "FN1", FieldOldName = "FO1", FieldOldUOM = "Fog", FieldNewUOM = "", PurchaseUnit = "pu1", ItemSize = "cartoon", ItemsPerPack = 10, PacksPerCarton = 5, RRUom = "gm", SCOldUom = string.Empty, SCNewUom = string.Empty, CreatedDate = DateTime.Now, AcceptedDate = DateTime.Now, MajorCategoryName = string.Empty, MinorCategoryName = string.Empty, KeyIngredient = string.Empty, ParentProduct = string.Empty, ProductCategoryName = string.Empty, Count = 1,MasterRecipeCount=10,MyRecipeCount=3 },
            new Product { ProductId = 1, ProductName = "p3", DistributionCentreId = 1, DistributionCentreName = "d3", DCProductCode = "003", FriendlyName = "f1", SupplierName = "S1", FieldName = "F", FieldNewName = "FN1", FieldOldName = "FO1", FieldOldUOM = "Fog", FieldNewUOM = "", PurchaseUnit = "pu1", ItemSize = "cartoon", ItemsPerPack = 10, PacksPerCarton = 5, RRUom = "gm", SCOldUom = string.Empty, SCNewUom = string.Empty, CreatedDate = DateTime.Now, AcceptedDate = DateTime.Now, MajorCategoryName = string.Empty, MinorCategoryName = string.Empty, KeyIngredient = string.Empty, ParentProduct = string.Empty, ProductCategoryName = string.Empty, Count = 1,MasterRecipeCount=10,MyRecipeCount=3 },
            new Product { ProductId = 1, ProductName = "p4", DistributionCentreId = 1, DistributionCentreName = "d4", DCProductCode = "004", FriendlyName = "f1", SupplierName = "S1", FieldName = "F", FieldNewName = "FN1", FieldOldName = "FO1", FieldOldUOM = "Fog", FieldNewUOM = "", PurchaseUnit = "pu1", ItemSize = "cartoon", ItemsPerPack = 10, PacksPerCarton = 5, RRUom = "gm", SCOldUom = string.Empty, SCNewUom = string.Empty, CreatedDate = DateTime.Now, AcceptedDate = DateTime.Now, MajorCategoryName = string.Empty, MinorCategoryName = string.Empty, KeyIngredient = string.Empty, ParentProduct = string.Empty, ProductCategoryName = string.Empty, Count = 1,MasterRecipeCount=10,MyRecipeCount=3 },
            new Product { ProductId = 1, ProductName = "p5", DistributionCentreId = 1, DistributionCentreName = "d5", DCProductCode = "005", FriendlyName = "f1", SupplierName = "S1", FieldName = "F", FieldNewName = "FN1", FieldOldName = "FO1", FieldOldUOM = "Fog", FieldNewUOM = "", PurchaseUnit = "pu1", ItemSize = "cartoon", ItemsPerPack = 10, PacksPerCarton = 5, RRUom = "gm", SCOldUom = string.Empty, SCNewUom = string.Empty, CreatedDate = DateTime.Now, AcceptedDate = DateTime.Now, MajorCategoryName = string.Empty, MinorCategoryName = string.Empty, KeyIngredient = string.Empty, ParentProduct = string.Empty, ProductCategoryName = string.Empty, Count = 1,MasterRecipeCount=10,MyRecipeCount=3 },
        };
public List<Product> GetAllProducts() {
            return productList;
        }
        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Product UpdateExistingProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
