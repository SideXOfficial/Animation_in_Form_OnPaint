using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControl
{
    public class CustomGraphics : Control
    {
        public CustomGraphics()
        {
            SuspendLayout();
            //components = new Container();
            timer_animation = new Timer();
            timer_animation.Enabled = true;
            timer_animation.Interval = 10;
            timer_animation.Tick += new EventHandler(this.timer_Tick);
            this.DoubleBuffered = true;
            //SetStyle(ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            //BackColor = Color.Transparent;
            Resize += new EventHandler(CustomInvalidate);
            DrawText = "SideX";
            DrawSize = TextRenderer.MeasureText(DrawText, DrawFont);
            Info = "You can turn animation off in contructor form and change animation speed.";
            ResumeLayout();
        }
        string DrawText;
        Font DrawFont = new Font("Arial", 32);
        Point Position = new Point(0, 0);
        Size DrawSize = new Size();
        string Info;
        Font DrawFontInfo = new Font("Arial", 8);
        SolidBrush DrawBrush = new SolidBrush(Color.Black);
        int x = 0;
        int y = 0;
        int Speed;
        bool ShowInfo;
        private Timer timer_animation;

        protected override void OnPaint(PaintEventArgs pe)
        {
            //pe.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            pe.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            if (DesignMode)
            {
                if (!ShowInfo)
                {
                    pe.Graphics.DrawString(DrawText, DrawFont, DrawBrush, Position);
                    base.OnPaint(pe);
                }
                else
                {
                    pe.Graphics.DrawString(Info, DrawFontInfo, DrawBrush, 0, 0);
                    base.OnPaint(pe);
                }
            }
            else
            {
                pe.Graphics.DrawString(DrawText, DrawFont, DrawBrush, Position);
                base.OnPaint(pe);
            }
            //pe.Dispose();

        }

        private void CustomInvalidate(object sender, EventArgs e)
        {
            Invalidate(new Rectangle(Position.X, Position.Y, DrawSize.Width, DrawSize.Height));
            Update();

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (Position.X < 1) x = Speed;
            if (Position.X > (Width - DrawSize.Width)) x = -Speed;
            if (Position.Y < 1) y = Speed;
            if (Position.Y > Height - DrawSize.Height) y = -Speed;
            Position.Offset(x, y);
            if (!DesignMode) Invalidate();// new Rectangle(Position.X, Position.Y, DrawSize.Width, DrawSize.Height));
            else Invalidate();
            Update();
        }

        [Browsable(true), Category("AnimationSpeed"), Description("Move speed")]
        public int Value
        {
            get
            {
                return Speed;
            }
            set
            {
                if (value > 0 && value <= 8) Speed = value;
            }
        }

        [Browsable(true), Category("Info"), Description("App info")]
        public bool Show_Info
        {
            get
            {
                return ShowInfo;
            }
            set
            {
                ShowInfo = value;
            }
        }

    }
}
