using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProduit.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestionProduit.Controllers
{
    public class CommandeController : Controller
    {
        public MonContext DB = new MonContext();
        public IActionResult Index()
        {
            var commande = DB.Commandes.Include(p => p.Client).ToList();
            return View(commande);
        }
        public IActionResult Details(int? id)
        {
            if (id == null) { return NotFound(); }
            var commande = DB.Commandes.Include(p => p.Client).FirstOrDefault(m => m.Id == id);
            if(commande == null)
            {
                return NotFound();
            }
            return View(commande);


        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var commande = DB.Commandes.Find(id);
            if (commande == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(DB.Clients, "Id", "Id", commande.ClientId);
            return View(commande);

        }

        [HttpPost]
        public IActionResult Edit(Commande commande)
        {
            if (ModelState.IsValid)
            {
                DB.Entry(commande).State = EntityState.Modified;
                DB.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(commande);
        }

        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(DB.Clients,"Id","Nom");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Commande commande)
        {
            if (ModelState.IsValid)
            {
                DB.Commandes.Add(commande);
                DB.SaveChanges();
                return RedirectToAction("Index");

            }
            ViewData["ClientId"] = new SelectList(DB.Clients, "Id", "Id",commande.ClientId);
            return View (commande);
        }
       public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var commande = DB.Commandes.Include(p => p.Client).FirstOrDefault(m => m.Id==id);//Find(id);
            if (commande == null)
            {

                return NotFound();
            }
          //  ViewData["ClientId"] = new SelectList(DB.Clients, "Id", "Id", commande.ClientId);

            return View(commande);
        }
        [HttpPost]
        public IActionResult Delete(Commande commande)
        {
            if (ModelState.IsValid)
            {
                DB.Entry(commande).State = EntityState.Deleted;
                DB.SaveChanges();
                RedirectToAction("Index");
            }
            return View(commande);
        }

    }
}