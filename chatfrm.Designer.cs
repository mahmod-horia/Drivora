namespace drivora
{
    partial class chatfrm
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
            this.cTextBox1 = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.cTextBox2 = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cTextBox1
            // 
            this.cTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.cTextBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox1.ForeColor = System.Drawing.Color.White;
            this.cTextBox1.Location = new System.Drawing.Point(12, 473);
            this.cTextBox1.Multiline = true;
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Size = new System.Drawing.Size(542, 46);
            this.cTextBox1.TabIndex = 34;
            this.cTextBox1.WaterMark = "Write your question here";
            this.cTextBox1.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.cTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox1.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // cTextBox2
            // 
            this.cTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.cTextBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox2.ForeColor = System.Drawing.Color.White;
            this.cTextBox2.Location = new System.Drawing.Point(12, 82);
            this.cTextBox2.Multiline = true;
            this.cTextBox2.Name = "cTextBox2";
            this.cTextBox2.ReadOnly = true;
            this.cTextBox2.Size = new System.Drawing.Size(677, 372);
            this.cTextBox2.TabIndex = 35;
            this.cTextBox2.WaterMark = "Ask me anything";
            this.cTextBox2.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.cTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextBox2.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 65);
            this.label1.TabIndex = 36;
            this.label1.Text = "Welcom to AI CHAT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(96)))), ((int)(((byte)(115)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::drivora.Properties.Resources.Paper_Plane;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(560, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 37;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::drivora.Properties.Resources.ChatGPT;
            this.pictureBox1.Location = new System.Drawing.Point(631, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // chatfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(701, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cTextBox2);
            this.Controls.Add(this.cTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chatfrm";
            this.Text = "chatfrm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ChreneLib.Controls.TextBoxes.CTextBox cTextBox1;
        public ChreneLib.Controls.TextBoxes.CTextBox cTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}