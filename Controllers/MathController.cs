using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm2.Models;

using MathLibrary;

namespace Midterm2.Controllers
{
    public class MathController : Controller
    {
        public IActionResult DoCalculation()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ShowCalculationResults(MathOperationModel model)
        {
            switch(model.Operator)
            {
                case "Addition":
                {
                    model.Result = MyMathRoutines.MathConverter.Add(model.LeftOperand, model.RightOperand);

                    return View(model);
                }

                case "Subtraction":
                {
                    model.Result = MyMathRoutines.MathConverter.Subtract(model.LeftOperand, model.RightOperand);

                    return View(model);
                }

                case "Multiplication":
                {
                    model.Result = MyMathRoutines.MathConverter.Multiply(model.LeftOperand, model.RightOperand);

                    return View(model);
                }

                case "Division":
                {
                    model.Result = MyMathRoutines.MathConverter.Divide(model.LeftOperand, model.RightOperand);

                    return View(model);
                }

                default:
                {
                    return View(model);
                }
            }
            

            
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}