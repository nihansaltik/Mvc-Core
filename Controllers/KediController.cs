using KediApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KediApp.Controllers
{
    public class KediController : Controller
    {
        public IActionResult Index()
        {
            KediModel kedi1 = new KediModel();
            kedi1.Id = 1;
            kedi1.Adi = "Poncik";
            kedi1.Cinsiyeti = true;
            kedi1.IdCinsi = 1;

            KediModel kedi2 = new KediModel()
            { Id = 2, Adi = "Kızım", IdCinsi = 2, Cinsiyeti = false };

            KediModel kedi3 = new KediModel()
            { Id = 3, Adi = "Oglum", IdCinsi = 3, Cinsiyeti = true };

            List<KediModel> kediler = new List<KediModel>();
            kediler.Add(kedi1);
            kediler.Add(kedi2);
            kediler.Add(kedi3);



            // List<KediModel> kediler = new List<KediModel>()
            // {
            // new KediModel(){ Id=1, Adi="Poncik", IdCinsi=1, Cinsiyeti=true },
            // new KediModel(){ Id=2, Adi="Kızım", IdCinsi=2, Cinsiyeti=false },
            // new KediModel(){ Id=3, Adi="Oglum", IdCinsi=3, Cinsiyeti=true },
            // };
            return View(kediler);



        }
        public IActionResult Yeni()
        {
            KediModel kedi = new KediModel();

            List<CinsModel> cinsler = new List<CinsModel>()
            {
                     new CinsModel(){ IdCinsi = 1 ,Cinsi = "Tekir"},
                     new CinsModel(){ IdCinsi = 2 ,Cinsi = "Van Kedisi"},
                     new CinsModel(){ IdCinsi = 3, Cinsi = "ScotishFold"},
                     new CinsModel(){ IdCinsi = 4, Cinsi = "BritishFold"}

             };


            KediYeniViewModel model = new KediYeniViewModel();
            model.Kedi = kedi;
            model.cinsler = cinsler;

            return View(model);
        }
        [HttpPost]
        public IActionResult Kaydet(KediModel kedi)
        {
            return View();
        }
    }
}
