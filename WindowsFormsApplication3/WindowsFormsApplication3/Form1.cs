using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
            if (txt_path.Text == "")
            {
                Console.Beep();
                MessageBox.Show("Informe o caminho!");
            }
            else {
                Image path = Image.FromFile(txt_path.Text);
                pictureBox1.Image = path;
                lst_path.Items.Add(txt_path.Text);
                txt_path.Clear();
            }
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int index = lst_path.SelectedIndex;

            if (index == -1)
            {
                Console.Beep();
                MessageBox.Show("Seleciona um item na Lista!");
            }
            else {
                lst_path.Items.RemoveAt(index);
            }
        }

        private void lst_path_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_path.SelectedIndex != -1)
            {
                Image path = Image.FromFile((string)lst_path.Items[lst_path.SelectedIndex]);

                pictureBox1.Image = path;
            }

          


        }
    }
}
