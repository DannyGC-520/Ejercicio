using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Ejercicio.Models;

namespace Ejercicio.Controllers {
    public class NumberController : Controller {
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int InitalValue){
            //genera objeto
            var numbers = new List<Number>();
            for(int i=1;i<(InitalValue+1);i++){
                var val= new Number();
                //evaluar si es primo
                if ( i % 2 == 0){
                    numbers.Add(new Number{Value=i,Type="Par"});
                }else{
                    numbers.Add(new Number{Value=i,Type="Impar"});

                }
            }            
            return View(numbers);
        }

    }
}