using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.HttpClientHelper.AccountentTreeServices;

namespace WarehouseManager.HttpClientHelper.AccountentTreeHttpServices
{
    public class AccountentTreeHttpService
    {
        private HttpClientHelper _httpHelper { get; set; }
        private IOptions<Options> _options { get; set; }
        private ILogger _logger { get; set; }

        public AccountentTreeHttpService(HttpClientHelper httpHelper, IOptions<Options> options, ILogger<AccountentTreeHttpService> logger)
        {
            _httpHelper = httpHelper;
            _options = options;
            _logger = logger;
        }

        public async Task<IEnumerable<AccountentTree>> GetAll()
        {
            _logger.LogInformation("AccountentTreeService GetAll Called");
            try
            {
                var result = await _httpHelper.Get<IEnumerable<AccountentTree>>($"/AccountentTree/");
                return result;
            }
            catch (Exception x)
            {
                _logger.LogError(x.Message);
                throw;
            }
        }

        public async Task<CreateAccountentTreeCommand> CreateAccountentTree(CreateAccountentTreeCommand accountentTree)
        {
            _logger.LogInformation("AccountentTreeService CreateAccountentTree Called");
            try
            {
                var result = await _httpHelper.Post<CreateAccountentTreeCommand>($"v1/AccountentTrees/", accountentTree);
                return result;
            }
            catch (Exception x)
            {
                _logger.LogError(x.Message);
                throw;
            }
        }

        public async Task<IEnumerable<AccountentTree>> GetAllDescendants(int Id)
        {
            _logger.LogInformation("AccountentTreeService GetAllDescendant Called");
            try
            {
                var result = await _httpHelper.Get<IEnumerable<AccountentTree>>($"v1/AccountentTrees/{Id}");
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
