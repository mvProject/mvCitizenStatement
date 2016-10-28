using System;
using System.Windows.Forms;
using static mvCitizenStatement.DataModel;
using static mvCitizenStatement.mvSettings;

namespace mvCitizenStatement
{
    public partial class frmMessageDetail : Form
    {
        MessageCitizen item;
        public frmMessageDetail()
        {
            InitializeComponent();
            if (IsEdit)
            {
                this.Text = "Редагувати поточний запис";
                item = GetSingleItem(IdEdit);

                dtpReceiveDate.Value = (DateTime)item.ReceivedDate;
                dtpControlDate.Value = (DateTime)item.ControlDate;

                txtCitizenName.Text = item.CitizenName;
                txtCitizenAddress.Text = item.CitizenAddress;
                txtCitizenPhone.Text = item.CitizenPhone;
                txtCitizenEmail.Text = item.CitizenEmail;
                txtTreatmentType.Text = item.TreatmentType;
                txtCorrespondentType.Text = item.CorrespondentType;
                txtCorrespondentSocialStatus.Text = item.CorrespondentSocialStatus;
                txtSummary.Text = item.Summary;
                txtTreatmentsBefore.Text = item.TreatmentsBefore;
                txtIndexReg.Text = item.IndexReg;
                txtIndexDoc.Text = item.IndexDoc;
                txtQuestion.Text = item.Question;
                txtSubquestion.Text = item.Subquestion;
                txtRecieveType.Text = item.RecieveType;
                txtReceiveSign.Text = item.RecieveSign;
                txtRecievedFrom.Text = item.RecievedFrom;
                txtCorrespondentCategory.Text = item.CorrespondentCategory;
                txtResolution.Text = item.Resolution;
                txtResolutionAuthor.Text = item.ResolutionAuthor;
                txtExecuteDaysCount.Text = item.ExecuteDaysCount;

                txtExecutor.Text = item.Executor;
                txtWorkingNote.Text = item.WorkingNote;
                txtControlState.Text = item.ControlState;
                txtWorkingDate.Text = item.WorkingDate;
                txtCitizenData.Text = item.CitizenData;
                if (item.SendingDate != null)
                {
                    dtpSendingDate.Value = (DateTime)item.SendingDate;
                    dtpSendingDate.Checked = true;
                }
                if (item.DateWorking != null)
                {
                    dtpDateWorking.Value = (DateTime)item.DateWorking;
                    dtpDateWorking.Checked = true;
                }
                if (item.DateChecked != null)
                {
                    dtpDateChecked.Value = (DateTime)item.DateChecked;
                    dtpDateChecked.Checked = true;
                }
                txtWorkerChecked.Text = item.WorkerChecked;
                txtAgreed.Text = item.Agreed;
                txtReviewResult.Text = item.ReviewResult;
                txtController.Text = item.Controller;
                txtCase.Text = item.Case;
                txtVolume.Text = item.Volume;
                txtPagesCount.Text = item.PagesCount;
                txtPagesCount.Text = item.PagesCount;

            }
                
        }
        private void ApplyAction()
        {
            // если установлен признак "редактирование" - обновить выбранный элемент новыми данными
            if (IsEdit)
            {
                FillItemData();
                UpdateItem(item);
            }
            // если не установлен признак "редактирование" - добавить новый элемент в базу
            else
            {
                item = new MessageCitizen();
                FillItemData();
                AddItem(item);
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            ApplyAction();
            DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// заполнить элемент указанными значениями
        /// </summary>
        private void FillItemData()
        {
            //
            item.ReceivedDate = dtpReceiveDate.Value.Date;
            item.ControlDate = dtpControlDate.Value.Date;
            //
            item.CitizenName = txtCitizenName.Text;
            item.CitizenAddress = txtCitizenAddress.Text;
            item.CitizenEmail = txtCitizenEmail.Text;
            item.CitizenPhone = txtCitizenPhone.Text;
            item.TreatmentType = txtTreatmentType.Text;
            item.CorrespondentType = txtCorrespondentType.Text;
            item.CorrespondentSocialStatus = txtCorrespondentSocialStatus.Text;
            item.Summary = txtSummary.Text;
            item.TreatmentsBefore = txtTreatmentsBefore.Text;
            item.IndexReg = txtIndexReg.Text;
            item.IndexDoc = txtIndexDoc.Text;
            item.Question = txtQuestion.Text;
            item.Subquestion = txtSubquestion.Text;
            if (dtpSendingDate.Checked)
                item.SendingDate = dtpSendingDate.Value.Date;
            item.RecieveType = txtRecieveType.Text;
            item.RecieveSign = txtReceiveSign.Text;
            item.RecievedFrom = txtRecievedFrom.Text;
            item.CorrespondentCategory = txtCorrespondentCategory.Text;
            item.Resolution = txtResolution.Text;
            item.ResolutionAuthor = txtResolutionAuthor.Text;
            item.ExecuteDaysCount = txtExecuteDaysCount.Text;
            //
            if (dtpDateWorking.Checked)
                item.DateWorking = dtpDateWorking.Value.Date;
            item.Executor = txtExecutor.Text;
            item.WorkingNote = txtWorkingNote.Text;
            item.ControlState = txtControlState.Text;
            item.WorkingDate = txtWorkingDate.Text;
            item.CitizenData = txtCitizenData.Text;
            if (dtpDateChecked.Checked)
                item.DateChecked = dtpDateChecked.Value.Date;
            item.WorkerChecked = txtWorkerChecked.Text;
            item.Agreed = txtAgreed.Text;
            item.ReviewResult = txtReviewResult.Text;
            item.Controller = txtController.Text;
            item.Case = txtCase.Text;
            item.Volume = txtVolume.Text;
            item.PagesCount = txtPagesCount.Text;
        }
        /// <summary>
        /// Открывает форму "дополнительные справочники" для выбора и подстановки значений в соответствующие поля
        /// </summary>
        private void selectSubstitution(object sender, EventArgs e)
        {
            IsSubstitute = true;
            // проверка условия для выбора соответствующего справочника для подстановки
            switch ((sender as TextBox).Tag.ToString())
            {
                case "Agreed":
                    CurrentReference = "Agreeds";
                    CurrentReferenceName = "Рішення";
                    break;
                case "Organization":
                    CurrentReference = "Organizations";
                    CurrentReferenceName = "Звідки отримано";
                    break;
                case "Executant":
                    CurrentReference = "Executants";
                    CurrentReferenceName = "Виконавці";
                    break;
                case "Summary":
                    CurrentReference = "Summarys";
                    CurrentReferenceName = "Короткий зміст";
                    break;
                case "Resolution":
                    CurrentReference = "Resolutions";
                    CurrentReferenceName = "Резолюції";
                    break;
                case "TreatmentType":
                    CurrentReference = "TreatmentTypes";
                    CurrentReferenceName = "Вид звернення";
                    break;
                case "CorrespondentType":
                    CurrentReference = "CorrespondentTypes";
                    CurrentReferenceName = "Тип кореспондента (за суб'єктом)";
                    break;
                case "RecieveType":
                    CurrentReference = "RecieveTypes";
                    CurrentReferenceName = "Форма надходження";
                    break;
                case "CorrespondentCategory":
                    CurrentReference = "CorrespondentCategories";
                    CurrentReferenceName = "Категорія заявника";
                    break;
                case "SubquestionsIndex":
                    CurrentReference = "SubquestionsIndexes";
                    CurrentReferenceName = "Підпитання";
                    break;
                case "RecieveSign":
                    CurrentReference = "RecieveSigns";
                    CurrentReferenceName = "Ознака надходження";
                    break;
                case "CorrespondentSocialStatus":
                    CurrentReference = "CorrespondentSocialStatuses";
                    CurrentReferenceName = "Соціальний стан заявника";
                    break;
            }
            // открыть соответствующий справочник для подстановки
            // если выбрано значение для подстановки,то подставить соответствующее значение
            frmReferencesDetail frmReferencesDetail = new frmReferencesDetail();
            if (frmReferencesDetail.ShowDialog() == DialogResult.OK)
            {
                switch ((sender as TextBox).Tag.ToString())
                {
                    case "Agreed":
                        txtAgreed.Text = SubstituteValue;
                        break;
                    case "Organization":
                        txtRecievedFrom.Text = SubstituteValue;
                        break;
                    case "Executant":
                        switch ((sender as TextBox).Name)
                        {
                            case "txtExecutor":
                                txtExecutor.Text = SubstituteValue;
                                break;
                            case "txtWorkerChecked":
                                txtWorkerChecked.Text = SubstituteValue;
                                break;
                            case "txtController":
                                txtController.Text = SubstituteValue;
                                break;
                            case "txtResolutionAuthor":
                                txtResolutionAuthor.Text = SubstituteValue;
                                break;
                        }
                        break;
                    case "Summary":
                        txtSummary.Text = SubstituteValue;
                        break;
                    case "Resolution":
                        txtResolution.Text = SubstituteValue;
                        break;
                    case "TreatmentType":
                        txtTreatmentType.Text = SubstituteValue;
                        break;
                    case "CorrespondentType":
                        txtCorrespondentType.Text = SubstituteValue;
                        break;
                    case "RecieveType":
                        txtRecieveType.Text = SubstituteValue;
                        break;
                    case "CorrespondentCategory":
                        txtCorrespondentCategory.Text = SubstituteValue;
                        break;
                    case "SubquestionsIndex":
                        txtSubquestion.Text = SubstituteValue;
                        break;
                    case "RecieveSign":
                        txtReceiveSign.Text = SubstituteValue;
                        break;
                    case "CorrespondentSocialStatus":
                        txtCorrespondentSocialStatus.Text = SubstituteValue;
                        break;

                        //case "Executant":
                        //    if (txtMessageExecutant.Text.Length < 1)
                        //        txtMessageExecutant.Text = SubstituteValue;
                        //    else
                        //        txtMessageExecutant.Text += "," + SubstituteValue;
                        //    break;
                }
            }
            IsSubstitute = false;
            SubstituteValue = null;
        }
    }
}
