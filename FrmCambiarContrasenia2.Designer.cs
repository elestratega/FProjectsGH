namespace FProjects
{
    partial class FrmCambiarContrasenia2
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
            this.JTB_Contras1 = new JMetroTextBox.JMetroTextBox();
            this.JTB_Contras2 = new JMetroTextBox.JMetroTextBox();
            this.JTB_Confirmar = new JThinButton.JThinButton();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // JTB_Contras1
            // 
            this.JTB_Contras1.BackColor = System.Drawing.Color.Transparent;
            this.JTB_Contras1.BorderColor = System.Drawing.Color.Empty;
            this.JTB_Contras1.BorderRadius = 10;
            this.JTB_Contras1.FillColor = System.Drawing.SystemColors.Window;
            this.JTB_Contras1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JTB_Contras1.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JTB_Contras1.ForeColors = System.Drawing.Color.Gray;
            this.JTB_Contras1.IsPassword = false;
            this.JTB_Contras1.LineThickness = 2;
            this.JTB_Contras1.Location = new System.Drawing.Point(19, 80);
            this.JTB_Contras1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JTB_Contras1.MaxLength = 32767;
            this.JTB_Contras1.MouseOnHover = System.Drawing.Color.Empty;
            this.JTB_Contras1.Name = "JTB_Contras1";
            this.JTB_Contras1.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.JTB_Contras1.OnFocusColor = System.Drawing.Color.Empty;
            this.JTB_Contras1.OnFocusFontColor = System.Drawing.Color.Empty;
            this.JTB_Contras1.ReadOnly = false;
            this.JTB_Contras1.Size = new System.Drawing.Size(224, 32);
            this.JTB_Contras1.TabIndex = 0;
            this.JTB_Contras1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JTB_Contras1.TextName = "Contraseña";
            this.JTB_Contras1.Enter += new System.EventHandler(this.JTB_Contras1_Enter);
            this.JTB_Contras1.Leave += new System.EventHandler(this.JTB_Contras1_Leave);
            // 
            // JTB_Contras2
            // 
            this.JTB_Contras2.BackColor = System.Drawing.Color.Transparent;
            this.JTB_Contras2.BorderColor = System.Drawing.Color.Empty;
            this.JTB_Contras2.BorderRadius = 10;
            this.JTB_Contras2.FillColor = System.Drawing.SystemColors.Window;
            this.JTB_Contras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JTB_Contras2.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.JTB_Contras2.ForeColors = System.Drawing.Color.Gray;
            this.JTB_Contras2.IsPassword = false;
            this.JTB_Contras2.LineThickness = 2;
            this.JTB_Contras2.Location = new System.Drawing.Point(19, 141);
            this.JTB_Contras2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JTB_Contras2.MaxLength = 32767;
            this.JTB_Contras2.MouseOnHover = System.Drawing.Color.Empty;
            this.JTB_Contras2.Name = "JTB_Contras2";
            this.JTB_Contras2.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.JTB_Contras2.OnFocusColor = System.Drawing.Color.Empty;
            this.JTB_Contras2.OnFocusFontColor = System.Drawing.Color.Empty;
            this.JTB_Contras2.ReadOnly = false;
            this.JTB_Contras2.Size = new System.Drawing.Size(224, 33);
            this.JTB_Contras2.TabIndex = 1;
            this.JTB_Contras2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JTB_Contras2.TextName = "Repetir Contraseña";
            this.JTB_Contras2.Enter += new System.EventHandler(this.JTB_Contras2_Enter);
            this.JTB_Contras2.Leave += new System.EventHandler(this.JTB_Contras2_Leave);
            // 
            // JTB_Confirmar
            // 
            this.JTB_Confirmar.BackColor = System.Drawing.Color.Transparent;
            this.JTB_Confirmar.BackgroundColor = System.Drawing.Color.White;
            this.JTB_Confirmar.BorderColor = System.Drawing.SystemColors.Highlight;
            this.JTB_Confirmar.BorderRadius = 17;
            this.JTB_Confirmar.ButtonText = "Cambiar Contraseña";
            this.JTB_Confirmar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTB_Confirmar.Font_Size = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTB_Confirmar.ForeColors = System.Drawing.SystemColors.Highlight;
            this.JTB_Confirmar.HoverBackground = System.Drawing.Color.White;
            this.JTB_Confirmar.HoverBorder = System.Drawing.Color.Empty;
            this.JTB_Confirmar.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.JTB_Confirmar.LineThickness = 2;
            this.JTB_Confirmar.Location = new System.Drawing.Point(34, 201);
            this.JTB_Confirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.JTB_Confirmar.Name = "JTB_Confirmar";
            this.JTB_Confirmar.Size = new System.Drawing.Size(194, 37);
            this.JTB_Confirmar.TabIndex = 2;
            this.JTB_Confirmar.Click += new System.EventHandler(this.jThinButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 23);
            this.label2.TabIndex = 76;
            this.label2.Text = "Esta a punto de cambiar su contraseña";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmCambiarContrasenia2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FProjects.Properties.Resources.m7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(273, 275);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JTB_Confirmar);
            this.Controls.Add(this.JTB_Contras2);
            this.Controls.Add(this.JTB_Contras1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCambiarContrasenia2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCambiarContrasenia2";
            this.Load += new System.EventHandler(this.FrmCambiarContrasenia2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JMetroTextBox.JMetroTextBox JTB_Contras1;
        private JMetroTextBox.JMetroTextBox JTB_Contras2;
        private JThinButton.JThinButton JTB_Confirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}