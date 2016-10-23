using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NV_AUC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cDialog.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {

                Check.BackColor = cDialog.Color;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cDialogue.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {

                Check.ForeColor = cDialogue.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
            }
        }
