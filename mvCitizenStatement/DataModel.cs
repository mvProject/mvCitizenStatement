using OfficeOpenXml;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static mvCitizenStatement.mvSettings;

namespace mvCitizenStatement
{
    /// <summary>
    /// Класс описывающий маодель данных,таблицы,и операции над данными
    /// </summary>
    public static class DataModel
    {
        /// <summary>
        /// внутрення переменная хранящая полный путь к открытой (или только что созданной базе данных)
        /// </summary>
        private static string _filename;

        /// <summary>
        /// Класс описывающий поля для входящего сообщения
        /// </summary>
        public class MessageCitizen
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            //front part
            public string CitizenAddress { get; set; }
            public string CitizenName { get; set; }
            public string TreatmentType { get; set; }
            public string CorrespondentType { get; set; }
            public string ControlDate { get; set; }
            public string ReceivedDate { get; set; }
            public string IndexReg { get; set; }
            public string RecievedFrom { get; set; }
            public string SendingDate { get; set; }
            public string IndexDoc { get; set; }
            public string RecieveType { get; set; }
            public string TreatmentsBefore { get; set; }
            public string Question { get; set; }
            public string Subquestion { get; set; }
            public string Resolution { get; set; }
            public string ResolutionAuthor { get; set; }
            public string CorrespondentCategory { get; set; }
            public string ExecuteDaysCount { get; set; }

            //back part
            public string DateWorking { get; set; }
            public string Executor { get; set; }
            public string WorkingNote { get; set; }
            public string ControlState { get; set; }
            public string DateChecked { get; set; }
            public string WorkerChecked { get; set; }
            public string WorkingDate { get; set; }
            public string CitizenData { get; set; }
            public string Agreed { get; set; }
            public string ReviewResult { get; set; }
            public string Controller { get; set; }
            public string Case { get; set; }
            public string Volume { get; set; }
            public string PagesCount { get; set; }
            public string Fund { get; set; }
            public string Review { get; set; }
            public string CaseSecond { get; set; }
            //[MaxLength(150), NotNull]
            //public string MessageNumberIn { get; set; }
            //public DateTime? MessageDateIn { get; set; }
            //[MaxLength(150)]
            //public string MessageType { get; set; }
            //public string MessageOrganization { get; set; }
            //[MaxLength(150)]
            //public string MessageNumberOut { get; set; }
            //public DateTime? MessageDateOut { get; set; }
            //public string MessageSummary { get; set; }
            //public string MessageExecutant { get; set; }
            //public string MessageResolution { get; set; }
            //public string MessageNumberOutOur { get; set; }
            //public DateTime? MessageDateOutOur { get; set; }
            //public DateTime? MessageExecutionDate { get; set; }
            //[MaxLength(15)]
            //public string MessageControl { get; set; }
            //public string MessageExecution { get; set; }
            //public DateTime? MessageControlDate { get; set; }
        }

        #region Дополнительные справочники классы	    
        /// <summary>
        /// Базовый класс для справочников
        /// </summary>
        public class References
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            [MaxLength(300)]
            public string ItemName { get; set; }
        }
        /// <summary>
        /// Класс описывающий таблицу Исполнители
        /// id - уникальный ключ
        /// ItemName - Наименование исполнителя
        /// </summary>
        public class Executants : References
        {
        }
        /// <summary>
        /// Класс описывающий таблицу Организации (откуда получено)
        /// id - уникальный ключ
        /// ItemName - Наименование организации
        /// </summary>
        public class Organizations : References
        {
        }
        /// <summary>
        /// Класс описывающий таблицу Типы Документов
        /// id - уникальный ключ
        /// ItemName - Наименование типа
        /// </summary>
        public class DocumentTypes : References
        {
        }
        /// <summary>
        /// Класс описывающий таблицу Резолюции
        /// id - уникальный ключ
        /// ItemName - Наименование резолюции
        /// </summary>
        public class Resolutions : References
        {
        }
        /// <summary>
        /// Класс описывающий таблицу Краткое содержание
        /// id - уникальный ключ
        /// ItemName - Наименование исполнителя
        /// </summary>
        public class Summarys : References
        {
        }
        /// <summary>
        /// Класс описывающий таблицу Тип обращения
        /// id - уникальный ключ
        /// ItemName - Наименование исполнителя
        /// </summary>
        public class TreatmentTypes : References
        {
        }
        /// <summary>
        /// Класс описывающий таблицу Тип кореспондента
        /// id - уникальный ключ
        /// ItemName - Наименование исполнителя
        /// </summary>
        public class CorrespondentTypes : References
        {
        }
        /// <summary>
        /// Класс описывающий таблицу Тип получения
        /// id - уникальный ключ
        /// ItemName - Наименование исполнителя
        /// </summary>
        public class RecieveTypes : References
        {
        }
        /// <summary>
        /// Класс описывающий таблицу Категория кореспондента
        /// id - уникальный ключ
        /// ItemName - Наименование исполнителя
        /// </summary>
        public class CorrespondentCategories : References
        {
        }
        /// <summary>
        /// Класс описывающий таблицу Индексы подкатегорий
        /// id - уникальный ключ
        /// ItemName - Наименование исполнителя
        /// </summary>
        public class SubquestionsIndexes : References
        {
        }
        /// <summary>
        /// Класс описывающий таблицу Решения
        /// id - уникальный ключ
        /// ItemName - Наименование исполнителя
        /// </summary>
        public class Agreeds : References
        {
        }
        #endregion

        #region Базовые операции
        /// <summary>
        /// Создать новую базу данных с указанным именем и добавить все таблицы
        /// </summary>
        /// <param name="filename">полный путь и название базы данных</param>
        public static void CreateNewTable(string filename)
        {
            using (var db = new SQLiteConnection(filename))
            {
                db.CreateTable<MessageCitizen>();
                db.CreateTable<Executants>();
                db.CreateTable<Organizations>();
                db.CreateTable<DocumentTypes>();
                db.CreateTable<Resolutions>();
                db.CreateTable<Summarys>();
                db.CreateTable<TreatmentTypes>();
                db.CreateTable<CorrespondentTypes>();
                db.CreateTable<RecieveTypes>();
                db.CreateTable<CorrespondentCategories>();
                db.CreateTable<SubquestionsIndexes>();
                db.CreateTable<Agreeds>();
                _filename = filename;
            }
        }
        /// <summary>
        /// Добаление нового элемента в таблицу указанного типа
        /// </summary>
        /// <typeparam name="T">Тип добавляемого элемента</typeparam>
        /// <param name="item">добавляемый элемент</param>
        public static void AddItem<T>(T item)
        {
            if (_filename != null)
            {
                using (var db = new SQLiteConnection(_filename))
                {
                    db.Insert(item);
                }
            }
        }
        /// <summary>
        /// Обновление элемента указанного типа
        /// </summary>
        /// <typeparam name="T">Тип обновляемого элемента</typeparam>
        /// <param name="item">обновляемый элемент</param>
        public static void UpdateItem<T>(T item)
        {
            using (var db = new SQLiteConnection(_filename))
            {
                db.Update(item);
            }
        }
        /// <summary>
        /// Удаление элемента указанного типа с указанным id
        /// </summary>
        /// <typeparam name="T">Тип удаляемого элемента</typeparam>
        /// <param name="id">id элемента для удаления</param>
        public static void DeleteItem<T>(int id)
        {
            using (var db = new SQLiteConnection(_filename))
            {
                db.Delete<T>(id);
            }
        }
        /// <summary>
        /// Импорт элементов указанного типа 
        /// </summary>
        /// <typeparam name="T">Тип импортируемого элемента</typeparam>
        /// <param name="item">Список импортируемых элементов</param>
        public static void ImportItem<T>(List<T> item)
        {
            if (_filename != null)
            {
                using (var db = new SQLiteConnection(_filename))
                {
                    db.RunInTransaction(() =>
                    {
                        db.InsertAll(item);
                    });
                }
            }
        }
        #endregion

        #region Справочники "Входящие" - методы
        /// <summary>
        /// Получить все записи из таблицы "Входящие" в выбраном файле базы данных
        /// </summary>
        /// <param name="filename">имя файла базы данных</param>
        /// <returns>список записей таблицы "Входящие"</returns>
        public static List<MessageCitizen> OpenTableMessage(string filename)
        {
            _filename = filename;
            return ShowMessageData();
        }
        /// <summary>
        /// Получить все записи из таблицы "Входящие" с сортировкой по дате
        /// </summary>
        /// <returns>список записей таблицы "Входящие"</returns>
        public static List<MessageCitizen> ShowMessageData()
        {
            if (_filename != null)
            {
                using (var db = new SQLiteConnection(_filename))
                {
                    var all = db.Table<MessageCitizen>().OrderByDescending(x => x.WorkingDate).ThenByDescending(x => x.Id).ToList();
                    return all;
                }
            }
            return null;
        }
        /// <summary>
        /// Получить записи из таблицы "Входящие" в указаном интрвале дат
        /// </summary>
        /// <param name="start">дата начала интервала</param>
        /// <param name="end">дата конца интервала</param>
        /// <returns>список записей соответствующих введеному интервалу</returns>
        public static List<MessageCitizen> ShowMessageDataByDate(DateTime start, DateTime end)
        {
            if (_filename != null)
            {
                using (var db = new SQLiteConnection(_filename))
                {
                    //var p = from s in db.Table<Message>()
                    //        where (s.MessageDateIn >= start && s.MessageDateIn <= end)
                    //        select s;
                    //return p.OrderByDescending(x => x.MessageDateIn).ThenByDescending(x => x.Id).ToList();
                }
            }
            return null;
        }
        /// <summary>
        /// Получить данные одной записи с указанным id из таблицы "Входящие"
        /// </summary>
        /// <param name="id">id требуемой записи</param>
        /// <returns>выбранная запись из таблицы</returns>
        public static MessageCitizen GetSingleItem(int id)
        {
            if (_filename != null)
            {
                using (var db = new SQLiteConnection(_filename))
                {
                    var item = db.Get<MessageCitizen>(id);
                    return item;
                }
            }
            return null;
        }
        /// <summary>
        /// Поиск строки в таблице "Входящие"
        /// </summary>
        /// <param name="str">строка которую будем искать</param>
        /// <returns>список записей соответствующих искомой строке</returns>
        public static List<MessageCitizen> FindItems(string str)
        {
            if (_filename != null)
            {
                using (var db = new SQLiteConnection(_filename))
                {
                    //var p = from s in db.Table<Message>()
                    //        where (s.MessageNumberIn.Contains(str) ||
                    //               s.MessageNumberOut.Contains(str) ||
                    //               s.MessageExecutant.Contains(str) ||
                    //               s.MessageOrganization.Contains(str) ||
                    //               s.MessageSummary.Contains(str) ||
                    //               s.MessageResolution.Contains(str) ||
                    //               s.MessageExecution.Contains(str) ||
                    //               s.MessageType.Contains(str))
                    //        select s;
                    //return p.OrderByDescending(x => x.MessageDateIn).ThenByDescending(x => x.Id).ToList();
                }
            }
            return null;
        }
        /// <summary>
        /// Получить все записи из таблицы "Входящие" со значением "На контроле"
        /// </summary>
        /// <param name="str">Строка-условие (На контроле)</param>
        /// <returns>список записей соответствующих условию</returns>
        public static List<MessageCitizen> FindItemsOnControl(string str)
        {
            if (_filename != null)
            {
                using (var db = new SQLiteConnection(_filename))
                {
                    //var p = from s in db.Table<Message>()
                    //        where (s.MessageControl.Contains(str))
                    //        select s;
                    //return p.OrderByDescending(x => x.MessageDateIn).ThenByDescending(x => x.Id).ToList();
                }
            }
            return null;
        }
        #endregion

        #region Дополнительные справочники методы
        /// <summary>
        /// Получить все записи из соответствующей таблицы в выбраном файле базы данных
        /// </summary>
        /// <typeparam name="T">тип таблицы из категории "дополнительные справочники"</typeparam>
        /// <param name="filename">имя файла базы данных</param>
        /// <returns>список записей указаной таблицы</returns>
        public static List<T> OpenDatabase<T>(string filename) where T : References, new()
        {
            _filename = filename;
            return ShowItemsData<T>();
        }
        /// <summary>
        /// Добавляет новый элемент в таблицу
        /// </summary>
        /// <typeparam name="T">тип таблицы из категории "дополнительные справочники"</typeparam>
        /// <param name="value">добавляемое строковое значение</param>
        public static void AddReferencesItem<T>(string value) where T : References, new()
        {
            var item = new T();
            item.ItemName = value;
            AddItem(item);
        }
        /// <summary>
        /// Получить все записи из таблицы с сортировкой  по названию
        /// </summary>
        /// <typeparam name="T">тип таблицы из категории "дополнительные справочники"</typeparam>
        /// <returns>список записей указаной таблицы</returns>
        public static List<T> ShowItemsData<T>() where T : References, new()
        {
            if (_filename != null)
            {
                using (var db = new SQLiteConnection(_filename))
                {
                    var all = db.Table<T>().OrderBy(x => x.ItemName).ToList();
                    return all;
                }
            }
            return null;
        }
        /// <summary>
        /// Получить данные одной записи с указанным id из таблицы 
        /// </summary>
        /// <typeparam name="T">тип таблицы из категории "дополнительные справочники"</typeparam>
        /// <param name="id">id требуемой записи</param>
        /// <returns>запись из указанной таблицы</returns>
        public static T GetSingleItem<T>(int id) where T : References, new()
        {
            if (_filename != null)
            {
                using (var db = new SQLiteConnection(_filename))
                {
                    var item = db.Get<T>(id);
                    return item;
                }
            }
            return null;
        }
        /// <summary>
        /// Поиск строки в указанной таблице
        /// </summary>
        /// <typeparam name="T">тип таблицы из категории "дополнительные справочники"</typeparam>
        /// <param name="str">строка которую будем искать</param>
        /// <returns>список записей соответствующих искомой строке</returns>
        public static List<T> FindItems<T>(string str) where T : References, new()
        {
            if (_filename != null)
            {
                using (var db = new SQLiteConnection(_filename))
                {
                    var p = from s in db.Table<T>()
                            where (s.ItemName.Contains(str))
                            select s;
                    return p.ToList();
                }
            }
            return null;
        }
        #endregion

        #region Импорт данных
        /// <summary>
        /// Проверяет объект на null,и если не равно , то приводит к типу string и возвращает значение
        /// в противном случае возвращает null
        /// </summary>
        /// <param name="item">данные которые нужно привести к строке</param>
        /// <returns>если не null , то возвращает объект приведенный к строке</returns>
        private static string PrepareItemString(object item)
        {
            if (item != null)
                return item.ToString();
            return null;
        }
        /// <summary>
        /// Проверяет объект на null,и если не равно , то приводит к типу string
        /// проверяет не пустая ли дата в строке ("  .  .    "),если нет - то приводит к типу datetime и возвращает значение
        /// в противном случае возвращает null
        /// </summary>
        /// <param name="item">данные которые нужно привести к дате</param>
        /// <returns>если не null , то возвращает объект приведенный к дате</returns>
        private static DateTime? PrepareItemDate(object item)
        {
            if (item != null)
                if (item.ToString() != "  .  .    ")
                    return DateTime.Parse(item.ToString());
            return null;
        }
        /// <summary>
        /// Выбор файла Xlsx с данными для загрузки в таблицу "Исходящие"
        /// Импорт данніх с файла в таблицу "Исходящие"
        /// </summary>
        //public static void ImportOutgoingItems()
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.DefaultExt = "*.xlsx";
        //    ofd.Filter = "Excel 2007(*.xlsx)|*.xlsx";
        //    ofd.Title = "Выберите документ для загрузки данных";
        //    ofd.InitialDirectory = ImportDir;

        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        var package = new ExcelPackage(new FileInfo(ofd.FileName));

        //        ExcelWorksheet workSheet = package.Workbook.Worksheets[1];


        //        if (workSheet.Dimension.End.Column != 8)
        //        {
        //            MessageBox.Show("Ошибка!Число столбцов должно быть равно 8,а файле " + workSheet.Dimension.End.Column.ToString());
        //        }
        //        else
        //        {
        //            int count = 0;
        //            for (int i = workSheet.Dimension.Start.Row + 3;
        //                    i < workSheet.Dimension.End.Row + 1;
        //                    i++)
        //            {
        //                //var item = new OutgoingMessage();

        //                //item.MessageNumberOut = PrepareItemString(workSheet.Cells[i, 1].Value);
        //                //item.MessageDateOut = PrepareItemDate(workSheet.Cells[i, 2].Value);
        //                //item.MessageNumberIn = PrepareItemString(workSheet.Cells[i, 3].Value);
        //                //item.MessageDateIn = PrepareItemDate(workSheet.Cells[i, 4].Value);
        //                //item.MessageType = PrepareItemString(workSheet.Cells[i, 5].Value);
        //                //item.MessageOrganization = PrepareItemString(workSheet.Cells[i, 6].Value);
        //                //item.MessageExecutant = PrepareItemString(workSheet.Cells[i, 7].Value);
        //                //item.MessageSummary = PrepareItemString(workSheet.Cells[i, 8].Value);

        //                //AddItem(item);
        //                count++;
        //            }
        //            ImportSuccessMessage(count);
        //        }
        //    }
        //}
        ///// <summary>
        ///// Выбор файла Xlsx с данными для загрузки в таблицу "Входящие"
        ///// Импорт данніх с файла в таблицу "Входящие" 
        ///// </summary>
        //public static void ImportIncomingItems()
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.DefaultExt = "*.xlsx";
        //    ofd.Filter = "Excel 2007(*.xlsx)|*.xlsx";
        //    ofd.Title = "Выберите документ для загрузки данных";
        //    ofd.InitialDirectory = ImportDir;

        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        var package = new ExcelPackage(new FileInfo(ofd.FileName));

        //        ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

        //        if (workSheet.Dimension.End.Column != 15)
        //        {
        //            MessageBox.Show("Ошибка!Число столбцов должно быть равно 15,а файле " + workSheet.Dimension.End.Column.ToString());
        //        }
        //        else
        //        {
        //            int count = 0;
        //            for (int i = workSheet.Dimension.Start.Row + 3;
        //                i < workSheet.Dimension.End.Row + 1;
        //                i++)
        //            {

        //                var item = new Message();

        //                //item.MessageNumberIn = PrepareItemString(workSheet.Cells[i, 1].Value);
        //                //item.MessageDateIn = PrepareItemDate(workSheet.Cells[i, 2].Value);
        //                //item.MessageType = PrepareItemString(workSheet.Cells[i, 3].Value);
        //                //item.MessageOrganization = PrepareItemString(workSheet.Cells[i, 4].Value);
        //                //item.MessageNumberOut = PrepareItemString(workSheet.Cells[i, 5].Value);
        //                //item.MessageDateOut = PrepareItemDate(workSheet.Cells[i, 6].Value);
        //                //item.MessageSummary = PrepareItemString(workSheet.Cells[i, 7].Value);
        //                //item.MessageExecutant = PrepareItemString(workSheet.Cells[i, 8].Value);
        //                //item.MessageResolution = PrepareItemString(workSheet.Cells[i, 9].Value);
        //                //item.MessageNumberOutOur = PrepareItemString(workSheet.Cells[i, 10].Value);
        //                //item.MessageDateOutOur = PrepareItemDate(workSheet.Cells[i, 11].Value);
        //                //item.MessageExecutionDate = PrepareItemDate(workSheet.Cells[i, 12].Value);
        //                //item.MessageControl = PrepareItemString(workSheet.Cells[i, 13].Value);
        //                //item.MessageExecution = PrepareItemString(workSheet.Cells[i, 14].Value);
        //                //item.MessageControlDate = PrepareItemDate(workSheet.Cells[i, 15].Value);

        //                AddItem(item);
        //                count++;
        //            }
        //            ImportSuccessMessage(count);
        //        }
        //    }
        //}
        /// <summary>
        /// Импорт информации из файла в соответствующий дополнительный справочник
        /// </summary>
        /// <typeparam name="T">тип таблицы из категории "дополнительные справочники</typeparam>
        /// <param name="importFilename">файл из которого производится импорт</param>
        public static void ImportReferenceItems<T>(string importFilename) where T : References, new()
        {
            var package = new ExcelPackage(new FileInfo(importFilename));

            ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

            if (workSheet.Dimension.End.Column != 1)
            {
                MessageBox.Show("Ошибка!Число столбцов должно быть равно 1,а файле " + workSheet.Dimension.End.Column.ToString());
            }
            else
            {
                int count = 0;
                for (int i = workSheet.Dimension.Start.Row + 1;
                    i < workSheet.Dimension.End.Row + 1;
                    i++)
                {
                    var item = new T();
                    item.ItemName = PrepareItemString(workSheet.Cells[i, 1].Value);
                    AddItem(item);
                    count++;
                }
                ImportSuccessMessage(count);
            }
        }
        #endregion

        public static void ExportReferenceItems<T>(string exportFilename, List<T> items) where T : References, new()
        {
            FileInfo fn = new FileInfo(exportFilename);
            using (ExcelPackage pck = new ExcelPackage(fn))
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add(CurrentReferenceName);
                ws.Cells[1, 1].Value = CurrentReferenceName;
                for (int i = 0; i < items.Count; i++)
                {
                    ws.Cells[i + 2, 1].Value = items[i].ItemName;
                }
                pck.Package.Compression = CompressionLevel.Level9;
                pck.Save();
            }

        }

        private static void ImportSuccessMessage(object count)
        {
            MessageBox.Show("Импортировано записей - " + count.ToString());
        }
    }
}
