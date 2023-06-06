namespace webBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.bttn_parar = new System.Windows.Forms.Button();
            this.bttn_pesquisa = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bttn_definir_home = new System.Windows.Forms.Button();
            this.bttn_ir = new System.Windows.Forms.Button();
            this.bttn_home = new System.Windows.Forms.Button();
            this.bttn_atualizar = new System.Windows.Forms.Button();
            this.bttn_proximo = new System.Windows.Forms.Button();
            this.bttn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(892, 408);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(246, 4);
            this.txt_url.Multiline = true;
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(375, 34);
            this.txt_url.TabIndex = 1;
            this.txt_url.TextChanged += new System.EventHandler(this.txt_url_TextChanged);
            this.txt_url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_url_KeyDown);
            // 
            // bttn_parar
            // 
            this.bttn_parar.AutoSize = true;
            this.bttn_parar.BackColor = System.Drawing.Color.Silver;
            this.bttn_parar.FlatAppearance.BorderSize = 0;
            this.bttn_parar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_parar.Location = new System.Drawing.Point(615, 54);
            this.bttn_parar.Name = "bttn_parar";
            this.bttn_parar.Size = new System.Drawing.Size(75, 40);
            this.bttn_parar.TabIndex = 6;
            this.bttn_parar.Text = "parar";
            this.bttn_parar.UseVisualStyleBackColor = false;
            this.bttn_parar.Click += new System.EventHandler(this.bttn_parar_Click);
            // 
            // bttn_pesquisa
            // 
            this.bttn_pesquisa.AutoSize = true;
            this.bttn_pesquisa.BackColor = System.Drawing.Color.Silver;
            this.bttn_pesquisa.FlatAppearance.BorderSize = 0;
            this.bttn_pesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_pesquisa.Location = new System.Drawing.Point(718, 3);
            this.bttn_pesquisa.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.bttn_pesquisa.Name = "bttn_pesquisa";
            this.bttn_pesquisa.Size = new System.Drawing.Size(75, 39);
            this.bttn_pesquisa.TabIndex = 8;
            this.bttn_pesquisa.Text = "pesquisa";
            this.bttn_pesquisa.UseVisualStyleBackColor = false;
            this.bttn_pesquisa.Click += new System.EventHandler(this.bttn_pesquisa_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.Controls.Add(this.bttn_definir_home);
            this.splitContainer1.Panel1.Controls.Add(this.bttn_ir);
            this.splitContainer1.Panel1.Controls.Add(this.bttn_pesquisa);
            this.splitContainer1.Panel1.Controls.Add(this.bttn_home);
            this.splitContainer1.Panel1.Controls.Add(this.bttn_atualizar);
            this.splitContainer1.Panel1.Controls.Add(this.bttn_proximo);
            this.splitContainer1.Panel1.Controls.Add(this.bttn_voltar);
            this.splitContainer1.Panel1.Controls.Add(this.txt_url);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel2.Controls.Add(this.bttn_parar);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(892, 457);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 10;
            // 
            // bttn_definir_home
            // 
            this.bttn_definir_home.AutoSize = true;
            this.bttn_definir_home.BackColor = System.Drawing.Color.Silver;
            this.bttn_definir_home.FlatAppearance.BorderSize = 0;
            this.bttn_definir_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_definir_home.Location = new System.Drawing.Point(799, 3);
            this.bttn_definir_home.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.bttn_definir_home.Name = "bttn_definir_home";
            this.bttn_definir_home.Size = new System.Drawing.Size(76, 38);
            this.bttn_definir_home.TabIndex = 9;
            this.bttn_definir_home.Text = "favoritos";
            this.bttn_definir_home.UseVisualStyleBackColor = false;
            this.bttn_definir_home.Click += new System.EventHandler(this.bttn_definir_home_Click);
            // 
            // bttn_ir
            // 
            this.bttn_ir.AutoSize = true;
            this.bttn_ir.BackColor = System.Drawing.Color.Silver;
            this.bttn_ir.FlatAppearance.BorderSize = 0;
            this.bttn_ir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_ir.Location = new System.Drawing.Point(641, 3);
            this.bttn_ir.Name = "bttn_ir";
            this.bttn_ir.Size = new System.Drawing.Size(60, 38);
            this.bttn_ir.TabIndex = 2;
            this.bttn_ir.Text = "ir";
            this.bttn_ir.UseVisualStyleBackColor = false;
            this.bttn_ir.Click += new System.EventHandler(this.bttn_ir_Click);
            // 
            // bttn_home
            // 
            this.bttn_home.AutoSize = true;
            this.bttn_home.FlatAppearance.BorderSize = 0;
            this.bttn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_home.Location = new System.Drawing.Point(165, 5);
            this.bttn_home.Name = "bttn_home";
            this.bttn_home.Size = new System.Drawing.Size(75, 38);
            this.bttn_home.TabIndex = 3;
            this.bttn_home.Text = "home";
            this.bttn_home.UseVisualStyleBackColor = true;
            this.bttn_home.Click += new System.EventHandler(this.bttn_home_Click);
            // 
            // bttn_atualizar
            // 
            this.bttn_atualizar.AutoSize = true;
            this.bttn_atualizar.BackColor = System.Drawing.SystemColors.Window;
            this.bttn_atualizar.FlatAppearance.BorderSize = 0;
            this.bttn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_atualizar.Image = global::webBrowser.Properties.Resources.refresh_arrow;
            this.bttn_atualizar.Location = new System.Drawing.Point(581, 6);
            this.bttn_atualizar.Name = "bttn_atualizar";
            this.bttn_atualizar.Size = new System.Drawing.Size(31, 29);
            this.bttn_atualizar.TabIndex = 7;
            this.bttn_atualizar.UseVisualStyleBackColor = false;
            this.bttn_atualizar.Click += new System.EventHandler(this.bttn_atualizar_Click);
            // 
            // bttn_proximo
            // 
            this.bttn_proximo.AutoSize = true;
            this.bttn_proximo.FlatAppearance.BorderSize = 0;
            this.bttn_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_proximo.Location = new System.Drawing.Point(93, 5);
            this.bttn_proximo.Name = "bttn_proximo";
            this.bttn_proximo.Size = new System.Drawing.Size(56, 38);
            this.bttn_proximo.TabIndex = 5;
            this.bttn_proximo.Text = "avançar";
            this.bttn_proximo.UseVisualStyleBackColor = true;
            this.bttn_proximo.Click += new System.EventHandler(this.bttn_proximo_Click);
            // 
            // bttn_voltar
            // 
            this.bttn_voltar.AutoSize = true;
            this.bttn_voltar.FlatAppearance.BorderSize = 0;
            this.bttn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_voltar.Location = new System.Drawing.Point(33, 4);
            this.bttn_voltar.Name = "bttn_voltar";
            this.bttn_voltar.Size = new System.Drawing.Size(54, 38);
            this.bttn_voltar.TabIndex = 4;
            this.bttn_voltar.Text = "voltar";
            this.bttn_voltar.UseVisualStyleBackColor = true;
            this.bttn_voltar.Click += new System.EventHandler(this.bttn_voltar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(892, 457);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LinkyBrowser";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button bttn_ir;
        private System.Windows.Forms.Button bttn_home;
        private System.Windows.Forms.Button bttn_voltar;
        private System.Windows.Forms.Button bttn_proximo;
        private System.Windows.Forms.Button bttn_parar;
        private System.Windows.Forms.Button bttn_atualizar;
        private System.Windows.Forms.Button bttn_pesquisa;
        private System.Windows.Forms.Button bttn_definir_home;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

