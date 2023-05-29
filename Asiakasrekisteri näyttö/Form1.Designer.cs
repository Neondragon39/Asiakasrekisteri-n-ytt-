namespace Asiakasrekisteri_näyttö
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
            this.label1 = new System.Windows.Forms.Label();
            this.LisääYrBT = new System.Windows.Forms.Button();
            this.PoistaYrBT = new System.Windows.Forms.Button();
            this.LisaaTiedotBT = new System.Windows.Forms.Button();
            this.PoistaTiedotBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.YrityksetGV = new System.Windows.Forms.DataGridView();
            this.LisätiedotGV = new System.Windows.Forms.DataGridView();
            this.LisääYrTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYritysYhteyshenkilot = new System.Windows.Forms.Button();
            this.btnValitse = new System.Windows.Forms.Button();
            this.btnNaytayhteydenotot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YrityksetGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LisätiedotGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(623, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asiakasrekisteri";
            // 
            // LisääYrBT
            // 
            this.LisääYrBT.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LisääYrBT.Location = new System.Drawing.Point(386, 550);
            this.LisääYrBT.Name = "LisääYrBT";
            this.LisääYrBT.Size = new System.Drawing.Size(105, 45);
            this.LisääYrBT.TabIndex = 2;
            this.LisääYrBT.Text = "Lisää yritys";
            this.LisääYrBT.UseVisualStyleBackColor = true;
            // 
            // PoistaYrBT
            // 
            this.PoistaYrBT.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaYrBT.Location = new System.Drawing.Point(497, 550);
            this.PoistaYrBT.Name = "PoistaYrBT";
            this.PoistaYrBT.Size = new System.Drawing.Size(118, 45);
            this.PoistaYrBT.TabIndex = 3;
            this.PoistaYrBT.Text = "Poista yritys";
            this.PoistaYrBT.UseVisualStyleBackColor = true;
            // 
            // LisaaTiedotBT
            // 
            this.LisaaTiedotBT.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LisaaTiedotBT.Location = new System.Drawing.Point(916, 550);
            this.LisaaTiedotBT.Name = "LisaaTiedotBT";
            this.LisaaTiedotBT.Size = new System.Drawing.Size(184, 45);
            this.LisaaTiedotBT.TabIndex = 4;
            this.LisaaTiedotBT.Text = "Lisää lisätietoa";
            this.LisaaTiedotBT.UseVisualStyleBackColor = true;
            this.LisaaTiedotBT.Visible = false;
            this.LisaaTiedotBT.Click += new System.EventHandler(this.LisaaTiedotBT_Click);
            // 
            // PoistaTiedotBT
            // 
            this.PoistaTiedotBT.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaTiedotBT.Location = new System.Drawing.Point(1148, 550);
            this.PoistaTiedotBT.Name = "PoistaTiedotBT";
            this.PoistaTiedotBT.Size = new System.Drawing.Size(206, 45);
            this.PoistaTiedotBT.TabIndex = 5;
            this.PoistaTiedotBT.Text = "Poista lisätietoa";
            this.PoistaTiedotBT.UseVisualStyleBackColor = true;
            this.PoistaTiedotBT.Visible = false;
            this.PoistaTiedotBT.Click += new System.EventHandler(this.PoistaTiedotBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(89, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Coding for the future ";
            // 
            // YrityksetGV
            // 
            this.YrityksetGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.YrityksetGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YrityksetGV.Location = new System.Drawing.Point(58, 111);
            this.YrityksetGV.Name = "YrityksetGV";
            this.YrityksetGV.Size = new System.Drawing.Size(706, 417);
            this.YrityksetGV.TabIndex = 13;
            this.YrityksetGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LisätiedotGV
            // 
            this.LisätiedotGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.LisätiedotGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LisätiedotGV.Location = new System.Drawing.Point(916, 111);
            this.LisätiedotGV.Name = "LisätiedotGV";
            this.LisätiedotGV.Size = new System.Drawing.Size(702, 417);
            this.LisätiedotGV.TabIndex = 14;
            // 
            // LisääYrTB
            // 
            this.LisääYrTB.Location = new System.Drawing.Point(58, 550);
            this.LisääYrTB.Multiline = true;
            this.LisääYrTB.Name = "LisääYrTB";
            this.LisääYrTB.Size = new System.Drawing.Size(291, 45);
            this.LisääYrTB.TabIndex = 15;
            this.LisääYrTB.Text = "Yrityksien nimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(307, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 47);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yritykset";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(1094, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(480, 51);
            this.label5.TabIndex = 17;
            this.label5.Text = "Yhteydenotot asiakkaisiin\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(916, 174);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 32);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Y-Tunnus";
            this.textBox1.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(916, 262);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(345, 32);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "Postinumero";
            this.textBox3.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(916, 362);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(345, 32);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "Toimiala";
            this.textBox5.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1273, 174);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(345, 32);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "Katuosoite";
            this.textBox2.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(1273, 262);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(345, 32);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "Kaupunki";
            this.textBox4.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(1273, 362);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(345, 32);
            this.textBox6.TabIndex = 24;
            this.textBox6.Text = "Puhelinnumero";
            this.textBox6.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(92, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ohketoimi Oy";
            // 
            // btnYritysYhteyshenkilot
            // 
            this.btnYritysYhteyshenkilot.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYritysYhteyshenkilot.Location = new System.Drawing.Point(959, 422);
            this.btnYritysYhteyshenkilot.Name = "btnYritysYhteyshenkilot";
            this.btnYritysYhteyshenkilot.Size = new System.Drawing.Size(244, 65);
            this.btnYritysYhteyshenkilot.TabIndex = 27;
            this.btnYritysYhteyshenkilot.Text = "Lisää yhteishenkilöiden yhteystiedot";
            this.btnYritysYhteyshenkilot.UseVisualStyleBackColor = true;
            this.btnYritysYhteyshenkilot.Visible = false;
            this.btnYritysYhteyshenkilot.Click += new System.EventHandler(this.btnYritysYhteyshenkilot_Click);
            // 
            // btnValitse
            // 
            this.btnValitse.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValitse.Location = new System.Drawing.Point(621, 550);
            this.btnValitse.Name = "btnValitse";
            this.btnValitse.Size = new System.Drawing.Size(143, 45);
            this.btnValitse.TabIndex = 28;
            this.btnValitse.Text = "Valitse yritys";
            this.btnValitse.UseVisualStyleBackColor = true;
            this.btnValitse.Click += new System.EventHandler(this.btnValitse_Click);
            // 
            // btnNaytayhteydenotot
            // 
            this.btnNaytayhteydenotot.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaytayhteydenotot.Location = new System.Drawing.Point(1412, 550);
            this.btnNaytayhteydenotot.Name = "btnNaytayhteydenotot";
            this.btnNaytayhteydenotot.Size = new System.Drawing.Size(206, 45);
            this.btnNaytayhteydenotot.TabIndex = 29;
            this.btnNaytayhteydenotot.Text = "Näytä yhteydenotot";
            this.btnNaytayhteydenotot.UseVisualStyleBackColor = true;
            this.btnNaytayhteydenotot.Visible = false;
            this.btnNaytayhteydenotot.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1792, 650);
            this.Controls.Add(this.btnNaytayhteydenotot);
            this.Controls.Add(this.btnValitse);
            this.Controls.Add(this.btnYritysYhteyshenkilot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LisääYrTB);
            this.Controls.Add(this.LisätiedotGV);
            this.Controls.Add(this.YrityksetGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PoistaTiedotBT);
            this.Controls.Add(this.LisaaTiedotBT);
            this.Controls.Add(this.PoistaYrBT);
            this.Controls.Add(this.LisääYrBT);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.YrityksetGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LisätiedotGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LisääYrBT;
        private System.Windows.Forms.Button PoistaYrBT;
        private System.Windows.Forms.Button LisaaTiedotBT;
        private System.Windows.Forms.Button PoistaTiedotBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView YrityksetGV;
        private System.Windows.Forms.DataGridView LisätiedotGV;
        private System.Windows.Forms.TextBox LisääYrTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYritysYhteyshenkilot;
        private System.Windows.Forms.Button btnValitse;
        private System.Windows.Forms.Button btnNaytayhteydenotot;
    }
}

