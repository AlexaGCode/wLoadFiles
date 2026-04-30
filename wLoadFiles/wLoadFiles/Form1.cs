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

namespace wLoadFiles
{
    public partial class frmPlano : Form
    {
        public frmPlano()
        {
            InitializeComponent();
        }

        private Stream mySteam;
        int counter = 0;
        string line;

        //Permite cargar archivo línea a línea
        private void btnPorLineas_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos (*.*)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mySteam = openFileDialog.OpenFile()) != null)
                    {
                        using (mySteam)
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName);
                            while ((line = file.ReadLine()) != null)
                            {
                                txtArchivo.Text = txtArchivo.Text + line + Environment.NewLine;
                                counter ++;
                            }
                            file.Close();
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: podria seleccionar el archivo plano?: " + ex.Message);
                }

            }
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            string[] result;
            //configurar el datagidview
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Columna1";
            col1.Width = 200;
            col1.ReadOnly = true;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Archivo (*.cvs)|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                if ((mySteam = openFileDialog1.OpenFile()) != null)
                {
                    using (mySteam)
                    {
                        System.IO.StreamReader file = new StreamReader(openFileDialog1.FileName);
                        while ((line = file.ReadLine()) != null)
                        {
                            result = line.Split(';');
                            dtgGrid.Rows.Add(result[0], result[1], result[2]);
                            counter++;
                        }
                        file.Close();
                    }
                }
            }
        }
    }
}
