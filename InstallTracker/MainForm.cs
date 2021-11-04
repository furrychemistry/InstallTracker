using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallTracker
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent ();
		}

		private void Form_Load(object sender, EventArgs e)
		{
			m_LastValidDirectory = Environment.CurrentDirectory;
			txtSelectDirectory.Text = m_LastValidDirectory;
			txtLastValidDirectory.Text = m_LastValidDirectory;

			btnPickDirectory.Focus ();
		}

		private static readonly string[] m_RunTheseExtensions =
		{
			"*.exe",
			"*.msi",
		};

		private void btnPopulateRunList_Click(object sender, EventArgs e)
		{
			var lst = chklstFiles.Items;

			lst.Clear ();

			foreach(var find in m_RunTheseExtensions)
			{
				foreach(var file in Directory.GetFiles(m_LastValidDirectory, find, SearchOption.TopDirectoryOnly))
				{
					lst.Add (new ListBoxEntry (new FileInfo (file)), true);
				}
			}

			if (chklstFiles.Items.Count > 0)
				chklstFiles.Focus();
			else
				btnPickDirectory.Focus();
		}

		private string m_LastValidDirectory;

		private void txtSelectDirectory_TextChanged(object sender, EventArgs e)
		{
			string test = txtSelectDirectory.Text;

			if (Directory.Exists(test))
			{
				m_LastValidDirectory = test[test.Length - 1] == '\\' ? test : test + '\\';
				txtLastValidDirectory.Text = m_LastValidDirectory;
				txtSelectDirectory.ForeColor = Color.Green;
			}
			else
			{
				txtSelectDirectory.ForeColor = Color.Red;
			}
		}

		private bool m_RunSelected_ContinueRun;
		private bool m_RunSelected_Running;

		private void RunSelected_ThreadMain_DisableControls()
		{
			Monitor.Enter(this);
			{
				btnStopRun.Visible = true;
				btnStopRun.Focus();

				btnRunAll.Enabled = false;
				txtSelectDirectory.Enabled = false;
				btnPickDirectory.Enabled = false;
				btnPopulateRunList.Enabled = false;
				chklstFiles.Enabled = false;
			}
			Monitor.Exit(this);
		}

		private void RunSelected_ThreadMain_EnableControls()
		{
			Monitor.Enter(this);
			{
				btnRunAll.Enabled = true;
				btnRunAll.Focus();

				btnStopRun.Visible = false;
				txtSelectDirectory.Enabled = true;
				btnPickDirectory.Enabled = true;
				btnPopulateRunList.Enabled = true;
				chklstFiles.Enabled = true;

				m_RunSelected_Running = false;
			}
			Monitor.Exit(this);
		}

		private void RunSelected_ThreadMain(object _)
		{
			Invoke((Action)RunSelected_ThreadMain_DisableControls);

			Action<int> uncheckIndex = (int index) => chklstFiles.SetItemChecked(index, false);
			Func<IWin32Window, string, string, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton
				, DialogResult> showMsgBox = MessageBox.Show;

			var lstBox = chklstFiles;

			for (int i = 0, count = lstBox.Items.Count; i < count; i++)
			{
				if (!m_RunSelected_ContinueRun)
					break;

				if (!lstBox.GetItemChecked(i))
					continue;

				var newline = Environment.NewLine;
				var newdoubleline = newline + newline;
				var entry = (ListBoxEntry)lstBox.Items[i];
				var proc = new Process();

				try
				{
					proc.StartInfo = new ProcessStartInfo(entry.Info.FullName)
					{
						WorkingDirectory = txtSelectDirectory.Text,
						UseShellExecute = true,
					};

					proc.Start();

					var abort = false;
					while (!proc.HasExited && !abort)
					{
						if (m_RunSelected_ContinueRun)
						{
							Thread.Sleep(50); // ms
						}
						else
						{
							var text = "Process is running:" + newline
								+ $"[{proc.Id}] :: {proc.ProcessName}" + newdoubleline
								+ "Leave process running?";
							var title = "Run: " + entry.Name;
							var buttons = MessageBoxButtons.YesNo;
							var icon = MessageBoxIcon.Exclamation;
							var defaultButton = MessageBoxDefaultButton.Button1;

							var result = (DialogResult)Invoke(showMsgBox, this, text, title, buttons
								, icon, defaultButton);

							// Leave it running.
							if (result == DialogResult.Yes)
							{
								text = "Move to next process without affecting the current one?";
								icon = MessageBoxIcon.None;
								buttons = MessageBoxButtons.YesNo;
								defaultButton = MessageBoxDefaultButton.Button2;

								result = (DialogResult)Invoke(showMsgBox, this, text, title, buttons
									, icon, defaultButton);

								// Move to next process.
								if (result == DialogResult.Yes)
									abort = true;
								else
									m_RunSelected_ContinueRun = true;
							}
							// Close it.
							else
							{
								text = "Are you sure!?" + newdoubleline + "This MAY cause issues!";
								icon = MessageBoxIcon.Exclamation;
								buttons = MessageBoxButtons.YesNo;
								defaultButton = MessageBoxDefaultButton.Button2;

								result = (DialogResult)Invoke(showMsgBox, this, text, title, buttons
									, icon, defaultButton);

								// Close it!
								if (result == DialogResult.Yes)
								{
									try
									{
										if (!proc.CloseMainWindow())
											proc.Close();
									}
									catch
									{
										try { proc.Close(); }
										catch { }
									}

									abort = true;
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					var text = ex.Message + newdoubleline + "\tContinue?";
					var title = entry.Name;
					var buttons = MessageBoxButtons.YesNo;
					var icon = MessageBoxIcon.Error;
					var defaultButton = MessageBoxDefaultButton.Button2;

					var result = (DialogResult)Invoke(showMsgBox, this, text, title, buttons
						, icon, defaultButton);

					if (result == DialogResult.No)
						m_RunSelected_ContinueRun = false;
				}

				proc.Dispose();
				lstBox.Invoke(uncheckIndex, i);
			}

			Invoke((Action)RunSelected_ThreadMain_EnableControls);
		}

		private void btnRunSelected_Click(object sender, EventArgs e)
		{
			if (m_RunSelected_Running)
				return;

			Monitor.Enter(this);
			{
				if (!m_RunSelected_Running)
				{
					m_RunSelected_Running = true;
					m_RunSelected_ContinueRun = true;

					try
					{
						ThreadPool.QueueUserWorkItem(RunSelected_ThreadMain); // Throws if not added.
					}
					catch
					{
						m_RunSelected_Running = false;
						Monitor.Exit(this);

						throw;
					}
				}
			}
			Monitor.Exit(this);
		}

		private void btnStopRun_Click(object sender, EventArgs e) => m_RunSelected_ContinueRun = false;

		private void btnPickDirectory_Click(object sender, EventArgs e)
		{
			var dialog = dialogPickDirectory;

			if (dialog.ShowDialog(this) == DialogResult.OK)
			{
				txtSelectDirectory.Text = dialog.SelectedPath;
				btnPopulateRunList.Focus();
			}
		}

		private void ctxLastValidDirectory_SelectAll_Click(object sender, EventArgs e)
			=> txtLastValidDirectory.SelectAll();

		private void ctxLastValidDirectory_Copy_Click(object sender, EventArgs e)
			=> txtLastValidDirectory.Copy();

		private void ctxSelectDirectory_SelectAll_Click(object sender, EventArgs e)
			=> txtSelectDirectory.SelectAll();

		private void ctxSelectDirectory_Cut_Click(object sender, EventArgs e)
			=> txtSelectDirectory.Cut();

		private void ctxSelectDirectory_Copy_Click(object sender, EventArgs e)
			=> txtSelectDirectory.Copy();

		private void ctxSelectDirectory_Paste_Click(object sender, EventArgs e)
		{
			try { txtSelectDirectory.Paste(); }
			catch { }
		}

		private void ctxSelectDirectory_Clear_Click(object sender, EventArgs e)
			=> txtSelectDirectory.Clear();
	}
}
