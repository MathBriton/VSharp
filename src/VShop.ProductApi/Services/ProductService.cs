using AutoMapper;
using VShop.ProductApi.DTOs;
using VShop.ProductApi.Models;
using VShop.ProductApi.Repositories;

namespace VShop.ProductApi.Services;

public class ProductService : IProductService
{
    private readonly IMapper _mapper;
    private IProductRepository _productRepository;

    public ProductService(IMiddleware mapper, IProductRepository productRepository)
    {
        _mapper = mapper;
        _productRepository = productRepository;
    }

    public async Task<IEnumearable<ProductDTO>> GetProducts()
    {
        var productEntity = await _productRepository.GetAll();
        return _mapper.Map<IEnumearable<ProductDTO>>(productsEntity);
    }

    public async Task<ProductDTO> GetProductById(int id)
    {
        var productEntity = await _productRepository.GetById(id);
        return _mapper.Map<ProductDTO>(productEntity);
    }

    public async Task AddProduct(ProductDTO productDto)
    {
        var productEntity = await _productRepository.GetById(id);
        return _mapper.Map<ProductDTO>(productEntity);
    }

    public async Task UpdateProduct (ProductDTO productDto)
    {
        var categoryEntity = _mapper.Map<Product>
        (productDto);
        await _productRepository.Update(categoryEntity);
    }

    public async Task RemoveProduct(int id)
    {
        var productEntity = await _productRepository.GetById(id);
        await _productRepository.Delete(productEntity.Id);
    }
}