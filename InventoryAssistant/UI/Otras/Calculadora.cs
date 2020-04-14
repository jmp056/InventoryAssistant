using System;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Otras
{
    public partial class Calculadora : Form
    {
        decimal MontoFactura;

        public Calculadora(decimal montoFactura)
        {
            try 
            {
                this.MontoFactura = montoFactura;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calculadora_Load(object sender, EventArgs e) // Al cargar el form
        {
            try
            {
                if (MontoFactura > 0)
                    MontoFacturaNumericUpDown.Value = MontoFactura;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularButton_Click(object sender, EventArgs e) // Clic al boton calcular
        {
            try
            {
                Calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)  // Clic al boton limpiar
        {
            try
            {
                MontoFacturaNumericUpDown.Value = 0;
                MontoRecibidoNumericUpDown.Value = 0;
                RetornoTextBox.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calcular() // Funcion encargada de realizar el calculo
        {
            try
            {
                RetornoTextBox.Text = Convert.ToString(MontoRecibidoNumericUpDown.Value - MontoFacturaNumericUpDown.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MontoFacturaNumericUpDown_ValueChanged(object sender, EventArgs e)  // Calcula si cambia el valor del NumericUpDown del monto de la factura
        {
            try
            {
                Calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MontoRecibidoNumericUpDown_ValueChanged(object sender, EventArgs e) // Calcula si cambia el valor del NumericUpDown del monto recibido
        {
            try
            {
                Calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void MontoRecibidoNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Calcula al pulsar una tecla en el NumericUpDown del monto recibido
        {
            try
            {
                Calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MontoFacturaNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Calcula al pulsar una tecla en el NumericUpDown del monto de la factura
        {
            try
            {
                Calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MontoFacturaNumericUpDown_Enter(object sender, EventArgs e) // Si el NumericUpDown del monto de la factura gana el foco
        {
            try
            {
                if (MontoFacturaNumericUpDown.Value == 0)
                    MontoFacturaNumericUpDown.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MontoRecibidoNumericUpDown_Enter(object sender, EventArgs e) // Si el NumericUpDown del monto recibido gana el foco
        {
            try
            {
                if (MontoRecibidoNumericUpDown.Value == 0)
                    MontoRecibidoNumericUpDown.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
