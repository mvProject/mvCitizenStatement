using System;
using static mvCitizenStatement.mvSettings;
using System.Windows.Forms;

namespace mvCitizenStatement
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();

            #region Загрузка настроек общего плана
            txtOrganiationName.Text = OrganisationName;
            txtDepartmentName.Text = DepartmentName;
            pnControlColor.BackColor = ControlColor;
            #endregion
            #region Загрузка Каталогов
            txtDatabaseDir.Text = DatabaseDir;
            txtTemplateDir.Text = TemplateDir;
            txtReportDir.Text = ReportDir;
            txtImportDir.Text = ImportDir;
            #endregion
            #region Загрузка вкладки Лицевая сторона
             chCitizenAddress.Text = CitizenAddress;
             chCitizenAddress.Checked = CitizenAddressView;

             chCitizenName.Text = CitizenName;
             chCitizenName.Checked = CitizenNameView;

             chTreatmentType.Text = TreatmentType;
             chTreatmentType.Checked = TreatmentTypeView;

             chCorrespondentType.Text = CorrespondentType;
             chCorrespondentType.Checked = CorrespondentTypeView;

             chControlDate.Text = ControlDate;
             chControlDate.Checked = ControlDateView;

             chReceivedDate.Text = ReceivedDate;
             chReceivedDate.Checked = ReceivedDateView;

             chIndexReg.Text = IndexReg;
             chIndexReg.Checked = IndexRegView;

             chRecievedFrom.Text = RecievedFrom;
             chRecievedFrom.Checked = RecievedFromView;

             chSendingDate.Text = SendingDate;
             chSendingDate.Checked = SendingDateView;

             chIndexDoc.Text = IndexDoc;
             chIndexDoc.Checked = IndexDocView;

             chRecieveType.Text = RecieveType;
             chRecieveType.Checked = RecieveTypeView;

             chTreatmentsBefore.Text = TreatmentsBefore;
             chTreatmentsBefore.Checked = TreatmentsBeforeView;

             chQuestion.Text = Question;
             chQuestion.Checked = QuestionView;

             chSubquestion.Text = Subquestion;
             chSubquestion.Checked = SubquestionView;

             chResolution.Text = Resolution;
             chResolution.Checked = ResolutionView;

             chResolutionAuthor.Text = ResolutionAuthor;
             chResolutionAuthor.Checked = ResolutionAuthorView;

             chCorrespondentCategory.Text = CorrespondentCategory;
             chCorrespondentCategory.Checked = CorrespondentCategoryView;

             chExecuteDaysCount.Text = ExecuteDaysCount;
             chExecuteDaysCount.Checked = ExecuteDaysCountView;

            #endregion
            #region Загрузка режима работы и открытой вкладки при старте
            cbWorkingMode.SelectedIndex = WorkingModeIndex;
            #endregion
            #region Загрузка вкладки Обратная сторона

            chDateWorking.Text = DateWorking;
            chDateWorking.Checked = DateWorkingView;

            chExecutor.Text = Executor;
            chExecutor.Checked = ExecutorView;

            chWorkingNote.Text = WorkingNote;
            chWorkingNote.Checked = WorkingNoteView;

            chControlState.Text = ControlState;
            chControlState.Checked = ControlStateView;

            chDateChecked.Text = DateChecked;
            chDateChecked.Checked = DateCheckedView;

            chWorkerChecked.Text = WorkerChecked;
            chWorkerChecked.Checked = WorkerCheckedView;

            chWorkingDate.Text = WorkingDate;
            chWorkingDate.Checked = WorkingDateView;

            chCitizenAddress.Text = CitizenAddress;
            chCitizenDate.Checked = CitizenDataView;

            chAgreed.Text = Agreed;
            chAgreed.Checked = AgreedView;

            chReviewResult.Text = ReviewResult;
            chReviewResult.Checked = ReviewResultView;

            chController.Text = Controller;
            chController.Checked = ControllerView;

            chCase.Text = CaseSecond;
            chCase.Checked = CaseView;

            chVolume.Text = Volume;
            chVolume.Checked = VolumeView;

            chPagesCount.Text = PagesCount;
            chPagesCount.Checked = PagesCountView;

            chFund.Text = Fund;
            chFund.Checked = FundView;

            chReview.Text = Review;
            chReview.Checked = ReviewView;

            chCaseSecond.Text = CaseSecond;
            chCaseSecond.Checked = CaseSecondView;
            #endregion
        }
        /// <summary>
        /// Диалог выбора каталога для сохранения
        /// </summary>
        /// <returns>выбраный каталог</returns>
        private string selectFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                return fbd.SelectedPath + "\\";
            return null;
        }
        /// <summary>
        /// Сохранение выбранных настроек
        /// </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            #region Сохранение настроек общего плана
            OrganisationName = txtOrganiationName.Text;
            DepartmentName = txtDepartmentName.Text;
            strControlColor = pnControlColor.BackColor.ToArgb().ToString();
            #endregion
            #region Сохранение Каталогов
            DatabaseDir = txtDatabaseDir.Text;
            TemplateDir = txtTemplateDir.Text;
            ReportDir = txtReportDir.Text;
            ImportDir = txtImportDir.Text;
            #endregion
            #region Сохранение вкладки Обратная сторона
            DateWorking = chDateWorking.Text;
            DateWorkingView = chDateWorking.Checked;

            Executor = chExecutor.Text;
            ExecutorView = chExecutor.Checked;

            WorkingNote = chWorkingNote.Text;
            WorkingNoteView = chWorkingNote.Checked;

            ControlState = chControlState.Text;
            ControlStateView = chControlState.Checked;

            DateChecked = chDateChecked.Text;
            DateCheckedView = chDateChecked.Checked;

            WorkerChecked = chWorkerChecked.Text;
            WorkerCheckedView = chWorkerChecked.Checked;

            WorkingDate = chWorkingDate.Text;
            WorkingDateView = chWorkingDate.Checked;

            CitizenData = chCitizenDate.Text;
            CitizenDataView = chCitizenDate.Checked;

            Agreed = chAgreed.Text;
            AgreedView = chAgreed.Checked;

            ReviewResult = chReviewResult.Text;
            ReviewResultView = chReviewResult.Checked;

            Controller = chController.Text;
            ControllerView = chController.Checked;

            Case = chCase.Text;
            CaseView = chCase.Checked;

            Volume = chVolume.Text;
            VolumeView = chVolume.Checked;

            PagesCount = chPagesCount.Text;
            PagesCountView = chPagesCount.Checked;

            Fund = chFund.Text;
            FundView = chFund.Checked;

            Review = chReview.Text;
            ReviewView = chReview.Checked;

            CaseSecond = chCaseSecond.Text;
            CaseSecondView = chCaseSecond.Checked;
            #endregion
            #region Сохранение режима работы и открытой вкладки при старте
            WorkingModeStart = cbWorkingMode.SelectedItem.ToString();
            WorkingModeIndex = cbWorkingMode.SelectedIndex;
            #endregion
            #region Сохранение вкладки Лицевая сторона
            CitizenAddress = chCitizenAddress.Text;
            CitizenAddressView = chCitizenAddress.Checked;

            CitizenName = chCitizenName.Text;
            CitizenNameView = chCitizenName.Checked;

            TreatmentType = chTreatmentType.Text;
            TreatmentTypeView = chTreatmentType.Checked;

            CorrespondentType = chCorrespondentType.Text;
            CorrespondentTypeView = chCorrespondentType.Checked;

            ControlDate = chControlDate.Text;
            ControlDateView = chControlDate.Checked;

            ReceivedDate = chReceivedDate.Text;
            ReceivedDateView = chReceivedDate.Checked;

            IndexReg = chIndexReg.Text;
            IndexRegView = chIndexReg.Checked;

            RecievedFrom = chRecievedFrom.Text;
            RecievedFromView = chRecievedFrom.Checked;

            SendingDate = chSendingDate.Text;
            SendingDateView = chSendingDate.Checked;

            IndexDoc = chIndexDoc.Text;
            IndexDocView = chIndexDoc.Checked;

            RecieveType = chRecieveType.Text;
            RecieveTypeView = chRecieveType.Checked;

            TreatmentsBefore = chTreatmentsBefore.Text;
            TreatmentsBeforeView = chTreatmentsBefore.Checked;

            Question = chQuestion.Text;
            QuestionView = chQuestion.Checked;

            Subquestion = chSubquestion.Text;
            SubquestionView = chSubquestion.Checked;

            Resolution = chResolution.Text;
            ResolutionView = chResolution.Checked;

            ResolutionAuthor = chResolutionAuthor.Text;
            ResolutionAuthorView = chResolutionAuthor.Checked;

            CorrespondentCategory = chCorrespondentCategory.Text;
            CorrespondentCategoryView = chCorrespondentCategory.Checked;

            ExecuteDaysCount = chExecuteDaysCount.Text;
            ExecuteDaysCountView = chExecuteDaysCount.Checked;
            #endregion
            SaveSettings();
            DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Выбор каталога для настроек путей для работы программы
        /// </summary>
        private void selectDir(object sender, EventArgs e)
        {
            switch ((sender as TextBox).Tag.ToString())
            {
                case "database":
                    txtDatabaseDir.Text = selectFolder();
                    break;
                case "template":
                    txtTemplateDir.Text = selectFolder();
                    break;
                case "report":
                    txtReportDir.Text = selectFolder();
                    break;
                case "import":
                    txtImportDir.Text = selectFolder();
                    break;
            }
        }
        /// <summary>
        /// Выбор цвета для выделения записи
        /// </summary>
        private void SelectColor(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pnControlColor.BackColor = cd.Color;
            }
        }
    }
}
