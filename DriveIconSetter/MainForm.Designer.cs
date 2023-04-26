using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace DriveIconSetter
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.fileBrowseButton = new System.Windows.Forms.Button();
			this.setIconButton = new System.Windows.Forms.Button();
			this.iconFilePathTextBox = new System.Windows.Forms.TextBox();
			this.driveLetterComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.iconPreviewPictureBox = new System.Windows.Forms.PictureBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.activeDriveIconsGrid = new System.Windows.Forms.DataGridView();
			this.DGDrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DGIcon = new System.Windows.Forms.DataGridViewImageColumn();
			this.DGIconPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DGActions = new System.Windows.Forms.DataGridViewButtonColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.panelDriveLettersUsed = new System.Windows.Forms.Panel();
			this.panelSetDriveIcon = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.iconPreviewPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.activeDriveIconsGrid)).BeginInit();
			this.panelDriveLettersUsed.SuspendLayout();
			this.panelSetDriveIcon.SuspendLayout();
			this.SuspendLayout();
			// 
			// fileBrowseButton
			// 
			this.fileBrowseButton.Location = new System.Drawing.Point(468, 26);
			this.fileBrowseButton.Name = "fileBrowseButton";
			this.fileBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.fileBrowseButton.TabIndex = 3;
			this.fileBrowseButton.Text = "Browse";
			this.fileBrowseButton.UseVisualStyleBackColor = true;
			this.fileBrowseButton.Click += new System.EventHandler(this.fileBrowseButton_Click);
			// 
			// setIconButton
			// 
			this.setIconButton.Enabled = false;
			this.setIconButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.setIconButton.Location = new System.Drawing.Point(603, 15);
			this.setIconButton.Name = "setIconButton";
			this.setIconButton.Size = new System.Drawing.Size(75, 41);
			this.setIconButton.TabIndex = 4;
			this.setIconButton.Text = "Apply";
			this.setIconButton.UseVisualStyleBackColor = false;
			this.setIconButton.Click += new System.EventHandler(this.setIconButton_Click);
			// 
			// iconFilePathTextBox
			// 
			this.iconFilePathTextBox.Location = new System.Drawing.Point(93, 27);
			this.iconFilePathTextBox.Name = "iconFilePathTextBox";
			this.iconFilePathTextBox.Size = new System.Drawing.Size(369, 20);
			this.iconFilePathTextBox.TabIndex = 2;
			this.iconFilePathTextBox.TextChanged += new System.EventHandler(this.iconFilePathTextBox_TextChanged);
			// 
			// driveLetterComboBox
			// 
			this.driveLetterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.driveLetterComboBox.FormattingEnabled = true;
			this.driveLetterComboBox.Location = new System.Drawing.Point(3, 26);
			this.driveLetterComboBox.Name = "driveLetterComboBox";
			this.driveLetterComboBox.Size = new System.Drawing.Size(84, 21);
			this.driveLetterComboBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Drive Letter";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(93, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(248, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Source Icon File Path (the file will be copied)";
			// 
			// iconPreviewPictureBox
			// 
			this.iconPreviewPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(23)))), ((int)(((byte)(70)))));
			this.iconPreviewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.iconPreviewPictureBox.Location = new System.Drawing.Point(549, 12);
			this.iconPreviewPictureBox.Name = "iconPreviewPictureBox";
			this.iconPreviewPictureBox.Size = new System.Drawing.Size(48, 48);
			this.iconPreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.iconPreviewPictureBox.TabIndex = 6;
			this.iconPreviewPictureBox.TabStop = false;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			this.openFileDialog.Filter = "Icons|*.png;*.ico";
			this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
			// 
			// activeDriveIconsGrid
			// 
			this.activeDriveIconsGrid.AllowUserToAddRows = false;
			this.activeDriveIconsGrid.AllowUserToDeleteRows = false;
			this.activeDriveIconsGrid.AllowUserToResizeColumns = false;
			this.activeDriveIconsGrid.AllowUserToResizeRows = false;
			this.activeDriveIconsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(23)))), ((int)(((byte)(70)))));
			this.activeDriveIconsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.activeDriveIconsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.activeDriveIconsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGDrive,
            this.DGIcon,
            this.DGIconPath,
            this.DGActions});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.activeDriveIconsGrid.DefaultCellStyle = dataGridViewCellStyle4;
			this.activeDriveIconsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.activeDriveIconsGrid.GridColor = System.Drawing.Color.LightGray;
			this.activeDriveIconsGrid.Location = new System.Drawing.Point(12, 180);
			this.activeDriveIconsGrid.MultiSelect = false;
			this.activeDriveIconsGrid.Name = "activeDriveIconsGrid";
			this.activeDriveIconsGrid.ReadOnly = true;
			this.activeDriveIconsGrid.RowHeadersVisible = false;
			this.activeDriveIconsGrid.RowTemplate.Height = 48;
			this.activeDriveIconsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.activeDriveIconsGrid.Size = new System.Drawing.Size(675, 458);
			this.activeDriveIconsGrid.TabIndex = 7;
			this.activeDriveIconsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activeDriveIconsGrid_CellContentClick);
			// 
			// DGDrive
			// 
			this.DGDrive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DGDrive.DefaultCellStyle = dataGridViewCellStyle1;
			this.DGDrive.HeaderText = "Drive";
			this.DGDrive.MinimumWidth = 50;
			this.DGDrive.Name = "DGDrive";
			this.DGDrive.ReadOnly = true;
			this.DGDrive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DGDrive.ToolTipText = "The drive letter this icon is attached to.";
			this.DGDrive.Width = 50;
			// 
			// DGIcon
			// 
			this.DGIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.DGIcon.HeaderText = "Icon";
			this.DGIcon.MinimumWidth = 48;
			this.DGIcon.Name = "DGIcon";
			this.DGIcon.ReadOnly = true;
			this.DGIcon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.DGIcon.ToolTipText = "Currently active icon for the drive letter.";
			this.DGIcon.Width = 48;
			// 
			// DGIconPath
			// 
			this.DGIconPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.DGIconPath.DefaultCellStyle = dataGridViewCellStyle2;
			this.DGIconPath.HeaderText = "Icon Path";
			this.DGIconPath.MinimumWidth = 120;
			this.DGIconPath.Name = "DGIconPath";
			this.DGIconPath.ReadOnly = true;
			this.DGIconPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DGIconPath.ToolTipText = "File location of the icon in use.";
			// 
			// DGActions
			// 
			this.DGActions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			dataGridViewCellStyle3.NullValue = "abc";
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8);
			this.DGActions.DefaultCellStyle = dataGridViewCellStyle3;
			this.DGActions.HeaderText = "Actions";
			this.DGActions.MinimumWidth = 80;
			this.DGActions.Name = "DGActions";
			this.DGActions.ReadOnly = true;
			this.DGActions.Text = "Unset";
			this.DGActions.Width = 80;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(50, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(579, 24);
			this.label3.TabIndex = 8;
			this.label3.Text = "All drive letters are used. To set another, first unset any existing icon.";
			// 
			// panelDriveLettersUsed
			// 
			this.panelDriveLettersUsed.BackColor = System.Drawing.Color.Transparent;
			this.panelDriveLettersUsed.Controls.Add(this.label3);
			this.panelDriveLettersUsed.Location = new System.Drawing.Point(11, 119);
			this.panelDriveLettersUsed.Name = "panelDriveLettersUsed";
			this.panelDriveLettersUsed.Size = new System.Drawing.Size(675, 47);
			this.panelDriveLettersUsed.TabIndex = 9;
			this.panelDriveLettersUsed.Visible = false;
			// 
			// panelSetDriveIcon
			// 
			this.panelSetDriveIcon.BackColor = System.Drawing.Color.Transparent;
			this.panelSetDriveIcon.Controls.Add(this.driveLetterComboBox);
			this.panelSetDriveIcon.Controls.Add(this.fileBrowseButton);
			this.panelSetDriveIcon.Controls.Add(this.setIconButton);
			this.panelSetDriveIcon.Controls.Add(this.iconPreviewPictureBox);
			this.panelSetDriveIcon.Controls.Add(this.iconFilePathTextBox);
			this.panelSetDriveIcon.Controls.Add(this.label2);
			this.panelSetDriveIcon.Controls.Add(this.label1);
			this.panelSetDriveIcon.Location = new System.Drawing.Point(8, 107);
			this.panelSetDriveIcon.Name = "panelSetDriveIcon";
			this.panelSetDriveIcon.Size = new System.Drawing.Size(682, 62);
			this.panelSetDriveIcon.TabIndex = 9;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DriveIconSetter.Properties.Resources.Background;
			this.ClientSize = new System.Drawing.Size(700, 650);
			this.Controls.Add(this.panelSetDriveIcon);
			this.Controls.Add(this.activeDriveIconsGrid);
			this.Controls.Add(this.panelDriveLettersUsed);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Drive Icon Setter";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.iconPreviewPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.activeDriveIconsGrid)).EndInit();
			this.panelDriveLettersUsed.ResumeLayout(false);
			this.panelDriveLettersUsed.PerformLayout();
			this.panelSetDriveIcon.ResumeLayout(false);
			this.panelSetDriveIcon.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button fileBrowseButton;
		private System.Windows.Forms.Button setIconButton;
		private System.Windows.Forms.TextBox iconFilePathTextBox;
		private System.Windows.Forms.ComboBox driveLetterComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox iconPreviewPictureBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.DataGridView activeDriveIconsGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn DGDrive;
		private System.Windows.Forms.DataGridViewImageColumn DGIcon;
		private System.Windows.Forms.DataGridViewTextBoxColumn DGIconPath;
		private System.Windows.Forms.DataGridViewButtonColumn DGActions;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panelDriveLettersUsed;
		private System.Windows.Forms.Panel panelSetDriveIcon;
	}
}

