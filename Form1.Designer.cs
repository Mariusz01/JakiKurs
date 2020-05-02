namespace JakiKurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDolar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEuro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFunt = new System.Windows.Forms.Label();
            this.buttonOdswiez = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFrank = new System.Windows.Forms.Label();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.dolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.odświeżToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.pokażNormalnieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńŚcieżkęZapisuLoguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(79, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurs walut:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(34, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar (USD):";
            // 
            // labelDolar
            // 
            this.labelDolar.AutoSize = true;
            this.labelDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDolar.Location = new System.Drawing.Point(169, 111);
            this.labelDolar.Name = "labelDolar";
            this.labelDolar.Size = new System.Drawing.Size(47, 20);
            this.labelDolar.TabIndex = 2;
            this.labelDolar.Text = "Dolar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(34, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Euro (EUR):";
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEuro.Location = new System.Drawing.Point(169, 153);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(43, 20);
            this.labelEuro.TabIndex = 4;
            this.labelEuro.Text = "Euro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(34, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Funt (GBP):";
            // 
            // labelFunt
            // 
            this.labelFunt.AutoSize = true;
            this.labelFunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFunt.Location = new System.Drawing.Point(169, 197);
            this.labelFunt.Name = "labelFunt";
            this.labelFunt.Size = new System.Drawing.Size(42, 20);
            this.labelFunt.TabIndex = 6;
            this.labelFunt.Text = "Funt";
            // 
            // buttonOdswiez
            // 
            this.buttonOdswiez.Location = new System.Drawing.Point(164, 275);
            this.buttonOdswiez.Name = "buttonOdswiez";
            this.buttonOdswiez.Size = new System.Drawing.Size(75, 23);
            this.buttonOdswiez.TabIndex = 7;
            this.buttonOdswiez.Text = "Włącz";
            this.buttonOdswiez.UseVisualStyleBackColor = true;
            this.buttonOdswiez.Click += new System.EventHandler(this.buttonOdswiez_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(16, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Kurs z dnia:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelData.Location = new System.Drawing.Point(98, 77);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(46, 17);
            this.labelData.TabIndex = 9;
            this.labelData.Text = "label9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(34, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Frank (CHF):";
            // 
            // labelFrank
            // 
            this.labelFrank.AutoSize = true;
            this.labelFrank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFrank.Location = new System.Drawing.Point(169, 241);
            this.labelFrank.Name = "labelFrank";
            this.labelFrank.Size = new System.Drawing.Size(50, 20);
            this.labelFrank.TabIndex = 11;
            this.labelFrank.Text = "Frank";
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconTray.Text = "notifyIcon1";
            this.notifyIconTray.DoubleClick += new System.EventHandler(this.notifyIconTray_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.toolStripMenuItem3,
            this.dolarToolStripMenuItem,
            this.euroToolStripMenuItem,
            this.funtToolStripMenuItem,
            this.frankToolStripMenuItem,
            this.toolStripMenuItem2,
            this.odświeżToolStripMenuItem,
            this.toolStripMenuItem1,
            this.pokażNormalnieToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 198);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(161, 6);
            // 
            // dolarToolStripMenuItem
            // 
            this.dolarToolStripMenuItem.Name = "dolarToolStripMenuItem";
            this.dolarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dolarToolStripMenuItem.Text = "Dolar";
            // 
            // euroToolStripMenuItem
            // 
            this.euroToolStripMenuItem.Name = "euroToolStripMenuItem";
            this.euroToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.euroToolStripMenuItem.Text = "Euro";
            // 
            // funtToolStripMenuItem
            // 
            this.funtToolStripMenuItem.Name = "funtToolStripMenuItem";
            this.funtToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.funtToolStripMenuItem.Text = "Funt";
            // 
            // frankToolStripMenuItem
            // 
            this.frankToolStripMenuItem.Name = "frankToolStripMenuItem";
            this.frankToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.frankToolStripMenuItem.Text = "Frank";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 6);
            // 
            // odświeżToolStripMenuItem
            // 
            this.odświeżToolStripMenuItem.Name = "odświeżToolStripMenuItem";
            this.odświeżToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.odświeżToolStripMenuItem.Text = "Odśwież";
            this.odświeżToolStripMenuItem.Click += new System.EventHandler(this.odświeżToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // pokażNormalnieToolStripMenuItem
            // 
            this.pokażNormalnieToolStripMenuItem.Name = "pokażNormalnieToolStripMenuItem";
            this.pokażNormalnieToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pokażNormalnieToolStripMenuItem.Text = "Pokaż Normalnie";
            this.pokażNormalnieToolStripMenuItem.Click += new System.EventHandler(this.pokażNormalnieToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "odświeżanie co 10 minut:";
            // 
            // timer1
            // 
            this.timer1.Interval = 600000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Odśwież";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńŚcieżkęZapisuLoguToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zmieńŚcieżkęZapisuLoguToolStripMenuItem
            // 
            this.zmieńŚcieżkęZapisuLoguToolStripMenuItem.Name = "zmieńŚcieżkęZapisuLoguToolStripMenuItem";
            this.zmieńŚcieżkęZapisuLoguToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.zmieńŚcieżkęZapisuLoguToolStripMenuItem.Text = "Zmień ścieżkę zapisu logu";
            this.zmieńŚcieżkęZapisuLoguToolStripMenuItem.Click += new System.EventHandler(this.zmieńŚcieżkęZapisuLoguToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 341);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelFrank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonOdswiez);
            this.Controls.Add(this.labelFunt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelEuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(285, 382);
            this.MinimumSize = new System.Drawing.Size(285, 380);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurs Walut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDolar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFunt;
        private System.Windows.Forms.Button buttonOdswiez;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFrank;
        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem euroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frankToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pokażNormalnieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem odświeżToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńŚcieżkęZapisuLoguToolStripMenuItem;
    }
}

