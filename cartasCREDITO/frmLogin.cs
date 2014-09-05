using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace cartasCREDITO
{
    public partial class frmLogin : Form
    {
        public int a = 0;
        public frmLogin()
        {
            InitializeComponent();;
 
        }      
        private void frmLogin_Load(object sender, EventArgs e)
        {
            indicador.Start();
            Thread cargar = new Thread(dataProyecto);
            cargar.Start();             
            while (cargar.ThreadState != ThreadState.Stopped)
            {
            }                        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        void dataProyecto() {
            Datos.datosSing1 = AdminSing1.buscaDatosSing1();
            Datos.datosSing2 = AdminSing2.buscaDatosSing2();
            Datos.datosSing3 = AdminSing3.buscaDatosSing3();
            Datos.datosSing4 = AdminSing4.buscaDatosSing4();
            Datos.datosSing5 = AdminSing5.buscaDatosSing5();
            Datos.datosPlural1 = AdminPlural1.buscaDatosPlural1();
            Datos.datosPlural2 = AdminPlural2.buscaDatosPlural2();
            Datos.datosPlural3 = AdminPlural3.buscaDatosPlural3();
            Datos.datosPlural4 = AdminPlural4.buscaDatosPlural4();
            Datos.datosPlural5 = AdminPlural5.buscaDatosPlural5();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (a == 0)
            {
                a = 1;
                info.Text = "Modulo 1 Cargado";
            }
            else
                if (a == 1)
                {
                    a = 2;
                    info.Text = "Modulo 2 Cargado";
                }
                else
                    if (a == 2)
                    {
                        a = 9;
                        info.Text = "Modulo 3 Cargado";
                        frmPrincipal p = new frmPrincipal();
                        this.Hide();
                        p.Show();
                        indicador.Stop();
                        timer1.Enabled = false;
                    }
        }
  
 
    }
}
