using CookBook.Models;
using CookBook.Repository.Interface;
using CookBook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBook.Repository.Implementation
{
    public class CookBookRepository : ICookBookRepository
    {
       static List<Recipe> recipes = new List<Recipe>() 
        { 
        new Recipe(){ RecipeId=1,Title="Recipe 1",Description="First Recipe"},
        new Recipe(){ RecipeId=2,Title="Recipe 2",Description="Second Recipe"},
        new Recipe(){ RecipeId=3,Title="Recipe 3",Description="Third Recipe"},
        new Recipe(){ RecipeId=4,Title="Recipe 4",Description="Fourth Recipe"},
        new Recipe(){ RecipeId=5,Title="Recipe 5",Description="Fifth Recipe"}
        };

      static  List<RecipeDetails> recipeDetails=new List<RecipeDetails>()
        { 
        new RecipeDetails(){RecipeDetailId=1,RecipeId=1,Ingredients="Ingredents 1",Process="Process 1",YouTubeLink="youtubelink1" },
        new RecipeDetails(){RecipeDetailId=2,RecipeId=2,Ingredients="Ingredents 2",Process="Process 2",YouTubeLink="youtubelink2" },
        new RecipeDetails(){RecipeDetailId=3,RecipeId=3,Ingredients="Ingredents 3",Process="Process 3",YouTubeLink="youtubelink3" },
        new RecipeDetails(){RecipeDetailId=4,RecipeId=4,Ingredients="Ingredents 4",Process="Process 4",YouTubeLink="youtubelink4" },
        new RecipeDetails(){RecipeDetailId=5,RecipeId=5,Ingredients="Ingredents 5",Process="Process 5",YouTubeLink="youtubelink5" },
        };
        public CookBookRepository()
        {

        }
        public async Task<List<RecipeViewModel>> GetRecipeDetails()
        {
            try
            {
                return  recipes
                        .Join(recipeDetails, rrd => rrd.RecipeId, rd => rd.RecipeId, (rrd, rd) => new { rrd, rd })
                        .Select(s => new RecipeViewModel()
                        {
                            RecipeId = s.rrd.RecipeId,
                            Description = s.rrd.Description,
                            Ingredients = s.rd.Ingredients,
                            Process = s.rd.Process,
                            Title = s.rrd.Title,
                            YouTubeLink = s.rd.YouTubeLink,
                            RecipeDetailId = s.rd.RecipeDetailId
                        }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Recipe AddRecipes(Recipe recipe)
        {
            try
            {
                recipe.RecipeId = recipes.Count + 1;
                recipes.Add(recipe);
                return recipe;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public async Task<RecipeDetails> AddRecipeDetails(RecipeDetails recipeDetail)
        {
            try
            {
                recipeDetail.RecipeDetailId=recipeDetails.Count + 1;
                recipeDetails.Add(recipeDetail);
                return recipeDetail;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public async Task UpdateRecipe(Recipe recipe)
        {
            try
            {
                recipes[recipe.RecipeId-1].Title = recipe.Title;
                recipes[recipe.RecipeId - 1].Description = recipe.Description;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task UpdateRecipeDetails(RecipeDetails recipeDetail)
        {
            try
            {
                recipeDetails[recipeDetail.RecipeDetailId-1].Process=recipeDetail.Process;
                recipeDetails[recipeDetail.RecipeDetailId-1].Ingredients=recipeDetail.Ingredients;
                recipeDetails[recipeDetail.RecipeDetailId-1].YouTubeLink=recipeDetail.YouTubeLink;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
