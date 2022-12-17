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
    public partial class FrmLogin : Form
    {
        private static FrmLogin _instance;
        public FrmLogin()
        {
            InitializeComponent();
            Repository repositorio = new Repository();
        }

        public static FrmLogin GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FrmLogin();
            }
            _instance.ActiveControl = _instance.txtMail;
            return _instance;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Credential dev = CredentialRepository.Autenticar(new Credential(){ Email = txtMail.Text,Senha = txtPass.Text});
            if (dev != null)
            {
                txtMail.Text = null;
                txtPass.Text = null;
                this.Hide();
                FrmSystem frmSystem = FrmSystem.GetInstance();
                frmSystem.DevLogado = dev;
                frmSystem.Show();
            }
            else
            {
                txtPass.Text = null;
                txtMail.SelectAll();
                this.ActiveControl = txtMail;
                lblMail.Text = "Email: Email or password is invalid.";
                lblMail.ForeColor = Color.FromArgb(245,151,148);
                lblPass.Text = "Password: Email or password is invalid.";
                lblPass.ForeColor = Color.FromArgb(245, 151, 148);
                //MessageBox.Show("Password - Login or password is invalid.", "GestãoDev's", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

