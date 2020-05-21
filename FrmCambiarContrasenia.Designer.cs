namespace FProjects
{
    partial class FrmCambiarContrasenia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiarContrasenia));
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.JMT_Correo = new JMetroTextBox.JMetroTextBox();
            this.JTButton_Enviar = new JThinButton.JThinButton();
            this.lbInicioSesion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JTB_Pin = new JTextBox2.JTextBox();
            this.btnConfirmar = new JThinButton.JThinButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(77, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿HAS OLVIDADO TU CONTRASEÑA?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(437, 112);
            this.label5.TabIndex = 10;
            this.label5.Text = "Introduce el correo electrónico que has ultilizado para registrarte. Recibiras un" +
    " correo con un PIN para confirmar que es el propietario de la cuenta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(105, 20);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(245, 66);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 55;
            this.pictureBox6.TabStop = false;
            // 
            // JMT_Correo
            // 
            this.JMT_Correo.BackColor = System.Drawing.Color.Transparent;
            this.JMT_Correo.BorderColor = System.Drawing.Color.Empty;
            this.JMT_Correo.BorderRadius = 10;
            this.JMT_Correo.FillColor = System.Drawing.Color.LightSkyBlue;
            this.JMT_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_Correo.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_Correo.ForeColors = System.Drawing.Color.Gray;
            this.JMT_Correo.IsPassword = false;
            this.JMT_Correo.LineThickness = 2;
            this.JMT_Correo.Location = new System.Drawing.Point(40, 245);
            this.JMT_Correo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.JMT_Correo.MaxLength = 32767;
            this.JMT_Correo.MouseOnHover = System.Drawing.Color.Empty;
            this.JMT_Correo.Name = "JMT_Correo";
            this.JMT_Correo.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.JMT_Correo.OnFocusColor = System.Drawing.Color.Empty;
            this.JMT_Correo.OnFocusFontColor = System.Drawing.Color.Empty;
            this.JMT_Correo.ReadOnly = false;
            this.JMT_Correo.Size = new System.Drawing.Size(387, 47);
            this.JMT_Correo.TabIndex = 58;
            this.JMT_Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JMT_Correo.TextName = "Correo Electrónico";
            this.JMT_Correo.Enter += new System.EventHandler(this.JMT_Correo_Enter);
            this.JMT_Correo.Leave += new System.EventHandler(this.JMT_Correo_Leave);
            // 
            // JTButton_Enviar
            // 
            this.JTButton_Enviar.BackColor = System.Drawing.Color.Transparent;
            this.JTButton_Enviar.BackgroundColor = System.Drawing.Color.White;
            this.JTButton_Enviar.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.JTButton_Enviar.BorderRadius = 10;
            this.JTButton_Enviar.ButtonText = "Enviar PIN";
            this.JTButton_Enviar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTButton_Enviar.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTButton_Enviar.ForeColors = System.Drawing.Color.Gray;
            this.JTButton_Enviar.HoverBackground = System.Drawing.Color.White;
            this.JTButton_Enviar.HoverBorder = System.Drawing.Color.Empty;
            this.JTButton_Enviar.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.JTButton_Enviar.LineThickness = 2;
            this.JTButton_Enviar.Location = new System.Drawing.Point(64, 319);
            this.JTButton_Enviar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.JTButton_Enviar.Name = "JTButton_Enviar";
            this.JTButton_Enviar.Size = new System.Drawing.Size(333, 29);
            this.JTButton_Enviar.TabIndex = 73;
            this.JTButton_Enviar.Click += new System.EventHandler(this.JTButton_Enviar_Click);
            // 
            // lbInicioSesion
            // 
            this.lbInicioSesion.AutoSize = true;
            this.lbInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.lbInicioSesion.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.lbInicioSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbInicioSesion.Location = new System.Drawing.Point(325, 464);
            this.lbInicioSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInicioSesion.Name = "lbInicioSesion";
            this.lbInicioSesion.Size = new System.Drawing.Size(123, 29);
            this.lbInicioSesion.TabIndex = 76;
            this.lbInicioSesion.Text = "Iniciar Sesion";
            this.lbInicioSesion.Click += new System.EventHandler(this.lbInicioSesion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 464);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 29);
            this.label2.TabIndex = 75;
            this.label2.Text = "¿Tienes una cuenta de FProjects?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // JTB_Pin
            // 
            this.JTB_Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.JTB_Pin.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.JTB_Pin.HintText = "PIN";
            this.JTB_Pin.IsPassword = false;
            this.JTB_Pin.Location = new System.Drawing.Point(131, 368);
            this.JTB_Pin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.JTB_Pin.MaxLength = 32767;
            this.JTB_Pin.Name = "JTB_Pin";
            this.JTB_Pin.OnFocusedColor = System.Drawing.Color.White;
            this.JTB_Pin.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.JTB_Pin.ReadOnly = false;
            this.JTB_Pin.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.JTB_Pin.Size = new System.Drawing.Size(191, 38);
            this.JTB_Pin.TabIndex = 77;
            this.JTB_Pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JTB_Pin.TextName = "PIN";
            this.JTB_Pin.Visible = false;
            this.JTB_Pin.Enter += new System.EventHandler(this.JTB_Pin_Enter);
            this.JTB_Pin.Leave += new System.EventHandler(this.JTB_Pin_Leave);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BackgroundColor = System.Drawing.Color.White;
            this.btnConfirmar.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConfirmar.BorderRadius = 13;
            this.btnConfirmar.ButtonText = "Confirmar PIN";
            this.btnConfirmar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColors = System.Drawing.Color.Gray;
            this.btnConfirmar.HoverBackground = System.Drawing.Color.White;
            this.btnConfirmar.HoverBorder = System.Drawing.Color.Empty;
            this.btnConfirmar.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmar.LineThickness = 2;
            this.btnConfirmar.Location = new System.Drawing.Point(64, 415);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(333, 41);
            this.btnConfirmar.TabIndex = 78;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmCambiarContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::FProjects.Properties.Resources.m7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 512);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.JTB_Pin);
            this.Controls.Add(this.lbInicioSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JTButton_Enviar);
            this.Controls.Add(this.JMT_Correo);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCambiarContrasenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCambiarContrasenia";
            this.Load += new System.EventHandler(this.FrmCambiarContrasenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private JMetroTextBox.JMetroTextBox JMT_Correo;
        private JThinButton.JThinButton JTButton_Enviar;
        private System.Windows.Forms.Label lbInicioSesion;
        private System.Windows.Forms.Label label2;
        private JTextBox2.JTextBox JTB_Pin;
        private JThinButton.JThinButton btnConfirmar;
    }
}