using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace InventoryAssistant.UI.Otras
{
    public class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(graphicsPath);
            base.OnPaint(pe);
        }
    }
}
