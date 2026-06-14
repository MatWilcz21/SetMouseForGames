namespace SetMouseForGames
{
    partial class MouseInfoUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SetMouseDpi = new Button();
            MouseDPITextBox = new TextBox();
            MouseInfoLabelX = new Label();
            UpdateMouseInfo = new Button();
            SuspendLayout();
            // 
            // SetMouseDpi
            // 
            SetMouseDpi.Location = new Point(8, 12);
            SetMouseDpi.Name = "SetMouseDpi";
            SetMouseDpi.Size = new Size(75, 23);
            SetMouseDpi.TabIndex = 19;
            SetMouseDpi.Text = "Mouse DPI";
            SetMouseDpi.UseVisualStyleBackColor = true;
            SetMouseDpi.Click += SetMouseDpi_Click;
            // 
            // MouseDPITextBox
            // 
            MouseDPITextBox.Location = new Point(89, 13);
            MouseDPITextBox.Name = "MouseDPITextBox";
            MouseDPITextBox.Size = new Size(100, 23);
            MouseDPITextBox.TabIndex = 18;
            // 
            // MouseInfoLabelX
            // 
            MouseInfoLabelX.AutoSize = true;
            MouseInfoLabelX.Location = new Point(110, 39);
            MouseInfoLabelX.Name = "MouseInfoLabelX";
            MouseInfoLabelX.Size = new Size(38, 15);
            MouseInfoLabelX.TabIndex = 17;
            MouseInfoLabelX.Text = "label1";
            // 
            // UpdateMouseInfo
            // 
            UpdateMouseInfo.Location = new Point(8, 41);
            UpdateMouseInfo.Name = "UpdateMouseInfo";
            UpdateMouseInfo.Size = new Size(75, 23);
            UpdateMouseInfo.TabIndex = 16;
            UpdateMouseInfo.Text = "Update mouse";
            UpdateMouseInfo.UseVisualStyleBackColor = true;
            UpdateMouseInfo.Click += button1_Click;
            // 
            // MouseInfoUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SetMouseDpi);
            Controls.Add(MouseDPITextBox);
            Controls.Add(MouseInfoLabelX);
            Controls.Add(UpdateMouseInfo);
            Name = "MouseInfoUC";
            Size = new Size(201, 119);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SetMouseDpi;
        private TextBox MouseDPITextBox;
        private Label MouseInfoLabelX;
        private Button UpdateMouseInfo;
    }
}
