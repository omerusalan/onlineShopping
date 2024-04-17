using eTicaretSitesi.Shared;

namespace eTicaretSitesi.Client.Services.ProductService
{
	public interface IProductService
	{
		List<Product> Products { get; set; }
		Task GetProducts();
	}
}
