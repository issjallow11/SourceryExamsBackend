using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseGeneration.Data.Services;
using DatabaseGeneration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseGeneration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult index()
        {
            try
            {
                return Ok(_service.GetAll());
            }catch(Exception e)

            {
                return BadRequest(e.Message);
            }
        }


        [HttpGet]
        public IActionResult GetProduct([FromBody] int id)
        {
            try
            {
                return Ok(_service.GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            try
            {
                _service.AddProduct(product);
                return Ok(new {Success = "Successfully added new product"});
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        [HttpPut]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            try
            {
                _service.UpdateProduct(product);
                return Ok(new {Success = "Successfully updated product"});
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        [HttpDelete]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            try
            {
                _service.DeleteProduct(id);
                return Ok(new {Success = "Successfully deleted product"});
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        
    }
}