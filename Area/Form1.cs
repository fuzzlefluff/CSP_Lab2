using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_MatthewPrindleSummer2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            AreaTxtB.Visible = true;
            if (CircleRadBtn.Checked == true)
            {
                double radius = Convert.ToDouble (RadiusTxtB.Text);
                double result = radius * radius;
                result = result * Math.PI;
                AreaTxtB.Text = Convert.ToString(result);
            }
            if (SquareRadBtn.Checked == true)
            {
                double side = Convert.ToDouble(RadiusTxtB.Text);
                double result = side * side;
                AreaTxtB.Text = Convert.ToString(result);
            }
            if (RectRadBtn.Checked == true)
            {
                double length = Convert.ToDouble(RadiusTxtB.Text);
                double width = Convert.ToDouble(WidthTextB.Text);
                double result = length * width;
                AreaTxtB.Text = Convert.ToString(result);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            RadiusTxtB.Text = "";
            WidthTextB.Text = "";
            AreaTxtB.Text = "";
        }

        private void CircleRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CircleRadBtn.Checked == true) ;
            {
                RadiusLbl.Text = "Radius";
                RadiusTxtB.Visible = true;
                WidthTextB.Visible = false;
                AreaTxtB.Visible = false;
            }
        }

        private void SquareRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadiusTxtB.Visible = true;
            WidthTextB.Visible = false;
            AreaTxtB.Visible = false;
            RadiusLbl.Text = "Side";
        }

        private void RectRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadiusLbl.Text = "Height";
            RadiusTxtB.Visible = true;
            WidthTextB.Visible = true;
            AreaTxtB.Visible = false;
        }
    }
}
