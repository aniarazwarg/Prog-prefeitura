namespace projetop2ds3
{
    partial class form_msg
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
            this.email_ms = new System.Windows.Forms.Label();
            this.tx_ms_email = new System.Windows.Forms.TextBox();
            this.tx_ms_nome = new System.Windows.Forms.TextBox();
            this.nome_ms = new System.Windows.Forms.Label();
            this.msg_ms = new System.Windows.Forms.Label();
            this.tx_msg = new System.Windows.Forms.TextBox();
            this.bt_enviar_ms = new System.Windows.Forms.Button();
            this.txbox_msg = new System.Windows.Forms.TextBox();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email_ms
            // 
            this.email_ms.AutoSize = true;
            this.email_ms.Location = new System.Drawing.Point(26, 136);
            this.email_ms.Name = "email_ms";
            this.email_ms.Size = new System.Drawing.Size(38, 13);
            this.email_ms.TabIndex = 0;
            this.email_ms.Text = "E-mail:";
            // 
            // tx_ms_email
            // 
            this.tx_ms_email.Location = new System.Drawing.Point(23, 162);
            this.tx_ms_email.Name = "tx_ms_email";
            this.tx_ms_email.Size = new System.Drawing.Size(268, 20);
            this.tx_ms_email.TabIndex = 1;
            // 
            // tx_ms_nome
            // 
            this.tx_ms_nome.Location = new System.Drawing.Point(23, 80);
            this.tx_ms_nome.Name = "tx_ms_nome";
            this.tx_ms_nome.Size = new System.Drawing.Size(268, 20);
            this.tx_ms_nome.TabIndex = 3;
            // 
            // nome_ms
            // 
            this.nome_ms.AutoSize = true;
            this.nome_ms.Location = new System.Drawing.Point(26, 54);
            this.nome_ms.Name = "nome_ms";
            this.nome_ms.Size = new System.Drawing.Size(41, 13);
            this.nome_ms.TabIndex = 2;
            this.nome_ms.Text = "Nome :";
            // 
            // msg_ms
            // 
            this.msg_ms.AutoSize = true;
            this.msg_ms.Location = new System.Drawing.Point(26, 227);
            this.msg_ms.Name = "msg_ms";
            this.msg_ms.Size = new System.Drawing.Size(62, 13);
            this.msg_ms.TabIndex = 4;
            this.msg_ms.Text = "Mensagem:";
            // 
            // tx_msg
            // 
            this.tx_msg.Location = new System.Drawing.Point(25, 263);
            this.tx_msg.Name = "tx_msg";
            this.tx_msg.Size = new System.Drawing.Size(362, 20);
            this.tx_msg.TabIndex = 5;
            // 
            // bt_enviar_ms
            // 
            this.bt_enviar_ms.Location = new System.Drawing.Point(501, 263);
            this.bt_enviar_ms.Name = "bt_enviar_ms";
            this.bt_enviar_ms.Size = new System.Drawing.Size(208, 67);
            this.bt_enviar_ms.TabIndex = 6;
            this.bt_enviar_ms.Text = "Enviar Mensagem.";
            this.bt_enviar_ms.UseVisualStyleBackColor = true;
            this.bt_enviar_ms.Click += new System.EventHandler(this.bt_enviar_ms_Click);
            // 
            // txbox_msg
            // 
            this.txbox_msg.Location = new System.Drawing.Point(452, 83);
            this.txbox_msg.Multiline = true;
            this.txbox_msg.Name = "txbox_msg";
            this.txbox_msg.Size = new System.Drawing.Size(281, 131);
            this.txbox_msg.TabIndex = 7;
            this.txbox_msg.TextChanged += new System.EventHandler(this.txbox_msg_TextChanged);
            // 
            // bt_voltar
            // 
            this.bt_voltar.Location = new System.Drawing.Point(29, 407);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(129, 31);
            this.bt_voltar.TabIndex = 21;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(667, 407);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(121, 31);
            this.bt_sair.TabIndex = 22;
            this.bt_sair.Text = "Sair.";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // form_msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.txbox_msg);
            this.Controls.Add(this.bt_enviar_ms);
            this.Controls.Add(this.tx_msg);
            this.Controls.Add(this.msg_ms);
            this.Controls.Add(this.tx_ms_nome);
            this.Controls.Add(this.nome_ms);
            this.Controls.Add(this.tx_ms_email);
            this.Controls.Add(this.email_ms);
            this.Name = "form_msg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_ms;
        private System.Windows.Forms.TextBox tx_ms_email;
        private System.Windows.Forms.TextBox tx_ms_nome;
        private System.Windows.Forms.Label nome_ms;
        private System.Windows.Forms.Label msg_ms;
        private System.Windows.Forms.TextBox tx_msg;
        private System.Windows.Forms.Button bt_enviar_ms;
        private System.Windows.Forms.TextBox txbox_msg;
        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.Button bt_sair;
    }
}