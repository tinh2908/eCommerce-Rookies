using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Rookies.ShareClassdLibrary.Dto;
using Rookies.ShareClassdLibrary.Dto.Product;
using Rookies.ShareClassdLibrary.Dto.ProductbyCate;

public interface IProductService
{
    Task<PagedResponseDto<ProductDto>> GetProductAsync(ProductCriteriaDto productCriteriaDto);
    Task<ProductDto> GetProductByIdAsync(int id);
    Task<IList<ProductbyCateDto>> GetProductByCateAsync(int cateid);
    //Task<bool> UpdateProduct(ProductDto product);
}