namespace CookBook.ViewModels
{
    public class RecipeViewModel
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int RecipeDetailId { get; set; }
        public string Ingredients { get; set; }
        public string Process { get; set; }
        public string YouTubeLink { get; set; }
    }
}
