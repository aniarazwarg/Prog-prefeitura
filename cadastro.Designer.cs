namespace projetop2ds3
{
    partial class cadastro
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
            this.txNm_cad = new System.Windows.Forms.TextBox();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.cad_NB = new System.Windows.Forms.RadioButton();
            this.cad_masc = new System.Windows.Forms.RadioButton();
            this.cad_fem = new System.Windows.Forms.RadioButton();
            this.lbgend = new System.Windows.Forms.Label();
            this.tx_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_insc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txNm_cad
            // 
            this.txNm_cad.Location = new System.Drawing.Point(269, 72);
            this.txNm_cad.Name = "txNm_cad";
            this.txNm_cad.Size = new System.Drawing.Size(327, 20);
            this.txNm_cad.TabIndex = 9;
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome.Location = new System.Drawing.Point(208, 72);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(55, 20);
            this.lb_Nome.TabIndex = 8;
            this.lb_Nome.Text = "Nome:";
            // 
            // cad_NB
            // 
            this.cad_NB.AutoSize = true;
            this.cad_NB.Location = new System.Drawing.Point(480, 145);
            this.cad_NB.Name = "cad_NB";
            this.cad_NB.Size = new System.Drawing.Size(56, 17);
            this.cad_NB.TabIndex = 21;
            this.cad_NB.TabStop = true;
            this.cad_NB.Text = "Outros";
            this.cad_NB.UseVisualStyleBackColor = true;
            this.cad_NB.CheckedChanged += new System.EventHandler(this.cad_NB_CheckedChanged);
            // 
            // cad_masc
            // 
            this.cad_masc.AutoSize = true;
            this.cad_masc.Location = new System.Drawing.Point(401, 145);
            this.cad_masc.Name = "cad_masc";
            this.cad_masc.Size = new System.Drawing.Size(73, 17);
            this.cad_masc.TabIndex = 20;
            this.cad_masc.TabStop = true;
            this.cad_masc.Text = "Masculino";
            this.cad_masc.UseVisualStyleBackColor = true;
            // 
            // cad_fem
            // 
            this.cad_fem.AutoSize = true;
            this.cad_fem.Location = new System.Drawing.Point(313, 145);
            this.cad_fem.Name = "cad_fem";
            this.cad_fem.Size = new System.Drawing.Size(67, 17);
            this.cad_fem.TabIndex = 19;
            this.cad_fem.TabStop = true;
            this.cad_fem.Text = "Feminino";
            this.cad_fem.UseVisualStyleBackColor = true;
            this.cad_fem.CheckedChanged += new System.EventHandler(this.cad_fem_CheckedChanged);
            // 
            // lbgend
            // 
            this.lbgend.AutoSize = true;
            this.lbgend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgend.Location = new System.Drawing.Point(235, 142);
            this.lbgend.Name = "lbgend";
            this.lbgend.Size = new System.Drawing.Size(67, 20);
            this.lbgend.TabIndex = 18;
            this.lbgend.Text = "Gênero:";
            // 
            // tx_login
            // 
            this.tx_login.Location = new System.Drawing.Point(267, 215);
            this.tx_login.Name = "tx_login";
            this.tx_login.Size = new System.Drawing.Size(327, 20);
            this.tx_login.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Login:";
            // 
            // tx_senha
            // 
            this.tx_senha.Location = new System.Drawing.Point(269, 266);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.Size = new System.Drawing.Size(327, 20);
            this.tx_senha.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Senha:";
            // 
            // bt_insc
            // 
            this.bt_insc.Location = new System.Drawing.Point(338, 329);
            this.bt_insc.Name = "bt_insc";
            this.bt_insc.Size = new System.Drawing.Size(150, 33);
            this.bt_insc.TabIndex = 30;
            this.bt_insc.Text = "cadastrar";
            this.bt_insc.UseVisualStyleBackColor = true;
            this.bt_insc.Click += new System.EventHandler(this.bt_insc_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_insc);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cad_NB);
            this.Controls.Add(this.cad_masc);
            this.Controls.Add(this.cad_fem);
            this.Controls.Add(this.lbgend);
            this.Controls.Add(this.txNm_cad);
            this.Controls.Add(this.lb_Nome);
            this.Name = "cadastro";
            this.Text = "cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNm_cad;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.RadioButton cad_NB;
        private System.Windows.Forms.RadioButton cad_masc;
        private System.Windows.Forms.RadioButton cad_fem;
        private System.Windows.Forms.Label lbgend;
        private System.Windows.Forms.TextBox tx_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_insc;
    }
}