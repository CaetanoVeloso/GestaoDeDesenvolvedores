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
    public partial class FrmProjCreate : Form
    {
        private static FrmProjCreate _instance;
        public FrmProjCreate()
        {
            InitializeComponent();
        }

        public static FrmProjCreate GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmProjCreate();
            }
            return _instance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Project newProj = new Project();
            newProj.Name = txtNome.Text;
            newProj.inicio = dtIni.Value;
            newProj.terminoPlanejado = dtTp.Value;
            newProj.termino = dtTp.Value;
            ProjRepository.Save(newProj);
            lblCreate.Text = "Project Created!";
            lblCreate.ForeColor = Color.FromArgb(115, 194, 171);
            MessageBox.Show("Project Created!", "GestãoDev's", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
