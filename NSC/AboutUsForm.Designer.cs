
namespace NSC
{
    partial class AboutUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsForm));
            this.instaMykha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instaMykha
            // 
            this.instaMykha.Location = new System.Drawing.Point(301, 148);
            this.instaMykha.Name = "instaMykha";
            this.instaMykha.Size = new System.Drawing.Size(100, 100);
            this.instaMykha.TabIndex = 0;
            this.instaMykha.Text = "Mykhailo\'s instagram";
            this.instaMykha.UseVisualStyleBackColor = true;
            this.instaMykha.Click += new System.EventHandler(this.instaMykha_Click);
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.instaMykha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(516, 289);
            this.MinimumSize = new System.Drawing.Size(516, 289);
            this.Name = "AboutUsForm";
            this.Text = "About Us";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button instaMykha;
    }
}