using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public static int nb_of_processes;
        public static int nb_of_ressources;
        public Form1()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(processes_txt.Text))
                {
                    MessageBox.Show("please fill the number of processes");
                }
                if (string.IsNullOrWhiteSpace(ressources_txt.Text))
                {
                    MessageBox.Show("please fill the number of ressources");
                }

                nb_of_processes = int.Parse(processes_txt.Text);
                nb_of_ressources = int.Parse(ressources_txt.Text);

                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter Integers values only");
                processes_txt.Clear();
                ressources_txt.Clear();
            }

        }
    }
}
