using Microsoft.AspNetCore.Mvc;
using Sate.Interfesis;
using Sate.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sate.Controllers
{
    public class ProductController:Controller
    {
        private readonly IAllProduct _allProduct;


        public ProductController(IAllProduct iallProduct)
        {
            _allProduct = iallProduct;

        }
        public ViewResult List()
        {
            ProductListViewModel obj = new ProductListViewModel();
            obj.allP = _allProduct.Products;

            return View(obj);
        }
    }
}
