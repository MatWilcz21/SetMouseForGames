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
            UpdateMouseInfo = new Button();
            SelectGameCombo = new ComboBox();
            SelectGameButton = new Button();
            CreateNewGameButton = new Button();
            EnterGameNameTextBox = new TextBox();
            DeleteGameFromList = new Button();
            PasteValueToFirstPersonAimPx = new Button();
            PasteValueToInGameCursorPx = new Button();
            CopyFromFirstPersonAimPx = new Button();
            CopyFromInGameCursorPx = new Button();
            MouseInfoLabel = new Label();
            MouseDPITextBox = new TextBox();
            SetMouseDpi = new Button();
            SelectedGameNameLabel = new Label();
            MainSpinValueHolder = new Label();
            FirstPersonAimPx = new Label();
            InGameCursorPx = new Label();
            SuspendLayout();
            // 
            // UpdateMouseInfo
            // 
            UpdateMouseInfo.Location = new Point(267, 275);
            UpdateMouseInfo.Name = "UpdateMouseInfo";
            UpdateMouseInfo.Size = new Size(75, 23);
            UpdateMouseInfo.TabIndex = 0;
            UpdateMouseInfo.Text = "Update mouse";
            UpdateMouseInfo.UseVisualStyleBackColor = true;
            UpdateMouseInfo.Click += button1_Click;
            // 
            // SelectGameCombo
            // 
            SelectGameCombo.FormattingEnabled = true;
            SelectGameCombo.Location = new Point(12, 81);
            SelectGameCombo.Name = "SelectGameCombo";
            SelectGameCombo.Size = new Size(121, 23);
            SelectGameCombo.TabIndex = 1;
            // 
            // SelectGameButton
            // 
            SelectGameButton.Location = new Point(13, 51);
            SelectGameButton.Name = "SelectGameButton";
            SelectGameButton.Size = new Size(120, 23);
            SelectGameButton.TabIndex = 2;
            SelectGameButton.Text = "Select Game";
            SelectGameButton.UseVisualStyleBackColor = true;
            SelectGameButton.Click += SelectGameButton_Click;
            // 
            // CreateNewGameButton
            // 
            CreateNewGameButton.Location = new Point(151, 51);
            CreateNewGameButton.Name = "CreateNewGameButton";
            CreateNewGameButton.Size = new Size(120, 23);
            CreateNewGameButton.TabIndex = 3;
            CreateNewGameButton.Text = "Add game";
            CreateNewGameButton.UseVisualStyleBackColor = true;
            CreateNewGameButton.Click += CreateNewGameButton_Click;
            // 
            // EnterGameNameTextBox
            // 
            EnterGameNameTextBox.Location = new Point(151, 80);
            EnterGameNameTextBox.Name = "EnterGameNameTextBox";
            EnterGameNameTextBox.Size = new Size(120, 23);
            EnterGameNameTextBox.TabIndex = 4;
            // 
            // DeleteGameFromList
            // 
            DeleteGameFromList.Location = new Point(12, 110);
            DeleteGameFromList.Name = "DeleteGameFromList";
            DeleteGameFromList.Size = new Size(120, 23);
            DeleteGameFromList.TabIndex = 5;
            DeleteGameFromList.Text = "Del selected game";
            DeleteGameFromList.UseVisualStyleBackColor = true;
            DeleteGameFromList.Click += DeleteGameFromList_Click;
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
            // MouseInfoLabel
            // 
            MouseInfoLabel.AutoSize = true;
            MouseInfoLabel.Location = new Point(369, 273);
            MouseInfoLabel.Name = "MouseInfoLabel";
            MouseInfoLabel.Size = new Size(38, 15);
            MouseInfoLabel.TabIndex = 13;
            MouseInfoLabel.Text = "label1";
            MouseInfoLabel.Click += label1_Click;
            // 
            // MouseDPITextBox
            // 
            MouseDPITextBox.Location = new Point(348, 247);
            MouseDPITextBox.Name = "MouseDPITextBox";
            MouseDPITextBox.Size = new Size(100, 23);
            MouseDPITextBox.TabIndex = 14;
            // 
            // SetMouseDpi
            // 
            SetMouseDpi.Location = new Point(267, 246);
            SetMouseDpi.Name = "SetMouseDpi";
            SetMouseDpi.Size = new Size(75, 23);
            SetMouseDpi.TabIndex = 15;
            SetMouseDpi.Text = "Mouse DPI";
            SetMouseDpi.UseVisualStyleBackColor = true;
            SetMouseDpi.Click += SetMouseDpi_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 508);
            Controls.Add(InGameCursorPx);
            Controls.Add(FirstPersonAimPx);
            Controls.Add(MainSpinValueHolder);
            Controls.Add(SelectedGameNameLabel);
            Controls.Add(SetMouseDpi);
            Controls.Add(MouseDPITextBox);
            Controls.Add(MouseInfoLabel);
            Controls.Add(CopyFromInGameCursorPx);
            Controls.Add(CopyFromFirstPersonAimPx);
            Controls.Add(PasteValueToInGameCursorPx);
            Controls.Add(PasteValueToFirstPersonAimPx);
            Controls.Add(DeleteGameFromList);
            Controls.Add(EnterGameNameTextBox);
            Controls.Add(CreateNewGameButton);
            Controls.Add(SelectGameButton);
            Controls.Add(SelectGameCombo);
            Controls.Add(UpdateMouseInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateMouseInfo;
        private ComboBox SelectGameCombo;
        private Button SelectGameButton;
        private Button CreateNewGameButton;
        private TextBox EnterGameNameTextBox;
        private Button DeleteGameFromList;
        private Button PasteValueToFirstPersonAimPx;
        private Button PasteValueToInGameCursorPx;
        private Button CopyFromFirstPersonAimPx;
        private Button CopyFromInGameCursorPx;
        private Label MouseInfoLabel;
        private TextBox MouseDPITextBox;
        private Button SetMouseDpi;
        private Label SelectedGameNameLabel;
        private Label MainSpinValueHolder;
        private Label FirstPersonAimPx;
        private Label InGameCursorPx;
    }
}
