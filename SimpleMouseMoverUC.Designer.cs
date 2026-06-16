namespace SetMouseForGames
{
    partial class SimpleMouseMoverUC
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
            PxDistanceLabel = new Label();
            PxDistanceIncr = new Button();
            PxDistanceDecr = new Button();
            Stop = new Button();
            Start = new Button();
            SuspendLayout();
            // 
            // PxDistanceLabel
            // 
            PxDistanceLabel.AutoSize = true;
            PxDistanceLabel.Location = new Point(58, 107);
            PxDistanceLabel.Name = "PxDistanceLabel";
            PxDistanceLabel.Size = new Size(26, 15);
            PxDistanceLabel.TabIndex = 18;
            PxDistanceLabel.Text = "1px";
            // 
            // PxDistanceIncr
            // 
            PxDistanceIncr.Location = new Point(102, 104);
            PxDistanceIncr.Name = "PxDistanceIncr";
            PxDistanceIncr.Size = new Size(33, 23);
            PxDistanceIncr.TabIndex = 17;
            PxDistanceIncr.Text = ">";
            PxDistanceIncr.UseVisualStyleBackColor = true;
            PxDistanceIncr.Click += PxDistanceIncr_Click;
            // 
            // PxDistanceDecr
            // 
            PxDistanceDecr.Location = new Point(15, 104);
            PxDistanceDecr.Name = "PxDistanceDecr";
            PxDistanceDecr.Size = new Size(33, 23);
            PxDistanceDecr.TabIndex = 16;
            PxDistanceDecr.Text = "<";
            PxDistanceDecr.UseVisualStyleBackColor = true;
            PxDistanceDecr.Click += PxDistanceDecr_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(15, 63);
            Stop.Name = "Stop";
            Stop.Size = new Size(120, 23);
            Stop.TabIndex = 15;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // Start
            // 
            Start.Location = new Point(15, 24);
            Start.Name = "Start";
            Start.Size = new Size(120, 23);
            Start.TabIndex = 14;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // SimpleMouseMoverUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PxDistanceLabel);
            Controls.Add(PxDistanceIncr);
            Controls.Add(PxDistanceDecr);
            Controls.Add(Stop);
            Controls.Add(Start);
            Name = "SimpleMouseMoverUC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PxDistanceLabel;
        private Button PxDistanceIncr;
        private Button PxDistanceDecr;
        private Button Stop;
        private Button Start;
    }
}
