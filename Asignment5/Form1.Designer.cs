namespace Asignment5
{
    partial class FRMMain
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
            this.LBLWrite = new System.Windows.Forms.Label();
            this.TXTWrite = new System.Windows.Forms.TextBox();
            this.LBLRead = new System.Windows.Forms.Label();
            this.TXTRead = new System.Windows.Forms.TextBox();
            this.BTNWrite = new System.Windows.Forms.Button();
            this.BTNRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLWrite
            // 
            this.LBLWrite.AutoSize = true;
            this.LBLWrite.Location = new System.Drawing.Point(6, 6);
            this.LBLWrite.Name = "LBLWrite";
            this.LBLWrite.Size = new System.Drawing.Size(35, 13);
            this.LBLWrite.TabIndex = 0;
            this.LBLWrite.Text = "الك&تابة";
            this.LBLWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXTWrite
            // 
            this.TXTWrite.Location = new System.Drawing.Point(48, 6);
            this.TXTWrite.Name = "TXTWrite";
            this.TXTWrite.Size = new System.Drawing.Size(100, 20);
            this.TXTWrite.TabIndex = 1;
            // 
            // LBLRead
            // 
            this.LBLRead.AutoSize = true;
            this.LBLRead.Location = new System.Drawing.Point(6, 35);
            this.LBLRead.Name = "LBLRead";
            this.LBLRead.Size = new System.Drawing.Size(36, 13);
            this.LBLRead.TabIndex = 2;
            this.LBLRead.Text = "الق&راءة";
            this.LBLRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXTRead
            // 
            this.TXTRead.Location = new System.Drawing.Point(48, 32);
            this.TXTRead.Multiline = true;
            this.TXTRead.Name = "TXTRead";
            this.TXTRead.Size = new System.Drawing.Size(100, 20);
            this.TXTRead.TabIndex = 3;
            // 
            // BTNWrite
            // 
            this.BTNWrite.AutoSize = true;
            this.BTNWrite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNWrite.Location = new System.Drawing.Point(6, 58);
            this.BTNWrite.Name = "BTNWrite";
            this.BTNWrite.Size = new System.Drawing.Size(39, 23);
            this.BTNWrite.TabIndex = 4;
            this.BTNWrite.Text = "ا&كتب";
            this.BTNWrite.UseVisualStyleBackColor = true;
            this.BTNWrite.Click += new System.EventHandler(this.BTNWrite_Click);
            // 
            // BTNRead
            // 
            this.BTNRead.AutoSize = true;
            this.BTNRead.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNRead.Location = new System.Drawing.Point(115, 58);
            this.BTNRead.Name = "BTNRead";
            this.BTNRead.Size = new System.Drawing.Size(33, 23);
            this.BTNRead.TabIndex = 5;
            this.BTNRead.Text = "ا&قرأ";
            this.BTNRead.UseVisualStyleBackColor = true;
            this.BTNRead.Click += new System.EventHandler(this.BTNRead_Click);
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNRead);
            this.Controls.Add(this.BTNWrite);
            this.Controls.Add(this.TXTRead);
            this.Controls.Add(this.LBLRead);
            this.Controls.Add(this.TXTWrite);
            this.Controls.Add(this.LBLWrite);
            this.Name = "FRMMain";
            this.Text = "الواجب الخامس";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLWrite;
        private System.Windows.Forms.TextBox TXTWrite;
        private System.Windows.Forms.Label LBLRead;
        private System.Windows.Forms.TextBox TXTRead;
        private System.Windows.Forms.Button BTNWrite;
        private System.Windows.Forms.Button BTNRead;
    }
}

