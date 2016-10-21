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
                this.Text = "Редактировать текущую запись";
                item = GetSingleItem(IdEdit);

                txtDateWorking.Text = item.DateWorking;
                txtExecutor.Text = item.Executor;
                txtWorkingNote.Text = item.WorkingNote;
                txtControlState.Text = item.ControlState;
                txtWorkingDate.Text = item.WorkingDate;
                txtCitizenData.Text = item.CitizenData;
                txtDateChecked.Text = item.DateChecked;
                txtWorkerChecked.Text = item.WorkerChecked;
                txtAgreed.Text = item.Agreed;
                txtReviewResult.Text = item.ReviewResult;
                txtController.Text = item.Controller;
                txtCase.Text = item.Case;
                txtVolume.Text = item.Volume;
                txtPagesCount.Text = item.PagesCount;
                txtFund.Text = item.Fund;
                txtReview.Text = item.Review;
                txtPagesCount.Text = item.PagesCount;
                txtCaseSecond.Text = item.CaseSecond;
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
            DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// заполнить элемент указанными значениями
        /// </summary>
        private void FillItemData()
        {
            item.DateWorking = txtDateWorking.Text;
            item.Executor = txtExecutor.Text;
            item.WorkingNote = txtWorkingNote.Text;
            item.ControlState = txtControlState.Text;
            item.WorkingDate = txtWorkingDate.Text;
            item.CitizenData = txtCitizenData.Text;
            item.DateChecked = txtDateChecked.Text;
            item.WorkerChecked = txtWorkerChecked.Text;
            item.Agreed = txtAgreed.Text;
            item.ReviewResult = txtReviewResult.Text;
            item.Controller = txtController.Text;
            item.Case = txtCase.Text;
            item.Volume = txtVolume.Text;
            item.PagesCount = txtPagesCount.Text;
            item.Fund = txtFund.Text;
            item.Review = txtReview.Text;
            item.CaseSecond = txtCaseSecond.Text;
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
                    CurrentReferenceName = "Решения";
                    break;
                //case "Organization":
                //    CurrentReference = "Organizations";
                //    CurrentReferenceName = "Организации";
                //    break;
                //case "Executant":
                //    CurrentReference = "Executants";
                //    CurrentReferenceName = "Исполнители";
                //    break;
                //case "Summary":
                //    CurrentReference = "Summarys";
                //    CurrentReferenceName = "Краткое содержание";
                //    break;
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
                    //case "Organization":
                    //    txtMessageOrganization.Text = SubstituteValue;
                    //    break;
                    //case "Executant":
                    //    if (txtMessageExecutant.Text.Length < 1)
                    //        txtMessageExecutant.Text = SubstituteValue;
                    //    else
                    //        txtMessageExecutant.Text += "," + SubstituteValue;
                    //    break;
                    //case "Summary":
                    //    txtMessageSummary.Text = SubstituteValue;
                    //    break;
                }
            }
            IsSubstitute = false;
            SubstituteValue = null;
        }
    }
}
