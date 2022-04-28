using CookBook.Services.Interface;
using CookBook.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class CookBookController : ControllerBase
    {
        public CookBookController()
        {

        }
        [HttpGet("GetRecipeDetails")]
        public async Task<List<RecipeViewModel>> GetRecipeDetails([FromServices]ICookBookService cookBookService)
        {
            try
            {
               return await cookBookService.GetRecipeDetails();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost("AddRecipes")]
        public async Task<List<RecipeViewModel>> AddRecipes([FromServices] ICookBookService cookBookService,[FromBody] RecipeViewModel recipe)
        {
            try
            {
                return await cookBookService.AddRecipes(recipe);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
