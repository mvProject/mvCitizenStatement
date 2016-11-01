using System;
using System.Windows.Forms;
using static mvCitizenStatement.mvSettings;
using static mvCitizenStatement.DataModel;
using static mvCitizenStatement.mvReport;
using TemplateEngine.Docx;

namespace mvCitizenStatement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoadSettings();
            this.Text = string.Format("Кореспонденція : {0} : {1}", OrganisationName, DepartmentName);
        }
        /// <summary>
        /// Пункт меню - Добавить
        /// </summary>
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddMessage();
        }
        /// <summary>
        /// Добавление нового элемента
        /// </summary>
        private void AddMessage()
        {
            frmMessageDetail frmMessageDetail = new frmMessageDetail();
            if (frmMessageDetail.ShowDialog() == DialogResult.OK)
            {
                dgv.DataSource = ShowMessageData();
                ShowRecordCount();
            }
        }
        /// <summary>
        /// Пункт меню - Редактировать
        /// </summary>
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            EditItem();
        }
        /// <summary>
        /// Двлйной клик по строке - режим Редактирования
        /// </summary>
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditItem();
        }
        /// <summary>
        /// Редактирование выбранного элемента
        /// </summary>
        private void EditItem()
        {
            try
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
            catch (NullReferenceException e)
            {
                MessageBox.Show("Ви повинні виділити запис!");
            }
        }
        /// <summary>
        /// Удаление одного или нескольких элементов
        /// </summary>
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити запис?",
                                "Видалення",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Warning) == DialogResult.OK)
            {

                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    var id = row.Cells[0].Value.ToString();
                    DeleteMessage(id);
                }
                dgv.DataSource = ShowMessageData();
                ShowRecordCount();
            }
        }
        /// <summary>
        /// Удаление записи с указанным Id из таблицы
        /// </summary>
        /// <param name="id">Id записи которую нужно удалить </param>
        private void DeleteMessage(string id)
        {
            DeleteItem<MessageCitizen>(Int32.Parse(id));
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
                dgvView();
                this.Text = string.Format("Кореспонденція : {0} : {1}", OrganisationName, DepartmentName);
            }
        }
        /// <summary>
        /// Создание новой базы данных
        /// </summary>
        private void mnCreate_Click(object sender, EventArgs e)
        {
            frmNewDatabase frmNewDatabase = new frmNewDatabase();
            if (frmNewDatabase.ShowDialog() == DialogResult.OK)
            {

            }
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
                this.WindowState = FormWindowState.Maximized;
                dgv.DataSource = OpenTableMessage(ofd.FileName);
                mnReferences.Enabled = true;
                mnPrint.Enabled = true;
                btnAddItem.Enabled = true;
                btnEditItem.Enabled = true;
                btnDeleteItem.Enabled = true;
                dgv.Focus();
                dgvView();
                ShowRecordCount();
            }
        }
        /// <summary>
        /// Настройка внешнего вида таблицы Исходящие
        /// настройка видимости столбцов
        /// настройка названий столбцов
        /// </summary>
        private void dgvView()
        {
            if (mnPrint.Enabled)
            {
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    dgv.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                #region Лицевая сторона
                dgv.Columns[0].Visible = IdView;
                dgv.Columns[0].HeaderText = Id;

                dgv.Columns[1].Visible = ReceivedDateView;
                dgv.Columns[1].HeaderText = ReceivedDate;

                dgv.Columns[2].Visible = ControlDateView;
                dgv.Columns[2].HeaderText = ControlDate;

                dgv.Columns[3].Visible = CitizenAddressView;
                dgv.Columns[3].HeaderText = CitizenAddress;
                dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgv.Columns[4].Visible = CitizenNameView;
                dgv.Columns[4].HeaderText = CitizenName;
                dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgv.Columns[5].Visible = CitizenPhoneView;
                dgv.Columns[5].HeaderText = CitizenPhone;

                dgv.Columns[6].Visible = CitizenEmailView;
                dgv.Columns[6].HeaderText = CitizenEmail;

                dgv.Columns[7].Visible = TreatmentTypeView;
                dgv.Columns[7].HeaderText = TreatmentType;
                dgv.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgv.Columns[8].Visible = CorrespondentTypeView;
                dgv.Columns[8].HeaderText = CorrespondentType;
                dgv.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgv.Columns[9].Visible = RecieveSignView;
                dgv.Columns[9].HeaderText = RecieveSign;
                dgv.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgv.Columns[10].Visible = IndexRegView;
                dgv.Columns[10].HeaderText = IndexReg;

                dgv.Columns[11].Visible = RecievedFromView;
                dgv.Columns[11].HeaderText = RecievedFrom;

                dgv.Columns[12].Visible = SendingDateView;
                dgv.Columns[12].HeaderText = SendingDate;

                dgv.Columns[13].Visible = IndexDocView;
                dgv.Columns[13].HeaderText = IndexDoc;

                dgv.Columns[14].Visible = RecieveTypeView;
                dgv.Columns[14].HeaderText = RecieveType;

                dgv.Columns[15].Visible = SummaryView;
                dgv.Columns[15].HeaderText = Summary;
                dgv.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgv.Columns[16].Visible = TreatmentsBeforeView;
                dgv.Columns[16].HeaderText = TreatmentsBefore;

                dgv.Columns[17].Visible = QuestionView;
                dgv.Columns[17].HeaderText = Question;

                dgv.Columns[18].Visible = SubquestionView;
                dgv.Columns[18].HeaderText = Subquestion;

                dgv.Columns[19].Visible = CorrespondentCategoryView;
                dgv.Columns[19].HeaderText = CorrespondentCategory;
                dgv.Columns[19].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgv.Columns[20].Visible = CorrespondentSocialStatusView;
                dgv.Columns[20].HeaderText = CorrespondentSocialStatus;
                dgv.Columns[20].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgv.Columns[21].Visible = ResolutionView;
                dgv.Columns[21].HeaderText = Resolution;

                dgv.Columns[22].Visible = ResolutionAuthorView;
                dgv.Columns[22].HeaderText = ResolutionAuthor;

                dgv.Columns[23].Visible = ExecuteDaysCountView;
                dgv.Columns[23].HeaderText = ExecuteDaysCount;
                #endregion
                #region Обратная сторона
                dgv.Columns[24].Visible = DateWorkingView;
                dgv.Columns[24].HeaderText = DateWorking;

                dgv.Columns[25].Visible = ExecutorView;
                dgv.Columns[25].HeaderText = Executor;

                dgv.Columns[26].Visible = WorkingNoteView;
                dgv.Columns[26].HeaderText = WorkingNote;

                dgv.Columns[27].Visible = ControlStateView;
                dgv.Columns[27].HeaderText = ControlState;

                dgv.Columns[28].Visible = DateCheckedView;
                dgv.Columns[28].HeaderText = DateChecked;

                dgv.Columns[29].Visible = WorkerCheckedView;
                dgv.Columns[29].HeaderText = WorkerChecked;

                dgv.Columns[30].Visible = WorkingDateView;
                dgv.Columns[30].HeaderText = WorkingDate;

                dgv.Columns[31].Visible = CitizenDataView;
                dgv.Columns[31].HeaderText = CitizenData;

                dgv.Columns[32].Visible = AgreedView;
                dgv.Columns[32].HeaderText = Agreed;

                dgv.Columns[33].Visible = ReviewResultView;
                dgv.Columns[33].HeaderText = ReviewResult;

                dgv.Columns[34].Visible = ControllerView;
                dgv.Columns[34].HeaderText = Controller;

                dgv.Columns[35].Visible = CaseView;
                dgv.Columns[35].HeaderText = Case;

                dgv.Columns[36].Visible = VolumeView;
                dgv.Columns[36].HeaderText = Volume;

                dgv.Columns[37].Visible = PagesCountView;
                dgv.Columns[37].HeaderText = PagesCount;

                #endregion
            }
        }
        /// <summary>
        /// Показать справочник в зависимости от выбранного пункта меню
        /// </summary>
        private void selectReferences(object sender, EventArgs e)
        {
            CurrentReference = (sender as ToolStripMenuItem).Tag.ToString();
            CurrentReferenceName = (sender as ToolStripMenuItem).Text;
            frmReferencesDetail frmReferencesDetail = new frmReferencesDetail();
            if (frmReferencesDetail.ShowDialog() == DialogResult.OK)
            {

            }
        }
        /// <summary>
        /// Печать единичной записи Исходящие 
        /// </summary>
        private void PrintSingleMessage()
        {
            var file = GetPrepareFilename("рег", dgv.CurrentRow.Cells[4].Value, dgv.CurrentRow.Cells[1].Value, dgv.CurrentRow.Cells[0].Value);
            //
            var Values = new Content();
            #region frontside
            Values.Fields.Add(GetContent("ReceivedDate", dgv.CurrentRow.Cells[1].Value, true));
            Values.Fields.Add(GetContent("ControlDate", dgv.CurrentRow.Cells[2].Value, true));
            Values.Fields.Add(GetContent("CitizenAddress", dgv.CurrentRow.Cells[3].Value));
            Values.Fields.Add(GetContent("Phone", dgv.CurrentRow.Cells[5].Value));
            Values.Fields.Add(GetContent("Email", dgv.CurrentRow.Cells[6].Value));
            Values.Fields.Add(GetContent("CitizenName", dgv.CurrentRow.Cells[4].Value));
            Values.Fields.Add(GetContent("TreatmentType", dgv.CurrentRow.Cells[7].Value));
            Values.Fields.Add(GetContent("CorrespondentType", dgv.CurrentRow.Cells[8].Value));
            Values.Fields.Add(GetContent("RecieveSign", dgv.CurrentRow.Cells[9].Value));
            Values.Fields.Add(GetContent("IndexReg", dgv.CurrentRow.Cells[10].Value));
            Values.Fields.Add(GetContent("RecievedFrom", dgv.CurrentRow.Cells[11].Value));
            Values.Fields.Add(GetContent("SendingDate", dgv.CurrentRow.Cells[12].Value, true));
            Values.Fields.Add(GetContent("IndexDoc", dgv.CurrentRow.Cells[13].Value));
            Values.Fields.Add(GetContent("RecieveType", dgv.CurrentRow.Cells[14].Value));
            Values.Fields.Add(GetContent("Summary", dgv.CurrentRow.Cells[15].Value));
            Values.Fields.Add(GetContent("TreatmentsBefore", dgv.CurrentRow.Cells[16].Value));
            Values.Fields.Add(GetContent("Question", dgv.CurrentRow.Cells[17].Value));
            Values.Fields.Add(GetContent("Subquestion", dgv.CurrentRow.Cells[18].Value));
            Values.Fields.Add(GetContent("CorrespondentCategory", dgv.CurrentRow.Cells[19].Value));
            Values.Fields.Add(GetContent("CorrespondentSocialStatus", dgv.CurrentRow.Cells[20].Value));
            Values.Fields.Add(GetContent("Resolution", dgv.CurrentRow.Cells[21].Value));
            Values.Fields.Add(GetContent("ResolutionAuthor", dgv.CurrentRow.Cells[22].Value));
            Values.Fields.Add(GetContent("ExecuteDaysCount", dgv.CurrentRow.Cells[23].Value));
            #endregion
            #region backside
            Values.Fields.Add(GetContent("DateWorking", dgv.CurrentRow.Cells[24].Value, true));
            Values.Fields.Add(GetContent("Executor", dgv.CurrentRow.Cells[25].Value));
            Values.Fields.Add(GetContent("WorkingNote", dgv.CurrentRow.Cells[26].Value));
            Values.Fields.Add(GetContent("ControlState", dgv.CurrentRow.Cells[27].Value));
            Values.Fields.Add(GetContent("DateChecked", dgv.CurrentRow.Cells[28].Value, true));
            Values.Fields.Add(GetContent("WorkerChecked", dgv.CurrentRow.Cells[29].Value));
            Values.Fields.Add(GetContent("WorkingDate", dgv.CurrentRow.Cells[30].Value));
            Values.Fields.Add(GetContent("CitizenData", dgv.CurrentRow.Cells[31].Value));
            Values.Fields.Add(GetContent("Agreed", dgv.CurrentRow.Cells[32].Value));
            Values.Fields.Add(GetContent("ReviewResult", dgv.CurrentRow.Cells[33].Value));
            Values.Fields.Add(GetContent("Controller", dgv.CurrentRow.Cells[34].Value));
            Values.Fields.Add(GetContent("Case", dgv.CurrentRow.Cells[35].Value));
            Values.Fields.Add(GetContent("Volume", dgv.CurrentRow.Cells[36].Value));
            Values.Fields.Add(GetContent("PagesCount", dgv.CurrentRow.Cells[37].Value));
            #endregion
            //
            SaveReport(Values, "tmp_statement.docx", file);
            MessageBox.Show("Завершено!");
        }
        private void PrintAllMessage()
        {

            //
            for (int i = 0; i < dgv.RowCount; i++)
            {
                var file = GetPrepareFilename("рег", dgv[4, i].Value, dgv[1, i].Value, dgv[0, i].Value);
                var Values = new Content();

                #region frontside
                Values.Fields.Add(GetContent("ReceivedDate", dgv[1, i].Value, true));
                Values.Fields.Add(GetContent("ControlDate", dgv[2, i].Value, true));
                Values.Fields.Add(GetContent("CitizenAddress", dgv[3, i].Value));
                Values.Fields.Add(GetContent("Phone", dgv[5, i].Value));
                Values.Fields.Add(GetContent("Email", dgv[6, i].Value));
                Values.Fields.Add(GetContent("CitizenName", dgv[4, i].Value));
                Values.Fields.Add(GetContent("TreatmentType", dgv[7, i].Value));
                Values.Fields.Add(GetContent("CorrespondentType", dgv[8, i].Value));
                Values.Fields.Add(GetContent("RecieveSign", dgv[9, i].Value));
                Values.Fields.Add(GetContent("IndexReg", dgv[10, i].Value));
                Values.Fields.Add(GetContent("RecievedFrom", dgv[11, i].Value));
                Values.Fields.Add(GetContent("SendingDate", dgv[12, i].Value, true));
                Values.Fields.Add(GetContent("IndexDoc", dgv[13, i].Value));
                Values.Fields.Add(GetContent("RecieveType", dgv[14, i].Value));
                Values.Fields.Add(GetContent("Summary", dgv[15, i].Value));
                Values.Fields.Add(GetContent("TreatmentsBefore", dgv[16, i].Value));
                Values.Fields.Add(GetContent("Question", dgv[17, i].Value));
                Values.Fields.Add(GetContent("Subquestion", dgv[18, i].Value));
                Values.Fields.Add(GetContent("CorrespondentCategory", dgv[19, i].Value));
                Values.Fields.Add(GetContent("CorrespondentSocialStatus", dgv[20, i].Value));
                Values.Fields.Add(GetContent("Resolution", dgv[21, i].Value));
                Values.Fields.Add(GetContent("ResolutionAuthor", dgv[22, i].Value));
                Values.Fields.Add(GetContent("ExecuteDaysCount", dgv[23, i].Value));
                #endregion
                #region backside
                Values.Fields.Add(GetContent("DateWorking", dgv[24, i].Value, true));
                Values.Fields.Add(GetContent("Executor", dgv[25, i].Value));
                Values.Fields.Add(GetContent("WorkingNote", dgv[26, i].Value));
                Values.Fields.Add(GetContent("ControlState", dgv[27, i].Value));
                Values.Fields.Add(GetContent("DateChecked", dgv[28, i].Value, true));
                Values.Fields.Add(GetContent("WorkerChecked", dgv[29, i].Value));
                Values.Fields.Add(GetContent("WorkingDate", dgv[30, i].Value));
                Values.Fields.Add(GetContent("CitizenData", dgv[31, i].Value));
                Values.Fields.Add(GetContent("Agreed", dgv[32, i].Value));
                Values.Fields.Add(GetContent("ReviewResult", dgv[33, i].Value));
                Values.Fields.Add(GetContent("Controller", dgv[34, i].Value));
                Values.Fields.Add(GetContent("Case", dgv[35, i].Value));
                Values.Fields.Add(GetContent("Volume", dgv[36, i].Value));
                Values.Fields.Add(GetContent("PagesCount", dgv[37, i].Value));
                #endregion
                SaveReport(Values, "tmp_statement.docx", file);
            }
            MessageBox.Show("Завершено!");
        }
        /// <summary>
        /// Печать одной записи
        /// </summary>
        private void mnPrintSingle_Click(object sender, EventArgs e)
        {
            try
            {
                PrintSingleMessage();
            }
            catch (NullReferenceException exc)
            {
                MessageBox.Show("Ви повинні виділити запис!");
            }
        }
        private void mnPrintAll_Click(object sender, EventArgs e)
        {
            try
            {
                PrintAllMessage();
            }
            catch (NullReferenceException exc)
            {
                MessageBox.Show("Ви повинні виділити запис!");
            }
        }
        /// <summary>
        /// Пункт меню - выход
        /// </summary>
        private void mnExit_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }
        /// <summary>
        /// Показать количество отображаемы записей
        /// </summary>
        private void ShowRecordCount()
        {
            txtRecordCount.Text = dgv.RowCount.ToString();
        }
        /// <summary>
        /// Очистить поле поиска
        /// </summary>
        private void btnClearFind_Click(object sender, EventArgs e)
        {
            txtFind.Clear();
        }
        /// <summary>
        /// Поиск по полям таблицы, отсеивающий по мере набора искомого текста
        /// </summary>
        private void FindRecords(object sender, EventArgs e)
        {
            dgv.DataSource = FindItems(txtFind.Text);
            ShowRecordCount();
        }
        /// <summary>
        /// Выбор дат для отображения записей,в случае отмены все записи
        /// </summary>
        private void btnJournal_Click(object sender, EventArgs e)
        {
            frmJournalDate frmJournalDate = new frmJournalDate();
            if (frmJournalDate.ShowDialog() == DialogResult.OK)
            {   //журнал включен
                btnJournal.Checked = true;
                dgv.DataSource = ShowMessageDataByDate(startPeriod, endPeriod);
            }
            else
            {   //журнал выключен
                btnJournal.Checked = false;
                dgv.DataSource = ShowMessageData();
            }
            ShowRecordCount();
        }


    }
}
