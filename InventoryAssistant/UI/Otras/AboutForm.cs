using System;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Otras
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            try
            {
                InitializeComponent();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
