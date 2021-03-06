﻿using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using InventoryAssistant.UI;
using InventoryAssistant.UI.Consultas;
using InventoryAssistant.UI.Otras;
using InventoryAssistant.UI.Registros;
using System;
using System.Windows.Forms;

namespace InventoryAssistant
{
    public partial class MainForm : Form
    {

        RepositorioBase<Usuarios> RepositorioUsuario = new RepositorioBase<Usuarios>();
        string Nombre = string.Empty;
        int Nivel;

        public MainForm(string nombre)
        {
            try
            {
                this.Nombre = nombre;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MainForm_Load(object sender, EventArgs e) //Funcion encargada de tomar los datos del usuario que esta logueado.
        {
            try
            {
                if(Nombre == "Administrador")
                    Nivel = 0;

                else
                {
                    Nombre = RepositorioUsuario.ReturnUsuario().Nombres;
                    Nivel = RepositorioUsuario.ReturnUsuario().NivelDeUsuario;
                }
                
                MyTimer.Enabled = true;
                NombreUsuarioToolStripStatusLabel.Text = Nombre;

                switch (Nivel)
                {
                    case 0:
                        {
                            NivelDeUsuarioToolStripStatusLabel.Text = "Administrador  ";
                            break;
                        }
                    case 1:
                        {
                            NivelDeUsuarioToolStripStatusLabel.Text = "Supervisor   ";
                            break;
                        }
                    default:
                        {
                            NivelDeUsuarioToolStripStatusLabel.Text = "Usuario   ";
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void NoTienePermiso() //Ventana para negar el acceso a usuarios sin permiso
        {
            try
            {
                MessageBox.Show("Usted no tiene permiso para realizar esta tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
        
        // R E G I S T R O S --------------------------------------------------------------------------------------
        private void registroDeFacturasToolStripMenuItem_Click(object sender, EventArgs e) //Registro de facturas
        {
            try
            {
                rFacturas rF = new rFacturas(Nombre, Nivel, 0);
                rF.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void entradaDeProductosToolStripMenuItem_Click(object sender, EventArgs e) // Entrada de productos
        {
            try
            {
                if (Nivel <= 1)
                {
                    rEntradaProductos rE = new rEntradaProductos(Nombre, 0, 0);
                    rE.ShowDialog();
                }
                else
                    NoTienePermiso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e) //Registro de productos
        {
            try
            {
                if (Nivel <= 0)
                {
                    rProductos rP = new rProductos(Nombre, Nivel, 0);
                    rP.ShowDialog();
                }
                else
                    NoTienePermiso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registroDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e) //Registro de categorias
        {
            try
            {
                if (Nivel <= 0)
                {
                    rCategorias rC = new rCategorias(Nombre, 0);
                    rC.ShowDialog();
                }
                else
                    NoTienePermiso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)//Registro de usuarios
        {
            try
            {
                if (Nivel <= 0)
                {
                    rUsuarios rU = new rUsuarios(Nombre, 0);
                    rU.ShowDialog();
                }
                else
                    NoTienePermiso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cuadreDeCajaToolStripMenuItem_Click(object sender, EventArgs e) // Cuadre de caja
        {
            try
            {
                rCuadreDeCaja rCC = new rCuadreDeCaja(Nombre, Nivel, 0);
                rCC.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e) // Cerrar sesion
        {
            try
            {
                var result = MessageBox.Show(" ¿Está seguro de que desea  Cerrar Sesión ? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Login l = new Login();
                    l.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // C O N S U L T A S ------------------------------------------------------------------------------------
        
        private void ConsultaDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)//Consulta de Facturas
        {
            try
            {
                if (Nivel <= 0)
                {
                    cFacturas cF = new cFacturas(Nombre, Nivel);
                    cF.ShowDialog();
                }
                else
                    NoTienePermiso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void consultaDeEntradaDeProductosToolStripMenuItem_Click(object sender, EventArgs e) // Consulta de entrada de productos
        {
            try
            {
                if (Nivel <= 1)
                {
                    cEntradaProductos cE = new cEntradaProductos(Nombre);
                    cE.ShowDialog();
                }
                else
                    NoTienePermiso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void consultaDeProductosToolStripMenuItem1_Click(object sender, EventArgs e) //Consulta de Productos
        {
            try
            {
                cProductos cP = new cProductos(Nombre, Nivel);
                cP.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultaDeCategoríasToolStripMenuItem_Click(object sender, EventArgs e) //Consulta de Categorías
        {
            try
            {
                if (Nivel <= 1)
                {
                    cCategorias cC = new cCategorias(Nombre, Nivel);
                    cC.ShowDialog();
                }
                else
                    NoTienePermiso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)//Consulta de Usuarios
        {
            try
            {
                if (Nivel <= 0)
                {
                    cUsuarios cU = new cUsuarios(Nombre);
                    cU.ShowDialog();
                }
                else
                    NoTienePermiso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultaDeCuadresDeCajaToolStripMenuItem_Click(object sender, EventArgs e) // Consulta de los cuadres de caja
        {
            try
            {
                if (Nivel <= 0)
                {
                    cCuadreDeCaja cCC = new cCuadreDeCaja(Nombre, Nivel);
                    cCC.ShowDialog();
                }
                else
                    NoTienePermiso();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e) // Calculadora
        {
            try
            {
                Calculadora Cal = new Calculadora(0);
                Cal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // A Y U D A ------------------------------------------------------------------------------------------

        private void registrosToolStripMenuItem1_Click(object sender, EventArgs e)//Ayuda de los registos
        {
            try
            {
                AyudaRegistros aR = new AyudaRegistros();
                aR.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultasToolStripMenuItem1_Click(object sender, EventArgs e) // Ayuda de las consultas
        {
            try
            {
                AyudaConsultas aC = new AyudaConsultas();
                aC.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       


        // A B O U T ------------------------------------------------------------------------------------------

        private void inventoryAssistantToolStripMenuItem_Click(object sender, EventArgs e)// Sobre InventoryAssistant
        {
            try
            {
                AboutForm Af = new AboutForm();
                Af.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e) // Actualiza los labels de la hora y la fecha
        {
            try
            {
                HoraLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
                FechaLabel.Text = DateTime.Now.ToString("dddd dd \\de MMMM \\del yyyy ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) // Al cerrar el MainForm cuerra la aplicacion
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
