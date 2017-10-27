using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();

        }

        private void appointBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm appointForm = new AppointmentForm();
            appointForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterPatient registerForm = new RegisterPatient();
            registerForm.Show();
        }
    }
}
