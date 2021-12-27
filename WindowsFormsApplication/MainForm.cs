using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication.AutoFac;
using InterfaceLib;

namespace WindowsFormsApplication
{
    public partial class MainForm : Form
    {
        [Autowired]
        private ILogic _logic { get; set; }

        public MainForm()
        {
            this.AutoWire();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _logic.Test();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var _logic1 = AutoFacStartUp
                .Resolve<ILogic1>();
            _logic1.Test();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AutoFacStartUp.Resolve<TestForm>().Show();
        }
    }
}
