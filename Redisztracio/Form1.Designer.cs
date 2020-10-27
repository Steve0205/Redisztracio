namespace Redisztracio
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
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_ferfi = new System.Windows.Forms.RadioButton();
            this.radioButton_no = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_hobbi = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ujhobbi = new System.Windows.Forms.TextBox();
            this.button_hozzaad = new System.Windows.Forms.Button();
            this.button_mentes = new System.Windows.Forms.Button();
            this.button_betoltes = new System.Windows.Forms.Button();
            this.dateTimePicker_szuletesdatum = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(112, 12);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(165, 20);
            this.textBox_nev.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Születési dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nem:";
            // 
            // radioButton_ferfi
            // 
            this.radioButton_ferfi.AutoSize = true;
            this.radioButton_ferfi.Checked = true;
            this.radioButton_ferfi.Location = new System.Drawing.Point(60, 80);
            this.radioButton_ferfi.Name = "radioButton_ferfi";
            this.radioButton_ferfi.Size = new System.Drawing.Size(45, 17);
            this.radioButton_ferfi.TabIndex = 5;
            this.radioButton_ferfi.TabStop = true;
            this.radioButton_ferfi.Text = "Férfi";
            this.radioButton_ferfi.UseVisualStyleBackColor = true;
            // 
            // radioButton_no
            // 
            this.radioButton_no.AutoSize = true;
            this.radioButton_no.Location = new System.Drawing.Point(111, 80);
            this.radioButton_no.Name = "radioButton_no";
            this.radioButton_no.Size = new System.Drawing.Size(39, 17);
            this.radioButton_no.TabIndex = 6;
            this.radioButton_no.Text = "Nő";
            this.radioButton_no.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kedvenc hobbi:";
            // 
            // listBox_hobbi
            // 
            this.listBox_hobbi.FormattingEnabled = true;
            this.listBox_hobbi.Location = new System.Drawing.Point(323, 34);
            this.listBox_hobbi.Name = "listBox_hobbi";
            this.listBox_hobbi.Size = new System.Drawing.Size(99, 134);
            this.listBox_hobbi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Új hobbi:";
            // 
            // textBox_ujhobbi
            // 
            this.textBox_ujhobbi.Location = new System.Drawing.Point(323, 186);
            this.textBox_ujhobbi.Name = "textBox_ujhobbi";
            this.textBox_ujhobbi.Size = new System.Drawing.Size(99, 20);
            this.textBox_ujhobbi.TabIndex = 10;
            // 
            // button_hozzaad
            // 
            this.button_hozzaad.Location = new System.Drawing.Point(347, 222);
            this.button_hozzaad.Name = "button_hozzaad";
            this.button_hozzaad.Size = new System.Drawing.Size(75, 23);
            this.button_hozzaad.TabIndex = 11;
            this.button_hozzaad.Text = "Hozzáad";
            this.button_hozzaad.UseVisualStyleBackColor = true;
            this.button_hozzaad.Click += new System.EventHandler(this.button_hozzaad_Click);
            // 
            // button_mentes
            // 
            this.button_mentes.Location = new System.Drawing.Point(266, 266);
            this.button_mentes.Name = "button_mentes";
            this.button_mentes.Size = new System.Drawing.Size(75, 23);
            this.button_mentes.TabIndex = 12;
            this.button_mentes.Text = "Mentés";
            this.button_mentes.UseVisualStyleBackColor = true;
            this.button_mentes.Click += new System.EventHandler(this.button_mentes_Click);
            // 
            // button_betoltes
            // 
            this.button_betoltes.Location = new System.Drawing.Point(347, 266);
            this.button_betoltes.Name = "button_betoltes";
            this.button_betoltes.Size = new System.Drawing.Size(75, 23);
            this.button_betoltes.TabIndex = 13;
            this.button_betoltes.Text = "Betöltés";
            this.button_betoltes.UseVisualStyleBackColor = true;
            this.button_betoltes.Click += new System.EventHandler(this.button_betoltes_Click);
            // 
            // dateTimePicker_szuletesdatum
            // 
            this.dateTimePicker_szuletesdatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_szuletesdatum.Location = new System.Drawing.Point(112, 46);
            this.dateTimePicker_szuletesdatum.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_szuletesdatum.Name = "dateTimePicker_szuletesdatum";
            this.dateTimePicker_szuletesdatum.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker_szuletesdatum.TabIndex = 14;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt fájl|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 324);
            this.Controls.Add(this.dateTimePicker_szuletesdatum);
            this.Controls.Add(this.button_betoltes);
            this.Controls.Add(this.button_mentes);
            this.Controls.Add(this.button_hozzaad);
            this.Controls.Add(this.textBox_ujhobbi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_hobbi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton_no);
            this.Controls.Add(this.radioButton_ferfi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_ferfi;
        private System.Windows.Forms.RadioButton radioButton_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_hobbi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ujhobbi;
        private System.Windows.Forms.Button button_hozzaad;
        private System.Windows.Forms.Button button_mentes;
        private System.Windows.Forms.Button button_betoltes;
        private System.Windows.Forms.DateTimePicker dateTimePicker_szuletesdatum;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

