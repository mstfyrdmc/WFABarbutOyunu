namespace WFA_Zar_Oyunu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblZar1 = new System.Windows.Forms.Label();
            this.lblZar2 = new System.Windows.Forms.Label();
            this.btnIlkZar = new System.Windows.Forms.Button();
            this.btnIkinciZar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSkor1 = new System.Windows.Forms.Label();
            this.lblSkor2 = new System.Windows.Forms.Label();
            this.btnSkor = new System.Windows.Forms.Button();
            this.btnYeniden = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(347, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zarlar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZar1
            // 
            this.lblZar1.BackColor = System.Drawing.Color.Yellow;
            this.lblZar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZar1.Location = new System.Drawing.Point(99, 69);
            this.lblZar1.Name = "lblZar1";
            this.lblZar1.Size = new System.Drawing.Size(209, 128);
            this.lblZar1.TabIndex = 1;
            this.lblZar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZar2
            // 
            this.lblZar2.BackColor = System.Drawing.Color.Blue;
            this.lblZar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZar2.Location = new System.Drawing.Point(581, 69);
            this.lblZar2.Name = "lblZar2";
            this.lblZar2.Size = new System.Drawing.Size(209, 128);
            this.lblZar2.TabIndex = 1;
            this.lblZar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIlkZar
            // 
            this.btnIlkZar.Location = new System.Drawing.Point(99, 219);
            this.btnIlkZar.Name = "btnIlkZar";
            this.btnIlkZar.Size = new System.Drawing.Size(208, 58);
            this.btnIlkZar.TabIndex = 2;
            this.btnIlkZar.Text = "Zar At";
            this.btnIlkZar.UseVisualStyleBackColor = true;
            this.btnIlkZar.Click += new System.EventHandler(this.btnIlkZar_Click);
            // 
            // btnIkinciZar
            // 
            this.btnIkinciZar.Location = new System.Drawing.Point(582, 219);
            this.btnIkinciZar.Name = "btnIkinciZar";
            this.btnIkinciZar.Size = new System.Drawing.Size(208, 58);
            this.btnIkinciZar.TabIndex = 2;
            this.btnIkinciZar.Text = "Zar At";
            this.btnIkinciZar.UseVisualStyleBackColor = true;
            this.btnIkinciZar.Click += new System.EventHandler(this.btnIkinciZar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "1. Oyuncu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "2. Oyuncu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Skor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Skor:";
            // 
            // lblSkor1
            // 
            this.lblSkor1.AutoSize = true;
            this.lblSkor1.Location = new System.Drawing.Point(109, 59);
            this.lblSkor1.Name = "lblSkor1";
            this.lblSkor1.Size = new System.Drawing.Size(27, 29);
            this.lblSkor1.TabIndex = 5;
            this.lblSkor1.Text = "0";
            // 
            // lblSkor2
            // 
            this.lblSkor2.AutoSize = true;
            this.lblSkor2.Location = new System.Drawing.Point(86, 49);
            this.lblSkor2.Name = "lblSkor2";
            this.lblSkor2.Size = new System.Drawing.Size(27, 29);
            this.lblSkor2.TabIndex = 5;
            this.lblSkor2.Text = "0";
            // 
            // btnSkor
            // 
            this.btnSkor.Location = new System.Drawing.Point(375, 230);
            this.btnSkor.Name = "btnSkor";
            this.btnSkor.Size = new System.Drawing.Size(126, 47);
            this.btnSkor.TabIndex = 6;
            this.btnSkor.Text = "Sonuç";
            this.btnSkor.UseVisualStyleBackColor = true;
            this.btnSkor.Click += new System.EventHandler(this.btnSkor_Click);
            // 
            // btnYeniden
            // 
            this.btnYeniden.Location = new System.Drawing.Point(331, 406);
            this.btnYeniden.Name = "btnYeniden";
            this.btnYeniden.Size = new System.Drawing.Size(226, 63);
            this.btnYeniden.TabIndex = 7;
            this.btnYeniden.Text = "Yeniden Başlat";
            this.btnYeniden.UseVisualStyleBackColor = true;
            this.btnYeniden.Click += new System.EventHandler(this.btnYeniden_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.lblSkor1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(99, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 109);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.lblSkor2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(581, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 107);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(866, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "UYARI: Oyun 10\'da Biter. İyi Eğlenceler :)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnYeniden);
            this.Controls.Add(this.btnSkor);
            this.Controls.Add(this.btnIkinciZar);
            this.Controls.Add(this.btnIlkZar);
            this.Controls.Add(this.lblZar2);
            this.Controls.Add(this.lblZar1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblZar1;
        private System.Windows.Forms.Label lblZar2;
        private System.Windows.Forms.Button btnIlkZar;
        private System.Windows.Forms.Button btnIkinciZar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSkor1;
        private System.Windows.Forms.Label lblSkor2;
        private System.Windows.Forms.Button btnSkor;
        private System.Windows.Forms.Button btnYeniden;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}

