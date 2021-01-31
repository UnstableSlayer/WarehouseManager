using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Data;
using WarehouseManager.Data.BaseEntities;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Repository.BaseRepositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(WarehouseManagerDBContext prdContext) : base(prdContext) { }

        public Product GetByAmount(float amountToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.Amount == amountToFind);
        }

        public Product GetByBarCode(string barCodeToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.Barcode == barCodeToFind);
        }

        public Product GetByBoxCode(string boxCodeToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.Boxcode == boxCodeToFind);
        }

        public Product GetByBrand(Brand brandToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.Brand == brandToFind);
        }

        public Product GetByCategory(ProductCategory categoryToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.Category == categoryToFind);
        }

        public Product GetByCode(string codeToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.Code == codeToFind);
        }

        public Product GetByColor(string colorToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.Color == colorToFind);
        }

        public Product GetByEN_Name(string enNameToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.EN_Name == enNameToFind);
        }

        public Product GetByImageURL(string imageURLToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.ImageURL == imageURLToFind);
        }

        public Product GetByManufacturer(Manufacturer manufacturerToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.Manufacturer == manufacturerToFind);
        }

        public Product GetByName(string nameToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.Name == nameToFind);
        }

        public Product GetByProductionCountry(Country productionCountryToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.ProductionCountry == productionCountryToFind);
        }

        public Product GetByProductionPrice(float productionPriceToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.ProductionPrice == productionPriceToFind);
        }

        public Product GetByRetailPrice(float retailPriceToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.RetailPrice == retailPriceToFind);
        }

        public Product GetByType(ProductType typeToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.Type == typeToFind);
        }

        public Product GetByUnit(string unitToFind)
        {
            return _context.Set<Product>().FirstOrDefault(x => x.Unit == unitToFind);
        }
    }
}
