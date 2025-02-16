using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Text;
using static ONBOARDING.DBConnection;
using static ONBOARDING.Email;

namespace ONBOARDING
{
	public partial class form_supplier_tasks : Form
	{
		DataView taskTrack;
		DataView supplierInfo;

		public form_supplier_tasks()
		{
			InitializeComponent();
		}

		protected void txtbox_supplier_search_KeyDown(object sender, KeyEventArgs e) // capture enter key event in supplier textbox
		{
			if (e.KeyCode == Keys.Enter && txtbox_supplier_search.Text.Length > 4) { strip_message.Text = ""; DatagridviewUpdate(); }
		}

		private void DatagridviewUpdate() // updates datagrid view when supplier is searched
		{
			strip_message.Text = $"HANG ON, I'M SEARCHING...  ─=≡Σʕっ•ᴥ•ʔっ";
			string supplierSearch = txtbox_supplier_search.Text.Replace("'", "''").Trim();
			bool fuzzy = true;
			if (supplierSearch.Replace(" ", "").All(char.IsDigit)) { fuzzy = false; supplierSearch = supplierSearch.Replace(" ", "").TrimStart('0'); }
			
			string currentTime = DateTime.Now.ToString("HH:mm:ss");
			supplierInfo = Query.SupplierInfo(supplierSearch, fuzzy);
			strip_time.Text = currentTime;
			if (supplierInfo.Count == 0)
			{
				strip_message.Text = @$"NO RESULTS FOR <{supplierSearch}>  ¯\_(ツ)_/¯";
				ClearData();
				return;
			}

			DataRowView row = supplierInfo[0];
			taskTrack = Query.TaskTrack(row["SUPPLIER_NO"].ToString());
			dgv_tasks.DataSource = taskTrack;
			txtbox_sup_profile.Text = row["PROFILE"].ToString();
			lbl_sup_name.Text = row["SUPPLIER_NAME"].ToString();
			txtbox_contract_type.Text = row["CONTRACT_TYPE"].ToString();
			txtbox_supplier_notes.Text = row["COMMENTS"].ToString();
			strip_status.Text = row["STATUS"].ToString();

			if (!dgv_tasks.Columns.Contains("TASK_BUTTON"))
			{
				DataGridViewButtonColumn bttn = new() { HeaderText = "TASK_BUTTON", Name = "TASK_BUTTON" };
				dgv_tasks.Columns.Add(bttn);
			}

			foreach (DataGridViewColumn column in dgv_tasks.Columns) { column.ReadOnly = true; column.FillWeight = 80; }  
			dgv_tasks.Columns["TASKID"].FillWeight = 54;
			dgv_tasks.Columns["AUTO_COMPLETED"].FillWeight = 98;
			dgv_tasks.Columns["BACKEND_CHECK"].FillWeight = 95;
			dgv_tasks.Columns["COMMENTS"].FillWeight = 160;
			dgv_tasks.Columns["COMMENTS"].ReadOnly = false;
			dgv_tasks.Columns["TASK_DESCRIPTION"].FillWeight = 160;
			dgv_tasks.Columns["TASK_BUTTON"].FillWeight = 90;
			dgv_tasks.CellFormatting -= dgv_tasks_CellFormatting;
			dgv_tasks.CellFormatting += dgv_tasks_CellFormatting;
			strip_message.Text = $"DISPLAYING TASKS FOR SUPPLIER <{row["SUPPLIER_NO"]}>  ( ･ω･)ﾉ";
		}

		private void dgv_tasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.ColumnIndex == dgv_tasks.Columns["TASK_BUTTON"].Index && e.RowIndex >= 0) // handles comestics of the button on data grid view
			{
				string taskID = dgv_tasks.Rows[e.RowIndex].Cells["TASKID"].Value.ToString();
				string completeValue = dgv_tasks.Rows[e.RowIndex].Cells["COMPLETED"].Value.ToString();
				DataGridViewButtonCell buttonCell = dgv_tasks.Rows[e.RowIndex].Cells["TASK_BUTTON"] as DataGridViewButtonCell;
				buttonCell.Value = $"COMPLETE {taskID}";
				buttonCell.FlatStyle = FlatStyle.Flat;
				buttonCell.Style.Font = new Font("Segoe UI Semibold", 12);
				if (string.IsNullOrEmpty(completeValue)) { buttonCell.Style.BackColor = Color.SkyBlue; buttonCell.Style.ForeColor = Color.FromArgb(51, 54, 62); }
				else { buttonCell.Style.BackColor = Color.WhiteSmoke; buttonCell.Style.ForeColor = Color.Gray; }
			}
			dgv_tasks.Columns["TASK_BUTTON"].DisplayIndex = dgv_tasks.Columns.Count - 1; // moves the button to last column after refresh
		}

		private void dgv_tasks_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string currentTime = DateTime.Now.ToString("HH:mm:ss");
			string taskID = dgv_tasks.Rows[e.RowIndex].Cells["taskID"].Value.ToString();
			string supNo = taskTrack[0]["SUPPLIER_NO"].ToString();
			string profile = supplierInfo[0]["PROFILE"].ToString();
			string completeValue = dgv_tasks.Rows[e.RowIndex].Cells["COMPLETED"].Value.ToString();
			string initiatedValue = dgv_tasks.Rows[e.RowIndex].Cells["INITIATED"].Value.ToString();
			var autoCompleteValue = (bool)dgv_tasks.Rows[e.RowIndex].Cells["AUTO_COMPLETED"].Value;
			var backendCheckValue = (bool)dgv_tasks.Rows[e.RowIndex].Cells["BACKEND_CHECK"].Value;
			if (!string.IsNullOrEmpty(completeValue)) return;

			if (e.ColumnIndex == dgv_tasks.Columns["TASK_BUTTON"].Index && e.RowIndex >= 0) // handles complete button column
			{
				DialogResult result = MessageBox.Show($"COMPLETE TASK <{taskID}>  (´･ω･`)?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.No) return;

				if (string.IsNullOrEmpty(initiatedValue))
				{
					strip_time.Text = currentTime;
					strip_message.Text = $"TASK CANNOT BE COMPLETED BEFORE IT'S INITIATED  ヾ( ･`⌓´･)ﾉﾞ";
					return;
				}
				if (backendCheckValue)
				{
					string statusMessage = $"TASK <{taskID}> HAS NOT BEEN COMPLETED - CONDITION(S) NOT SATISFIED  ヾ( ･`⌓´･)ﾉﾞ";
					if (BackendCheck.CompleteBackend(supNo, profile, taskID)) statusMessage = $"TASK <{taskID}> HAS BEEN COMPLETED  ( • ̀ω•́ )✧";
					RefreshDataGridView(supNo, statusMessage);
					return;
				}
				Query.CompleteTasks(supNo, taskID);
				Parallel.Invoke(() => InitiateNextTask(taskID, supNo, profile), () => SendTaskCompleteEmails(taskID, supNo, profile));
				RefreshDataGridView(supNo, $"TASK <{taskID}> HAS BEEN COMPLETED  ( • ̀ω•́ )✧");
			}

			if (e.ColumnIndex == dgv_tasks.Columns["BYPASSED"].Index && e.RowIndex >= 0) // handles BYPASSED checkbox column 
			{
				if (autoCompleteValue || taskID == "6Z") return;
				DialogResult result = MessageBox.Show($"BYPASS TASK <{taskID}>  (´･ω･`)?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.No) return;
				SnowflakeCommand($"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK SET BYPASSED = TRUE, COMPLETED = CURRENT_DATE WHERE SUPPLIER_NO = '{supNo}' AND TASKID = '{taskID}'");
				Parallel.Invoke(() => InitiateNextTask(taskID, supNo, profile), () => SendTaskCompleteEmails(taskID, supNo, profile));
				RefreshDataGridView(supNo, $"TASK <{taskID}> HAS BEEN COMPLETED USING BYPASS  ( ﾉ･o･ )ﾉ");
			}
			
			if ((e.ColumnIndex == dgv_tasks.Columns["TASK_BUTTON"].Index || e.ColumnIndex == dgv_tasks.Columns["BYPASSED"].Index) && e.RowIndex >= 0) // handles 6Z
			{
				int taskNullCount = 0;
				foreach (DataRowView row in taskTrack) { if (string.IsNullOrEmpty(row["COMPLETED"].ToString())) { taskNullCount += 1; } }
				if (taskNullCount == 1) // 6Z is the only reminaing task not completed
				{
					Parallel.Invoke(() => Query.InitiateTasks(supNo, "6Z"), 
						() => SnowflakeCommand($"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK SET INITIATED = CURRENT_DATE, COMPLETED = CURRENT_DATE WHERE SUPPLIER_NO = '{supNo}' AND TASKID = '6Z'"),
						() => SendTaskCompleteEmails("6Z", supNo, profile),
						() => SnowflakeCommand($"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_SUPPLIER SET STATUS = 'COMPLETE' WHERE SUPPLIER_NO = '{supNo}'"),
						() => SQLCommand($"UPDATE ITEMMANAGEMENT.DBO.SUPPLIER_ALIGNMENT SET STANDING = 'New' WHERE SUPPLIERNUMBER = {supNo}"));
					RefreshDataGridView(supNo, "SUPPLIER ONBOARDING COMPLETED  ( ﾉ･o･ )ﾉ");
					strip_status.Text = "COMPLETE";
				}
			}
		}

		private void dgv_tasks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dgv_tasks.Columns["COMMENTS"].Index && e.RowIndex >= 0) // handles comment column edit
			{
				string taskID = dgv_tasks.Rows[e.RowIndex].Cells["TASKID"].Value.ToString();
				string comments = dgv_tasks.Rows[e.RowIndex].Cells["COMMENTS"].Value.ToString().Replace("'", "''");
				string supNo = dgv_tasks.Rows[e.RowIndex].Cells["SUPPLIER_NO"].Value.ToString();
				SnowflakeCommand($"UPDATE ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK SET COMMENTS = LEFT('{comments}', 250) WHERE SUPPLIER_NO = '{supNo}' AND TASKID = '{taskID}'");
			}
		}

		private static void InitiateNextTask(string taskID, string supNo, string profile)  //Code to initiate next task if dependent tasks have been marked as complete
		{
			DataView profileDependency = SnowflakeView($"SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_TASK_DEPENDENCIES WHERE PROFILE = '{profile}' AND TASKID = '{taskID}'");
			if (profileDependency.Count == 0) return;
			DataRowView taskRow = profileDependency[0];
			string taskToIntitiate = taskRow["INITIATE"].ToString();
			string dependentTasks = taskRow["CHECK_IF_COMPLETE"].ToString();

			if (!string.IsNullOrEmpty(dependentTasks))
			{
				if (!Query.DependentTaskComplete(supNo, dependentTasks)) return; // if any dependent tasks are not completed then dont initiate next task
			}

			if (string.IsNullOrEmpty(taskToIntitiate)) return;
			Query.InitiateTasks(supNo, taskToIntitiate);

			DataView autoCompleteTasks = SnowflakeView($@"SELECT * FROM ISP.SPM.SUPPLIER_ONBOARDING_TASK_TRACK WHERE SUPPLIER_NO = '{supNo}' AND AUTO_COMPLETED = true");
			string[] initiateTasks = taskToIntitiate.Split(',');
			foreach (string task in initiateTasks)
			{
				autoCompleteTasks.RowFilter = $"TASKID = '{task}'";
				if (autoCompleteTasks.Count > 0) // check for autocomplete email tasks done by program and complete them
				{
					Parallel.Invoke(() => Query.CompleteTasks(supNo, task), () => SendTaskCompleteEmails(task, supNo, profile));
					InitiateNextTask(task, supNo, profile);
				}
			}
		}

		private void RefreshDataGridView(string supNo, string statusMessage) // refreshes datagrid also keeps user on the current row
		{
			string currentTime = DateTime.Now.ToString("HH:mm:ss");
			int firstDisplayedRow = dgv_tasks.FirstDisplayedScrollingRowIndex;
			taskTrack = Query.TaskTrack(supNo);
			dgv_tasks.DataSource = taskTrack;
			if (firstDisplayedRow >= 0 && firstDisplayedRow < dgv_tasks.RowCount) dgv_tasks.FirstDisplayedScrollingRowIndex = firstDisplayedRow;
			strip_time.Text = currentTime;
			strip_message.Text = statusMessage;
		}

		private void ClearData()
		{
			foreach (Control ctrl in panel_supplier_tasks_top.Controls)
			{ if (ctrl is TextBox || ctrl.Name == "lbl_sup_name" || ctrl is ComboBox) ctrl.Text = ""; }
			dgv_tasks.DataSource = null;
		}

		private void action_reset_tasks_Click(object sender, EventArgs e)
		{
			if (dgv_tasks.Rows.Count == 0) return;
			string supNo = dgv_tasks.Rows[0].Cells["SUPPLIER_NO"].Value.ToString();
			DialogResult result = MessageBox.Show("RESET ONBOARD PROCESS FOR SUPPLIER  (´･ω･`)?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.No) return;
			Query.ResetAllTasks(supNo);
			RefreshDataGridView(supNo, $"SUPPLIER <{supNo}> HAS BEEN RESET  (╯°□°)╯︵ ┻━┻");
		}
	}
}