using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Security.AccessControl;
using System.Security.Principal;


namespace DriveIconSetter
{
	public partial class MainForm : Form
	{
		private Dictionary<string, string> currentIcons = new Dictionary<string, string>();

		private const string programDataDirectory = @"C:\ProgramData\DriveIconSetter";

		// HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\explorer\DriveIcons
		private const string driveIconsRegistryBasePath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\explorer\DriveIcons";
		
		public MainForm()
		{
			if (!isAdministrator())
			{
				MessageBox.Show("No Admin permissions!");
				Environment.Exit(1);
				return;
			}

			InitializeComponent();

			initialize();

			refreshState();
		}
		
		private void MainForm_Shown(object sender, EventArgs e)
		{
			displayFirstRunDialog();
		}

		private void initialize()
		{
			if (!Directory.Exists(programDataDirectory))
			{
				Directory.CreateDirectory(programDataDirectory);
			}
		}

		private void displayFirstRunDialog()
		{
			MessageBox.Show(
				Properties.Resources.FirstRunHelp,
				"Drive Icon Setter", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		private void refreshState()
		{
			loadCurrentDriveIcons();
			updateDriveLetterOptions();
			updateDriveLetterDataGrid();
		}
		
// 		defaultIconKey.GetValueNames().ToList().ForEach(i => Console.WriteLine(i.ToString()));

		private void loadCurrentDriveIcons()
		{
			currentIcons.Clear();

			RegistryKey baseKey = Registry.LocalMachine.OpenSubKey(driveIconsRegistryBasePath);
			if (baseKey != null)
			{
				string[] subkeys = baseKey.GetSubKeyNames();

				foreach(string subkey in subkeys)
				{
					RegistryKey defaultIconKey = baseKey.OpenSubKey($"{subkey}\\DefaultIcon");
					if (defaultIconKey != null)
					{
						string filepath = defaultIconKey.GetValue("").ToString();
						currentIcons.Add(subkey.ToUpper(), filepath);
						defaultIconKey.Close();
					}
				}
				baseKey.Close();
			}
		}

		private void updateDriveLetterDataGrid()
		{
			activeDriveIconsGrid.Rows.Clear();

			foreach (KeyValuePair<string, string> data in currentIcons)
			{
				string filepath = data.Value.Replace("\"", "");
				Bitmap icon = new Bitmap(tryLoadIcon(filepath), new Size(48, 48));
				activeDriveIconsGrid.Rows.Add(data.Key, icon, data.Value, "Unset");
			}
		}

		private void updateDriveLetterOptions()
		{
			driveLetterComboBox.Items.Clear();

			for (int i = 67; i <= 90; i++)
			{
				string letter = ((char)i).ToString();
				if (!currentIcons.ContainsKey(letter))
				{
					driveLetterComboBox.Items.Add(letter);
				}
			}
			for (int i = 65; i <= 66; i++)
			{
				string letter = ((char)i).ToString();
				if (!currentIcons.ContainsKey(letter))
				{
					driveLetterComboBox.Items.Add(letter);
				}
			}

			if (driveLetterComboBox.Items.Count > 0)
			{
				driveLetterComboBox.SelectedIndex = 0;
				setVisibilityDriveLettersUsed(false);
			}
			else
			{
				setVisibilityDriveLettersUsed(true);
			}
		}

		private Bitmap tryLoadIcon(string iconFilepath)
		{
			if (iconFilepath.EndsWith(".ico"))
			{
				try
				{
					Icon icon = new Icon(iconFilepath, new Size(48, 48));
					return Bitmap.FromHicon(icon.Handle);
				}
				catch (ArgumentException)
				{
					// Not .ico file
				}
			}
			else if (iconFilepath.EndsWith(".png"))
			{
				FileStream stream = new FileStream(iconFilepath, FileMode.Open, FileAccess.Read);
				Bitmap iconBitmap = new Bitmap(stream);
				stream.Close();
				return iconBitmap;
			}
			
			return null;
		}

		private string generateRandomString()
		{
			long timestamp = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
			string hexString = timestamp.ToString("X");
			return hexString.Substring(hexString.Length - 6).ToLower();
		}

		private string copyAndConvertIcon(string originalFilepath, string driveLetter)
		{
			string random_string = generateRandomString();

			string outputFilename = $"driveicon_{driveLetter}_{random_string}.ico";
			string destinationFilepath = Path.Combine(programDataDirectory, outputFilename);

			if (originalFilepath.EndsWith(".png"))
			{
				PngIconConverter.Convert(originalFilepath, destinationFilepath, 256, false);
			}
			else if (originalFilepath.EndsWith(".ico"))
			{
				File.Copy(originalFilepath, destinationFilepath, true);
			}
			else
			{
				throw new ArgumentException("Unsupported file type.");
			}

			return destinationFilepath;
		}

		private void iconFilePathTextBox_TextChanged(object sender, EventArgs e)
		{
			if (iconFilePathTextBox.Text.Length == 0)
				return;

			string text = iconFilePathTextBox.Text.Trim().Replace("\"", "");
			if (!text.Equals(iconFilePathTextBox.Text))
			{
				iconFilePathTextBox.Text = text;
				return;
			}

			iconPreviewPictureBox.Image = null;
			setIconButton.Enabled = false;

			String filepath = iconFilePathTextBox.Text;
			if (!File.Exists(filepath))
			{
				return;
			}

			Bitmap iconBitmap = tryLoadIcon(filepath);
			if (iconBitmap != null)
			{
				iconPreviewPictureBox.Image = iconBitmap;
				setIconButton.Enabled = true;
			}
			else
			{
				//MessageBox.Show("Unsupported icon type. Only .ico and .png files are supported.", "Icon Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void setVisibilityDriveLettersUsed(bool allLettersUsed)
		{
			panelSetDriveIcon.Visible = !allLettersUsed;
			panelDriveLettersUsed.Visible = allLettersUsed;
		}

		private void fileBrowseButton_Click(object sender, EventArgs e)
		{
			showOpenFileDialog();
		}

		private void openFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			string filepath = openFileDialog.FileName.Trim().Replace("\"", "");

			Bitmap iconBitmap = tryLoadIcon(filepath);
			if (iconBitmap != null)
			{
				if (iconBitmap.Width != iconBitmap.Height)
				{
					DialogResult result = MessageBox.Show(
						"Selected icon does not have square aspect ratio (width equal to height) and some stretching will occur if used as icon.\n\nDo you want to continue?",
						"Icon Aspect Ratio",
						MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

					if (result == DialogResult.No)
					{
						iconFilePathTextBox.Text = "";
						e.Cancel = true;
						return;
					}
				}
			}
			else
			{
				MessageBox.Show("Unsupported icon type. Only .ico and .png files are supported.", "Unsupported Icon Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;
				return;
			}

			iconFilePathTextBox.Text = filepath;

			string selectedDirectory = Path.GetDirectoryName(filepath);
			Properties.Settings.Default.LastSelectedDirectory = selectedDirectory;
			Properties.Settings.Default.Save();

			Console.WriteLine(selectedDirectory);
		}

		private void showOpenFileDialog()
		{
			string lastSelectedDirectory = Properties.Settings.Default.LastSelectedDirectory;
			if (!string.IsNullOrEmpty(lastSelectedDirectory))
			{
				openFileDialog.InitialDirectory = lastSelectedDirectory;
			}
			else
			{
				openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
			}
			openFileDialog.ShowDialog();
		}

		private void setDriveIcon(string driveLetter, string filepath)
		{
			RegistryKey baseKey = Registry.LocalMachine.OpenSubKey(driveIconsRegistryBasePath, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl)
				               ?? Registry.LocalMachine.CreateSubKey(driveIconsRegistryBasePath, RegistryKeyPermissionCheck.ReadWriteSubTree);

			if (baseKey != null)
			{
				string filepathWithQuotes = $"\"{filepath}\"";

				RegistryKey defaultIconKey = baseKey.CreateSubKey($"{driveLetter}\\DefaultIcon");
				defaultIconKey.SetValue("", filepathWithQuotes, RegistryValueKind.String);

				defaultIconKey.Close();
				baseKey.Close();

				refreshState();

				iconPreviewPictureBox.Image = null;
				setIconButton.Enabled = false;
				iconFilePathTextBox.Text = "";
			}
		}

		private void unsetDriveIcon(string driveLetter)
		{
			RegistryKey baseKey = Registry.LocalMachine.OpenSubKey(driveIconsRegistryBasePath, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);

			if (baseKey != null)
			{
				baseKey.DeleteSubKeyTree(driveLetter);
				baseKey.Close();

				refreshState();
			}
		}

		private void activeDriveIconsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (activeDriveIconsGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
			{
				string driveLetter = currentIcons.ToArray()[e.RowIndex].Key;
				
				DialogResult result = MessageBox.Show(
					"Do you really want to unset this drive icon?\n\nThis action is irreversible.",
					"Confirmation",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning);
				
				if (result == DialogResult.Yes)
				{
					string comparedPath = Path.Combine(programDataDirectory, "driveicon_");
					string currentIconPath = currentIcons[driveLetter].Replace("\"", "");

					unsetDriveIcon(driveLetter);
					
					if (currentIconPath.StartsWith(comparedPath) && File.Exists(currentIconPath))
					{
						File.Delete(currentIconPath);
					}
				}
			}
		}

		private void setIconButton_Click(object sender, EventArgs e)
		{
			String filepath = iconFilePathTextBox.Text.Trim();
			if (!File.Exists(filepath))
			{
				return;
			}

			Bitmap iconBitmap = tryLoadIcon(filepath);
			if (iconBitmap == null)
			{
				MessageBox.Show("Unsupported icon type. Only .ico and .png files are supported.", "Icon Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			iconBitmap.Dispose();

			string driveLetter = driveLetterComboBox.Items[driveLetterComboBox.SelectedIndex].ToString().ToUpper();
			string copiedFilepath = copyAndConvertIcon(filepath, driveLetter);
			setDriveIcon(driveLetter, copiedFilepath);
		}
		
		public bool isAdministrator()
		{
			bool isAdmin;
			try
			{
				WindowsIdentity user = WindowsIdentity.GetCurrent();
				WindowsPrincipal principal = new WindowsPrincipal(user);
				isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
			}
			catch (UnauthorizedAccessException)
			{
				isAdmin = false;
			}
			catch (Exception)
			{
				isAdmin = false;
			}
			return isAdmin;
		}
	}
}
