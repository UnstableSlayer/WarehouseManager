using System.Linq;
using WarehouseManager.Common.Exceptions;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;
using WarehouseManager.Service.Products.Commands;

namespace WarehouseManager.Service.Products
{
    public class ProductService
    {
        private readonly IRepository<Product> _productRepository;
        public ProductService(IRepository<Product> productrepository)
        {
            _productRepository = productrepository;
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
            _productRepository.Insert(new Product
            {
                Code = command.Code,
                Barcode = command.Barcode,
                Boxcode = command.Boxcode,
                Name = command.Name,
                EN_Name = command.EN_Name,
                Unit= command.Unit,
                Amount = command.Amount,
                Category = command.Category,
                Type = command.Type,
                Color = command.Color,
                ProductionCountry = command.ProductionCountry,
                Manufacturer = command.Manufacturer,
                Brand = command.Brand,
                ImageURL = command.ImageURL,
                ProductionPrice = command.ProductionPrice,
                RetailPrice = command.RetailPrice
            });
        }

        public void UpdateProduct(UpdateProductCommand command)
        {
            UpdateProductCommandValidator validator = new UpdateProductCommandValidator();
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
            _productRepository.Update(new Product()
            {
                Code = command.Code,
                Barcode = command.Barcode,
                Boxcode = command.Boxcode,
                Name = command.Name,
                EN_Name = command.EN_Name,
                Unit = command.Unit,
                Amount = command.Amount,
                Category = command.Category,
                Type = command.Type,
                Color = command.Color,
                ProductionCountry = command.ProductionCountry,
                Manufacturer = command.Manufacturer,
                Brand = command.Brand,
                ImageURL = command.ImageURL,
                ProductionPrice = command.ProductionPrice,
                RetailPrice = command.RetailPrice
            });
        }
    }
}
