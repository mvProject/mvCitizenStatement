using System;
using System.Drawing;
using mvIniSettings;
using System.Windows.Forms;

namespace mvCitizenStatement
{
    /// <summary>
    /// Класс для работы с настройками программы и внутренними переменными
    /// </summary>
    public static class mvSettings
    {
        /// <summary>
        /// Переменная хранящая название таблицы открываемой при старте
        /// </summary>
        public static string WorkingModeStart = "Входящие";
        /// <summary>
        /// Переменная хранящая название таблицы открываемой при старте
        /// </summary>
        public static string WorkingMode;
        /// <summary>
        /// Переменная хранящая код режима работы
        /// </summary>
        public static int WorkingModeIndex = 0;
        /// <summary>
        /// Переменная хранящая имя текущей таблицы
        /// </summary>
        public static string CurrentReference;
        /// <summary>
        /// Переменная хранящая название текущей таблицы
        /// </summary>
        public static string CurrentReferenceName;
        /// <summary>
        /// Переменная указывающая статус редактирования (true - если в режиме редактирования)
        /// </summary>
        public static bool IsEdit = false;
        /// <summary>
        /// Переменная указывающая статус подстановки (true - если в режиме подстановки)
        /// </summary>
        public static bool IsSubstitute = false;
        /// <summary>
        /// Переменная хранящая значение для подстановки
        /// </summary>
        public static string SubstituteValue;
        /// <summary>
        /// Переменная хранящая ID редактируемого элемента
        /// </summary>
        public static int IdEdit;
        /// <summary>
        /// Переменная хранящая начальную дату для журнала
        /// </summary>
        public static DateTime startPeriod = DateTime.Now;
        /// <summary>
        /// Переменная хранящая конечную дату для журнала
        /// </summary>
        public static DateTime endPeriod = DateTime.Now;



        #region Настройки программы Общие
        /// <summary>
        /// Переменная хранящая название предприятия
        /// </summary>
        public static string OrganisationName = "OrganisationName";
        /// <summary>
        /// Переменная хранящая название отдела
        /// </summary>
        public static string DepartmentName = "DepartmentName";
        #endregion
        #region Настройки программы Каталоги
        /// <summary>
        /// Переменная хранящая каталог с базами данных
        /// </summary>
        public static string DatabaseDir = Application.StartupPath + "\\Database\\";
        /// <summary>
        /// Переменная хранящая с шаблонами для отчетов
        /// </summary>
        public static string TemplateDir = Application.StartupPath + "\\Templates\\";
        /// <summary>
        /// Переменная хранящая созданные отчеты
        /// </summary>
        public static string ReportDir = Application.StartupPath + "\\Reports\\";
        /// <summary>
        /// Переменная хранящая файлы для импорта в базу
        /// </summary>
        public static string ImportDir = Application.StartupPath + "\\Import\\";
        #endregion
        #region Настройки программы Лицевая сторона
        public static string Id = "Ид";
        public static string CitizenAddress = "Адреса";
        public static string CitizenName = "Кореспондент";
        public static string CitizenPhone = "Телефон";
        public static string CitizenEmail = "Електронна адреса";
        public static string TreatmentType = "Тип звернення";
        public static string CorrespondentType = "Тип заявника";
        public static string CorrespondentSocialStatus = "Соціальний стан заявника";
        public static string ControlDate = "Контроль";
        public static string Summary = "Короткий зміст";
        public static string ReceivedDate = "Дата отримання";
        public static string IndexReg = "Реєстраційний індекс";
        public static string RecievedFrom = "Звідки отримано";
        public static string SendingDate = "Дата надіслання";
        public static string IndexDoc = "Індекс документа";
        public static string RecieveType = "Тип отримання";
        public static string RecieveSign = "Ознака надходження";
        public static string TreatmentsBefore = "Попередні звернення";
        public static string Question = "Питання";
        public static string Subquestion = "Підпитання";
        public static string Resolution = "Резолюція";
        public static string ResolutionAuthor = "Автор резолюції";
        public static string CorrespondentCategory = "Категорія";
        public static string ExecuteDaysCount = "Кількість днів"; 

        public static bool IdView = true;
        public static bool SummaryView = true;
        public static bool CitizenAddressView = true;
        public static bool CitizenNameView = true;
        public static bool CitizenPhoneView = true;
        public static bool CitizenEmailView = true;
        public static bool TreatmentTypeView = true;
        public static bool CorrespondentTypeView = true;
        public static bool CorrespondentSocialStatusView = true;
        public static bool ControlDateView = true;
        public static bool ReceivedDateView = true;
        public static bool IndexRegView = true;
        public static bool RecievedFromView = true;
        public static bool SendingDateView = true;
        public static bool IndexDocView = true;
        public static bool RecieveTypeView = true;
        public static bool RecieveSignView = true;
        public static bool TreatmentsBeforeView = true;
        public static bool QuestionView = true;
        public static bool SubquestionView = true;
        public static bool ResolutionView = true;
        public static bool ResolutionAuthorView = true;
        public static bool CorrespondentCategoryView = true;
        public static bool ExecuteDaysCountView = true;
        
        public static Color ControlColor;
        public static string strControlColor = "-4465841";
        #endregion
        #region Настройки программы Обратная сторона
        public static bool DateWorkingView = true;
        public static bool ExecutorView = true;
        public static bool WorkingNoteView = true;
        public static bool ControlStateView = true;
        public static bool DateCheckedView = true;
        public static bool WorkerCheckedView = true;
        public static bool WorkingDateView = true;
        public static bool CitizenDataView = true;
        public static bool AgreedView = true;
        public static bool ReviewResultView = true;
        public static bool ControllerView = true;
        public static bool CaseView = true;
        public static bool VolumeView = true;
        public static bool PagesCountView = true;

        public static string DateWorking = "Дата виконання";
        public static string Executor = "Виконавець";
        public static string WorkingNote = "Записи";
        public static string ControlState = "Контрольні відмітки";
        public static string DateChecked = "Перевірено на місці";
        public static string WorkerChecked = "працівником служби";
        public static string WorkingDate = "Дата, індекс, виконання";
        public static string CitizenData = "Адресат";
        public static string Agreed = "Вирішено";
        public static string ReviewResult = "Результати розгляду питань";
        public static string Controller = "З контролю зняв";
        public static string Case = "Справа";
        public static string Volume = "Том";
        public static string PagesCount = "Аркушів";
        #endregion

        /// <summary>
        /// Сохранение настроек в файл
        /// </summary>
        public static void SaveSettings()
        {
            var ini = new IniFile(Application.StartupPath + "\\mvCitizenStatement.ini");
            #region Сохранение настроек "Общие" 
            ini.IniWriteValue("Main", "OrganisationName", OrganisationName);
            ini.IniWriteValue("Main", "DepartmentName", DepartmentName);
            ini.IniWriteValue("Main", "WorkingModeStart", WorkingModeStart);
            ini.IniWriteValue("Main", "WorkingModeIndex", WorkingModeIndex.ToString());
            #endregion
            #region Сохранение настроек "Каталоги"
            ini.IniWriteValue("Directory", "DatabaseDir", DatabaseDir);
            ini.IniWriteValue("Directory", "TemplateDir", TemplateDir);
            ini.IniWriteValue("Directory", "ReportDir", ReportDir);
            ini.IniWriteValue("Directory", "ImportDir", ImportDir);
            #endregion
            #region Сохранение настроек отображения полей в Лицевая сторона

            ini.IniWriteValue("Frontside", "Id", Id);
            ini.IniWriteValue("Frontside", "IdView", IdView.ToString());

            ini.IniWriteValue("Frontside", "Summary", Summary);
            ini.IniWriteValue("Frontside", "SummaryView", SummaryView.ToString());

            ini.IniWriteValue("Frontside", "CitizenAddress", CitizenAddress);
            ini.IniWriteValue("Frontside", "CitizenAddressView", CitizenAddressView.ToString());

            ini.IniWriteValue("Frontside", "CitizenName", CitizenName);
            ini.IniWriteValue("Frontside", "CitizenNameView", CitizenNameView.ToString());

            ini.IniWriteValue("Frontside", "CitizenPhone", CitizenPhone);
            ini.IniWriteValue("Frontside", "CitizenPhoneView", CitizenPhoneView.ToString());

            ini.IniWriteValue("Frontside", "CitizenEmail", CitizenEmail);
            ini.IniWriteValue("Frontside", "CitizenEmailView", CitizenEmailView.ToString());

            ini.IniWriteValue("Frontside", "TreatmentType", TreatmentType);
            ini.IniWriteValue("Frontside", "TreatmentTypeView", TreatmentTypeView.ToString());

            ini.IniWriteValue("Frontside", "CorrespondentType", CorrespondentType);
            ini.IniWriteValue("Frontside", "CorrespondentTypeView", CorrespondentTypeView.ToString());

            ini.IniWriteValue("Frontside", "CorrespondentSocialStatus", CorrespondentSocialStatus);
            ini.IniWriteValue("Frontside", "CorrespondentSocialStatusView", CorrespondentSocialStatusView.ToString());

            ini.IniWriteValue("Frontside", "ControlDate", ControlDate);
            ini.IniWriteValue("Frontside", "ControlDateView", ControlDateView.ToString());

            ini.IniWriteValue("Frontside", "ReceivedDate", ReceivedDate);
            ini.IniWriteValue("Frontside", "ReceivedDateView", ReceivedDateView.ToString());

            ini.IniWriteValue("Frontside", "IndexReg", IndexReg);
            ini.IniWriteValue("Frontside", "IndexRegView", IndexRegView.ToString());

            ini.IniWriteValue("Frontside", "RecievedFrom", RecievedFrom);
            ini.IniWriteValue("Frontside", "RecievedFromView", RecievedFromView.ToString());

            ini.IniWriteValue("Frontside", "RecieveSign", RecieveSign);
            ini.IniWriteValue("Frontside", "RecieveSignView", RecieveSignView.ToString());

            ini.IniWriteValue("Frontside", "SendingDate", SendingDate);
            ini.IniWriteValue("Frontside", "SendingDateView", SendingDateView.ToString());

            ini.IniWriteValue("Frontside", "IndexDoc", IndexDoc);
            ini.IniWriteValue("Frontside", "IndexDocView", IndexDocView.ToString());

            ini.IniWriteValue("Frontside", "RecieveType", RecieveType);
            ini.IniWriteValue("Frontside", "RecieveTypeView", RecieveTypeView.ToString());

            ini.IniWriteValue("Frontside", "TreatmentsBefore", TreatmentsBefore);
            ini.IniWriteValue("Frontside", "TreatmentsBeforeView", TreatmentsBeforeView.ToString());

            ini.IniWriteValue("Frontside", "Question", Question);
            ini.IniWriteValue("Frontside", "QuestionView", QuestionView.ToString());

            ini.IniWriteValue("Frontside", "Subquestion", Subquestion);
            ini.IniWriteValue("Frontside", "SubquestionView", SubquestionView.ToString());

            ini.IniWriteValue("Frontside", "Resolution", Resolution);
            ini.IniWriteValue("Frontside", "ResolutionView", ResolutionView.ToString());

            ini.IniWriteValue("Frontside", "ResolutionAuthor", ResolutionAuthor);
            ini.IniWriteValue("Frontside", "ResolutionAuthorView", ResolutionAuthorView.ToString());

            ini.IniWriteValue("Frontside", "CorrespondentCategory", CorrespondentCategory);
            ini.IniWriteValue("Frontside", "CorrespondentCategoryView", CorrespondentCategoryView.ToString());

            ini.IniWriteValue("Frontside", "ExecuteDaysCount", ExecuteDaysCount);
            ini.IniWriteValue("Frontside", "ExecuteDaysCountView", ExecuteDaysCountView.ToString());
            #endregion
            #region Сохранение настроек отображения полей в Обратная сторона
            ini.IniWriteValue("Backside", "DateWorking", DateWorking);
            ini.IniWriteValue("Backside", "DateWorkingView", DateWorkingView.ToString());

            ini.IniWriteValue("Backside", "Executor", Executor);
            ini.IniWriteValue("Backside", "ExecutorView", ExecutorView.ToString());

            ini.IniWriteValue("Backside", "WorkingNote", WorkingNote);
            ini.IniWriteValue("Backside", "WorkingNoteView", WorkingNoteView.ToString());

            ini.IniWriteValue("Backside", "ControlState", ControlState);
            ini.IniWriteValue("Backside", "ControlStateView", ControlStateView.ToString());

            ini.IniWriteValue("Backside", "DateChecked", DateChecked);
            ini.IniWriteValue("Backside", "DateCheckedView", DateCheckedView.ToString());

            ini.IniWriteValue("Backside", "WorkerChecked", WorkerChecked);
            ini.IniWriteValue("Backside", "WorkerCheckedView", WorkerCheckedView.ToString());

            ini.IniWriteValue("Backside", "WorkingDate", WorkingDate);
            ini.IniWriteValue("Backside", "WorkingDateView", WorkingDateView.ToString());

            ini.IniWriteValue("Backside", "CitizenData", CitizenData);
            ini.IniWriteValue("Backside", "CitizenDataView", CitizenDataView.ToString());

            ini.IniWriteValue("Backside", "Agreed", Agreed);
            ini.IniWriteValue("Backside", "AgreedView", AgreedView.ToString());

            ini.IniWriteValue("Backside", "ReviewResult", ReviewResult);
            ini.IniWriteValue("Backside", "ReviewResultView", ReviewResultView.ToString());

            ini.IniWriteValue("Backside", "Controller", Controller);
            ini.IniWriteValue("Backside", "ControllerView", ControllerView.ToString());

            ini.IniWriteValue("Backside", "Case", Case);
            ini.IniWriteValue("Backside", "CaseView", CaseView.ToString());

            ini.IniWriteValue("Backside", "Volume", Volume);
            ini.IniWriteValue("Backside", "VolumeView", VolumeView.ToString());
            
            ini.IniWriteValue("Backside", "PagesCount", PagesCount);
            ini.IniWriteValue("Backside", "PagesCountView", PagesCountView.ToString());

            ini.IniWriteValue("View", "ControlColor", strControlColor);
            #endregion

        }
        /// <summary>
        /// Загрузка настроек из файла
        /// </summary>
        public static void LoadSettings()
        {
            try
            {
                var ini = new IniFile(Application.StartupPath + "\\mvCitizenStatement.ini");
                #region Загрузка настроек "Общие"
                OrganisationName = ini.IniReadValue("Main", "OrganisationName");
                DepartmentName = ini.IniReadValue("Main", "DepartmentName");
                WorkingModeStart = ini.IniReadValue("Main", "WorkingModeStart");
                WorkingModeIndex = Int32.Parse(ini.IniReadValue("Main", "WorkingModeIndex"));
                #endregion
                #region Загрузка настроек "Каталоги"
                DatabaseDir = ini.IniReadValue("Directory", "DatabaseDir");
                TemplateDir = ini.IniReadValue("Directory", "TemplateDir");
                ReportDir = ini.IniReadValue("Directory", "ReportDir");
                ImportDir = ini.IniReadValue("Directory", "ImportDir");
                #endregion
                #region Загрузка настроек отображения полей в Лицевая сторона
                Id = ini.IniReadValue("Frontside", "Id");
                IdView = bool.Parse(ini.IniReadValue("Frontside", "IdView"));

                Summary = ini.IniReadValue("Frontside", "Summary");
                SummaryView = bool.Parse(ini.IniReadValue("Frontside", "SummaryView"));

                CorrespondentSocialStatus = ini.IniReadValue("Frontside", "CorrespondentSocialStatus");
                CorrespondentSocialStatusView = bool.Parse(ini.IniReadValue("Frontside", "CorrespondentSocialStatusView"));

                RecieveSign = ini.IniReadValue("Frontside", "RecieveSign");
                RecieveSignView = bool.Parse(ini.IniReadValue("Frontside", "RecieveSignView"));

                CitizenAddress = ini.IniReadValue("Frontside", "CitizenAddress");
                CitizenAddressView = bool.Parse(ini.IniReadValue("Frontside", "CitizenAddressView"));

                CitizenName = ini.IniReadValue("Frontside", "CitizenName");
                CitizenNameView = bool.Parse(ini.IniReadValue("Frontside", "CitizenNameView"));

                CitizenPhone = ini.IniReadValue("Frontside", "CitizenPhone");
                CitizenPhoneView = bool.Parse(ini.IniReadValue("Frontside", "CitizenPhoneView"));

                CitizenEmail = ini.IniReadValue("Frontside", "CitizenEmail");
                CitizenEmailView = bool.Parse(ini.IniReadValue("Frontside", "CitizenEmailView"));

                TreatmentType = ini.IniReadValue("Frontside", "TreatmentType");
                CorrespondentType = ini.IniReadValue("Frontside", "CorrespondentType");
                ControlDate = ini.IniReadValue("Frontside", "ControlDate");
                IndexReg = ini.IniReadValue("Frontside", "ReceivedDate");
                IndexReg = ini.IniReadValue("Frontside", "IndexReg");
                RecievedFrom = ini.IniReadValue("Frontside", "RecievedFrom");
                SendingDate = ini.IniReadValue("Frontside", "SendingDate");
                IndexDoc = ini.IniReadValue("Frontside", "IndexDoc");
                RecieveType = ini.IniReadValue("Frontside", "RecieveType");
                TreatmentsBefore = ini.IniReadValue("Frontside", "TreatmentsBefore");
                Question = ini.IniReadValue("Frontside", "Question");
                Subquestion = ini.IniReadValue("Frontside", "Subquestion");
                Resolution = ini.IniReadValue("Frontside", "Resolution");
                ResolutionAuthor = ini.IniReadValue("Frontside", "ResolutionAuthor");
                CorrespondentCategory = ini.IniReadValue("Frontside", "CorrespondentCategory");
                ExecuteDaysCount = ini.IniReadValue("Frontside", "ExecuteDaysCount");


                TreatmentTypeView = bool.Parse(ini.IniReadValue("Frontside", "TreatmentTypeView"));
                CorrespondentTypeView = bool.Parse(ini.IniReadValue("Frontside", "CorrespondentTypeView"));
                ControlDateView = bool.Parse(ini.IniReadValue("Frontside", "ControlDateView"));
                ReceivedDateView = bool.Parse(ini.IniReadValue("Frontside", "ReceivedDateView"));
                IndexRegView = bool.Parse(ini.IniReadValue("Frontside", "IndexRegView"));
                RecievedFromView = bool.Parse(ini.IniReadValue("Frontside", "RecievedFromView"));
                SendingDateView = bool.Parse(ini.IniReadValue("Frontside", "SendingDateView"));
                IndexDocView = bool.Parse(ini.IniReadValue("Frontside", "IndexDocView"));
                RecieveTypeView = bool.Parse(ini.IniReadValue("Frontside", "RecieveTypeView"));
                TreatmentsBeforeView = bool.Parse(ini.IniReadValue("Frontside", "TreatmentsBeforeView"));
                QuestionView = bool.Parse(ini.IniReadValue("Frontside", "QuestionView"));
                SubquestionView = bool.Parse(ini.IniReadValue("Frontside", "SubquestionView"));
                ResolutionView = bool.Parse(ini.IniReadValue("Frontside", "ResolutionView"));
                ResolutionAuthorView = bool.Parse(ini.IniReadValue("Frontside", "ResolutionAuthorView"));
                CorrespondentCategoryView = bool.Parse(ini.IniReadValue("Frontside", "CorrespondentCategoryView"));
                ExecuteDaysCountView = bool.Parse(ini.IniReadValue("Frontside", "ExecuteDaysCountView"));

                #endregion
                #region Загрузка настроек отображения полей в Обратная сторона
                strControlColor = ini.IniReadValue("View", "ControlColor");

                DateWorkingView = bool.Parse(ini.IniReadValue("Backside", "DateWorkingView"));
                ExecutorView = bool.Parse(ini.IniReadValue("Backside", "ExecutorView"));
                WorkingNoteView = bool.Parse(ini.IniReadValue("Backside", "WorkingNoteView"));
                ControlStateView = bool.Parse(ini.IniReadValue("Backside", "ControlStateView"));
                DateCheckedView = bool.Parse(ini.IniReadValue("Backside", "DateCheckedView"));
                WorkerCheckedView = bool.Parse(ini.IniReadValue("Backside", "WorkerCheckedView"));
                WorkingDateView = bool.Parse(ini.IniReadValue("Backside", "WorkingDateView"));
                CitizenDataView = bool.Parse(ini.IniReadValue("Backside", "CitizenDataView"));
                AgreedView = bool.Parse(ini.IniReadValue("Backside", "AgreedView"));
                ReviewResultView = bool.Parse(ini.IniReadValue("Backside", "ReviewResultView"));
                ControllerView = bool.Parse(ini.IniReadValue("Backside", "ControllerView"));
                CaseView = bool.Parse(ini.IniReadValue("Backside", "CaseView"));
                VolumeView = bool.Parse(ini.IniReadValue("Backside", "VolumeView"));
                PagesCountView = bool.Parse(ini.IniReadValue("Backside", "PagesCountView"));

                DateWorking = ini.IniReadValue("Backside", "DateWorking");
                Executor = ini.IniReadValue("Backside", "Executor");
                WorkingNote = ini.IniReadValue("Backside", "WorkingNote");
                ControlState = ini.IniReadValue("Backside", "ControlState");
                DateChecked = ini.IniReadValue("Backside", "DateChecked");
                WorkerChecked = ini.IniReadValue("Backside", "WorkerChecked");
                WorkingDate = ini.IniReadValue("Backside", "WorkingDate");
                CitizenData = ini.IniReadValue("Backside", "CitizenData");
                Agreed = ini.IniReadValue("Backside", "Agreed");
                ReviewResult = ini.IniReadValue("Backside", "ReviewResult");
                Controller = ini.IniReadValue("Backside", "Controller");
                Case = ini.IniReadValue("Backside", "Case");
                Volume = ini.IniReadValue("Backside", "Volume");
                PagesCount = ini.IniReadValue("Backside", "PagesCount");
                #endregion
            }
            catch
            {
                MessageBox.Show("Файл настроек не найден! Будут использоватья настройки по-умолчанию");
            }
            ControlColor = Color.FromArgb(Int32.Parse(strControlColor));
        }
    }
}
