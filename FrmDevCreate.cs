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
    public partial class FrmDevCreate : Form
    {
        private static FrmDevCreate _instance;
        public FrmDevCreate()
        {
            InitializeComponent();
        }
        public static FrmDevCreate GetInstance()
        {
            if (_instance == null
                // Quando esta janela é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmDevCreate();
            }
            return _instance;
        }
    }
}
