﻿
using AutoMapper;
using WebApplicationAPI.DTO;
using WebApplicationAPI.Model;
using WebApplicationAPI.Repository.Product;

namespace WebApplicationAPI.Repository.Product
{
    public class ProductService : IProductService
    {
        // repository 
        public IMapper _mapper { get; set; }
        public IProductRepository Repository;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            Repository = productRepository;    
            _mapper = mapper;
        }

        public string createProduct(CreateProductCategoryDTO Productdto)
        {
            // logic
            // create product with new category
            // DTO with relation using automapper to table
            var product = _mapper.Map<Model.Product>(Productdto);
            
           return  Repository.create(product);

        }

        public List<ProductResponseDTO> getAllProducts()
        {
            var products = Repository.getAll();
            var respose = _mapper.Map<List<ProductResponseDTO>>(products);
            return respose;
        }

        public ProductResponseDTO updateProduct(int id, UpdateProductDTO dto)
        {
            var productmap = _mapper.Map<Model.Product>(dto);
            var updatedProduct = Repository.update(id, productmap);
            var response = _mapper.Map<ProductResponseDTO>(updatedProduct);
            return response;
        }

        public string deleteProduct(int id)
        {
            return Repository.delete(id);
        }
    }
}
