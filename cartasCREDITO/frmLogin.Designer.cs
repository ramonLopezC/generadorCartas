namespace cartasCREDITO
{
    partial class frmLogin
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.indicador = new Infragistics.Win.UltraActivityIndicator.UltraActivityIndicator();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.info = new Infragistics.Win.Misc.UltraLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // indicador
            // 
            this.indicador.AnimationEnabled = true;
            this.indicador.AnimationSpeed = 10;
            this.indicador.CausesValidation = true;
            this.indicador.Dock = System.Windows.Forms.DockStyle.Top;
            this.indicador.Location = new System.Drawing.Point(0, 0);
            this.indicador.Name = "indicador";
            this.indicador.Size = new System.Drawing.Size(284, 23);
            this.indicador.TabIndex = 0;
            this.indicador.TabStop = true;
            this.indicador.ViewStyle = Infragistics.Win.UltraActivityIndicator.ActivityIndicatorViewStyle.Aero;
            // 
            // ultraLabel1
            // 
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            appearance1.BackColor2 = System.Drawing.Color.DodgerBlue;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal;
            appearance1.ForeColor = System.Drawing.Color.DarkOrange;
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.ultraLabel1.Appearance = appearance1;
            this.ultraLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraLabel1.Font = new System.Drawing.Font("Rockwell Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(0, 23);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(284, 26);
            this.ultraLabel1.TabIndex = 2;
            this.ultraLabel1.Text = "CARGANDO DATOS";
            // 
            // info
            // 
            appearance2.ForeColor = System.Drawing.Color.Green;
            appearance2.TextHAlignAsString = "Center";
            appearance2.TextVAlignAsString = "Bottom";
            this.info.Appearance = appearance2;
            this.info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(0, 49);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(284, 18);
            this.info.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 67);
            this.Controls.Add(this.info);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.indicador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraActivityIndicator.UltraActivityIndicator indicador;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel info;
        private System.Windows.Forms.Timer timer1;
    }
}