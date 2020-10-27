using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Redisztracio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker_szuletesdatum.MaxDate = DateTime.Now;
            StreamReader olvas = new StreamReader(@"lista.txt");

            while(!olvas.EndOfStream)
            {
                listBox_hobbi.Items.Add(olvas.ReadLine());
            }
            olvas.Close();
        }

        private void button_hozzaad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_ujhobbi.Text.Trim()))
            {
                MessageBox.Show("Nem adta meg a hobbit!","Hibás adat!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                textBox_nev.Focus();
            }
            else
            {
                int listadb = listBox_hobbi.Items.Count;
                int eredmeny = 0;
                foreach(string item in listBox_hobbi.Items)
                {
                    if (textBox_ujhobbi.Text.ToUpper().TrimEnd().TrimStart() == item.ToUpper())
                    {
                        eredmeny = 1;
                    }
                }
                if (eredmeny == 0)
                {
                    listBox_hobbi.Items.Add(textBox_ujhobbi.Text.TrimStart().TrimEnd());
                    textBox_ujhobbi.Text = "";
                    textBox_ujhobbi.Focus();
                }
                else
                {
                    MessageBox.Show("Már volt ilyen adat");
                    textBox_ujhobbi.Focus();
                }
            }
            

            
        }

        private void button_mentes_Click(object sender, EventArgs e)
        {
            
            
            string nev="";
            int hobbi = 0;
            int ures = 0;
            if (textBox_nev.Text.TrimStart().TrimEnd() == "")
            {
                MessageBox.Show("Hiányzik a név!", "Hiányos adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ures = 1;
            }
            else
            {
                nev = textBox_nev.Text.TrimStart().TrimEnd();

                
            }
            string szulev = dateTimePicker_szuletesdatum.Text;

            string nem;
            if(radioButton_ferfi.Checked)
            {
                nem = "ferfi";
            }
            else
            {
                nem = "no";
            }
            if (listBox_hobbi.SelectedIndex > -1)
            {
                hobbi = listBox_hobbi.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Nem választottál ki hobbit", "Hibás adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ures = 1;

            }
            if (ures == 0)
            {
                string egysor = nev + ";" + szulev + ";" + nem + ";" + hobbi;

                saveFileDialog1.FileName = nev +".txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fajl = saveFileDialog1.FileName;
                    using (StreamWriter kiir = new StreamWriter(fajl))
                    {
                        kiir.WriteLine(egysor);
                    }
                    using (StreamWriter lista = new StreamWriter(@"lista.txt"))
                    {
                        foreach (string item in listBox_hobbi.Items)
                        {
                            lista.WriteLine(item);
                        }
                    }
                    textBox_nev.Text = "";
                    dateTimePicker_szuletesdatum.Text = DateTime.Now.ToString("yyyy.MM.dd.");
                    radioButton_ferfi.Checked = true;
                    listBox_hobbi.SelectedIndex = -1;
                }
                else
                {
                    return;
                }
                
            }
        }

        private void button_betoltes_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                using (StreamReader beolvas = new StreamReader (openFileDialog1.FileName))
                {
                    while(!beolvas.EndOfStream)
                    {
                        string[] sor = beolvas.ReadLine().Split(';');
                        textBox_nev.Text = sor[0];
                        dateTimePicker_szuletesdatum.Text = sor[1];
                        if(sor[2]=="ferfi")
                        {
                            radioButton_ferfi.Checked = true;
                        }
                        else
                        {
                            radioButton_no.Checked = true;
                        }
                        listBox_hobbi.SelectedIndex = int.Parse(sor[3]);
                    }
                    beolvas.Close();
                }
            }
        }
    }
}
