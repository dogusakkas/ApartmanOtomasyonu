
namespace ApartmanOtomasyonu
{
    partial class Giderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giderler));
            this.chk_Elektrik = new System.Windows.Forms.CheckBox();
            this.chk_su = new System.Windows.Forms.CheckBox();
            this.chk_asansor = new System.Windows.Forms.CheckBox();
            this.chk_temizlik = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Elektrik
            // 
            this.chk_Elektrik.AutoSize = true;
            this.chk_Elektrik.Location = new System.Drawing.Point(19, 53);
            this.chk_Elektrik.Name = "chk_Elektrik";
            this.chk_Elektrik.Size = new System.Drawing.Size(89, 28);
            this.chk_Elektrik.TabIndex = 0;
            this.chk_Elektrik.Text = "Elektrik";
            this.chk_Elektrik.UseVisualStyleBackColor = true;
            // 
            // chk_su
            // 
            this.chk_su.AutoSize = true;
            this.chk_su.Location = new System.Drawing.Point(19, 99);
            this.chk_su.Name = "chk_su";
            this.chk_su.Size = new System.Drawing.Size(52, 28);
            this.chk_su.TabIndex = 1;
            this.chk_su.Text = "Su";
            this.chk_su.UseVisualStyleBackColor = true;
            // 
            // chk_asansor
            // 
            this.chk_asansor.AutoSize = true;
            this.chk_asansor.Location = new System.Drawing.Point(19, 142);
            this.chk_asansor.Name = "chk_asansor";
            this.chk_asansor.Size = new System.Drawing.Size(98, 28);
            this.chk_asansor.TabIndex = 2;
            this.chk_asansor.Text = "Asansör";
            this.chk_asansor.UseVisualStyleBackColor = true;
            // 
            // chk_temizlik
            // 
            this.chk_temizlik.AutoSize = true;
            this.chk_temizlik.Location = new System.Drawing.Point(19, 195);
            this.chk_temizlik.Name = "chk_temizlik";
            this.chk_temizlik.Size = new System.Drawing.Size(98, 28);
            this.chk_temizlik.TabIndex = 3;
            this.chk_temizlik.Text = "Temizlik";
            this.chk_temizlik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarih :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(432, 45);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(191, 29);
            this.numericUpDown1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(432, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 29);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.chk_Elektrik);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.chk_su);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.chk_asansor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chk_temizlik);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 275);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giderler";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(63, 354);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 172);
            this.listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(289, 354);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(140, 172);
            this.listBox2.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 24;
            this.listBox3.Location = new System.Drawing.Point(527, 354);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(140, 172);
            this.listBox3.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(24, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 38);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 538);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Giderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.Giderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Elektrik;
        private System.Windows.Forms.CheckBox chk_su;
        private System.Windows.Forms.CheckBox chk_asansor;
        private System.Windows.Forms.CheckBox chk_temizlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button2;
    }
}