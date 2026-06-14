namespace SetMouseForGames
{
    partial class GameDataUC
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
            InGameCursorPx = new Label();
            FirstPersonAimPx = new Label();
            MainSpinValueHolder = new Label();
            CopyFromInGameCursorPx = new Button();
            CopyFromFirstPersonAimPx = new Button();
            PasteValueToInGameCursorPx = new Button();
            PasteValueToFirstPersonAimPx = new Button();
            ResetScratchpad = new Button();
            SuspendLayout();
            // 
            // InGameCursorPx
            // 
            InGameCursorPx.AutoSize = true;
            InGameCursorPx.Location = new Point(68, 85);
            InGameCursorPx.Name = "InGameCursorPx";
            InGameCursorPx.Size = new Size(13, 15);
            InGameCursorPx.TabIndex = 26;
            InGameCursorPx.Text = "0";
            // 
            // FirstPersonAimPx
            // 
            FirstPersonAimPx.AutoSize = true;
            FirstPersonAimPx.Location = new Point(68, 52);
            FirstPersonAimPx.Name = "FirstPersonAimPx";
            FirstPersonAimPx.Size = new Size(13, 15);
            FirstPersonAimPx.TabIndex = 25;
            FirstPersonAimPx.Text = "0";
            // 
            // MainSpinValueHolder
            // 
            MainSpinValueHolder.AutoSize = true;
            MainSpinValueHolder.Location = new Point(122, 19);
            MainSpinValueHolder.Name = "MainSpinValueHolder";
            MainSpinValueHolder.Size = new Size(13, 15);
            MainSpinValueHolder.TabIndex = 24;
            MainSpinValueHolder.Text = "0";
            // 
            // CopyFromInGameCursorPx
            // 
            CopyFromInGameCursorPx.Location = new Point(112, 81);
            CopyFromInGameCursorPx.Name = "CopyFromInGameCursorPx";
            CopyFromInGameCursorPx.Size = new Size(23, 23);
            CopyFromInGameCursorPx.TabIndex = 23;
            CopyFromInGameCursorPx.Text = ">";
            CopyFromInGameCursorPx.UseVisualStyleBackColor = true;
            CopyFromInGameCursorPx.Click += CopyFromInGameCursorPx_Click;
            // 
            // CopyFromFirstPersonAimPx
            // 
            CopyFromFirstPersonAimPx.Location = new Point(112, 48);
            CopyFromFirstPersonAimPx.Name = "CopyFromFirstPersonAimPx";
            CopyFromFirstPersonAimPx.Size = new Size(23, 23);
            CopyFromFirstPersonAimPx.TabIndex = 22;
            CopyFromFirstPersonAimPx.Text = ">";
            CopyFromFirstPersonAimPx.UseVisualStyleBackColor = true;
            CopyFromFirstPersonAimPx.Click += CopyFromFirstPersonAimPx_Click;
            // 
            // PasteValueToInGameCursorPx
            // 
            PasteValueToInGameCursorPx.Location = new Point(39, 81);
            PasteValueToInGameCursorPx.Name = "PasteValueToInGameCursorPx";
            PasteValueToInGameCursorPx.Size = new Size(23, 23);
            PasteValueToInGameCursorPx.TabIndex = 21;
            PasteValueToInGameCursorPx.Text = ">";
            PasteValueToInGameCursorPx.UseVisualStyleBackColor = true;
            PasteValueToInGameCursorPx.Click += PasteValueToInGameCursorPx_Click;
            // 
            // PasteValueToFirstPersonAimPx
            // 
            PasteValueToFirstPersonAimPx.Location = new Point(39, 48);
            PasteValueToFirstPersonAimPx.Name = "PasteValueToFirstPersonAimPx";
            PasteValueToFirstPersonAimPx.Size = new Size(23, 23);
            PasteValueToFirstPersonAimPx.TabIndex = 20;
            PasteValueToFirstPersonAimPx.Text = ">";
            PasteValueToFirstPersonAimPx.UseVisualStyleBackColor = true;
            PasteValueToFirstPersonAimPx.Click += PasteValueToFirstPersonAimPx_Click;
            // 
            // ResetScratchpad
            // 
            ResetScratchpad.Location = new Point(3, 13);
            ResetScratchpad.Name = "ResetScratchpad";
            ResetScratchpad.Size = new Size(113, 27);
            ResetScratchpad.TabIndex = 27;
            ResetScratchpad.Text = "Reset scratchpad";
            ResetScratchpad.UseVisualStyleBackColor = true;
            ResetScratchpad.Click += button1_Click;
            // 
            // GameDataUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ResetScratchpad);
            Controls.Add(InGameCursorPx);
            Controls.Add(FirstPersonAimPx);
            Controls.Add(MainSpinValueHolder);
            Controls.Add(CopyFromInGameCursorPx);
            Controls.Add(CopyFromFirstPersonAimPx);
            Controls.Add(PasteValueToInGameCursorPx);
            Controls.Add(PasteValueToFirstPersonAimPx);
            Name = "GameDataUC";
            Size = new Size(198, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InGameCursorPx;
        private Label FirstPersonAimPx;
        private Label MainSpinValueHolder;
        private Button CopyFromInGameCursorPx;
        private Button CopyFromFirstPersonAimPx;
        private Button PasteValueToInGameCursorPx;
        private Button PasteValueToFirstPersonAimPx;
        private Button ResetScratchpad;
    }
}
