using System.Linq;
using WarehouseManager.Common.Exceptions;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;
using WarehouseManager.Service.Products.Commands;

namespace WarehouseManager.Service.Products
{
    public class ProductService
    {
        private readonly IRepository<Product> _productrepository;
        public ProductService(IRepository<Product> productrepository)
        {
            _productrepository = productrepository;
        }
        
        public void CreateProduct(CreateProductCommand command)
        {
            CreateProductCommandValidator validator = new CreateProductCommandValidator();
            var results = validator.Validate(command);
            if (!results.IsValid)
            {
                throw new CommandValidationException(results.Errors.Select(x => new CommandValidationError
                {
                    ErrorCode = x.ErrorCode,
                    ErrorMessage = x.ErrorMessage,
                    PropertyName = x.PropertyName
                }));
            }
            _productrepository.Insert(new Product
            {
                Name = command.Name,
                RetailPrice = command.Price,
                Type = command.ProductType,
                Id = command.WarehouseId
            });
        }
    }
}
