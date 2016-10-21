using System;
using System.Windows.Forms;
using static mvCitizenStatement.DataModel;
using static mvCitizenStatement.mvSettings;

namespace mvCitizenStatement
{
    /// <summary>
    /// Окно создания / редактирования элемента (дополнительные справочники)
    /// </summary>
    public partial class frmAddEditReferences : Form
    {
        References item;
        public frmAddEditReferences()
        {
            InitializeComponent();
            // если находится в режиме редактирования
            if (IsEdit)
            {
                //получить значение выбранного элемента
                switch (CurrentReference)
                {
                    case "Executants":
                        item = GetSingleItem<Executants>(IdEdit);
                        break;
                    case "Organizations":
                        item = GetSingleItem<Organizations>(IdEdit);
                        break;
                    case "DocumentTypes":
                        item = GetSingleItem<DocumentTypes>(IdEdit);
                        break;
                    case "Resolutions":
                        item = GetSingleItem<Resolutions>(IdEdit);
                        break;
                    case "Summarys":
                        item = GetSingleItem<Summarys>(IdEdit);
                        break;
                    case "TreatmentTypes":
                        item = GetSingleItem<TreatmentTypes>(IdEdit);
                        break;
                    case "CorrespondentTypes":
                        item = GetSingleItem<CorrespondentTypes>(IdEdit);
                        break;
                    case "RecieveTypes":
                        item = GetSingleItem<RecieveTypes>(IdEdit);
                        break;
                    case "CorrespondentCategories":
                        item = GetSingleItem<CorrespondentCategories>(IdEdit);
                        break;
                    case "SubquestionsIndexes":
                        item = GetSingleItem<SubquestionsIndexes>(IdEdit);
                        break;
                    case "Agreeds":
                        item = GetSingleItem<Agreeds>(IdEdit);
                        break;
                }
                txtName.Text = item.ItemName;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // В зависмиости от типа режима создать новый элемент либо обновить существующий
            switch (CurrentReference)
            {
                case "Executants":
                    if (IsEdit)
                    {
                        item.ItemName = txtName.Text;
                        UpdateItem<Executants>((Executants)item);
                    }
                    else
                    {
                        AddReferencesItem<Executants>(txtName.Text);
                    }
                    break;
                case "Organizations":
                    if (IsEdit)
                    {
                        item.ItemName = txtName.Text;
                        UpdateItem<Organizations>((Organizations)item);
                    }
                    else
                    {
                        AddReferencesItem<Organizations>(txtName.Text);
                    }
                    break;
                case "DocumentTypes":
                    if (IsEdit)
                    {
                        item.ItemName = txtName.Text;
                        UpdateItem<DocumentTypes>((DocumentTypes)item);
                    }
                    else
                    {
                        AddReferencesItem<DocumentTypes>(txtName.Text);
                    }
                    break;
                case "Resolutions":
                    if (IsEdit)
                    {
                        item.ItemName = txtName.Text;
                        UpdateItem<Resolutions>((Resolutions)item);
                    }
                    else
                    {
                        AddReferencesItem<Resolutions>(txtName.Text);
                    }
                    break;
                case "Summarys":
                    if (IsEdit)
                    {
                        item.ItemName = txtName.Text;
                        UpdateItem<Summarys>((Summarys)item);
                    }
                    else
                    {
                        AddReferencesItem<Summarys>(txtName.Text);
                    }
                    break;
                case "TreatmentTypes":
                    if (IsEdit)
                    {
                        item.ItemName = txtName.Text;
                        UpdateItem<TreatmentTypes>((TreatmentTypes)item);
                    }
                    else
                    {
                        AddReferencesItem<TreatmentTypes>(txtName.Text);
                    }
                    break;
                case "CorrespondentTypes":
                    if (IsEdit)
                    {
                        item.ItemName = txtName.Text;
                        UpdateItem<CorrespondentTypes>((CorrespondentTypes)item);
                    }
                    else
                    {
                        AddReferencesItem<CorrespondentTypes>(txtName.Text);
                    }
                    break;
                case "RecieveTypes":
                    if (IsEdit)
                    {
                        item.ItemName = txtName.Text;
                        UpdateItem<RecieveTypes>((RecieveTypes)item);
                    }
                    else
                    {
                        AddReferencesItem<RecieveTypes>(txtName.Text);
                    }
                    break;
                case "CorrespondentCategories":
                    if (IsEdit)
                    {
                        item.ItemName = txtName.Text;
                        UpdateItem<CorrespondentCategories>((CorrespondentCategories)item);
                    }
                    else
                    {
                        AddReferencesItem<CorrespondentCategories>(txtName.Text);
                    }
                    break;
                case "SubquestionsIndexes":
                    if (IsEdit)
                    {
                        item.ItemName = txtName.Text;
                        UpdateItem<SubquestionsIndexes>((SubquestionsIndexes)item);
                    }
                    else
                    {
                        AddReferencesItem<SubquestionsIndexes>(txtName.Text);
                    }
                    break;
                case "Agreeds":
                    if (IsEdit)
                    {
                        item.ItemName = txtName.Text;
                        UpdateItem<Agreeds>((Agreeds)item);
                    }
                    else
                    {
                        AddReferencesItem<Agreeds>(txtName.Text);
                    }
                    break;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
