namespace projetop2ds3
{
    partial class FormHome
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
            this.lbhome = new System.Windows.Forms.Label();
            this.bt_msg = new System.Windows.Forms.Button();
            this.bt_atv = new System.Windows.Forms.Button();
            this.bt_insc = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbhome
            // 
            this.lbhome.AutoSize = true;
            this.lbhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhome.Location = new System.Drawing.Point(321, 107);
            this.lbhome.Name = "lbhome";
            this.lbhome.Size = new System.Drawing.Size(158, 31);
            this.lbhome.TabIndex = 0;
            this.lbhome.Text = "Saudações!";
            this.lbhome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbhome.Click += new System.EventHandler(this.lbhome_Click);
            // 
            // bt_msg
            // 
            this.bt_msg.Location = new System.Drawing.Point(487, 181);
            this.bt_msg.Name = "bt_msg";
            this.bt_msg.Size = new System.Drawing.Size(98, 88);
            this.bt_msg.TabIndex = 1;
            this.bt_msg.Text = "Mensagem";
            this.bt_msg.UseVisualStyleBackColor = true;
            this.bt_msg.Click += new System.EventHandler(this.bt_msg_Click);
            // 
            // bt_atv
            // 
            this.bt_atv.Location = new System.Drawing.Point(215, 181);
            this.bt_atv.Name = "bt_atv";
            this.bt_atv.Size = new System.Drawing.Size(98, 88);
            this.bt_atv.TabIndex = 2;
            this.bt_atv.Text = "Atividades";
            this.bt_atv.UseVisualStyleBackColor = true;
            this.bt_atv.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_insc
            // 
            this.bt_insc.Location = new System.Drawing.Point(351, 181);
            this.bt_insc.Name = "bt_insc";
            this.bt_insc.Size = new System.Drawing.Size(98, 88);
            this.bt_insc.TabIndex = 3;
            this.bt_insc.Text = "Inscrição";
            this.bt_insc.UseVisualStyleBackColor = true;
            this.bt_insc.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(669, 406);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(119, 32);
            this.bt_sair.TabIndex = 4;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividadesToolStripMenuItem,
            this.inscriçãoToolStripMenuItem,
            this.mensagemToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.admToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atividadesToolStripMenuItem
            // 
            this.atividadesToolStripMenuItem.Name = "atividadesToolStripMenuItem";
            this.atividadesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.atividadesToolStripMenuItem.Text = "Atividades";
            this.atividadesToolStripMenuItem.Click += new System.EventHandler(this.atividadesToolStripMenuItem_Click);
            // 
            // inscriçãoToolStripMenuItem
            // 
            this.inscriçãoToolStripMenuItem.Name = "inscriçãoToolStripMenuItem";
            this.inscriçãoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.inscriçãoToolStripMenuItem.Text = "Inscrição";
            this.inscriçãoToolStripMenuItem.Click += new System.EventHandler(this.inscriçãoToolStripMenuItem_Click);
            // 
            // mensagemToolStripMenuItem
            // 
            this.mensagemToolStripMenuItem.Name = "mensagemToolStripMenuItem";
            this.mensagemToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.mensagemToolStripMenuItem.Text = "Mensagem";
            this.mensagemToolStripMenuItem.Click += new System.EventHandler(this.mensagemToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // admToolStripMenuItem
            // 
            this.admToolStripMenuItem.Name = "admToolStripMenuItem";
            this.admToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.admToolStripMenuItem.Text = "adm";
            this.admToolStripMenuItem.Click += new System.EventHandler(this.admToolStripMenuItem_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_insc);
            this.Controls.Add(this.bt_atv);
            this.Controls.Add(this.bt_msg);
            this.Controls.Add(this.lbhome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbhome;
        private System.Windows.Forms.Button bt_msg;
        private System.Windows.Forms.Button bt_atv;
        private System.Windows.Forms.Button bt_insc;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admToolStripMenuItem;
    }
}