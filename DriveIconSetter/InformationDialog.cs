using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveIconSetter
{
	public partial class InformationDialog : Form
	{
		public InformationDialog()
		{
			InitializeComponent();
			programdataPathLabel.Text = MainForm.getProgramDataFolderPath();

			displayOnStartupCheckBox.Checked = Properties.Settings.Default.DisplayInformationDialog;
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void InformationDialog_Shown(object sender, EventArgs e)
		{
			SystemSounds.Question.Play();
		}

		private void InformationDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.DisplayInformationDialog = displayOnStartupCheckBox.Checked;
			Properties.Settings.Default.Save();
		}
	}
}
