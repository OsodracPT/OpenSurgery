using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class AppointmentUserControl : UserControl
    {

        //singleton initiation
        private static AppointmentUserControl _instance;

        public static AppointmentUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AppointmentUserControl();
                return _instance;
            }
        }
        public AppointmentUserControl()
        {
            InitializeComponent();
        }
    }
}
