using System.Resources;
using System.Windows.Forms;

namespace Logintpfinal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtUser = new TextBox();
            label2 = new Label();
            txtPass = new TextBox();
            button1 = new Button();
            btnOlvidaste = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold);
            label1.Location = new Point(12, 187);
            label1.Name = "label1";
            label1.Size = new Size(212, 24);
            label1.TabIndex = 3;
            label1.Text = "Nombre de Usuario";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(12, 215);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(261, 27);
            txtUser.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Bold);
            label2.Location = new Point(12, 257);
            label2.Name = "label2";
            label2.Size = new Size(127, 24);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(12, 285);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(225, 27);
            txtPass.TabIndex = 2;
            txtPass.UseSystemPasswordChar = true;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("MS Reference Sans Serif", 11.25F);
            button1.Location = new Point(12, 333);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 37);
            button1.TabIndex = 3;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnOlvidaste
            // 
            btnOlvidaste.Font = new Font("MS Reference Sans Serif", 11.25F);
            btnOlvidaste.Location = new Point(12, 449);
            btnOlvidaste.Margin = new Padding(3, 4, 3, 4);
            btnOlvidaste.Name = "btnOlvidaste";
            btnOlvidaste.Size = new Size(351, 31);
            btnOlvidaste.TabIndex = 4;
            btnOlvidaste.Text = "¿Olvidaste tu contraseña?";
            btnOlvidaste.UseVisualStyleBackColor = true;
            btnOlvidaste.Click += btnOlvidaste_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Company_Profile_Presentation_1_1;
            pictureBox1.Location = new Point(277, -17);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(471, 493);
            Controls.Add(pictureBox1);
            Controls.Add(btnOlvidaste);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUser;
        private Label label2;
        private TextBox txtPass;
        private Button button1;
        private Button btnOlvidaste;
        private PictureBox pictureBox1;
    }
}
