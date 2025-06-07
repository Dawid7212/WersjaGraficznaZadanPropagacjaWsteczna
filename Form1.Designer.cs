namespace WersjagraficznaTychZadan
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTestuj = new System.Windows.Forms.Button();
            this.labelWagiPoczatkowe = new System.Windows.Forms.Label();
            this.labelWagiKoncowe = new System.Windows.Forms.Label();
            this.WszystkieWyniki = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WYniki12 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz zadanie i zatwierdz przyciskiem";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "XOR",
            "XOR_NOR",
            "Sumatorek"});
            this.comboBox1.Location = new System.Drawing.Point(44, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Resetuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTestuj
            // 
            this.btnTestuj.Location = new System.Drawing.Point(44, 101);
            this.btnTestuj.Name = "btnTestuj";
            this.btnTestuj.Size = new System.Drawing.Size(75, 23);
            this.btnTestuj.TabIndex = 4;
            this.btnTestuj.Text = "Testuj";
            this.btnTestuj.UseVisualStyleBackColor = true;
            this.btnTestuj.Click += new System.EventHandler(this.btnTestuj_Click);
            // 
            // labelWagiPoczatkowe
            // 
            this.labelWagiPoczatkowe.AutoSize = true;
            this.labelWagiPoczatkowe.Location = new System.Drawing.Point(360, 172);
            this.labelWagiPoczatkowe.Name = "labelWagiPoczatkowe";
            this.labelWagiPoczatkowe.Size = new System.Drawing.Size(93, 13);
            this.labelWagiPoczatkowe.TabIndex = 7;
            this.labelWagiPoczatkowe.Text = "Wagi poczatkowe";
            // 
            // labelWagiKoncowe
            // 
            this.labelWagiKoncowe.AutoSize = true;
            this.labelWagiKoncowe.Location = new System.Drawing.Point(360, 301);
            this.labelWagiKoncowe.Name = "labelWagiKoncowe";
            this.labelWagiKoncowe.Size = new System.Drawing.Size(79, 13);
            this.labelWagiKoncowe.TabIndex = 8;
            this.labelWagiKoncowe.Text = "Wagi koncowe";
            // 
            // WszystkieWyniki
            // 
            this.WszystkieWyniki.Location = new System.Drawing.Point(363, 26);
            this.WszystkieWyniki.Name = "WszystkieWyniki";
            this.WszystkieWyniki.Size = new System.Drawing.Size(286, 126);
            this.WszystkieWyniki.TabIndex = 9;
            this.WszystkieWyniki.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Wyjscia po uczeniu:";
            // 
            // WYniki12
            // 
            this.WYniki12.Location = new System.Drawing.Point(44, 201);
            this.WYniki12.Name = "WYniki12";
            this.WYniki12.Size = new System.Drawing.Size(269, 142);
            this.WYniki12.TabIndex = 11;
            this.WYniki12.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wyjscia sieci przed uczeniem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "*Każde kolejne kliknęcie przycisku \"Testuj\" powoduje wylosowanie wag i uczenie si" +
    "eci na nowo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WYniki12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WszystkieWyniki);
            this.Controls.Add(this.labelWagiKoncowe);
            this.Controls.Add(this.labelWagiPoczatkowe);
            this.Controls.Add(this.btnTestuj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTestuj;
        private System.Windows.Forms.Label labelWagiPoczatkowe;
        private System.Windows.Forms.Label labelWagiKoncowe;
        private System.Windows.Forms.RichTextBox WszystkieWyniki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox WYniki12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

