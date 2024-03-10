
namespace TaskBAssessed.Forms
{
    partial class Routes
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
            this.label4 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arriveListBox = new System.Windows.Forms.ListBox();
            this.departListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dropDownSelection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Please select a departure and airport and route type";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(137, 289);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(128, 23);
            this.removeButton.TabIndex = 27;
            this.removeButton.Text = "Display routes";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.routeTypeSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Arrival Airport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Departure Airport";
            // 
            // arriveListBox
            // 
            this.arriveListBox.FormattingEnabled = true;
            this.arriveListBox.Location = new System.Drawing.Point(275, 121);
            this.arriveListBox.Name = "arriveListBox";
            this.arriveListBox.Size = new System.Drawing.Size(93, 147);
            this.arriveListBox.TabIndex = 24;
            // 
            // departListBox
            // 
            this.departListBox.FormattingEnabled = true;
            this.departListBox.Location = new System.Drawing.Point(29, 121);
            this.departListBox.Name = "departListBox";
            this.departListBox.Size = new System.Drawing.Size(93, 147);
            this.departListBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "View Routes";
            // 
            // dropDownSelection
            // 
            this.dropDownSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownSelection.FormattingEnabled = true;
            this.dropDownSelection.Items.AddRange(new object[] {
            "Direct only",
            "Direct and indirect"});
            this.dropDownSelection.Location = new System.Drawing.Point(137, 180);
            this.dropDownSelection.Name = "dropDownSelection";
            this.dropDownSelection.Size = new System.Drawing.Size(121, 21);
            this.dropDownSelection.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Route Type";
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 379);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dropDownSelection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arriveListBox);
            this.Controls.Add(this.departListBox);
            this.Controls.Add(this.label1);
            this.Name = "Routes";
            this.Text = "Routes";
            this.Load += new System.EventHandler(this.Routes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox arriveListBox;
        private System.Windows.Forms.ListBox departListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dropDownSelection;
        private System.Windows.Forms.Label label5;
    }
}