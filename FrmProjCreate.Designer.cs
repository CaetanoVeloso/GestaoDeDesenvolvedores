namespace GestaoDeDesenvolvedores
{
    partial class FrmProjCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjCreate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtIni = new System.Windows.Forms.DateTimePicker();
            this.dtTp = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtT = new System.Windows.Forms.DateTimePicker();
            this.lblCreate = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNasc = new System.Windows.Forms.Label();
            this.lblTermP = new System.Windows.Forms.Label();
            this.lblIni = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtIni);
            this.panel1.Controls.Add(this.dtTp);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dtT);
            this.panel1.Controls.Add(this.lblCreate);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblNasc);
            this.panel1.Controls.Add(this.lblTermP);
            this.panel1.Controls.Add(this.lblIni);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 330);
            this.panel1.TabIndex = 1;
            // 
            // dtIni
            // 
            this.dtIni.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtIni.Location = new System.Drawing.Point(31, 132);
            this.dtIni.Name = "dtIni";
            this.dtIni.Size = new System.Drawing.Size(370, 26);
            this.dtIni.TabIndex = 15;
            // 
            // dtTp
            // 
            this.dtTp.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtTp.Location = new System.Drawing.Point(31, 185);
            this.dtTp.Name = "dtTp";
            this.dtTp.Size = new System.Drawing.Size(370, 26);
            this.dtTp.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(171)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(31, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(370, 35);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Create";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtT
            // 
            this.dtT.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtT.Location = new System.Drawing.Point(31, 238);
            this.dtT.Name = "dtT";
            this.dtT.Size = new System.Drawing.Size(370, 26);
            this.dtT.TabIndex = 9;
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCreate.Location = new System.Drawing.Point(66, 9);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(303, 35);
            this.lblCreate.TabIndex = 8;
            this.lblCreate.Text = "Create new Project";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNome.Location = new System.Drawing.Point(31, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(370, 26);
            this.txtNome.TabIndex = 5;
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.lblNasc.Location = new System.Drawing.Point(31, 214);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(172, 21);
            this.lblNasc.TabIndex = 3;
            this.lblNasc.Text = "Termino Executado:";
            // 
            // lblTermP
            // 
            this.lblTermP.AutoSize = true;
            this.lblTermP.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.lblTermP.Location = new System.Drawing.Point(31, 161);
            this.lblTermP.Name = "lblTermP";
            this.lblTermP.Size = new System.Drawing.Size(172, 21);
            this.lblTermP.TabIndex = 2;
            this.lblTermP.Text = "Termino Planejado:";
            // 
            // lblIni
            // 
            this.lblIni.AutoSize = true;
            this.lblIni.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.lblIni.Location = new System.Drawing.Point(31, 108);
            this.lblIni.Name = "lblIni";
            this.lblIni.Size = new System.Drawing.Size(73, 21);
            this.lblIni.TabIndex = 1;
            this.lblIni.Text = "Inicio:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(187)))), ((int)(((byte)(190)))));
            this.lblName.Location = new System.Drawing.Point(31, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // FrmProjCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(463, 352);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProjCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestãoDeDesenvolvedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtT;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.Label lblTermP;
        private System.Windows.Forms.Label lblIni;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtIni;
        private System.Windows.Forms.DateTimePicker dtTp;
        private System.Windows.Forms.TextBox txtNome;
    }
}