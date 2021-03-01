using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WarehouseManager.HttpClientHelper.ProductHttpServices
{
    public class ProductService
    {
        private HttpClientHelper _httpHelper { get; set; }
        private IOptions<Options> _options { get; set; }
        private ILogger _logger { get; set; }

        public ProductService(HttpClientHelper httpHelper, IOptions<Options> options, ILogger<ProductService> logger)
        {
            _httpHelper = httpHelper;
            _options = options;
            _logger = logger;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            _logger.LogInformation("ProductService GetAll Called");
            try
            {
                var result = await _httpHelper.Get<IEnumerable<Product>>($"/Product/");
                return result;
            }
            catch (Exception x)
            {
                _logger.LogError(x.Message);
                throw;
            }
        }

        public async Task<CreateProductCommand> CreateAccountentTree(CreateProductCommand product)
        {
            _logger.LogInformation("AccountentTreeService CreateAccountentTree Called");
            try
            {
                var result = await _httpHelper.Post<CreateProductCommand>($"v1/AccountentTrees/", product);
                return result;
            }
            catch (Exception x)
            {
                _logger.LogError(x.Message);
                throw;
            }
        }
    }
}
