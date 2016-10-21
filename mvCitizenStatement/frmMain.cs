using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static mvCitizenStatement.mvSettings;
using static mvCitizenStatement.DataModel;

namespace mvCitizenStatement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoadSettings();
            this.Text = string.Format("Корреспонденция : {0} : {1}", OrganisationName, DepartmentName);
        }
        /// <summary>
        /// Добавление нового элемента
        /// </summary>
        private void btnAddItem_Click(object sender, EventArgs e)
        {
                AddMessage();
        }
        private void AddMessage()
        {
            frmMessageDetail frmMessageDetail = new frmMessageDetail();
            if (frmMessageDetail.ShowDialog() == DialogResult.OK)
            {
                dgv.DataSource = ShowMessageData();
            }
        }
        /// <summary>
        /// Редактирование выбранного элемента
        /// </summary>
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            IsEdit = true;
            IdEdit = Int32.Parse(dgv.CurrentRow.Cells[0].Value.ToString());
            int rowId = dgv.FirstDisplayedScrollingRowIndex;
            int id = dgv.CurrentCell.RowIndex;

            frmMessageDetail frmMessageDetail = new frmMessageDetail();
            if (frmMessageDetail.ShowDialog() == DialogResult.OK)
            {
                dgv.DataSource = ShowMessageData();
            }

            dgv.FirstDisplayedScrollingRowIndex = rowId;
            dgv.CurrentCell = dgv.Rows[id].Cells[1];
            IsEdit = false;
        }
        /// <summary>
        /// Удаление одного или нескольких элементов
        /// </summary>
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?",
                                "Удаление",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Warning) == DialogResult.OK)
            {

            }
        }
        /// <summary>
        /// Показ формы с настройками программы,после подтверждения - настройки сохраняются и применяются сразу
        /// </summary>
        private void mnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            if (frmSettings.ShowDialog() == DialogResult.OK)
            {
                LoadSettings();
                //switch (WorkingMode)
                //{
                //    case "Входящие":
                //        dgvIncomingView();
                //        break;
                //    case "Исходящие":
                //        dgvOutgoingView();
                //        break;
                //}
                this.Text = string.Format("Корреспонденция : {0} : {1}", OrganisationName, DepartmentName);
            }
        }
        /// <summary>
        /// Создание новой базы данных
        /// </summary>
        private void mnCreate_Click(object sender, EventArgs e)
        {
            frmNewDatabase frmNewDatabase = new frmNewDatabase();
            frmNewDatabase.ShowDialog();
        }
        /// <summary>
        /// Выбор и открытие существующей базы данных
        /// </summary>
        private void mnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.db;";
            ofd.InitialDirectory = DatabaseDir;
            ofd.Filter = "SQlite databases (*.db)|*.db";
            ofd.Title = "Выберите файл базы данных для загрузки";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //cbWorkingMode.SelectedIndex = WorkingModeIndex;
                //WorkingMode = WorkingModeStart;
                this.WindowState = FormWindowState.Maximized;
                //открыть нужную таблицу в зависимости от настроек
                //switch (WorkingMode)
                //{
                //    case "Входящие":
                        dgv.DataSource = OpenTableMessage(ofd.FileName);
                //        btnShowControl.Visible = true;
                //        mnImportOutgoing.Enabled = false;
                //        dgvIncomingView();
                //        break;
                //    case "Исходящие":
                //        dgv.DataSource = OpenTableMessageOut(ofd.FileName);
                //        dgvOutgoingView();
                //        mnImportIncoming.Enabled = false;
                //        break;
                //}
                //mnImport.Enabled = true;
                mnPrint.Enabled = true;
                //ShowRecordCount();
            }

        }

        private void selectReferences(object sender, EventArgs e)
        {
            CurrentReference = (sender as ToolStripMenuItem).Tag.ToString();
            CurrentReferenceName = (sender as ToolStripMenuItem).Text;
            frmReferencesDetail frmReferencesDetail = new frmReferencesDetail();
            if (frmReferencesDetail.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
