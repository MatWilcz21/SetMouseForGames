namespace SetMouseForGames
{
    partial class SimpleAutoclickerUC
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
            Start = new Button();
            Stop = new Button();
            PxDistanceDecr = new Button();
            PxDistanceIncr = new Button();
            PxDistanceLabel = new Label();
            SuspendLayout();
            // 
            // Start
            // 
            Start.Location = new Point(15, 74);
            Start.Name = "Start";
            Start.Size = new Size(120, 23);
            Start.TabIndex = 9;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(15, 113);
            Stop.Name = "Stop";
            Stop.Size = new Size(120, 23);
            Stop.TabIndex = 10;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // PxDistanceDecr
            // 
            PxDistanceDecr.Location = new Point(15, 154);
            PxDistanceDecr.Name = "PxDistanceDecr";
            PxDistanceDecr.Size = new Size(33, 23);
            PxDistanceDecr.TabIndex = 11;
            PxDistanceDecr.Text = "<";
            PxDistanceDecr.UseVisualStyleBackColor = true;
            PxDistanceDecr.Click += PxDistanceDecr_Click;
            // 
            // PxDistanceIncr
            // 
            PxDistanceIncr.Location = new Point(102, 154);
            PxDistanceIncr.Name = "PxDistanceIncr";
            PxDistanceIncr.Size = new Size(33, 23);
            PxDistanceIncr.TabIndex = 12;
            PxDistanceIncr.Text = ">";
            PxDistanceIncr.UseVisualStyleBackColor = true;
            PxDistanceIncr.Click += PxDistanceIncr_Click;
            // 
            // PxDistanceLabel
            // 
            PxDistanceLabel.AutoSize = true;
            PxDistanceLabel.Location = new Point(58, 157);
            PxDistanceLabel.Name = "PxDistanceLabel";
            PxDistanceLabel.Size = new Size(26, 15);
            PxDistanceLabel.TabIndex = 13;
            PxDistanceLabel.Text = "1px";
            // 
            // SimpleAutoclickerUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PxDistanceLabel);
            Controls.Add(PxDistanceIncr);
            Controls.Add(PxDistanceDecr);
            Controls.Add(Stop);
            Controls.Add(Start);
            Name = "SimpleAutoclickerUC";
            Size = new Size(150, 195);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start;
        private Button Stop;
        private Button PxDistanceDecr;
        private Button PxDistanceIncr;
        private Label PxDistanceLabel;
    }
}
