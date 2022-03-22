﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        public List<Product> GetList()
        {
            return _productDal.GetAll().ToList();
        }

        public List<Product> GetListByCategory(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id).ToList();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
