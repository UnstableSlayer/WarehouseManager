using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;
using WarehouseManager.Service.Products;
using WarehouseManager.Service.Products.Commands;

namespace WarehouseManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IRepository<Product> _repository;
        private readonly IProductRepository _productRepository;
        private readonly ProductService _productService;
        public ProductController(IRepository<Product> repository, IProductRepository productRepository, ProductService productService)
        {
            _repository = repository;
            _productRepository = productRepository;
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{Id:int}")]
        public ActionResult<Product> GetById(int Id)
        {
            var productToFind = _repository.GetById(Id);
            if (productToFind == null)
            {
                return NotFound();
            }

            return Ok(productToFind);
        }

        [HttpGet("{Code:int}")]
        public ActionResult<Product> GetByCode(int Code)
        {
            var productToFind = _productRepository.GetByCode(Code);
            if (productToFind == null)
            {
                return NotFound();
            }


            return Ok(productToFind);
        }

        [HttpGet("{Barcode}")]
        public ActionResult<Product> GetByBarcode(string Barcode)
        {
            var productToFind = _productRepository.GetByBarcode(Barcode);
            if (productToFind == null)
            {
                return NotFound();
            }


            return Ok(productToFind);
        }

        [HttpPost]
        public ActionResult<Product> CreateProduct(CreateProductCommand command)
        {
            _productService.CreateProduct(command);
            return Ok(command);
        }

        [HttpPut("{Id}")]
        public ActionResult UpdateProductById(int Id, UpdateProductCommand command)
        {
            var productToUpdate = _repository.GetById(Id);
            if(productToUpdate == null)
            {
                return NotFound();
            }

            _productService.UpdateProduct(command);

            return NoContent();
        }

        [HttpPut("{Code}")]
        public ActionResult UpdateProductByCode(int Code, UpdateProductCommand command)
        {
            var productToUpdate = _productRepository.GetByCode(Code);
            if (productToUpdate == null)
            {
                return NotFound();
            }

            _productService.UpdateProduct(command);

            return NoContent();
        }

        [HttpPut("{Barcode}")]
        public ActionResult UpdateProductByBarcode(string Barcode, UpdateProductCommand command)
        {
            var productToUpdate = _productRepository.GetByBarcode(Barcode);
            if (productToUpdate == null)
            {
                return NotFound();
            }

            _productService.UpdateProduct(command);

            return NoContent();
        }

        [HttpDelete("{Id}")]
        public ActionResult DeleteProduct(int Id)
        {
            var productToDelete = _repository.GetById(Id);
            if (productToDelete == null)
            {
                return NotFound();
            }
            _repository.Delete(Id);

            return Ok();
        }

        [HttpDelete("{Code}")]
        public ActionResult DeleteProductByCode(int Code)
        {
            var productToDelete = _productRepository.GetByCode(Code);
            if (productToDelete == null)
            {
                return NotFound();
            }
            _repository.Delete(productToDelete.Id);

            return Ok();
        }


        [HttpDelete("{Barcode}")]
        public ActionResult DeleteProductByBarcode(string Barcode)
        {
            var productToDelete = _productRepository.GetByBarcode(Barcode);
            if (productToDelete == null)
            {
                return NotFound();
            }
            _repository.Delete(productToDelete.Id);

            return Ok();
        }
    }
}
