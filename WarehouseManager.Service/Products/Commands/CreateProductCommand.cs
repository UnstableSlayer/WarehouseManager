using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Service.Products.Commands
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
        public int Price { get; set; }
        public int WarehouseId { get; set; }
    }

    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(product => product.Name).NotNull().NotEmpty().Length(0, 50);
            RuleFor(product => product.Price).NotNull().NotEmpty();
            RuleFor(product => product.WarehouseId).NotNull().NotEmpty();
            RuleFor(product => product.ProductType).NotNull().NotEmpty();
        }
    }
}
