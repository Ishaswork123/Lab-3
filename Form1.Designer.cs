namespace formssss
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
            this.check_it = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // check_it
            // 
            this.check_it.Location = new System.Drawing.Point(129, 155);
            this.check_it.Name = "check_it";
            this.check_it.Size = new System.Drawing.Size(115, 23);
            this.check_it.TabIndex = 1;
            this.check_it.Text = "check it";
            this.check_it.UseVisualStyleBackColor = true;
            this.check_it.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(92, 90);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(182, 36);
            this.txt.TabIndex = 2;
            this.txt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.check_it);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button check_it;
        private System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.Label label1;
    }
}

