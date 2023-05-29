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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LisääYrTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(896, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asiakasrekisteri";
            // 
            // LisääYrBT
            // 
            this.LisääYrBT.Location = new System.Drawing.Point(389, 572);
            this.LisääYrBT.Name = "LisääYrBT";
            this.LisääYrBT.Size = new System.Drawing.Size(165, 23);
            this.LisääYrBT.TabIndex = 2;
            this.LisääYrBT.Text = "Lisää";
            this.LisääYrBT.UseVisualStyleBackColor = true;
            // 
            // PoistaYrBT
            // 
            this.PoistaYrBT.Location = new System.Drawing.Point(590, 572);
            this.PoistaYrBT.Name = "PoistaYrBT";
            this.PoistaYrBT.Size = new System.Drawing.Size(165, 23);
            this.PoistaYrBT.TabIndex = 3;
            this.PoistaYrBT.Text = "Poista";
            this.PoistaYrBT.UseVisualStyleBackColor = true;
            // 
            // LisaaTiedotBT
            // 
            this.LisaaTiedotBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LisaaTiedotBT.Location = new System.Drawing.Point(916, 550);
            this.LisaaTiedotBT.Name = "LisaaTiedotBT";
            this.LisaaTiedotBT.Size = new System.Drawing.Size(267, 45);
            this.LisaaTiedotBT.TabIndex = 4;
            this.LisaaTiedotBT.Text = "Lisää";
            this.LisaaTiedotBT.UseVisualStyleBackColor = true;
            // 
            // PoistaTiedotBT
            // 
            this.PoistaTiedotBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaTiedotBT.Location = new System.Drawing.Point(1379, 550);
            this.PoistaTiedotBT.Name = "PoistaTiedotBT";
            this.PoistaTiedotBT.Size = new System.Drawing.Size(239, 45);
            this.PoistaTiedotBT.TabIndex = 5;
            this.PoistaTiedotBT.Text = "Poista";
            this.PoistaTiedotBT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Slogan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 417);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(916, 111);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(702, 417);
            this.dataGridView2.TabIndex = 14;
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 39);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yritykset";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1096, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 42);
            this.label5.TabIndex = 17;
            this.label5.Text = "Yrityksien lisätiedot";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 650);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LisääYrTB);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PoistaTiedotBT);
            this.Controls.Add(this.LisaaTiedotBT);
            this.Controls.Add(this.PoistaYrBT);
            this.Controls.Add(this.LisääYrBT);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox LisääYrTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

