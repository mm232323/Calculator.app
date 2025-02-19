namespace Calculator.app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Solver
{
    private float left;
    private float right;
    private StringBuilder operation;
    internal Solver(float left,float right,StringBuilder operation)
    {
        this.left = left;
        this.right = right;
        this.operation = operation;
    }
    internal float Solve()
    {
        switch (operation.ToString())
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
                return 0;
        }
    }
}
