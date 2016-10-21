using System;
using System.Windows.Forms;
using static mvCitizenStatement.mvSettings;
using static mvCitizenStatement.DataModel;
using System.Collections.Generic;

namespace mvCitizenStatement
{

    /// <summary>
    /// Окно отображающее информацию из дополнительных справочников
    /// с возможностью добавления / редактирования / удаления и поиска
    /// </summary>
    public partial class frmReferencesDetail : Form
    {
        public frmReferencesDetail()
        {
            InitializeComponent();
            this.Text = CurrentReferenceName;
            selectCurrentReference(CurrentReference);
            ShowRecordCount();
        }
        /// <summary>
        /// Добавление нового элемента в текущий справочник
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditReferences frmAddEditReferences = new frmAddEditReferences();
            if (frmAddEditReferences.ShowDialog() == DialogResult.OK)
            {
                selectCurrentReference(CurrentReference);
            }
        }
        /// <summary>
        /// Редактирование выбранного элемента
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditReferenceItem();
        }
        /// <summary>
        /// Редактирование выбранного элемента
        /// </summary>
        private void EditReferenceItem()
        {
            IsEdit = true;
            IdEdit = Int32.Parse(dgv.CurrentRow.Cells[0].Value.ToString());
            int rowId = dgv.FirstDisplayedScrollingRowIndex;
            int id = dgv.CurrentCell.RowIndex;
            frmAddEditReferences frmAddEditReferences = new frmAddEditReferences();
            if (frmAddEditReferences.ShowDialog() == DialogResult.OK)
            {
                selectCurrentReference(CurrentReference);
            }
            dgv.FirstDisplayedScrollingRowIndex = rowId;
            dgv.CurrentCell = dgv.Rows[id].Cells[1];
            IsEdit = false;
        }
        /// <summary>
        /// Удаление выбранного элемента
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                var id = dgv.CurrentRow.Cells[0].Value.ToString();
                switch (CurrentReference)
                {
                    
                    case "Executants":
                        DeleteItem<Executants>(Int32.Parse(id));
                        break;
                    case "Organizations":
                        DeleteItem<Organizations>(Int32.Parse(id));
                        break;
                    case "DocumentTypes":
                        DeleteItem<DocumentTypes>(Int32.Parse(id));
                        break;
                    case "Resolutions":
                        DeleteItem<Resolutions>(Int32.Parse(id));
                        break;
                    case "Summarys":
                        DeleteItem<Summarys>(Int32.Parse(id));
                        break;
                    case "TreatmentTypes":
                        DeleteItem<TreatmentTypes>(Int32.Parse(id));
                        break;
                    case "CorrespondentTypes":
                        DeleteItem<CorrespondentTypes>(Int32.Parse(id));
                        break;
                    case "RecieveTypes":
                        DeleteItem<RecieveTypes>(Int32.Parse(id));
                        break;
                    case "CorrespondentCategories":
                        DeleteItem<CorrespondentCategories>(Int32.Parse(id));
                        break;
                    case "SubquestionsIndexes":
                        DeleteItem<SubquestionsIndexes>(Int32.Parse(id));
                        break;
                    case "Agreeds":
                        DeleteItem<Agreeds>(Int32.Parse(id));
                        break;
                }
                selectCurrentReference(CurrentReference);
            }
        }
        /// <summary>
        /// Очистка поля поиска
        /// </summary>
        private void btnClearFind_Click(object sender, EventArgs e)
        {
            txtFind.Clear();
        }
        /// <summary>
        /// Поиск записей по названию
        /// </summary>
        private void Find(object sender, EventArgs e)
        {
            FindItem(txtFind.Text);
        }
        /// <summary>
        /// Поиск по справочнику с отсеиванием результата по мере набора 
        /// </summary>
        /// <param name="source">Текстовое выражение для поиска</param>
        private void FindItem(string source)
        {
            if (txtFind.Text.Length > 0)
            {
                switch (CurrentReference)
                {
                    case "Executants":
                        dgv.DataSource = FindItems<Executants>(source);
                        break;
                    case "Organizations":
                        dgv.DataSource = FindItems<Organizations>(source);
                        break;
                    case "DocumentTypes":
                        dgv.DataSource = FindItems<DocumentTypes>(source);
                        break;
                    case "Resolutions":
                        dgv.DataSource = FindItems<Resolutions>(source);
                        break;
                    case "Summarys":
                        dgv.DataSource = FindItems<Summarys>(source);
                        break;
                    case "TreatmentTypes":
                        dgv.DataSource = FindItems<TreatmentTypes>(source);
                        break;
                    case "CorrespondentTypes":
                        dgv.DataSource = FindItems<CorrespondentTypes>(source);
                        break;
                    case "RecieveTypes":
                        dgv.DataSource = FindItems<RecieveTypes>(source);
                        break;
                    case "CorrespondentCategories":
                        dgv.DataSource = FindItems<CorrespondentCategories>(source);
                        break;
                    case "SubquestionsIndexes":
                        dgv.DataSource = FindItems<SubquestionsIndexes>(source);
                        break;
                    case "Agreeds":
                        dgv.DataSource = FindItems<Agreeds>(source);
                        break;
                }
                ShowRecordCount();
            }
            else
            {
                selectCurrentReference(CurrentReference);
            }
            CustomizeDgvReferences();
        }
        /// <summary>
        /// Показ в DataGrid содержимого выбранного справочника
        /// </summary>
        /// <param name="value">Имя выбраного справочника</param>
        private void selectCurrentReference(string value)
        {
            switch (value)
            {
                case "Executants":
                    CurrentReference = "Executants";
                    dgv.DataSource = ShowItemsData<Executants>();
                    break;
                case "Organizations":
                    CurrentReference = "Organizations";
                    dgv.DataSource = ShowItemsData<Organizations>();
                    break;
                case "DocumentTypes":
                    CurrentReference = "DocumentTypes";
                    dgv.DataSource = ShowItemsData<DocumentTypes>();
                    break;
                case "Resolutions":
                    CurrentReference = "Resolutions";
                    dgv.DataSource = ShowItemsData<Resolutions>();
                    break;
                case "Summarys":
                    CurrentReference = "Summarys";
                    dgv.DataSource = ShowItemsData<Summarys>();
                    break;
                case "TreatmentTypes":
                    CurrentReference = "TreatmentTypes";
                    dgv.DataSource = ShowItemsData<TreatmentTypes>();
                    break;
                case "CorrespondentTypes":
                    CurrentReference = "CorrespondentTypes";
                    dgv.DataSource = ShowItemsData<CorrespondentTypes>();
                    break;
                case "RecieveTypes":
                    CurrentReference = "RecieveTypes";
                    dgv.DataSource = ShowItemsData<RecieveTypes>();
                    break;
                case "CorrespondentCategories":
                    CurrentReference = "CorrespondentCategories";
                    dgv.DataSource = ShowItemsData<CorrespondentCategories>();
                    break;
                case "SubquestionsIndexes":
                    CurrentReference = "SubquestionsIndexes";
                    dgv.DataSource = ShowItemsData<SubquestionsIndexes>();
                    break;
                case "Agreeds":
                    CurrentReference = "Agreeds";
                    dgv.DataSource = ShowItemsData<Agreeds>();
                    break;
            }
            CustomizeDgvReferences();
            ShowRecordCount();
        }
        /// <summary>
        /// Настройка внешнего вида Datagrid для доролнительных справочников
        /// </summary>
        private void CustomizeDgvReferences()
        {
            if (dgv.DataSource != null)
            {
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "Наименование";
                dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        /// <summary>
        /// Если установлен режим "Подстановки" то по дабл-клику выбираетяс значение для подстановки
        /// если нет - то открывается форма для редактирования элемента
        /// </summary>
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsSubstitute)
            {
                EditReferenceItem();
            }
            else
            {
                SubstituteValue = dgv.CurrentRow.Cells[1].Value.ToString();
                DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// Показать количество отображаемы записей
        /// </summary>
        private void ShowRecordCount()
        {
            txtRecordCount.Text = dgv.RowCount.ToString();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.xlsx";
            ofd.Filter = "Excel 2007(*.xlsx)|*.xlsx";
            ofd.Title = "Выберите документ для загрузки данных";
            ofd.InitialDirectory = ImportDir;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.Text = CurrentReferenceName + "  -  Подождите,происходит импорт данных!";
                switch (CurrentReference)
                {
                    case "Executants":
                        ImportReferenceItems<Executants>(ofd.FileName);
                        break;
                    case "Organizations":
                        ImportReferenceItems<Organizations>(ofd.FileName);
                        break;
                    case "DocumentTypes":
                        ImportReferenceItems<DocumentTypes>(ofd.FileName);
                        break;
                    case "Resolutions":
                        ImportReferenceItems<Resolutions>(ofd.FileName);
                        break;
                    case "Summarys":
                        ImportReferenceItems<Summarys>(ofd.FileName);
                        break;
                    case "TreatmentTypes":
                        ImportReferenceItems<TreatmentTypes>(ofd.FileName);
                        break;
                    case "CorrespondentTypes":
                        ImportReferenceItems<CorrespondentTypes>(ofd.FileName);
                        break;
                    case "RecieveTypes":
                        ImportReferenceItems<RecieveTypes>(ofd.FileName);
                        break;
                    case "CorrespondentCategories":
                        ImportReferenceItems<CorrespondentCategories>(ofd.FileName);
                        break;
                    case "SubquestionsIndexes":
                        ImportReferenceItems<SubquestionsIndexes>(ofd.FileName);
                        break;
                    case "Agreeds":
                        ImportReferenceItems<Agreeds>(ofd.FileName);
                        break;
                }
            }
            this.Text = CurrentReferenceName;
            selectCurrentReference(CurrentReference);
            ShowRecordCount();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.xlsx";
            sfd.Filter = "Excel 2007(*.xlsx)|*.xlsx";
            sfd.Title = "Сохранить файл";
            sfd.InitialDirectory = ImportDir;
            sfd.FileName = CurrentReferenceName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.Text = CurrentReferenceName + "  -  Подождите,происходит экспорт данных!";
                switch (CurrentReference)
                {
                    case "Executants":
                        List<Executants> Executants = (List<Executants>)dgv.DataSource;
                        ExportReferenceItems<Executants>(sfd.FileName, Executants);
                        break;
                    case "Organizations":
                        List<Organizations> Organizations = (List<Organizations>)dgv.DataSource;
                        ExportReferenceItems<Organizations>(sfd.FileName, Organizations);
                        break;
                    case "DocumentTypes":
                        List<DocumentTypes> DocumentTypes = (List<DocumentTypes>)dgv.DataSource;
                        ExportReferenceItems<DocumentTypes>(sfd.FileName, DocumentTypes);
                        break;
                    case "Resolutions":
                        List<Resolutions> Resolutions = (List<Resolutions>)dgv.DataSource;
                        ExportReferenceItems<Resolutions>(sfd.FileName, Resolutions);
                        break;
                    case "Summarys":
                        List<Summarys> Summarys = (List<Summarys>)dgv.DataSource;
                        ExportReferenceItems<Summarys>(sfd.FileName, Summarys);
                        break;
                    case "TreatmentTypes":
                        List<TreatmentTypes> TreatmentTypes = (List<TreatmentTypes>)dgv.DataSource;
                        ExportReferenceItems<TreatmentTypes>(sfd.FileName, TreatmentTypes);
                        break;
                    case "CorrespondentTypes":
                        List<CorrespondentTypes> CorrespondentTypes = (List<CorrespondentTypes>)dgv.DataSource;
                        ExportReferenceItems<CorrespondentTypes>(sfd.FileName, CorrespondentTypes);
                        break;
                    case "RecieveTypes":
                        List<RecieveTypes> RecieveTypes = (List<RecieveTypes>)dgv.DataSource;
                        ExportReferenceItems<RecieveTypes>(sfd.FileName, RecieveTypes);
                        break;
                    case "CorrespondentCategories":
                        List<CorrespondentCategories> CorrespondentCategories = (List<CorrespondentCategories>)dgv.DataSource;
                        ExportReferenceItems<CorrespondentCategories>(sfd.FileName, CorrespondentCategories);
                        break;
                    case "SubquestionsIndexes":
                        List<SubquestionsIndexes> SubquestionsIndexes = (List<SubquestionsIndexes>)dgv.DataSource;
                        ExportReferenceItems<SubquestionsIndexes>(sfd.FileName, SubquestionsIndexes);
                        break;
                    case "Agreeds":
                        List<Agreeds> Agreeds = (List<Agreeds>)dgv.DataSource;
                        ExportReferenceItems<Agreeds>(sfd.FileName, Agreeds);
                        break;
                }
                this.Text = CurrentReferenceName;
                MessageBox.Show(string.Format("Файл \n {0} \n сохранен!", sfd.FileName));
            }
        }
    }
}
