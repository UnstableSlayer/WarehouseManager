using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.HttpClientHelper.BrandHttpServices.Commands;

namespace WarehouseManager.HttpClientHelper.BrandHttpServices
{
    public class BrandService
    {
        private HttpClientHelper _httpHelper { get; set; }
        private IOptions<Options> _options { get; set; }
        public BrandService(HttpClientHelper httpHelper, IOptions<Options> options)
        {
            _httpHelper = httpHelper;
            _options = options;
        }

        public async Task<IEnumerable<Brand>> GetAll()
        {
            var result = await _httpHelper.Get<IEnumerable<Brand>>($"v1/Brands/");
            return result;
        }

        public async Task<Brand> CreateBrand(CreateBrandCommand accountentTree)
        {
            var result = await _httpHelper.Post<Brand>($"v1/Brands/", accountentTree);
            return result;
        }

    }
}
