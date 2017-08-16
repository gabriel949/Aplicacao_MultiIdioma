namespace App_Multi_Idioma
{
    partial class frmMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMI));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pctBR = new System.Windows.Forms.PictureBox();
            this.pctGB = new System.Windows.Forms.PictureBox();
            this.pctFR = new System.Windows.Forms.PictureBox();
            this.lblBR = new System.Windows.Forms.Label();
            this.lblFR = new System.Windows.Forms.Label();
            this.lblGB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.Name = "lblNome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblEndereço
            // 
            resources.ApplyResources(this.lblEndereço, "lblEndereço");
            this.lblEndereço.Name = "lblEndereço";
            // 
            // lblTelefone
            // 
            resources.ApplyResources(this.lblTelefone, "lblTelefone");
            this.lblTelefone.Name = "lblTelefone";
            // 
            // txtNome
            // 
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            // 
            // txtTelefone
            // 
            resources.ApplyResources(this.txtTelefone, "txtTelefone");
            this.txtTelefone.Name = "txtTelefone";
            // 
            // txtEndereço
            // 
            resources.ApplyResources(this.txtEndereço, "txtEndereço");
            this.txtEndereço.Name = "txtEndereço";
            // 
            // btnEnviar
            // 
            resources.ApplyResources(this.btnEnviar, "btnEnviar");
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // pctBR
            // 
            resources.ApplyResources(this.pctBR, "pctBR");
            this.pctBR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pctBR.Name = "pctBR";
            this.pctBR.TabStop = false;
            this.pctBR.Click += new System.EventHandler(this.pctBR_Click);
            // 
            // pctGB
            // 
            resources.ApplyResources(this.pctGB, "pctGB");
            this.pctGB.BackColor = System.Drawing.Color.Blue;
            this.pctGB.Name = "pctGB";
            this.pctGB.TabStop = false;
            this.pctGB.Click += new System.EventHandler(this.pctGB_Click);
            // 
            // pctFR
            // 
            resources.ApplyResources(this.pctFR, "pctFR");
            this.pctFR.BackColor = System.Drawing.Color.Red;
            this.pctFR.Name = "pctFR";
            this.pctFR.TabStop = false;
            this.pctFR.Click += new System.EventHandler(this.pctFR_Click);
            // 
            // lblBR
            // 
            resources.ApplyResources(this.lblBR, "lblBR");
            this.lblBR.Name = "lblBR";
            // 
            // lblFR
            // 
            resources.ApplyResources(this.lblFR, "lblFR");
            this.lblFR.Name = "lblFR";
            // 
            // lblGB
            // 
            resources.ApplyResources(this.lblGB, "lblGB");
            this.lblGB.Name = "lblGB";
            // 
            // frmMI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblGB);
            this.Controls.Add(this.lblFR);
            this.Controls.Add(this.lblBR);
            this.Controls.Add(this.pctFR);
            this.Controls.Add(this.pctGB);
            this.Controls.Add(this.pctBR);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.lblNome);
            this.Name = "frmMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.PictureBox pctBR;
        private System.Windows.Forms.PictureBox pctGB;
        private System.Windows.Forms.PictureBox pctFR;
        private System.Windows.Forms.Label lblBR;
        private System.Windows.Forms.Label lblFR;
        private System.Windows.Forms.Label lblGB;
    }
}

