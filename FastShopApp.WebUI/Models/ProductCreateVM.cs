namespace FastShopApp.WebUI.Models
{
    public class ProductCreateVM
    {
        public string ProductName { get; set; }
        
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }

        //Repoları yapmaya zamanım olmadığı için bunları elle yazıcam. Zaman olsaydı repoları yazıp HttpGet kısmında ViewBag ile çekip comboBoxları doldurabilirdim.
        public string? BrandName { get; set; }
        public string? CategoryName { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
