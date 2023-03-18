namespace WinFormsApp2
{
    partial class Lesson
    {
        private System.ComponentModel.IContainer componet = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (componet != null))
            {
                componet.Dispose();
            }
            base.Dispose(disposing);
        }
       private void InitializeComponent1()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 284);
            this.Name = "Lesson";
            this.Load += new System.EventHandler(this.Lesson_Load);
            this.ResumeLayout(false);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lesson));
            SuspendLayout();
            // 
            // Lesson
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Name = "Lesson";
            Load += Lesson_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}