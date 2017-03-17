using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BancoAppMetrica.Models;

namespace BancoAppMetrica.Controllers
{
    public class BancoController : Controller
    {
        //
        // GET: /Banco/
        public ActionResult Mantener_Banco()
        {
            return View();
        }

        public ActionResult Mantener_Sucursal()
        {
            return View();
        }

        public ActionResult Mantener_OrdenPago()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Mantener_Banco(BancoModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                try
                {
                    var bancoModels = new List<BancoModel>();
                    if (Session["BancoModelo"] != null)
                        bancoModels = (List<BancoModel>)Session["BancoModel"];
                    bancoModels.Add(model);
                    Session["BancoModelo"] = bancoModels;
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception e)
                {
                    
                }
            }

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Mantener_Sucursal(SucursalModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                try
                {
                    var sucursalModels = new List<SucursalModel>();
                    if (Session["SucursalModelo"] != null)
                        sucursalModels = (List<SucursalModel>)Session["SucursalModelo"];
                    sucursalModels.Add(model);
                    Session["SucursalModelo"] = sucursalModels;
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception e)
                {

                }
            }

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Mantener_OrdenPago(OrdenPagoModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                try
                {
                    var ordenPagoModels = new List<OrdenPagoModel>();
                    if (Session["OrdenPagoModelo"] != null)
                        ordenPagoModels = (List<OrdenPagoModel>)Session["OrdenPagoModelo"];
                    ordenPagoModels.Add(model);
                    Session["OrdenPagoModelo"] = ordenPagoModels;
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception e)
                {

                }
            }

            return View(model);
        }

    }
}
