namespace FProjects
{
    partial class FrmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioSesion));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRegistrarse = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Titulo = new System.Windows.Forms.PictureBox();
            this.lbCambioContra = new System.Windows.Forms.Label();
            this.jImageButton1 = new JImageButton.JImageButton();
            this.jImageButton2 = new JImageButton.JImageButton();
            this.JMT_txtCorreo = new JMetroTextBox.JMetroTextBox();
            this.JMT_ContraEsconder = new JMetroTextBox.JMetroTextBox();
            this.JTButton_Login = new JThinButton.JThinButton();
            this.btnMostrarContra = new System.Windows.Forms.Button();
            this.JMT_ContraMostrar = new JMetroTextBox.JMetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Titulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // lbRegistrarse
            // 
            this.lbRegistrarse.AutoSize = true;
            this.lbRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.lbRegistrarse.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistrarse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbRegistrarse.Location = new System.Drawing.Point(53, 298);
            this.lbRegistrarse.Name = "lbRegistrarse";
            this.lbRegistrarse.Size = new System.Drawing.Size(120, 20);
            this.lbRegistrarse.TabIndex = 8;
            this.lbRegistrarse.Text = "¿No tienes cuenta?";
            this.lbRegistrarse.Click += new System.EventHandler(this.lbRegistrarse_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Image = ((System.Drawing.Image)(resources.GetObject("Titulo.Image")));
            this.Titulo.Location = new System.Drawing.Point(79, 23);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(242, 63);
            this.Titulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Titulo.TabIndex = 51;
            this.Titulo.TabStop = false;
            // 
            // lbCambioContra
            // 
            this.lbCambioContra.AutoSize = true;
            this.lbCambioContra.BackColor = System.Drawing.Color.Transparent;
            this.lbCambioContra.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCambioContra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCambioContra.Location = new System.Drawing.Point(194, 298);
            this.lbCambioContra.Name = "lbCambioContra";
            this.lbCambioContra.Size = new System.Drawing.Size(184, 20);
            this.lbCambioContra.TabIndex = 53;
            this.lbCambioContra.Text = "¿Has olvidado tu contraseña?";
            this.lbCambioContra.Click += new System.EventHandler(this.lbCambioContra_Click);
            // 
            // jImageButton1
            // 
            this.jImageButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jImageButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.jImageButton1.CausesValidation = false;
            this.jImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.jImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("jImageButton1.ErrorImage")));
            this.jImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("jImageButton1.Image")));
            this.jImageButton1.ImageHover = null;
            this.jImageButton1.InitialImage = null;
            this.jImageButton1.Location = new System.Drawing.Point(-21, -46);
            this.jImageButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jImageButton1.Name = "jImageButton1";
            this.jImageButton1.Size = new System.Drawing.Size(157, 47);
            this.jImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jImageButton1.TabIndex = 54;
            this.jImageButton1.Zoom = 4;
            // 
            // jImageButton2
            // 
            this.jImageButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jImageButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.jImageButton2.CausesValidation = false;
            this.jImageButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.jImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("jImageButton2.ErrorImage")));
            this.jImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("jImageButton2.Image")));
            this.jImageButton2.ImageHover = null;
            this.jImageButton2.InitialImage = null;
            this.jImageButton2.Location = new System.Drawing.Point(-21, -46);
            this.jImageButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jImageButton2.Name = "jImageButton2";
            this.jImageButton2.Size = new System.Drawing.Size(157, 47);
            this.jImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jImageButton2.TabIndex = 55;
            this.jImageButton2.Zoom = 4;
            // 
            // JMT_txtCorreo
            // 
            this.JMT_txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.JMT_txtCorreo.BorderColor = System.Drawing.Color.Silver;
            this.JMT_txtCorreo.BorderRadius = 10;
            this.JMT_txtCorreo.FillColor = System.Drawing.Color.White;
            this.JMT_txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_txtCorreo.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_txtCorreo.ForeColors = System.Drawing.Color.Gray;
            this.JMT_txtCorreo.IsPassword = false;
            this.JMT_txtCorreo.LineThickness = 2;
            this.JMT_txtCorreo.Location = new System.Drawing.Point(66, 100);
            this.JMT_txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JMT_txtCorreo.MaxLength = 32767;
            this.JMT_txtCorreo.MouseOnHover = System.Drawing.Color.Empty;
            this.JMT_txtCorreo.Name = "JMT_txtCorreo";
            this.JMT_txtCorreo.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.JMT_txtCorreo.OnFocusColor = System.Drawing.Color.Empty;
            this.JMT_txtCorreo.OnFocusFontColor = System.Drawing.Color.Empty;
            this.JMT_txtCorreo.ReadOnly = false;
            this.JMT_txtCorreo.Size = new System.Drawing.Size(273, 39);
            this.JMT_txtCorreo.TabIndex = 56;
            this.JMT_txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JMT_txtCorreo.TextName = "Correo Electrónico";
            this.JMT_txtCorreo.Enter += new System.EventHandler(this.JMT_txtCorreo_Enter);
            this.JMT_txtCorreo.Leave += new System.EventHandler(this.JMT_txtCorreo_Leave);
            // 
            // JMT_ContraEsconder
            // 
            this.JMT_ContraEsconder.BackColor = System.Drawing.Color.Transparent;
            this.JMT_ContraEsconder.BorderColor = System.Drawing.Color.Silver;
            this.JMT_ContraEsconder.BorderRadius = 10;
            this.JMT_ContraEsconder.FillColor = System.Drawing.Color.White;
            this.JMT_ContraEsconder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_ContraEsconder.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_ContraEsconder.ForeColors = System.Drawing.Color.Gray;
            this.JMT_ContraEsconder.IsPassword = false;
            this.JMT_ContraEsconder.LineThickness = 2;
            this.JMT_ContraEsconder.Location = new System.Drawing.Point(64, 170);
            this.JMT_ContraEsconder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JMT_ContraEsconder.MaxLength = 32767;
            this.JMT_ContraEsconder.MouseOnHover = System.Drawing.Color.Empty;
            this.JMT_ContraEsconder.Name = "JMT_ContraEsconder";
            this.JMT_ContraEsconder.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.JMT_ContraEsconder.OnFocusColor = System.Drawing.Color.Empty;
            this.JMT_ContraEsconder.OnFocusFontColor = System.Drawing.Color.Empty;
            this.JMT_ContraEsconder.ReadOnly = false;
            this.JMT_ContraEsconder.Size = new System.Drawing.Size(273, 36);
            this.JMT_ContraEsconder.TabIndex = 57;
            this.JMT_ContraEsconder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JMT_ContraEsconder.TextName = "Contraseña";
            this.JMT_ContraEsconder.Enter += new System.EventHandler(this.JMT_ContraEsconder_Enter);
            this.JMT_ContraEsconder.Leave += new System.EventHandler(this.JMT_ContraEsconder_Leave);
            // 
            // JTButton_Login
            // 
            this.JTButton_Login.BackColor = System.Drawing.Color.Transparent;
            this.JTButton_Login.BackgroundColor = System.Drawing.Color.White;
            this.JTButton_Login.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.JTButton_Login.BorderRadius = 19;
            this.JTButton_Login.ButtonText = "Login";
            this.JTButton_Login.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTButton_Login.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTButton_Login.ForeColors = System.Drawing.Color.Gray;
            this.JTButton_Login.HoverBackground = System.Drawing.Color.White;
            this.JTButton_Login.HoverBorder = System.Drawing.Color.Empty;
            this.JTButton_Login.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.JTButton_Login.LineThickness = 2;
            this.JTButton_Login.Location = new System.Drawing.Point(79, 239);
            this.JTButton_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JTButton_Login.Name = "JTButton_Login";
            this.JTButton_Login.Size = new System.Drawing.Size(242, 41);
            this.JTButton_Login.TabIndex = 58;
            this.JTButton_Login.Click += new System.EventHandler(this.JTButton_Login_Click);
            // 
            // btnMostrarContra
            // 
            this.btnMostrarContra.BackColor = System.Drawing.Color.White;
            this.btnMostrarContra.BackgroundImage = global::FProjects.Properties.Resources.contrasena;
            this.btnMostrarContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarContra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrarContra.FlatAppearance.BorderSize = 0;
            this.btnMostrarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContra.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.btnMostrarContra.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnMostrarContra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMostrarContra.Location = new System.Drawing.Point(308, 180);
            this.btnMostrarContra.Margin = new System.Windows.Forms.Padding(0);
            this.btnMostrarContra.Name = "btnMostrarContra";
            this.btnMostrarContra.Size = new System.Drawing.Size(17, 20);
            this.btnMostrarContra.TabIndex = 59;
            this.btnMostrarContra.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMostrarContra.UseVisualStyleBackColor = false;
            this.btnMostrarContra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMostrarContra_MouseDown);
            this.btnMostrarContra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMostrarContra_MouseUp);
            // 
            // JMT_ContraMostrar
            // 
            this.JMT_ContraMostrar.BackColor = System.Drawing.Color.Transparent;
            this.JMT_ContraMostrar.BorderColor = System.Drawing.Color.Silver;
            this.JMT_ContraMostrar.BorderRadius = 10;
            this.JMT_ContraMostrar.FillColor = System.Drawing.SystemColors.Window;
            this.JMT_ContraMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_ContraMostrar.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_ContraMostrar.ForeColors = System.Drawing.Color.Gray;
            this.JMT_ContraMostrar.IsPassword = false;
            this.JMT_ContraMostrar.LineThickness = 2;
            this.JMT_ContraMostrar.Location = new System.Drawing.Point(64, 170);
            this.JMT_ContraMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JMT_ContraMostrar.MaxLength = 32767;
            this.JMT_ContraMostrar.MouseOnHover = System.Drawing.Color.Empty;
            this.JMT_ContraMostrar.Name = "JMT_ContraMostrar";
            this.JMT_ContraMostrar.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.JMT_ContraMostrar.OnFocusColor = System.Drawing.Color.Empty;
            this.JMT_ContraMostrar.OnFocusFontColor = System.Drawing.Color.Empty;
            this.JMT_ContraMostrar.ReadOnly = false;
            this.JMT_ContraMostrar.Size = new System.Drawing.Size(273, 36);
            this.JMT_ContraMostrar.TabIndex = 60;
            this.JMT_ContraMostrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JMT_ContraMostrar.TextName = "";
            this.JMT_ContraMostrar.Visible = false;
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FProjects.Properties.Resources.f1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(413, 345);
            this.Controls.Add(this.JMT_ContraMostrar);
            this.Controls.Add(this.btnMostrarContra);
            this.Controls.Add(this.JTButton_Login);
            this.Controls.Add(this.JMT_ContraEsconder);
            this.Controls.Add(this.JMT_txtCorreo);
            this.Controls.Add(this.jImageButton2);
            this.Controls.Add(this.jImageButton1);
            this.Controls.Add(this.lbCambioContra);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRegistrarse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FrmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmInicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Titulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRegistrarse;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Titulo;
        private JImageButton.JImageButton jImageButton2;
        private JImageButton.JImageButton jImageButton1;
        private System.Windows.Forms.Label lbCambioContra;
        private JMetroTextBox.JMetroTextBox JMT_txtCorreo;
        private JMetroTextBox.JMetroTextBox JMT_ContraEsconder;
        private JThinButton.JThinButton JTButton_Login;
        private System.Windows.Forms.Button btnMostrarContra;
        private JMetroTextBox.JMetroTextBox JMT_ContraMostrar;
    }
}