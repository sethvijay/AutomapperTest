namespace Automapper.UI.Models.Product
{
    public class ProductExistingUpdateModel
    {
        public int ProductId { get; set; }
        public string SCNewUOM { get; set; } = string.Empty;
        public string ChangedField { get; set; } = string.Empty;
        public string RRNewUOM { get; set; } = string.Empty;
        public string UpdatedValue { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string DCProductCode { get; set; } = string.Empty;
        public int DistributionCentreId { get; set; }
        public string DistributionCentreName { get; set; } = string.Empty;
        public string FriendlyName { get; set; } = string.Empty;
    }
}
