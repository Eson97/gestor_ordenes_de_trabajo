using System.Drawing;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.CustomComponents
{
    class FloatButton : Button
    {
        private Color _borderColor = Color.Silver;
        private Color _onHoverBorderColor = Color.Gray;
        private Color _buttonColor = Color.Red;
        private Color _onHoverButtonColor = Color.Yellow;
        private Color _textColor = Color.White;
        private Color _onHoverTextColor = Color.Gray;
        private Color _onMouseDownBorderColor = Color.Black;
        private Color _onMouseDownButtonColor = Color.Black;
        private Color _shadowTextColor = Color.Transparent;

        private bool _isHovering;
        private bool _isMouseDown;
        private int _borderThickness = 6;
        private int _borderThicknessByTwo = 3;


        public FloatButton()
        {
            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
            {
                _isHovering = true;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                _isHovering = false;
                Invalidate();
            };
            MouseDown += (s, e) =>
            {
                _isMouseDown = true;
                Invalidate();
            };
            MouseUp += (s, e) =>
            {
                _isMouseDown = false;
                Invalidate();
            };
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //brush border
            Brush brush = new SolidBrush(_isMouseDown ? _onMouseDownBorderColor : _isHovering ? _onHoverBorderColor : _borderColor);

            //Border
            g.FillEllipse(brush, 0, 0, Height, Height);
            g.FillEllipse(brush, Width - Height, 0, Height, Height);
            g.FillRectangle(brush, Height / 2, 0, Width - Height, Height);

            brush.Dispose();
            //bruh button
            brush = new SolidBrush(_isMouseDown ? _onMouseDownButtonColor : _isHovering ? _onHoverButtonColor : _buttonColor);

            //Inner part. Button itself
            g.FillEllipse(brush, _borderThicknessByTwo, _borderThicknessByTwo, Height - _borderThickness,
                Height - _borderThickness);
            g.FillEllipse(brush, (Width - Height) + _borderThicknessByTwo, _borderThicknessByTwo,
                Height - _borderThickness, Height - _borderThickness);
            g.FillRectangle(brush, Height / 2 + _borderThicknessByTwo, _borderThicknessByTwo,
                Width - Height - _borderThickness, Height - _borderThickness);

            brush.Dispose();
            //brush text
            brush = new SolidBrush(_isHovering ? _onHoverTextColor : _textColor);
            Brush shadowBrush = new SolidBrush(_shadowTextColor);

            //Button Text
            SizeF stringSize = g.MeasureString(Text, Font);
            Point p = new Point((Width - (int)stringSize.Width) / 2, ((Height - (int)stringSize.Height) / 2) + 2);
            g.DrawString(Text, Font, shadowBrush, p.X + 2, p.Y + 2);
            g.DrawString(Text, Font, brush, p);
        }

        public Color textShadow
        {
            get => _shadowTextColor;
            set
            {
                _shadowTextColor = value;
                Invalidate();
            }
        }

        public Color OnMouseDownBorderColor
        {
            get => _onMouseDownBorderColor;
            set 
            {
                _onMouseDownBorderColor = value;
                Invalidate();
            }
        }
        public Color OnMouseDownButtonColor
        {
            get => _onMouseDownButtonColor;
            set
            {
                _onMouseDownButtonColor = value;
                Invalidate();
            }
        }
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public Color OnHoverBorderColor
        {
            get => _onHoverBorderColor;
            set
            {
                _onHoverBorderColor = value;
                Invalidate();
            }
        }

        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                Invalidate();
            }
        }

        public Color OnHoverButtonColor
        {
            get => _onHoverButtonColor;
            set
            {
                _onHoverButtonColor = value;
                Invalidate();
            }
        }

        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                Invalidate();
            }
        }

        public Color OnHoverTextColor
        {
            get => _onHoverTextColor;
            set
            {
                _onHoverTextColor = value;
                Invalidate();
            }
        }
    }
}
