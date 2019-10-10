using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestionProduit.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace GestionProduit.Controllers
{
    public class ProduitsController : Controller
    {

        public MonContext DB = new MonContext();

        public IActionResult Index()
        {
            return View(DB.Produits.Include(p => p.Category).ToList());
        }
        //get
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(DB.Categories, "Id", "Libelle");
            return View();
        }

        //Post
        [HttpPost]
        public IActionResult Create(Produit produit)
        {
            if (ModelState.IsValid)
            {
                DB.Produits.Add(produit);
                DB.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            ViewData["CategoryId"] = new SelectList(DB.Categories, "Id", "Id", produit.CategoryId);
            return View(produit);
        }





        // GET: Produits1/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produit = DB.Produits.Find(id);
            if (produit == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(DB.Categories, "Id", "Id", produit.CategoryId);
            return View(produit);
        }


        [HttpPost]
        public IActionResult Edit(Produit produit) {

            if (ModelState.IsValid)
            {
                DB.Entry(produit).State = EntityState.Modified;
                DB.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produit);
        }


        public IActionResult Delete(int? id)
        {
            if (id == 0) {
                return NotFound();
            }
            var produit = DB.Produits.Include(p => p.Category).SingleOrDefault(p => p.Id == id);
            if (produit == null) {
                return NotFound();
            }

          //  ViewData["CategoryId"] = new SelectList(DB.Categories, "Id", "Id", produit.CategoryId);
            return View(produit);

        }

        [HttpPost]
        public IActionResult Delete(Produit produit) {
            if (ModelState.IsValid)
            {
                DB.Entry(produit).State = EntityState.Deleted;
                DB.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produit);

        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var produit = DB.Produits.Include(p=>p.Category).FirstOrDefault(m=>m.Id==id);
            if (produit == null) {
                return NotFound();
            }
          //  ViewData["CategoryId"] = new SelectList(DB.Categories, "Id", "Libelle");//, produit.Category);
            return View(produit);



        }
    }
}