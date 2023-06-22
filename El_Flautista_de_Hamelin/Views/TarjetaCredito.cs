using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Flautista_de_Hamelin.Views
{
    public partial class TarjetaCredito : Form
    {
        public TarjetaCredito()
        {
            InitializeComponent();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelClickHandler(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            TextBox textBox = null;
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    textBox = (TextBox)control;
                    break;
                }
            }

            if (textBox != null)
            {
                textBox.Focus();
            }
        }

        private void LabelClickHandler(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Panel panel = label.Parent as Panel;
            TextBox textBox = null;
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    textBox = (TextBox)control;
                    break;
                }
            }

            if (textBox != null)
            {
                textBox.Focus();
            }
        }

        private void input_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Panel panel = (Panel)textBox.Parent;
            panel.BackColor = SystemColors.ScrollBar;
            textBox.BackColor = SystemColors.ScrollBar;

            if (textBox.Text == "")
            {
                Label label = null;
                foreach (Control control in panel.Controls)
                {
                    if (control is Label)
                    {
                        label = (Label)control;
                        break;
                    }
                }

                if (label != null)
                {
                    LabelAnimationToOriginal(label);
                }
            }
        }
        private void LabelAnimationToOriginal(Label label)
        {
            if (label.Left != 2 || label.Top != 2) return;

            label.Font = new Font(label.Font.FontFamily, 11, label.Font.Style);

            Point originalPosition = (Point)label.Tag;

            int targetX = originalPosition.X;
            int targetY = originalPosition.Y;

            int step = 8; // Cantidad de píxeles para cada paso de la animación
            int interval = 2; // Intervalo de tiempo entre cada paso de la animación (en milisegundos)

            int deltaX = (targetX - label.Left) / step;
            int deltaY = (targetY - label.Top) / step;

            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = interval;

            animationTimer.Tick += (s, args) =>
            {
                if (label.Left != targetX)
                {
                    label.Left += deltaX;
                }

                if (label.Top != targetY)
                {
                    label.Top += deltaY;
                }

                if (label.Left == targetX && label.Top == targetY)
                {
                    animationTimer.Stop();
                    animationTimer.Dispose();
                    animationTimer = null;
                }
            };

            animationTimer.Start();
        }

        private void input_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Panel panel = (Panel)textBox.Parent;

            panel.BackColor = SystemColors.ControlLightLight;
            //panel.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = SystemColors.ControlLightLight;


            Label label = null;
            foreach (Control control in panel.Controls)
            {
                if (control is Label)
                {
                    label = (Label)control;
                    break;
                }
            }

            if (label != null)
            {
                LabelAnimationToTop(label);
            }
        }

        private void LabelAnimationToTop(Label label)
        {
            if (label.Left == 2 || label.Top == 2) return;

            label.Font = new Font(label.Font.FontFamily, 9, label.Font.Style);


            int originalX = label.Left;
            int originalY = label.Top;


            int targetX = 2;
            int targetY = 2;

            int step = 8; // Cantidad de píxeles para cada paso de la animación
            int interval = 2; // Intervalo de tiempo entre cada paso de la animación (en milisegundos)

            int deltaX = (targetX - label.Left) / step;
            int deltaY = (targetY - label.Top) / step;

            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = interval;

            animationTimer.Tick += (s, args) =>
            {
                if (label.Left != targetX)
                {
                    label.Left += deltaX;
                }

                if (label.Top != targetY)
                {
                    label.Top += deltaY;
                }

                if (label.Left == targetX && label.Top == targetY)
                {
                    animationTimer.Stop();
                    animationTimer.Dispose();
                    animationTimer = null;
                }
            };

            animationTimer.Start();

            // Guardar la posición original en la propiedad Tag del Label
            label.Tag = new Point(originalX, originalY);
        }

        private void tarjeta_btn_efectivo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
