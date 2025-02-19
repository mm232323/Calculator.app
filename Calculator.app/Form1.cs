using System.Security.Cryptography.X509Certificates;

namespace Calculator.app;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void handle_But_Click(Button but)
    {
        resultBar.Text = resultBar.Text + but.Text;
        if (Evaluator.operation?.Length == 0)
        {
            Evaluator.leftOperator = int.Parse(resultBar.Text);

        }
        else
        {
            Evaluator.rightOperator = int.Parse(resultBar.Text);
        }
    }
    private void handle_Operation_Click(Button op)
    {
        if (Evaluator.leftOperator != 0)
        {
            Evaluator.operation.Append(op.Text);
            resultBar.Text = "";
        }
    }

    private void but1_Click(object sender, EventArgs e)
    {

        handle_But_Click(but1);
    }

    private void but2_Click(object sender, EventArgs e)
    {
        handle_But_Click(but2);

    }

    private void but3_Click(object sender, EventArgs e)
    {
        handle_But_Click(but3);
    }

    private void but4_Click(object sender, EventArgs e)
    {
        handle_But_Click(but4);
        

    }

    private void but7_Click(object sender, EventArgs e)
    {
        handle_But_Click(but5);
    }

    private void but6_Click(object sender, EventArgs e)
    {
        handle_But_Click(but6);
    }

    private void but5_Click(object sender, EventArgs e)
    {
        handle_But_Click(but7);
    }

    private void but10_Click(object sender, EventArgs e)
    {
        handle_But_Click(but8);
    }

    private void but9_Click(object sender, EventArgs e)
    {
        handle_But_Click(but9);
    }

    private void but8_Click(object sender, EventArgs e)
    {
        handle_But_Click(but10);
    }

    private void operator1_Click(object sender, EventArgs e)
    {
        handle_Operation_Click(operator1);
    }

    private void operator2_Click(object sender, EventArgs e)
    {
        if (Evaluator.leftOperator != 0)
        {
            if (Evaluator.operation.Length != 0)
            {
                resultBar.Text = "-";
                return;
            }
            Evaluator.operation.Append(operator2.Text);
            resultBar.Text = "";
        }
        else
        {
            resultBar.Text = "-";
        }
    }
    private void operator3_Click(object sender, EventArgs e)
    {
        handle_Operation_Click(operator3);
    }
    private void operator4_Click(object sender, EventArgs e)
    {
        handle_Operation_Click(operator4);
    }

    private void actionTrigger_Click(object sender, EventArgs e)
    {
        if (Evaluator.operation.Length == 0)
        {
            resultBar.Text = "";
            return;
        }
        Solver result = new(Evaluator.leftOperator, Evaluator.rightOperator, Evaluator.operation);
        float solution = result.Solve();
        resultBar.Text = solution.ToString();
        Evaluator.leftOperator = solution;
        Evaluator.rightOperator = 0;
        Evaluator.operation.Clear();
    }

}

