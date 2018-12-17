namespace Torens_van_Hanoi_Groep_2
{
    partial class MainForm
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
            this.forLoopButton = new System.Windows.Forms.Button();
            this.forLoopTextBox = new System.Windows.Forms.TextBox();
            this.forLoopLabel = new System.Windows.Forms.Label();
            this.forLoopGroupBox = new System.Windows.Forms.GroupBox();
            this.machtsverheffingGroupBox = new System.Windows.Forms.GroupBox();
            this.machtsverheffingTextBox = new System.Windows.Forms.TextBox();
            this.machtsverheffingButton = new System.Windows.Forms.Button();
            this.machtsverheffingLabel = new System.Windows.Forms.Label();
            this.incursieGroupBox = new System.Windows.Forms.GroupBox();
            this.RecursieTextBox = new System.Windows.Forms.TextBox();
            this.IncursieButton = new System.Windows.Forms.Button();
            this.incursieLabel = new System.Windows.Forms.Label();
            this.forLoopGroupBox.SuspendLayout();
            this.machtsverheffingGroupBox.SuspendLayout();
            this.incursieGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // forLoopButton
            // 
            this.forLoopButton.Location = new System.Drawing.Point(47, 139);
            this.forLoopButton.Margin = new System.Windows.Forms.Padding(4);
            this.forLoopButton.Name = "forLoopButton";
            this.forLoopButton.Size = new System.Drawing.Size(201, 48);
            this.forLoopButton.TabIndex = 0;
            this.forLoopButton.Text = "Bereken";
            this.forLoopButton.UseVisualStyleBackColor = true;
            this.forLoopButton.Click += new System.EventHandler(this.forLoopButton_Click);
            // 
            // forLoopTextBox
            // 
            this.forLoopTextBox.Location = new System.Drawing.Point(47, 39);
            this.forLoopTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.forLoopTextBox.Name = "forLoopTextBox";
            this.forLoopTextBox.Size = new System.Drawing.Size(200, 22);
            this.forLoopTextBox.TabIndex = 6;
            // 
            // forLoopLabel
            // 
            this.forLoopLabel.AutoSize = true;
            this.forLoopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forLoopLabel.Location = new System.Drawing.Point(103, 89);
            this.forLoopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forLoopLabel.Name = "forLoopLabel";
            this.forLoopLabel.Size = new System.Drawing.Size(84, 25);
            this.forLoopLabel.TabIndex = 13;
            this.forLoopLabel.Text = "uitkomst";
            // 
            // forLoopGroupBox
            // 
            this.forLoopGroupBox.Controls.Add(this.forLoopTextBox);
            this.forLoopGroupBox.Controls.Add(this.forLoopButton);
            this.forLoopGroupBox.Controls.Add(this.forLoopLabel);
            this.forLoopGroupBox.Location = new System.Drawing.Point(16, 53);
            this.forLoopGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.forLoopGroupBox.Name = "forLoopGroupBox";
            this.forLoopGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.forLoopGroupBox.Size = new System.Drawing.Size(293, 214);
            this.forLoopGroupBox.TabIndex = 16;
            this.forLoopGroupBox.TabStop = false;
            this.forLoopGroupBox.Text = "for loop";
            // 
            // machtsverheffingGroupBox
            // 
            this.machtsverheffingGroupBox.Controls.Add(this.machtsverheffingTextBox);
            this.machtsverheffingGroupBox.Controls.Add(this.machtsverheffingButton);
            this.machtsverheffingGroupBox.Controls.Add(this.machtsverheffingLabel);
            this.machtsverheffingGroupBox.Location = new System.Drawing.Point(317, 53);
            this.machtsverheffingGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.machtsverheffingGroupBox.Name = "machtsverheffingGroupBox";
            this.machtsverheffingGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.machtsverheffingGroupBox.Size = new System.Drawing.Size(293, 214);
            this.machtsverheffingGroupBox.TabIndex = 17;
            this.machtsverheffingGroupBox.TabStop = false;
            this.machtsverheffingGroupBox.Text = "machtsverheffing";
            // 
            // machtsverheffingTextBox
            // 
            this.machtsverheffingTextBox.Location = new System.Drawing.Point(51, 39);
            this.machtsverheffingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.machtsverheffingTextBox.Name = "machtsverheffingTextBox";
            this.machtsverheffingTextBox.Size = new System.Drawing.Size(200, 22);
            this.machtsverheffingTextBox.TabIndex = 6;
            // 
            // machtsverheffingButton
            // 
            this.machtsverheffingButton.Location = new System.Drawing.Point(51, 139);
            this.machtsverheffingButton.Margin = new System.Windows.Forms.Padding(4);
            this.machtsverheffingButton.Name = "machtsverheffingButton";
            this.machtsverheffingButton.Size = new System.Drawing.Size(201, 48);
            this.machtsverheffingButton.TabIndex = 0;
            this.machtsverheffingButton.Text = "Bereken";
            this.machtsverheffingButton.UseVisualStyleBackColor = true;
            this.machtsverheffingButton.Click += new System.EventHandler(this.machtsverheffingButton_Click);
            // 
            // machtsverheffingLabel
            // 
            this.machtsverheffingLabel.AutoSize = true;
            this.machtsverheffingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machtsverheffingLabel.Location = new System.Drawing.Point(107, 89);
            this.machtsverheffingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.machtsverheffingLabel.Name = "machtsverheffingLabel";
            this.machtsverheffingLabel.Size = new System.Drawing.Size(84, 25);
            this.machtsverheffingLabel.TabIndex = 13;
            this.machtsverheffingLabel.Text = "uitkomst";
            // 
            // incursieGroupBox
            // 
            this.incursieGroupBox.Controls.Add(this.RecursieTextBox);
            this.incursieGroupBox.Controls.Add(this.IncursieButton);
            this.incursieGroupBox.Controls.Add(this.incursieLabel);
            this.incursieGroupBox.Location = new System.Drawing.Point(619, 53);
            this.incursieGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.incursieGroupBox.Name = "incursieGroupBox";
            this.incursieGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.incursieGroupBox.Size = new System.Drawing.Size(293, 214);
            this.incursieGroupBox.TabIndex = 18;
            this.incursieGroupBox.TabStop = false;
            this.incursieGroupBox.Text = "incursie";
            // 
            // RecursieTextBox
            // 
            this.RecursieTextBox.Location = new System.Drawing.Point(51, 39);
            this.RecursieTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RecursieTextBox.Name = "RecursieTextBox";
            this.RecursieTextBox.Size = new System.Drawing.Size(200, 22);
            this.RecursieTextBox.TabIndex = 6;
            // 
            // IncursieButton
            // 
            this.IncursieButton.Location = new System.Drawing.Point(51, 139);
            this.IncursieButton.Margin = new System.Windows.Forms.Padding(4);
            this.IncursieButton.Name = "IncursieButton";
            this.IncursieButton.Size = new System.Drawing.Size(201, 48);
            this.IncursieButton.TabIndex = 0;
            this.IncursieButton.Text = "Bereken";
            this.IncursieButton.UseVisualStyleBackColor = true;
            // 
            // incursieLabel
            // 
            this.incursieLabel.AutoSize = true;
            this.incursieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incursieLabel.Location = new System.Drawing.Point(107, 89);
            this.incursieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incursieLabel.Name = "incursieLabel";
            this.incursieLabel.Size = new System.Drawing.Size(84, 25);
            this.incursieLabel.TabIndex = 13;
            this.incursieLabel.Text = "uitkomst";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 318);
            this.Controls.Add(this.incursieGroupBox);
            this.Controls.Add(this.machtsverheffingGroupBox);
            this.Controls.Add(this.forLoopGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Torens van Hanoi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.forLoopGroupBox.ResumeLayout(false);
            this.forLoopGroupBox.PerformLayout();
            this.machtsverheffingGroupBox.ResumeLayout(false);
            this.machtsverheffingGroupBox.PerformLayout();
            this.incursieGroupBox.ResumeLayout(false);
            this.incursieGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button forLoopButton;
        private System.Windows.Forms.TextBox forLoopTextBox;
        private System.Windows.Forms.Label forLoopLabel;
        private System.Windows.Forms.GroupBox forLoopGroupBox;
        private System.Windows.Forms.GroupBox machtsverheffingGroupBox;
        private System.Windows.Forms.TextBox machtsverheffingTextBox;
        private System.Windows.Forms.Button machtsverheffingButton;
        private System.Windows.Forms.Label machtsverheffingLabel;
        private System.Windows.Forms.GroupBox incursieGroupBox;
        private System.Windows.Forms.TextBox RecursieTextBox;
        private System.Windows.Forms.Button IncursieButton;
        private System.Windows.Forms.Label incursieLabel;
    }
}

