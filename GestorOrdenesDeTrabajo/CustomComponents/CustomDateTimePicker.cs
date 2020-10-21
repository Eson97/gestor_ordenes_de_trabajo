using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GestorOrdenesDeTrabajo.Clases
{
    class CustomDateTimePicker : DateTimePicker
    {
        private Color _BackColor = SystemColors.ControlDark;

        public CustomDateTimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            //The dropDownRectangle defines position and size of dropdownbutton block, 
            //the width is fixed to 17 and height to 16. 
            //The dropdownbutton is aligned to right
            Rectangle dropDownRectangle =
               new Rectangle(ClientRectangle.Width - 20, 0, 20, ClientRectangle.Height);
            Brush bkgBrush;
            ComboBoxState visualState;
            bkgBrush = new SolidBrush(this.BackColor);
            visualState = ComboBoxState.Normal;
            // Painting...in action

            //Filling the background
            g.FillRectangle(bkgBrush, 0, 0, ClientRectangle.Width, ClientRectangle.Height);

            //Drawing the border
            g.DrawRectangle(Pens.Gray, 0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);

            //Drawing the datetime text
            g.DrawString(this.Text, this.Font, Brushes.Black, 0, 2);

            //Drawing the dropdownbutton using ComboBoxRenderer
            ComboBoxRenderer.DrawDropDownButton(g, dropDownRectangle, visualState);

            g.Dispose();
            bkgBrush.Dispose();
        }

        [Browsable(true)]
        public override Color BackColor
        {
            get
            {
                return _BackColor;
            }
            set
            {
                _BackColor = value;
                Invalidate();
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == (int)0x0014 /* WM_ERASEBKGND */)
            {
                Graphics g = Graphics.FromHdc(m.WParam);
                g.FillRectangle(new SolidBrush(_BackColor),
                    ClientRectangle);
                g.Dispose();
                return;
            }
            base.WndProc(ref m);
        }

    }
}
