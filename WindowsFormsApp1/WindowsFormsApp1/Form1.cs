using System;
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
        List<double> member;
        double valu;
        string lable;
        public Form1()
        {
            InitializeComponent();


            label1.Text = "0";
            member = new List<double>();
            valu = new double();
            lable = "";
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

        }

        private void CleanAll_Click(object sender, EventArgs e)
        {

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
        private void B7_Click(object sender, EventArgs e)
        {
            lable += "7";
            label1.Text = lable;
        }

        private void B8_Click(object sender, EventArgs e)
        {
            lable += "8";
            label1.Text = lable;
        }

        private void B9_Click(object sender, EventArgs e)
        {
            lable += "9";
            label1.Text = lable;
        }

        

        private void B4_Click(object sender, EventArgs e)
        {
            lable += "4";
            label1.Text = lable;
        }

        private void B5_Click(object sender, EventArgs e)
        {
            lable += "5";
            label1.Text = lable;
        }

        private void B6_Click(object sender, EventArgs e)
        {
            lable += "6";
            label1.Text = lable;
        }

        private void B1_Click(object sender, EventArgs e)
        {
            lable += "1";
            label1.Text = lable;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            lable += "2";
            label1.Text = lable;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            lable += "3";
            label1.Text = lable;
        }

        private void B0_Click(object sender, EventArgs e)
        {
            lable += "0";
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

        private void Plus_Click(object sender, EventArgs e)
        {

        }

        private void Zap_Click(object sender, EventArgs e)
        {

        }

      
    }
}
