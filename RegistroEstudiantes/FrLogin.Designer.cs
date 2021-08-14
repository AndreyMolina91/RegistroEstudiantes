
namespace RegistroEstudiantes
{
    partial class FrLogin
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
            this.PbLogin = new System.Windows.Forms.PictureBox();
            this.TxtBxUsuario = new System.Windows.Forms.TextBox();
            this.TxtBxClave = new System.Windows.Forms.TextBox();
            this.Btnlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PbLogin
            // 
            this.PbLogin.Image = global::RegistroEstudiantes.Properties.Resources.Imagen2;
            this.PbLogin.Location = new System.Drawing.Point(-1, -1);
            this.PbLogin.Name = "PbLogin";
            this.PbLogin.Size = new System.Drawing.Size(286, 338);
            this.PbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbLogin.TabIndex = 0;
            this.PbLogin.TabStop = false;
            // 
            // TxtBxUsuario
            // 
            this.TxtBxUsuario.Location = new System.Drawing.Point(86, 120);
            this.TxtBxUsuario.Multiline = true;
            this.TxtBxUsuario.Name = "TxtBxUsuario";
            this.TxtBxUsuario.Size = new System.Drawing.Size(141, 25);
            this.TxtBxUsuario.TabIndex = 1;
            // 
            // TxtBxClave
            // 
            this.TxtBxClave.Location = new System.Drawing.Point(86, 153);
            this.TxtBxClave.Multiline = true;
            this.TxtBxClave.Name = "TxtBxClave";
            this.TxtBxClave.Size = new System.Drawing.Size(141, 25);
            this.TxtBxClave.TabIndex = 2;
            // 
            // Btnlogin
            // 
            this.Btnlogin.BackColor = System.Drawing.Color.SeaGreen;
            this.Btnlogin.FlatAppearance.BorderSize = 0;
            this.Btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnlogin.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btnlogin.Location = new System.Drawing.Point(59, 185);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(168, 31);
            this.Btnlogin.TabIndex = 3;
            this.Btnlogin.Text = "INGRESAR";
            this.Btnlogin.UseVisualStyleBackColor = false;
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // FrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 337);
            this.ControlBox = false;
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.TxtBxClave);
            this.Controls.Add(this.TxtBxUsuario);
            this.Controls.Add(this.PbLogin);
            this.Name = "FrLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbLogin;
        private System.Windows.Forms.TextBox TxtBxUsuario;
        private System.Windows.Forms.TextBox TxtBxClave;
        private System.Windows.Forms.Button Btnlogin;
    }
}