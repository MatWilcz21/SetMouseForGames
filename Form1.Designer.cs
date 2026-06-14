namespace SetMouseForGames
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
            PasteValueToFirstPersonAimPx = new Button();
            PasteValueToInGameCursorPx = new Button();
            CopyFromFirstPersonAimPx = new Button();
            CopyFromInGameCursorPx = new Button();
            SelectedGameNameLabel = new Label();
            MainSpinValueHolder = new Label();
            FirstPersonAimPx = new Label();
            InGameCursorPx = new Label();
            addAndSelectGameuc1 = new AddAndSelectGameUC();
            mouseInfouc1 = new MouseInfoUC();
            SuspendLayout();
            // 
            // PasteValueToFirstPersonAimPx
            // 
            PasteValueToFirstPersonAimPx.Location = new Point(682, 81);
            PasteValueToFirstPersonAimPx.Name = "PasteValueToFirstPersonAimPx";
            PasteValueToFirstPersonAimPx.Size = new Size(23, 23);
            PasteValueToFirstPersonAimPx.TabIndex = 9;
            PasteValueToFirstPersonAimPx.Text = ">";
            PasteValueToFirstPersonAimPx.UseVisualStyleBackColor = true;
            PasteValueToFirstPersonAimPx.Click += PasteValueToFirstPersonAimPx_Click;
            // 
            // PasteValueToInGameCursorPx
            // 
            PasteValueToInGameCursorPx.Location = new Point(682, 114);
            PasteValueToInGameCursorPx.Name = "PasteValueToInGameCursorPx";
            PasteValueToInGameCursorPx.Size = new Size(23, 23);
            PasteValueToInGameCursorPx.TabIndex = 10;
            PasteValueToInGameCursorPx.Text = ">";
            PasteValueToInGameCursorPx.UseVisualStyleBackColor = true;
            PasteValueToInGameCursorPx.Click += PasteValueToInGameCursorPx_Click;
            // 
            // CopyFromFirstPersonAimPx
            // 
            CopyFromFirstPersonAimPx.Location = new Point(755, 81);
            CopyFromFirstPersonAimPx.Name = "CopyFromFirstPersonAimPx";
            CopyFromFirstPersonAimPx.Size = new Size(23, 23);
            CopyFromFirstPersonAimPx.TabIndex = 11;
            CopyFromFirstPersonAimPx.Text = ">";
            CopyFromFirstPersonAimPx.UseVisualStyleBackColor = true;
            CopyFromFirstPersonAimPx.Click += CopyFromFirstPersonAimPx_Click;
            // 
            // CopyFromInGameCursorPx
            // 
            CopyFromInGameCursorPx.Location = new Point(755, 114);
            CopyFromInGameCursorPx.Name = "CopyFromInGameCursorPx";
            CopyFromInGameCursorPx.Size = new Size(23, 23);
            CopyFromInGameCursorPx.TabIndex = 12;
            CopyFromInGameCursorPx.Text = ">";
            CopyFromInGameCursorPx.UseVisualStyleBackColor = true;
            CopyFromInGameCursorPx.Click += CopyFromInGameCursorPx_Click;
            // 
            // SelectedGameNameLabel
            // 
            SelectedGameNameLabel.AutoSize = true;
            SelectedGameNameLabel.Font = new Font("Segoe UI", 15F);
            SelectedGameNameLabel.Location = new Point(277, 9);
            SelectedGameNameLabel.Name = "SelectedGameNameLabel";
            SelectedGameNameLabel.Size = new Size(28, 28);
            SelectedGameNameLabel.TabIndex = 16;
            SelectedGameNameLabel.Text = "__";
            // 
            // MainSpinValueHolder
            // 
            MainSpinValueHolder.AutoSize = true;
            MainSpinValueHolder.Location = new Point(649, 59);
            MainSpinValueHolder.Name = "MainSpinValueHolder";
            MainSpinValueHolder.Size = new Size(13, 15);
            MainSpinValueHolder.TabIndex = 17;
            MainSpinValueHolder.Text = "0";
            // 
            // FirstPersonAimPx
            // 
            FirstPersonAimPx.AutoSize = true;
            FirstPersonAimPx.Location = new Point(711, 85);
            FirstPersonAimPx.Name = "FirstPersonAimPx";
            FirstPersonAimPx.Size = new Size(13, 15);
            FirstPersonAimPx.TabIndex = 18;
            FirstPersonAimPx.Text = "0";
            FirstPersonAimPx.Click += FirstPersonAimPx_Click;
            // 
            // InGameCursorPx
            // 
            InGameCursorPx.AutoSize = true;
            InGameCursorPx.Location = new Point(711, 118);
            InGameCursorPx.Name = "InGameCursorPx";
            InGameCursorPx.Size = new Size(13, 15);
            InGameCursorPx.TabIndex = 19;
            InGameCursorPx.Text = "0";
            // 
            // addAndSelectGameuc1
            // 
            addAndSelectGameuc1.Location = new Point(2, 40);
            addAndSelectGameuc1.Name = "addAndSelectGameuc1";
            addAndSelectGameuc1.Size = new Size(317, 142);
            addAndSelectGameuc1.TabIndex = 20;
            // 
            // mouseInfouc1
            // 
            mouseInfouc1.Location = new Point(599, 361);
            mouseInfouc1.Name = "mouseInfouc1";
            mouseInfouc1.Size = new Size(201, 119);
            mouseInfouc1.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 508);
            Controls.Add(mouseInfouc1);
            Controls.Add(addAndSelectGameuc1);
            Controls.Add(InGameCursorPx);
            Controls.Add(FirstPersonAimPx);
            Controls.Add(MainSpinValueHolder);
            Controls.Add(SelectedGameNameLabel);
            Controls.Add(CopyFromInGameCursorPx);
            Controls.Add(CopyFromFirstPersonAimPx);
            Controls.Add(PasteValueToInGameCursorPx);
            Controls.Add(PasteValueToFirstPersonAimPx);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button PasteValueToFirstPersonAimPx;
        private Button PasteValueToInGameCursorPx;
        private Button CopyFromFirstPersonAimPx;
        private Button CopyFromInGameCursorPx;
        private Label SelectedGameNameLabel;
        private Label MainSpinValueHolder;
        private Label FirstPersonAimPx;
        private Label InGameCursorPx;
        public AddAndSelectGameUC addAndSelectGameuc1;
        public MouseInfoUC mouseInfouc1;
    }
}