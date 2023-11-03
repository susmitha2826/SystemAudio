namespace RecordSystemAudio
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
            label1 = new Label();
            OutputDeviceComboBox = new ComboBox();
            StartButton = new Button();
            StopButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(91, 54);
            label1.Name = "label1";
            label1.Size = new Size(136, 17);
            label1.TabIndex = 0;
            label1.Text = "Select Output Device";
            label1.Click += label1_Click;
            // 
            // OutputDeviceComboBox
            // 
            OutputDeviceComboBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OutputDeviceComboBox.FormattingEnabled = true;
            OutputDeviceComboBox.Location = new Point(255, 51);
            OutputDeviceComboBox.Name = "OutputDeviceComboBox";
            OutputDeviceComboBox.Size = new Size(227, 25);
            OutputDeviceComboBox.TabIndex = 1;
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            StartButton.Location = new Point(174, 111);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(110, 23);
            StartButton.TabIndex = 2;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Enabled = false;
            StopButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            StopButton.Location = new Point(380, 111);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(108, 23);
            StopButton.TabIndex = 3;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 175);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Controls.Add(OutputDeviceComboBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox OutputDeviceComboBox;
        private Button StartButton;
        private Button StopButton;
    }
}