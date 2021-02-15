using FluentValidation;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Service.Products.Commands
{
    public class UpdateProductCommand
    {
        public int Code { get; set; }
        public string Barcode { get; set; }
        public string Boxcode { get; set; }
        public string Name { get; set; }
        public string EN_Name { get; set; }
        public string Unit { get; set; }
        public float Amount { get; set; }
        public ProductCategory Category { get; set; }
        public ProductType Type { get; set; }
        public string Color { get; set; }
        public Country ProductionCountry { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Brand Brand { get; set; }
        public string ImageURL { get; set; }
        public float ProductionPrice { get; set; }
        public float RetailPrice { get; set; }
    }

    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(product => product.Code).GreaterThan(0);
            RuleFor(product => product.Barcode).NotNull().NotEmpty().Length(1, 32);
            RuleFor(product => product.Boxcode).NotNull().NotEmpty().Length(1, 32);
            RuleFor(product => product.Name).NotNull().NotEmpty().Length(0, 50);
            RuleFor(product => product.EN_Name).NotNull().NotEmpty().Length(0, 50);
            RuleFor(product => product.Amount).GreaterThanOrEqualTo(0);
            RuleFor(product => product.ProductionPrice).GreaterThanOrEqualTo(0);
            RuleFor(product => product.RetailPrice).NotNull().NotEmpty();
        }
    }
}
