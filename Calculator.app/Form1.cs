using System.Security.Cryptography.X509Certificates;

namespace Calculator.app;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void but1_Click(object sender, EventArgs e)
    {
        resultBar.Text = resultBar.Text + but1.Text;
        if (Evaluator.operation?.Length == 0)
        {
            Evaluator.leftOperator = int.Parse(resultBar.Text);

        }
        else
        {
            Evaluator.rightOperator = int.Parse(resultBar.Text);
        }

    }

    private void but2_Click(object sender, EventArgs e)
    {
        resultBar.Text = resultBar.Text + but2.Text;
        if (Evaluator.operation?.Length == 0)
        {
            Evaluator.leftOperator = int.Parse(resultBar.Text);

        }
        else
        {
            Evaluator.rightOperator = int.Parse(resultBar.Text);
        }

    }

    private void but3_Click(object sender, EventArgs e)
    {
        resultBar.Text = resultBar.Text + but3.Text;
        if (Evaluator.operation?.Length == 0)
        {
            Evaluator.leftOperator = int.Parse(resultBar.Text);

        }
        else
        {
            Evaluator.rightOperator = int.Parse(resultBar.Text);
        }

    }

    private void but4_Click(object sender, EventArgs e)
    {
        resultBar.Text = resultBar.Text + but4.Text;
        if (Evaluator.operation?.Length == 0)
        {
            Evaluator.leftOperator = int.Parse(resultBar.Text);

        }
        else
        {
            Evaluator.rightOperator = int.Parse(resultBar.Text);
        }

    }

    private void but7_Click(object sender, EventArgs e)
    {
        resultBar.Text = resultBar.Text + but5.Text;
        if (Evaluator.operation?.Length == 0)
        {
            Evaluator.leftOperator = int.Parse(resultBar.Text);

        }
        else
        {
            Evaluator.rightOperator = int.Parse(resultBar.Text);
        }

    }

    private void but6_Click(object sender, EventArgs e)
    {
        resultBar.Text = resultBar.Text + but6.Text;
        if (Evaluator.operation?.Length == 0)
        {
            Evaluator.leftOperator = int.Parse(resultBar.Text);

        }
        else
        {
            Evaluator.rightOperator = int.Parse(resultBar.Text);
        }

    }

    private void but5_Click(object sender, EventArgs e)
    {
        resultBar.Text = resultBar.Text + but7.Text;
        if (Evaluator.operation?.Length == 0)
        {
            Evaluator.leftOperator = int.Parse(resultBar.Text);

        }
        else
        {
            Evaluator.rightOperator = int.Parse(resultBar.Text);
        }

    }

    private void but10_Click(object sender, EventArgs e)
    {
        resultBar.Text = resultBar.Text + but10.Text;
        if (Evaluator.operation?.Length == 0)
        {
            Evaluator.leftOperator = int.Parse(resultBar.Text);

        }
        else
        {
            Evaluator.rightOperator = int.Parse(resultBar.Text);
        }

    }

    private void but9_Click(object sender, EventArgs e)
    {
        resultBar.Text = resultBar.Text + but9.Text;
        if (Evaluator.operation?.Length == 0)
        {
            Evaluator.leftOperator = int.Parse(resultBar.Text);

        }
        else
        {
            Evaluator.rightOperator = int.Parse(resultBar.Text);
        }

    }

    private void but8_Click(object sender, EventArgs e)
    {
        resultBar.Text = resultBar.Text + but10.Text;

        if (Evaluator.operation?.Length == 0)
        {
            Evaluator.leftOperator = int.Parse(resultBar.Text);

        }
        else
        {
            Evaluator.rightOperator = int.Parse(resultBar.Text);
        }

    }

    private void operator1_Click(object sender, EventArgs e)
    {
        if (Evaluator.leftOperator != 0)
        {
            Evaluator.operation = operator1.Text;
            resultBar.Text = "";
        }
    }

    private void operator2_Click(object sender, EventArgs e)
    {
        if (Evaluator.leftOperator != 0)
        {
            Evaluator.operation = operator2.Text;
            resultBar.Text = "";
        }
        else
        {
            resultBar.Text = "-";
        }
    }
    private void operator3_Click(object sender, EventArgs e)
    {
        if (Evaluator.leftOperator != 0)
        {
            Evaluator.operation = operator3.Text;
            resultBar.Text = "";
        }
    }
    private void operator4_Click(object sender, EventArgs e)
    {
        if (Evaluator.leftOperator != 0)
        {
            Evaluator.operation = operator4.Text;
            resultBar.Text = "";
        }
    }

    private void actionTrigger_Click(object sender, EventArgs e)
    {
        if (Evaluator.operation.Length == 0)
        {
            resultBar.Text = "";
            return;
        }
        Solver result = new(Evaluator.leftOperator, Evaluator.rightOperator, Evaluator.operation);
        double solution = result.Solve();
        resultBar.Text = solution.ToString();
        Evaluator.leftOperator = solution;
        Evaluator.rightOperator = 0;
        Evaluator.operation = "";
    }

}

