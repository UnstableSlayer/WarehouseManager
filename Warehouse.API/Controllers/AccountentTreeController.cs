using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;
using WarehouseManager.Service.AccountentTrees;
using WarehouseManager.Service.AccountentTrees.Commands;

namespace WarehouseManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountentTreeController : ControllerBase
    {
        private readonly IRepository<AccountentTree> _repository;
        private readonly IAccountentTreeRepository _accountentTreeRepository;
        private readonly AccountentTreeService _accountentTreeService;
        public AccountentTreeController(IRepository<AccountentTree> repository, IAccountentTreeRepository accountentTreeRepository, AccountentTreeService accountentTreeService)
        {
            _repository = repository;
            _accountentTreeRepository = accountentTreeRepository;
            _accountentTreeService = accountentTreeService;
        }

        [HttpPost]
        public ActionResult<AccountentTree> CreateAccountentTree(CreateAccountentTreeCommand command)
        {
            _accountentTreeService.CreateAccountentTree(command);
            return Ok(command);
        }

        [HttpGet]
        public ActionResult<IEnumerable<AccountentTree>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{Id:int}")]
        public ActionResult<AccountentTree> GetById(int Id)
        {
            var accountentTreeToFind = _repository.GetById(Id);
            if (accountentTreeToFind == null)
            {
                return NotFound();
            }

            return Ok(accountentTreeToFind);
        }

        [HttpGet("{Code}")]
        public ActionResult<AccountentTree> GetByCode(int Code)
        {
            var accountentTreeToFind = _accountentTreeRepository.GetByCode(Code);
            if (accountentTreeToFind == null)
            {
                return NotFound();
            }


            return Ok(accountentTreeToFind);
        }

        [HttpGet("{FullCode}")]
        public ActionResult<AccountentTree> GetByFullCode(string FullCode)
        {
            var accountentTreeToFind = _accountentTreeRepository.GetByFullCode(FullCode);
            if (accountentTreeToFind == null)
            {
                return NotFound();
            }


            return Ok(accountentTreeToFind);
        }

        [HttpPut("{Id:int}")]
        public ActionResult UpdateAccountentTreeById(int Id, UpdateAccountentTreeCommand command)
        {
            var accountentTreeToUpdate = _accountentTreeRepository.GetById(Id);
            if (accountentTreeToUpdate == null)
            {
                return NotFound();
            }

            _accountentTreeService.UpdateAccountentTree(command);

            return Ok();
        }

        [HttpPut("{Code}")]
        public ActionResult UpdateAccountentTreeByCode(int Code, UpdateAccountentTreeCommand command)
        {
            var accountentTreeToUpdate = _accountentTreeRepository.GetByCode(Code);
            if (accountentTreeToUpdate == null)
            {
                return NotFound();
            }

            _accountentTreeService.UpdateAccountentTree(command);

            return Ok();
        }

        [HttpPut("{FullCode}")]
        public ActionResult UpdateAccountentTreeByFullCode(string FullCode, UpdateAccountentTreeCommand command)
        {
            var accountentTreeToUpdate = _accountentTreeRepository.GetByFullCode(FullCode);
            if (accountentTreeToUpdate == null)
            {
                return NotFound();
            }

            _accountentTreeService.UpdateAccountentTree(command);

            return Ok();
        }

        [HttpDelete("{Id:int}")]
        public ActionResult DeleteAccountentTreeById(int Id)
        {
            var accountentTreeToDelete = _accountentTreeRepository.GetById(Id);
            if (accountentTreeToDelete == null)
            {
                return NotFound();
            }
            _repository.Delete(accountentTreeToDelete.Id);

            return Ok();
        }

        [HttpDelete("{Code}")]
        public ActionResult DeleteAccountentTreeByCode(int Code)
        {
            var accountentTreeToDelete = _accountentTreeRepository.GetByCode(Code);
            if (accountentTreeToDelete == null)
            {
                return NotFound();
            }
            _repository.Delete(accountentTreeToDelete.Id);

            return Ok();
        }

        [HttpDelete("{FullCode}")]
        public ActionResult DeleteAccountentTreeByFullCode(string FullCode)
        {
            var accountentTreeToDelete = _accountentTreeRepository.GetByFullCode(FullCode);
            if (accountentTreeToDelete == null)
            {
                return NotFound();
            }
            _repository.Delete(accountentTreeToDelete.Id);

            return Ok();
        }
    }
}
