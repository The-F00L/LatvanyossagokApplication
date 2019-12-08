using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (!DataBaseControl.csatlakozas())
            {
                MessageBox.Show("Hiba a csatlakozás során!", "Hiba",MessageBoxButtons.OK);
            }

            DataBaseControl.tableMade();

        }
        private void dataGridUpdate()
        {
            DataBaseControl.dataGridViewLoder("varosok", dataGridViewVarosok);
            DataBaseControl.dataGridViewLoder("latvanyossagok", dataGridViewLatvanyossag);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridUpdate();
        }

        private void AddCity_Click(object sender, EventArgs e)
        {
            DataBaseControl.varosHozzaAd(
                (textBoxNev.Text).First().ToString().ToUpper()
                    + String.Join("", (textBoxNev.Text).Skip(1)),
                Convert.ToInt32(Math.Round(lakosagNumeric.Value, 0))
            );
            dataGridUpdate();
            textBoxNev.Text = "";
            lakosagNumeric.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (textBoxLNev.Text != "" && LeirasText.Text != "" && varosValasz.Text != "")
            {
                DataBaseControl.latvanyossagHozzaAd(
                    (textBoxLNev.Text).First().ToString().ToUpper()+String.Join("", (textBoxLNev.Text).Skip(1)),
                    LeirasText.Text,
                    Convert.ToInt32(Math.Round(numericUpDownAr.Value, 0)),
                    (varosValasz.Text).First().ToString().ToUpper()+String.Join("", (varosValasz.Text).Skip(1))
                );
                dataGridUpdate();
                textBoxLNev.Text = "";
                varosValasz.Text = "";
                LeirasText.Text = "";
                numericUpDownAr.Text = "";
            }
            else
            {
                MessageBox.Show("Üres mező");
            }
        }
    }
}
