namespace GPSFrancisco
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnVoluntarios = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btUusuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoluntarios
            // 
            this.btnVoluntarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoluntarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoluntarios.Image = ((System.Drawing.Image)(resources.GetObject("btnVoluntarios.Image")));
            this.btnVoluntarios.Location = new System.Drawing.Point(24, 11);
            this.btnVoluntarios.Name = "btnVoluntarios";
            this.btnVoluntarios.Size = new System.Drawing.Size(154, 222);
            this.btnVoluntarios.TabIndex = 0;
            this.btnVoluntarios.Text = "V&oluntários";
            this.btnVoluntarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoluntarios.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(686, 503);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 46);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btUusuarios
            // 
            this.btUusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUusuarios.Image = ((System.Drawing.Image)(resources.GetObject("btUusuarios.Image")));
            this.btUusuarios.Location = new System.Drawing.Point(197, 11);
            this.btUusuarios.Name = "btUusuarios";
            this.btUusuarios.Size = new System.Drawing.Size(154, 222);
            this.btUusuarios.TabIndex = 2;
            this.btUusuarios.Text = "&Usuários";
            this.btUusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btUusuarios.UseVisualStyleBackColor = true;
            this.btUusuarios.Click += new System.EventHandler(this.btUusuarios_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btUusuarios);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVoluntarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPSFrancisco - Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoluntarios;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btUusuarios;
    }
}