using System;
using System.IO;
using TemplateEngine.Docx;
using static mvCitizenStatement.mvSettings;


namespace mvCitizenStatement
{
    /// <summary>
    /// Класс реализовующий создание карточки на основании шаблона,с подстановкой переданных значений и сохранении в файл
    /// </summary>
    public static class mvReport
    {
        /// <summary>
        /// Создает на основании указанного шаблона файл отчета,подставляет данные и сохраняет с указанным именем
        /// </summary>
        /// <param name="values">Данные для подстановки в шаблон</param>
        /// <param name="tmpName">Имя файла-шаблона</param>
        /// <param name="outFileName">Имя выходного файла</param>
        public static void SaveReport(Content values,string tmpName,string outFileName)
        {
            if (File.Exists(ReportDir + "\\" + outFileName))
                File.Delete(ReportDir + "\\" + outFileName);
            File.Copy(TemplateDir + tmpName,ReportDir + outFileName);
            using (var outfile = new TemplateProcessor(ReportDir + outFileName).SetRemoveContentControls(true))
            {
                outfile.FillContent(values);
                outfile.SaveChanges();
            }

        }
        /// <summary>
        /// Подготовка данных для подстановки в шаблон с проверкой на null
        /// </summary>
        /// <param name="fieldname">название поля в шаблоне</param>
        /// <param name="item">объект который необходимо подставить</param>
        /// <returns>возвращает обработанный объект для подстановки</returns>
        public static FieldContent GetContent(string fieldname,object item)
        {
            var resultitem = "";
            if (item != null)
                 resultitem = item.ToString();
            return new FieldContent(fieldname, resultitem); 
        }
        /// <summary>
        /// Подготовка данных для подстановки в шаблон с проверкой на null
        /// </summary>
        /// <param name="fieldname">название поля в шаблоне</param>
        /// <param name="item">объект который необходимо подставить</param>
        /// <param name="isdate">является ли занчения объекта датой</param>
        /// <returns>возвращает обработанный объект для подстановки</returns>
        public static FieldContent GetContent(string fieldname, object item, bool isdate)
        {
            var resultitem = "";
            if (item != null)
            {
                if (isdate)
                    resultitem = DateTime.Parse(item.ToString()).ToShortDateString();
            }
            return new FieldContent(fieldname, resultitem);
        }
        /// <summary>
        /// Формирование имени файла для вывода
        /// </summary>
        /// <param name="prefix">префикс для названия ("вх" или "исх")</param>
        /// <param name="number">номер сообщения</param>
        /// <param name="date">дата сообщения</param>
        /// <param name="idrecord">id записи в базе</param>
        /// <returns>имя файла в формате префикс_(дата)_(номер)_(ид)</returns>
        public static string GetPrepareFilename(string prefix,object number,object date,object idrecord)
        {
            string res, dt, num, id;
            res = prefix;
            if (date != null)
            {
                dt = DateTime.Parse(date.ToString()).ToShortDateString();
                res += "_" + dt;
            }
            if (number != null)
            {
                num = number.ToString().Replace('\\', '-').Replace('/', '-');
                res +="_" + num; 
            }
            if (idrecord != null)
            {
                id = idrecord.ToString();
                res += "_(" + id + ")";
            }
            return res + ".docx";
        }

    }
}
