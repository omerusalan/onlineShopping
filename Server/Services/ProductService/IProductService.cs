﻿namespace eTicaretSitesi.Server.Services.ProductService
{
	public interface IProductService
	{
		Task<ServiceResponse<List<Product>>> GetProductAsync();
	}
}
