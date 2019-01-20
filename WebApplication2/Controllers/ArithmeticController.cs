using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ArithmeticController : Controller
    {
        // GET: Arithmetic
        public ActionResult Insertion_sort()
        {
            int[] arr = new int[] { 1, 5, 3, 6, 2, 9, 8, 4, 12, 34, 78, 57, 23, 45 };
            int i, j;
            for (i = 1; i < arr.Length; i++)
            {
                int tmp = arr[i];
                for (j = i; j > 0 && arr[j - 1] > tmp; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[j] = tmp;
            }
            ViewBag.arr = arr;
            return View(arr);
        }
    }
}