namespace monitors
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.nowy = new System.Windows.Forms.TabPage();
            this.cena = new System.Windows.Forms.Label();
            this.cenaBox = new System.Windows.Forms.TextBox();
            this.monitor = new System.Windows.Forms.Button();
            this.komputer = new System.Windows.Forms.Button();
            this.aktualizacja = new System.Windows.Forms.TabPage();
            this.monitorAk = new System.Windows.Forms.Button();
            this.procesor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.nowy.SuspendLayout();
            this.aktualizacja.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.nowy);
            this.tabControl1.Controls.Add(this.aktualizacja);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // nowy
            // 
            this.nowy.Controls.Add(this.cena);
            this.nowy.Controls.Add(this.cenaBox);
            this.nowy.Controls.Add(this.monitor);
            this.nowy.Controls.Add(this.komputer);
            this.nowy.Location = new System.Drawing.Point(4, 22);
            this.nowy.Name = "nowy";
            this.nowy.Padding = new System.Windows.Forms.Padding(3);
            this.nowy.Size = new System.Drawing.Size(791, 425);
            this.nowy.TabIndex = 0;
            this.nowy.Text = "NEW";
            this.nowy.UseVisualStyleBackColor = true;
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.Location = new System.Drawing.Point(574, 150);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(43, 13);
            this.cena.TabIndex = 3;
            this.cena.Text = "Price zł";
            // 
            // cenaBox
            // 
            this.cenaBox.Location = new System.Drawing.Point(565, 179);
            this.cenaBox.Name = "cenaBox";
            this.cenaBox.Size = new System.Drawing.Size(102, 20);
            this.cenaBox.TabIndex = 2;
            // 
            // monitor
            // 
            this.monitor.Location = new System.Drawing.Point(290, 150);
            this.monitor.Name = "monitor";
            this.monitor.Size = new System.Drawing.Size(174, 76);
            this.monitor.TabIndex = 1;
            this.monitor.Text = "Monitor";
            this.monitor.UseVisualStyleBackColor = true;
            this.monitor.Click += new System.EventHandler(this.monitor_Click);
            // 
            // komputer
            // 
            this.komputer.Location = new System.Drawing.Point(71, 150);
            this.komputer.Name = "komputer";
            this.komputer.Size = new System.Drawing.Size(168, 76);
            this.komputer.TabIndex = 0;
            this.komputer.Text = "Computer";
            this.komputer.UseVisualStyleBackColor = true;
            this.komputer.Click += new System.EventHandler(this.komputer_Click);
            // 
            // aktualizacja
            // 
            this.aktualizacja.Controls.Add(this.monitorAk);
            this.aktualizacja.Controls.Add(this.procesor);
            this.aktualizacja.Location = new System.Drawing.Point(4, 22);
            this.aktualizacja.Name = "aktualizacja";
            this.aktualizacja.Padding = new System.Windows.Forms.Padding(3);
            this.aktualizacja.Size = new System.Drawing.Size(791, 425);
            this.aktualizacja.TabIndex = 1;
            this.aktualizacja.Text = "UPDATE";
            this.aktualizacja.UseVisualStyleBackColor = true;
            // 
            // monitorAk
            // 
            this.monitorAk.Location = new System.Drawing.Point(414, 143);
            this.monitorAk.Name = "monitorAk";
            this.monitorAk.Size = new System.Drawing.Size(152, 65);
            this.monitorAk.TabIndex = 1;
            this.monitorAk.Text = "Monitor";
            this.monitorAk.UseVisualStyleBackColor = true;
            this.monitorAk.Click += new System.EventHandler(this.monitorAk_Click);
            // 
            // procesor
            // 
            this.procesor.Location = new System.Drawing.Point(138, 143);
            this.procesor.Name = "procesor";
            this.procesor.Size = new System.Drawing.Size(149, 65);
            this.procesor.TabIndex = 0;
            this.procesor.Text = "Proccessor";
            this.procesor.UseVisualStyleBackColor = true;
            this.procesor.Click += new System.EventHandler(this.procesor_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.nowy.ResumeLayout(false);
            this.nowy.PerformLayout();
            this.aktualizacja.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage nowy;
        private System.Windows.Forms.TabPage aktualizacja;
        private System.Windows.Forms.Label cena;
        private System.Windows.Forms.TextBox cenaBox;
        private System.Windows.Forms.Button monitor;
        private System.Windows.Forms.Button komputer;
        private System.Windows.Forms.Button monitorAk;
        private System.Windows.Forms.Button procesor;
        private System.Windows.Forms.Timer timer1;
    }
}

