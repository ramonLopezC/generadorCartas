using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cartasCREDITO
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }
        public static string mandante { get; set; }
        private void buscar_Click(object sender, EventArgs e)
        {
            if (gridClientes.Rows.Count > 0)
            {
                if (gridClientes.Rows.Count == 1)
                {
                    Datos.res = true;
                    Datos.fila = 0;
                    this.Close();
                }
                    if(gridClientes.Rows.Count>1)
                {                        
                    Datos.res = true;
                    Datos.fila = gridClientes.CurrentRow.Index;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No has realizado ninguna consulta");
            }
         }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Datos.res = false;
            Datos.fila = 0;
            this.Close();
        }

        private void txtNombre_ValueChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == string.Empty)
            {

            }
            else
            {
                switch (mandante)
                {
                    case "sing1":
                        {
                            Datos.bSing = AdminSing1.consulta(txtNombre.Text);
                            if (Datos.bSing.Rows.Count > 0)
                            {
                                gridClientes.DataSource = Datos.bSing;
                                for (int c=0; c < gridClientes.Columns.Count; c++) {
                                    gridClientes.Columns[c].Visible = false;
                                }
                                gridClientes.Columns[0].Visible = true;
                                gridClientes.Columns[1].Visible = true;
                                gridClientes.Columns[2].Visible = true;
                                gridClientes.Columns[3].Visible = true;
                                gridClientes.Columns[8].Visible = true;
                                gridClientes.Columns[0].HeaderText = "Nombre";
                                gridClientes.Columns[1].HeaderText = "Direccion";
                                gridClientes.Columns[2].HeaderText = "Cont Direccion";
                                gridClientes.Columns[3].HeaderText = "Ciudad";
                                gridClientes.Columns[8].HeaderText = "Pie";
                            }
                            else
                            {
                                gridClientes.DataSource = null;
                            }
                            break;
                        }
                    case "sing2":
                        {
                            Datos.bSing = AdminSing2.consulta(txtNombre.Text);
                            if (Datos.bSing.Rows.Count > 0)
                            {
                                gridClientes.DataSource = Datos.bSing;
                                for (int c = 0; c < gridClientes.Columns.Count; c++)
                                {
                                    gridClientes.Columns[c].Visible = false;
                                }
                                gridClientes.Columns[0].Visible = true;
                                gridClientes.Columns[1].Visible = true;
                                gridClientes.Columns[2].Visible = true;
                                gridClientes.Columns[3].Visible = true;
                                gridClientes.Columns[8].Visible = true;
                                gridClientes.Columns[0].HeaderText = "Nombre";
                                gridClientes.Columns[1].HeaderText = "Direccion";
                                gridClientes.Columns[2].HeaderText = "Cont Direccion";
                                gridClientes.Columns[3].HeaderText = "Ciudad";
                                gridClientes.Columns[8].HeaderText = "Pie";
                            }
                            else
                            {
                                gridClientes.DataSource = null;
                            }
                            break;
                        }
                    case "sing3":
                        {
                            Datos.bSing = AdminSing3.consulta(txtNombre.Text);
                            if (Datos.bSing.Rows.Count > 0)
                            {
                                gridClientes.DataSource = Datos.bSing;
                                for (int c = 0; c < gridClientes.Columns.Count; c++)
                                {
                                    gridClientes.Columns[c].Visible = false;
                                }
                                gridClientes.Columns[0].Visible = true;
                                gridClientes.Columns[1].Visible = true;
                                gridClientes.Columns[2].Visible = true;
                                gridClientes.Columns[3].Visible = true;
                                gridClientes.Columns[8].Visible = true;
                                gridClientes.Columns[0].HeaderText = "Nombre";
                                gridClientes.Columns[1].HeaderText = "Direccion";
                                gridClientes.Columns[2].HeaderText = "Cont Direccion";
                                gridClientes.Columns[3].HeaderText = "Ciudad";
                                gridClientes.Columns[8].HeaderText = "Pie";
                            }
                            else
                            {
                                gridClientes.DataSource = null;
                            }
                            break;
                        }
                    case "sing4":
                        {
                            Datos.bSing = AdminSing4.consulta(txtNombre.Text);
                            if (Datos.bSing.Rows.Count > 0)
                            {
                                gridClientes.DataSource = Datos.bSing;
                                for (int c = 0; c < gridClientes.Columns.Count; c++)
                                {
                                    gridClientes.Columns[c].Visible = false;
                                }
                                gridClientes.Columns[0].Visible = true;
                                gridClientes.Columns[1].Visible = true;
                                gridClientes.Columns[2].Visible = true;
                                gridClientes.Columns[3].Visible = true;
                                gridClientes.Columns[8].Visible = true;
                                gridClientes.Columns[0].HeaderText = "Nombre";
                                gridClientes.Columns[1].HeaderText = "Direccion";
                                gridClientes.Columns[2].HeaderText = "Cont Direccion";
                                gridClientes.Columns[3].HeaderText = "Ciudad";
                                gridClientes.Columns[8].HeaderText = "Pie";
                            }
                            else
                            {
                                gridClientes.DataSource = null;
                            }
                            break;
                        }
                    case "sing5":
                        {
                            Datos.bSing = AdminSing5.consulta(txtNombre.Text);
                            if (Datos.bSing.Rows.Count > 0)
                            {
                                gridClientes.DataSource = Datos.bSing;
                                for (int c = 0; c < gridClientes.Columns.Count; c++)
                                {
                                    gridClientes.Columns[c].Visible = false;
                                }
                                gridClientes.Columns[0].Visible = true;
                                gridClientes.Columns[1].Visible = true;
                                gridClientes.Columns[2].Visible = true;
                                gridClientes.Columns[3].Visible = true;
                                gridClientes.Columns[8].Visible = true;
                                gridClientes.Columns[0].HeaderText = "Nombre";
                                gridClientes.Columns[1].HeaderText = "Direccion";
                                gridClientes.Columns[2].HeaderText = "Cont Direccion";
                                gridClientes.Columns[3].HeaderText = "Ciudad";
                                gridClientes.Columns[8].HeaderText = "Pie";
                            }
                            else
                            {
                                gridClientes.DataSource = null;
                            }
                            break;
                        }
                    case "plural1":
                        {
                            Datos.bSing = AdminPlural1.consulta(txtNombre.Text);
                            if (Datos.bSing.Rows.Count > 0)
                            {
                                gridClientes.DataSource = Datos.bSing;
                                for (int c = 0; c < gridClientes.Columns.Count; c++)
                                {
                                    gridClientes.Columns[c].Visible = false;
                                }
                                gridClientes.Columns[0].Visible = true;
                                gridClientes.Columns[1].Visible = true;
                                gridClientes.Columns[2].Visible = true;
                                gridClientes.Columns[3].Visible = true;
                                gridClientes.Columns[8].Visible = true;
                                gridClientes.Columns[0].HeaderText = "Nombre";
                                gridClientes.Columns[1].HeaderText = "Direccion";
                                gridClientes.Columns[2].HeaderText = "Cont Direccion";
                                gridClientes.Columns[3].HeaderText = "Ciudad";
                                gridClientes.Columns[8].HeaderText = "Pie";
                            }
                            else
                            {
                                gridClientes.DataSource = null;
                            }
                            break;
                        }
                    case "plural2":
                        {
                            Datos.bSing = AdminPlural2.consulta(txtNombre.Text);
                            if (Datos.bSing.Rows.Count > 0)
                            {
                                gridClientes.DataSource = Datos.bSing;
                                for (int c = 0; c < gridClientes.Columns.Count; c++)
                                {
                                    gridClientes.Columns[c].Visible = false;
                                }
                                gridClientes.Columns[0].Visible = true;
                                gridClientes.Columns[1].Visible = true;
                                gridClientes.Columns[2].Visible = true;
                                gridClientes.Columns[3].Visible = true;
                                gridClientes.Columns[8].Visible = true;
                                gridClientes.Columns[0].HeaderText = "Nombre";
                                gridClientes.Columns[1].HeaderText = "Direccion";
                                gridClientes.Columns[2].HeaderText = "Cont Direccion";
                                gridClientes.Columns[3].HeaderText = "Ciudad";
                                gridClientes.Columns[8].HeaderText = "Pie";
                            }
                            else
                            {
                                gridClientes.DataSource = null;
                            }
                            break;
                        }
                    case "plural3":
                        {
                            Datos.bSing = AdminPlural3.consulta(txtNombre.Text);
                            if (Datos.bSing.Rows.Count > 0)
                            {
                                gridClientes.DataSource = Datos.bSing;
                                for (int c = 0; c < gridClientes.Columns.Count; c++)
                                {
                                    gridClientes.Columns[c].Visible = false;
                                }
                                gridClientes.Columns[0].Visible = true;
                                gridClientes.Columns[1].Visible = true;
                                gridClientes.Columns[2].Visible = true;
                                gridClientes.Columns[3].Visible = true;
                                gridClientes.Columns[8].Visible = true;
                                gridClientes.Columns[0].HeaderText = "Nombre";
                                gridClientes.Columns[1].HeaderText = "Direccion";
                                gridClientes.Columns[2].HeaderText = "Cont Direccion";
                                gridClientes.Columns[3].HeaderText = "Ciudad";
                                gridClientes.Columns[8].HeaderText = "Pie";
                            }
                            else
                            {
                                gridClientes.DataSource = null;
                            }
                            break;
                        }
                    case "plural4":
                        {
                            Datos.bSing = AdminPlural4.consulta(txtNombre.Text);
                            if (Datos.bSing.Rows.Count > 0)
                            {
                                gridClientes.DataSource = Datos.bSing;
                                for (int c = 0; c < gridClientes.Columns.Count; c++)
                                {
                                    gridClientes.Columns[c].Visible = false;
                                }
                                gridClientes.Columns[0].Visible = true;
                                gridClientes.Columns[1].Visible = true;
                                gridClientes.Columns[2].Visible = true;
                                gridClientes.Columns[3].Visible = true;
                                gridClientes.Columns[8].Visible = true;
                                gridClientes.Columns[0].HeaderText = "Nombre";
                                gridClientes.Columns[1].HeaderText = "Direccion";
                                gridClientes.Columns[2].HeaderText = "Cont Direccion";
                                gridClientes.Columns[3].HeaderText = "Ciudad";
                                gridClientes.Columns[8].HeaderText = "Pie";
                            }
                            else
                            {
                                gridClientes.DataSource = null;
                            }
                            break;
                        }
                    case "plural5":
                        {
                            Datos.bSing = AdminPlural5.consulta(txtNombre.Text);
                            if (Datos.bSing.Rows.Count > 0)
                            {
                                gridClientes.DataSource = Datos.bSing;
                                for (int c = 0; c < gridClientes.Columns.Count; c++)
                                {
                                    gridClientes.Columns[c].Visible = false;
                                }
                                gridClientes.Columns[0].Visible = true;
                                gridClientes.Columns[1].Visible = true;
                                gridClientes.Columns[2].Visible = true;
                                gridClientes.Columns[3].Visible = true;
                                gridClientes.Columns[8].Visible = true;
                                gridClientes.Columns[0].HeaderText = "Nombre";
                                gridClientes.Columns[1].HeaderText = "Direccion";
                                gridClientes.Columns[2].HeaderText = "Cont Direccion";
                                gridClientes.Columns[3].HeaderText = "Ciudad";
                                gridClientes.Columns[8].HeaderText = "Pie";
                            }
                            else
                            {
                                gridClientes.DataSource = null;
                            }
                            break;
                        }

                }
            }


            
        }
        }
    }

