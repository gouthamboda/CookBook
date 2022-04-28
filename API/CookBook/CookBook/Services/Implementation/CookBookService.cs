using CookBook.Models;
using CookBook.Repository.Interface;
using CookBook.Services.Interface;
using CookBook.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookBook.Services.Implementation
{
    public class CookBookService : ICookBookService
    {
        private readonly ICookBookRepository _cookBookRepository;
        public CookBookService(ICookBookRepository cookBookRepository)
        {
            _cookBookRepository = cookBookRepository;
        }

        public async Task<List<RecipeViewModel>> GetRecipeDetails()
        {
            try
            {
                return await _cookBookRepository.GetRecipeDetails();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<RecipeViewModel>> AddRecipes(RecipeViewModel recipeViewModel)
        {
            try
            {
                Recipe recipe=new Recipe();
                RecipeDetails recipeDetail = new RecipeDetails();
                recipe.Title = recipeViewModel.Title;
                recipe.Description = recipeViewModel.Description;
                recipeDetail.Ingredients = recipeViewModel.Ingredients;
                recipeDetail.Process = recipeViewModel.Process;
                recipeDetail.YouTubeLink = recipeViewModel.YouTubeLink;
                if (recipeViewModel.RecipeId > 0)
                {
                    recipe.RecipeId = recipeViewModel.RecipeId;
                    await _cookBookRepository.UpdateRecipe(recipe);
                    recipeDetail.RecipeDetailId= recipeViewModel.RecipeDetailId;
                    await _cookBookRepository.UpdateRecipeDetails(recipeDetail);
                }
                else
                {
                    recipe = _cookBookRepository.AddRecipes(recipe);
                    recipeDetail.RecipeId = recipe.RecipeId;
                }
                return await GetRecipeDetails();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
