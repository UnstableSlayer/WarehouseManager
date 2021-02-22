using System;
using System.Linq;
using WarehouseManager.Common.Exceptions;
using WarehouseManager.Data;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;
using WarehouseManager.Service.AccountentTrees.Commands;

namespace WarehouseManager.Service.AccountentTrees
{
    public class AccountentTreeService
    {
        private readonly IRepository<AccountentTree> _repository;
        private readonly WarehouseManagerDBContext _context;

        public AccountentTreeService(IRepository<AccountentTree> accountentTreeRepository, WarehouseManagerDBContext context)
        {
            _repository = accountentTreeRepository;
            _context = context;
        }

        public void CreateAccountentTree(CreateAccountentTreeCommand command)
        {
            CreateAccountentTreeCommandValidator validator = new CreateAccountentTreeCommandValidator();
            var results = validator.Validate(command);
            if (!results.IsValid)
            {
                throw new CommandValidationException(results.Errors.Select(x => new CommandValidationError
                {
                    ErrorCode = x.ErrorCode,
                    ErrorMessage = x.ErrorMessage,
                    PropertyName = x.PropertyName
                }));
            }

            var parent = _repository.GetById(command.ParentTreeId);
            string fullCode = parent != null ? String.Format($"{parent.FullCode}-{command.Code}") : Convert.ToString(command.Code);

            _repository.Insert(new AccountentTree
            {
                //Id = command.Id,
                Code = command.Code,
                FullCode = fullCode,
                Name = command.Name,
                ParentTreeId = command.ParentTreeId,
            });
        }

        public void UpdateAccountentTree(UpdateAccountentTreeCommand command)
        {
            UpdateAccountentTreeCommandValidator validator = new UpdateAccountentTreeCommandValidator();
            var results = validator.Validate(command);
            if (!results.IsValid)
            {
                throw new CommandValidationException(results.Errors.Select(x => new CommandValidationError
                {
                    ErrorCode = x.ErrorCode,
                    ErrorMessage = x.ErrorMessage,
                    PropertyName = x.PropertyName
                }));
            }

            var parent = _repository.GetById(command.ParentTreeId);
            string fullCode = parent != null ? String.Format($"{parent.FullCode}-{command.Code}") : Convert.ToString(command.Code);

            _repository.Update(new AccountentTree()
            {
                Id = command.Id,
                Code = command.Code,
                Name = command.Name,
                ParentTreeId = command.ParentTreeId,
                FullCode = fullCode
            });

            ChangeFullCodeOfChildren(command.Id);

            _repository.Update(new AccountentTree()
            {
                Id = command.Id,
                Code = command.Code,
                Name = command.Name,
                ParentTreeId = command.ParentTreeId,
                FullCode = fullCode
            });
        }

        void ChangeFullCodeOfChildren(int? id)
        {
            if (id == null) return;

            var parent = _repository.GetById(id);
            _context.Entry(parent).Collection(p => p.Children).Load();

            if (parent.Children == null) return;

            int numberOfChildren = parent.Children.ToList().Count;
            for (int i = 0; i < numberOfChildren; i++)
            {
                var child = parent.Children.ElementAt(i);
                child.FullCode = String.Format($"{parent.FullCode}-{child.Code}");

                if (child.Children != null)
                    ChangeFullCodeOfChildren(child.Id);
            }
        }
    }
}
