using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB0DS.Helpers;
using LAB0DS.Models;

namespace LAB0DS.Controllers
{
    public class ClientesController : Controller
    {
        // GET: ClientesController
        public ActionResult Index()
        {
            return View(Data.Instance.clienteslist);
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            var model = Data.Instance.clienteslist.Find(cliente => cliente.Telefono == id);
            return View(model);
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View(new ClientesModel());
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var response = ClientesModel.Save(new ClientesModel
                {
                    Telefono = int.Parse(collection["Telefono"]),
                    Nombre = collection["Nombre"],
                    Apellido = collection["Apellido"],
                    Descripcion = collection["Descripcion"]
                });
                
                if(response)
                {
                    return RedirectToAction(nameof(Index));
                }
                ViewBag["Error"] = "Error while creating new element";
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Data.Instance.clienteslist.Find(cliente => cliente.Telefono == id);
            return View(model);
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                ClientesModel.Edit(id, new ClientesModel
                {
                    Telefono = int.Parse(collection["Telefono"]),
                    Nombre = collection["Nombre"],
                    Apellido = collection["Apellido"],
                    Descripcion = collection["Descripcion"]
                });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = Data.Instance.clienteslist.Find(cliente => cliente.Telefono == id);
            return View(model);
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                ClientesModel.Clean(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
