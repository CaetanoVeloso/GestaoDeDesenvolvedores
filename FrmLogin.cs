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

        // Singleton
        {
            InitializeComponent();

            // Força a criação do banco de dados,
            // caso ele não exista previamente
            Repository repositorio = new Repository();
        }

        // Singleton
        public static FrmLogin GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FrmLogin();
            }

            // Pré-seleciona o primeiro campo de entrada
            _instance.ActiveControl = _instance.txtMail;

            return _instance;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Autentica usuário
            Credential usuario = CredentialRepository.Autenticar(
                new Credential()
                {
                    Email = txtMail.Text,
                    Senha = txtPass.Text
                }
            );

            // Se o usuário é válido, ...
            if (usuario != null)
            {
                // ... limpa campos de entrada, ...
                txtMail.Text = null;
                txtPass.Text = null;

                // ... "fecha" esta janela ...
                //this.Visible = false;
                this.Hide();

                // ... e abre o programa principal.
                FrmSystem janelaSistema = FrmSystem.GetInstance();
                janelaSistema.DesenvolvedorLogado = usuario;
                //janelaSistema.Visible = true;
                janelaSistema.Show();
            }
            else
            {
                // Se o usuário é inválido, limpa campo de senha, ...
                txtPass.Text = null;

                // ... e pré-seleciona o primeiro campo de entrada.
                txtMail.SelectAll();
                this.ActiveControl = txtMail;

                // Ao invés de uma mensagem, pode ser usado um rótulo na
                // GUI para indicar que a autenticação não foi realizada
                lblMail.Text = "Email: Email or password is invalid.";
                lblMail.ForeColor = Color.FromArgb(245,151,148);
                lblPass.Text = "Password: Email or password is invalid.";
                lblPass.ForeColor = Color.FromArgb(245, 151, 148);
                //MessageBox.Show("Password - Login or password is invalid.", "GestãoDev's", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

