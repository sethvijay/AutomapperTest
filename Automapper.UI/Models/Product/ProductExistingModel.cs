namespace Automapper.UI.Models.Product
{
    public class ProductExistingModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string DCProductCode { get; set; } = string.Empty;
        public int DistributionCentreId { get; set; }
        public string DistributionCentreName { get; set; } = string.Empty;
        public string FriendlyName { get; set; } = string.Empty;
        public string SupplierName { get; set; } = string.Empty;
        public string FieldOldName { get; set; } = string.Empty;
        public string FieldNewName { get; set; } = string.Empty;
        public string FieldOldUOM { get; set; } = string.Empty;
        public string FieldNewUOM { get; set; } = string.Empty;
        public string PurchaseUnit { get; set; } = string.Empty;
        public string ItemSize { get; set; } = string.Empty;
        public int ItemsPerPack { get; set; }
        public int PacksPerCarton { get; set; }
        public string RRUom { get; set; } = string.Empty;
        public string SCOldUom { get; set; } = string.Empty;
        public decimal SCOldUomCost { get; set; }
        public string SCNewUom { get; set; } = string.Empty;
        public DateTime? CreatedDate { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public string MajorCategoryName { get; set; } = string.Empty;
        public string MinorCategoryName { get; set; } = string.Empty;
        public string KeyIngredient { get; set; } = string.Empty;
        public string ParentProduct { get; set; } = string.Empty;
        public string ProductCategoryName { get; set; } = string.Empty;
        public string FieldName { get; set; } = string.Empty;
        public int Count { get; set; }
    }
}
