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
        string temp_strings;
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
            calc.member = null;
        }

        private void MR_Click(object sender, EventArgs e)
        {
            if (calc.member!=null)
            label1.Text =lable= calc.member.ToString();
        }

        private void MS_Click(object sender, EventArgs e)
        {
            calc.member = Double.Parse(label1.Text);
            calc.member = calc.member == 0 ? null : calc.member;
        }

        private void MPlus_Click(object sender, EventArgs e)
        {
            if (calc.member != null)
            {
                calc.member += Double.Parse(label1.Text);
                calc.member = calc.member == 0 ? null : calc.member;
            }
        }

        private void MMin_Click(object sender, EventArgs e)
        {
            if (calc.member != null)
            {
                calc.member -= Double.Parse(label1.Text);
                calc.member = calc.member == 0 ? null : calc.member;
            }            
        }

        private void Backspase_Click(object sender, EventArgs e)
        {
            if (Double.Parse(lable)>0&& lable!="0")
            {
                if (lable.Length > 1)
                    lable = lable.Substring(0, lable.Length - 1);
                else
                    lable = "0";


                label1.Text = lable;
            }
            
        }

        private void CleanElement_Click(object sender, EventArgs e)
        {
            calc.value2 = null;
            lable = "0";
            label1.Text = "0";
            if (label2.Text == "0")
                label2.Text = "";
        }

        private void CleanAll_Click(object sender, EventArgs e)
        {
            calc.value2 = null;
            calc.value1 = null;

            temp_strings = "";
            strings = "";
            lable = "0";

            label1.Text = "0";
            label2.Text="";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            
            if (lable!="")
            {
                if(calc.value1==null)
                {
                    if (lable == "0")
                        lable = label1.Text;

                    calc.value1 = Double.Parse(lable);
                    label2.Text = lable + " + ";
                    calc.operators = "+";
                    lable = "";
                }
                else if(calc.value2==null)
                {                                    
                    calc.value2 = Double.Parse(lable);

                    calc.value1 = calc.Operetion() != null ? calc.Operetion() : calc.value1;

                    calc.operators = "+";

                    if (strings == "")
                        label2.Text += lable + " + ";
                    else
                        label2.Text += " + ";

                    label1.Text = calc.value1.ToString();
                    calc.value2 = null;
                    lable = "0";
                    strings = "";
                }
            }   
        }


        private void Min_Click(object sender, EventArgs e)
        {
           
            if (lable != "" )
            {
                if (calc.value1 == null)
                {
                    if (lable == "0")
                        lable = label1.Text;

                    calc.value1 = Double.Parse(lable);
                    label2.Text = lable + " - ";
                    calc.operators = "-";
                    lable = "";
                }
                else if (calc.value2 == null)
                {
                   
                    calc.value2 = Double.Parse(lable);
                    calc.value1 = calc.Operetion() != null ? calc.Operetion() : calc.value1;

                    calc.operators = "-";

                   

                    if (strings == "")
                        label2.Text += lable + " - ";
                    else
                        label2.Text += " - ";


                    label1.Text = calc.value1.ToString();
                    calc.value2 = null;
                    lable = "0";
                    strings = "";
                }
            }

        }

        private void PlusForMin_Click(object sender, EventArgs e)
        {

        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (lable != "")
            {
                if (lable != "")
                {
                    label2.Text = ("√(" + lable + ")");
                    calc.value1 = Math.Sqrt(Double.Parse(lable));
                    
                    label1.Text= ("√("+calc.value1+")");
                   strings = label1.Text;
                }
            }
        }
        private void Dell_Click(object sender, EventArgs e)
        {
            
            if (lable != "")
            {
                if (calc.value1 == null)
                {
                    if (lable == "0")
                        lable = label1.Text;

                    calc.value1 = Double.Parse(lable);
                    label2.Text = lable + " / ";
                    calc.operators = "/";
                    lable = "";
                }
                else if (calc.value2 == null)
                {

                    calc.value2 = Double.Parse(lable);
                    calc.value1 = calc.Operetion() != null ? calc.Operetion() : calc.value1;

                    calc.operators = "/";

                    label2.Text += lable + " / ";

                    if (strings == "")
                        label2.Text += lable + " / ";
                    else
                        label2.Text += " / ";

                    label1.Text = calc.value1.ToString();
                    calc.value2 = null;
                    lable = "0";
                    strings = "";
                }
            }
        }

        private void Proz_Click(object sender, EventArgs e)
        {
            
            if (calc.value1 == null)
            {
                label1.Text = "0";
                label2.Text = "0";
                calc.value2 = null;
            }
            else if (calc.value2 == null)
            {
                if(strings=="")
                {
                    strings = label2.Text;
                }
                calc.value2 = Double.Parse(label1.Text);
                calc.value2 = calc.Proz() != null ? calc.Proz() : calc.value2;

                temp_strings = label1.Text = lable = calc.value2.ToString();



                label2.Text = strings + label1.Text;
                
                calc.value2 = null;
                
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(lable == temp_strings && strings != "")
            {
                lable = "" + b.Text;
                label2.Text = strings;
            }
            else if (lable =="0" )
                lable = "" + b.Text;
            else
            {
                lable += "" + b.Text;
                strings = "";
            }
           

            label1.Text = lable;
        }     

        private void Ymnoj_Click(object sender, EventArgs e)
        {
            
            if (lable != "")
            {
                if (calc.value1 == null)
                {
                    if (lable == "0")
                        lable = label1.Text;

                    calc.value1 = Double.Parse(lable);
                    label2.Text = lable + " * ";
                    calc.operators = "*";
                    lable = "";
                }
                else if (calc.value2 == null)
                {

                    calc.value2 = Double.Parse(lable);
                    calc.value1 = calc.Operetion() != null ? calc.Operetion() : calc.value1;

                    calc.operators = "*";
                  
                    if (strings == "")
                        label2.Text += lable + " * ";
                    else
                        label2.Text += " * ";

                    label1.Text = calc.value1.ToString();
                    calc.value2 = null;
                    lable = "0";
                    strings = "";
                }
            }
        }

        private void OneDellX_Click(object sender, EventArgs e)
        {

        }

    

        private void RESULT_Click(object sender, EventArgs e)
        {
            if (calc.value2 == null&& calc.value1 != null)
            {

                calc.value2 = Double.Parse(lable);
                calc.value1 = calc.Operetion() != null ? calc.Operetion() : calc.value1;

                calc.operators = "-";

                label2.Text ="";
                label1.Text = calc.value1.ToString();
                calc.value2 = null;
                calc.value1 = null;
                lable = "0";
                strings = "";
            }
        }

    

        private void Zap_Click(object sender, EventArgs e)
        {
            if (!label1.Text.ToString().Contains("."))
            {
                label1.Text += ",";
                lable += ",";
            }
        }

      
    }
}
