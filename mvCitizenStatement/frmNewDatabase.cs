using System;
using static mvCitizenStatement.DataModel;
using static mvCitizenStatement.mvSettings;
using System.Windows.Forms;

namespace mvCitizenStatement
{
    public partial class frmNewDatabase : Form
    {
        public frmNewDatabase()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Создать новую базу данных с указанным именем  
        /// </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtBaseName.Text.Length <= 0)
            {
                MessageBox.Show("Вы не ввели название базы");
            }
            else
            {
                CreateNewTable(string.Format(DatabaseDir + "\\db_{0}.db", txtBaseName.Text));
                DialogResult = DialogResult.OK;
            }
        }
    }
}
