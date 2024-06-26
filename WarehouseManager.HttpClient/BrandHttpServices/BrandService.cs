﻿using Microsoft.Extensions.Logging;
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
        private ILogger _logger { get; set; }

        public BrandService(HttpClientHelper httpHelper, IOptions<Options> options, ILogger<BrandService> logger)
        {
            _httpHelper = httpHelper;
            _options = options;
            _logger = logger;
        }

        public async Task<IEnumerable<Brand>> GetAll()
        {
            _logger.LogInformation("BrandService GetAll Called");
            try
            {
                var result = await _httpHelper.Get<IEnumerable<Brand>>($"v1/Brands/");
                return result;
            }
            catch (Exception x)
            {
                _logger.LogError(x.Message);
                throw;
            }
        }

        public async Task<Brand> CreateBrand(CreateBrandCommand accountentTree)
        {
            _logger.LogInformation("BrandService CreateBrand Called");
            try
            {
                var result = await _httpHelper.Post<Brand>($"v1/Brands/", accountentTree);
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
