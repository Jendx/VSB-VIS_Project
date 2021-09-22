using System;

namespace WF
{
    partial class ZvyseniProverky
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
            this.ZamitnoutButton = new System.Windows.Forms.Button();
            this.PotvrditButton = new System.Windows.Forms.Button();
            this.listBoxVrchniVyzkumnik = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(299, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zvyšení prověrky";
            // 
            // ZamitnoutButton
            // 
            this.ZamitnoutButton.Location = new System.Drawing.Point(425, 375);
            this.ZamitnoutButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ZamitnoutButton.Name = "ZamitnoutButton";
            this.ZamitnoutButton.Size = new System.Drawing.Size(114, 35);
            this.ZamitnoutButton.TabIndex = 1;
            this.ZamitnoutButton.Text = "Zamitnout";
            this.ZamitnoutButton.UseVisualStyleBackColor = true;
            this.ZamitnoutButton.Click += new System.EventHandler(this.buttonNO_Click);
            // 
            // PotvrditButton
            // 
            this.PotvrditButton.Location = new System.Drawing.Point(236, 375);
            this.PotvrditButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PotvrditButton.Name = "PotvrditButton";
            this.PotvrditButton.Size = new System.Drawing.Size(114, 35);
            this.PotvrditButton.TabIndex = 0;
            this.PotvrditButton.Text = "Potvrdit";
            this.PotvrditButton.UseVisualStyleBackColor = true;
            this.PotvrditButton.Click += new System.EventHandler(this.buttonYES_Click);
            // 
            // listBoxVrchniVyzkumnik
            // 
            this.listBoxVrchniVyzkumnik.FormattingEnabled = true;
            this.listBoxVrchniVyzkumnik.ItemHeight = 15;
            this.listBoxVrchniVyzkumnik.Location = new System.Drawing.Point(324, 84);
            this.listBoxVrchniVyzkumnik.Name = "listBoxVrchniVyzkumnik";
            this.listBoxVrchniVyzkumnik.Size = new System.Drawing.Size(120, 229);
            this.listBoxVrchniVyzkumnik.TabIndex = 5;
            // 
            // ZvyseniProverky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxVrchniVyzkumnik);
            this.Controls.Add(this.PotvrditButton);
            this.Controls.Add(this.ZamitnoutButton);
            this.Controls.Add(this.label1);
            this.Name = "ZvyseniProverky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZvyseniProverky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ZamitnoutButton;
        private System.Windows.Forms.Button PotvrditButton;
        private System.Windows.Forms.ListBox listBoxVrchniVyzkumnik;
    }
}