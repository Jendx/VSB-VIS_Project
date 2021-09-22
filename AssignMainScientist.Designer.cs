namespace WF
{
    partial class AssignMainScientist
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
            this.Vrchní_výzkumník = new System.Windows.Forms.ListBox();
            this.SCP = new System.Windows.Forms.ListBox();
            this.Assign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxProverka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vrchní_výzkumník
            // 
            this.Vrchní_výzkumník.FormattingEnabled = true;
            this.Vrchní_výzkumník.ItemHeight = 15;
            this.Vrchní_výzkumník.Location = new System.Drawing.Point(284, 93);
            this.Vrchní_výzkumník.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Vrchní_výzkumník.Name = "Vrchní_výzkumník";
            this.Vrchní_výzkumník.Size = new System.Drawing.Size(139, 349);
            this.Vrchní_výzkumník.TabIndex = 0;
            this.Vrchní_výzkumník.SelectedIndexChanged += new System.EventHandler(this.Vrchní_výzkumník_SelectedIndexChanged);
            // 
            // SCP
            // 
            this.SCP.FormattingEnabled = true;
            this.SCP.ItemHeight = 15;
            this.SCP.Location = new System.Drawing.Point(458, 93);
            this.SCP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SCP.Name = "SCP";
            this.SCP.Size = new System.Drawing.Size(187, 349);
            this.SCP.TabIndex = 1;
            // 
            // Assign
            // 
            this.Assign.Location = new System.Drawing.Point(774, 463);
            this.Assign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Assign.Name = "Assign";
            this.Assign.Size = new System.Drawing.Size(126, 33);
            this.Assign.TabIndex = 2;
            this.Assign.Text = "Přiřadit";
            this.Assign.UseVisualStyleBackColor = true;
            this.Assign.Click += new System.EventHandler(this.Assign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Přiřazení vrchního výzkumníka";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 463);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Zpět";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxProverka
            // 
            this.textBoxProverka.Location = new System.Drawing.Point(61, 104);
            this.textBoxProverka.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxProverka.MaxLength = 2;
            this.textBoxProverka.Name = "textBoxProverka";
            this.textBoxProverka.Size = new System.Drawing.Size(24, 23);
            this.textBoxProverka.TabIndex = 6;
            this.textBoxProverka.TextChanged += new System.EventHandler(this.textBoxProverka_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prověření";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vrchni výzkumníci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "SCP objekt";
            // 
            // AssignMainScientist
            // 
            this.AcceptButton = this.Assign;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProverka);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Assign);
            this.Controls.Add(this.SCP);
            this.Controls.Add(this.Vrchní_výzkumník);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AssignMainScientist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přiřazení vrchního výzkumníka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Vrchní_výzkumník;
        private System.Windows.Forms.ListBox SCP;
        private System.Windows.Forms.Button Assign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxProverka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}