using HTML5ViewerParametersDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HTML5ViewerParametersDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var reportSourceModel = new ReportSourceModel()
            {
                Report = "Ope935_v_telerik.trdp",
                Parameters = new Dictionary<string, object>()
            };
            reportSourceModel.Parameters.Add("ProductCategory", "Clothing");
            reportSourceModel.Parameters.Add("ProductSubcategory", new string[] { "Caps", "Gloves", "Vests" });

            return View(reportSourceModel);
        }
    }
}
