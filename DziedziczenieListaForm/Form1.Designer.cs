namespace DziedziczenieListaForm
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnLosuj = new System.Windows.Forms.Button();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSortuj = new System.Windows.Forms.Button();
            this.myLst = new DziedziczenieListaForm.myList();
            this.btnSumaLiczb = new System.Windows.Forms.Button();
            this.lstBoxSystem = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "zakres liczb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "A";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(252, 46);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(44, 20);
            this.txtA.TabIndex = 3;
            this.txtA.Text = "0";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "B";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(351, 46);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(44, 20);
            this.txtB.TabIndex = 5;
            this.txtB.Text = "100";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLosuj
            // 
            this.btnLosuj.Location = new System.Drawing.Point(320, 95);
            this.btnLosuj.Name = "btnLosuj";
            this.btnLosuj.Size = new System.Drawing.Size(75, 23);
            this.btnLosuj.TabIndex = 6;
            this.btnLosuj.Text = "Losuj";
            this.btnLosuj.UseVisualStyleBackColor = true;
            this.btnLosuj.Click += new System.EventHandler(this.btnLosuj_Click);
            // 
            // txtIlosc
            // 
            this.txtIlosc.Location = new System.Drawing.Point(252, 72);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(44, 20);
            this.txtIlosc.TabIndex = 7;
            this.txtIlosc.Text = "0";
            this.txtIlosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "n";
            // 
            // btnSortuj
            // 
            this.btnSortuj.Location = new System.Drawing.Point(320, 136);
            this.btnSortuj.Name = "btnSortuj";
            this.btnSortuj.Size = new System.Drawing.Size(75, 23);
            this.btnSortuj.TabIndex = 9;
            this.btnSortuj.Text = "Sortuj";
            this.btnSortuj.UseVisualStyleBackColor = true;
            this.btnSortuj.Click += new System.EventHandler(this.btnSortuj_Click);
            // 
            // myLst
            // 
            this.myLst.FormattingEnabled = true;
            this.myLst.Location = new System.Drawing.Point(32, 25);
            this.myLst.Name = "myLst";
            this.myLst.Size = new System.Drawing.Size(133, 199);
            this.myLst.TabIndex = 10;
            // 
            // btnSumaLiczb
            // 
            this.btnSumaLiczb.Location = new System.Drawing.Point(263, 179);
            this.btnSumaLiczb.Name = "btnSumaLiczb";
            this.btnSumaLiczb.Size = new System.Drawing.Size(132, 23);
            this.btnSumaLiczb.TabIndex = 11;
            this.btnSumaLiczb.Text = "WyswietlSumeLiczb";
            this.btnSumaLiczb.UseVisualStyleBackColor = true;
            this.btnSumaLiczb.Click += new System.EventHandler(this.btnSumaLiczb_Click);
            // 
            // lstBoxSystem
            // 
            this.lstBoxSystem.FormattingEnabled = true;
            this.lstBoxSystem.Location = new System.Drawing.Point(455, 33);
            this.lstBoxSystem.Name = "lstBoxSystem";
            this.lstBoxSystem.Size = new System.Drawing.Size(120, 199);
            this.lstBoxSystem.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 331);
            this.Controls.Add(this.lstBoxSystem);
            this.Controls.Add(this.btnSumaLiczb);
            this.Controls.Add(this.myLst);
            this.Controls.Add(this.btnSortuj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.btnLosuj);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnLosuj;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSortuj;
        private myList myLst;
        private System.Windows.Forms.Button btnSumaLiczb;
        private System.Windows.Forms.ListBox lstBoxSystem;
    }
}

