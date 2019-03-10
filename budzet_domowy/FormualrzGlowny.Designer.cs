namespace budzet_domowy
{
    partial class FormualrzGlowny
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
            this.DGV_uzytkownicy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_uzytkownicy)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_uzytkownicy
            // 
            this.DGV_uzytkownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_uzytkownicy.Location = new System.Drawing.Point(240, 82);
            this.DGV_uzytkownicy.Name = "DGV_uzytkownicy";
            this.DGV_uzytkownicy.RowHeadersVisible = false;
            this.DGV_uzytkownicy.Size = new System.Drawing.Size(240, 150);
            this.DGV_uzytkownicy.TabIndex = 0;
            // 
            // FormualrzGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_uzytkownicy);
            this.Name = "FormualrzGlowny";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_uzytkownicy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_uzytkownicy;
    }
}

