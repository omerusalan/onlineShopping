﻿using eTicaretSitesi.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTicaretSitesi.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{

		private readonly IProductService _productService;
		public ProductController(IProductService productService) 
		{
			_productService = productService;
		}	
		
		
		[HttpGet]
		public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
		{
			var result = await _productService.GetProductAsync();
			return Ok(result);

		}
	}
}
