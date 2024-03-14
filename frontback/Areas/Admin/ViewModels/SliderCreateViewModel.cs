namespace frontback.Areas.Admin.ViewModels
{
    public class SliderCreateViewModel
    {
        public int Offer { get; set; }

        public string Tittle { get; set; }

        public string Description { get; set; }
        public IFormFile File { get; set; }
    }
}
