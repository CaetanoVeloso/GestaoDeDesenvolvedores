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
    public partial class FrmAlloc : Form
    {
        private static FrmAlloc _instance;
        public FrmAlloc()
        {
            InitializeComponent();
        }
        public static FrmAlloc GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmAlloc();
            }
            return _instance;
        }
    }
}
