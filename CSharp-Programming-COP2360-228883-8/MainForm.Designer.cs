namespace CSharp_Programming_COP2360_228883_8
{
    partial class MainForm
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
            this.materialLabel1 = new CSharp_Programming_COP2360_228883_8.Controls.MaterialLabel();
            this.materialLabel2 = new CSharp_Programming_COP2360_228883_8.Controls.MaterialLabel();
            this.materialLabel3 = new CSharp_Programming_COP2360_228883_8.Controls.MaterialLabel();
            this.UserFeedbackLabel = new CSharp_Programming_COP2360_228883_8.Controls.MaterialLabel();
            this.CalculateButton = new CSharp_Programming_COP2360_228883_8.Controls.MaterialRaisedButton();
            this.ResetButton = new CSharp_Programming_COP2360_228883_8.Controls.MaterialFlatButton();
            this.SpeedMph = new CSharp_Programming_COP2360_228883_8.Controls.MaterialSingleLineTextField();
            this.TimeTraveled = new CSharp_Programming_COP2360_228883_8.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(149, 84);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(140, 75, 139, 0);
            this.materialLabel1.MouseState = CSharp_Programming_COP2360_228883_8.MaterialDesign.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(162, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "How far did you travel?";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(84, 126);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(75, 100, 139, 0);
            this.materialLabel2.MouseState = CSharp_Programming_COP2360_228883_8.MaterialDesign.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(101, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Speed (MPH):";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(84, 178);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(75, 20, 139, 0);
            this.materialLabel3.MouseState = CSharp_Programming_COP2360_228883_8.MaterialDesign.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(146, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Time Traveled (Hrs):";
            // 
            // UserFeedbackLabel
            // 
            this.UserFeedbackLabel.AllowDrop = true;
            this.UserFeedbackLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserFeedbackLabel.AutoSize = true;
            this.UserFeedbackLabel.BackColor = System.Drawing.SystemColors.Window;
            this.UserFeedbackLabel.Depth = 0;
            this.UserFeedbackLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.UserFeedbackLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserFeedbackLabel.Location = new System.Drawing.Point(46, 350);
            this.UserFeedbackLabel.Margin = new System.Windows.Forms.Padding(75, 20, 139, 0);
            this.UserFeedbackLabel.MouseState = CSharp_Programming_COP2360_228883_8.MaterialDesign.MouseState.HOVER;
            this.UserFeedbackLabel.Name = "UserFeedbackLabel";
            this.UserFeedbackLabel.Size = new System.Drawing.Size(0, 19);
            this.UserFeedbackLabel.TabIndex = 4;
            // 
            // CalculateButton
            // 
            this.CalculateButton.AutoSize = true;
            this.CalculateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CalculateButton.Depth = 0;
            this.CalculateButton.Icon = null;
            this.CalculateButton.Location = new System.Drawing.Point(50, 258);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(41, 100, 41, 0);
            this.CalculateButton.MinimumSize = new System.Drawing.Size(400, 0);
            this.CalculateButton.MouseState = CSharp_Programming_COP2360_228883_8.MaterialDesign.MouseState.HOVER;
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Primary = true;
            this.CalculateButton.Size = new System.Drawing.Size(400, 36);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.AutoSize = true;
            this.ResetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetButton.Depth = 0;
            this.ResetButton.Icon = null;
            this.ResetButton.Location = new System.Drawing.Point(50, 300);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ResetButton.MinimumSize = new System.Drawing.Size(400, 0);
            this.ResetButton.MouseState = CSharp_Programming_COP2360_228883_8.MaterialDesign.MouseState.HOVER;
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Primary = false;
            this.ResetButton.Size = new System.Drawing.Size(400, 36);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SpeedMph
            // 
            this.SpeedMph.Depth = 0;
            this.SpeedMph.Hint = "";
            this.SpeedMph.Location = new System.Drawing.Point(369, 122);
            this.SpeedMph.MaxLength = 32767;
            this.SpeedMph.MouseState = CSharp_Programming_COP2360_228883_8.MaterialDesign.MouseState.HOVER;
            this.SpeedMph.Name = "SpeedMph";
            this.SpeedMph.PasswordChar = '\0';
            this.SpeedMph.SelectedText = "";
            this.SpeedMph.SelectionLength = 0;
            this.SpeedMph.SelectionStart = 0;
            this.SpeedMph.Size = new System.Drawing.Size(81, 23);
            this.SpeedMph.TabIndex = 7;
            this.SpeedMph.TabStop = false;
            this.SpeedMph.UseSystemPasswordChar = false;
            this.SpeedMph.TextChanged += new System.EventHandler(this.SpeedMph_TextChanged);
            // 
            // TimeTraveled
            // 
            this.TimeTraveled.Depth = 0;
            this.TimeTraveled.Hint = "";
            this.TimeTraveled.Location = new System.Drawing.Point(369, 174);
            this.TimeTraveled.MaxLength = 32767;
            this.TimeTraveled.MouseState = CSharp_Programming_COP2360_228883_8.MaterialDesign.MouseState.HOVER;
            this.TimeTraveled.Name = "TimeTraveled";
            this.TimeTraveled.PasswordChar = '\0';
            this.TimeTraveled.SelectedText = "";
            this.TimeTraveled.SelectionLength = 0;
            this.TimeTraveled.SelectionStart = 0;
            this.TimeTraveled.Size = new System.Drawing.Size(81, 23);
            this.TimeTraveled.TabIndex = 8;
            this.TimeTraveled.TabStop = false;
            this.TimeTraveled.UseSystemPasswordChar = false;
            this.TimeTraveled.TextChanged += new System.EventHandler(this.TimeTraveled_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 378);
            this.Controls.Add(this.TimeTraveled);
            this.Controls.Add(this.SpeedMph);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.UserFeedbackLabel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "MainForm";
            this.Text = "Distance Calculator App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MaterialLabel materialLabel1;
        private Controls.MaterialLabel materialLabel2;
        private Controls.MaterialLabel materialLabel3;
        private Controls.MaterialLabel UserFeedbackLabel;
        private Controls.MaterialRaisedButton CalculateButton;
        private Controls.MaterialFlatButton ResetButton;
        private Controls.MaterialSingleLineTextField SpeedMph;
        private Controls.MaterialSingleLineTextField TimeTraveled;
    }
}

