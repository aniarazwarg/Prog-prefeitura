namespace projetop2ds3
{
    partial class form_atv
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
            this.lb_descatv = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_atv1 = new System.Windows.Forms.Label();
            this.lb_atv2 = new System.Windows.Forms.Label();
            this.lb_atv3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_descatv
            // 
            this.lb_descatv.AutoSize = true;
            this.lb_descatv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descatv.Location = new System.Drawing.Point(38, 26);
            this.lb_descatv.Name = "lb_descatv";
            this.lb_descatv.Size = new System.Drawing.Size(286, 25);
            this.lb_descatv.TabIndex = 0;
            this.lb_descatv.Text = "Disponíveis em Fevereiro/2023.";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(555, 133);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inscrever-se.";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_atv1
            // 
            this.lb_atv1.AutoSize = true;
            this.lb_atv1.Location = new System.Drawing.Point(40, 93);
            this.lb_atv1.Name = "lb_atv1";
            this.lb_atv1.Size = new System.Drawing.Size(41, 13);
            this.lb_atv1.TabIndex = 5;
            this.lb_atv1.Text = "Karatê:";
            this.lb_atv1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_atv2
            // 
            this.lb_atv2.AutoSize = true;
            this.lb_atv2.Location = new System.Drawing.Point(40, 202);
            this.lb_atv2.Name = "lb_atv2";
            this.lb_atv2.Size = new System.Drawing.Size(46, 13);
            this.lb_atv2.TabIndex = 6;
            this.lb_atv2.Text = "Costura:";
            // 
            // lb_atv3
            // 
            this.lb_atv3.AutoSize = true;
            this.lb_atv3.Location = new System.Drawing.Point(40, 311);
            this.lb_atv3.Name = "lb_atv3";
            this.lb_atv3.Size = new System.Drawing.Size(63, 13);
            this.lb_atv3.TabIndex = 7;
            this.lb_atv3.Text = "Caminhada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Disponivel nas unidades rebouças (terças e quintas) e MM nascimento (quartas e se" +
    "xtas). ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Disponível nas unidades: ArenaSantos (segundas , quartas e sextas).";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Disponivel nas unidades: centro de cultura (quarta-feira). ";
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(667, 407);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(121, 31);
            this.bt_sair.TabIndex = 11;
            this.bt_sair.Text = "Sair.";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_voltar
            // 
            this.bt_voltar.Location = new System.Drawing.Point(12, 407);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(129, 31);
            this.bt_voltar.TabIndex = 21;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // form_atv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_atv3);
            this.Controls.Add(this.lb_atv2);
            this.Controls.Add(this.lb_atv1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lb_descatv);
            this.Name = "form_atv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividades:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_descatv;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_atv1;
        private System.Windows.Forms.Label lb_atv2;
        private System.Windows.Forms.Label lb_atv3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_voltar;
    }
}