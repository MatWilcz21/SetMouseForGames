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
            addAndSelectGameuc1 = new AddAndSelectGameUC();
            mouseInfouc1 = new MouseInfoUC();
            gameDatauc1 = new GameDataUC();
            simpleAutoclickeruc1 = new SimpleAutoClickerUC();
            simpleMouseMoveruc1 = new SimpleMouseMoverUC();
            SuspendLayout();
            // 
            // addAndSelectGameuc1
            // 
            addAndSelectGameuc1.Location = new Point(12, 12);
            addAndSelectGameuc1.Name = "addAndSelectGameuc1";
            addAndSelectGameuc1.Size = new Size(317, 142);
            addAndSelectGameuc1.TabIndex = 20;
            addAndSelectGameuc1.Load += addAndSelectGameuc1_Load;
            // 
            // mouseInfouc1
            // 
            mouseInfouc1.Location = new Point(400, 172);
            mouseInfouc1.Name = "mouseInfouc1";
            mouseInfouc1.Size = new Size(277, 119);
            mouseInfouc1.TabIndex = 23;
            // 
            // gameDatauc1
            // 
            gameDatauc1.Location = new Point(335, 4);
            gameDatauc1.Name = "gameDatauc1";
            gameDatauc1.Size = new Size(150, 150);
            gameDatauc1.TabIndex = 22;
            // 
            // simpleAutoclickeruc1
            // 
            simpleAutoclickeruc1.Location = new Point(188, 181);
            simpleAutoclickeruc1.Name = "simpleAutoclickeruc1";
            simpleAutoclickeruc1.Size = new Size(150, 197);
            simpleAutoclickeruc1.TabIndex = 24;
            // 
            // simpleMouseMoveruc1
            // 
            simpleMouseMoveruc1.Location = new Point(23, 238);
            simpleMouseMoveruc1.Name = "simpleMouseMoveruc1";
            simpleMouseMoveruc1.Size = new Size(150, 150);
            simpleMouseMoveruc1.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 400);
            Controls.Add(simpleMouseMoveruc1);
            Controls.Add(simpleAutoclickeruc1);
            Controls.Add(gameDatauc1);
            Controls.Add(mouseInfouc1);
            Controls.Add(addAndSelectGameuc1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        public AddAndSelectGameUC addAndSelectGameuc1;
        public MouseInfoUC mouseInfouc1;
        public GameDataUC gameDatauc1;
        private SimpleAutoClickerUC simpleAutoclickeruc1;
        private SimpleMouseMoverUC simpleMouseMoveruc1;
    }
}