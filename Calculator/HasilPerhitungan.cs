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
    public partial class Form1 : Form
    {
        private IList<FormCalculator> listofCalculator = new List<FormCalculator>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FrmEntry_OnCreate(FormCalculator cal)
        {
            listofCalculator.Clear();
            listofCalculator.Add(cal);
            listHasil.Items.Add(cal.Hasil);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //untuk membuka calculator ketika hasil di klik
            FormCalculator cal = new FormCalculator();
            cal.OnCreate += FrmEntry_OnCreate;

            cal.ShowDialog();
        }
    }
}
