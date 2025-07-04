namespace Logintpfinal
{
    partial class RecuperarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarForm));
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            btnEnviarCodigo = new Button();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNuevaPass = new Label();
            txtNuevaPass = new TextBox();
            lblConfirmar = new Label();
            txtConfirmarPass = new TextBox();
            btnConfirmar = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9.75F);
            lblCorreo.Location = new Point(24, 24);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(151, 23);
            lblCorreo.TabIndex = 0;
            lblCorreo.Text = "Correo Electronico";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(24, 51);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(245, 27);
            txtCorreo.TabIndex = 1;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.Location = new Point(296, 50);
            btnEnviarCodigo.Margin = new Padding(3, 4, 3, 4);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new Size(112, 29);
            btnEnviarCodigo.TabIndex = 2;
            btnEnviarCodigo.Text = "Enviar código";
            btnEnviarCodigo.UseVisualStyleBackColor = true;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9.75F);
            lblCodigo.Location = new Point(24, 95);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(65, 23);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(24, 122);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(114, 27);
            txtCodigo.TabIndex = 3;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // lblNuevaPass
            // 
            lblNuevaPass.AutoSize = true;
            lblNuevaPass.Font = new Font("Segoe UI", 9.75F);
            lblNuevaPass.Location = new Point(24, 175);
            lblNuevaPass.Name = "lblNuevaPass";
            lblNuevaPass.Size = new Size(148, 23);
            lblNuevaPass.TabIndex = 5;
            lblNuevaPass.Text = "Nueva contraseña";
            // 
            // txtNuevaPass
            // 
            txtNuevaPass.Location = new Point(24, 214);
            txtNuevaPass.Margin = new Padding(3, 4, 3, 4);
            txtNuevaPass.Name = "txtNuevaPass";
            txtNuevaPass.Size = new Size(245, 27);
            txtNuevaPass.TabIndex = 4;
            txtNuevaPass.TextChanged += txtNuevaPass_TextChanged;
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Font = new Font("Segoe UI", 9.75F);
            lblConfirmar.Location = new Point(24, 260);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(175, 23);
            lblConfirmar.TabIndex = 7;
            lblConfirmar.Text = "Confirmar contraseña";
            // 
            // txtConfirmarPass
            // 
            txtConfirmarPass.Location = new Point(24, 302);
            txtConfirmarPass.Margin = new Padding(3, 4, 3, 4);
            txtConfirmarPass.Name = "txtConfirmarPass";
            txtConfirmarPass.Size = new Size(245, 27);
            txtConfirmarPass.TabIndex = 5;
            txtConfirmarPass.TextChanged += txtConfirmarPass_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(384, 348);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(138, 31);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar cambio";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.ForeColor = Color.Red;
            lblMensaje.Location = new Point(24, 333);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 20);
            lblMensaje.TabIndex = 10;
            // 
            // RecuperarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 392);
            Controls.Add(lblMensaje);
            Controls.Add(btnConfirmar);
            Controls.Add(txtConfirmarPass);
            Controls.Add(lblConfirmar);
            Controls.Add(txtNuevaPass);
            Controls.Add(lblNuevaPass);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnEnviarCodigo);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "RecuperarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecuperarForm";
            Load += RecuperarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCorreo;
        private TextBox txtCorreo;
        private Button btnEnviarCodigo;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNuevaPass;
        private TextBox txtNuevaPass;
        private Label lblConfirmar;
        private TextBox txtConfirmarPass;
        private Button btnConfirmar;
        private Label lblMensaje;
    }
}