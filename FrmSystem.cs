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
        // Singleton
        private static FrmSystem _instance;

        // Horário de logon
        

        // Dados do usuário acessado
        private Credencial _usuarioLogado;
        public Credencial DesenvolvedorLogado
        {
            get { return _instance._usuarioLogado; }
            set
            {
                _instance._usuarioLogado = value;
            }
        }

        // Singleton
        private FrmSystem()
        {
            InitializeComponent();
        }

        // Singleton
        public static FrmSystem GetInstance()
        {
            if (_instance == null
                // Quando esta janela é fechada, a sua
                // instância persiste em um estado inacessível
                // devendo ser recriada
                || (_instance != null && _instance.IsDisposed))
            {
                _instance = new FrmSystem();
            }
            return _instance;
        }

        #region Fechamento da janela
        private void FrmSistema_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exibe a janela de login
            //FrmLogin.GetInstance().Visible = true;
            FrmLogin.GetInstance().Show();

            // "Fecha" esta janela (principal)
            //this.Visible = false;
            this.Hide();
        }
        #endregion
    }
}
