using System;
using System.Windows.Forms;
using System.Drawing;

namespace Decorator_professions
{
    public partial class Form1 : Form, Iprofessions
    {
        public int Atack
        {
            get
            {
                return vertical_progressBar1.Value;
            }
            set
            {
                if (vertical_progressBar1.Value < value)
                    vertical_progressBar1.Update();
                vertical_progressBar1.Value = value;
                label5.Text = value.ToString();
            }
        }
        public int Speed
        {
            get
            {
                return vertical_progressBar2.Value;
            }
            set
            {
                if (vertical_progressBar2.Value < value)
                    vertical_progressBar2.Update();
                vertical_progressBar2.Value = value;
                label6.Text = value.ToString();
            }
        }
        public int Health
        {
            get
            {
                return vertical_progressBar3.Value;
            }
            set
            {
                if (vertical_progressBar3.Value < value)
                    vertical_progressBar3.Update();
                vertical_progressBar3.Value = value;
                label7.Text = value.ToString();
            }
        }
        public int Armor
        {
            get
            {
                return vertical_progressBar4.Value;
            }
            set
            {
                if (vertical_progressBar4.Value < value)
                    vertical_progressBar4.Update();
                vertical_progressBar4.Value = value;
                label8.Text = value.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        public event myVoidStringDelegate ManClicHandler;
        public event myVoidStringDelegate ElfClicHandler;


        #region человек
        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = button1.Text;
            label9.Font = button1.Font;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button6.Enabled = false;
            button11.Enabled = false;

            vertical_progressBar1.Maximum = 185;
            vertical_progressBar2.Maximum = 185;
            vertical_progressBar3.Maximum = 450;
            vertical_progressBar4.Maximum = 160;

            ManClicHandler?.Invoke(profession.MAN);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = button2.Text;
            label9.Font = button2.Font;
            button3.Enabled = true;
            button4.Enabled = true;
            button2.Enabled = false;
            ManClicHandler?.Invoke(profession.MAN_VARIOR);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = button3.Text;
            label9.Font = button3.Font;
            button5.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
            ManClicHandler?.Invoke(profession.MAN_SWORD);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label9.Text = button4.Text;
            label9.Font = button4.Font;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Start();
            timer2.Start();
            ManClicHandler?.Invoke(profession.MAN_ARCHER);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label9.Text = button5.Text;
            label9.Font = button5.Font;
            button5.Enabled = false;
            timer1.Start();
            timer2.Start();
            ManClicHandler?.Invoke(profession.MAN_KNIGHT);
        }
        #endregion
        #region Эльф
        private void button10_Click(object sender, EventArgs e)
        {
            label9.Text = button10.Text;
            label9.Font = button10.Font;
            button9.Enabled = true;
            button8.Enabled = true;

            button7.Enabled = false;
            button6.Enabled = false;
            button11.Enabled = false;


            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

            vertical_progressBar1.Maximum = 95;
            vertical_progressBar2.Maximum = 70;
            vertical_progressBar3.Maximum = 250;
            vertical_progressBar4.Maximum = 40;

            ElfClicHandler?.Invoke(profession.ELF);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            label9.Text = button9.Text;
            label9.Font = button9.Font;
            button7.Enabled = true;
            button9.Enabled = false;
            button8.Enabled = false;
            ElfClicHandler?.Invoke(profession.ELF_VARIOR);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label9.Text = button8.Text;
            label9.Font = button8.Font;
            button6.Enabled = true;
            button11.Enabled = true;
            button9.Enabled = false;
            button8.Enabled = false;
            ElfClicHandler?.Invoke(profession.ELF_MAG);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label9.Text = button7.Text;
            label9.Font = button7.Font;
            button7.Enabled = false;
            button9.Enabled = false;
            ElfClicHandler?.Invoke(profession.ELF_ARCHER);
            timer1.Start();
            timer2.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label9.Text = button6.Text;
            label9.Font = button6.Font;
            button6.Enabled = false;
            button11.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            ElfClicHandler?.Invoke(profession.ELF_ENGRY_MAG);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label9.Text = button11.Text;
            label9.Font = button11.Font;
            button6.Enabled = false;
            button11.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            ElfClicHandler?.Invoke(profession.ELF_KIND_MAG);
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.LightGray && button10.BackColor == Color.LightGray)
            {
                button1.BackColor = Color.GreenYellow;
                button10.BackColor = Color.GreenYellow;
            }
            else
            {
                button1.BackColor = Color.LightGray;
                button10.BackColor = Color.LightGray;
            }
            }
        private void timer2_Tick(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
            button10.BackColor = Color.LightGray;
            timer1.Stop();
        }
    }
}
