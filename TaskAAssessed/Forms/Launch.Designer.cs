
namespace TaskAAssessed
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
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayNumEdgesButton = new System.Windows.Forms.Button();
            this.displayNumNodeButton = new System.Windows.Forms.Button();
            this.addEdgeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.LaunchTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please select from the following options";
            // 
            // exitButton
            // 
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitButton.Location = new System.Drawing.Point(84, 264);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(122, 23);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit Programme";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayNumEdgesButton
            // 
            this.displayNumEdgesButton.Location = new System.Drawing.Point(84, 216);
            this.displayNumEdgesButton.Name = "displayNumEdgesButton";
            this.displayNumEdgesButton.Size = new System.Drawing.Size(122, 23);
            this.displayNumEdgesButton.TabIndex = 13;
            this.displayNumEdgesButton.Text = "Display num of edges";
            this.displayNumEdgesButton.UseVisualStyleBackColor = true;
            this.displayNumEdgesButton.Click += new System.EventHandler(this.displayNumEdgesButton_Click);
            // 
            // displayNumNodeButton
            // 
            this.displayNumNodeButton.Location = new System.Drawing.Point(84, 171);
            this.displayNumNodeButton.Name = "displayNumNodeButton";
            this.displayNumNodeButton.Size = new System.Drawing.Size(122, 23);
            this.displayNumNodeButton.TabIndex = 12;
            this.displayNumNodeButton.Text = "Display num of nodes";
            this.displayNumNodeButton.UseVisualStyleBackColor = true;
            this.displayNumNodeButton.Click += new System.EventHandler(this.displayNumNodesButton_Click);
            // 
            // addEdgeButton
            // 
            this.addEdgeButton.Location = new System.Drawing.Point(84, 126);
            this.addEdgeButton.Name = "addEdgeButton";
            this.addEdgeButton.Size = new System.Drawing.Size(122, 23);
            this.addEdgeButton.TabIndex = 11;
            this.addEdgeButton.Text = "Add an edge";
            this.addEdgeButton.UseVisualStyleBackColor = true;
            this.addEdgeButton.Click += new System.EventHandler(this.addEdgeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(86, 81);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add a node";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // LaunchTitleLabel
            // 
            this.LaunchTitleLabel.AutoSize = true;
            this.LaunchTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchTitleLabel.Location = new System.Drawing.Point(84, 22);
            this.LaunchTitleLabel.Name = "LaunchTitleLabel";
            this.LaunchTitleLabel.Size = new System.Drawing.Size(127, 16);
            this.LaunchTitleLabel.TabIndex = 9;
            this.LaunchTitleLabel.Text = "Graph Management";
            // 
            // Launch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayNumEdgesButton);
            this.Controls.Add(this.displayNumNodeButton);
            this.Controls.Add(this.addEdgeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.LaunchTitleLabel);
            this.Name = "Launch";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button displayNumEdgesButton;
        private System.Windows.Forms.Button displayNumNodeButton;
        private System.Windows.Forms.Button addEdgeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label LaunchTitleLabel;
    }
}

