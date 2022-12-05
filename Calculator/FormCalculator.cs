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
    public partial class FormCalculator : Form
    {
        public delegate void CreateUpdateEventHandler(FormCalculator cal);

        public event CreateUpdateEventHandler OnCreate;

        private bool isNewData = true;

        private FormCalculator cal;

        public string Hasil;

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (isNewData) cal = new FormCalculator();

            if(operasi.Text == "Penjumlahan")
            {
                cal.Hasil = "Hasil Penjumlahan" + textNilaiA.Text + " + " + textNilaiB.Text + " = " + (int.Parse(textNilaiA.Text) + int.Parse(textNilaiB.Text));
            }
            else if (operasi.Text == "Pengurangan")
            {
                cal.Hasil = "Hasil Pengurangan" + textNilaiA.Text + " - " + textNilaiB.Text + " = " + (int.Parse(textNilaiA.Text) - int.Parse(textNilaiB.Text));
            }
            else if (operasi.Text == "Perkalian")
            {
                cal.Hasil = "Hasil Perkalian" + textNilaiA.Text + " x " + textNilaiB.Text + " = " + (int.Parse(textNilaiA.Text) * int.Parse(textNilaiB.Text));
            }
            else if (operasi.Text == "Pembagian")
            {
                cal.Hasil = "Hasil Pembagian" + textNilaiA.Text + " / " + textNilaiB.Text + " = " + (int.Parse(textNilaiA.Text) / int.Parse(textNilaiB.Text));
            }

            if (isNewData)
            {
                OnCreate(cal);
            }
        }

        private void operasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
