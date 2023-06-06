namespace Alarme01
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttn_programar = new System.Windows.Forms.Button();
            this.bttn_Stop = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMinuto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.cbMinutos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_programar
            // 
            this.bttn_programar.FlatAppearance.BorderSize = 0;
            this.bttn_programar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_programar.Location = new System.Drawing.Point(271, 177);
            this.bttn_programar.Margin = new System.Windows.Forms.Padding(1);
            this.bttn_programar.Name = "bttn_programar";
            this.bttn_programar.Size = new System.Drawing.Size(96, 76);
            this.bttn_programar.TabIndex = 0;
            this.bttn_programar.Text = "iniciar";
            this.bttn_programar.UseVisualStyleBackColor = true;
            this.bttn_programar.Click += new System.EventHandler(this.btn_programar_Click);
            // 
            // bttn_Stop
            // 
            this.bttn_Stop.FlatAppearance.BorderSize = 0;
            this.bttn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Stop.Location = new System.Drawing.Point(369, 177);
            this.bttn_Stop.Margin = new System.Windows.Forms.Padding(1);
            this.bttn_Stop.Name = "bttn_Stop";
            this.bttn_Stop.Size = new System.Drawing.Size(96, 76);
            this.bttn_Stop.TabIndex = 1;
            this.bttn_Stop.Text = "parar";
            this.bttn_Stop.UseVisualStyleBackColor = true;
            this.bttn_Stop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.lblHora.Location = new System.Drawing.Point(14, 19);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(107, 76);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.label2.Location = new System.Drawing.Point(127, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 76);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // lblMinuto
            // 
            this.lblMinuto.AutoSize = true;
            this.lblMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.lblMinuto.Location = new System.Drawing.Point(185, 19);
            this.lblMinuto.Name = "lblMinuto";
            this.lblMinuto.Size = new System.Drawing.Size(107, 76);
            this.lblMinuto.TabIndex = 4;
            this.lblMinuto.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.label4.Location = new System.Drawing.Point(298, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 76);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.lblSegundo.Location = new System.Drawing.Point(356, 19);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(107, 76);
            this.lblSegundo.TabIndex = 6;
            this.lblSegundo.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbHora
            // 
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Location = new System.Drawing.Point(76, 130);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(121, 21);
            this.cbHora.TabIndex = 8;
            // 
            // cbMinutos
            // 
            this.cbMinutos.FormattingEnabled = true;
            this.cbMinutos.Location = new System.Drawing.Point(250, 130);
            this.cbMinutos.Name = "cbMinutos";
            this.cbMinutos.Size = new System.Drawing.Size(121, 21);
            this.cbMinutos.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Horas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Minutos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMinutos);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMinuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.bttn_Stop);
            this.Controls.Add(this.bttn_programar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " Alarme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_programar;
        private System.Windows.Forms.Button bttn_Stop;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMinuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.ComboBox cbMinutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

