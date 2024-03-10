
namespace TaskBAssessed
{
    partial class Launch
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
            this.addButton = new System.Windows.Forms.Button();
            this.LaunchTitleLabel = new System.Windows.Forms.Label();
            this.addConnectionButton = new System.Windows.Forms.Button();
            this.removeConnectionButton = new System.Windows.Forms.Button();
            this.displayRoutesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(83, 84);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add an airport";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // LaunchTitleLabel
            // 
            this.LaunchTitleLabel.AutoSize = true;
            this.LaunchTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchTitleLabel.Location = new System.Drawing.Point(81, 25);
            this.LaunchTitleLabel.Name = "LaunchTitleLabel";
            this.LaunchTitleLabel.Size = new System.Drawing.Size(129, 16);
            this.LaunchTitleLabel.TabIndex = 2;
            this.LaunchTitleLabel.Text = "Airport Management";
            // 
            // addConnectionButton
            // 
            this.addConnectionButton.Location = new System.Drawing.Point(81, 129);
            this.addConnectionButton.Name = "addConnectionButton";
            this.addConnectionButton.Size = new System.Drawing.Size(122, 23);
            this.addConnectionButton.TabIndex = 4;
            this.addConnectionButton.Text = "Add a connection";
            this.addConnectionButton.UseVisualStyleBackColor = true;
            this.addConnectionButton.Click += new System.EventHandler(this.addConnectionButton_Click);
            // 
            // removeConnectionButton
            // 
            this.removeConnectionButton.Location = new System.Drawing.Point(81, 173);
            this.removeConnectionButton.Name = "removeConnectionButton";
            this.removeConnectionButton.Size = new System.Drawing.Size(122, 23);
            this.removeConnectionButton.TabIndex = 5;
            this.removeConnectionButton.Text = "Remove a connection";
            this.removeConnectionButton.UseVisualStyleBackColor = true;
            this.removeConnectionButton.Click += new System.EventHandler(this.removeConnectionButton_Click);
            // 
            // displayRoutesButton
            // 
            this.displayRoutesButton.Location = new System.Drawing.Point(81, 218);
            this.displayRoutesButton.Name = "displayRoutesButton";
            this.displayRoutesButton.Size = new System.Drawing.Size(122, 23);
            this.displayRoutesButton.TabIndex = 6;
            this.displayRoutesButton.Text = "Display routes";
            this.displayRoutesButton.UseVisualStyleBackColor = true;
            this.displayRoutesButton.Click += new System.EventHandler(this.displayRoutesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitButton.Location = new System.Drawing.Point(81, 267);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(122, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit Programme";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please select from the following options";
            // 
            // Launch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayRoutesButton);
            this.Controls.Add(this.removeConnectionButton);
            this.Controls.Add(this.addConnectionButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.LaunchTitleLabel);
            this.Name = "Launch";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label LaunchTitleLabel;
        private System.Windows.Forms.Button addConnectionButton;
        private System.Windows.Forms.Button removeConnectionButton;
        private System.Windows.Forms.Button displayRoutesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}

