namespace FProjects
{
    partial class FrmPadreDiseñado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPadreDiseñado));
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconTamanoNormal = new FontAwesome.Sharp.IconPictureBox();
            this.lbMiperfil = new System.Windows.Forms.Label();
            this.iconCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.iconMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.iconMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnInicioSesion = new FontAwesome.Sharp.IconButton();
            this.btnProyectos = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxRedondeado1 = new FProjects.PictureBoxRedondeado();
            this.panelBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTamanoNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelFondo.SuspendLayout();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedondeado1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelBotones.Controls.Add(this.panel1);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotones.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panelBotones.Location = new System.Drawing.Point(196, 0);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1208, 66);
            this.panelBotones.TabIndex = 5;
            this.panelBotones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBotones_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxRedondeado1);
            this.panel1.Controls.Add(this.iconTamanoNormal);
            this.panel1.Controls.Add(this.lbMiperfil);
            this.panel1.Controls.Add(this.iconCerrar);
            this.panel1.Controls.Add(this.iconMinimizar);
            this.panel1.Controls.Add(this.iconMaximizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(943, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 66);
            this.panel1.TabIndex = 5;
            // 
            // iconTamanoNormal
            // 
            this.iconTamanoNormal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconTamanoNormal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconTamanoNormal.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconTamanoNormal.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconTamanoNormal.IconSize = 30;
            this.iconTamanoNormal.Location = new System.Drawing.Point(194, 21);
            this.iconTamanoNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconTamanoNormal.Name = "iconTamanoNormal";
            this.iconTamanoNormal.Size = new System.Drawing.Size(30, 30);
            this.iconTamanoNormal.TabIndex = 4;
            this.iconTamanoNormal.TabStop = false;
            this.iconTamanoNormal.Click += new System.EventHandler(this.iconTamanoNormal_Click);
            // 
            // lbMiperfil
            // 
            this.lbMiperfil.AutoSize = true;
            this.lbMiperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiperfil.Location = new System.Drawing.Point(3, 25);
            this.lbMiperfil.Name = "lbMiperfil";
            this.lbMiperfil.Size = new System.Drawing.Size(76, 24);
            this.lbMiperfil.TabIndex = 6;
            this.lbMiperfil.Text = "Mi Perfil";
            this.lbMiperfil.Click += new System.EventHandler(this.lbMiperfil_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconCerrar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconCerrar.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconCerrar.Location = new System.Drawing.Point(231, 18);
            this.iconCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(34, 32);
            this.iconCerrar.TabIndex = 4;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconMinimizar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimizar.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconMinimizar.IconSize = 30;
            this.iconMinimizar.Location = new System.Drawing.Point(158, 16);
            this.iconMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(30, 30);
            this.iconMinimizar.TabIndex = 4;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // iconMaximizar
            // 
            this.iconMaximizar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconMaximizar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMaximizar.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconMaximizar.IconSize = 30;
            this.iconMaximizar.Location = new System.Drawing.Point(194, 21);
            this.iconMaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(30, 30);
            this.iconMaximizar.TabIndex = 0;
            this.iconMaximizar.TabStop = false;
            this.iconMaximizar.Click += new System.EventHandler(this.iconMaximizar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelMenu.Controls.Add(this.btnInicioSesion);
            this.panelMenu.Controls.Add(this.btnProyectos);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.pictureBox6);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(196, 742);
            this.panelMenu.TabIndex = 4;
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInicioSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesion.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnInicioSesion.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnInicioSesion.IconSize = 30;
            this.btnInicioSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicioSesion.Location = new System.Drawing.Point(0, 158);
            this.btnInicioSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnInicioSesion.Rotation = 0D;
            this.btnInicioSesion.Size = new System.Drawing.Size(196, 42);
            this.btnInicioSesion.TabIndex = 55;
            this.btnInicioSesion.Text = "Inicio de Sesión";
            this.btnInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicioSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // btnProyectos
            // 
            this.btnProyectos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProyectos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectos.IconChar = FontAwesome.Sharp.IconChar.ThList;
            this.btnProyectos.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnProyectos.IconSize = 30;
            this.btnProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyectos.Location = new System.Drawing.Point(0, 112);
            this.btnProyectos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnProyectos.Rotation = 0D;
            this.btnProyectos.Size = new System.Drawing.Size(196, 42);
            this.btnProyectos.TabIndex = 54;
            this.btnProyectos.Text = "Proyectos";
            this.btnProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProyectos.UseVisualStyleBackColor = true;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Foursquare;
            this.btnInicio.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnInicio.IconSize = 30;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 66);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnInicio.Rotation = 0D;
            this.btnInicio.Size = new System.Drawing.Size(196, 42);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(196, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 53;
            this.pictureBox6.TabStop = false;
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelFondo.Controls.Add(this.panelInicio);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(196, 66);
            this.panelFondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(1208, 676);
            this.panelFondo.TabIndex = 9;
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.Color.White;
            this.panelInicio.Controls.Add(this.label4);
            this.panelInicio.Controls.Add(this.label2);
            this.panelInicio.Controls.Add(this.label3);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(1208, 676);
            this.panelInicio.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Concurso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Navega por nuestra aplicación y conócela (link)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "¿Qué es FProjects?";
            // 
            // pictureBoxRedondeado1
            // 
            this.pictureBoxRedondeado1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBoxRedondeado1.Image = global::FProjects.Properties.Resources.usuario;
            this.pictureBoxRedondeado1.InitialImage = global::FProjects.Properties.Resources.cooltext353420064755126;
            this.pictureBoxRedondeado1.Location = new System.Drawing.Point(91, 11);
            this.pictureBoxRedondeado1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxRedondeado1.Name = "pictureBoxRedondeado1";
            this.pictureBoxRedondeado1.Size = new System.Drawing.Size(48, 39);
            this.pictureBoxRedondeado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRedondeado1.TabIndex = 7;
            this.pictureBoxRedondeado1.TabStop = false;
            this.pictureBoxRedondeado1.Click += new System.EventHandler(this.lbMiperfil_Click);
            // 
            // FrmPadreDiseñado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1404, 742);
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPadreDiseñado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPadreDiseñado";
            this.Load += new System.EventHandler(this.FrmPadreDiseñado_Load);
            this.panelBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTamanoNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panelFondo.ResumeLayout(false);
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedondeado1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconTamanoNormal;
        private System.Windows.Forms.Label lbMiperfil;
        private FontAwesome.Sharp.IconPictureBox iconCerrar;
        private FontAwesome.Sharp.IconPictureBox iconMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconMaximizar;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnInicioSesion;
        private FontAwesome.Sharp.IconButton btnProyectos;
        private FontAwesome.Sharp.IconButton btnInicio;
        private System.Windows.Forms.PictureBox pictureBox6;
        private PictureBoxRedondeado pictureBoxRedondeado1;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}