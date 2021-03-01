using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseManager.HttpClientHelper.ProductHttpServices
{
    public class Product
    {
        public int Code { get; set; }
        public string Barcode { get; set; }
        public string Boxcode { get; set; }
        public string Name { get; set; }
        public string EN_Name { get; set; }
        public string Unit { get; set; }
        public float Amount { get; set; }
        public int? CategoryId { get; set; }
        public int? TypeId { get; set; }
        public string Color { get; set; }
        public int? ProductionCountryId { get; set; }
        public int? ManufacturerId { get; set; }
        public int? BrandId { get; set; }
        public string ImageURL { get; set; }
        public float ProductionPrice { get; set; }
        public float RetailPrice { get; set; }
    }
}
