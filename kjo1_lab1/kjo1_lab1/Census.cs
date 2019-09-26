using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kjo1_lab1
{
    public partial class Census : Form
    {
        int[,] arrayPop = new int[13, 48]; // 13 rows, 48 cols

        public Census()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            txtProvince.Focus();
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            //sfd.FileName = "Canadian Census Information";
            sfd.Filter = "Text Files|*.txt|AllFiles|*.*";
            sfd.DefaultExt = "txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);

                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(string.Format("Canadian Population Information " + DateTime.Now.ToString("(yyyy-MM-dd)\n")));
                    for (int i = 0; i < 13; i++)
                    {
                        sw.WriteLine(string.Format("Province ID #{0}", i));
                        for (int j = 0; j < 48; j++)
                            sw.WriteLine(string.Format("\tRegion ID #{0}: {1}", new object[] { j, arrayPop[i, j] }));                        
                    }

                }
            }
            ClearAllData();
        }

        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        private void BtnClearData_Click(object sender, EventArgs e)
        {
            this.ClearAllData();
            txtProvince.Focus();
        }

        void ClearAllData()
        {
            Array.Clear(arrayPop, 0, arrayPop.Length);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int provinceID;
            int regionID;
            if (!int.TryParse(txtProvince.Text, out provinceID) || provinceID > 12)
            {
                MessageBox.Show("Please enter a Province ID from between 0 to 12", "Error!");
                txtProvince.Focus();
            }

            else if (!int.TryParse(txtRegion.Text, out regionID) || regionID > 47)
            {
                MessageBox.Show("Please enter a Regin ID between 0 to 47", "Error!");
                txtRegion.Focus();
            }
            else if (!int.TryParse(txtPopulation.Text, out arrayPop[provinceID, regionID]))
            {
                MessageBox.Show("That's way too big!!!\n" +
                    " Maximum accept input (2,147,483,647)\n" +
                    "Canada 2019 population is estimated at 37,411,047 people at mid year according to UN data.\n" +
                    " Canada population is equivalent to 0.49% of the total world population.", "For Your Information!");
                txtPopulation.Focus();
            }
            else
            {
                MessageBox.Show("Population: " + string.Format("{0:#,0}", Convert.ToInt32(txtPopulation.Text)) +
                                "\nsaved for Prov #" + txtProvince.Text +
                                ", Region #" + txtRegion.Text, "Success!");
                ClearAllText(this);
                txtProvince.Focus();
            }
        }



        // not allow any key but numeric.
        private void TxtRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPopulation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtProvince_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
