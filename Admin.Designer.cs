namespace projetop2ds3
{
    partial class form_adm
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
            this.dataGridViewAdm = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdm
            // 
            this.dataGridViewAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdm.Location = new System.Drawing.Point(12, 11);
            this.dataGridViewAdm.Name = "dataGridViewAdm";
            this.dataGridViewAdm.Size = new System.Drawing.Size(774, 351);
            this.dataGridViewAdm.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // form_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewAdm);
            this.Name = "form_adm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.form_adm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdm;
        private System.Windows.Forms.Button button1;
    }
}