using CookBook.Models;
using CookBook.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookBook.Repository.Interface
{
    public interface ICookBookRepository
    {
        Task<List<RecipeViewModel>> GetRecipeDetails();
        Recipe AddRecipes(Recipe recipe);
        Task<RecipeDetails> AddRecipeDetails(RecipeDetails recipeDetail);
        Task UpdateRecipe(Recipe recipe);
        Task UpdateRecipeDetails(RecipeDetails recipeDetail);

    }
}
