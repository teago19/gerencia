﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Models.Repositories;

namespace WebApplication2.Controllers
{
    public class TelaCadastroClienteController : Controller
    {

        // GET: TelaCadastroCliente/Create
        public ActionResult CadastrarCliente()
        {
            return View();
        }

        // POST: TelaCadastroCliente/Create
        [HttpPost]
        public ActionResult CadastrarCliente(string nome, string telefone, string email, string password,string cpf)
        {
            try
            {
                Fachada.SingletonFachada.CadastrarCliente(cpf, nome, password, telefone, email, new Endereco("c", 3, "c", "c", "3", "3"));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //// GET: TelaCadastroCliente/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: TelaCadastroCliente/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: TelaCadastroCliente/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: TelaCadastroCliente/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
