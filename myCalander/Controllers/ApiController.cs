using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using myCalander.Models;
using System;

namespace myCalander.Controllers
{

    public class ApiController : Controller
    {
        public IActionResult Tasks()
    {
        var list = new List<Task>();
           
           var t1 = new Task();
           t1.Id = 1;
           t1.Title = "first task";
           t1.Notes ="This is the first task on my super calander sys";
           t1.Important = true;
           t1.Date = DateTime.Now;
           list.Add(t1);

           var t2  = new Task()
           {
               Id = 2,
               Title = "Get Milk",
               Important = false,
               Notes = "Get milk next time you go to the store",
               Date = DateTime.Now

           };
           list.Add(t2);

           

            var t3 = new Task()
            {
                Id = 3,
                Title = "Something Something",
                Important = false,
                Notes = "Running out of ideas for tasks",
                Date = DateTime.Now
            };
            List.Add(t3);

             return Json(list);


        }

    }

}

