﻿
using System.Windows.Forms;

namespace NSC
{
    partial class NSC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NSC));
            this.input = new System.Windows.Forms.TextBox();
            this.inputAsking = new System.Windows.Forms.Label();
            this.binary = new System.Windows.Forms.TextBox();
            this.octal = new System.Windows.Forms.TextBox();
            this.binLabel = new System.Windows.Forms.Label();
            this.octLabel = new System.Windows.Forms.Label();
            this.hexadecimal = new System.Windows.Forms.TextBox();
            this.hexadec = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SystemSelect = new System.Windows.Forms.ComboBox();
            this.ConverFrom = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.Location = new System.Drawing.Point(12, 132);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(155, 20);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // inputAsking
            // 
            this.inputAsking.AutoSize = true;
            this.inputAsking.BackColor = System.Drawing.Color.Transparent;
            this.inputAsking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputAsking.Location = new System.Drawing.Point(12, 116);
            this.inputAsking.Name = "inputAsking";
            this.inputAsking.Size = new System.Drawing.Size(0, 15);
            this.inputAsking.TabIndex = 1;
            // 
            // binary
            // 
            this.binary.Location = new System.Drawing.Point(218, 65);
            this.binary.Name = "binary";
            this.binary.ReadOnly = true;
            this.binary.Size = new System.Drawing.Size(230, 20);
            this.binary.TabIndex = 2;
            // 
            // octal
            // 
            this.octal.Location = new System.Drawing.Point(218, 132);
            this.octal.Name = "octal";
            this.octal.ReadOnly = true;
            this.octal.Size = new System.Drawing.Size(230, 20);
            this.octal.TabIndex = 3;
            // 
            // binLabel
            // 
            this.binLabel.AutoSize = true;
            this.binLabel.BackColor = System.Drawing.Color.Transparent;
            this.binLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.binLabel.Location = new System.Drawing.Point(215, 49);
            this.binLabel.Name = "binLabel";
            this.binLabel.Size = new System.Drawing.Size(88, 15);
            this.binLabel.TabIndex = 4;
            this.binLabel.Text = "Binary form: ";
            // 
            // octLabel
            // 
            this.octLabel.AutoSize = true;
            this.octLabel.BackColor = System.Drawing.Color.Transparent;
            this.octLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.octLabel.Location = new System.Drawing.Point(215, 116);
            this.octLabel.Name = "octLabel";
            this.octLabel.Size = new System.Drawing.Size(81, 15);
            this.octLabel.TabIndex = 5;
            this.octLabel.Text = "Octal form: ";
            // 
            // hexadecimal
            // 
            this.hexadecimal.Location = new System.Drawing.Point(218, 196);
            this.hexadecimal.Name = "hexadecimal";
            this.hexadecimal.ReadOnly = true;
            this.hexadecimal.Size = new System.Drawing.Size(230, 20);
            this.hexadecimal.TabIndex = 6;
            // 
            // hexadec
            // 
            this.hexadec.AutoSize = true;
            this.hexadec.BackColor = System.Drawing.Color.Transparent;
            this.hexadec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hexadec.Location = new System.Drawing.Point(215, 178);
            this.hexadec.Name = "hexadec";
            this.hexadec.Size = new System.Drawing.Size(132, 15);
            this.hexadec.TabIndex = 7;
            this.hexadec.Text = "Hexadecimal form: ";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(-1, 229);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.exitButtonClicked);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Transparent;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(12, 164);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 17);
            this.error.TabIndex = 9;
            this.error.Visible = false;
            // 
            // SystemSelect
            // 
            this.SystemSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SystemSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SystemSelect.FormattingEnabled = true;
            this.SystemSelect.Items.AddRange(new object[] {
            "Binary",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.SystemSelect.Location = new System.Drawing.Point(12, 64);
            this.SystemSelect.Name = "SystemSelect";
            this.SystemSelect.Size = new System.Drawing.Size(155, 21);
            this.SystemSelect.TabIndex = 10;
            this.SystemSelect.SelectedIndexChanged += new System.EventHandler(this.SystemSelect_SelectedIndexChanged);
            // 
            // ConverFrom
            // 
            this.ConverFrom.AutoSize = true;
            this.ConverFrom.BackColor = System.Drawing.Color.Transparent;
            this.ConverFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConverFrom.Location = new System.Drawing.Point(12, 49);
            this.ConverFrom.Name = "ConverFrom";
            this.ConverFrom.Size = new System.Drawing.Size(92, 15);
            this.ConverFrom.TabIndex = 11;
            this.ConverFrom.Text = "Convert from:";
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(425, 0);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(75, 23);
            this.About.TabIndex = 12;
            this.About.Text = "About us";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // NSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.About);
            this.Controls.Add(this.ConverFrom);
            this.Controls.Add(this.SystemSelect);
            this.Controls.Add(this.error);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.hexadec);
            this.Controls.Add(this.hexadecimal);
            this.Controls.Add(this.octLabel);
            this.Controls.Add(this.binLabel);
            this.Controls.Add(this.octal);
            this.Controls.Add(this.binary);
            this.Controls.Add(this.inputAsking);
            this.Controls.Add(this.input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(516, 289);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(516, 289);
            this.Name = "NSC";
            this.Text = "NSC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label inputAsking;
        private System.Windows.Forms.TextBox binary;
        private System.Windows.Forms.TextBox octal;
        private System.Windows.Forms.Label binLabel;
        private Label octLabel;
        private TextBox hexadecimal;
        private Label hexadec;
        private Button ExitButton;
        private Label error;
        private ComboBox SystemSelect;
        private Label ConverFrom;
        private Button About;
    }
}

