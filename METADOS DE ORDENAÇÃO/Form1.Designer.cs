namespace metodosOrdenacao {
    partial class Frame {
       
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent() {
            this.Aba_metodos = new System.Windows.Forms.ComboBox();
            this.botao_info = new System.Windows.Forms.Button();
            this.botao_limpar = new System.Windows.Forms.Button();
            this.Tabela_Numeros = new System.Windows.Forms.TextBox();
            this.Ordenar = new System.Windows.Forms.Button();
            this.tela_info = new System.Windows.Forms.TextBox();
            this.tela_numeros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.temp_Exe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
         

            this.Aba_metodos.FormattingEnabled = true;
            this.Aba_metodos.Items.AddRange(new object[] {
            "Bubble sort",
            "Selection sort",
            "Insertion sort",
            "Cocktail sort",
            "Comb sort",
            "Shell sort",
            "Quick sort",
            "Heap sort"});
            this.Aba_metodos.Location = new System.Drawing.Point(23, 12);
            this.Aba_metodos.Name = "Aba_metodos";
            this.Aba_metodos.Size = new System.Drawing.Size(212, 23);
            this.Aba_metodos.TabIndex = 0;
            this.Aba_metodos.Text = "Metodos ";
            this.Aba_metodos.SelectedIndexChanged += new System.EventHandler(this.cbMetodos_SelectedIndexChanged);
            
            this.botao_info.Location = new System.Drawing.Point(1000, 11);
            this.botao_info.Name = "botao_info";
            this.botao_info.Size = new System.Drawing.Size(75, 23);
            this.botao_info.TabIndex = 1;
            this.botao_info.Text = "Exibir Infos";
            this.botao_info.UseVisualStyleBackColor = true;
            this.botao_info.Click += new System.EventHandler(this.btInfos_Click);
            
            this.botao_limpar.Location = new System.Drawing.Point(919, 11);
            this.botao_limpar.Name = "botao_limpar";
            this.botao_limpar.Size = new System.Drawing.Size(75, 23);
            this.botao_limpar.TabIndex = 2;
            this.botao_limpar.Text = "Limpar";
            this.botao_limpar.UseVisualStyleBackColor = true;
            this.botao_limpar.Click += new System.EventHandler(this.btLimpar_Click);
            
            this.Tabela_Numeros.Location = new System.Drawing.Point(362, 11);
            this.Tabela_Numeros.Name = "Tabela_Numeros";
            this.Tabela_Numeros.Size = new System.Drawing.Size(92, 23);
            this.Tabela_Numeros.TabIndex = 3;
            this.Tabela_Numeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tabela_Numeros.TextChanged += new System.EventHandler(this.Tabela_Numeros_TextChanged);
            
            this.Ordenar.Location = new System.Drawing.Point(472, 10);
            this.Ordenar.Name = "Ordenar";
            this.Ordenar.Size = new System.Drawing.Size(75, 23);
            this.Ordenar.TabIndex = 4;
            this.Ordenar.Text = "iniciar";
            this.Ordenar.UseVisualStyleBackColor = true;
            this.Ordenar.Click += new System.EventHandler(this.Ordenar_Click);
           
            this.tela_info.Location = new System.Drawing.Point(668, 51);
            this.tela_info.Multiline = true;
            this.tela_info.Name = "tela_info";
            this.tela_info.ReadOnly = true;
            this.tela_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tela_info.Size = new System.Drawing.Size(407, 253);
            this.tela_info.TabIndex = 5;
            this.tela_info.TextChanged += new System.EventHandler(this.tela_info_TextChanged);
             
            this.tela_numeros.Location = new System.Drawing.Point(23, 71);
            this.tela_numeros.Multiline = true;
            this.tela_numeros.Name = "tela_numeros";
            this.tela_numeros.ReadOnly = true;
            this.tela_numeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tela_numeros.Size = new System.Drawing.Size(404, 233);
            this.tela_numeros.TabIndex = 6;
            
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "QTD de numeros";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "tempo levado em ms";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            
            this.temp_Exe.Location = new System.Drawing.Point(572, 74);
            this.temp_Exe.Name = "temp_Exe";
            this.temp_Exe.ReadOnly = true;
            this.temp_Exe.Size = new System.Drawing.Size(79, 23);
            this.temp_Exe.TabIndex = 11;
            this.temp_Exe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.temp_Exe.TextChanged += new System.EventHandler(this.tbTempoExec_TextChanged);
           
            this.button1.Location = new System.Drawing.Point(456, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "como funciona?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.temp_Exe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tela_numeros);
            this.Controls.Add(this.tela_info);
            this.Controls.Add(this.Ordenar);
            this.Controls.Add(this.Tabela_Numeros);
            this.Controls.Add(this.botao_limpar);
            this.Controls.Add(this.botao_info);
            this.Controls.Add(this.Aba_metodos);
            this.Name = "Frame";
            this.Text = "Programa De Ordenação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Aba_metodos;
        private Button botao_info;
        private Button botao_limpar;
        private TextBox Tabela_Numeros;
        private Button Ordenar;
        private TextBox tela_info;
        private TextBox tela_numeros;
        private Label label3;
        private Label label4;
        private TextBox temp_Exe;
        private Button button1;
    }
}