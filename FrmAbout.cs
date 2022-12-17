using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeDesenvolvedores
{
    public partial class FrmAbout : Form
    {
        private static FrmAbout _instance;
        public FrmAbout()
        {
            InitializeComponent();
        }
        public static FrmAbout GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmAbout();
            }
            return _instance;
        }
    }
}
