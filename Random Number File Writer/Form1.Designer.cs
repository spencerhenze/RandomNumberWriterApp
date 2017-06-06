namespace Random_Number_File_Writer
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.writeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(70, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(271, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Random Number File Writer";
            // 
            // questionLabel
            // 
            this.questionLabel.Location = new System.Drawing.Point(12, 66);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(263, 22);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "How many random numbers would you like to write?";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(149, 91);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.qtyTextBox.TabIndex = 2;
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Location = new System.Drawing.Point(94, 94);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(49, 13);
            this.qtyLabel.TabIndex = 3;
            this.qtyLabel.Text = "Quantity:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(91, 155);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(102, 23);
            this.writeButton.TabIndex = 4;
            this.writeButton.Text = "Write Numbers";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(224, 155);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Random Number File Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button exitButton;
    }
}

