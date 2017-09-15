namespace EditorDeTexto
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
            this.textoConteuto = new System.Windows.Forms.TextBox();
            this.buttonGrava = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textoBusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoReplace = new System.Windows.Forms.TextBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoConteuto
            // 
            this.textoConteuto.Location = new System.Drawing.Point(12, 12);
            this.textoConteuto.Multiline = true;
            this.textoConteuto.Name = "textoConteuto";
            this.textoConteuto.Size = new System.Drawing.Size(350, 170);
            this.textoConteuto.TabIndex = 0;
            this.textoConteuto.Text = "edite seu arquivo aqui...";
            // 
            // buttonGrava
            // 
            this.buttonGrava.Location = new System.Drawing.Point(12, 272);
            this.buttonGrava.Name = "buttonGrava";
            this.buttonGrava.Size = new System.Drawing.Size(75, 23);
            this.buttonGrava.TabIndex = 1;
            this.buttonGrava.Text = "Gravar";
            this.buttonGrava.UseVisualStyleBackColor = true;
            this.buttonGrava.Click += new System.EventHandler(this.buttonGrava_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonReplace);
            this.groupBox1.Controls.Add(this.textoReplace);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoBusca);
            this.groupBox1.Controls.Add(this.buttonFind);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(159, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find and Replace";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(107, 80);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textoBusca
            // 
            this.textoBusca.Location = new System.Drawing.Point(65, 28);
            this.textoBusca.Name = "textoBusca";
            this.textoBusca.Size = new System.Drawing.Size(117, 20);
            this.textoBusca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace";
            // 
            // textoReplace
            // 
            this.textoReplace.Location = new System.Drawing.Point(66, 55);
            this.textoReplace.Name = "textoReplace";
            this.textoReplace.Size = new System.Drawing.Size(116, 20);
            this.textoReplace.TabIndex = 4;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(26, 81);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 5;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGrava);
            this.Controls.Add(this.textoConteuto);
            this.Name = "Form1";
            this.Text = "Editor de Texto do Douglas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoConteuto;
        private System.Windows.Forms.Button buttonGrava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textoBusca;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.TextBox textoReplace;
        private System.Windows.Forms.Label label2;
    }
}

