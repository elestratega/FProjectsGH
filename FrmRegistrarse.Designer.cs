namespace FProjects
{
    partial class FrmRegistrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarse));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.JMT_Correo = new JMetroTextBox.JMetroTextBox();
            this.JMT_Nombre = new JMetroTextBox.JMetroTextBox();
            this.JMT_Contra = new JMetroTextBox.JMetroTextBox();
            this.JMT_RepetirContra = new JMetroTextBox.JMetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JTButton_Confirmar = new JThinButton.JThinButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbInicioSesion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(83, 14);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(295, 78);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 50;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // JMT_Correo
            // 
            this.JMT_Correo.BackColor = System.Drawing.Color.Transparent;
            this.JMT_Correo.BorderColor = System.Drawing.Color.Silver;
            this.JMT_Correo.BorderRadius = 10;
            this.JMT_Correo.FillColor = System.Drawing.SystemColors.Window;
            this.JMT_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_Correo.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_Correo.ForeColors = System.Drawing.Color.Gray;
            this.JMT_Correo.IsPassword = false;
            this.JMT_Correo.LineThickness = 2;
            this.JMT_Correo.Location = new System.Drawing.Point(59, 194);
            this.JMT_Correo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.JMT_Correo.MaxLength = 32767;
            this.JMT_Correo.MouseOnHover = System.Drawing.Color.Empty;
            this.JMT_Correo.Name = "JMT_Correo";
            this.JMT_Correo.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.JMT_Correo.OnFocusColor = System.Drawing.Color.Empty;
            this.JMT_Correo.OnFocusFontColor = System.Drawing.Color.Empty;
            this.JMT_Correo.ReadOnly = false;
            this.JMT_Correo.Size = new System.Drawing.Size(348, 48);
            this.JMT_Correo.TabIndex = 65;
            this.JMT_Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JMT_Correo.TextName = "Correo Electrónico";
            this.JMT_Correo.Enter += new System.EventHandler(this.JMT_Correo_Enter);
            this.JMT_Correo.Leave += new System.EventHandler(this.JMT_Correo_Leave);
            // 
            // JMT_Nombre
            // 
            this.JMT_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.JMT_Nombre.BorderColor = System.Drawing.Color.Silver;
            this.JMT_Nombre.BorderRadius = 10;
            this.JMT_Nombre.FillColor = System.Drawing.SystemColors.Window;
            this.JMT_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_Nombre.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_Nombre.ForeColors = System.Drawing.Color.Gray;
            this.JMT_Nombre.IsPassword = false;
            this.JMT_Nombre.LineThickness = 2;
            this.JMT_Nombre.Location = new System.Drawing.Point(59, 126);
            this.JMT_Nombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.JMT_Nombre.MaxLength = 32767;
            this.JMT_Nombre.MouseOnHover = System.Drawing.Color.Empty;
            this.JMT_Nombre.Name = "JMT_Nombre";
            this.JMT_Nombre.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.JMT_Nombre.OnFocusColor = System.Drawing.Color.Empty;
            this.JMT_Nombre.OnFocusFontColor = System.Drawing.Color.Empty;
            this.JMT_Nombre.ReadOnly = false;
            this.JMT_Nombre.Size = new System.Drawing.Size(348, 48);
            this.JMT_Nombre.TabIndex = 66;
            this.JMT_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JMT_Nombre.TextName = "Nombre de Usuario";
            this.JMT_Nombre.Enter += new System.EventHandler(this.JMT_Nombre_Enter);
            this.JMT_Nombre.Leave += new System.EventHandler(this.JMT_Nombre_Leave);
            // 
            // JMT_Contra
            // 
            this.JMT_Contra.BackColor = System.Drawing.Color.Transparent;
            this.JMT_Contra.BorderColor = System.Drawing.Color.Silver;
            this.JMT_Contra.BorderRadius = 10;
            this.JMT_Contra.FillColor = System.Drawing.SystemColors.Window;
            this.JMT_Contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_Contra.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_Contra.ForeColors = System.Drawing.Color.Gray;
            this.JMT_Contra.IsPassword = false;
            this.JMT_Contra.LineThickness = 2;
            this.JMT_Contra.Location = new System.Drawing.Point(59, 266);
            this.JMT_Contra.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.JMT_Contra.MaxLength = 32767;
            this.JMT_Contra.MouseOnHover = System.Drawing.Color.Empty;
            this.JMT_Contra.Name = "JMT_Contra";
            this.JMT_Contra.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.JMT_Contra.OnFocusColor = System.Drawing.Color.Empty;
            this.JMT_Contra.OnFocusFontColor = System.Drawing.Color.Empty;
            this.JMT_Contra.ReadOnly = false;
            this.JMT_Contra.Size = new System.Drawing.Size(348, 48);
            this.JMT_Contra.TabIndex = 67;
            this.JMT_Contra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JMT_Contra.TextName = "Contraseña";
            this.JMT_Contra.Enter += new System.EventHandler(this.JMT_Contra_Enter);
            this.JMT_Contra.Leave += new System.EventHandler(this.JMT_Contra_Leave);
            // 
            // JMT_RepetirContra
            // 
            this.JMT_RepetirContra.BackColor = System.Drawing.Color.Transparent;
            this.JMT_RepetirContra.BorderColor = System.Drawing.Color.Silver;
            this.JMT_RepetirContra.BorderRadius = 10;
            this.JMT_RepetirContra.FillColor = System.Drawing.SystemColors.Window;
            this.JMT_RepetirContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_RepetirContra.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JMT_RepetirContra.ForeColors = System.Drawing.Color.Gray;
            this.JMT_RepetirContra.IsPassword = false;
            this.JMT_RepetirContra.LineThickness = 2;
            this.JMT_RepetirContra.Location = new System.Drawing.Point(59, 337);
            this.JMT_RepetirContra.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.JMT_RepetirContra.MaxLength = 32767;
            this.JMT_RepetirContra.MouseOnHover = System.Drawing.Color.Empty;
            this.JMT_RepetirContra.Name = "JMT_RepetirContra";
            this.JMT_RepetirContra.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.JMT_RepetirContra.OnFocusColor = System.Drawing.Color.Empty;
            this.JMT_RepetirContra.OnFocusFontColor = System.Drawing.Color.Empty;
            this.JMT_RepetirContra.ReadOnly = false;
            this.JMT_RepetirContra.Size = new System.Drawing.Size(348, 48);
            this.JMT_RepetirContra.TabIndex = 68;
            this.JMT_RepetirContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JMT_RepetirContra.TextName = "Repetir Contraseña";
            this.JMT_RepetirContra.Enter += new System.EventHandler(this.JMT_RepetirContra_Enter);
            this.JMT_RepetirContra.Leave += new System.EventHandler(this.JMT_RepetirContra_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(69, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 69;
            this.label1.Text = "Registrate";
            // 
            // JTButton_Confirmar
            // 
            this.JTButton_Confirmar.BackColor = System.Drawing.Color.Transparent;
            this.JTButton_Confirmar.BackgroundColor = System.Drawing.Color.White;
            this.JTButton_Confirmar.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.JTButton_Confirmar.BorderRadius = 19;
            this.JTButton_Confirmar.ButtonText = "Registrarse";
            this.JTButton_Confirmar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTButton_Confirmar.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTButton_Confirmar.ForeColors = System.Drawing.Color.Gray;
            this.JTButton_Confirmar.HoverBackground = System.Drawing.Color.White;
            this.JTButton_Confirmar.HoverBorder = System.Drawing.Color.Empty;
            this.JTButton_Confirmar.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.JTButton_Confirmar.LineThickness = 2;
            this.JTButton_Confirmar.Location = new System.Drawing.Point(75, 407);
            this.JTButton_Confirmar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.JTButton_Confirmar.Name = "JTButton_Confirmar";
            this.JTButton_Confirmar.Size = new System.Drawing.Size(323, 50);
            this.JTButton_Confirmar.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 485);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 29);
            this.label2.TabIndex = 70;
            this.label2.Text = "¿Tienes una cuenta de FProjects?";
            // 
            // lbInicioSesion
            // 
            this.lbInicioSesion.AutoSize = true;
            this.lbInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.lbInicioSesion.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.lbInicioSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbInicioSesion.Location = new System.Drawing.Point(327, 485);
            this.lbInicioSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInicioSesion.Name = "lbInicioSesion";
            this.lbInicioSesion.Size = new System.Drawing.Size(123, 29);
            this.lbInicioSesion.TabIndex = 71;
            this.lbInicioSesion.Text = "Iniciar Sesion";
            this.lbInicioSesion.Click += new System.EventHandler(this.lbInicioSesion_Click);
            // 
            // FrmRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FProjects.Properties.Resources.m4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 543);
            this.Controls.Add(this.JTButton_Confirmar);
            this.Controls.Add(this.lbInicioSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JMT_RepetirContra);
            this.Controls.Add(this.JMT_Contra);
            this.Controls.Add(this.JMT_Nombre);
            this.Controls.Add(this.JMT_Correo);
            this.Controls.Add(this.pictureBox6);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRegistrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistrarse";
            this.Load += new System.EventHandler(this.FrmRegistrarse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private JMetroTextBox.JMetroTextBox JMT_Nombre;
        private JMetroTextBox.JMetroTextBox JMT_Correo;
        private JMetroTextBox.JMetroTextBox JMT_RepetirContra;
        private JMetroTextBox.JMetroTextBox JMT_Contra;
        private System.Windows.Forms.Label label1;
        private JThinButton.JThinButton JTButton_Confirmar;
        private System.Windows.Forms.Label lbInicioSesion;
        private System.Windows.Forms.Label label2;
    }
}