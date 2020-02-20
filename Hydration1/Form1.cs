using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydration1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* This program generate feedback or suggesstion about the hydration status
         * of a person depending on the number of glasses of water 
         * he/she drinks a day, and displays the result */
        
        private void numGlasses_ValueChanged(object sender, EventArgs e)
        {
            /* Get the number of glasses of water from the NumericUpDown control
              *and generate the feedback based on the number of glasses of water
              * the person drink a day */
            decimal glasses = numGlasses.Value;

            if (glasses >= 0 && glasses <= 1)
            {

                lblHydrationStatus.Text = "Drink some water!";
                lblHydrationStatus.ForeColor = Color.White; // Assigning the forecolor of the labels
                lblNumGlasses.ForeColor = Color.White;

                this.BackColor = Color.Gray;      // Assigning the background color of the form


            }
            else if (glasses >= 2 && glasses <= 4)
            {
                lblHydrationStatus.Text = "Good job!";
                lblHydrationStatus.ForeColor = Color.Black;
                lblNumGlasses.ForeColor = Color.Black;

                this.BackColor = Color.LightGray;

            }
            else if (glasses >= 5 && glasses <= 8)
            {
                lblHydrationStatus.Text = "Just right!";
                lblHydrationStatus.ForeColor = Color.Black;
                lblNumGlasses.ForeColor = Color.Black;

                this.BackColor = Color.LightBlue;

            }
            else if (glasses >= 9 && glasses <= 15)
            {
                lblHydrationStatus.Text = "Awosome!";
                lblHydrationStatus.ForeColor = Color.White;
                lblNumGlasses.ForeColor = Color.White;

                this.BackColor = Color.DarkBlue;

            }
            else
            {
                lblHydrationStatus.Text = "Too much!";
                lblHydrationStatus.ForeColor = Color.White;
                lblNumGlasses.ForeColor = Color.White;

                this.BackColor = Color.Red;
            }

        }
    }
}
