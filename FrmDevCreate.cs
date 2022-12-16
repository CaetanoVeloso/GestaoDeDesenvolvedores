﻿using System;
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
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmDevCreate();
            }
            return _instance;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Developer newDev = new Developer();
            Credential newCred = new Credential();
            newDev.Nome = txtNome.Text;
            newCred.Email = txtMail.Text;
            newCred.Senha = txtPass.Text;
            newCred.Administrador = chkAdm.Checked;
            newCred.Desenvolvedor = newDev;
            newDev.Credencial = newCred;
            DevRepository.Save(newDev);
            CredentialRepository.Save(newCred);
        }
    }
}
