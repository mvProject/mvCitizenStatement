using System;
using static mvCitizenStatement.mvSettings;
using System.Windows.Forms;

namespace mvCitizenStatement
{
    public partial class frmJournalDate : Form
    {
        public frmJournalDate()
        {
            InitializeComponent();
            if (startPeriod != DateTime.Now)
                dtpStartPeriod.Value = startPeriod;
            if (endPeriod != DateTime.Now)
                dtpEndPeriod.Value = endPeriod;
        }
        /// <summary>
        /// Отключить действие журнала
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            startPeriod = DateTime.Now;
            endPeriod = DateTime.Now;
            DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// Включить десйтвие журнала
        /// установить начальную и конечную даты
        /// </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            startPeriod = dtpStartPeriod.Value.Date;
            endPeriod = dtpEndPeriod.Value.Date;
            DialogResult = DialogResult.OK;
        }
    }
}
