namespace Calculator.app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal static class Evaluator
{
    internal static float leftOperator { get; set; }
    internal static float rightOperator {get;set;}
    internal static StringBuilder operation { get; set; } = new(); 
}
