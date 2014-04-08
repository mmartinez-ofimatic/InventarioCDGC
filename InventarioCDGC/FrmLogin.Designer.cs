namespace InventarioCDGC
{
    partial class FrmLogin
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
            this.tpass = new System.Windows.Forms.TextBox();
            this.tusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BLOGIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tpass
            // 
            this.tpass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tpass.Location = new System.Drawing.Point(125, 107);
            this.tpass.Name = "tpass";
            this.tpass.PasswordChar = '*';
            this.tpass.Size = new System.Drawing.Size(121, 20);
            this.tpass.TabIndex = 8;
            // 
            // tusuario
            // 
            this.tusuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tusuario.Location = new System.Drawing.Point(125, 62);
            this.tusuario.Name = "tusuario";
            this.tusuario.Size = new System.Drawing.Size(121, 20);
            this.tusuario.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "USUARIO:";
            // 
            // BLOGIN
            // 
            this.BLOGIN.Location = new System.Drawing.Point(125, 158);
            this.BLOGIN.Name = "BLOGIN";
            this.BLOGIN.Size = new System.Drawing.Size(79, 29);
            this.BLOGIN.TabIndex = 9;
            this.BLOGIN.Text = "LOGIN";
            this.BLOGIN.UseVisualStyleBackColor = true;
            this.BLOGIN.Click += new System.EventHandler(this.BLOGIN_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 233);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.tusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BLOGIN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.TextBox tusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BLOGIN;
    }
}