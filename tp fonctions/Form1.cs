using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tp_fonctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtresultat.Text !="") { resetSaisie();}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rd_add.Checked == true)
            {
                txtresultat.Text = (Int32.Parse(txtnombre1.Text) + Int32.Parse(txtnombre2.Text)).ToString();
            }
            else if (rd_sous.Checked == true)
            {
                txtresultat.Text = (Int32.Parse(txtnombre1.Text) - Int32.Parse(txtnombre2.Text)).ToString();
            }
            else if (rd_multip.Checked == true)
            {
                txtresultat.Text = (Int32.Parse(txtnombre1.Text) * Int32.Parse(txtnombre2.Text)).ToString();
            }
            else
            {
                if (Int32.Parse(txtnombre2.Text) != 0)
                {
                    txtresultat.Text = (Int32.Parse(txtnombre1.Text) / Int32.Parse(txtnombre2.Text)).ToString();
                    
                   zero.Text = ""; 
                }
                else
                {
                    //MessageBox.Show("division par 0 est impossible !! corriger ");
                    zero.Text = "division par 0 est impossible";
                }
            }
        }

        private void rd_add_CheckedChanged(object sender, EventArgs e)
        {
        if (txtresultat.Text !="") { resetSaisie();}
        }
        private void resetSaisie()
        {
            txtnombre1.Clear();
            txtnombre2.Clear();
            txtresultat.Clear();
        }
        private void btnquitter_Click(object sender, EventArgs e)
        {
               Application.Exit();
        }

        private void txtnombre1_TextChanged(object sender, EventArgs e)
        {
            if(txtresultat.Text !="")txtresultat.Clear();
        }

        private void txtnombre2_TextChanged(object sender, EventArgs e)
        {
         if(txtresultat.Text !="")txtresultat.Clear();
         if (Int32.Parse(txtnombre2.Text) != 0)
         { zero.Text = ""; }
      
        }

        private void rd_multip_CheckedChanged(object sender, EventArgs e)
        {
            if (txtresultat.Text !="") { resetSaisie();}
        }

        private void rd_div_CheckedChanged(object sender, EventArgs e)
        {
            if (txtresultat.Text != "") { resetSaisie(); }
        }
       
        private void txtnombre2_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtnombre1_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar))) 
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        }
    }

