using CookBook.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookBook.Services.Interface
{
    public interface ICookBookService
    {
        Task<List<RecipeViewModel>> GetRecipeDetails();
        Task<List<RecipeViewModel>> AddRecipes(RecipeViewModel recipeViewModel);
    }
}
