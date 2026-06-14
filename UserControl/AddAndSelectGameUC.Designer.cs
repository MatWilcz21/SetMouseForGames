namespace SetMouseForGames
{
    partial class AddAndSelectGameUC
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
            DeleteGameFromList = new Button();
            EnterGameNameTextBox = new TextBox();
            CreateNewGameButton = new Button();
            SelectGameButton = new Button();
            SelectGameCombo = new ComboBox();
            SuspendLayout();
            // 
            // DeleteGameFromList
            // 
            DeleteGameFromList.Location = new Point(26, 79);
            DeleteGameFromList.Name = "DeleteGameFromList";
            DeleteGameFromList.Size = new Size(120, 23);
            DeleteGameFromList.TabIndex = 10;
            DeleteGameFromList.Text = "Del selected game";
            DeleteGameFromList.UseVisualStyleBackColor = true;
            DeleteGameFromList.Click += DeleteGameFromList_Click;
            // 
            // EnterGameNameTextBox
            // 
            EnterGameNameTextBox.Location = new Point(165, 49);
            EnterGameNameTextBox.Name = "EnterGameNameTextBox";
            EnterGameNameTextBox.Size = new Size(120, 23);
            EnterGameNameTextBox.TabIndex = 9;
            // 
            // CreateNewGameButton
            // 
            CreateNewGameButton.Location = new Point(165, 20);
            CreateNewGameButton.Name = "CreateNewGameButton";
            CreateNewGameButton.Size = new Size(120, 23);
            CreateNewGameButton.TabIndex = 8;
            CreateNewGameButton.Text = "Add game";
            CreateNewGameButton.UseVisualStyleBackColor = true;
            CreateNewGameButton.Click += CreateNewGameButton_Click;
            // 
            // SelectGameButton
            // 
            SelectGameButton.Location = new Point(27, 20);
            SelectGameButton.Name = "SelectGameButton";
            SelectGameButton.Size = new Size(120, 23);
            SelectGameButton.TabIndex = 7;
            SelectGameButton.Text = "Select Game";
            SelectGameButton.UseVisualStyleBackColor = true;
            SelectGameButton.Click += SelectGameButton_Click;
            // 
            // SelectGameCombo
            // 
            SelectGameCombo.FormattingEnabled = true;
            SelectGameCombo.Location = new Point(26, 50);
            SelectGameCombo.Name = "SelectGameCombo";
            SelectGameCombo.Size = new Size(121, 23);
            SelectGameCombo.TabIndex = 6;
            // 
            // AddAndSelectGameUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteGameFromList);
            Controls.Add(EnterGameNameTextBox);
            Controls.Add(CreateNewGameButton);
            Controls.Add(SelectGameButton);
            Controls.Add(SelectGameCombo);
            Name = "AddAndSelectGameUC";
            Size = new Size(317, 142);
            Load += AddAndSelectGameUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteGameFromList;
        private TextBox EnterGameNameTextBox;
        private Button CreateNewGameButton;
        private Button SelectGameButton;
        private ComboBox SelectGameCombo;
    }
}
