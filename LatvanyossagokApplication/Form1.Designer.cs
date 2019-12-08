namespace LatvanyossagokApplication
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
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.addCity = new System.Windows.Forms.Button();
            this.lakosagNumeric = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLNev = new System.Windows.Forms.TextBox();
            this.numericUpDownAr = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LeirasText = new System.Windows.Forms.RichTextBox();
            this.varosValasz = new System.Windows.Forms.ComboBox();
            this.NumericAr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewVarosok = new System.Windows.Forms.DataGridView();
            this.dataGridViewLatvanyossag = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lakosagNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVarosok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLatvanyossag)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(6, 70);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNev.TabIndex = 0;
            // 
            // addCity
            // 
            this.addCity.Location = new System.Drawing.Point(260, 70);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(75, 23);
            this.addCity.TabIndex = 2;
            this.addCity.Text = "Felvessz";
            this.addCity.UseVisualStyleBackColor = true;
            this.addCity.Click += new System.EventHandler(this.AddCity_Click);
            // 
            // lakosagNumeric
            // 
            this.lakosagNumeric.Location = new System.Drawing.Point(120, 73);
            this.lakosagNumeric.Name = "lakosagNumeric";
            this.lakosagNumeric.Size = new System.Drawing.Size(120, 20);
            this.lakosagNumeric.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Felvessz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Város hozzá adás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Látványosag hozzá add";
            // 
            // textBoxLNev
            // 
            this.textBoxLNev.Location = new System.Drawing.Point(3, 160);
            this.textBoxLNev.Name = "textBoxLNev";
            this.textBoxLNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxLNev.TabIndex = 7;
            // 
            // numericUpDownAr
            // 
            this.numericUpDownAr.Location = new System.Drawing.Point(215, 161);
            this.numericUpDownAr.Name = "numericUpDownAr";
            this.numericUpDownAr.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAr.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Város";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lakosság";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nev";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Leiras";
            // 
            // LeirasText
            // 
            this.LeirasText.Location = new System.Drawing.Point(109, 160);
            this.LeirasText.Name = "LeirasText";
            this.LeirasText.Size = new System.Drawing.Size(100, 96);
            this.LeirasText.TabIndex = 14;
            this.LeirasText.Text = "";
            // 
            // varosValasz
            // 
            this.varosValasz.FormattingEnabled = true;
            this.varosValasz.Location = new System.Drawing.Point(341, 161);
            this.varosValasz.Name = "varosValasz";
            this.varosValasz.Size = new System.Drawing.Size(121, 21);
            this.varosValasz.TabIndex = 15;
            // 
            // NumericAr
            // 
            this.NumericAr.AutoSize = true;
            this.NumericAr.Location = new System.Drawing.Point(212, 145);
            this.NumericAr.Name = "NumericAr";
            this.NumericAr.Size = new System.Drawing.Size(17, 13);
            this.NumericAr.TabIndex = 16;
            this.NumericAr.Text = "Ar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Varos";
            // 
            // dataGridViewVarosok
            // 
            this.dataGridViewVarosok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVarosok.Location = new System.Drawing.Point(384, 19);
            this.dataGridViewVarosok.Name = "dataGridViewVarosok";
            this.dataGridViewVarosok.Size = new System.Drawing.Size(399, 112);
            this.dataGridViewVarosok.TabIndex = 18;
            // 
            // dataGridViewLatvanyossag
            // 
            this.dataGridViewLatvanyossag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLatvanyossag.Location = new System.Drawing.Point(224, 210);
            this.dataGridViewLatvanyossag.Name = "dataGridViewLatvanyossag";
            this.dataGridViewLatvanyossag.Size = new System.Drawing.Size(559, 211);
            this.dataGridViewLatvanyossag.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 441);
            this.Controls.Add(this.dataGridViewLatvanyossag);
            this.Controls.Add(this.dataGridViewVarosok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumericAr);
            this.Controls.Add(this.varosValasz);
            this.Controls.Add(this.LeirasText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownAr);
            this.Controls.Add(this.textBoxLNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lakosagNumeric);
            this.Controls.Add(this.addCity);
            this.Controls.Add(this.textBoxNev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lakosagNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVarosok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLatvanyossag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Button addCity;
        private System.Windows.Forms.NumericUpDown lakosagNumeric;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLNev;
        private System.Windows.Forms.NumericUpDown numericUpDownAr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox LeirasText;
        private System.Windows.Forms.ComboBox varosValasz;
        private System.Windows.Forms.Label NumericAr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewVarosok;
        private System.Windows.Forms.DataGridView dataGridViewLatvanyossag;
    }
}

