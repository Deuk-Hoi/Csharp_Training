namespace SecondForm_Method_
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
            this.Chanege = new System.Windows.Forms.Button();
            this.InchTextBox = new System.Windows.Forms.TextBox();
            this.exampleA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmTextBox = new System.Windows.Forms.TextBox();
            this.PoundTextbox = new System.Windows.Forms.TextBox();
            this.KgTextBox = new System.Windows.Forms.TextBox();
            this.exampleB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Chanege
            // 
            this.Chanege.Location = new System.Drawing.Point(13, 13);
            this.Chanege.Name = "Chanege";
            this.Chanege.Size = new System.Drawing.Size(75, 23);
            this.Chanege.TabIndex = 0;
            this.Chanege.Text = "Change";
            this.Chanege.UseVisualStyleBackColor = true;
            this.Chanege.Click += new System.EventHandler(this.Chanege_Click);
            // 
            // InchTextBox
            // 
            this.InchTextBox.Location = new System.Drawing.Point(12, 94);
            this.InchTextBox.Name = "InchTextBox";
            this.InchTextBox.Size = new System.Drawing.Size(100, 23);
            this.InchTextBox.TabIndex = 1;
            // 
            // exampleA
            // 
            this.exampleA.AutoSize = true;
            this.exampleA.Location = new System.Drawing.Point(13, 59);
            this.exampleA.Name = "exampleA";
            this.exampleA.Size = new System.Drawing.Size(116, 15);
            this.exampleA.TabIndex = 2;
            this.exampleA.Text = "예제 A (inch -> cm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "=>";
            // 
            // CmTextBox
            // 
            this.CmTextBox.Location = new System.Drawing.Point(165, 94);
            this.CmTextBox.Name = "CmTextBox";
            this.CmTextBox.Size = new System.Drawing.Size(100, 23);
            this.CmTextBox.TabIndex = 4;
            // 
            // PoundTextbox
            // 
            this.PoundTextbox.Location = new System.Drawing.Point(12, 170);
            this.PoundTextbox.Name = "PoundTextbox";
            this.PoundTextbox.Size = new System.Drawing.Size(100, 23);
            this.PoundTextbox.TabIndex = 5;
            // 
            // KgTextBox
            // 
            this.KgTextBox.Location = new System.Drawing.Point(165, 170);
            this.KgTextBox.Name = "KgTextBox";
            this.KgTextBox.Size = new System.Drawing.Size(100, 23);
            this.KgTextBox.TabIndex = 6;
            // 
            // exampleB
            // 
            this.exampleB.AutoSize = true;
            this.exampleB.Location = new System.Drawing.Point(12, 139);
            this.exampleB.Name = "exampleB";
            this.exampleB.Size = new System.Drawing.Size(124, 15);
            this.exampleB.TabIndex = 2;
            this.exampleB.Text = "예제 B (Pound -> Kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "=>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exampleB);
            this.Controls.Add(this.KgTextBox);
            this.Controls.Add(this.PoundTextbox);
            this.Controls.Add(this.CmTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exampleA);
            this.Controls.Add(this.InchTextBox);
            this.Controls.Add(this.Chanege);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Chanege;
        private System.Windows.Forms.TextBox InchTextBox;
        private System.Windows.Forms.Label exampleA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CmTextBox;
        private System.Windows.Forms.TextBox PoundTextbox;
        private System.Windows.Forms.TextBox KgTextBox;
        private System.Windows.Forms.Label exampleB;
        private System.Windows.Forms.Label label2;
    }
}

