﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wkhtmltopdf.NetCore;

namespace GymManager.Web.Controllers
{
    public class InvoicingController : Controller
    {
        private readonly IGeneratePdf _generatePdf;
        public InvoicingController(IGeneratePdf generatePdf)
        {
            _generatePdf = generatePdf;
        }
        public IActionResult Index()
        {
            return View();
        }
   
        public IActionResult GenerateInvoice()
        {
            return View();
        }

        public async Task<IActionResult> Print()
        {
            return await _generatePdf.GetPdf("/Views/Invoicing/Print.cshtml");

            //return View();
        }
    }
}

