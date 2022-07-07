using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcus_Exe_2
{
    public partial class Form1 : Form
    {
        private object Bnt_trocabateria;

        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Bnt_TrocaBateria.BackColor = Color.Green;
            Bnt_TrocaBateria.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

                Bnt_LigaDesliga.BackColor = Color.Red;
        }
    }
}
