namespace MultilineTextEditor.Paste.MWA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new TextBox();
            this.propertyGrid1 = new PropertyGrid();
            this.label1 = new Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(12, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(776, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "etaoin shrdlu";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new Point(12, 99);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new Size(776, 339);
            this.propertyGrid1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(391, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Copy-paste from the MultilineStringEditor to the TextBox works.\r\nCopy-paste from the TextBox to the MultilineStringEditor does not work. ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PropertyGrid propertyGrid1;
        private Label label1;
    }
}
