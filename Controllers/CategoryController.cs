using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using testeApi.Models;

namespace testeApi.Controllers
{
    public class CategoryController : Controller {

        [HttpGet("v1/categories")]
        public IActionResult allCategories() {
            return Ok(
                new List<Category> {
                    new Category {
                        Name = "Categopry"
                    },
                    new Category {
                        Name = "Categopry 2"
                    }
                }
            );
        }

        [HttpPost("v1/categories")]
        public IActionResult createCategory() {
            return Ok();
        }
    }
}