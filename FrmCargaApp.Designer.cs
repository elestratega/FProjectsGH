namespace FProjects
{
    partial class FrmCargaApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCargaI = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timerAparecer = new System.Windows.Forms.Timer(this.components);
            this.timerDesvanecer = new System.Windows.Forms.Timer(this.components);
            this.panelCargaD = new System.Windows.Forms.Panel();
            this.lbCargando = new System.Windows.Forms.Label();
            this.lbConectando = new System.Windows.Forms.Label();
            this.lbIniciando = new System.Windows.Forms.Label();
            this.timerReintentarConex = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelCargaI);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 333);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 21);
            this.panel1.TabIndex = 54;
            // 
            // panelCargaI
            // 
            this.panelCargaI.BackColor = System.Drawing.Color.Black;
            this.panelCargaI.Location = new System.Drawing.Point(0, 0);
            this.panelCargaI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCargaI.Name = "panelCargaI";
            this.panelCargaI.Size = new System.Drawing.Size(73, 21);
            this.panelCargaI.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 21);
            this.panel2.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(777, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(23, 350);
            this.panel3.TabIndex = 57;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 21);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 312);
            this.panel4.TabIndex = 58;
            // 
            // timerAparecer
            // 
            this.timerAparecer.Interval = 1;
            this.timerAparecer.Tick += new System.EventHandler(this.timerAparecer_Tick);
            // 
            // timerDesvanecer
            // 
            this.timerDesvanecer.Interval = 1;
            this.timerDesvanecer.Tick += new System.EventHandler(this.timerDesvanecer_Tick);
            // 
            // panelCargaD
            // 
            this.panelCargaD.BackColor = System.Drawing.Color.Black;
            this.panelCargaD.Location = new System.Drawing.Point(741, 333);
            this.panelCargaD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCargaD.Name = "panelCargaD";
            this.panelCargaD.Size = new System.Drawing.Size(59, 21);
            this.panelCargaD.TabIndex = 60;
            // 
            // lbCargando
            // 
            this.lbCargando.AutoSize = true;
            this.lbCargando.BackColor = System.Drawing.Color.Transparent;
            this.lbCargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCargando.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbCargando.Location = new System.Drawing.Point(663, 303);
            this.lbCargando.Name = "lbCargando";
            this.lbCargando.Size = new System.Drawing.Size(93, 20);
            this.lbCargando.TabIndex = 61;
            this.lbCargando.Text = "Cargando...";
            this.lbCargando.Visible = false;
            // 
            // lbConectando
            // 
            this.lbConectando.AutoSize = true;
            this.lbConectando.BackColor = System.Drawing.Color.Transparent;
            this.lbConectando.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbConectando.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbConectando.Location = new System.Drawing.Point(515, 303);
            this.lbConectando.Name = "lbConectando";
            this.lbConectando.Size = new System.Drawing.Size(225, 20);
            this.lbConectando.TabIndex = 62;
            this.lbConectando.Text = "Conectando con el servidor...";
            this.lbConectando.Visible = false;
            // 
            // lbIniciando
            // 
            this.lbIniciando.AutoSize = true;
            this.lbIniciando.BackColor = System.Drawing.Color.Transparent;
            this.lbIniciando.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIniciando.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbIniciando.Location = new System.Drawing.Point(587, 303);
            this.lbIniciando.Name = "lbIniciando";
            this.lbIniciando.Size = new System.Drawing.Size(164, 20);
            this.lbIniciando.TabIndex = 63;
            this.lbIniciando.Text = "Iniciando FProjects...";
            this.lbIniciando.Visible = false;
            // 
            // timerReintentarConex
            // 
            this.timerReintentarConex.Interval = 2000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(311, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 64;
            this.label1.Text = "FProjects";
            // 
            // FrmCargaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FProjects.Properties.Resources._3293322;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbIniciando);
            this.Controls.Add(this.lbConectando);
            this.Controls.Add(this.lbCargando);
            this.Controls.Add(this.panelCargaD);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCargaApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCargaApp";
            this.Load += new System.EventHandler(this.FrmCargaApp_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelCargaI;
        private System.Windows.Forms.Timer timerAparecer;
        private System.Windows.Forms.Timer timerDesvanecer;
        private System.Windows.Forms.Panel panelCargaD;
        private System.Windows.Forms.Label lbCargando;
        private System.Windows.Forms.Label lbConectando;
        private System.Windows.Forms.Label lbIniciando;
        private System.Windows.Forms.Timer timerReintentarConex;
        private System.Windows.Forms.Label label1;
    }
}