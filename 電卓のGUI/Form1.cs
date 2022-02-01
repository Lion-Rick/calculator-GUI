using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 電卓のGUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        bool isFirst = true;
        bool kesanFirst = true; 
        double val1 = 0;
        double result = 0;
        enum sign {blank, ADD, SUB, MUL, DIV };
        sign exec = sign.blank;
        string text = "";
        private void button_dot_Click(object sender, EventArgs e)
        {
            if (label1.Text.IndexOf(".") >= 1)
            {
                return;
            }
            else
            {
                if (text == "")
                {
                    text += "0.";
                    label1.Text = text;
                    isFirst = false;
                }
                else
                {
                    text += ".";
                    label1.Text = text;

                }
            }
        }

        private void button_tasu_Click(object sender, EventArgs e)
        {
            sign calc = sign.ADD;
            keisan(calc);
        }
        private void button_hiku_Click(object sender, EventArgs e)
        {
            sign calc = sign.SUB;
            keisan(calc);

        }
        private void button_kakuru_Click(object sender, EventArgs e)
        {
            sign calc = sign.MUL;
            keisan(calc);

        }
        private void button_waru_Click(object sender, EventArgs e)
        {
            sign calc = sign.DIV;
            keisan(calc);

        }
        private void keisan(sign calc)
        {
            if (exec == sign.blank)
            {
                exec = calc;
                text = "";
                result = val1;
                kesanFirst = false;
            }
            else
            {
                if (kesanFirst == true)
                {
                    exec = calc;
                    text = "";
                    kesanFirst = false;
                }
                else
                {
                    exec = calc;
                    Loot();
                    text = "";
                    kesanFirst = false;
                }
            }
        }
        private void button_clean_Click(object sender, EventArgs e)
        {
            exec = sign.blank;
            label1.Text = "0";
            result = 0;
            text = "";
            val1 = 0;
            isFirst = true;
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string m = bt.Text;
            if (isFirst)
            {
                if (kesanFirst)
                {
                    exec = sign.blank;
                }
                text = "";
                isFirst = false;
            }
            text += m;

            val1 = double.Parse(text);
            label1.Text = text;
        }
        private void calc_Click(object sender, EventArgs e)
        {
            if (text == "")
            {
                if (result == 0)
                {
                    text = "";
                    label1.Text = "0";
                }
                else
                {
                    Loot();
                }
            }
            else
            {
                Loot();
            }
        }
        private void Loot()
        {
            try
            {
                switch (exec)
                {
                    case sign.ADD:
                        result += val1;
                        break;
                    case sign.SUB:
                        result -= val1;
                        break;
                    case sign.MUL:
                        result *= val1;
                        break;
                    case sign.DIV:
                        result /= val1;
                        break;
                    default:
                        result = val1;
                        break;
                }
                label1.Text = result.ToString();
                isFirst = true;
                kesanFirst = true;
            }
            catch (Exception)
            {
                exec = sign.blank;
                label1.Text = "エラーです。";
                result = 0;
                text = "";
                val1 = 0;
                isFirst = true;
                kesanFirst = true;
            }

        }
        private void button_kawaru_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                text = "0";
                label1.Text = text;
            }
            else
            {
                val1 = 0 - double.Parse(label1.Text);
                text = val1.ToString();
                label1.Text = text;
            }
        }
        private void button_pasento_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                text = "0";
                label1.Text = text;
            }
            else
            {
                val1 = double.Parse(label1.Text) / 100;
                text = val1.ToString();
                label1.Text = text;
            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (text != "")
            {
                string Text = Convert.ToString(val1);
                var lenght = Text.Length;
                if (lenght > 1)
                {
                    text = text.Remove(lenght - 1);
                    val1 = double.Parse(text);
                }
                else
                {
                     text = "";
                     val1 = 0;
                }
            }
            else
            {
                val1 = 0;
                result = 0;
            }
            label1.Text = text;
        }
        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void 計算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loot();
        }
    }
}
