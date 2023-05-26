namespace projetop2ds3
{
    partial class Form_Log
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_log = new System.Windows.Forms.Label();
            this.boxlog = new System.Windows.Forms.TextBox();
            this.boxsen = new System.Windows.Forms.TextBox();
            this.lb_sen = new System.Windows.Forms.Label();
            this.bt_entrar = new System.Windows.Forms.Button();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.bt_cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_log
            // 
            this.lb_log.AutoSize = true;
            this.lb_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_log.Location = new System.Drawing.Point(288, 135);
            this.lb_log.Name = "lb_log";
            this.lb_log.Size = new System.Drawing.Size(52, 20);
            this.lb_log.TabIndex = 0;
            this.lb_log.Text = "Login:";
            this.lb_log.Click += new System.EventHandler(this.label1_Click);
            // 
            // boxlog
            // 
            this.boxlog.Location = new System.Drawing.Point(359, 137);
            this.boxlog.Name = "boxlog";
            this.boxlog.Size = new System.Drawing.Size(149, 20);
            this.boxlog.TabIndex = 1;
            this.boxlog.TextChanged += new System.EventHandler(this.boxlog_TextChanged);
            // 
            // boxsen
            // 
            this.boxsen.Location = new System.Drawing.Point(359, 184);
            this.boxsen.Name = "boxsen";
            this.boxsen.PasswordChar = '*';
            this.boxsen.Size = new System.Drawing.Size(149, 20);
            this.boxsen.TabIndex = 2;
            // 
            // lb_sen
            // 
            this.lb_sen.AutoSize = true;
            this.lb_sen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sen.Location = new System.Drawing.Point(288, 182);
            this.lb_sen.Name = "lb_sen";
            this.lb_sen.Size = new System.Drawing.Size(60, 20);
            this.lb_sen.TabIndex = 3;
            this.lb_sen.Text = "Senha:";
            // 
            // bt_entrar
            // 
            this.bt_entrar.Location = new System.Drawing.Point(359, 243);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(80, 25);
            this.bt_entrar.TabIndex = 4;
            this.bt_entrar.Text = "Entrar";
            this.bt_entrar.UseVisualStyleBackColor = true;
            this.bt_entrar.Click += new System.EventHandler(this.bt_entrar_Click);
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(287, 89);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(233, 25);
            this.lb_titulo.TabIndex = 5;
            this.lb_titulo.Text = "Bem vindo(a) ao sistema.";
            // 
            // bt_cadastro
            // 
            this.bt_cadastro.Location = new System.Drawing.Point(359, 289);
            this.bt_cadastro.Name = "bt_cadastro";
            this.bt_cadastro.Size = new System.Drawing.Size(79, 24);
            this.bt_cadastro.TabIndex = 6;
            this.bt_cadastro.Text = "Cadastrar";
            this.bt_cadastro.UseVisualStyleBackColor = true;
            this.bt_cadastro.Click += new System.EventHandler(this.bt_cadastro_Click);
            // 
            // Form_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_cadastro);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.bt_entrar);
            this.Controls.Add(this.lb_sen);
            this.Controls.Add(this.boxsen);
            this.Controls.Add(this.boxlog);
            this.Controls.Add(this.lb_log);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form_Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Form_Log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_log;
        private System.Windows.Forms.TextBox boxlog;
        private System.Windows.Forms.TextBox boxsen;
        private System.Windows.Forms.Label lb_sen;
        private System.Windows.Forms.Button bt_entrar;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Button bt_cadastro;
    }
}

