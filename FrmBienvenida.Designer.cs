namespace FProjects
{
    partial class FrmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBienvenida));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerAparecer = new System.Windows.Forms.Timer(this.components);
            this.timerDesvanecer = new System.Windows.Forms.Timer(this.components);
            this.circuloProgreso = new CircularProgressBar.CircularProgressBar();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(35, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(332, 97);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 52;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-30, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(425, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // timerAparecer
            // 
            this.timerAparecer.Interval = 40;
            this.timerAparecer.Tick += new System.EventHandler(this.timerAparecer_Tick);
            // 
            // timerDesvanecer
            // 
            this.timerDesvanecer.Interval = 40;
            this.timerDesvanecer.Tick += new System.EventHandler(this.timerDesvanecer_Tick);
            // 
            // circuloProgreso
            // 
            this.circuloProgreso.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circuloProgreso.AnimationSpeed = 500;
            this.circuloProgreso.BackColor = System.Drawing.Color.Transparent;
            this.circuloProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuloProgreso.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.circuloProgreso.InnerColor = System.Drawing.SystemColors.MenuHighlight;
            this.circuloProgreso.InnerMargin = 5;
            this.circuloProgreso.InnerWidth = -1;
            this.circuloProgreso.Location = new System.Drawing.Point(579, 244);
            this.circuloProgreso.MarqueeAnimationSpeed = 2000;
            this.circuloProgreso.Name = "circuloProgreso";
            this.circuloProgreso.OuterColor = System.Drawing.Color.LightSkyBlue;
            this.circuloProgreso.OuterMargin = -40;
            this.circuloProgreso.OuterWidth = 20;
            this.circuloProgreso.ProgressColor = System.Drawing.Color.Navy;
            this.circuloProgreso.ProgressWidth = 25;
            this.circuloProgreso.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.circuloProgreso.Size = new System.Drawing.Size(248, 229);
            this.circuloProgreso.StartAngle = 270;
            this.circuloProgreso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circuloProgreso.SubscriptColor = System.Drawing.Color.LightSkyBlue;
            this.circuloProgreso.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circuloProgreso.SubscriptText = "";
            this.circuloProgreso.SuperscriptColor = System.Drawing.Color.LightSkyBlue;
            this.circuloProgreso.SuperscriptMargin = new System.Windows.Forms.Padding(10, 40, 0, 0);
            this.circuloProgreso.SuperscriptText = "%";
            this.circuloProgreso.TabIndex = 4;
            this.circuloProgreso.Text = "0";
            this.circuloProgreso.TextMargin = new System.Windows.Forms.Padding(5, 4, 20, 0);
            this.circuloProgreso.Value = 68;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbUsuario.Location = new System.Drawing.Point(443, 184);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(137, 30);
            this.lbUsuario.TabIndex = 3;
            this.lbUsuario.Text = "UserName";
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.circuloProgreso);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBienvenida";
            this.Load += new System.EventHandler(this.FrmBienvenida_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerAparecer;
        private System.Windows.Forms.Timer timerDesvanecer;
        private CircularProgressBar.CircularProgressBar circuloProgreso;
        private System.Windows.Forms.Label lbUsuario;
    }
}