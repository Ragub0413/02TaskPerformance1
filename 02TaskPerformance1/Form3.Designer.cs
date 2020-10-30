namespace _02TaskPerformance1
{
    partial class CustomerViewForm
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
            this.lblQueueNowServing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Now Serving";
            // 
            // lblQueueNowServing
            // 
            this.lblQueueNowServing.AccessibleDescription = "lblQueueNowServing";
            this.lblQueueNowServing.AutoSize = true;
            this.lblQueueNowServing.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueNowServing.Location = new System.Drawing.Point(88, 79);
            this.lblQueueNowServing.Name = "lblQueueNowServing";
            this.lblQueueNowServing.Size = new System.Drawing.Size(300, 55);
            this.lblQueueNowServing.TabIndex = 1;
            this.lblQueueNowServing.Text = "Unavailable";
            this.lblQueueNowServing.Click += new System.EventHandler(this.lblQueueNowServing_Click);
            // 
            // CustomerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 186);
            this.Controls.Add(this.lblQueueNowServing);
            this.Controls.Add(this.label1);
            this.Name = "CustomerViewForm";
            this.Text = "CustomerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblQueueNowServing;
    }
}