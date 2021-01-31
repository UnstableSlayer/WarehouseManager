using System.Collections.Generic;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;

namespace WarehouseManager.Repository.BaseRepositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetByCode(string codeToFind);
        Product GetByBarCode(string barCodeToFind);
        Product GetByBoxCode(string boxCodeToFind);
        Product GetByName(string nameToFind);
        Product GetByEN_Name(string enNameToFind);
        Product GetByUnit(string unitToFind);
        Product GetByAmount(float amountToFind);
        Product GetByCategory(ProductCategory categoryToFind);
        Product GetByType(ProductType typeToFind);
        Product GetByColor(string colorToFind);
        Product GetByProductionCountry(Country productionCountryToFind);
        Product GetByManufacturer(Manufacturer manufacturerToFind);
        Product GetByBrand(Brand brandToFind);
        Product GetByImageURL(string imageURLToFind);
        Product GetByProductionPrice(float productionPriceToFind);
        Product GetByRetailPrice(float retailPriceToFind);
    }
}
