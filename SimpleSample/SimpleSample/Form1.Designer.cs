namespace SimpleSample
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
            chartHost1 = new ChartHost();
            SuspendLayout();
            // 
            // chartHost1
            // 
            chartHost1.Location = new Point(101, 126);
            chartHost1.Name = "chartHost1";
            chartHost1.Size = new Size(736, 301);
            chartHost1.TabIndex = 0;
            chartHost1.Text = "chartHost1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 521);
            Controls.Add(chartHost1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ChartHost chartHost1;
    }
}
