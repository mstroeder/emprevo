namespace CarPark
{
    partial class InputForm
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
            this.EntryTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExitTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.EntryTimeLabel = new System.Windows.Forms.Label();
            this.ExitTimeLabel = new System.Windows.Forms.Label();
            this.ResultsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EntryTimePicker
            // 
            this.EntryTimePicker.CustomFormat = "d-MMM-yyyy hh:mm tt";
            this.EntryTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EntryTimePicker.Location = new System.Drawing.Point(32, 50);
            this.EntryTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntryTimePicker.Name = "EntryTimePicker";
            this.EntryTimePicker.Size = new System.Drawing.Size(330, 32);
            this.EntryTimePicker.TabIndex = 1;
            // 
            // ExitTimePicker
            // 
            this.ExitTimePicker.CustomFormat = "d-MMM-yyyy hh:mm tt";
            this.ExitTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExitTimePicker.Location = new System.Drawing.Point(32, 124);
            this.ExitTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitTimePicker.Name = "ExitTimePicker";
            this.ExitTimePicker.Size = new System.Drawing.Size(330, 32);
            this.ExitTimePicker.TabIndex = 3;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(32, 192);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(331, 58);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate -->";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // EntryTimeLabel
            // 
            this.EntryTimeLabel.AutoSize = true;
            this.EntryTimeLabel.Location = new System.Drawing.Point(32, 21);
            this.EntryTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EntryTimeLabel.Name = "EntryTimeLabel";
            this.EntryTimeLabel.Size = new System.Drawing.Size(123, 25);
            this.EntryTimeLabel.TabIndex = 0;
            this.EntryTimeLabel.Text = "Entry Time";
            // 
            // ExitTimeLabel
            // 
            this.ExitTimeLabel.AutoSize = true;
            this.ExitTimeLabel.Location = new System.Drawing.Point(32, 95);
            this.ExitTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitTimeLabel.Name = "ExitTimeLabel";
            this.ExitTimeLabel.Size = new System.Drawing.Size(107, 25);
            this.ExitTimeLabel.TabIndex = 2;
            this.ExitTimeLabel.Text = "Exit Time";
            // 
            // ResultsBox
            // 
            this.ResultsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsBox.Location = new System.Drawing.Point(393, 21);
            this.ResultsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultsBox.Multiline = true;
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsBox.Size = new System.Drawing.Size(968, 370);
            this.ResultsBox.TabIndex = 5;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1378, 404);
            this.Controls.Add(this.ResultsBox);
            this.Controls.Add(this.ExitTimeLabel);
            this.Controls.Add(this.EntryTimeLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExitTimePicker);
            this.Controls.Add(this.EntryTimePicker);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InputForm";
            this.Text = "Test Input Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker EntryTimePicker;
        private System.Windows.Forms.DateTimePicker ExitTimePicker;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label EntryTimeLabel;
        private System.Windows.Forms.Label ExitTimeLabel;
        private System.Windows.Forms.TextBox ResultsBox;
    }
}