namespace DriveIconSetter
{
	partial class InformationDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationDialog));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.programdataPathLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Button();
			this.displayOnStartupCheckBox = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(527, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome to Drive Icon Setter for Windows by Sonaza!";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(527, 96);
			this.label2.TabIndex = 0;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(527, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "The icon files used for the drives will be copied and stored in:";
			// 
			// programdataPathLabel
			// 
			this.programdataPathLabel.Location = new System.Drawing.Point(12, 195);
			this.programdataPathLabel.Name = "programdataPathLabel";
			this.programdataPathLabel.Size = new System.Drawing.Size(349, 20);
			this.programdataPathLabel.TabIndex = 0;
			this.programdataPathLabel.Text = "<placeholder %programdata%>";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(527, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "This software requires Administrator\'s permissions to modify registry keys in:";
			// 
			// closeButton
			// 
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.closeButton.Location = new System.Drawing.Point(404, 14);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(135, 23);
			this.closeButton.TabIndex = 1;
			this.closeButton.Text = "OK";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// displayOnStartupCheckBox
			// 
			this.displayOnStartupCheckBox.AutoSize = true;
			this.displayOnStartupCheckBox.Checked = true;
			this.displayOnStartupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.displayOnStartupCheckBox.Location = new System.Drawing.Point(16, 18);
			this.displayOnStartupCheckBox.Name = "displayOnStartupCheckBox";
			this.displayOnStartupCheckBox.Size = new System.Drawing.Size(113, 17);
			this.displayOnStartupCheckBox.TabIndex = 2;
			this.displayOnStartupCheckBox.Text = "Display on start-up";
			this.displayOnStartupCheckBox.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 242);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(527, 19);
			this.label5.TabIndex = 0;
			this.label5.Text = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\explorer\\DriveIcons";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.displayOnStartupCheckBox);
			this.panel1.Controls.Add(this.closeButton);
			this.panel1.Location = new System.Drawing.Point(-1, 293);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(553, 74);
			this.panel1.TabIndex = 3;
			// 
			// InformationDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(551, 341);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.programdataPathLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InformationDialog";
			this.ShowInTaskbar = false;
			this.Text = "Welcome";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InformationDialog_FormClosing);
			this.Shown += new System.EventHandler(this.InformationDialog_Shown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label programdataPathLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.CheckBox displayOnStartupCheckBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
	}
}