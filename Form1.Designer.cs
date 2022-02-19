
namespace Stream_Client
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonStreamHighQuality = new System.Windows.Forms.Button();
            this.buttonStreamLowLatency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(393, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // buttonStreamHighQuality
            // 
            this.buttonStreamHighQuality.Location = new System.Drawing.Point(144, 29);
            this.buttonStreamHighQuality.Name = "buttonStreamHighQuality";
            this.buttonStreamHighQuality.Size = new System.Drawing.Size(75, 49);
            this.buttonStreamHighQuality.TabIndex = 1;
            this.buttonStreamHighQuality.Text = "Stream High Quality";
            this.buttonStreamHighQuality.UseVisualStyleBackColor = true;
            // 
            // buttonStreamLowLatency
            // 
            this.buttonStreamLowLatency.Location = new System.Drawing.Point(251, 29);
            this.buttonStreamLowLatency.Name = "buttonStreamLowLatency";
            this.buttonStreamLowLatency.Size = new System.Drawing.Size(75, 49);
            this.buttonStreamLowLatency.TabIndex = 2;
            this.buttonStreamLowLatency.Text = "Stream Low Latency";
            this.buttonStreamLowLatency.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStreamLowLatency);
            this.Controls.Add(this.buttonStreamHighQuality);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonStreamHighQuality;
        private System.Windows.Forms.Button buttonStreamLowLatency;
    }
}

