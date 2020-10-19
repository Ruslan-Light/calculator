using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calcForm : Form
    {
        
        public calcForm()
        {
            InitializeComponent();
        }

        public float memoryCurrentNumber = 0;
        public float memoryNumber = 0;
        public string memorySymbolOperaion;
        public bool flag = false;

        private void clear_Click(object sender, EventArgs e)
        {
            calcField.Text = "0";
            memoryCurrentNumber = 0;
            memoryNumber = 0;
            memorySymbolOperaion = null;
            flag = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Button figureBtn = (Button)sender;

            
            if (calcField.Text == "0")
            {
                calcField.Text = figureBtn.Text;

            }
            else if(calcField.Text.Length < 15 && flag == false)
            {
                calcField.Text += figureBtn.Text;
                
            }
            else if(calcField.Text.Length < 15 && flag == true)
            {
                flag = false;
                calcField.Clear();
                calcField.Text += figureBtn.Text;
                
            }

        }

        private void div_Click(object sender, EventArgs e)
        {

            memoryCurrentNumber = float.Parse(calcField.Text);
            
            Button symbolBtn = (Button)sender;
            if(flag)
            {
                calcField.Text = memoryNumber.ToString();
            }
            else if(memorySymbolOperaion == null)
            {
                flag = true;
                memoryNumber = memoryCurrentNumber;
            }
            else if(memorySymbolOperaion != "=")
            {
                flag = true;
                if (memorySymbolOperaion == "+")
                {
                    memoryNumber += memoryCurrentNumber;
                }
                else if (memorySymbolOperaion == "-")
                {
                    memoryNumber -= memoryCurrentNumber;
                }
                else if (memorySymbolOperaion == "/")
                {
                    memoryNumber /= memoryCurrentNumber;
                }
                else if (memorySymbolOperaion == "*")
                {
                    memoryNumber *= memoryCurrentNumber;
                }
            }
            


            memoryCurrentNumber = 0;
            memorySymbolOperaion = symbolBtn.Text;
            calcField.Text = memoryNumber.ToString();
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {

        }

        private void equally_Click(object sender, EventArgs e)
        {
            flag = true;
            Button symbolBtn = (Button)sender;

            memoryCurrentNumber = float.Parse(calcField.Text);

            if (memorySymbolOperaion == "+")
            {
                calcField.Text = (memoryNumber + memoryCurrentNumber).ToString();
            }
            else if (memorySymbolOperaion == "-")
            {
                calcField.Text = (memoryNumber - memoryCurrentNumber).ToString();
            }
            else if (memorySymbolOperaion == "/")
            {
                calcField.Text = (memoryNumber / memoryCurrentNumber).ToString();
            }
            else if (memorySymbolOperaion == "*")
            {
                calcField.Text = (memoryNumber * memoryCurrentNumber).ToString();
            }
            memoryNumber = float.Parse(calcField.Text);
            memoryCurrentNumber = 0;

            memorySymbolOperaion = symbolBtn.Text;
        }

        private void calcField_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
