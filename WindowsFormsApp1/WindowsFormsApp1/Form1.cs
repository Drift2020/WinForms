using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Calc calc = new Calc();
        string strings;
        string lable;
     
        public Form1()
        {
            InitializeComponent();

            label1.Text = "0";
                
            lable = "";
            label2.Text = strings = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MC_Click(object sender, EventArgs e)
        {

        }

        private void MR_Click(object sender, EventArgs e)
        {

        }

        private void MS_Click(object sender, EventArgs e)
        {

        }

        private void MPlus_Click(object sender, EventArgs e)
        {
          
        }

        private void MMin_Click(object sender, EventArgs e)
        {

        }

        private void Backspase_Click(object sender, EventArgs e)
        {

        }

        private void CleanElement_Click(object sender, EventArgs e)
        {
            lable = "";
            label1.Text = "0";
            
        }

        private void CleanAll_Click(object sender, EventArgs e)
        {
            calc.value2 = 0;
            calc.value1 = 0;

            strings = "";
            lable = "";

            label1.Text = "0";
            label2.Text="";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if(lable!= "" && calc.value1 == null)
            {
                calc.value1 = Double.Parse(lable);
                strings += lable + " + ";
                label2.Text = strings;
                lable = "";
            }
            else if(lable != "" && calc.value1 != null)
            {
                calc.value2 = Double.Parse(lable);
                strings += lable + " + ";
                  lable = "";
                label2.Text = strings;
                label1.Text = calc.Plus().ToString();
                calc.value1 = calc.Plus();
            }
        }

        private void PlusForMin_Click(object sender, EventArgs e)
        {

        }

        private void Sqrt_Click(object sender, EventArgs e)
        {

        }
        private void Dell_Click(object sender, EventArgs e)
        {

        }

        private void Proz_Click(object sender, EventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            lable += label1.Text = "" + b.Text;
            label1.Text = lable;
        }

        private void Ymnoj_Click(object sender, EventArgs e)
        {

        }

        private void OneDellX_Click(object sender, EventArgs e)
        {

        }

        private void Min_Click(object sender, EventArgs e)
        {

        }

        private void RESULT_Click(object sender, EventArgs e)
        {

        }

    

        private void Zap_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
