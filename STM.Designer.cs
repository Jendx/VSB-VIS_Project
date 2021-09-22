using System;

namespace WF
{
    partial class STM
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
            this.VýzkumníkListBox = new System.Windows.Forms.ListBox();
            this.ČlenovéListBox = new System.Windows.Forms.ListBox();
            this.ADD = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.SEND = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vybrání člena týmu";
            // 
            // VýzkumníkListBox
            // 
            this.VýzkumníkListBox.FormattingEnabled = true;
            this.VýzkumníkListBox.ItemHeight = 15;
            this.VýzkumníkListBox.Location = new System.Drawing.Point(267, 92);
            this.VýzkumníkListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VýzkumníkListBox.Name = "VýzkumníkListBox";
            this.VýzkumníkListBox.Size = new System.Drawing.Size(139, 259);
            this.VýzkumníkListBox.TabIndex = 1;
            // 
            // ČlenovéListBox
            // 
            this.ČlenovéListBox.FormattingEnabled = true;
            this.ČlenovéListBox.ItemHeight = 15;
            this.ČlenovéListBox.Location = new System.Drawing.Point(534, 92);
            this.ČlenovéListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ČlenovéListBox.Name = "ČlenovéListBox";
            this.ČlenovéListBox.Size = new System.Drawing.Size(139, 259);
            this.ČlenovéListBox.TabIndex = 2;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(425, 130);
            this.ADD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(88, 27);
            this.ADD.TabIndex = 3;
            this.ADD.Text = "Přidat";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(425, 275);
            this.Remove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(88, 27);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // SEND
            // 
            this.SEND.Location = new System.Drawing.Point(734, 429);
            this.SEND.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SEND.Name = "SEND";
            this.SEND.Size = new System.Drawing.Size(121, 45);
            this.SEND.TabIndex = 5;
            this.SEND.Text = "Odeslat";
            this.SEND.UseVisualStyleBackColor = true;
            this.SEND.Click += new System.EventHandler(this.SEND_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(14, 429);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(128, 45);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Zpět";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // STM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SEND);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.ČlenovéListBox);
            this.Controls.Add(this.VýzkumníkListBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "STM";
            this.Text = "Vybrání člena týmu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox VýzkumníkListBox;
        private System.Windows.Forms.ListBox ČlenovéListBox;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button SEND;
        private System.Windows.Forms.Button BackButton;
    }
}