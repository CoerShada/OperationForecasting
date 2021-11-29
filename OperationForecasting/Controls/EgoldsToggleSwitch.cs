using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace OperationForecasting.Controls
{

    public class EgoldsToggleSwitch : Control
    {
        public EgoldsToggleSwitch()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(40, 15);

            Font = new Font("Verdana", 9F, FontStyle.Regular);
            BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Pen TSPen = new Pen(FlatColors.GrayDark, 3);
            Pen TSPenToggle = new Pen(FlatColors.GrayDark, 3);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectToggle = new Rectangle(0, 0, Width - 1, Height - 1);

            graph.DrawRectangle(TSPen, rect);
            graph.FillRectangle(new SolidBrush(Color.WhiteSmoke), rect);

            graph.DrawEllipse(TSPenToggle, rectToggle);
            graph.FillRectangle(new SolidBrush(Color.White), rectToggle);
        }
    }
}
