using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace cartasCREDITO
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public void navegacionSing1(int actual, int total)
        {
            if (actual > 0 && actual < total)
            {
                sing1Primero.Enabled = true;
                sing1Atras.Enabled = true;
                sing1Ultimo.Enabled = true;
                sing1Siguiente.Enabled = true;
            }
            else
                if (actual == 0 && total > 0)
                {
                    sing1Primero.Enabled = false;
                    sing1Atras.Enabled = false;
                    sing1Ultimo.Enabled = true;
                    sing1Siguiente.Enabled = true;
                }
                else
                    if (actual > 0 && actual == total)
                    {
                        sing1Primero.Enabled = true;
                        sing1Atras.Enabled = true;
                        sing1Ultimo.Enabled = false;
                        sing1Siguiente.Enabled = false;
                    }
                    else
                        if (actual == 0 && total == 0)
                        {
                            sing1Primero.Enabled = false;
                            sing1Atras.Enabled = false;
                            sing1Ultimo.Enabled = false;
                            sing1Siguiente.Enabled = false;
                        }
        }
        public void navegacionSing2(int actual, int total)
        {
            if (actual > 0 && actual < total)
            {
                btnSing2Primero.Enabled = true;
                btnSing2Atras.Enabled = true;
                btnSing2Ultimo.Enabled = true;
                btnSing2Siguiente.Enabled = true;
            }
            else
                if (actual == 0 && total > 0)
                {
                    btnSing2Atras.Enabled = false;
                    btnSing2Primero.Enabled = false;
                    btnSing2Siguiente.Enabled = true;
                    btnSing2Ultimo.Enabled = true;
                }
                else
                    if (actual > 0 && actual == total)
                    {
                        btnSing2Primero.Enabled = true;
                        btnSing2Atras.Enabled = true;
                        btnSing2Ultimo.Enabled = false;
                        btnSing2Siguiente.Enabled = false;
                    }
                    else
                        if (actual == 0 && total == 0)
                        {
                            btnSing2Primero.Enabled = false;
                            btnSing2Atras.Enabled = false;
                            btnSing2Ultimo.Enabled = false;
                            btnSing2Siguiente.Enabled = false;
                        }
        }
        public void navegacionSing3(int actual, int total)
        {
            if (actual > 0 && actual < total)
            {
                sing3Primero.Enabled = true;
                sing3Atras.Enabled = true;
                sing3Ultimo.Enabled = true;
                sing3Siguiente.Enabled = true;
            }
            else
                if (actual == 0 && total > 0)
                {
                    sing3Primero.Enabled = false;
                    sing3Atras.Enabled = false;
                    sing3Ultimo.Enabled = true;
                    sing3Siguiente.Enabled = true;
                }
                else
                    if (actual > 0 && actual == total)
                    {
                        sing3Primero.Enabled = true;
                        sing3Atras.Enabled = true;
                        sing3Ultimo.Enabled = false;
                        sing3Siguiente.Enabled = false;
                    }
                    else
                        if (actual == 0 && total == 0)
                        {
                            sing3Primero.Enabled = false;
                            sing3Atras.Enabled = false;
                            sing3Ultimo.Enabled = false;
                            sing3Siguiente.Enabled = false;
                        }
        }
        public void navegacionSing4(int actual, int total)
        {
            if (actual > 0 && actual < total)
            {
                sing4Primero.Enabled = true;
                sing4Atras.Enabled = true;
                sing4Ultimo.Enabled = true;
                sing4Siguiente.Enabled = true;
            }
            else
                if (actual == 0 && total > 0)
                {
                    sing4Primero.Enabled = false;
                    sing4Atras.Enabled = false;
                    sing4Ultimo.Enabled = true;
                    sing4Siguiente.Enabled = true;
                }
                else
                    if (actual > 0 && actual == total)
                    {
                        sing4Primero.Enabled = true;
                        sing4Atras.Enabled = true;
                        sing4Ultimo.Enabled = false;
                        sing4Siguiente.Enabled = false;
                    }
                    else
                        if (actual == 0 && total == 0)
                        {
                            sing4Primero.Enabled = false;
                            sing4Atras.Enabled = false;
                            sing4Ultimo.Enabled = false;
                            sing4Siguiente.Enabled = false;
                        }
        }
        public void navegacionSing5(int actual, int total)
        {
            if (actual > 0 && actual < total)
            {
                sing5Primero.Enabled = true;
                sing5Atras.Enabled = true;
                sing5Ultimo.Enabled = true;
                sing5Siguiente.Enabled = true;
            }
            else
                if (actual == 0 && total > 0)
                {
                    sing5Primero.Enabled = false;
                    sing5Atras.Enabled = false;
                    sing5Ultimo.Enabled = true;
                    sing5Siguiente.Enabled = true;
                }
                else
                    if (actual > 0 && actual == total)
                    {
                        sing5Primero.Enabled = true;
                        sing5Atras.Enabled = true;
                        sing5Ultimo.Enabled = false;
                        sing5Siguiente.Enabled = false;
                    }
                    else
                        if (actual == 0 && total == 0)
                        {
                            sing5Primero.Enabled = false;
                            sing5Atras.Enabled = false;
                            sing5Ultimo.Enabled = false;
                            sing5Siguiente.Enabled = false;
                        }
        }
        public void navegacionPlural1(int actual, int total)
        {
            if (actual > 0 && actual < total)
            {
                plural1Primero.Enabled = true;
                plural1Atras.Enabled = true;
                plural1Ultimo.Enabled = true;
                plural1Siguiente.Enabled = true;
            }
            else
                if (actual == 0 && total > 0)
                {
                    plural1Primero.Enabled = false;
                    plural1Atras.Enabled = false;
                    plural1Ultimo.Enabled = true;
                    plural1Siguiente.Enabled = true;
                }
                else
                    if (actual > 0 && actual == total)
                    {
                        plural1Primero.Enabled = true;
                        plural1Atras.Enabled = true;
                        plural1Ultimo.Enabled = false;
                        plural1Siguiente.Enabled = false;
                    }
                    else
                        if (actual == 0 && total == 0)
                        {
                            plural1Primero.Enabled = false;
                            plural1Atras.Enabled = false;
                            plural1Ultimo.Enabled = false;
                            plural1Siguiente.Enabled = false;
                        }
        }
        public void navegacionPlural2(int actual, int total)
        {
            if (actual > 0 && actual < total)
            {
                plural2Primero.Enabled = true;
                plural2Atras.Enabled = true;
                plural2Ultimo.Enabled = true;
                plural2Siguiente.Enabled = true;
            }
            else
                if (actual == 0 && total > 0)
                {
                    plural2Primero.Enabled = false;
                    plural2Atras.Enabled = false;
                    plural2Ultimo.Enabled = true;
                    plural2Siguiente.Enabled = true;
                }
                else
                    if (actual > 0 && actual == total)
                    {
                        plural2Primero.Enabled = true;
                        plural2Atras.Enabled = true;
                        plural2Ultimo.Enabled = false;
                        plural2Siguiente.Enabled = false;
                    }
                    else
                        if (actual == 0 && total == 0)
                        {
                            plural2Primero.Enabled = false;
                            plural2Atras.Enabled = false;
                            plural2Ultimo.Enabled = false;
                            plural2Siguiente.Enabled = false;
                        }
        }
        public void navegacionPlural3(int actual, int total)
        {
            if (actual > 0 && actual < total)
            {
                plural3Primero.Enabled = true;
                plural3Atras.Enabled = true;
                plural3Ultimo.Enabled = true;
                plural3Siguiente.Enabled = true;
            }
            else
                if (actual == 0 && total > 0)
                {
                    plural3Primero.Enabled = false;
                    plural3Atras.Enabled = false;
                    plural3Ultimo.Enabled = true;
                    plural3Siguiente.Enabled = true;
                }
                else
                    if (actual > 0 && actual == total)
                    {
                        plural3Primero.Enabled = true;
                        plural3Atras.Enabled = true;
                        plural3Ultimo.Enabled = false;
                        plural3Siguiente.Enabled = false;
                    }
                    else
                        if (actual == 0 && total == 0)
                        {
                            plural3Primero.Enabled = false;
                            plural3Atras.Enabled = false;
                            plural3Ultimo.Enabled = false;
                            plural3Siguiente.Enabled = false;
                        }
        }
        public void navegacionPlural4(int actual, int total)
        {
            if (actual > 0 && actual < total)
            {
                plural4Primero.Enabled = true;
                plural4Atras.Enabled = true;
                plural4Ultimo.Enabled = true;
                plural4Siguiente.Enabled = true;
            }
            else
                if (actual == 0 && total > 0)
                {
                    plural4Primero.Enabled = false;
                    plural4Atras.Enabled = false;
                    plural4Ultimo.Enabled = true;
                    plural4Siguiente.Enabled = true;
                }
                else
                    if (actual > 0 && actual == total)
                    {
                        plural4Primero.Enabled = true;
                        plural4Atras.Enabled = true;
                        plural4Ultimo.Enabled = false;
                        plural4Siguiente.Enabled = false;
                    }
                    else
                        if (actual == 0 && total == 0)
                        {
                            plural4Primero.Enabled = false;
                            plural4Atras.Enabled = false;
                            plural4Ultimo.Enabled = false;
                            plural4Siguiente.Enabled = false;
                        }
        }
        public void navegacionPlural5(int actual, int total)
        {
            if (actual > 0 && actual < total)
            {
                plural5Primero.Enabled = true;
                plural5Atras.Enabled = true;
                plural5Ultimo.Enabled = true;
                plural5Siguiente.Enabled = true;
            }
            else
                if (actual == 0 && total > 0)
                {
                    plural5Primero.Enabled = false;
                    plural5Atras.Enabled = false;
                    plural5Ultimo.Enabled = true;
                    plural5Siguiente.Enabled = true;
                }
                else
                    if (actual > 0 && actual == total)
                    {
                        plural5Primero.Enabled = true;
                        plural5Atras.Enabled = true;
                        plural5Ultimo.Enabled = false;
                        plural5Siguiente.Enabled = false;
                    }
                    else
                        if (actual == 0 && total == 0)
                        {
                            plural5Primero.Enabled = false;
                            plural5Atras.Enabled = false;
                            plural5Ultimo.Enabled = false;
                            plural5Siguiente.Enabled = false;
                        }
        }
        public static void soloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
        public static void soloDecimales(KeyPressEventArgs pE,string valor)
        {
            if (pE.KeyChar == 8)
            {
                pE.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;
            for (int i = 0; i < valor.Length; i++)
            {
                if (valor[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    pE.Handled = true;
                    return;
                }
            }
            if (pE.KeyChar >= 48 && pE.KeyChar <= 57)
                pE.Handled = false;
            else if (pE.KeyChar == 46)
                pE.Handled = (IsDec) ? true : false;
            else
                pE.Handled = true;       
        }
        public static int filaSing1 { get; set; }
        public static int filaSing2 { get; set; }
        public static int filaSing3 { get; set; }
        public static int filaSing4 { get; set; }
        public static int filaSing5 { get; set; }
        public static int filaPlural1 { get; set; }
        public static int filaPlural2 { get; set; }
        public static int filaPlural3 { get; set; }
        public static int filaPlural4 { get; set; }
        public static int filaPlural5 { get; set; }
        public static bool busSing1 { get; set; }
        public static bool busSing2 { get; set; }
        public static bool busSing3 { get; set; }
        public static bool busSing4 { get; set; }
        public static bool busSing5 { get; set; }
        public static bool busPlural1 { get; set; }
        public static bool busPlural2 { get; set; }
        public static bool busPlural3 { get; set; }
        public static bool busPlural4 { get; set; }
        public static bool busPlural5 { get; set; }
        public static string tipoSing1 { get; set; }
        public static string tipoSing2 { get; set; }
        public static string tipoSing3 { get; set; }
        public static string tipoSing4 { get; set; }
        public static string tipoSing5 { get; set; }
        public static string tipoPlural1 { get; set; }
        public static string tipoPlural2 { get; set; }
        public static string tipoPlural3 { get; set; }
        public static string tipoPlural4 { get; set; }
        public static string tipoPlural5 { get; set; }
        void actualizarSing1() {
            bloquearSing1();
            if (Datos.datosSing1.Rows.Count > 0)
            {
                if (Datos.datosSing1.Rows.Count == 1)
                {
                    cargaSing1(Datos.datosSing1.Rows[0]);
                    filaSing1 = 0;
                    sing1Primero.Enabled = false;
                    sing1Atras.Enabled = false;
                    sing1Siguiente.Enabled = false;
                    sing1Ultimo.Enabled = false;
                    sing1Conteo.Text = "1 de 1";
                    sing1Modificar.Enabled = true;
                    sing1Borrar.Enabled = true;
                    sing1Buscar.Enabled = false;
                    sing1Nuevo.Enabled = true;
                    sing1Registrar.Enabled = false;
                }
                else
                {
                    sing1Modificar.Enabled = true;
                    sing1Registrar.Enabled = false;
                    sing1Nuevo.Enabled = true;
                    cargaSing1(Datos.datosSing1.Rows[0]);
                    filaSing1 = 0;
                    sing1Primero.Enabled = false;
                    sing1Atras.Enabled = false;
                    sing1Buscar.Enabled = true;
                    sing1Siguiente.Enabled = true;
                    sing1Ultimo.Enabled = true;
                    sing1Borrar.Enabled = true;
                    sing1Conteo.Text = "1 de " + Datos.datosSing1.Rows.Count.ToString();
                }
            }
            else
            {
                sing1Modificar.Enabled = false;
                limpiarSing1();
                bloquearSing1();
                sing1Conteo.Text = "No hay registros";
                sing1Primero.Enabled = false;
                sing1Atras.Enabled = false;
                sing1Siguiente.Enabled = false;
                sing1Ultimo.Enabled = false;
                sing1Modificar.Enabled = true;
                sing1Borrar.Enabled = false;
                sing1Buscar.Enabled = false;
                sing1Modificar.Enabled = false;
                sing1Registrar.Enabled = false;
                sing1Cancelar.Enabled = false;
                sing1Nuevo.Enabled = true;
            }
        }
        void actualizarSing2()
        {
            bloquearSing2();
            if (Datos.datosSing2.Rows.Count > 0)
            {
                if (Datos.datosSing2.Rows.Count == 1)
                {
                    cargaSing2(Datos.datosSing2.Rows[0]);
                    filaSing2 = 0;
                    btnSing2Primero.Enabled = false;
                    btnSing2Atras.Enabled = false;
                    btnSing2Siguiente.Enabled = false;
                    btnSing2Ultimo.Enabled = false;
                    conteo.Text = "1 de 1";
                    btnSing2Modificar.Enabled = true;
                    btnSing2Borrar.Enabled = true;
                    btnSing2Nuevo.Enabled = true;
                    btnSing2Registrar.Enabled = false;
                }
                else
                {
                    btnSing2Modificar.Enabled = true;
                    btnSing2Registrar.Enabled = false;
                    btnSing2Nuevo.Enabled = true;
                    cargaSing2(Datos.datosSing2.Rows[0]);
                    filaSing2 = 0;
                    btnSing2Primero.Enabled = false;
                    btnSing2Atras.Enabled = false;
                    btnSing2Buscar.Enabled = true;
                    btnSing2Siguiente.Enabled = true;
                    btnSing2Ultimo.Enabled = true;
                    btnSing2Borrar.Enabled = true;
                    conteo.Text = "1 de " + Datos.datosSing2.Rows.Count.ToString();
                }
            }
            else
            {
                btnSing2Modificar.Enabled = false;
                limpiarSing2();
                bloquearSing2();
                conteo.Text = "No hay registros";
                btnSing2Primero.Enabled = false;
                btnSing2Atras.Enabled = false;
                btnSing2Siguiente.Enabled = false;
                btnSing2Ultimo.Enabled = false;
                btnSing2Modificar.Enabled = true;
                btnSing2Borrar.Enabled = false;
                btnSing2Buscar.Enabled = false;
                btnSing2Modificar.Enabled = false;
                btnSing2Registrar.Enabled = false;
                btnSing2Cancelar.Enabled = false;
                btnSing2Nuevo.Enabled = true;
            }
        }
        void actualizaPlural1()
        {
            bloquearPlural1();
            if (Datos.datosPlural1.Rows.Count > 0)
            {

                if (Datos.datosPlural1.Rows.Count == 1)
                {
                    cargaPlural1(Datos.datosPlural1.Rows[0]);
                    filaPlural1 = 0;
                    plural1Primero.Enabled = false;
                    plural1Atras.Enabled = false;
                    plural1Siguiente.Enabled = false;
                    plural1Ultimo.Enabled = false;
                    plural1Conteo.Text = "1 de 1";
                    plural1Modificar.Enabled = true;
                    plural1Borrar.Enabled = true;
                    plural1Buscar.Enabled = false;
                    plural1Nuevo.Enabled = true;
                    plural1Registrar.Enabled = false;
                }
                else
                {
                    plural1Modificar.Enabled = true;
                    plural1Registrar.Enabled = false;
                    plural1Nuevo.Enabled = true;
                    cargaPlural1(Datos.datosPlural1.Rows[0]);
                    filaPlural1 = 0;
                    plural1Primero.Enabled = false;
                    plural1Atras.Enabled = false;
                    plural1Buscar.Enabled = true;
                    plural1Siguiente.Enabled = true;
                    plural1Ultimo.Enabled = true;
                    plural1Borrar.Enabled = true;
                    plural1Conteo.Text = "1 de " + Datos.datosPlural1.Rows.Count.ToString();
                }
            }
            else
            {
                plural1Modificar.Enabled = false;
                limpiarPlural1();
                bloquearPlural1();
                plural1Conteo.Text = "No hay registros";
                plural1Primero.Enabled = false;
                plural1Atras.Enabled = false;
                plural1Siguiente.Enabled = false;
                plural1Ultimo.Enabled = false;
                plural1Modificar.Enabled = true;
                plural1Borrar.Enabled = false;
                plural1Buscar.Enabled = false;
                plural1Modificar.Enabled = false;
                plural1Registrar.Enabled = false;
                plural1Cancelar.Enabled = false;
                plural1Nuevo.Enabled = true;
            }
        }
        void actualizaPlural2()
        {
            bloquearPlural2();
            if (Datos.datosPlural2.Rows.Count > 0)
            {

                if (Datos.datosPlural2.Rows.Count == 1)
                {
                    cargaPlural2(Datos.datosPlural2.Rows[0]);
                    filaPlural2 = 0;
                    plural2Primero.Enabled = false;
                    plural2Atras.Enabled = false;
                    plural2Siguiente.Enabled = false;
                    plural2Ultimo.Enabled = false;
                    plural2Conteo.Text = "1 de 1";
                    plural2Modificar.Enabled = true;
                    plural2Borrar.Enabled = true;
                    plural2Buscar.Enabled = false;
                    plural2Nuevo.Enabled = true;
                    plural2Registrar.Enabled = false;
                }
                else
                {
                    plural2Modificar.Enabled = true;
                    plural2Registrar.Enabled = false;
                    plural2Nuevo.Enabled = true;
                    cargaPlural2(Datos.datosPlural2.Rows[0]);
                    filaPlural2 = 0;
                    plural2Primero.Enabled = false;
                    plural2Atras.Enabled = false;
                    plural2Buscar.Enabled = true;
                    plural2Siguiente.Enabled = true;
                    plural2Ultimo.Enabled = true;
                    plural2Borrar.Enabled = true;
                    plural2Conteo.Text = "1 de " + Datos.datosPlural2.Rows.Count.ToString();
                }
            }
            else
            {
                plural2Modificar.Enabled = false;
                limpiarPlural2();
                bloquearPlural2();
                plural2Conteo.Text = "No hay registros";
                plural2Primero.Enabled = false;
                plural2Atras.Enabled = false;
                plural2Siguiente.Enabled = false;
                plural2Ultimo.Enabled = false;
                plural2Modificar.Enabled = true;
                plural2Borrar.Enabled = false;
                plural2Buscar.Enabled = false;
                plural2Modificar.Enabled = false;
                plural2Registrar.Enabled = false;
                plural2Cancelar.Enabled = false;
                plural2Nuevo.Enabled = true;
            }
        }
        void actualizaPlural3()
        {
            bloquearPlural3();
            if (Datos.datosPlural3.Rows.Count > 0)
            {

                if (Datos.datosPlural3.Rows.Count == 1)
                {
                    cargaPlural3(Datos.datosPlural3.Rows[0]);
                    filaPlural3 = 0;
                    plural3Primero.Enabled = false;
                    plural3Atras.Enabled = false;
                    plural3Siguiente.Enabled = false;
                    plural3Ultimo.Enabled = false;
                    plural3Conteo.Text = "1 de 1";
                    plural3Modificar.Enabled = true;
                    plural3Borrar.Enabled = true;
                    plural3Buscar.Enabled = false;
                    plural3Nuevo.Enabled = true;
                    plural3Registrar.Enabled = false;
                }
                else
                {
                    plural3Modificar.Enabled = true;
                    plural3Registrar.Enabled = false;
                    plural3Nuevo.Enabled = true;
                    cargaPlural3(Datos.datosPlural3.Rows[0]);
                    filaPlural3 = 0;
                    plural3Primero.Enabled = false;
                    plural3Atras.Enabled = false;
                    plural3Buscar.Enabled = true;
                    plural3Siguiente.Enabled = true;
                    plural3Ultimo.Enabled = true;
                    plural3Borrar.Enabled = true;
                    plural3Conteo.Text = "1 de " + Datos.datosPlural3.Rows.Count.ToString();
                }
            }
            else
            {
                plural3Modificar.Enabled = false;
                limpiarPlural3();
                bloquearPlural3();
                plural3Conteo.Text = "No hay registros";
                plural3Primero.Enabled = false;
                plural3Atras.Enabled = false;
                plural3Siguiente.Enabled = false;
                plural3Ultimo.Enabled = false;
                plural3Modificar.Enabled = true;
                plural3Borrar.Enabled = false;
                plural3Buscar.Enabled = false;
                plural3Modificar.Enabled = false;
                plural3Registrar.Enabled = false;
                plural3Cancelar.Enabled = false;
                plural3Nuevo.Enabled = true;
            }
        }
        void actualizaPlural4()
        {
            bloquearPlural4();
            if (Datos.datosPlural4.Rows.Count > 0)
            {

                if (Datos.datosPlural4.Rows.Count == 1)
                {
                    cargaPlural4(Datos.datosPlural4.Rows[0]);
                    filaPlural4 = 0;
                    plural4Primero.Enabled = false;
                    plural4Atras.Enabled = false;
                    plural4Siguiente.Enabled = false;
                    plural4Ultimo.Enabled = false;
                    plural4Conteo.Text = "1 de 1";
                    plural4Modificar.Enabled = true;
                    plural4Borrar.Enabled = true;
                    plural4Buscar.Enabled = false;
                    plural4Nuevo.Enabled = true;
                    plural4Registrar.Enabled = false;
                }
                else
                {
                    plural4Modificar.Enabled = true;
                    plural4Registrar.Enabled = false;
                    plural4Nuevo.Enabled = true;
                    cargaPlural4(Datos.datosPlural4.Rows[0]);
                    filaPlural4 = 0;
                    plural4Primero.Enabled = false;
                    plural4Atras.Enabled = false;
                    plural4Buscar.Enabled = true;
                    plural4Siguiente.Enabled = true;
                    plural4Ultimo.Enabled = true;
                    plural4Borrar.Enabled = true;
                    plural4Conteo.Text = "1 de " + Datos.datosPlural4.Rows.Count.ToString();
                }
            }
            else
            {
                plural4Modificar.Enabled = false;
                limpiarPlural4();
                bloquearPlural4();
                plural4Conteo.Text = "No hay registros";
                plural4Primero.Enabled = false;
                plural4Atras.Enabled = false;
                plural4Siguiente.Enabled = false;
                plural4Ultimo.Enabled = false;
                plural4Modificar.Enabled = true;
                plural4Borrar.Enabled = false;
                plural4Buscar.Enabled = false;
                plural4Modificar.Enabled = false;
                plural4Registrar.Enabled = false;
                plural4Cancelar.Enabled = false;
                plural4Nuevo.Enabled = true;
            }
        }
        void actualizaPlural5()
        {
            bloquearPlural5();
            if (Datos.datosPlural5.Rows.Count > 0)
            {

                if (Datos.datosPlural5.Rows.Count == 1)
                {
                    cargaPlural5(Datos.datosPlural5.Rows[0]);
                    filaPlural5 = 0;
                    plural5Primero.Enabled = false;
                    plural5Atras.Enabled = false;
                    plural5Siguiente.Enabled = false;
                    plural5Ultimo.Enabled = false;
                    plural5Conteo.Text = "1 de 1";
                    plural5Modificar.Enabled = true;
                    plural5Borrar.Enabled = true;
                    plural5Buscar.Enabled = false;
                    plural5Nuevo.Enabled = true;
                    plural5Registrar.Enabled = false;
                }
                else
                {
                    plural5Modificar.Enabled = true;
                    plural5Registrar.Enabled = false;
                    plural5Nuevo.Enabled = true;
                    cargaPlural5(Datos.datosPlural5.Rows[0]);
                    filaPlural5 = 0;
                    plural5Primero.Enabled = false;
                    plural5Atras.Enabled = false;
                    plural5Buscar.Enabled = true;
                    plural5Siguiente.Enabled = true;
                    plural5Ultimo.Enabled = true;
                    plural5Borrar.Enabled = true;
                    plural5Conteo.Text = "1 de " + Datos.datosPlural5.Rows.Count.ToString();
                }
            }
            else
            {
                plural5Modificar.Enabled = false;
                limpiarPlural5();
                bloquearPlural5();
                plural5Conteo.Text = "No hay registros";
                plural5Primero.Enabled = false;
                plural5Atras.Enabled = false;
                plural5Siguiente.Enabled = false;
                plural5Ultimo.Enabled = false;
                plural5Modificar.Enabled = true;
                plural5Borrar.Enabled = false;
                plural5Buscar.Enabled = false;
                plural5Modificar.Enabled = false;
                plural5Registrar.Enabled = false;
                plural5Cancelar.Enabled = false;
                plural5Nuevo.Enabled = true;
            }
        }
        void actualizarSing3()
        {
            bloquearSing3();
            if (Datos.datosSing3.Rows.Count > 0)
            {
                if (Datos.datosSing3.Rows.Count == 1)
                {
                    cargaSing3(Datos.datosSing3.Rows[0]);
                    filaSing3 = 0;
                    sing3Primero.Enabled = false;
                    sing3Atras.Enabled = false;
                    sing3Siguiente.Enabled = false;
                    sing3Ultimo.Enabled = false;
                    sing3Conteo.Text = "1 de 1";
                    sing3Modificar.Enabled = true;
                    sing3Borrar.Enabled = true;
                    sing3Buscar.Enabled = false;
                    sing3Nuevo.Enabled = true;
                    sing3Registrar.Enabled = false;
                }
                else
                {
                    sing3Modificar.Enabled = true;
                    sing3Registrar.Enabled = false;
                    sing3Nuevo.Enabled = true;
                    cargaSing3(Datos.datosSing3.Rows[0]);
                    filaSing3 = 0;
                    sing3Primero.Enabled = false;
                    sing3Atras.Enabled = false;
                    sing3Buscar.Enabled = true;
                    sing3Siguiente.Enabled = true;
                    sing3Ultimo.Enabled = true;
                    sing3Borrar.Enabled = true;
                    sing3Conteo.Text = "1 de " + Datos.datosSing3.Rows.Count.ToString();
                }
            }
            else
            {
                sing3Modificar.Enabled = false;
                limpiarSing3();
                bloquearSing3();
                sing3Conteo.Text = "No hay registros";
                sing3Primero.Enabled = false;
                sing3Atras.Enabled = false;
                sing3Siguiente.Enabled = false;
                sing3Ultimo.Enabled = false;
                sing3Modificar.Enabled = true;
                sing3Borrar.Enabled = false;
                sing3Buscar.Enabled = false;
                sing3Modificar.Enabled = false;
                sing3Registrar.Enabled = false;
                sing3Cancelar.Enabled = false;
                sing3Nuevo.Enabled = true;
            }
        }
        void actualizarSing4()
        {
            bloquearSing4();
            if (Datos.datosSing4.Rows.Count > 0)
            {
                if (Datos.datosSing4.Rows.Count == 1)
                {
                    cargaSing4(Datos.datosSing4.Rows[0]);
                    filaSing4 = 0;
                    sing4Primero.Enabled = false;
                    sing4Atras.Enabled = false;
                    sing4Siguiente.Enabled = false;
                    sing4Ultimo.Enabled = false;
                    sing4Conteo.Text = "1 de 1";
                    sing4Modificar.Enabled = true;
                    sing4Borrar.Enabled = true;
                    sing4Buscar.Enabled = false;
                    sing4Nuevo.Enabled = true;
                    sing4Registrar.Enabled = false;
                }
                else
                {
                    sing4Modificar.Enabled = true;
                    sing4Registrar.Enabled = false;
                    sing4Nuevo.Enabled = true;
                    cargaSing4(Datos.datosSing4.Rows[0]);
                    filaSing4 = 0;
                    sing4Primero.Enabled = false;
                    sing4Atras.Enabled = false;
                    sing4Buscar.Enabled = true;
                    sing4Siguiente.Enabled = true;
                    sing4Ultimo.Enabled = true;
                    sing4Borrar.Enabled = true;
                    sing4Conteo.Text = "1 de " + Datos.datosSing4.Rows.Count.ToString();
                }
            }
            else
            {
                sing4Modificar.Enabled = false;
                limpiarSing4();
                bloquearSing4();
                sing4Conteo.Text = "No hay registros";
                sing4Primero.Enabled = false;
                sing4Atras.Enabled = false;
                sing4Siguiente.Enabled = false;
                sing4Ultimo.Enabled = false;
                sing4Modificar.Enabled = true;
                sing4Borrar.Enabled = false;
                sing4Buscar.Enabled = false;
                sing4Modificar.Enabled = false;
                sing4Registrar.Enabled = false;
                sing4Cancelar.Enabled = false;
                sing4Nuevo.Enabled = true;
            }
        }
        void actualizarSing5()
        {
            bloquearSing5();
            if (Datos.datosSing5.Rows.Count > 0)
            {
                if (Datos.datosSing5.Rows.Count == 1)
                {
                    cargaSing5(Datos.datosSing5.Rows[0]);
                    filaSing5 = 0;
                    sing5Primero.Enabled = false;
                    sing5Atras.Enabled = false;
                    sing5Siguiente.Enabled = false;
                    sing5Ultimo.Enabled = false;
                    sing5Conteo.Text = "1 de 1";
                    sing5Modificar.Enabled = true;
                    sing5Borrar.Enabled = true;
                    sing5Buscar.Enabled = false;
                    sing5Nuevo.Enabled = true;
                    sing5Registrar.Enabled = false;
                }
                else
                {
                    sing5Modificar.Enabled = true;
                    sing5Registrar.Enabled = false;
                    sing5Nuevo.Enabled = true;
                    cargaSing5(Datos.datosSing5.Rows[0]);
                    filaSing5 = 0;
                    sing5Primero.Enabled = false;
                    sing5Atras.Enabled = false;
                    sing5Buscar.Enabled = true;
                    sing5Siguiente.Enabled = true;
                    sing5Ultimo.Enabled = true;
                    sing5Borrar.Enabled = true;
                    sing5Conteo.Text = "1 de " + Datos.datosSing5.Rows.Count.ToString();
                }
            }
            else
            {
                sing5Modificar.Enabled = false;
                limpiarSing5();
                bloquearSing5();
                sing5Conteo.Text = "No hay registros";
                sing5Primero.Enabled = false;
                sing5Atras.Enabled = false;
                sing5Siguiente.Enabled = false;
                sing5Ultimo.Enabled = false;
                sing5Modificar.Enabled = true;
                sing5Borrar.Enabled = false;
                sing5Buscar.Enabled = false;
                sing5Modificar.Enabled = false;
                sing5Registrar.Enabled = false;
                sing5Cancelar.Enabled = false;
                sing5Nuevo.Enabled = true;
            }
        }
        void cargaSing1(DataRow s)
        {
                sing1Fecha.Value = s["fecha"].ToString();
                sing1Encabezado.Text = s["encabezado"].ToString();
                sing1Nombre.Text = s["nombre"].ToString();
                sing1Direccion.Text = s["direccion"].ToString();
                sing1Direccion2.Text = s["direccion2"].ToString();
                sing1Ciudad.Text = s["ciudad"].ToString();
                sing1Saludo.Text = s["saludo"].ToString();
                sing1CantidadL.Text = s["cantidadL"].ToString();
                sing1Cantidad.Text = s["cantidad"].ToString();
                sing1Meses.Text = s["meses"].ToString();
                sing1Anio.Text = s["anio"].ToString();
                sing1Pie.Text = s["pie"].ToString();
                sing1Asesor.Text = s["asesor"].ToString();
        }
        void cargaSing2(DataRow s)
        {
            sing2Fecha.Value = s["fecha"].ToString();
            sing2Encabezado.Text = s["encabezado"].ToString();
            sing2Nombre.Text = s["nombre"].ToString();
            sing2Direccion1.Text = s["direccion"].ToString();
            sing2Direccion2.Text = s["direccion2"].ToString();
            sing2Ciudad.Text = s["ciudad"].ToString();
            sing2Saludo.Text = s["saludo"].ToString();
            sing2CantidadL.Text = s["cantidadL"].ToString();
            sing2Cantidad.Text = s["cantidad"].ToString();
            sing2Meses.Text = s["meses"].ToString();
            sing2Anio.Text = s["anio"].ToString();
            sing2Pie.Text = s["pie"].ToString();
            sing2Ejecutivo.Text = s["asesor"].ToString();
        }
        void cargaSing3(DataRow s)
        {
            sing3Fecha.Value = s["fecha"].ToString();
            sing3Encabezado.Text = s["encabezado"].ToString();
            sing3Nombre.Text = s["nombre"].ToString();
            sing3Direccion.Text = s["direccion"].ToString();
            sing3Direccion2.Text = s["direccion2"].ToString();
            sing3Ciudad.Text = s["ciudad"].ToString();
            sing3Saludo.Text = s["saludo"].ToString();
            sing3CantidadL.Text = s["cantidadL"].ToString();
            sing3Cantidad.Text = s["cantidad"].ToString();
            sing3Meses.Text = s["meses"].ToString();
            sing3Anio.Text = s["anio"].ToString();
            sing3Pie.Text = s["pie"].ToString();
            sing3Asesor.Text = s["asesor"].ToString();
        }
        void cargaSing4(DataRow s)
        {
            sing4Fecha.Value = s["fecha"].ToString();
            sing4Encabezado.Text = s["encabezado"].ToString();
            sing4Nombre.Text = s["nombre"].ToString();
            sing4Direccion.Text = s["direccion"].ToString();
            sing4Direccion2.Text = s["direccion2"].ToString();
            sing4Ciudad.Text = s["ciudad"].ToString();
            sing4Saludo.Text = s["saludo"].ToString();
            sing4Pie.Text = s["pie"].ToString();
            sing4Asesor.Text = s["asesor"].ToString();
        }
        void cargaSing5(DataRow s)
        {
            sing5Fecha.Value = s["fecha"].ToString();
            sing5Encabezado.Text = s["encabezado"].ToString();
            sing5Nombre.Text = s["nombre"].ToString();
            sing5Direccion.Text = s["direccion"].ToString();
            sing5Direccion2.Text = s["direccion2"].ToString();
            sing5Ciudad.Text = s["ciudad"].ToString();
            sing5Saludo.Text = s["saludo"].ToString();
            sing5Cantidad.Text = s["cantidad"].ToString();
            sing5Pie.Text = s["pie"].ToString();
            sing5Asesor.Text = s["asesor"].ToString();
        }
        void cargaPlural1(DataRow s)
        {
            plural1Fecha.Value = s["fecha"].ToString();
            plural1Nombre.Text = s["nombre"].ToString();
            plural1Direccion.Text = s["direccion"].ToString();
            plural1Direccion2.Text = s["direccion2"].ToString();
            plural1Ciudad.Text = s["ciudad"].ToString();
            plural1CantidadL.Text = s["cantidadL"].ToString();
            plural1Cantidad.Text = s["cantidad"].ToString();
            plural1Meses.Text = s["meses"].ToString();
            plural1Anio.Text = s["anio"].ToString();
            plural1Pie.Text = s["pie"].ToString();
            plural1Asesor.Text = s["asesor"].ToString();
        }
        void cargaPlural2(DataRow s)
        {
            plural2Fecha.Value = s["fecha"].ToString();
            plural2Nombre.Text = s["nombre"].ToString();
            plural2Direccion.Text = s["direccion"].ToString();
            plural2Direccion2.Text = s["direccion2"].ToString();
            plural2Ciudad.Text = s["ciudad"].ToString();
            plural2CantidadL.Text = s["cantidadL"].ToString();
            plural2Cantidad.Text = s["cantidad"].ToString();
            plural2Meses.Text = s["meses"].ToString();
            plural2Anio.Text = s["anio"].ToString();
            plural2Pie.Text = s["pie"].ToString();
            plural2Asesor.Text = s["asesor"].ToString();
        }
        void cargaPlural3(DataRow s)
        {
            plural3Fecha.Value = s["fecha"].ToString();
            plural3Nombre.Text = s["nombre"].ToString();
            plural3Direccion.Text = s["direccion"].ToString();
            plural3Direccion2.Text = s["direccion2"].ToString();
            plural3Ciudad.Text = s["ciudad"].ToString();
            plural3CantidadL.Text = s["cantidadL"].ToString();
            plural3Cantidad.Text = s["cantidad"].ToString();
            plural3Meses.Text = s["meses"].ToString();
            plural3Anio.Text = s["anio"].ToString();
            plural3Pie.Text = s["pie"].ToString();
            plural3Asesor.Text = s["asesor"].ToString();
        }
        void cargaPlural4(DataRow s)
        {
            plural4Fecha.Value = s["fecha"].ToString();
            plural4Nombre.Text = s["nombre"].ToString();
            plural4Direccion.Text = s["direccion"].ToString();
            plural4Direccion2.Text = s["direccion2"].ToString();
            plural4Ciudad.Text = s["ciudad"].ToString();
            plural4Pie.Text = s["pie"].ToString();
            plural4Asesor.Text = s["asesor"].ToString();
        }
        void cargaPlural5(DataRow s)
        {
            plural5Fecha.Value = s["fecha"].ToString();
            plural5Nombre.Text = s["nombre"].ToString();
            plural5Direccion.Text = s["direccion"].ToString();
            plural5Direccion2.Text = s["direccion2"].ToString();
            plural5Ciudad.Text = s["ciudad"].ToString();
            plural5Cantidad.Text = s["cantidad"].ToString();
            plural5Pie.Text = s["pie"].ToString();
            plural5Asesor.Text = s["asesor"].ToString();
        }
        string generaFecha(int d,int m,int a) {
            string mes = string.Empty;
            switch (m) { 
                case 1:
                    mes = "Enero";
                    break;
                case 2:
                    mes = "Febrero";
                    break;
                case 3:
                    mes = "Marzo";
                    break;
                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Mayo";
                    break;
                case 6:
                    mes = "Junio";
                    break;
                case 7:
                    mes = "Julio";
                    break;
                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Septiembre";
                    break;
                case 10:
                    mes = "Octubre";
                    break;
                case 11:
                    mes = "Noviembre";
                    break;
                case 12:
                    mes = "Diciembre";
                    break;
            }
            mes = d.ToString() + " de " + mes + " del " + a.ToString();
            return (mes);
        }
        void reportePlural1(DataRow s)
        {
            DateTime t = Convert.ToDateTime(s["fecha"]);
            string carta = string.Empty;
            string titulo = string.Empty;
            string montoL, monto, mes, anio, fecha,nombre, direccion, direccion2, ciudad, asesor;
            fecha = generaFecha(t.Day, t.Month, t.Year);
            nombre = s["nombre"].ToString();
            direccion = s["direccion"].ToString();
            direccion2 = s["direccion2"].ToString();
            ciudad = s["ciudad"].ToString();
            montoL = s["cantidadL"].ToString();
            monto = string.Format("{0:C}", Convert.ToDecimal(s["cantidad"].ToString()));
            mes = s["meses"].ToString();
            anio = s["anio"].ToString();
            asesor = s["asesor"].ToString();
            carta = @"<p align='justify'>Nos dirigimos a ustedes con la finalidad de recordarles la deuda que tienen contraída con esta empresa, ascendente a la suma de <b>" + montoL + "</b> <b>(" + monto + ")</b>, correspondientes a facturas tomadas en " + mes + " del año " + anio + ", sin que hasta la fecha se haya honrado el cumplimiento de su obligación con esta entidad comercial.<p>&nbsp;</p></p><p align='justify'>Nos gustaría que recibieran a uno de nuestros gerentes de crédito, ya que su cuenta muestra facturas pendientes por encima de los límites establecidos.<p>&nbsp;</p></p> <p align='justify'>Si al recibo de esta comunicación ustedes han efectuado algún pago a su deuda por favor acepten nuestras excusas.<p>&nbsp;</p><p>&nbsp;</p> Muy atentamente,</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + asesor + "<p><b>Asesor Operativo</b>";
            DataTable tabla = new dataCredito.reporteSing2DataTable();
            DataRow fila = tabla.NewRow();
            titulo = @fecha + "<p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>Señores<p><b>" + nombre + "</b><p>" + direccion + "<p>" + direccion2 + "<p>" + ciudad + "<p>&nbsp;</p><p>&nbsp;</p>Estimados Señores:<p>&nbsp;</p>";
            fila["carta"] = titulo + carta;
            fila["titulo"] = s["pie"].ToString();
            tabla.Rows.Add(fila);
            carta r = new carta();
            r.SetDataSource(tabla);
            visorPlural1.ReportSource = r;
            visorPlural1.RefreshReport();
        }
        void reportePlural2(DataRow s)
        {
            DateTime t = Convert.ToDateTime(s["fecha"]);
            string carta = string.Empty;
            string titulo = string.Empty;
            string montoL, monto, mes, anio, fecha, nombre, direccion, direccion2, ciudad, asesor;
            fecha = generaFecha(t.Day, t.Month, t.Year);
            nombre = s["nombre"].ToString();
            direccion = s["direccion"].ToString();
            direccion2 = s["direccion2"].ToString();
            ciudad = s["ciudad"].ToString();
            montoL = s["cantidadL"].ToString();
            monto = string.Format("{0:C}", Convert.ToDecimal(s["cantidad"].ToString()));
            mes = s["meses"].ToString();
            anio = s["anio"].ToString();
            asesor = s["asesor"].ToString();
            carta = @"<p align='justify'>Nos dirigimos a ustedes con la finalidad de recordarle la deuda que tienen contraída con esta empresa, ascendente a la suma de <b>" + montoL + "</b> <b>(" + monto + ")</b>, correspondientes a facturas tomadas en " + mes + " del año " + anio + ", sin que hasta la fecha se haya honrado el cumplimiento de su obligación con esta entidad comercial.<p>&nbsp;</p></p><p align='justify'>Les informamos de la manera más cordial, que les concedemos un plazo de quince (15) días para el cumplimiento de su obligación. Nos gustaría que recibieran a uno de nuestros gerentes de crédito para que hicieramos un plan de pago difinitivo, a fin de evitarles futuras molestias.<p>&nbsp;</p></p> <p align='justify'>Si al recibo de esta comunicación ustedes han efectuado algún pago a su deuda por favor acepten nuestras excusas.<p>&nbsp;</p><p>&nbsp;</p> Muy atentamente,</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + asesor + "<p><b>Asesor Operativo</b>";
            DataTable tabla = new dataCredito.reporteSing2DataTable();
            DataRow fila = tabla.NewRow();
            titulo = @fecha + "<p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>Señores<p><b>" + nombre + "</b><p>" + direccion + "<p>" + direccion2 + "<p>" + ciudad + "<p>&nbsp;</p><p>&nbsp;</p>Estimados Señores:<p>&nbsp;</p>";
            fila["carta"] = titulo + carta;
            fila["titulo"] = s["pie"].ToString();
            tabla.Rows.Add(fila);
            carta r = new carta();
            r.SetDataSource(tabla);
            visorPlural2.ReportSource = r;
            visorPlural2.RefreshReport();
        }
        void reportePlural3(DataRow s)
        {
            DateTime t = Convert.ToDateTime(s["fecha"]);
            string carta = string.Empty;
            string titulo = string.Empty;
            string montoL, monto, mes, anio, fecha, nombre, direccion, direccion2, ciudad, asesor;
            fecha = generaFecha(t.Day, t.Month, t.Year);
            nombre = s["nombre"].ToString();
            direccion = s["direccion"].ToString();
            direccion2 = s["direccion2"].ToString();
            ciudad = s["ciudad"].ToString();
            montoL = s["cantidadL"].ToString();
            monto = string.Format("{0:C}", Convert.ToDecimal(s["cantidad"].ToString()));
            mes = s["meses"].ToString();
            anio = s["anio"].ToString();
            asesor = s["asesor"].ToString();
            carta = @"<p align='justify'>Sirva la presente como un recordatorio del compromiso que tiene contraído con esta empresa ascendente a la suma de <b>" + montoL + "</b> <b>(" + monto + ")</b>, correspondientes a facturas tomadas en " + mes + " del año " + anio + ".<p>&nbsp;</p></p><p align='justify'>Como su deuda ha sobrepasado los límites de crédito que son normas de esta empresa, les invitamos a pasar por nuestro Departamento de Crédito para acordar un plan de pago de la misma.<p>&nbsp;</p></p> <p align='justify'>Si al recibo de esta comunicación ustedes han efectuado algún pago a su deuda por favor acepten nuestras excusas.<p>&nbsp;</p><p>&nbsp;</p> Muy atentamente,</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + asesor + "<p><b>Ejecutivo de Cuentas</b>";
            DataTable tabla = new dataCredito.reporteSing2DataTable();
            DataRow fila = tabla.NewRow();
            titulo = @fecha + "<p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>Señores<p><b>" + nombre + "</b><p>" + direccion + "<p>" + direccion2 + "<p>" + ciudad + "<p>&nbsp;</p><p>&nbsp;</p>Estimados Señores:<p>&nbsp;</p>";
            fila["carta"] = titulo + carta;
            fila["titulo"] = s["pie"].ToString();
            tabla.Rows.Add(fila);
            carta r = new carta();
            r.SetDataSource(tabla);
            visorPlural3.ReportSource = r;
            visorPlural3.RefreshReport();
        }
        void reportePlural4(DataRow s)
        {
            DateTime t = Convert.ToDateTime(s["fecha"]);
            string carta = string.Empty;
            string titulo = string.Empty;
            string fecha, nombre, direccion, direccion2, ciudad, asesor;
            fecha = generaFecha(t.Day, t.Month, t.Year);
            nombre = s["nombre"].ToString();
            direccion = s["direccion"].ToString();
            direccion2 = s["direccion2"].ToString();
            ciudad = s["ciudad"].ToString();
            asesor = s["asesor"].ToString();
            carta = @"<p align='justify'>Debido a su falta de respuesta a nuestras comunicaciones sobre su deuda en Ferretería Americana, C. por A., les hacemos saber que aparte de tener el crédito suspendido en nuestra compañía los próximos pasos para hacer viable el cobro de dicha deuda están siendo dados por nuestro Departamento Legal, sintiendo mucho que hayamos tenido que tomar esta decisión.<p>&nbsp;</p></p><p align='justify'>Esperamos que se llegue a un acuerdo lo antes posible.<p>&nbsp;</p></p> <p align='justify'>Si al recibo de esta comunicación usted ha efectuado algún pago a su deuda por favor acepte nuestras excusas.<p>&nbsp;</p><p>&nbsp;</p> Muy atentamente,</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + asesor + "<p><b>Gerente de Cuenta</b>";
            DataTable tabla = new dataCredito.reporteSing2DataTable();
            DataRow fila = tabla.NewRow();
            titulo = @fecha + "<p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>Señores<p><b>" + nombre + "</b><p>" + direccion + "<p>" + direccion2 + "<p>" + ciudad + "<p>&nbsp;</p><p>&nbsp;</p>Estimados Señores:<p>&nbsp;</p>";
            fila["carta"] = titulo + carta;
            fila["titulo"] = s["pie"].ToString();
            tabla.Rows.Add(fila);
            carta r = new carta();
            r.SetDataSource(tabla);
            visorPlural4.ReportSource = r;
            visorPlural4.RefreshReport();
        }
        void reportePlural5(DataRow s)
        {
            DateTime t = Convert.ToDateTime(s["fecha"]);
            string carta = string.Empty;
            string titulo = string.Empty;
            string monto,fecha, nombre, direccion, direccion2, ciudad, asesor;
            fecha = generaFecha(t.Day, t.Month, t.Year);
            nombre = s["nombre"].ToString();
            direccion = s["direccion"].ToString();
            direccion2 = s["direccion2"].ToString();
            ciudad = s["ciudad"].ToString();
            monto = string.Format("{0:C}", Convert.ToDecimal(s["cantidad"].ToString()));
            asesor = s["asesor"].ToString();
            carta = @"<p align='justify'>Nos dirigimos a ustedes, para extenderles un afectuoso saludo y agradecerles el uso de su línea de crédito, al mismo tiempo queremos recordarles que su cuenta tiene un balance vencido de <b>(" + monto + ")</b><p>&nbsp;</p></p><p align='justify'>Nos gustaría que se comunicaran con su Ejecutivo de Cuenta, ya que el vencimiento de nuestras facturas es a 30 días. Si al recibo de esta comunicación ustedes han efectuado algún pago a su deuda, por favor acepten nuestras excusas.<p>&nbsp;</p><p>&nbsp;</p> Muy atentamente,</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + asesor + "<p><b>Ejecutivo de Cuentas</b>";
            DataTable tabla = new dataCredito.reporteSing2DataTable();
            DataRow fila = tabla.NewRow();
            titulo = @fecha + "<p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>Señores<p><b>" + nombre + "</b><p>" + direccion + "<p>" + direccion2 + "<p>" + ciudad + "<p>&nbsp;</p><p>&nbsp;</p>Estimados Señores:<p>&nbsp;</p>";
            fila["carta"] = titulo + carta;
            fila["titulo"] = s["pie"].ToString();
            tabla.Rows.Add(fila);
            carta r = new carta();
            r.SetDataSource(tabla);
            visorPlural5.ReportSource = r;
            visorPlural5.RefreshReport();
        }
        void reporteSing1(DataRow s)
        {
            DateTime t = Convert.ToDateTime(s["fecha"]);
            string carta = string.Empty;
            string titulo = string.Empty;
            string montoL, monto, mes, anio, fecha, saludo, encabezado, nombre, direccion, direccion2, ciudad, asesor;
            fecha = generaFecha(t.Day, t.Month, t.Year);
            saludo = s["saludo"].ToString();
            encabezado = s["encabezado"].ToString();
            nombre = s["nombre"].ToString();
            direccion = s["direccion"].ToString();
            direccion2 = s["direccion2"].ToString();
            ciudad = s["ciudad"].ToString();
            montoL = s["cantidadL"].ToString();
            monto = string.Format("{0:C}", Convert.ToDecimal(s["cantidad"].ToString()));
            mes = s["meses"].ToString();
            anio = s["anio"].ToString();
            asesor = s["asesor"].ToString();
            carta = @"<p align='justify'>Nos dirigimos a usted con la finalidad de recordarle la deuda que tienen contraída con esta empresa, ascendente a la suma de <b>" + montoL + "</b> <b>(" + monto + ")</b>, correspondientes a facturas tomadas en " + mes + " del año " + anio + ", sin que hasta la fecha se haya honrado el cumplimiento de su obligación con esta entidad comercial.<p>&nbsp;</p></p><p align='justify'>Nos gustaría que recibiera a uno de nuestros gerentes de crédito, ya que su cuenta muestra facturas pendientes por encima de los límites establecidos.<p>&nbsp;</p></p> <p align='justify'>Si al recibo de esta comunicación usted ha efectuado algún pago a su deuda por favor acepte nuestras excusas.<p>&nbsp;</p><p>&nbsp;</p> Muy atentamente,</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + asesor + "<p><b>Asesor Operativo</b>";
            DataTable tabla = new dataCredito.reporteSing2DataTable();
            DataRow fila = tabla.NewRow();
            titulo = @fecha + "<p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + encabezado + "<p><b>" + nombre + "</b><p>" + direccion + "<p>" + direccion2 + "<p>" + ciudad + "<p>&nbsp;</p><p>&nbsp;</p>" + saludo + "<p>&nbsp;</p>";
            fila["carta"] = titulo + carta;
            fila["titulo"] = s["pie"].ToString();
            tabla.Rows.Add(fila);
            carta r = new carta();
            r.SetDataSource(tabla);
            visorSing1.ReportSource = r;
            visorSing1.RefreshReport();
            foreach (Control c1 in visorSing1.Controls)
            {
                if (c1 is CrystalDecisions.Windows.Forms.PageView)
                {
                    PageView pv = (PageView)c1;
                    foreach (Control c2 in pv.Controls)
                    {
                        if (c2 is TabControl)
                        {
                            TabControl tc = (TabControl)c2;
                            tc.ItemSize = new Size(0, 1);
                            tc.SizeMode = TabSizeMode.Fixed;
                        }
                    }
                }
            }
             //*/ 

            //fin
        }
        void reporteSing22(DataRow s)
        {
            DateTime t = Convert.ToDateTime(s["fecha"]);
            string carta = string.Empty;
            string titulo = string.Empty;
            string montoL, monto, mes, anio,fecha,saludo,encabezado,nombre,direccion,direccion2,ciudad,asesor;
            fecha = generaFecha(t.Day, t.Month, t.Year);
            saludo = s["saludo"].ToString();
            encabezado = s["encabezado"].ToString();
            nombre = s["nombre"].ToString();
            direccion = s["direccion"].ToString();
            direccion2 = s["direccion2"].ToString();
            ciudad = s["ciudad"].ToString();
            montoL = s["cantidadL"].ToString();
            monto =string.Format("{0:C}",Convert.ToDecimal(s["cantidad"].ToString()));
            mes = s["meses"].ToString();
            anio = s["anio"].ToString();
            asesor = s["asesor"].ToString();
            carta = @"<p align='justify'>Nos dirigimos a usted con la finalidad de recordarle la deuda que tienen contraída con esta empresa, ascendente a la suma de <b>" + montoL + "</b> <b>(" + monto + ")</b>, correspondientes a facturas tomadas en " + mes + " del año " + anio + ", sin que hasta la fecha se haya honrado el cumplimiento de su obligación con esta entidad comercial.<p>&nbsp;</p></p><p align='justify'>Le informamos de la manera más cordial, que le concedemos un plazo de quince (15) días para el cumplimiento de su obligación. Nos gustaría que recibiera a uno de nuestros gerentes de crédito para que hicieramos un plan de pago difinitivo, a fin de evitarle futuras molestias.<p>&nbsp;</p></p> <p align='justify'>Si al recibo de esta comunicación usted ha efectuado algún pago a su deuda por favor acepte nuestras excusas.<p>&nbsp;</p><p>&nbsp;</p> Muy atentamente,</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + asesor + "<p><b>Asesor Operativo</b>";
            DataTable tabla = new dataCredito.reporteSing2DataTable();
            DataRow fila = tabla.NewRow();
            titulo = @fecha + "<p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + encabezado + "<p><b>" + nombre + "</b><p>" + direccion + "<p>" + direccion2 + "<p>" + ciudad + "<p>&nbsp;</p><p>&nbsp;</p>" + saludo + "<p>&nbsp;</p>";
            fila["carta"] =titulo+ carta;
            fila["titulo"] = s["pie"].ToString();
            tabla.Rows.Add(fila);
            carta r = new carta();
            r.SetDataSource(tabla);
            visorSing2.ReportSource = r;
            visorSing2.RefreshReport();
        }
        void reporteSing3(DataRow s)
        {
            DateTime t = Convert.ToDateTime(s["fecha"]);
            string carta = string.Empty;
            string titulo = string.Empty;
            string montoL, monto, mes, anio, fecha, saludo, encabezado, nombre, direccion, direccion2, ciudad, asesor;
            fecha = generaFecha(t.Day, t.Month, t.Year);
            saludo = s["saludo"].ToString();
            encabezado = s["encabezado"].ToString();
            nombre = s["nombre"].ToString();
            direccion = s["direccion"].ToString();
            direccion2 = s["direccion2"].ToString();
            ciudad = s["ciudad"].ToString();
            montoL = s["cantidadL"].ToString();
            monto = string.Format("{0:C}", Convert.ToDecimal(s["cantidad"].ToString()));
            mes = s["meses"].ToString();
            anio = s["anio"].ToString();
            asesor = s["asesor"].ToString();
            carta = @"<p align='justify'>Sirva la presente como un recordatorio del compromiso que tiene contraído con esta empresa ascendente a la suma de <b>" + montoL + "</b> <b>(" + monto + ")</b>, correspondientes a facturas tomadas en " + mes + " del año " + anio + ".<p>&nbsp;</p></p><p align='justify'>Como su deuda ha sobrepasado los límites de crédito que son normas de esta empresa, le invitamos a pasar por nuestro Departamento de Crédito para acordar un plan de pago de la misma.<p>&nbsp;</p></p> <p align='justify'>Si al recibo de esta comunicación usted ha efectuado algún pago a su deuda por favor acepte nuestras excusas.<p>&nbsp;</p><p>&nbsp;</p> Muy atentamente,</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + asesor + "<p><b>Asesor Operativo</b>";
            DataTable tabla = new dataCredito.reporteSing2DataTable();
            DataRow fila = tabla.NewRow();
            titulo = @fecha + "<p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + encabezado + "<p><b>" + nombre + "</b><p>" + direccion + "<p>" + direccion2 + "<p>" + ciudad + "<p>&nbsp;</p><p>&nbsp;</p>" + saludo + "<p>&nbsp;</p>";
            fila["carta"] = titulo + carta;
            fila["titulo"] = s["pie"].ToString();
            tabla.Rows.Add(fila);
            carta r = new carta();
            r.SetDataSource(tabla);
            visorSing3.ReportSource = r;
            visorSing3.RefreshReport();
        }
        void reporteSing4(DataRow s)
        {
            DateTime t = Convert.ToDateTime(s["fecha"]);
            string carta = string.Empty;
            string titulo = string.Empty;
            string fecha, saludo, encabezado, nombre, direccion, direccion2, ciudad, asesor;
            fecha = generaFecha(t.Day, t.Month, t.Year);
            saludo = s["saludo"].ToString();
            encabezado = s["encabezado"].ToString();
            nombre = s["nombre"].ToString();
            direccion = s["direccion"].ToString();
            direccion2 = s["direccion2"].ToString();
            ciudad = s["ciudad"].ToString();
            asesor = s["asesor"].ToString();
            carta = @"<p align='justify'>Debido a su falta de respuesta a nuestras comunicaciones sobre su deuda en Ferretería Americana, C. por A., les hacemos saber que aparte de tener el crédito suspendido en nuestra compañía los próximos pasos para hacer viable el cobro de dicha deuda están siendo dados por nuestro Departamento Legal, sintiendo mucho que hayamos tenido que tomar esta decisión.<p>&nbsp;</p></p><p align='justify'>Esperamos que se llegue a un acuerdo lo antes posible.<p>&nbsp;</p></p> <p align='justify'>Si al recibo de esta comunicación usted ha efectuado algún pago a su deuda por favor acepte nuestras excusas.<p>&nbsp;</p><p>&nbsp;</p> Muy atentamente,</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + asesor + "<p><b>Asesor Operativo</b>";
            DataTable tabla = new dataCredito.reporteSing2DataTable();
            DataRow fila = tabla.NewRow();
            titulo = @fecha + "<p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + encabezado + "<p><b>" + nombre + "</b><p>" + direccion + "<p>" + direccion2 + "<p>" + ciudad + "<p>&nbsp;</p><p>&nbsp;</p>" + saludo + "<p>&nbsp;</p>";
            fila["carta"] = titulo + carta;
            fila["titulo"] = s["pie"].ToString();
            tabla.Rows.Add(fila);
            carta r = new carta();
            r.SetDataSource(tabla);
            visorSing4.ReportSource = r;
            visorSing4.RefreshReport();
        }
        void reporteSing5(DataRow s)
        {
            DateTime t = Convert.ToDateTime(s["fecha"]);
            string carta = string.Empty;
            string titulo = string.Empty;
            string monto,fecha, saludo, encabezado, nombre, direccion, direccion2, ciudad, asesor;
            fecha = generaFecha(t.Day, t.Month, t.Year);
            saludo = s["saludo"].ToString();
            encabezado = s["encabezado"].ToString();
            nombre = s["nombre"].ToString();
            direccion = s["direccion"].ToString();
            direccion2 = s["direccion2"].ToString();
            ciudad = s["ciudad"].ToString();
            monto = string.Format("{0:C}", Convert.ToDecimal(s["cantidad"].ToString()));
            asesor = s["asesor"].ToString();
            carta = @"<p align='justify'>Nos dirigimos a usted, para extenderle un afectuoso saludo y agradecerle el uso de su línea de crédito, al mismo tiempo queremos recordarle que su cuenta tiene un balance vencido de <b>("+ monto + ")</b><p>&nbsp;</p></p><p align='justify'>Nos gustaría que se comunicara con su Ejecutivo de Cuenta, ya que el vencimiento de nuestras facturas es a 30 días. Si al recibo de esta comunicación usted ha efectuado algún pago a su deuda, por favor acepten nuestras excusas.<p>&nbsp;</p><p>&nbsp;</p> Muy atentamente,</p><p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + asesor + "<p><b>Asesor Operativo</b>";
            DataTable tabla = new dataCredito.reporteSing2DataTable();
            DataRow fila = tabla.NewRow();
            titulo = @fecha + "<p>&nbsp;</p><p>&nbsp;</p><p>&nbsp;</p>" + encabezado + "<p><b>" + nombre + "</b><p>" + direccion + "<p>" + direccion2 + "<p>" + ciudad + "<p>&nbsp;</p><p>&nbsp;</p>" + saludo + "<p>&nbsp;</p>";
            fila["carta"] = titulo + carta;
            fila["titulo"] = s["pie"].ToString();
            tabla.Rows.Add(fila);
            carta r = new carta();
            r.SetDataSource(tabla);
            visorSing5.ReportSource = r;
            visorSing5.RefreshReport();
        }
        void bloquearPlural1()
        {
            plural1Fecha.Enabled = false;
            plural1Nombre.Enabled = false;
            plural1Direccion.Enabled = false;
            plural1Direccion2.Enabled = false;
            plural1Ciudad.Enabled = false;
            plural1CantidadL.Enabled = false;
            plural1Cantidad.Enabled = false;
            plural1Meses.Enabled = false;
            plural1Anio.Enabled = false;
            plural1Pie.Enabled = false;
            plural1Asesor.Enabled = false;
        }
        void bloquearPlural2()
        {
            plural2Fecha.Enabled = false;
            plural2Nombre.Enabled = false;
            plural2Direccion.Enabled = false;
            plural2Direccion2.Enabled = false;
            plural2Ciudad.Enabled = false;
            plural2CantidadL.Enabled = false;
            plural2Cantidad.Enabled = false;
            plural2Meses.Enabled = false;
            plural2Anio.Enabled = false;
            plural2Pie.Enabled = false;
            plural2Asesor.Enabled = false;
        }
        void bloquearPlural3()
        {
            plural3Fecha.Enabled = false;
            plural3Nombre.Enabled = false;
            plural3Direccion.Enabled = false;
            plural3Direccion2.Enabled = false;
            plural3Ciudad.Enabled = false;
            plural3CantidadL.Enabled = false;
            plural3Cantidad.Enabled = false;
            plural3Meses.Enabled = false;
            plural3Anio.Enabled = false;
            plural3Pie.Enabled = false;
            plural3Asesor.Enabled = false;
        }
        void bloquearPlural4()
        {
            plural4Fecha.Enabled = false;
            plural4Nombre.Enabled = false;
            plural4Direccion.Enabled = false;
            plural4Direccion2.Enabled = false;
            plural4Ciudad.Enabled = false;
            plural4Pie.Enabled = false;
            plural4Asesor.Enabled = false;
        }
        void bloquearPlural5()
        {
            plural5Fecha.Enabled = false;
            plural5Nombre.Enabled = false;
            plural5Direccion.Enabled = false;
            plural5Direccion2.Enabled = false;
            plural5Ciudad.Enabled = false;
            plural5Cantidad.Enabled = false;
            plural5Pie.Enabled = false;
            plural5Asesor.Enabled = false;
        }
        void desbloquearPlural5()
        {
            plural5Fecha.Enabled = true;
            plural5Nombre.Enabled = true;
            plural5Direccion.Enabled = true;
            plural5Direccion2.Enabled = true;
            plural5Ciudad.Enabled = true;
            plural5Cantidad.Enabled = true;
            plural5Pie.Enabled = true;
            plural5Asesor.Enabled = true;
        }
        void limpiarPlural5()
        {
            plural5Fecha.Value = null;
            plural5Nombre.Text = string.Empty;
            plural5Direccion.Text = string.Empty;
            plural5Direccion2.Text = string.Empty;
            plural5Ciudad.Text = string.Empty;
            plural5Cantidad.Text = string.Empty;
            plural5Pie.Text = string.Empty;
            plural5Asesor.Text = string.Empty;
        }
        void desbloquearPlural4()
        {
            plural4Fecha.Enabled = true;
            plural4Nombre.Enabled = true;
            plural4Direccion.Enabled = true;
            plural4Direccion2.Enabled = true;
            plural4Ciudad.Enabled = true;
            plural4Pie.Enabled = true;
            plural4Asesor.Enabled = true;
        }
        void limpiarPlural4()
        {
            plural4Fecha.Value = null;
            plural4Nombre.Text = string.Empty;
            plural4Direccion.Text = string.Empty;
            plural4Direccion2.Text = string.Empty;
            plural4Ciudad.Text = string.Empty;
            plural4Pie.Text = string.Empty;
            plural4Asesor.Text = string.Empty;
        }
        void desbloquearPlural1()
        {
            plural1Fecha.Enabled = true;
            plural1Nombre.Enabled = true;
            plural1Direccion.Enabled = true;
            plural1Direccion2.Enabled = true;
            plural1Ciudad.Enabled = true;
            plural1CantidadL.Enabled = true;
            plural1Cantidad.Enabled = true;
            plural1Meses.Enabled = true;
            plural1Anio.Enabled = true;
            plural1Pie.Enabled = true;
            plural1Asesor.Enabled = true;
        }
        void desbloquearPlural2()
        {
            plural2Fecha.Enabled = true;
            plural2Nombre.Enabled = true;
            plural2Direccion.Enabled = true;
            plural2Direccion2.Enabled = true;
            plural2Ciudad.Enabled = true;
            plural2CantidadL.Enabled = true;
            plural2Cantidad.Enabled = true;
            plural2Meses.Enabled = true;
            plural2Anio.Enabled = true;
            plural2Pie.Enabled = true;
            plural2Asesor.Enabled = true;
        }
        void desbloquearPlural3()
        {
            plural3Fecha.Enabled = true;
            plural3Nombre.Enabled = true;
            plural3Direccion.Enabled = true;
            plural3Direccion2.Enabled = true;
            plural3Ciudad.Enabled = true;
            plural3CantidadL.Enabled = true;
            plural3Cantidad.Enabled = true;
            plural3Meses.Enabled = true;
            plural3Anio.Enabled = true;
            plural3Pie.Enabled = true;
            plural3Asesor.Enabled = true;
        }
        void bloquearSing1() {
            sing1Fecha.Enabled = false;
            sing1Encabezado.Enabled = false;
            sing1Nombre.Enabled = false;
            sing1Direccion.Enabled = false;
            sing1Direccion2.Enabled = false;
            sing1Ciudad.Enabled = false;
            sing1Saludo.Enabled = false;
            sing1CantidadL.Enabled = false;
            sing1Cantidad.Enabled = false;
            sing1Meses.Enabled = false;
            sing1Anio.Enabled = false;
            sing1Pie.Enabled = false;
            sing1Asesor.Enabled = false;
        }
        void bloquearSing2()
        {
            sing2Fecha.Enabled = false;
            sing2Encabezado.Enabled = false;
            sing2Nombre.Enabled = false;
            sing2Direccion1.Enabled = false;
            sing2Direccion2.Enabled = false;
            sing2Ciudad.Enabled = false;
            sing2Saludo.Enabled = false;
            sing2CantidadL.Enabled = false;
            sing2Cantidad.Enabled = false;
            sing2Meses.Enabled = false;
            sing2Anio.Enabled = false;
            sing2Pie.Enabled = false;
            sing2Ejecutivo.Enabled = false;
        }
        void bloquearSing3()
        {
            sing3Fecha.Enabled = false;
            sing3Encabezado.Enabled = false;
            sing3Nombre.Enabled = false;
            sing3Direccion.Enabled = false;
            sing3Direccion2.Enabled = false;
            sing3Ciudad.Enabled = false;
            sing3Saludo.Enabled = false;
            sing3CantidadL.Enabled = false;
            sing3Cantidad.Enabled = false;
            sing3Meses.Enabled = false;
            sing3Anio.Enabled = false;
            sing3Pie.Enabled = false;
            sing3Asesor.Enabled = false;
        }
        void bloquearSing4()
        {
            sing4Fecha.Enabled = false;
            sing4Encabezado.Enabled = false;
            sing4Nombre.Enabled = false;
            sing4Direccion.Enabled = false;
            sing4Direccion2.Enabled = false;
            sing4Ciudad.Enabled = false;
            sing4Saludo.Enabled = false;
            sing4Pie.Enabled = false;
            sing4Asesor.Enabled = false;
        }
        void bloquearSing5()
        {
            sing5Fecha.Enabled = false;
            sing5Encabezado.Enabled = false;
            sing5Nombre.Enabled = false;
            sing5Direccion.Enabled = false;
            sing5Direccion2.Enabled = false;
            sing5Ciudad.Enabled = false;
            sing5Saludo.Enabled = false;
            sing5Cantidad.Enabled = false;
            sing5Pie.Enabled = false;
            sing5Asesor.Enabled = false;
        }
        void desbloquearSing1()
        {
            sing1Fecha.Enabled = true;
            sing1Encabezado.Enabled = true;
            sing1Nombre.Enabled = true;
            sing1Direccion.Enabled = true;
            sing1Direccion2.Enabled = true;
            sing1Ciudad.Enabled = true;
            sing1Saludo.Enabled = true;
            sing1CantidadL.Enabled = true;
            sing1Cantidad.Enabled = true;
            sing1Meses.Enabled = true;
            sing1Anio.Enabled = true;
            sing1Pie.Enabled = true;
            sing1Asesor.Enabled = true;
        }
        void desbloquearSing2()
        {
            sing2Fecha.Enabled = true;
            sing2Encabezado.Enabled = true;
            sing2Nombre.Enabled = true;
            sing2Direccion1.Enabled = true;
            sing2Direccion2.Enabled = true;
            sing2Ciudad.Enabled = true;
            sing2Saludo.Enabled = true;
            sing2CantidadL.Enabled = true;
            sing2Cantidad.Enabled = true;
            sing2Meses.Enabled = true;
            sing2Anio.Enabled = true;
            sing2Pie.Enabled = true;
            sing2Ejecutivo.Enabled = true;
        }
        void desbloquearSing3()
        {
            sing3Fecha.Enabled = true;
            sing3Encabezado.Enabled = true;
            sing3Nombre.Enabled = true;
            sing3Direccion.Enabled = true;
            sing3Direccion2.Enabled = true;
            sing3Ciudad.Enabled = true;
            sing3Saludo.Enabled = true;
            sing3CantidadL.Enabled = true;
            sing3Cantidad.Enabled = true;
            sing3Meses.Enabled = true;
            sing3Anio.Enabled = true;
            sing3Pie.Enabled = true;
            sing3Asesor.Enabled = true;
        }
        void desbloquearSing4()
        {
            sing4Fecha.Enabled = true;
            sing4Encabezado.Enabled = true;
            sing4Nombre.Enabled = true;
            sing4Direccion.Enabled = true;
            sing4Direccion2.Enabled = true;
            sing4Ciudad.Enabled = true;
            sing4Saludo.Enabled = true;
            sing4Pie.Enabled = true;
            sing4Asesor.Enabled = true;
        }
        void desbloquearSing5()
        {
            sing5Fecha.Enabled = true;
            sing5Encabezado.Enabled = true;
            sing5Nombre.Enabled = true;
            sing5Direccion.Enabled = true;
            sing5Direccion2.Enabled = true;
            sing5Ciudad.Enabled = true;
            sing5Saludo.Enabled = true;
            sing5Cantidad.Enabled = true;
            sing5Pie.Enabled = true;
            sing5Asesor.Enabled = true;
        }
        void limpiarSing1()
        {
            sing1Fecha.Value = null;
            sing1Encabezado.SelectedIndex = -1;
            sing1Nombre.Text = string.Empty;
            sing1Direccion.Text = string.Empty;
            sing1Direccion2.Text = string.Empty;
            sing1Ciudad.Text = string.Empty;
            sing1Saludo.SelectedIndex = -1;
            sing1CantidadL.Text = string.Empty;
            sing1Cantidad.Text = string.Empty;
            sing1Meses.Text = string.Empty;
            sing1Anio.Text = string.Empty;
            sing1Pie.Text = string.Empty;
            sing1Asesor.Text = string.Empty;
        }
        void limpiarSing2()
        {
            sing2Fecha.Value = null;
            sing2Encabezado.SelectedIndex = -1;
            sing2Nombre.Text = string.Empty;
            sing2Direccion1.Text = string.Empty;
            sing2Direccion2.Text = string.Empty;
            sing2Ciudad.Text = string.Empty;
            sing2Saludo.SelectedIndex = -1;
            sing2CantidadL.Text = string.Empty;
            sing2Cantidad.Text = string.Empty;
            sing2Meses.Text = string.Empty;
            sing2Anio.Text = string.Empty;
            sing2Pie.Text = string.Empty;
            sing2Ejecutivo.Text = string.Empty;
        }
        void limpiarSing3()
        {
            sing3Fecha.Value = null;
            sing3Encabezado.SelectedIndex = -1;
            sing3Nombre.Text = string.Empty;
            sing3Direccion.Text = string.Empty;
            sing3Direccion2.Text = string.Empty;
            sing3Ciudad.Text = string.Empty;
            sing3Saludo.SelectedIndex = -1;
            sing3CantidadL.Text = string.Empty;
            sing3Cantidad.Text = string.Empty;
            sing3Meses.Text = string.Empty;
            sing3Anio.Text = string.Empty;
            sing3Pie.Text = string.Empty;
            sing3Asesor.Text = string.Empty;
        }
        void limpiarSing4()
        {
            sing4Fecha.Value = null;
            sing4Encabezado.SelectedIndex = -1;
            sing4Nombre.Text = string.Empty;
            sing4Direccion.Text = string.Empty;
            sing4Direccion2.Text = string.Empty;
            sing4Ciudad.Text = string.Empty;
            sing4Saludo.SelectedIndex = -1;
            sing4Pie.Text = string.Empty;
            sing4Asesor.Text = string.Empty;
        }
        void limpiarSing5()
        {
            sing5Fecha.Value = null;
            sing5Encabezado.SelectedIndex = -1;
            sing5Nombre.Text = string.Empty;
            sing5Direccion.Text = string.Empty;
            sing5Direccion2.Text = string.Empty;
            sing5Ciudad.Text = string.Empty;
            sing5Saludo.SelectedIndex = -1;
            sing5Cantidad.Text = string.Empty;
            sing5Pie.Text = string.Empty;
            sing5Asesor.Text = string.Empty;
        }
        void limpiarPlural1()
        {
            plural1Fecha.Value = null;
            plural1Nombre.Text = string.Empty;
            plural1Direccion.Text = string.Empty;
            plural1Direccion2.Text = string.Empty;
            plural1Ciudad.Text = string.Empty;
            plural1CantidadL.Text = string.Empty;
            plural1Cantidad.Text = string.Empty;
            plural1Meses.Text = string.Empty;
            plural1Anio.Text = string.Empty;
            plural1Pie.Text = string.Empty;
            plural1Asesor.Text = string.Empty;
        }
        void limpiarPlural2()
        {
            plural2Fecha.Value = null;
            plural2Nombre.Text = string.Empty;
            plural2Direccion.Text = string.Empty;
            plural2Direccion2.Text = string.Empty;
            plural2Ciudad.Text = string.Empty;
            plural2CantidadL.Text = string.Empty;
            plural2Cantidad.Text = string.Empty;
            plural2Meses.Text = string.Empty;
            plural2Anio.Text = string.Empty;
            plural2Pie.Text = string.Empty;
            plural2Asesor.Text = string.Empty;
        }
        void limpiarPlural3()
        {
            plural3Fecha.Value = null;
            plural3Nombre.Text = string.Empty;
            plural3Direccion.Text = string.Empty;
            plural3Direccion2.Text = string.Empty;
            plural3Ciudad.Text = string.Empty;
            plural3CantidadL.Text = string.Empty;
            plural3Cantidad.Text = string.Empty;
            plural3Meses.Text = string.Empty;
            plural3Anio.Text = string.Empty;
            plural3Pie.Text = string.Empty;
            plural3Asesor.Text = string.Empty;
        }
        void ocultaTab()
        {
            tabSingular.Visible = false;
            tabPlural.Visible = false;
            tabMantenimiento.Visible = false;
        }
        void ocultaTabSingular()
        {
            tabSingular.Tabs[0].Visible = false;
            tabSingular.Tabs[1].Visible = false;
            tabSingular.Tabs[2].Visible = false;
            tabSingular.Tabs[3].Visible = false;
            tabSingular.Tabs[4].Visible = false;
        }
        void ocultaTabPlural()
        {
            tabPlural.Tabs[0].Visible = false;
            tabPlural.Tabs[1].Visible = false;
            tabPlural.Tabs[2].Visible = false;
            tabPlural.Tabs[3].Visible = false;
            tabPlural.Tabs[4].Visible = false;

        }
        void pantallas(string grupo, string pantalla)
        {
            switch (grupo)
            {
                case "singular":
                    {
                        switch (pantalla)
                        {
                            case "9b1s":
                                {
                                    actualizarSing1();
                                    ocultaTab();
                                    ocultaTabSingular();
                                    tabSingular.Tabs[0].Visible = true;
                                    tabSingular.Dock = DockStyle.Fill;
                                    tabSingular.Visible = true;
                                    break;
                                }
                            case "9b2s":
                                {
                                    actualizarSing2();
                                    ocultaTab();
                                    ocultaTabSingular();
                                    tabSingular.Tabs[1].Visible = true;
                                    tabSingular.Dock = DockStyle.Fill;
                                    tabSingular.Visible = true;
                                    break;
                                }
                            case "9b4s":
                                {
                                    actualizarSing3();
                                    ocultaTab();
                                    ocultaTabSingular();
                                    tabSingular.Tabs[2].Visible = true;
                                    tabSingular.Dock = DockStyle.Fill;
                                    tabSingular.Visible = true;
                                    break;
                                }
                            case "9cs":
                                {
                                    actualizarSing4();
                                    ocultaTab();
                                    ocultaTabSingular();
                                    tabSingular.Tabs[3].Visible = true;
                                    tabSingular.Dock = DockStyle.Fill;
                                    tabSingular.Visible = true;
                                    break;
                                }
                            case "9b30s":
                                {
                                    actualizarSing5();
                                    ocultaTab();
                                    ocultaTabSingular();
                                    tabSingular.Tabs[4].Visible = true;
                                    tabSingular.Dock = DockStyle.Fill;
                                    tabSingular.Visible = true;
                                    break;
                                }
                        }
                        break;

                    }
                case "plural":
                    {
                        switch (pantalla)
                        {
                            case "9b1p":
                                {
                                    actualizaPlural1();
                                    ocultaTab();
                                    ocultaTabPlural();
                                    tabPlural.Tabs[0].Visible = true;
                                    tabPlural.Dock = DockStyle.Fill;
                                    tabPlural.Visible = true;
                                    break;
                                }
                            case "9b2p":
                                {
                                    actualizaPlural2();
                                    ocultaTab();
                                    ocultaTabPlural();
                                    tabPlural.Tabs[1].Visible = true;
                                    tabPlural.Dock = DockStyle.Fill;
                                    tabPlural.Visible = true;
                                    break;
                                }
                            case "9b4p":
                                {
                                    actualizaPlural3();
                                    ocultaTab();
                                    ocultaTabPlural();
                                    tabPlural.Tabs[2].Visible = true;
                                    tabPlural.Dock = DockStyle.Fill;
                                    tabPlural.Visible = true;
                                    break;
                                }
                            case "9cp":
                                {
                                    actualizaPlural4();
                                    ocultaTab();
                                    ocultaTabPlural();
                                    tabPlural.Tabs[3].Visible = true;
                                    tabPlural.Dock = DockStyle.Fill;
                                    tabPlural.Visible = true;
                                    break;
                                }
                            case "9b30p":
                                {
                                    actualizaPlural5();
                                    ocultaTab();
                                    ocultaTabPlural();
                                    tabPlural.Tabs[4].Visible = true;
                                    tabPlural.Dock = DockStyle.Fill;
                                    tabPlural.Visible = true;
                                    break;
                                }
                        }
                        break;
                    }
            }

        }
        private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
        {
            if (e.Item.Group.Index == 0)
            {
                switch (e.Item.Index)
                {
                    case 0:
                        pantallas("singular", "9b1s");
                        break;
                    case 1:
                        pantallas("singular", "9b2s");
                        break;
                    case 2:
                        pantallas("singular", "9b4s");
                        break;
                    case 3:
                        pantallas("singular", "9cs");
                        break;
                    case 4:
                        pantallas("singular", "9b30s");
                        break;
                }
            }
            else
                if (e.Item.Group.Index == 1)
                {
                    switch (e.Item.Index)
                    {
                        case 0:
                            pantallas("plural", "9b1p");
                            break;
                        case 1:
                            pantallas("plural", "9b2p");
                            break;
                        case 2:
                            pantallas("plural", "9b4p");
                            break;
                        case 3:
                            pantallas("plural", "9cp");
                            break;
                        case 4:
                            pantallas("plural", "9b30p");
                            break;
                    }
                }
        }

        private void btnSing2Nuevo_Click(object sender, EventArgs e)
        {
            tipoSing2 = "R";
            desbloquearSing2();
            limpiarSing2();
            sing2Fecha.Value = DateTime.Now;
            btnSing2Primero.Enabled = false;
            btnSing2Atras.Enabled = false;
            btnSing2Siguiente.Enabled = false;
            btnSing2Ultimo.Enabled = false;
            btnSing2Registrar.Enabled = true;
            btnSing2Cancelar.Enabled = true;
            btnSing2Modificar.Enabled = false;
            btnSing2Buscar.Enabled = false;
            btnSing2Nuevo.Enabled = false;
            btnSing2Borrar.Enabled = false;
            conteo.Text = "Nuevo registro";
        }

        private void btnSing2Cancelar_Click(object sender, EventArgs e)
        {
            bloquearSing2();
            actualizarSing2();
        }

        private void btnSing2Registrar_Click(object sender, EventArgs e)
        {
            if (sing2Encabezado.Text == string.Empty)
            {
                MessageBox.Show("Aun no has elegido el encabezado de la carta");
            }
            else
                if (sing2Nombre.Text == string.Empty)
                {
                    MessageBox.Show("Aun no has colocado el nombre de cliente");
                    sing2Nombre.Focus();
                }
                else
                    if (sing2Direccion1.Text == string.Empty)
                    {
                        MessageBox.Show("Aun no has colocado la direccion del cliente");
                        sing2Direccion1.Focus();
                    }
                    else
                        if (sing2Saludo.Text == string.Empty)
                        {
                            MessageBox.Show("Aun no has elegido el saludo de la carta");
                        }
                        else
                            if (sing2CantidadL.Text == string.Empty)
                            {
                                MessageBox.Show("Aun no has colocado el monto en letras");
                                sing2CantidadL.Focus();
                            }
                            else
                                if (sing2Cantidad.Text == string.Empty)
                                {
                                    MessageBox.Show("Aun no has colocado el monto en numeros");
                                    sing2Cantidad.Focus();
                                }
                                else
                                    if (sing2Meses.Text == string.Empty)
                                    {
                                        MessageBox.Show("No has escrito ningun mes aun");
                                        sing2Meses.Focus();
                                    }
                                    else
                                        if (sing2Anio.Text == string.Empty)
                                        {
                                            MessageBox.Show("Aun no has colocado el año");
                                            sing2Anio.Focus();
                                        }
                                        else
                                        {
                                            Clientes c = new Clientes();
                                            c.nombre = sing2Nombre.Text.ToString();
                                            c.direccion = sing2Direccion1.Text.ToString();
                                            c.direccion2 = sing2Direccion2.Text.ToString();
                                            c.ciudad = sing2Ciudad.Text.ToString();
                                            c.tipo = "singular";
                                            c.id = AdminClientes.totalClientes() + 1;
                                            c.fecha = DateTime.Now.ToString();
                                            AdminClientes.registrar(c);
                                            Sing2 s = new Sing2();
                                            s.idCliente = c.id;
                                            s.id =Convert.ToString(DateTime.Now.ToFileTimeUtc())+"-"+AdminSing2.totalSing2().ToString();
                                            s.fecha = sing2Fecha.DateTime;
                                            s.encabezado = sing2Encabezado.Text.ToString();
                                            s.saludo = sing2Saludo.Text.ToString();
                                            s.cantidadL = sing2CantidadL.Text.ToString();
                                            s.cantidad = sing2Cantidad.Text.ToString();
                                            s.meses = sing2Meses.Text.ToString();
                                            s.anio = sing2Anio.Text.ToString();
                                            s.pie = sing2Pie.Text.ToString();
                                            s.asesor = sing2Ejecutivo.Text.ToString();
                                            if (tipoSing2 == "R")
                                            {
                                                AdminSing2.registrar(s);
                                                MessageBox.Show("Registrado con exito");
                                                bloquearSing2();
                                                btnSing2Nuevo.Enabled = true;
                                                btnSing2Registrar.Enabled = false;
                                                btnSing2Cancelar.Enabled = false;
                                                btnSing2Borrar.Enabled = true;
                                                btnSing2Buscar.Enabled = true;
                                                Datos.datosSing2 = AdminSing2.buscaDatosSing2();
                                                actualizarSing2();
                                                filaSing2 = Datos.datosSing2.Rows.Count - 1;
                                                cargaSing2(Datos.datosSing2.Rows[filaSing2]);
                                                conteo.Text = Datos.datosSing2.Rows.Count.ToString() + " de " + Datos.datosSing2.Rows.Count.ToString();
                                                navegacionSing2(filaSing2,filaSing2);
                                            }
                                            else
                                                if (tipoSing2 == "M")
                                                {
                                                    s.id = Datos.datosSing2.Rows[filaSing2]["id"].ToString();
                                                    c.id = Convert.ToInt32(Datos.datosSing2.Rows[filaSing2]["idCliente"].ToString());
                                                    AdminSing2.actualizar(s);
                                                    AdminClientes.actualizar(c);
                                                    bloquearSing2();
                                                    MessageBox.Show("Modificado con exito");
                                                    btnSing2Nuevo.Enabled = true;
                                                    btnSing2Registrar.Enabled = false;
                                                    btnSing2Cancelar.Enabled = false;
                                                    btnSing2Borrar.Enabled = true;
                                                    btnSing2Buscar.Enabled = true;
                                                    btnSing2Modificar.Enabled = true;
                                                    int actual = filaSing2;
                                                    int fin = Datos.datosSing2.Rows.Count - 1;
                                                    Datos.datosSing2 = AdminSing2.buscaDatosSing2();
                                                    cargaSing2(Datos.datosSing2.Rows[actual]);
                                                    conteo.Text = (actual + 1).ToString() + " de " + Datos.datosSing2.Rows.Count.ToString();
                                                    navegacionSing2(actual, fin);
                                                }
                                            else
                                                    if (tipoSing2 == "M2") {
                                                        s.id = Datos.datosSing2.Rows[0]["id"].ToString();
                                                        c.id = Convert.ToInt32(Datos.datosSing2.Rows[0]["idCliente"].ToString());
                                                        AdminSing2.actualizar(s);
                                                        AdminClientes.actualizar(c);
                                                        bloquearSing2();
                                                        MessageBox.Show("Modificado con exito");
                                                        btnSing2Nuevo.Enabled = true;
                                                        btnSing2Registrar.Enabled = false;
                                                        btnSing2Cancelar.Enabled = false;
                                                        btnSing2Borrar.Enabled = true;
                                                        btnSing2Buscar.Enabled = true;
                                                        btnSing2Modificar.Enabled = true;
                                                        int actual = 0;
                                                        int fin = 0;
                                                        Datos.datosSing2 = AdminSing2.consultaPorId(s.id);
                                                        cargaSing2(Datos.datosSing2.Rows[actual]);
                                                        conteo.Text = (actual + 1).ToString() + " de " + Datos.datosSing2.Rows.Count.ToString();
                                                        navegacionSing2(actual, fin);
                                                    
                                                    }
                                        }
        }

        private void btnSing2Modificar_Click(object sender, EventArgs e)
        {
            if (busSing2 == true)
            {
                tipoSing2 = "M2";
            }
            else
            {
                tipoSing2 = "M";
            }
            desbloquearSing2();
            btnSing2Primero.Enabled = false;
            btnSing2Atras.Enabled = false;
            btnSing2Siguiente.Enabled = false;
            btnSing2Ultimo.Enabled = false;
            btnSing2Registrar.Enabled = true;
            btnSing2Cancelar.Enabled = true;
            btnSing2Modificar.Enabled = false;
            btnSing2Buscar.Enabled = false;
            btnSing2Nuevo.Enabled = false;
            btnSing2Borrar.Enabled = false;
            conteo.Text = "Modificar registro";            
        }

        private void ultraTabControl2_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            if (e.Tab.Index == 0) {
            }
            else
                if (e.Tab.Index == 1)
                {
                    if (Datos.datosSing2.Rows.Count > 0)
                    {
                        reporteSing22(Datos.datosSing2.Rows[filaSing2]);
                    }
                }

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnSing2Ultimo_Click(object sender, EventArgs e)
        {
            filaSing2 = Datos.datosSing2.Rows.Count - 1;
            cargaSing2(Datos.datosSing2.Rows[filaSing2]);
            navegacionSing2(filaSing2, filaSing2);
            conteo.Text = Datos.datosSing2.Rows.Count.ToString()+ " de " + Datos.datosSing2.Rows.Count.ToString();
        }

        private void btnSing2Primero_Click(object sender, EventArgs e)
        {
            filaSing2 = 0;
            navegacionSing2(filaSing2, Datos.datosSing2.Rows.Count - 1);
            cargaSing2(Datos.datosSing2.Rows[filaSing2]);
            conteo.Text = (filaSing2 + 1).ToString() + " de " + Datos.datosSing2.Rows.Count.ToString();
        }

        private void btnSing2Atras_Click(object sender, EventArgs e)
        {
            int total = Datos.datosSing2.Rows.Count - 1;
            filaSing2 = filaSing2 - 1;
            navegacionSing2(filaSing2, total);
            cargaSing2(Datos.datosSing2.Rows[filaSing2]);
             conteo.Text = (filaSing2 + 1).ToString() + " de " + Datos.datosSing2.Rows.Count.ToString();
        }

        private void btnSing2Siguiente_Click(object sender, EventArgs e)
        {
            int total = Datos.datosSing2.Rows.Count - 1;
            filaSing2 = filaSing2 + 1;
            navegacionSing2(filaSing2, total);
            cargaSing2(Datos.datosSing2.Rows[filaSing2]);
            conteo.Text = (filaSing2+1).ToString() + " de " + Datos.datosSing2.Rows.Count.ToString();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSing2Refrescar_Click(object sender, EventArgs e)
        {
            Datos.datosSing2 = AdminSing2.buscaDatosSing2();
            actualizarSing2();
        }

        private void btnSing2Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer eliminar este registro", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminSing2.eliminar(Datos.datosSing2.Rows[filaSing2]["id"].ToString());
                Datos.datosSing2 = AdminSing2.buscaDatosSing2();
                actualizarSing2();
            }
            else
            {
                
            }
        }

        private void sing2Anio_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void sing2Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDecimales(e, sing2Cantidad.Text);
        }

        private void ultraTabControl6_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            if (e.Tab.Index == 0)
            {
            }
            else
                if (e.Tab.Index == 1)
                {
                    if (Datos.datosPlural2.Rows.Count > 0)
                    {
                        reportePlural2(Datos.datosPlural2.Rows[filaPlural2]);
                    }
                }
        }

        private void plural2Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDecimales(e, plural2Cantidad.Text);
        }

        private void plural2Anio_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void ultraTextEditor26_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void ultraTextEditor34_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void maskedTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDecimales(e, plural3Cantidad.Text);
        }

        private void plural2Registrar_Click(object sender, EventArgs e)
        {
            if (plural2Nombre.Text == string.Empty)
            {
                MessageBox.Show("Aun no has colocado el nombre del negocio");
                plural2Nombre.Focus();
            }
            else
                if (plural2Direccion.Text == string.Empty)
                {
                    MessageBox.Show("Aun no has colocado la direccion del negocio");
                    plural2Direccion.Focus();
                }
                else
                    if (plural2CantidadL.Text == string.Empty)
                    {
                        MessageBox.Show("Aun no has colocado el monto en letras");
                        plural2CantidadL.Focus();
                    }
                    else
                        if (plural2Cantidad.Text == string.Empty)
                        {
                            MessageBox.Show("Aun no has colocado el monto en numeros");
                            plural2Cantidad.Focus();
                        }
                        else
                            if (plural2Meses.Text == string.Empty)
                            {
                                MessageBox.Show("No has escrito ningun mes aun");
                                plural2Meses.Focus();
                            }
                            else
                                if (plural2Anio.Text == string.Empty)
                                {
                                    MessageBox.Show("Aun no has colocado el año");
                                    plural2Anio.Focus();
                                }
                                else
                                {
                                    Clientes c = new Clientes();
                                    c.nombre = plural2Nombre.Text.ToString();
                                    c.direccion = plural2Direccion.Text.ToString();
                                    c.direccion2 = plural2Direccion2.Text.ToString();
                                    c.ciudad = plural2Ciudad.Text.ToString();
                                    c.tipo = "plural";
                                    c.id = AdminClientes.totalClientes() + 1;
                                    c.fecha = DateTime.Now.ToString();
                                    Plural2 s = new Plural2();
                                    s.idCliente = c.id;
                                    s.id = Convert.ToString(DateTime.Now.ToFileTimeUtc()) + "-" + AdminPlural2.totalPlural2().ToString();
                                    s.fecha = plural2Fecha.DateTime;
                                    s.cantidadL = plural2CantidadL.Text.ToString();
                                    s.cantidad = plural2Cantidad.Text.ToString();
                                    s.meses = plural2Meses.Text.ToString();
                                    s.anio = plural2Anio.Text.ToString();
                                    s.pie = plural2Pie.Text.ToString();
                                    s.asesor = plural2Asesor.Text.ToString();
                                    if (tipoPlural2 == "R")
                                    {
                                        AdminPlural2.registrar(s);
                                        AdminClientes.registrar(c);
                                        MessageBox.Show("Registrado con exito");
                                        bloquearPlural2();
                                        plural2Nuevo.Enabled = true;
                                        plural2Registrar.Enabled = false;
                                        plural2Cancelar.Enabled = false;
                                        plural2Borrar.Enabled = true;
                                        plural2Buscar.Enabled = true;
                                        Datos.datosPlural2 = AdminPlural2.buscaDatosPlural2();
                                        actualizaPlural2();
                                        filaPlural2 = Datos.datosPlural2.Rows.Count - 1;
                                        cargaPlural2(Datos.datosPlural2.Rows[filaPlural2]);
                                        plural2Conteo.Text = Datos.datosPlural2.Rows.Count.ToString() + " de " + Datos.datosPlural2.Rows.Count.ToString();
                                        navegacionPlural2(filaPlural2,filaPlural2);
                                    }
                                    else
                                        if (tipoPlural2 == "M")
                                        {
                                            s.id = Datos.datosPlural2.Rows[filaPlural2]["id"].ToString();
                                            c.id = Convert.ToInt32(Datos.datosPlural2.Rows[filaPlural2]["idCliente"].ToString());
                                            AdminPlural2.actualizar(s);
                                            AdminClientes.actualizar(c);
                                            bloquearPlural2();
                                            MessageBox.Show("Modificado con exito");
                                            plural2Nuevo.Enabled = true;
                                            plural2Registrar.Enabled = false;
                                            plural2Cancelar.Enabled = false;
                                            plural2Modificar.Enabled = true;
                                            plural2Borrar.Enabled = true;
                                            plural2Buscar.Enabled = true;
                                            int actual = filaPlural2;
                                            int fin = Datos.datosPlural2.Rows.Count - 1;
                                            Datos.datosPlural2 = AdminPlural2.buscaDatosPlural2();
                                            cargaPlural2(Datos.datosPlural2.Rows[actual]);
                                            plural2Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosPlural2.Rows.Count.ToString();
                                            navegacionPlural2(actual, fin);
                                        }
                                        else
                                            if (tipoPlural2 == "M2")
                                            {
                                                s.id = Datos.datosPlural2.Rows[0]["id"].ToString();
                                                c.id = Convert.ToInt32(Datos.datosPlural2.Rows[0]["idCliente"].ToString());
                                                AdminPlural2.actualizar(s);
                                                AdminClientes.actualizar(c);
                                                bloquearPlural2();
                                                MessageBox.Show("Modificado con exito");
                                                plural2Nuevo.Enabled = true;
                                                plural2Registrar.Enabled = false;
                                                plural2Cancelar.Enabled = false;
                                                plural2Borrar.Enabled = true;
                                                plural2Buscar.Enabled = true;
                                                plural2Modificar.Enabled = true;
                                                int actual = 0;
                                                int fin = 0;
                                                Datos.datosPlural2 = AdminPlural2.consultaPorId(s.id);
                                                cargaPlural2(Datos.datosPlural2.Rows[actual]);
                                                plural2Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosPlural2.Rows.Count.ToString();
                                                navegacionPlural2(actual, fin);

                                            }
                                }

        }

        private void plural2Nuevo_Click(object sender, EventArgs e)
        {
            tipoPlural2 = "R";
            desbloquearPlural2();
            limpiarPlural2();
            plural2Fecha.Value = DateTime.Now;
            plural2Primero.Enabled = false;
            plural2Atras.Enabled = false;
            plural2Siguiente.Enabled = false;
            plural2Ultimo.Enabled = false;
            plural2Registrar.Enabled = true;
            plural2Cancelar.Enabled = true;
            plural2Modificar.Enabled = false;
            plural2Buscar.Enabled = false;
            plural2Nuevo.Enabled = false;
            plural2Borrar.Enabled = false;
            plural2Conteo.Text = "Nuevo registro";
        }

        private void plural2Atras_Click(object sender, EventArgs e)
        {
            int total = Datos.datosPlural2.Rows.Count - 1;
            filaPlural2 = filaPlural2 - 1;
            navegacionPlural2(filaPlural2, total);
            cargaPlural2(Datos.datosPlural2.Rows[filaPlural2]);
            plural2Conteo.Text = (filaPlural2 + 1).ToString() + " de " + Datos.datosPlural2.Rows.Count.ToString();
        }

        private void plural2Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer eliminar este registro", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminPlural2.eliminar(Datos.datosPlural2.Rows[filaPlural2]["id"].ToString());
                Datos.datosPlural2 = AdminPlural2.buscaDatosPlural2();
                actualizaPlural2();
            }
            else
            {

            }
        }

        private void plural2Cancelar_Click(object sender, EventArgs e)
        {
            bloquearPlural2();
            actualizaPlural2();
        }

        private void plural2Modificar_Click(object sender, EventArgs e)
        {
            if (busPlural2 == true)
            {
                tipoPlural2 = "M2";
            }
            else
            {
                tipoPlural2 = "M";
            }
            desbloquearPlural2();
            plural2Primero.Enabled = false;
            plural2Atras.Enabled = false;
            plural2Siguiente.Enabled = false;
            plural2Ultimo.Enabled = false;
            plural2Registrar.Enabled = true;
            plural2Cancelar.Enabled = true;
            plural2Modificar.Enabled = false;
            plural2Buscar.Enabled = false;
            plural2Nuevo.Enabled = false;
            plural2Borrar.Enabled = false;
            plural2Conteo.Text = "Modificar registro";
        }

        private void plural2Primero_Click(object sender, EventArgs e)
        {
            filaPlural2 = 0;
            navegacionPlural2(filaPlural2, Datos.datosPlural2.Rows.Count - 1);
            cargaPlural2(Datos.datosSing2.Rows[filaPlural2]);
            plural2Conteo.Text = (filaPlural2 + 1).ToString() + " de " + Datos.datosPlural2.Rows.Count.ToString();
        }

        private void plural2Actualizar_Click(object sender, EventArgs e)
        {
            Datos.datosPlural2 = AdminPlural2.buscaDatosPlural2();
            actualizaPlural2();
        }

        private void plural2Siguiente_Click(object sender, EventArgs e)
        {
            int total = Datos.datosPlural2.Rows.Count - 1;
            filaPlural2 = filaPlural2 + 1;
            navegacionPlural2(filaPlural2, total);
            cargaPlural2(Datos.datosPlural2.Rows[filaPlural2]);
            plural2Conteo.Text = (filaPlural2 + 1).ToString() + " de " + Datos.datosPlural2.Rows.Count.ToString();
        }

        private void plural2Ultimo_Click(object sender, EventArgs e)
        {
            filaPlural2 = Datos.datosPlural2.Rows.Count - 1;
            cargaPlural2(Datos.datosSing2.Rows[filaPlural2]);
            navegacionPlural2(filaPlural2, filaPlural2);
            plural2Conteo.Text = Datos.datosPlural2.Rows.Count.ToString() + " de " + Datos.datosPlural2.Rows.Count.ToString();
        }

        private void ultraTabControl7_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            if (e.Tab.Index == 0)
            {
            }
            else
                if (e.Tab.Index == 1)
                {
                    if (Datos.datosPlural1.Rows.Count > 0)
                    {
                        reportePlural1(Datos.datosPlural1.Rows[filaPlural1]);
                    }
                }
        }

        private void sing3Cancelar_Click(object sender, EventArgs e)
        {
            bloquearSing3();
            actualizarSing3();
        }

        private void sing1Cancelar_Click(object sender, EventArgs e)
        {
            bloquearSing1();
            actualizarSing1();
        }

        private void sing1Atras_Click(object sender, EventArgs e)
        {
            int total = Datos.datosSing1.Rows.Count - 1;
            filaSing1 = filaSing1 - 1;
            navegacionSing1(filaSing1, total);
            cargaSing1(Datos.datosSing1.Rows[filaSing1]);
            sing1Conteo.Text = (filaSing1 + 1).ToString() + " de " + Datos.datosSing1.Rows.Count.ToString();
        }

        private void sing3Atras_Click(object sender, EventArgs e)
        {
            int total = Datos.datosSing3.Rows.Count - 1;
            filaSing3 = filaSing3 - 1;
            navegacionSing3(filaSing3, total);
            cargaSing3(Datos.datosSing3.Rows[filaSing1]);
            sing3Conteo.Text = (filaSing3 + 1).ToString() + " de " + Datos.datosSing3.Rows.Count.ToString();
        }

        private void sing3Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer eliminar este registro", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminSing3.eliminar(Datos.datosSing3.Rows[filaSing3]["id"].ToString());
                Datos.datosSing3 = AdminSing3.buscaDatosSing3();
                actualizarSing3();
            }
            else
            {

            }
        }

        private void sing1Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer eliminar este registro", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminSing1.eliminar(Datos.datosSing1.Rows[filaSing1]["id"].ToString());
                Datos.datosSing1 = AdminSing1.buscaDatosSing1();
                actualizarSing1();
            }
            else
            {

            }
        }

        private void sing1Modificar_Click(object sender, EventArgs e)
        {
            if (busSing1 == true)
            {
                tipoSing1 = "M2";
            }
            else
            {
                tipoSing1 = "M";
            }
            desbloquearSing1();
            sing1Primero.Enabled = false;
            sing1Atras.Enabled = false;
            sing1Siguiente.Enabled = false;
            sing1Ultimo.Enabled = false;
            sing1Registrar.Enabled = true;
            sing1Cancelar.Enabled = true;
            sing1Modificar.Enabled = false;
            sing1Buscar.Enabled = false;
            sing1Nuevo.Enabled = false;
            sing1Borrar.Enabled = false;
            sing1Conteo.Text = "Modificar registro"; 
        }

        private void sing3Modificar_Click(object sender, EventArgs e)
        {
            if (busSing3 == true)
            {
                tipoSing3 = "M2";
            }
            else
            {
                tipoSing3 = "M";
            }
            desbloquearSing3();
            sing3Primero.Enabled = false;
            sing3Atras.Enabled = false;
            sing3Siguiente.Enabled = false;
            sing3Ultimo.Enabled = false;
            sing3Registrar.Enabled = true;
            sing3Cancelar.Enabled = true;
            sing3Modificar.Enabled = false;
            sing3Buscar.Enabled = false;
            sing3Nuevo.Enabled = false;
            sing3Borrar.Enabled = false;
            sing3Conteo.Text = "Modificar registro";
        }

        private void sing3Nuevo_Click(object sender, EventArgs e)
        {
            tipoSing3 = "R";
            desbloquearSing3();
            limpiarSing3();
            sing3Fecha.Value = DateTime.Now;
            sing3Primero.Enabled = false;
            sing3Atras.Enabled = false;
            sing3Siguiente.Enabled = false;
            sing3Ultimo.Enabled = false;
            sing3Registrar.Enabled = true;
            sing3Cancelar.Enabled = true;
            sing3Modificar.Enabled = false;
            sing3Buscar.Enabled = false;
            sing3Nuevo.Enabled = false;
            sing3Borrar.Enabled = false;
            sing3Conteo.Text = "Nuevo registro";
        }

        private void sing1Nuevo_Click(object sender, EventArgs e)
        {
            tipoSing1 = "R";
            desbloquearSing1();
            limpiarSing1();
            sing1Fecha.Value = DateTime.Now;
            sing1Primero.Enabled = false;
            sing1Atras.Enabled = false;
            sing1Siguiente.Enabled = false;
            sing1Ultimo.Enabled = false;
            sing1Registrar.Enabled = true;
            sing1Buscar.Enabled = false;
            sing1Cancelar.Enabled = true;
            sing1Modificar.Enabled = false;
            sing1Nuevo.Enabled = false;
            sing1Borrar.Enabled = false;
            sing1Conteo.Text = "Nuevo registro";
        }

        private void sing1Primero_Click(object sender, EventArgs e)
        {
            filaSing1 = 0;
            navegacionSing1(filaSing1, Datos.datosSing1.Rows.Count - 1);
            cargaSing1(Datos.datosSing1.Rows[filaSing1]);
            sing1Conteo.Text = (filaSing1 + 1).ToString() + " de " + Datos.datosSing1.Rows.Count.ToString();
        }

        private void sing3Primero_Click(object sender, EventArgs e)
        {
            filaSing3 = 0;
            navegacionSing3(filaSing3, Datos.datosSing3.Rows.Count - 1);
            cargaSing3(Datos.datosSing3.Rows[filaSing3]);
            sing3Conteo.Text = (filaSing3 + 1).ToString() + " de " + Datos.datosSing3.Rows.Count.ToString();
        }

        private void sing3Actualizar_Click(object sender, EventArgs e)
        {
            Datos.datosSing3 = AdminSing3.buscaDatosSing3();
            actualizarSing3();
        }

        private void sing1Actualizar_Click(object sender, EventArgs e)
        {
            Datos.datosSing1 = AdminSing1.buscaDatosSing1();
            actualizarSing1();
        }

        private void sing1Siguiente_Click(object sender, EventArgs e)
        {
            int total = Datos.datosSing1.Rows.Count - 1;
            filaSing1 = filaSing1 + 1;
            navegacionSing1(filaSing1, total);
            cargaSing1(Datos.datosSing1.Rows[filaSing1]);
            sing1Conteo.Text = (filaSing1 + 1).ToString() + " de " + Datos.datosSing1.Rows.Count.ToString();
        }

        private void sing3Siguiente_Click(object sender, EventArgs e)
        {
            int total = Datos.datosSing3.Rows.Count - 1;
            filaSing3 = filaSing3 + 1;
            navegacionSing3(filaSing3, total);
            cargaSing3(Datos.datosSing3.Rows[filaSing3]);
            sing3Conteo.Text = (filaSing3 + 1).ToString() + " de " + Datos.datosSing3.Rows.Count.ToString();
        }

        private void sing3Registrar_Click(object sender, EventArgs e)
        {
            if (sing3Encabezado.Text == string.Empty)
            {
                MessageBox.Show("Aun no has elegido el encabezado de la carta");
            }
            else
                if (sing3Nombre.Text == string.Empty)
                {
                    MessageBox.Show("Aun no has colocado el nombre de cliente");
                    sing3Nombre.Focus();
                }
                else
                    if (sing3Direccion.Text == string.Empty)
                    {
                        MessageBox.Show("Aun no has colocado la direccion del cliente");
                        sing3Direccion.Focus();
                    }
                    else
                        if (sing3Saludo.Text == string.Empty)
                        {
                            MessageBox.Show("Aun no has elegido el saludo de la carta");
                        }
                        else
                            if (sing3CantidadL.Text == string.Empty)
                            {
                                MessageBox.Show("Aun no has colocado el monto en letras");
                                sing3CantidadL.Focus();
                            }
                            else
                                if (sing3Cantidad.Text == string.Empty)
                                {
                                    MessageBox.Show("Aun no has colocado el monto en numeros");
                                    sing3Cantidad.Focus();
                                }
                                else
                                    if (sing3Meses.Text == string.Empty)
                                    {
                                        MessageBox.Show("No has escrito ningun mes aun");
                                        sing3Meses.Focus();
                                    }
                                    else
                                        if (sing3Anio.Text == string.Empty)
                                        {
                                            MessageBox.Show("Aun no has colocado el año");
                                            sing3Anio.Focus();
                                        }
                                        else
                                        {
                                            Clientes c = new Clientes();
                                            c.nombre = sing3Nombre.Text.ToString();
                                            c.direccion = sing3Direccion.Text.ToString();
                                            c.direccion2 = sing3Direccion2.Text.ToString();
                                            c.ciudad = sing3Ciudad.Text.ToString();
                                            c.tipo = "singular";
                                            c.id = AdminClientes.totalClientes() + 1;
                                            c.fecha = DateTime.Now.ToString();
                                            AdminClientes.registrar(c);
                                            Sing2 s = new Sing2();
                                            s.idCliente = c.id;
                                            s.id = Convert.ToString(DateTime.Now.ToFileTimeUtc()) + "-" + AdminSing3.totalSing3().ToString();
                                            s.fecha = sing3Fecha.DateTime;
                                            s.encabezado = sing3Encabezado.Text.ToString();
                                            s.saludo = sing3Saludo.Text.ToString();
                                            s.cantidadL = sing3CantidadL.Text.ToString();
                                            s.cantidad = sing3Cantidad.Text.ToString();
                                            s.meses = sing3Meses.Text.ToString();
                                            s.anio = sing3Anio.Text.ToString();
                                            s.pie = sing3Pie.Text.ToString();
                                            s.asesor = sing3Asesor.Text.ToString();
                                            if (tipoSing3 == "R")
                                            {
                                                AdminSing3.registrar(s);
                                                MessageBox.Show("Registrado con exito");
                                                bloquearSing3();
                                                sing3Nuevo.Enabled = true;
                                                sing3Registrar.Enabled = false;
                                                sing3Cancelar.Enabled = false;
                                                sing3Borrar.Enabled = true;
                                                sing3Buscar.Enabled = true;
                                                Datos.datosSing3 = AdminSing3.buscaDatosSing3();
                                                actualizarSing3();
                                                filaSing3 = Datos.datosSing3.Rows.Count - 1;
                                                cargaSing3(Datos.datosSing3.Rows[filaSing3]);
                                                sing3Conteo.Text = Datos.datosSing3.Rows.Count.ToString() + " de " + Datos.datosSing3.Rows.Count.ToString();
                                                navegacionSing3(filaSing3, filaSing3);
                                            }
                                            else
                                                if (tipoSing3 == "M")
                                                {
                                                    s.id = Datos.datosSing3.Rows[filaSing3]["id"].ToString();
                                                    c.id = Convert.ToInt32(Datos.datosSing3.Rows[filaSing3]["idCliente"].ToString());
                                                    AdminSing3.actualizar(s);
                                                    AdminClientes.actualizar(c);
                                                    bloquearSing3();
                                                    MessageBox.Show("Modificado con exito");
                                                    sing3Nuevo.Enabled = true;
                                                    sing3Registrar.Enabled = false;
                                                    sing3Cancelar.Enabled = false;
                                                    sing3Borrar.Enabled = true;
                                                    sing3Buscar.Enabled = true;
                                                    sing3Modificar.Enabled = true;
                                                    int actual = filaSing3;
                                                    int fin = Datos.datosSing3.Rows.Count - 1;
                                                    Datos.datosSing3 = AdminSing3.buscaDatosSing3();
                                                    cargaSing3(Datos.datosSing3.Rows[actual]);
                                                    sing3Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosSing3.Rows.Count.ToString();
                                                    navegacionSing3(actual, fin);
                                                }
                                                else
                                                    if (tipoSing3 == "M2")
                                                    {
                                                        s.id = Datos.datosSing3.Rows[0]["id"].ToString();
                                                        c.id = Convert.ToInt32(Datos.datosSing3.Rows[0]["idCliente"].ToString());
                                                        AdminSing3.actualizar(s);
                                                        AdminClientes.actualizar(c);
                                                        bloquearSing3();
                                                        MessageBox.Show("Modificado con exito");
                                                        sing3Nuevo.Enabled = true;
                                                        sing3Registrar.Enabled = false;
                                                        sing3Cancelar.Enabled = false;
                                                        sing3Borrar.Enabled = true;
                                                        sing3Buscar.Enabled = true;
                                                        sing3Modificar.Enabled = true;
                                                        int actual = 0;
                                                        int fin = 0;
                                                        Datos.datosSing3 = AdminSing3.consultaPorId(s.id);
                                                        cargaSing3(Datos.datosSing3.Rows[actual]);
                                                        sing3Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosSing3.Rows.Count.ToString();
                                                        navegacionSing3(actual, fin);

                                                    }
                                        }
        }

        private void sing1Registrar_Click(object sender, EventArgs e)
        {
            if (sing1Encabezado.Text == string.Empty)
            {
                MessageBox.Show("Aun no has elegido el encabezado de la carta");
            }
            else
                if (sing1Nombre.Text == string.Empty)
                {
                    MessageBox.Show("Aun no has colocado el nombre de cliente");
                    sing1Nombre.Focus();
                }
                else
                    if (sing1Direccion.Text == string.Empty)
                    {
                        MessageBox.Show("Aun no has colocado la direccion del cliente");
                        sing1Direccion.Focus();
                    }
                    else
                        if (sing1Saludo.Text == string.Empty)
                        {
                            MessageBox.Show("Aun no has elegido el saludo de la carta");
                        }
                        else
                            if (sing1CantidadL.Text == string.Empty)
                            {
                                MessageBox.Show("Aun no has colocado el monto en letras");
                                sing1CantidadL.Focus();
                            }
                            else
                                if (sing1Cantidad.Text == string.Empty)
                                {
                                    MessageBox.Show("Aun no has colocado el monto en numeros");
                                    sing1Cantidad.Focus();
                                }
                                else
                                    if (sing1Meses.Text == string.Empty)
                                    {
                                        MessageBox.Show("No has escrito ningun mes aun");
                                        sing1Meses.Focus();
                                    }
                                    else
                                        if (sing1Anio.Text == string.Empty)
                                        {
                                            MessageBox.Show("Aun no has colocado el año");
                                            sing1Anio.Focus();
                                        }
                                        else
                                        {
                                            Clientes c = new Clientes();
                                            c.nombre = sing1Nombre.Text.ToString();
                                            c.direccion = sing1Direccion.Text.ToString();
                                            c.direccion2 = sing1Direccion2.Text.ToString();
                                            c.ciudad = sing1Ciudad.Text.ToString();
                                            c.tipo = "singular";
                                            c.id = AdminClientes.totalClientes() + 1;
                                            c.fecha = DateTime.Now.ToString();
                                            AdminClientes.registrar(c);
                                            Sing2 s = new Sing2();
                                            s.idCliente = c.id;
                                            s.id = Convert.ToString(DateTime.Now.ToFileTimeUtc()) + "-" + AdminSing1.totalSing1().ToString();
                                            s.fecha = sing1Fecha.DateTime;
                                            s.encabezado = sing1Encabezado.Text.ToString();
                                            s.saludo = sing1Saludo.Text.ToString();
                                            s.cantidadL = sing1CantidadL.Text.ToString();
                                            s.cantidad = sing1Cantidad.Text.ToString();
                                            s.meses = sing1Meses.Text.ToString();
                                            s.anio = sing1Anio.Text.ToString();
                                            s.pie = sing1Pie.Text.ToString();
                                            s.asesor = sing1Asesor.Text.ToString();
                                            if (tipoSing1 == "R")
                                            {
                                                AdminSing1.registrar(s);
                                                MessageBox.Show("Registrado con exito");
                                                bloquearSing1();
                                                sing1Nuevo.Enabled = true;
                                                sing1Registrar.Enabled = false;
                                                sing1Cancelar.Enabled = false;
                                                sing1Borrar.Enabled = true;
                                                sing1Buscar.Enabled = true;
                                                Datos.datosSing1 = AdminSing1.buscaDatosSing1();
                                                actualizarSing1();
                                                filaSing1 = Datos.datosSing1.Rows.Count - 1;
                                                cargaSing1(Datos.datosSing1.Rows[filaSing1]);
                                                sing1Conteo.Text = Datos.datosSing1.Rows.Count.ToString() + " de " + Datos.datosSing1.Rows.Count.ToString();
                                                navegacionSing1(filaSing1, filaSing1);
                                            }
                                            else
                                                if (tipoSing1 == "M")
                                                {
                                                    s.id = Datos.datosSing1.Rows[filaSing1]["id"].ToString();
                                                    c.id = Convert.ToInt32(Datos.datosSing1.Rows[filaSing1]["idCliente"].ToString());
                                                    AdminSing1.actualizar(s);
                                                    AdminClientes.actualizar(c);
                                                    bloquearSing1();
                                                    MessageBox.Show("Modificado con exito");
                                                    sing1Nuevo.Enabled = true;
                                                    sing1Registrar.Enabled = false;
                                                    sing1Cancelar.Enabled = false;
                                                    sing1Borrar.Enabled = true;
                                                    sing1Buscar.Enabled = true;
                                                    sing1Modificar.Enabled = true;
                                                    int actual = filaSing1;
                                                    int fin = Datos.datosSing1.Rows.Count - 1;
                                                    Datos.datosSing1 = AdminSing1.buscaDatosSing1();
                                                    cargaSing1(Datos.datosSing1.Rows[actual]);
                                                    sing1Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosSing1.Rows.Count.ToString();
                                                    navegacionSing1(actual, fin);
                                                }
                                                else
                                                    if (tipoSing1 == "M2")
                                                    {
                                                        s.id = Datos.datosSing1.Rows[0]["id"].ToString();
                                                        c.id = Convert.ToInt32(Datos.datosSing1.Rows[0]["idCliente"].ToString());
                                                        AdminSing1.actualizar(s);
                                                        AdminClientes.actualizar(c);
                                                        bloquearSing1();
                                                        MessageBox.Show("Modificado con exito");
                                                        sing1Nuevo.Enabled = true;
                                                        sing1Registrar.Enabled = false;
                                                        sing1Cancelar.Enabled = false;
                                                        sing1Borrar.Enabled = true;
                                                        sing1Buscar.Enabled = true;
                                                        sing1Modificar.Enabled = true;
                                                        int actual = 0;
                                                        int fin = 0;
                                                        Datos.datosSing1 = AdminSing1.consultaPorId(s.id);
                                                        cargaSing1(Datos.datosSing1.Rows[actual]);
                                                        sing1Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosSing1.Rows.Count.ToString();
                                                        navegacionSing1(actual, fin);

                                                    }
                                        }

        }

        private void ultraTabControl1_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            if (e.Tab.Index == 0)
            {
            }
            else
                if (e.Tab.Index == 1)
                {
                    if (Datos.datosSing1.Rows.Count > 0)
                    {
                        reporteSing1(Datos.datosSing1.Rows[filaSing1]);
                    }
                }
        }

        private void ultraTabControl3_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            if (e.Tab.Index == 0)
            {
            }
            else
                if (e.Tab.Index == 1)
                {
                    if (Datos.datosSing3.Rows.Count > 0)
                    {
                        reporteSing3(Datos.datosSing3.Rows[filaSing3]);
                    }
                }
        }

        private void plural1Actualizar_Click(object sender, EventArgs e)
        {
            Datos.datosPlural1 = AdminPlural1.buscaDatosPlural1();
            actualizaPlural1();
        }

        private void plural3Actualizar_Click(object sender, EventArgs e)
        {
            Datos.datosPlural3 = AdminPlural3.buscaDatosPlural3();
            actualizaPlural3();
        }

        private void plural3Ultimo_Click(object sender, EventArgs e)
        {
            filaPlural3 = Datos.datosPlural3.Rows.Count - 1;
            cargaPlural3(Datos.datosSing3.Rows[filaPlural3]);
            navegacionPlural3(filaPlural3, filaPlural3);
            plural3Conteo.Text = Datos.datosPlural3.Rows.Count.ToString() + " de " + Datos.datosPlural3.Rows.Count.ToString();
        }

        private void plural1Ultimo_Click(object sender, EventArgs e)
        {
            filaPlural1 = Datos.datosPlural1.Rows.Count - 1;
            cargaPlural1(Datos.datosSing1.Rows[filaPlural2]);
            navegacionPlural1(filaPlural1, filaPlural1);
            plural1Conteo.Text = Datos.datosPlural1.Rows.Count.ToString() + " de " + Datos.datosPlural1.Rows.Count.ToString();
        }

        private void plural1Atras_Click(object sender, EventArgs e)
        {
            int total = Datos.datosPlural1.Rows.Count - 1;
            filaPlural1 = filaPlural1 - 1;
            navegacionPlural1(filaPlural1, total);
            cargaPlural1(Datos.datosPlural1.Rows[filaPlural1]);
            plural1Conteo.Text = (filaPlural1 + 1).ToString() + " de " + Datos.datosPlural1.Rows.Count.ToString();
        }

        private void plural3Atras_Click(object sender, EventArgs e)
        {
            int total = Datos.datosPlural3.Rows.Count - 1;
            filaPlural3 = filaPlural3 - 1;
            navegacionPlural3(filaPlural3, total);
            cargaPlural3(Datos.datosPlural3.Rows[filaPlural2]);
            plural3Conteo.Text = (filaPlural3 + 1).ToString() + " de " + Datos.datosPlural3.Rows.Count.ToString();
        }

        private void plural3Siguiente_Click(object sender, EventArgs e)
        {
            int total = Datos.datosPlural3.Rows.Count - 1;
            filaPlural3 = filaPlural3 + 1;
            navegacionPlural3(filaPlural3, total);
            cargaPlural3(Datos.datosPlural3.Rows[filaPlural3]);
            plural3Conteo.Text = (filaPlural3 + 1).ToString() + " de " + Datos.datosPlural3.Rows.Count.ToString();
        }

        private void plural1Siguiente_Click(object sender, EventArgs e)
        {
            int total = Datos.datosPlural1.Rows.Count - 1;
            filaPlural1 = filaPlural1 + 1;
            navegacionPlural1(filaPlural1, total);
            cargaPlural1(Datos.datosPlural1.Rows[filaPlural1]);
            plural1Conteo.Text = (filaPlural1 + 1).ToString() + " de " + Datos.datosPlural1.Rows.Count.ToString();
        }

        private void plural1Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer eliminar este registro", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminPlural1.eliminar(Datos.datosPlural1.Rows[filaPlural1]["id"].ToString());
                Datos.datosPlural1 = AdminPlural1.buscaDatosPlural1();
                actualizaPlural1();
            }
            else
            {

            }
        }

        private void plural3Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer eliminar este registro", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminPlural3.eliminar(Datos.datosPlural3.Rows[filaPlural3]["id"].ToString());
                Datos.datosPlural3 = AdminPlural3.buscaDatosPlural3();
                actualizaPlural3();
            }
            else
            {

            }
        }

        private void plural1Nuevo_Click(object sender, EventArgs e)
        {
            tipoPlural1 = "R";
            desbloquearPlural1();
            limpiarPlural1();
            plural1Fecha.Value = DateTime.Now;
            plural1Primero.Enabled = false;
            plural1Atras.Enabled = false;
            plural1Siguiente.Enabled = false;
            plural1Ultimo.Enabled = false;
            plural1Registrar.Enabled = true;
            plural1Cancelar.Enabled = true;
            plural1Modificar.Enabled = false;
            plural1Buscar.Enabled = false;
            plural1Nuevo.Enabled = false;
            plural1Borrar.Enabled = false;
            plural1Conteo.Text = "Nuevo registro";
        }

        private void plural3Nuevo_Click(object sender, EventArgs e)
        {
            tipoPlural3 = "R";
            desbloquearPlural3();
            limpiarPlural3();
            plural3Fecha.Value = DateTime.Now;
            plural3Primero.Enabled = false;
            plural3Atras.Enabled = false;
            plural3Siguiente.Enabled = false;
            plural3Ultimo.Enabled = false;
            plural3Registrar.Enabled = true;
            plural3Cancelar.Enabled = true;
            plural3Modificar.Enabled = false;
            plural3Buscar.Enabled = false;
            plural3Nuevo.Enabled = false;
            plural3Borrar.Enabled = false;
            plural3Conteo.Text = "Nuevo registro";
        }

        private void plural3Registrar_Click(object sender, EventArgs e)
        {
            if (plural3Nombre.Text == string.Empty)
            {
                MessageBox.Show("Aun no has colocado el nombre del negocio");
                plural3Nombre.Focus();
            }
            else
                if (plural3Direccion.Text == string.Empty)
                {
                    MessageBox.Show("Aun no has colocado la direccion del negocio");
                    plural3Direccion.Focus();
                }
                else
                    if (plural3CantidadL.Text == string.Empty)
                    {
                        MessageBox.Show("Aun no has colocado el monto en letras");
                        plural3CantidadL.Focus();
                    }
                    else
                        if (plural3Cantidad.Text == string.Empty)
                        {
                            MessageBox.Show("Aun no has colocado el monto en numeros");
                            plural3Cantidad.Focus();
                        }
                        else
                            if (plural3Meses.Text == string.Empty)
                            {
                                MessageBox.Show("No has escrito ningun mes aun");
                                plural3Meses.Focus();
                            }
                            else
                                if (plural3Anio.Text == string.Empty)
                                {
                                    MessageBox.Show("Aun no has colocado el año");
                                    plural3Anio.Focus();
                                }
                                else
                                {
                                    Clientes c = new Clientes();
                                    c.nombre = plural3Nombre.Text.ToString();
                                    c.direccion = plural3Direccion.Text.ToString();
                                    c.direccion2 = plural3Direccion2.Text.ToString();
                                    c.ciudad = plural3Ciudad.Text.ToString();
                                    c.tipo = "plural";
                                    c.id = AdminClientes.totalClientes() + 1;
                                    c.fecha = DateTime.Now.ToString();
                                    Plural2 s = new Plural2();
                                    s.idCliente = c.id;
                                    s.id = Convert.ToString(DateTime.Now.ToFileTimeUtc()) + "-" + AdminPlural3.totalPlural3().ToString();
                                    s.fecha = plural3Fecha.DateTime;
                                    s.cantidadL = plural3CantidadL.Text.ToString();
                                    s.cantidad = plural3Cantidad.Text.ToString();
                                    s.meses = plural3Meses.Text.ToString();
                                    s.anio = plural3Anio.Text.ToString();
                                    s.pie = plural3Pie.Text.ToString();
                                    s.asesor = plural3Asesor.Text.ToString();
                                    if (tipoPlural3 == "R")
                                    {
                                        AdminPlural3.registrar(s);
                                        AdminClientes.registrar(c);
                                        MessageBox.Show("Registrado con exito");
                                        bloquearPlural3();
                                        plural3Nuevo.Enabled = true;
                                        plural3Registrar.Enabled = false;
                                        plural3Cancelar.Enabled = false;
                                        plural3Borrar.Enabled = true;
                                        plural3Buscar.Enabled = true;
                                        Datos.datosPlural3 = AdminPlural3.buscaDatosPlural3();
                                        actualizaPlural3();
                                        filaPlural3 = Datos.datosPlural3.Rows.Count - 1;
                                        cargaPlural3(Datos.datosPlural3.Rows[filaPlural3]);
                                        plural3Conteo.Text = Datos.datosPlural3.Rows.Count.ToString() + " de " + Datos.datosPlural3.Rows.Count.ToString();
                                        navegacionPlural3(filaPlural3, filaPlural3);
                                    }
                                    else
                                        if (tipoPlural3 == "M")
                                        {
                                            s.id = Datos.datosPlural3.Rows[filaPlural3]["id"].ToString();
                                            c.id = Convert.ToInt32(Datos.datosPlural3.Rows[filaPlural3]["idCliente"].ToString());
                                            AdminPlural3.actualizar(s);
                                            AdminClientes.actualizar(c);
                                            bloquearPlural3();
                                            MessageBox.Show("Modificado con exito");
                                            plural3Nuevo.Enabled = true;
                                            plural3Registrar.Enabled = false;
                                            plural3Cancelar.Enabled = false;
                                            plural3Modificar.Enabled = true;
                                            plural3Borrar.Enabled = true;
                                            plural3Buscar.Enabled = true;
                                            int actual = filaPlural3;
                                            int fin = Datos.datosPlural3.Rows.Count - 1;
                                            Datos.datosPlural3 = AdminPlural3.buscaDatosPlural3();
                                            cargaPlural3(Datos.datosPlural3.Rows[actual]);
                                            plural3Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosPlural3.Rows.Count.ToString();
                                            navegacionPlural3(actual, fin);
                                        }
                                        else
                                            if (tipoPlural3 == "M2")
                                            {
                                                s.id = Datos.datosPlural3.Rows[0]["id"].ToString();
                                                c.id = Convert.ToInt32(Datos.datosPlural3.Rows[0]["idCliente"].ToString());
                                                AdminPlural3.actualizar(s);
                                                AdminClientes.actualizar(c);
                                                bloquearPlural3();
                                                MessageBox.Show("Modificado con exito");
                                                plural3Nuevo.Enabled = true;
                                                plural3Registrar.Enabled = false;
                                                plural3Cancelar.Enabled = false;
                                                plural3Borrar.Enabled = true;
                                                plural3Buscar.Enabled = true;
                                                plural3Modificar.Enabled = true;
                                                int actual = 0;
                                                int fin = 0;
                                                Datos.datosPlural3 = AdminPlural3.consultaPorId(s.id);
                                                cargaPlural3(Datos.datosPlural3.Rows[actual]);
                                                plural3Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosPlural3.Rows.Count.ToString();
                                                navegacionPlural3(actual, fin);

                                            }
                                }
        }

        private void plural1Registrar_Click(object sender, EventArgs e)
        {
            if (plural1Nombre.Text == string.Empty)
            {
                MessageBox.Show("Aun no has colocado el nombre del negocio");
                plural1Nombre.Focus();
            }
            else
                if (plural1Direccion.Text == string.Empty)
                {
                    MessageBox.Show("Aun no has colocado la direccion del negocio");
                    plural1Direccion.Focus();
                }
                else
                    if (plural1CantidadL.Text == string.Empty)
                    {
                        MessageBox.Show("Aun no has colocado el monto en letras");
                        plural1CantidadL.Focus();
                    }
                    else
                        if (plural1Cantidad.Text == string.Empty)
                        {
                            MessageBox.Show("Aun no has colocado el monto en numeros");
                            plural1Cantidad.Focus();
                        }
                        else
                            if (plural1Meses.Text == string.Empty)
                            {
                                MessageBox.Show("No has escrito ningun mes aun");
                                plural1Meses.Focus();
                            }
                            else
                                if (plural1Anio.Text == string.Empty)
                                {
                                    MessageBox.Show("Aun no has colocado el año");
                                    plural1Anio.Focus();
                                }
                                else
                                {
                                    Clientes c = new Clientes();
                                    c.nombre = plural1Nombre.Text.ToString();
                                    c.direccion = plural1Direccion.Text.ToString();
                                    c.direccion2 = plural1Direccion2.Text.ToString();
                                    c.ciudad = plural1Ciudad.Text.ToString();
                                    c.tipo = "plural";
                                    c.id = AdminClientes.totalClientes() + 1;
                                    c.fecha = DateTime.Now.ToString();
                                    Plural2 s = new Plural2();
                                    s.idCliente = c.id;
                                    s.id = Convert.ToString(DateTime.Now.ToFileTimeUtc()) + "-" + AdminPlural1.totalPlural1().ToString();
                                    s.fecha = plural1Fecha.DateTime;
                                    s.cantidadL = plural1CantidadL.Text.ToString();
                                    s.cantidad = plural1Cantidad.Text.ToString();
                                    s.meses = plural1Meses.Text.ToString();
                                    s.anio = plural1Anio.Text.ToString();
                                    s.pie = plural1Pie.Text.ToString();
                                    s.asesor = plural1Asesor.Text.ToString();
                                    if (tipoPlural1 == "R")
                                    {
                                        AdminPlural1.registrar(s);
                                        AdminClientes.registrar(c);
                                        MessageBox.Show("Registrado con exito");
                                        bloquearPlural1();
                                        plural1Nuevo.Enabled = true;
                                        plural1Registrar.Enabled = false;
                                        plural1Cancelar.Enabled = false;
                                        plural1Borrar.Enabled = true;
                                        plural1Buscar.Enabled = true;
                                        Datos.datosPlural1 = AdminPlural1.buscaDatosPlural1();
                                        actualizaPlural1();
                                        filaPlural1 = Datos.datosPlural1.Rows.Count - 1;
                                        cargaPlural1(Datos.datosPlural1.Rows[filaPlural1]);
                                        plural1Conteo.Text = Datos.datosPlural1.Rows.Count.ToString() + " de " + Datos.datosPlural1.Rows.Count.ToString();
                                        navegacionPlural1(filaPlural1, filaPlural1);
                                    }
                                    else
                                        if (tipoPlural1 == "M")
                                        {
                                            s.id = Datos.datosPlural1.Rows[filaPlural1]["id"].ToString();
                                            c.id = Convert.ToInt32(Datos.datosPlural1.Rows[filaPlural1]["idCliente"].ToString());
                                            AdminPlural1.actualizar(s);
                                            AdminClientes.actualizar(c);
                                            bloquearPlural1();
                                            MessageBox.Show("Modificado con exito");
                                            plural1Nuevo.Enabled = true;
                                            plural1Registrar.Enabled = false;
                                            plural1Cancelar.Enabled = false;
                                            plural1Modificar.Enabled = true;
                                            plural1Borrar.Enabled = true;
                                            plural1Buscar.Enabled = true;
                                            int actual = filaPlural1;
                                            int fin = Datos.datosPlural1.Rows.Count - 1;
                                            Datos.datosPlural1 = AdminPlural1.buscaDatosPlural1();
                                            cargaPlural1(Datos.datosPlural1.Rows[actual]);
                                            plural1Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosPlural1.Rows.Count.ToString();
                                            navegacionPlural1(actual, fin);
                                        }
                                        else
                                            if (tipoPlural1 == "M2")
                                            {
                                                s.id = Datos.datosPlural1.Rows[0]["id"].ToString();
                                                c.id = Convert.ToInt32(Datos.datosPlural1.Rows[0]["idCliente"].ToString());
                                                AdminPlural1.actualizar(s);
                                                AdminClientes.actualizar(c);
                                                bloquearPlural1();
                                                MessageBox.Show("Modificado con exito");
                                                plural1Nuevo.Enabled = true;
                                                plural1Registrar.Enabled = false;
                                                plural1Cancelar.Enabled = false;
                                                plural1Borrar.Enabled = true;
                                                plural1Buscar.Enabled = true;
                                                plural1Modificar.Enabled = true;
                                                int actual = 0;
                                                int fin = 0;
                                                Datos.datosPlural1 = AdminPlural1.consultaPorId(s.id);
                                                cargaPlural1(Datos.datosPlural1.Rows[actual]);
                                                plural1Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosPlural1.Rows.Count.ToString();
                                                navegacionPlural1(actual, fin);

                                            }
                                }
        }

        private void plural3Cancelar_Click(object sender, EventArgs e)
        {
            bloquearPlural3();
            actualizaPlural3();
        }

        private void plural1Cancelar_Click(object sender, EventArgs e)
        {
            bloquearPlural1();
            actualizaPlural1();
        }

        private void ultraTabControl8_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            if (e.Tab.Index == 0)
            {
            }
            else
                if (e.Tab.Index == 1)
                {
                    if (Datos.datosPlural3.Rows.Count > 0)
                    {
                        reportePlural3(Datos.datosPlural3.Rows[filaPlural3]);
                    }
                }
        }

        private void plural3Modificar_Click(object sender, EventArgs e)
        {
            if (busPlural3 == true)
            {
                tipoPlural3 = "M2";
            }
            else
            {
                tipoPlural3 = "M";
            }
            desbloquearPlural3();
            plural3Primero.Enabled = false;
            plural3Atras.Enabled = false;
            plural3Siguiente.Enabled = false;
            plural3Ultimo.Enabled = false;
            plural3Registrar.Enabled = true;
            plural3Cancelar.Enabled = true;
            plural3Modificar.Enabled = false;
            plural3Buscar.Enabled = false;
            plural3Nuevo.Enabled = false;
            plural3Borrar.Enabled = false;
            plural3Conteo.Text = "Modificar registro";
        }

        private void plural1Modificar_Click(object sender, EventArgs e)
        {
            if (busPlural1 == true)
            {
                tipoPlural1 = "M2";
            }
            else
            {
                tipoPlural1 = "M";
            }
            desbloquearPlural1();
            plural1Primero.Enabled = false;
            plural1Atras.Enabled = false;
            plural1Siguiente.Enabled = false;
            plural1Ultimo.Enabled = false;
            plural1Registrar.Enabled = true;
            plural1Cancelar.Enabled = true;
            plural1Modificar.Enabled = false;
            plural1Buscar.Enabled = false;
            plural1Nuevo.Enabled = false;
            plural1Borrar.Enabled = false;
            plural1Conteo.Text = "Modificar registro";
        }

        private void plural1Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDecimales(e, plural1Cantidad.Text);
        }

        private void sing3Anio_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void sing1Anio_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void sing1Ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void sing1Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDecimales(e, sing1Cantidad.Text);
        }

        private void sing3Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDecimales(e, sing3Cantidad.Text);
        }

        private void sing4Actualizar_Click(object sender, EventArgs e)
        {
            Datos.datosSing4 = AdminSing4.buscaDatosSing4();
            actualizarSing4();
        }

        private void sing5Actualizar_Click(object sender, EventArgs e)
        {
            Datos.datosSing5 = AdminSing5.buscaDatosSing5();
            actualizarSing5();   
        }

        private void sing5Cancelar_Click(object sender, EventArgs e)
        {
            bloquearSing5();
            actualizarSing5();
        }

        private void sing4Cancelar_Click(object sender, EventArgs e)
        {
            bloquearSing4();
            actualizarSing4();
        }

        private void sing4Siguiente_Click(object sender, EventArgs e)
        {
            int total = Datos.datosSing4.Rows.Count - 1;
            filaSing4 = filaSing4 + 1;
            navegacionSing4(filaSing4, total);
            cargaSing4(Datos.datosSing4.Rows[filaSing4]);
            sing4Conteo.Text = (filaSing4 + 1).ToString() + " de " + Datos.datosSing4.Rows.Count.ToString();
        }

        private void sing5Siguiente_Click(object sender, EventArgs e)
        {
            int total = Datos.datosSing5.Rows.Count - 1;
            filaSing5 = filaSing5 + 1;
            navegacionSing5(filaSing5, total);
            cargaSing5(Datos.datosSing5.Rows[filaSing5]);
            sing5Conteo.Text = (filaSing5 + 1).ToString() + " de " + Datos.datosSing5.Rows.Count.ToString();
        }

        private void sing5Primero_Click(object sender, EventArgs e)
        {
            filaSing5 = 0;
            navegacionSing5(filaSing5, Datos.datosSing5.Rows.Count - 1);
            cargaSing5(Datos.datosSing5.Rows[filaSing5]);
            sing5Conteo.Text = (filaSing5 + 1).ToString() + " de " + Datos.datosSing5.Rows.Count.ToString();
        }

        private void sing4Primero_Click(object sender, EventArgs e)
        {
            filaSing4 = 0;
            navegacionSing4(filaSing4, Datos.datosSing4.Rows.Count - 1);
            cargaSing4(Datos.datosSing4.Rows[filaSing4]);
            sing4Conteo.Text = (filaSing4 + 1).ToString() + " de " + Datos.datosSing4.Rows.Count.ToString();
        }

        private void sing4Nuevo_Click(object sender, EventArgs e)
        {
            tipoSing4 = "R";
            desbloquearSing4();
            limpiarSing4();
            sing4Fecha.Value = DateTime.Now;
            sing4Primero.Enabled = false;
            sing4Atras.Enabled = false;
            sing4Siguiente.Enabled = false;
            sing4Ultimo.Enabled = false;
            sing4Registrar.Enabled = true;
            sing4Cancelar.Enabled = true;
            sing4Modificar.Enabled = false;
            sing4Buscar.Enabled = false;
            sing4Nuevo.Enabled = false;
            sing4Borrar.Enabled = false;
            sing4Conteo.Text = "Nuevo registro";
        }

        private void sing5Nuevo_Click(object sender, EventArgs e)
        {
            tipoSing5 = "R";
            desbloquearSing5();
            limpiarSing5();
            sing5Fecha.Value = DateTime.Now;
            sing5Primero.Enabled = false;
            sing5Atras.Enabled = false;
            sing5Siguiente.Enabled = false;
            sing5Ultimo.Enabled = false;
            sing5Registrar.Enabled = true;
            sing5Cancelar.Enabled = true;
            sing5Modificar.Enabled = false;
            sing5Buscar.Enabled = false;
            sing5Nuevo.Enabled = false;
            sing5Borrar.Enabled = false;
            sing5Conteo.Text = "Nuevo registro";
        }

        private void sing5Modificar_Click(object sender, EventArgs e)
        {
            if (busSing5 == true)
            {
                tipoSing5 = "M2";
            }
            else
            {
                tipoSing5 = "M";
            }
            desbloquearSing5();
            sing5Primero.Enabled = false;
            sing5Atras.Enabled = false;
            sing5Siguiente.Enabled = false;
            sing5Ultimo.Enabled = false;
            sing5Registrar.Enabled = true;
            sing5Cancelar.Enabled = true;
            sing5Modificar.Enabled = false;
            sing5Buscar.Enabled = false;
            sing5Nuevo.Enabled = false;
            sing5Borrar.Enabled = false;
            sing5Conteo.Text = "Modificar registro";
        }

        private void sing4Modificar_Click(object sender, EventArgs e)
        {
            if (busSing4 == true)
            {
                tipoSing4 = "M2";
            }
            else
            {
                tipoSing4 = "M";
            }
            desbloquearSing4();
            sing4Primero.Enabled = false;
            sing4Atras.Enabled = false;
            sing4Siguiente.Enabled = false;
            sing4Ultimo.Enabled = false;
            sing4Registrar.Enabled = true;
            sing4Cancelar.Enabled = true;
            sing4Modificar.Enabled = false;
            sing4Buscar.Enabled = false;
            sing4Nuevo.Enabled = false;
            sing4Borrar.Enabled = false;
            sing4Conteo.Text = "Modificar registro";
        }

        private void sing4Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer eliminar este registro", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminSing4.eliminar(Datos.datosSing4.Rows[filaSing4]["id"].ToString());
                Datos.datosSing4 = AdminSing4.buscaDatosSing4();
                actualizarSing4();
            }
            else
            {

            }
        }

        private void sing5Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer eliminar este registro", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminSing5.eliminar(Datos.datosSing5.Rows[filaSing5]["id"].ToString());
                Datos.datosSing5 = AdminSing5.buscaDatosSing5();
                actualizarSing5();
            }
            else
            {

            }
        }

        private void sing5Atras_Click(object sender, EventArgs e)
        {
            int total = Datos.datosSing5.Rows.Count - 1;
            filaSing5 = filaSing5 - 1;
            navegacionSing5(filaSing5, total);
            cargaSing5(Datos.datosSing5.Rows[filaSing5]);
            sing5Conteo.Text = (filaSing5 + 1).ToString() + " de " + Datos.datosSing5.Rows.Count.ToString();
        }

        private void sing4Atras_Click(object sender, EventArgs e)
        {
            int total = Datos.datosSing4.Rows.Count - 1;
            filaSing4 = filaSing4 - 1;
            navegacionSing4(filaSing4, total);
            cargaSing4(Datos.datosSing4.Rows[filaSing4]);
            sing4Conteo.Text = (filaSing4 + 1).ToString() + " de " + Datos.datosSing4.Rows.Count.ToString();
        }

        private void sing5Registrar_Click(object sender, EventArgs e)
        {
            if (sing5Encabezado.Text == string.Empty)
            {
                MessageBox.Show("Aun no has elegido el encabezado de la carta");
            }
            else
                if (sing5Nombre.Text == string.Empty)
                {
                    MessageBox.Show("Aun no has colocado el nombre de cliente");
                    sing5Nombre.Focus();
                }
                else
                    if (sing5Direccion.Text == string.Empty)
                    {
                        MessageBox.Show("Aun no has colocado la direccion del cliente");
                        sing5Direccion.Focus();
                    }
                    else
                        if (sing5Saludo.Text == string.Empty)
                        {
                            MessageBox.Show("Aun no has elegido el saludo de la carta");
                        }
                            else
                                if (sing5Cantidad.Text == string.Empty)
                                {
                                    MessageBox.Show("Aun no has colocado el monto en numeros");
                                    sing5Cantidad.Focus();
                                }
                                        else
                                        {
                                            Clientes c = new Clientes();
                                            c.nombre = sing5Nombre.Text.ToString();
                                            c.direccion = sing5Direccion.Text.ToString();
                                            c.direccion2 = sing5Direccion2.Text.ToString();
                                            c.ciudad = sing5Ciudad.Text.ToString();
                                            c.tipo = "singular";
                                            c.id = AdminClientes.totalClientes() + 1;
                                            c.fecha = DateTime.Now.ToString();
                                            AdminClientes.registrar(c);
                                            Sing5 s = new Sing5();
                                            s.idCliente = c.id;
                                            s.id = Convert.ToString(DateTime.Now.ToFileTimeUtc()) + "-" + AdminSing5.totalSing5().ToString();
                                            s.fecha = sing5Fecha.DateTime;
                                            s.encabezado = sing5Encabezado.Text.ToString();
                                            s.saludo = sing5Saludo.Text.ToString();
                                            s.cantidad = sing5Cantidad.Text.ToString();
                                            s.pie = sing5Pie.Text.ToString();
                                            s.asesor = sing5Asesor.Text.ToString();
                                            if (tipoSing5 == "R")
                                            {
                                                AdminSing5.registrar(s);
                                                MessageBox.Show("Registrado con exito");
                                                bloquearSing5();
                                                sing5Nuevo.Enabled = true;
                                                sing5Registrar.Enabled = false;
                                                sing5Cancelar.Enabled = false;
                                                sing5Borrar.Enabled = true;
                                                sing5Buscar.Enabled = true;
                                                Datos.datosSing5 = AdminSing5.buscaDatosSing5();
                                                actualizarSing5();
                                                filaSing5 = Datos.datosSing5.Rows.Count - 1;
                                                cargaSing5(Datos.datosSing5.Rows[filaSing5]);
                                                sing5Conteo.Text = Datos.datosSing5.Rows.Count.ToString() + " de " + Datos.datosSing5.Rows.Count.ToString();
                                                navegacionSing5(filaSing5, filaSing5);
                                            }
                                            else
                                                if (tipoSing5 == "M")
                                                {
                                                    s.id = Datos.datosSing5.Rows[filaSing5]["id"].ToString();
                                                    c.id = Convert.ToInt32(Datos.datosSing5.Rows[filaSing5]["idCliente"].ToString());
                                                    AdminSing5.actualizar(s);
                                                    AdminClientes.actualizar(c);
                                                    bloquearSing5();
                                                    MessageBox.Show("Modificado con exito");
                                                    sing5Nuevo.Enabled = true;
                                                    sing5Registrar.Enabled = false;
                                                    sing5Cancelar.Enabled = false;
                                                    sing5Borrar.Enabled = true;
                                                    sing5Buscar.Enabled = true;
                                                    sing5Modificar.Enabled = true;
                                                    int actual = filaSing5;
                                                    int fin = Datos.datosSing5.Rows.Count - 1;
                                                    Datos.datosSing5 = AdminSing5.buscaDatosSing5();
                                                    cargaSing5(Datos.datosSing5.Rows[actual]);
                                                    sing5Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosSing5.Rows.Count.ToString();
                                                    navegacionSing5(actual, fin);
                                                }
                                                else
                                                    if (tipoSing5 == "M2")
                                                    {
                                                        s.id = Datos.datosSing5.Rows[0]["id"].ToString();
                                                        c.id = Convert.ToInt32(Datos.datosSing5.Rows[0]["idCliente"].ToString());
                                                        AdminSing5.actualizar(s);
                                                        AdminClientes.actualizar(c);
                                                        bloquearSing5();
                                                        MessageBox.Show("Modificado con exito");
                                                        sing5Nuevo.Enabled = true;
                                                        sing5Registrar.Enabled = false;
                                                        sing5Cancelar.Enabled = false;
                                                        sing5Borrar.Enabled = true;
                                                        sing5Buscar.Enabled = true;
                                                        sing5Modificar.Enabled = true;
                                                        int actual = 0;
                                                        int fin = 0;
                                                        Datos.datosSing5 = AdminSing5.consultaPorId(s.id);
                                                        cargaSing5(Datos.datosSing5.Rows[actual]);
                                                        sing5Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosSing5.Rows.Count.ToString();
                                                        navegacionSing5(actual, fin);

                                                    }
                                        }

        }

        private void sing4Registrar_Click(object sender, EventArgs e)
        {
            if (sing4Encabezado.Text == string.Empty)
            {
                MessageBox.Show("Aun no has elegido el encabezado de la carta");
            }
            else
                if (sing4Nombre.Text == string.Empty)
                {
                    MessageBox.Show("Aun no has colocado el nombre de cliente");
                    sing4Nombre.Focus();
                }
                else
                    if (sing4Direccion.Text == string.Empty)
                    {
                        MessageBox.Show("Aun no has colocado la direccion del cliente");
                        sing4Direccion.Focus();
                    }
                    else
                        if (sing4Saludo.Text == string.Empty)
                        {
                            MessageBox.Show("Aun no has elegido el saludo de la carta");
                        }
                            else
                            {
                                Clientes c = new Clientes();
                                c.nombre = sing4Nombre.Text.ToString();
                                c.direccion = sing4Direccion.Text.ToString();
                                c.direccion2 = sing4Direccion2.Text.ToString();
                                c.ciudad = sing4Ciudad.Text.ToString();
                                c.tipo = "singular";
                                c.id = AdminClientes.totalClientes() + 1;
                                c.fecha = DateTime.Now.ToString();
                                AdminClientes.registrar(c);
                                Sing4 s = new Sing4();
                                s.idCliente = c.id;
                                s.id = Convert.ToString(DateTime.Now.ToFileTimeUtc()) + "-" + AdminSing4.totalSing4().ToString();
                                s.fecha = sing4Fecha.DateTime;
                                s.encabezado = sing4Encabezado.Text.ToString();
                                s.saludo = sing4Saludo.Text.ToString();
                                s.pie = sing4Pie.Text.ToString();
                                s.asesor = sing4Asesor.Text.ToString();
                                if (tipoSing4 == "R")
                                {
                                    AdminSing4.registrar(s);
                                    MessageBox.Show("Registrado con exito");
                                    bloquearSing4();
                                    sing4Nuevo.Enabled = true;
                                    sing4Registrar.Enabled = false;
                                    sing4Cancelar.Enabled = false;
                                    sing4Borrar.Enabled = true;
                                    sing4Buscar.Enabled = true;
                                    Datos.datosSing4 = AdminSing4.buscaDatosSing4();
                                    actualizarSing4();
                                    filaSing4 = Datos.datosSing4.Rows.Count - 1;
                                    cargaSing4(Datos.datosSing4.Rows[filaSing4]);
                                    sing4Conteo.Text = Datos.datosSing4.Rows.Count.ToString() + " de " + Datos.datosSing4.Rows.Count.ToString();
                                    navegacionSing4(filaSing4, filaSing4);
                                }
                                else
                                    if (tipoSing4 == "M")
                                    {
                                        s.id = Datos.datosSing4.Rows[filaSing4]["id"].ToString();
                                        c.id = Convert.ToInt32(Datos.datosSing4.Rows[filaSing4]["idCliente"].ToString());
                                        AdminSing4.actualizar(s);
                                        AdminClientes.actualizar(c);
                                        bloquearSing4();
                                        MessageBox.Show("Modificado con exito");
                                        sing4Nuevo.Enabled = true;
                                        sing4Registrar.Enabled = false;
                                        sing4Cancelar.Enabled = false;
                                        sing4Borrar.Enabled = true;
                                        sing4Buscar.Enabled = true;
                                        sing4Modificar.Enabled = true;
                                        int actual = filaSing4;
                                        int fin = Datos.datosSing4.Rows.Count - 1;
                                        Datos.datosSing4 = AdminSing4.buscaDatosSing4();
                                        cargaSing4(Datos.datosSing4.Rows[actual]);
                                        sing4Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosSing4.Rows.Count.ToString();
                                        navegacionSing4(actual, fin);
                                    }
                                    else
                                        if (tipoSing4 == "M2")
                                        {
                                            s.id = Datos.datosSing4.Rows[0]["id"].ToString();
                                            c.id = Convert.ToInt32(Datos.datosSing4.Rows[0]["idCliente"].ToString());
                                            AdminSing4.actualizar(s);
                                            AdminClientes.actualizar(c);
                                            bloquearSing4();
                                            MessageBox.Show("Modificado con exito");
                                            sing4Nuevo.Enabled = true;
                                            sing4Registrar.Enabled = false;
                                            sing4Cancelar.Enabled = false;
                                            sing4Borrar.Enabled = true;
                                            sing4Buscar.Enabled = true;
                                            sing4Modificar.Enabled = true;
                                            int actual = 0;
                                            int fin = 0;
                                            Datos.datosSing4 = AdminSing4.consultaPorId(s.id);
                                            cargaSing4(Datos.datosSing4.Rows[actual]);
                                            sing4Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosSing4.Rows.Count.ToString();
                                            navegacionSing4(actual, fin);

                                        }
                            }
        }

        private void ultraTabControl4_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            if (e.Tab.Index == 0)
            {
            }
            else
                if (e.Tab.Index == 1)
                {
                    if (Datos.datosSing4.Rows.Count > 0)
                    {
                        reporteSing4(Datos.datosSing4.Rows[filaSing4]);
                    }
                }
        }

        private void ultraTabControl5_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            if (e.Tab.Index == 0)
            {
            }
            else
                if (e.Tab.Index == 1)
                {
                    if (Datos.datosSing5.Rows.Count > 0)
                    {
                        reporteSing5(Datos.datosSing5.Rows[filaSing5]);
                    }
                }
        }

        private void ultraTabControl9_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            if (e.Tab.Index == 0)
            {
            }
            else
                if (e.Tab.Index == 1)
                {
                    if (Datos.datosPlural4.Rows.Count > 0)
                    {
                        reportePlural4(Datos.datosPlural4.Rows[filaPlural4]);
                    }
                }
        }

        private void tabPlural_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
 
        }

        private void plural5Actualizar_Click(object sender, EventArgs e)
        {
            Datos.datosPlural5 = AdminPlural5.buscaDatosPlural5();
            actualizaPlural5();
        }

        private void plural4Actualizar_Click(object sender, EventArgs e)
        {
            Datos.datosPlural4 = AdminPlural4.buscaDatosPlural4();
            actualizaPlural4();
        }

        private void plural4Ultimo_Click(object sender, EventArgs e)
        {
            filaPlural4 = Datos.datosPlural4.Rows.Count - 1;
            cargaPlural4(Datos.datosSing4.Rows[filaPlural4]);
            navegacionPlural4(filaPlural4, filaPlural4);
            plural4Conteo.Text = Datos.datosPlural4.Rows.Count.ToString() + " de " + Datos.datosPlural4.Rows.Count.ToString();
        }

        private void plural5Ultimo_Click(object sender, EventArgs e)
        {
            filaPlural5 = Datos.datosPlural5.Rows.Count - 1;
            cargaPlural5(Datos.datosSing5.Rows[filaPlural5]);
            navegacionPlural5(filaPlural5, filaPlural5);
            plural5Conteo.Text = Datos.datosPlural5.Rows.Count.ToString() + " de " + Datos.datosPlural5.Rows.Count.ToString();
        }

        private void plural5Siguiente_Click(object sender, EventArgs e)
        {
            int total = Datos.datosPlural5.Rows.Count - 1;
            filaPlural5 = filaPlural5 + 1;
            navegacionPlural5(filaPlural5, total);
            cargaPlural5(Datos.datosPlural5.Rows[filaPlural5]);
            plural5Conteo.Text = (filaPlural5 + 1).ToString() + " de " + Datos.datosPlural5.Rows.Count.ToString();
        }

        private void plural4Siguiente_Click(object sender, EventArgs e)
        {
            int total = Datos.datosPlural4.Rows.Count - 1;
            filaPlural4 = filaPlural4 + 1;
            navegacionPlural4(filaPlural4, total);
            cargaPlural4(Datos.datosPlural4.Rows[filaPlural4]);
            plural4Conteo.Text = (filaPlural4 + 1).ToString() + " de " + Datos.datosPlural4.Rows.Count.ToString();
        }

        private void plural4Nuevo_Click(object sender, EventArgs e)
        {
            tipoPlural4 = "R";
            desbloquearPlural4();
            limpiarPlural4();
            plural4Fecha.Value = DateTime.Now;
            plural4Primero.Enabled = false;
            plural4Atras.Enabled = false;
            plural4Siguiente.Enabled = false;
            plural4Ultimo.Enabled = false;
            plural4Registrar.Enabled = true;
            plural4Cancelar.Enabled = true;
            plural4Modificar.Enabled = false;
            plural4Buscar.Enabled = false;
            plural4Nuevo.Enabled = false;
            plural4Borrar.Enabled = false;
            plural4Conteo.Text = "Nuevo registro";
        }

        private void plural5Nuevo_Click(object sender, EventArgs e)
        {
            tipoPlural5 = "R";
            desbloquearPlural5();
            limpiarPlural5();
            plural5Fecha.Value = DateTime.Now;
            plural5Primero.Enabled = false;
            plural5Atras.Enabled = false;
            plural5Siguiente.Enabled = false;
            plural5Ultimo.Enabled = false;
            plural5Registrar.Enabled = true;
            plural5Cancelar.Enabled = true;
            plural5Modificar.Enabled = false;
            plural5Buscar.Enabled = false;
            plural5Nuevo.Enabled = false;
            plural5Borrar.Enabled = false;
            plural5Conteo.Text = "Nuevo registro";
        }

        private void plural5Modificar_Click(object sender, EventArgs e)
        {
            if (busPlural5 == true)
            {
                tipoPlural5 = "M2";
            }
            else
            {
                tipoPlural5 = "M";
            }
            desbloquearPlural5();
            plural5Primero.Enabled = false;
            plural5Atras.Enabled = false;
            plural5Siguiente.Enabled = false;
            plural5Ultimo.Enabled = false;
            plural5Registrar.Enabled = true;
            plural5Cancelar.Enabled = true;
            plural5Modificar.Enabled = false;
            plural5Buscar.Enabled = false;
            plural5Nuevo.Enabled = false;
            plural5Borrar.Enabled = false;
            plural5Conteo.Text = "Modificar registro";
        }

        private void plural4Modificar_Click(object sender, EventArgs e)
        {
            if (busPlural4 == true)
            {
                tipoPlural4 = "M2";
            }
            else
            {
                tipoPlural4 = "M";
            }
            desbloquearPlural4();
            plural4Primero.Enabled = false;
            plural4Atras.Enabled = false;
            plural4Siguiente.Enabled = false;
            plural4Ultimo.Enabled = false;
            plural4Registrar.Enabled = true;
            plural4Cancelar.Enabled = true;
            plural4Modificar.Enabled = false;
            plural4Buscar.Enabled = false;
            plural4Nuevo.Enabled = false;
            plural4Borrar.Enabled = false;
            plural4Conteo.Text = "Modificar registro";
        }

        private void plural4Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer eliminar este registro", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminPlural4.eliminar(Datos.datosPlural4.Rows[filaPlural4]["id"].ToString());
                Datos.datosPlural4 = AdminPlural4.buscaDatosPlural4();
                actualizaPlural4();
            }
            else
            {

            }
        }

        private void plural5Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer eliminar este registro", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdminPlural5.eliminar(Datos.datosPlural5.Rows[filaPlural5]["id"].ToString());
                Datos.datosPlural5 = AdminPlural5.buscaDatosPlural5();
                actualizaPlural5();
            }
            else
            {

            }
        }

        private void plural5Cancelar_Click(object sender, EventArgs e)
        {
            bloquearPlural5();
            actualizaPlural5();
        }

        private void plural4Cancelar_Click(object sender, EventArgs e)
        {
            bloquearPlural4();
            actualizaPlural4();
        }

        private void plural4Atras_Click(object sender, EventArgs e)
        {
            int total = Datos.datosPlural4.Rows.Count - 1;
            filaPlural4 = filaPlural4 - 1;
            navegacionPlural4(filaPlural4, total);
            cargaPlural4(Datos.datosPlural4.Rows[filaPlural2]);
            plural4Conteo.Text = (filaPlural4 + 1).ToString() + " de " + Datos.datosPlural4.Rows.Count.ToString();
        }

        private void plural5Atras_Click(object sender, EventArgs e)
        {
            int total = Datos.datosPlural5.Rows.Count - 1;
            filaPlural5 = filaPlural5 - 1;
            navegacionPlural5(filaPlural5, total);
            cargaPlural5(Datos.datosPlural5.Rows[filaPlural2]);
            plural5Conteo.Text = (filaPlural5 + 1).ToString() + " de " + Datos.datosPlural5.Rows.Count.ToString();
        }

        private void plural4Primero_Click(object sender, EventArgs e)
        {
            filaPlural4 = 0;
            navegacionPlural4(filaPlural4, Datos.datosPlural4.Rows.Count - 1);
            cargaPlural4(Datos.datosSing2.Rows[filaPlural4]);
            plural4Conteo.Text = (filaPlural4 + 1).ToString() + " de " + Datos.datosPlural4.Rows.Count.ToString();
        }

        private void plural5Primero_Click(object sender, EventArgs e)
        {
            filaPlural5 = 0;
            navegacionPlural5(filaPlural5, Datos.datosPlural5.Rows.Count - 1);
            cargaPlural5(Datos.datosSing2.Rows[filaPlural5]);
            plural5Conteo.Text = (filaPlural5 + 1).ToString() + " de " + Datos.datosPlural5.Rows.Count.ToString();
        }

        private void plural4Registrar_Click(object sender, EventArgs e)
        {
            if (plural4Nombre.Text == string.Empty)
            {
                MessageBox.Show("Aun no has colocado el nombre del negocio");
                plural4Nombre.Focus();
            }
            else
                if (plural4Direccion.Text == string.Empty)
                {
                    MessageBox.Show("Aun no has colocado la direccion del negocio");
                    plural4Direccion.Focus();
                }
                                else
                                {
                                    Clientes c = new Clientes();
                                    c.nombre = plural4Nombre.Text.ToString();
                                    c.direccion = plural4Direccion.Text.ToString();
                                    c.direccion2 = plural4Direccion2.Text.ToString();
                                    c.ciudad = plural4Ciudad.Text.ToString();
                                    c.tipo = "plural";
                                    c.id = AdminClientes.totalClientes() + 1;
                                    c.fecha = DateTime.Now.ToString();
                                    Plural4 s = new Plural4();
                                    s.idCliente = c.id;
                                    s.id = Convert.ToString(DateTime.Now.ToFileTimeUtc()) + "-" + AdminPlural4.totalPlural4().ToString();
                                    s.fecha = plural4Fecha.DateTime;
                                    s.pie = plural4Pie.Text.ToString();
                                    s.asesor = plural4Asesor.Text.ToString();
                                    if (tipoPlural4 == "R")
                                    {
                                        AdminPlural4.registrar(s);
                                        AdminClientes.registrar(c);
                                        MessageBox.Show("Registrado con exito");
                                        bloquearPlural4();
                                        plural4Nuevo.Enabled = true;
                                        plural4Registrar.Enabled = false;
                                        plural4Cancelar.Enabled = false;
                                        plural4Borrar.Enabled = true;
                                        plural4Buscar.Enabled = true;
                                        Datos.datosPlural4 = AdminPlural4.buscaDatosPlural4();
                                        actualizaPlural4();
                                        filaPlural4 = Datos.datosPlural4.Rows.Count - 1;
                                        cargaPlural4(Datos.datosPlural4.Rows[filaPlural4]);
                                        plural4Conteo.Text = Datos.datosPlural4.Rows.Count.ToString() + " de " + Datos.datosPlural4.Rows.Count.ToString();
                                        navegacionPlural4(filaPlural4, filaPlural4);
                                    }
                                    else
                                        if (tipoPlural4 == "M")
                                        {
                                            s.id = Datos.datosPlural4.Rows[filaPlural4]["id"].ToString();
                                            c.id = Convert.ToInt32(Datos.datosPlural4.Rows[filaPlural4]["idCliente"].ToString());
                                            AdminPlural4.actualizar(s);
                                            AdminClientes.actualizar(c);
                                            bloquearPlural4();
                                            MessageBox.Show("Modificado con exito");
                                            plural4Nuevo.Enabled = true;
                                            plural4Registrar.Enabled = false;
                                            plural4Cancelar.Enabled = false;
                                            plural4Modificar.Enabled = true;
                                            plural4Borrar.Enabled = true;
                                            plural4Buscar.Enabled = true;
                                            int actual = filaPlural4;
                                            int fin = Datos.datosPlural4.Rows.Count - 1;
                                            Datos.datosPlural4 = AdminPlural4.buscaDatosPlural4();
                                            cargaPlural4(Datos.datosPlural4.Rows[actual]);
                                            plural4Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosPlural4.Rows.Count.ToString();
                                            navegacionPlural4(actual, fin);
                                        }
                                        else
                                            if (tipoPlural4 == "M2")
                                            {
                                                s.id = Datos.datosPlural4.Rows[0]["id"].ToString();
                                                c.id = Convert.ToInt32(Datos.datosPlural4.Rows[0]["idCliente"].ToString());
                                                AdminPlural4.actualizar(s);
                                                AdminClientes.actualizar(c);
                                                bloquearPlural4();
                                                MessageBox.Show("Modificado con exito");
                                                plural4Nuevo.Enabled = true;
                                                plural4Registrar.Enabled = false;
                                                plural4Cancelar.Enabled = false;
                                                plural4Borrar.Enabled = true;
                                                plural4Buscar.Enabled = true;
                                                plural4Modificar.Enabled = true;
                                                int actual = 0;
                                                int fin = 0;
                                                Datos.datosPlural4 = AdminPlural4.consultaPorId(s.id);
                                                cargaPlural4(Datos.datosPlural4.Rows[actual]);
                                                plural4Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosPlural4.Rows.Count.ToString();
                                                navegacionPlural4(actual, fin);

                                            }
                                }
        }

        private void plural5Registrar_Click(object sender, EventArgs e)
        {
            if (plural5Nombre.Text == string.Empty)
            {
                MessageBox.Show("Aun no has colocado el nombre del negocio");
                plural5Nombre.Focus();
            }
            else
                if (plural5Direccion.Text == string.Empty)
                {
                    MessageBox.Show("Aun no has colocado la direccion del negocio");
                    plural5Direccion.Focus();
                }
                else
                        if (plural5Cantidad.Text == string.Empty)
                        {
                            MessageBox.Show("Aun no has colocado el monto en numeros");
                            plural5Cantidad.Focus();
                        }
                                else
                                {
                                    Clientes c = new Clientes();
                                    c.nombre = plural5Nombre.Text.ToString();
                                    c.direccion = plural5Direccion.Text.ToString();
                                    c.direccion2 = plural5Direccion2.Text.ToString();
                                    c.ciudad = plural5Ciudad.Text.ToString();
                                    c.tipo = "plural";
                                    c.id = AdminClientes.totalClientes() + 1;
                                    c.fecha = DateTime.Now.ToString();
                                    Plural5 s = new Plural5();
                                    s.idCliente = c.id;
                                    s.id = Convert.ToString(DateTime.Now.ToFileTimeUtc()) + "-" + AdminPlural5.totalPlural5().ToString();
                                    s.fecha = plural5Fecha.DateTime;
                                    s.cantidad = plural5Cantidad.Text.ToString();
                                    s.pie = plural5Pie.Text.ToString();
                                    s.asesor = plural5Asesor.Text.ToString();
                                    if (tipoPlural5 == "R")
                                    {
                                        AdminPlural5.registrar(s);
                                        AdminClientes.registrar(c);
                                        MessageBox.Show("Registrado con exito");
                                        bloquearPlural5();
                                        plural5Nuevo.Enabled = true;
                                        plural5Registrar.Enabled = false;
                                        plural5Cancelar.Enabled = false;
                                        plural5Borrar.Enabled = true;
                                        plural5Buscar.Enabled = true;
                                        Datos.datosPlural5 = AdminPlural5.buscaDatosPlural5();
                                        actualizaPlural5();
                                        filaPlural5 = Datos.datosPlural5.Rows.Count - 1;
                                        cargaPlural5(Datos.datosPlural5.Rows[filaPlural5]);
                                        plural5Conteo.Text = Datos.datosPlural5.Rows.Count.ToString() + " de " + Datos.datosPlural5.Rows.Count.ToString();
                                        navegacionPlural5(filaPlural5, filaPlural5);
                                    }
                                    else
                                        if (tipoPlural5 == "M")
                                        {
                                            s.id = Datos.datosPlural5.Rows[filaPlural5]["id"].ToString();
                                            c.id = Convert.ToInt32(Datos.datosPlural5.Rows[filaPlural5]["idCliente"].ToString());
                                            AdminPlural5.actualizar(s);
                                            AdminClientes.actualizar(c);
                                            bloquearPlural5();
                                            MessageBox.Show("Modificado con exito");
                                            plural5Nuevo.Enabled = true;
                                            plural5Registrar.Enabled = false;
                                            plural5Cancelar.Enabled = false;
                                            plural5Modificar.Enabled = true;
                                            plural5Borrar.Enabled = true;
                                            plural5Buscar.Enabled = true;
                                            int actual = filaPlural5;
                                            int fin = Datos.datosPlural5.Rows.Count - 1;
                                            Datos.datosPlural5 = AdminPlural5.buscaDatosPlural5();
                                            cargaPlural5(Datos.datosPlural5.Rows[actual]);
                                            plural5Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosPlural5.Rows.Count.ToString();
                                            navegacionPlural5(actual, fin);
                                        }
                                        else
                                            if (tipoPlural5 == "M2")
                                            {
                                                s.id = Datos.datosPlural5.Rows[0]["id"].ToString();
                                                c.id = Convert.ToInt32(Datos.datosPlural5.Rows[0]["idCliente"].ToString());
                                                AdminPlural5.actualizar(s);
                                                AdminClientes.actualizar(c);
                                                bloquearPlural5();
                                                MessageBox.Show("Modificado con exito");
                                                plural5Nuevo.Enabled = true;
                                                plural5Registrar.Enabled = false;
                                                plural5Cancelar.Enabled = false;
                                                plural5Borrar.Enabled = true;
                                                plural5Buscar.Enabled = true;
                                                plural5Modificar.Enabled = true;
                                                int actual = 0;
                                                int fin = 0;
                                                Datos.datosPlural5 = AdminPlural5.consultaPorId(s.id);
                                                cargaPlural5(Datos.datosPlural5.Rows[actual]);
                                                plural5Conteo.Text = (actual + 1).ToString() + " de " + Datos.datosPlural5.Rows.Count.ToString();
                                                navegacionPlural5(actual, fin);

                                            }
                                }
        }

        private void ultraTabControl10_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            if (e.Tab.Index == 0)
            {
            }
            else
                if (e.Tab.Index == 1)
                {
                    if (Datos.datosPlural5.Rows.Count > 0)
                    {
                        reportePlural5(Datos.datosPlural5.Rows[filaPlural5]);
                    }
                }
        }

        private void plural5Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDecimales(e, plural5Cantidad.Text);
        }

        private void sing1Buscar_Click(object sender, EventArgs e)
        {
            if (sing1Nuevo.Enabled == true)
            {
                frmBuscar.mandante = "sing1";
                frmBuscar b = new frmBuscar();
                b.ShowDialog();
                if (Datos.res == true)
                {
                    busSing1 = true;
                    Datos.datosSing1.Clear();
                    Datos.datosSing1 = AdminSing1.consultaPorId(Datos.bSing.Rows[Datos.fila]["id"].ToString());
                    actualizarSing1();
                    cargaSing1(Datos.datosSing1.Rows[0]);
                }
                else
                {
                    busSing1 = false;
                }
            }
        }

        private void btnSing2Buscar_Click(object sender, EventArgs e)
        {
            if (btnSing2Nuevo.Enabled == true)
            {
                frmBuscar.mandante = "sing2";
                frmBuscar b = new frmBuscar();
                b.ShowDialog();
                if (Datos.res == true)
                {
                    busSing2 = true;
                    Datos.datosSing2.Clear();
                    Datos.datosSing2 = AdminSing2.consultaPorId(Datos.bSing.Rows[Datos.fila]["id"].ToString());
                    actualizarSing2();
                    cargaSing2(Datos.datosSing2.Rows[0]);
                }
                else {
                    busSing2 = false;
                }
            }
        }

        private void sing3Buscar_Click(object sender, EventArgs e)
        {
            if (sing3Nuevo.Enabled == true)
            {
                frmBuscar.mandante = "sing3";
                frmBuscar b = new frmBuscar();
                b.ShowDialog();
                if (Datos.res == true)
                {
                    busSing3 = true;
                    Datos.datosSing3.Clear();
                    Datos.datosSing3 = AdminSing3.consultaPorId(Datos.bSing.Rows[Datos.fila]["id"].ToString());
                    actualizarSing3();
                    cargaSing3(Datos.datosSing3.Rows[0]);
                }
                else
                {
                    busSing3 = false;
                }
            }
        }

        private void sing4Buscar_Click(object sender, EventArgs e)
        {
            if (sing4Nuevo.Enabled == true)
            {
                frmBuscar.mandante = "sing4";
                frmBuscar b = new frmBuscar();
                b.ShowDialog();
                if (Datos.res == true)
                {
                    busSing4 = true;
                    Datos.datosSing4.Clear();
                    Datos.datosSing4 = AdminSing4.consultaPorId(Datos.bSing.Rows[Datos.fila]["id"].ToString());
                    actualizarSing4();
                    cargaSing4(Datos.datosSing4.Rows[0]);
                }
                else
                {
                    busSing4 = false;
                }
            }
        }

        private void sing5Buscar_Click(object sender, EventArgs e)
        {
            if (sing5Nuevo.Enabled == true)
            {
                frmBuscar.mandante = "sing5";
                frmBuscar b = new frmBuscar();
                b.ShowDialog();
                if (Datos.res == true)
                {
                    busSing5 = true;
                    Datos.datosSing5.Clear();
                    Datos.datosSing5 = AdminSing5.consultaPorId(Datos.bSing.Rows[Datos.fila]["id"].ToString());
                    actualizarSing5();
                    cargaSing5(Datos.datosSing5.Rows[0]);
                }
                else
                {
                    busSing5 = false;
                }
            }
        }

        private void plural1Buscar_Click(object sender, EventArgs e)
        {
            if (plural1Nuevo.Enabled == true)
            {
                frmBuscar.mandante = "plural1";
                frmBuscar b = new frmBuscar();
                b.ShowDialog();
                if (Datos.res == true)
                {
                    busPlural1 = true;
                    Datos.datosPlural1.Clear();
                    Datos.datosPlural1 = AdminPlural1.consultaPorId(Datos.bSing.Rows[Datos.fila]["id"].ToString());
                    actualizaPlural1();
                    cargaPlural1(Datos.datosPlural1.Rows[0]);
                }
                else
                {
                    busPlural1 = false;
                }
            }
        }

        private void plural2Buscar_Click(object sender, EventArgs e)
        {
            if (plural2Nuevo.Enabled == true)
            {
                frmBuscar.mandante = "plural2";
                frmBuscar b = new frmBuscar();
                b.ShowDialog();
                if (Datos.res == true)
                {
                    busPlural2 = true;
                    Datos.datosPlural2.Clear();
                    Datos.datosPlural2 = AdminPlural2.consultaPorId(Datos.bSing.Rows[Datos.fila]["id"].ToString());
                    actualizaPlural2();
                    cargaPlural2(Datos.datosPlural2.Rows[0]);
                }
                else
                {
                    busPlural2 = false;
                }
            }
        }

        private void plural3Buscar_Click(object sender, EventArgs e)
        {
            if (plural3Nuevo.Enabled == true)
            {
                frmBuscar.mandante = "plural3";
                frmBuscar b = new frmBuscar();
                b.ShowDialog();
                if (Datos.res == true)
                {
                    busPlural3 = true;
                    Datos.datosPlural3.Clear();
                    Datos.datosPlural3 = AdminPlural3.consultaPorId(Datos.bSing.Rows[Datos.fila]["id"].ToString());
                    actualizaPlural3();
                    cargaPlural3(Datos.datosPlural3.Rows[0]);
                }
                else
                {
                    busPlural3 = false;
                }
            }
        }

        private void plural4Buscar_Click(object sender, EventArgs e)
        {
            if (plural4Nuevo.Enabled == true)
            {
                frmBuscar.mandante = "plural4";
                frmBuscar b = new frmBuscar();
                b.ShowDialog();
                if (Datos.res == true)
                {
                    busPlural4 = true;
                    Datos.datosPlural4.Clear();
                    Datos.datosPlural4 = AdminPlural4.consultaPorId(Datos.bSing.Rows[Datos.fila]["id"].ToString());
                    actualizaPlural4();
                    cargaPlural4(Datos.datosPlural4.Rows[0]);
                }
                else
                {
                    busPlural4 = false;
                }
            }
        }

        private void plural5Buscar_Click(object sender, EventArgs e)
        {
            if (plural5Nuevo.Enabled == true)
            {
                frmBuscar.mandante = "plural5";
                frmBuscar b = new frmBuscar();
                b.ShowDialog();
                if (Datos.res == true)
                {
                    busPlural5 = true;
                    Datos.datosPlural5.Clear();
                    Datos.datosPlural5 = AdminPlural5.consultaPorId(Datos.bSing.Rows[Datos.fila]["id"].ToString());
                    actualizaPlural5();
                    cargaPlural5(Datos.datosPlural5.Rows[0]);
                }
                else
                {
                    busPlural5 = false;
                }
            }
        }

        private void sing1Ultimo_Click(object sender, EventArgs e)
        {
            filaSing1 = Datos.datosSing1.Rows.Count - 1;
            cargaSing1(Datos.datosSing1.Rows[filaSing1]);
            navegacionSing1(filaSing1, filaSing1);
            sing1Conteo.Text = Datos.datosSing1.Rows.Count.ToString() + " de " + Datos.datosSing1.Rows.Count.ToString();
        }

        private void sing3Ultimo_Click(object sender, EventArgs e)
        {
            filaSing3 = Datos.datosSing3.Rows.Count - 1;
            cargaSing3(Datos.datosSing3.Rows[filaSing3]);
            navegacionSing3(filaSing3, filaSing3);
            sing3Conteo.Text = Datos.datosSing3.Rows.Count.ToString() + " de " + Datos.datosSing3.Rows.Count.ToString();
        }

        private void sing4Ultimo_Click(object sender, EventArgs e)
        {
            filaSing4 = Datos.datosSing4.Rows.Count - 1;
            cargaSing4(Datos.datosSing4.Rows[filaSing4]);
            navegacionSing4(filaSing4, filaSing4);
            sing4Conteo.Text = Datos.datosSing4.Rows.Count.ToString() + " de " + Datos.datosSing4.Rows.Count.ToString();
        }

        private void sing5Ultimo_Click(object sender, EventArgs e)
        {
            filaSing5 = Datos.datosSing5.Rows.Count - 1;
            cargaSing5(Datos.datosSing5.Rows[filaSing5]);
            navegacionSing5(filaSing5, filaSing5);
            sing5Conteo.Text = Datos.datosSing5.Rows.Count.ToString() + " de " + Datos.datosSing5.Rows.Count.ToString();
        }

        private void sing5Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDecimales(e, sing5Cantidad.Text);
        }
    }
}
