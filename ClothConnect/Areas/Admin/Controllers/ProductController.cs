using ClothConnect.DataAccess.Repository.IRepository;
using ClothConnect.Models.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; // Required for using List

namespace ClothConnect.Areas.Admin.Controllers
{
    // Specifies that this controller is part of the 'Admin' area
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        // Constructor injecting the IUnitOfWork dependency
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Action method for displaying the list of products
        public IActionResult Index()
        {
            // Retrieve all products and convert to a list
            List<Product> objProductList = _unitOfWork.Product.GetAll().ToList();
            // Pass the product list to the view
            return View(objProductList);
        }

        // GET action for the Create view
        public IActionResult Create()
        {
            return View();
        }

        // POST action for creating a new product
        [HttpPost]
        public IActionResult Create(Product obj)
        {
            // Check if the model state is valid
            if (ModelState.IsValid)
            {
                // Add the new product and save changes
                _unitOfWork.Product.Add(obj);
                _unitOfWork.Save();
                // Set a success message in TempData
                TempData["success"] = "Product created successfully";
                // Redirect to the Index view
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET action for the Edit view
        public IActionResult Edit(int? id)
        {
            // Check if id is null or zero
            if (id == null || id == 0)
            {
                return NotFound();
            }
            // Retrieve the product from the database
            Product? categoryFromDb = _unitOfWork.Product.Get(u => u.Id == id);

            // Check if the product exists
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        // POST action for editing an existing product
        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            // Check if the model state is valid
            if (ModelState.IsValid)
            {
                // Update the product and save changes
                _unitOfWork.Product.Update(obj);
                _unitOfWork.Save();
                // Set a success message in TempData
                TempData["success"] = "Product updated successfully";
                // Redirect to the Index view
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET action for the Delete view
        public IActionResult Delete(int? id)
        {
            // Check if id is null or zero
            if (id == null || id == 0)
            {
                return NotFound();
            }
            // Retrieve the product from the database
            Product? categoryFromDb = _unitOfWork.Product.Get(u => u.Id == id);

            // Check if the product exists
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        // POST action for deleting a product
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            // Retrieve the product from the database
            Product? obj = _unitOfWork.Product.Get(u => u.Id == id);

            // Check if the product exists
            if (obj == null)
            {
                return NotFound();
            }
            // Remove the product and save changes
            _unitOfWork.Product.Remove(obj);
            _unitOfWork.Save();
            // Set a success message in TempData
            TempData["success"] = "Product deleted successfully";
            // Redirect to the Index view
            return RedirectToAction("Index");
        }
    }
}
//Radhika Munjal
