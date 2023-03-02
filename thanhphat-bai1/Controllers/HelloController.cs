using Microsoft.AspNetCore.Mvc;
using thanhphat_bai1.Models;

namespace thanhphat_bai1.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetName()
        {
            return Ok("Thanh Phat");
        }

        public IActionResult GetInfo()
        {
            ViewBag.Info = new InfoModel
            {
                _school = "Hutech",
                _class = "18DTHA2",
                _name = "thanhphat",
                _id = "1811060563",
            };
            return View();
        }
    }
}
