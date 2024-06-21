namespace Exercicio_C_
{
    partial class FrmPrincipal: Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpxPrincipal = new GroupBox();
            btnUsuarios = new Button();
            btnChamados = new Button();
            btnSair = new Button();
            gpxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // gpxPrincipal
            // 
            gpxPrincipal.Controls.Add(btnSair);
            gpxPrincipal.Controls.Add(btnUsuarios);
            gpxPrincipal.Controls.Add(btnChamados);
            gpxPrincipal.Location = new Point(12, 12);
            gpxPrincipal.Name = "gpxPrincipal";
            gpxPrincipal.Size = new Size(776, 426);
            gpxPrincipal.TabIndex = 0;
            gpxPrincipal.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Felix Titling", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.Location = new Point(42, 124);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(322, 197);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnChamados
            // 
            btnChamados.Font = new Font("Felix Titling", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChamados.Location = new Point(418, 124);
            btnChamados.Name = "btnChamados";
            btnChamados.Size = new Size(322, 197);
            btnChamados.TabIndex = 0;
            btnChamados.Text = "Chamados";
            btnChamados.UseVisualStyleBackColor = true;
            btnChamados.Click += btnChamados_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.LightCoral;
            btnSair.Location = new Point(701, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpxPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Principal";
            gpxPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpxPrincipal;
        private Button btnUsuarios;
        private Button btnChamados;
        private Button btnSair;
    }
}
