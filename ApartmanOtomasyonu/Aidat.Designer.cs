
namespace ApartmanOtomasyonu
{
    partial class Aidat
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
            this.gelirler = new System.Windows.Forms.Button();
            this.giderler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gelirler
            // 
            this.gelirler.Location = new System.Drawing.Point(167, 168);
            this.gelirler.Margin = new System.Windows.Forms.Padding(6);
            this.gelirler.Name = "gelirler";
            this.gelirler.Size = new System.Drawing.Size(196, 284);
            this.gelirler.TabIndex = 0;
            this.gelirler.Text = "Gelirler";
            this.gelirler.UseVisualStyleBackColor = true;
            this.gelirler.Click += new System.EventHandler(this.gelirler_Click);
            // 
            // giderler
            // 
            this.giderler.Location = new System.Drawing.Point(621, 168);
            this.giderler.Margin = new System.Windows.Forms.Padding(6);
            this.giderler.Name = "giderler";
            this.giderler.Size = new System.Drawing.Size(196, 284);
            this.giderler.TabIndex = 1;
            this.giderler.Text = "Giderler";
            this.giderler.UseVisualStyleBackColor = true;
            this.giderler.Click += new System.EventHandler(this.giderler_Click);
            // 
            // Aidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 540);
            this.Controls.Add(this.giderler);
            this.Controls.Add(this.gelirler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Aidat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gelirler;
        private System.Windows.Forms.Button giderler;
    }
}

