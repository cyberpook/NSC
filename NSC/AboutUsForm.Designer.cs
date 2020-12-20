
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
            this.instaMaksym = new System.Windows.Forms.Button();
            this.GitHub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InstaYuriy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instaMykha
            // 
            this.instaMykha.Image = ((System.Drawing.Image)(resources.GetObject("instaMykha.Image")));
            this.instaMykha.Location = new System.Drawing.Point(405, 200);
            this.instaMykha.Name = "instaMykha";
            this.instaMykha.Size = new System.Drawing.Size(50, 50);
            this.instaMykha.TabIndex = 0;
            this.instaMykha.UseVisualStyleBackColor = true;
            this.instaMykha.Click += new System.EventHandler(this.instaMykha_Click);
            // 
            // instaMaksym
            // 
            this.instaMaksym.Image = ((System.Drawing.Image)(resources.GetObject("instaMaksym.Image")));
            this.instaMaksym.Location = new System.Drawing.Point(451, 200);
            this.instaMaksym.Name = "instaMaksym";
            this.instaMaksym.Size = new System.Drawing.Size(50, 50);
            this.instaMaksym.TabIndex = 1;
            this.instaMaksym.UseVisualStyleBackColor = true;
            this.instaMaksym.Click += new System.EventHandler(this.instaMaksym_Click);
            // 
            // GitHub
            // 
            this.GitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GitHub.Image = ((System.Drawing.Image)(resources.GetObject("GitHub.Image")));
            this.GitHub.Location = new System.Drawing.Point(315, 200);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(50, 50);
            this.GitHub.TabIndex = 2;
            this.GitHub.UseVisualStyleBackColor = true;
            this.GitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Follow us on our GitHub\nand Instagram accounts.";
            // 
            // InstaYuriy
            // 
            this.InstaYuriy.Image = ((System.Drawing.Image)(resources.GetObject("InstaYuriy.Image")));
            this.InstaYuriy.Location = new System.Drawing.Point(361, 200);
            this.InstaYuriy.Name = "InstaYuriy";
            this.InstaYuriy.Size = new System.Drawing.Size(50, 50);
            this.InstaYuriy.TabIndex = 4;
            this.InstaYuriy.UseVisualStyleBackColor = true;
            this.InstaYuriy.Click += new System.EventHandler(this.InstaYuriy_Click);
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.InstaYuriy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GitHub);
            this.Controls.Add(this.instaMaksym);
            this.Controls.Add(this.instaMykha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(516, 289);
            this.MinimumSize = new System.Drawing.Size(516, 289);
            this.Name = "AboutUsForm";
            this.Text = "About Us";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button instaMykha;
        private System.Windows.Forms.Button instaMaksym;
        private System.Windows.Forms.Button GitHub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InstaYuriy;
    }
}