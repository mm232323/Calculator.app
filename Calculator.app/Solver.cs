namespace Calculator.app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Solver
{
    private double left;
    private double right;
    private string operation;
    internal Solver(double left,double right,string operation)
    {
        this.left = left;
        this.right = right;
        this.operation = operation;
    }
    internal double Solve()
    {
        switch (operation)
        {
            case "+":
                return left + right;
            case "-":
                return left - right;
            case "*":
                return left * right;
            case "/":
                return left / right;
            default:
                throw new InvalidOperationException("Invalid operation");
        }
    }
}
