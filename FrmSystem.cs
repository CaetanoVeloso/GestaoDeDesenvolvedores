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
    public partial class FrmSystem : Form
    {
        private static FrmSystem _instance;
        private Credential _devLogado;
        public Credential DevLogado
        {
            get { return _instance._devLogado; }
            set
            {
                _instance._devLogado = value;
            }
        }
        private FrmSystem()
        {
            InitializeComponent();
        }
        public static FrmSystem GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmSystem();
            }
            return _instance;
        }

        private void desenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDevCreate.GetInstance().Show();
        }
        private void projetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProjCreate.GetInstance().Show();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAbout.GetInstance().Show();
        }

        private void FrmSystem_Load(object sender, EventArgs e)
        {
            if (DevLogado.Administrador)
            {
                menuStrip1.Enabled = true;
                projetoToolStripMenuItem.Enabled = true;
                desenvolvedorToolStripMenuItem.Enabled = true;

            }
            else
            {
                menuStrip1.Enabled = true;
                projetoToolStripMenuItem.Enabled = false;
                desenvolvedorToolStripMenuItem.Enabled = false;
            }
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.FromArgb(54, 57, 63);
                    break;
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLogin.GetInstance().Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAlloc.GetInstance().Show();

        }
    }
}
