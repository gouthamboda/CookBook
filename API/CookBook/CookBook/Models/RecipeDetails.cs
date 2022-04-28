namespace CookBook.Models
{
    public class RecipeDetails
    {
        public int RecipeDetailId { get; set; }
        public int RecipeId { get; set; }
        public string Ingredients { get; set; }
        public string Process { get; set; }
        public string YouTubeLink { get; set; }
    }
}
