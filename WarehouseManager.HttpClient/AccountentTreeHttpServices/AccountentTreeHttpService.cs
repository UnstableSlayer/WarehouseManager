using Microsoft.Extensions.Options;
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
        public AccountentTreeHttpService(HttpClientHelper httpHelper, IOptions<Options> options)
        {
            _httpHelper = httpHelper;
            _options = options;
        }

        public async Task<IEnumerable<AccountentTree>> GetAll()
        {
            var result = await _httpHelper.Get<IEnumerable<AccountentTree>>($"v1/AccountentTrees/");
            return result;
        }

        public async Task<AccountentTree> CreateAccountentTree(AccountentTree accountentTree)
        {
            var result = await _httpHelper.Post<AccountentTree>($"v1/AccountentTrees/", accountentTree);
            return result;
        }

        public async Task<IEnumerable<AccountentTree>> GetAllDescendants(int Id)
        {
            var result = await _httpHelper.Get<IEnumerable<AccountentTree>>($"v1/AccountentTrees/{Id}");
            return result;
        }
    }
}
