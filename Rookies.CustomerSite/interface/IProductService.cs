using System.Threading;
using System.Threading.Tasks;
using Rookies.ShareClassdLibrary;
using Rookies.ShareClassdLibrary.Dto;
using Rookies.ShareClassdLibrary.Dto.Product;

public interface IProductService
{
    Task<PagedResponseDto<ProductDto>> GetProductAsync(ProductCriteriaDto productCriteriaDto);
    Task<ProductDto> GetProductByIdAsync(int id);
    //Task<bool> UpdateProduct(ProductDto product);
}