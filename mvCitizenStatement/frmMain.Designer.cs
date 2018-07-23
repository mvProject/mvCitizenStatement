namespace mvCitizenStatement
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrintSingle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrintAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReferences = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOrganizations = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTreatmentTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCorrespondentTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRecieveTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReceiveSign = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSubquestionsIndexes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCorrespondentCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCorrespondentSocialStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSummarys = new System.Windows.Forms.ToolStripMenuItem();
            this.mnResolutions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAgreeds = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExecutants = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddItem = new System.Windows.Forms.ToolStripButton();
            this.btnEditItem = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.btnClearFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnJournal = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRecordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMain
            // 
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFile,
            this.mnReferences});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(698, 24);
            this.mnMain.TabIndex = 0;
            this.mnMain.Text = "menuStrip1";
            // 
            // mnFile
            // 
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCreate,
            this.mnOpen,
            this.toolStripMenuItem2,
            this.mnPrint,
            this.mnSettings,
            this.toolStripMenuItem3,
            this.mnExit});
            this.mnFile.Name = "mnFile";
            this.mnFile.Size = new System.Drawing.Size(48, 20);
            this.mnFile.Text = "Файл";
            // 
            // mnCreate
            // 
            this.mnCreate.Image = global::mvCitizenStatement.Properties.Resources.new_item;
            this.mnCreate.Name = "mnCreate";
            this.mnCreate.Size = new System.Drawing.Size(156, 22);
            this.mnCreate.Text = "Створити";
            this.mnCreate.Click += new System.EventHandler(this.mnCreate_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Image = global::mvCitizenStatement.Properties.Resources.open_item;
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(156, 22);
            this.mnOpen.Text = "Відкрити";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 6);
            // 
            // mnPrint
            // 
            this.mnPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPrintSingle,
            this.mnPrintAll});
            this.mnPrint.Enabled = false;
            this.mnPrint.Image = global::mvCitizenStatement.Properties.Resources.print;
            this.mnPrint.Name = "mnPrint";
            this.mnPrint.Size = new System.Drawing.Size(156, 22);
            this.mnPrint.Text = "Друк";
            // 
            // mnPrintSingle
            // 
            this.mnPrintSingle.Image = global::mvCitizenStatement.Properties.Resources.print;
            this.mnPrintSingle.Name = "mnPrintSingle";
            this.mnPrintSingle.Size = new System.Drawing.Size(137, 22);
            this.mnPrintSingle.Text = "Один запис";
            this.mnPrintSingle.Click += new System.EventHandler(this.mnPrintSingle_Click);
            // 
            // mnPrintAll
            // 
            this.mnPrintAll.Image = global::mvCitizenStatement.Properties.Resources.print_many;
            this.mnPrintAll.Name = "mnPrintAll";
            this.mnPrintAll.Size = new System.Drawing.Size(137, 22);
            this.mnPrintAll.Text = "Усі записи";
            this.mnPrintAll.Click += new System.EventHandler(this.mnPrintAll_Click);
            // 
            // mnSettings
            // 
            this.mnSettings.Image = global::mvCitizenStatement.Properties.Resources.settings;
            this.mnSettings.Name = "mnSettings";
            this.mnSettings.Size = new System.Drawing.Size(156, 22);
            this.mnSettings.Text = "Налаштування";
            this.mnSettings.Click += new System.EventHandler(this.mnSettings_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(153, 6);
            // 
            // mnExit
            // 
            this.mnExit.Image = global::mvCitizenStatement.Properties.Resources.application_exit;
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(156, 22);
            this.mnExit.Text = "Вихід";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnReferences
            // 
            this.mnReferences.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOrganizations,
            this.mnTreatmentTypes,
            this.mnCorrespondentTypes,
            this.mnRecieveTypes,
            this.mnReceiveSign,
            this.mnSubquestionsIndexes,
            this.mnCorrespondentCategories,
            this.mnCorrespondentSocialStatus,
            this.mnSummarys,
            this.mnResolutions,
            this.mnAgreeds,
            this.mnExecutants});
            this.mnReferences.Enabled = false;
            this.mnReferences.Name = "mnReferences";
            this.mnReferences.Size = new System.Drawing.Size(131, 20);
            this.mnReferences.Text = "Додаткові довідники";
            // 
            // mnOrganizations
            // 
            this.mnOrganizations.Name = "mnOrganizations";
            this.mnOrganizations.Size = new System.Drawing.Size(227, 22);
            this.mnOrganizations.Tag = "Organizations";
            this.mnOrganizations.Text = "Звідки";
            this.mnOrganizations.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnTreatmentTypes
            // 
            this.mnTreatmentTypes.Name = "mnTreatmentTypes";
            this.mnTreatmentTypes.Size = new System.Drawing.Size(227, 22);
            this.mnTreatmentTypes.Tag = "TreatmentTypes";
            this.mnTreatmentTypes.Text = "Вид звернення";
            this.mnTreatmentTypes.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnCorrespondentTypes
            // 
            this.mnCorrespondentTypes.Name = "mnCorrespondentTypes";
            this.mnCorrespondentTypes.Size = new System.Drawing.Size(227, 22);
            this.mnCorrespondentTypes.Tag = "CorrespondentTypes";
            this.mnCorrespondentTypes.Text = "Тип заявника (за суб\'єктом)";
            this.mnCorrespondentTypes.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnRecieveTypes
            // 
            this.mnRecieveTypes.Name = "mnRecieveTypes";
            this.mnRecieveTypes.Size = new System.Drawing.Size(227, 22);
            this.mnRecieveTypes.Tag = "RecieveTypes";
            this.mnRecieveTypes.Text = "Форма надходження";
            this.mnRecieveTypes.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnReceiveSign
            // 
            this.mnReceiveSign.Name = "mnReceiveSign";
            this.mnReceiveSign.Size = new System.Drawing.Size(227, 22);
            this.mnReceiveSign.Tag = "RecieveSigns";
            this.mnReceiveSign.Text = "Ознака надходження";
            this.mnReceiveSign.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnSubquestionsIndexes
            // 
            this.mnSubquestionsIndexes.Name = "mnSubquestionsIndexes";
            this.mnSubquestionsIndexes.Size = new System.Drawing.Size(227, 22);
            this.mnSubquestionsIndexes.Tag = "SubquestionsIndexes";
            this.mnSubquestionsIndexes.Text = "Індекси підпитань";
            this.mnSubquestionsIndexes.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnCorrespondentCategories
            // 
            this.mnCorrespondentCategories.Name = "mnCorrespondentCategories";
            this.mnCorrespondentCategories.Size = new System.Drawing.Size(227, 22);
            this.mnCorrespondentCategories.Tag = "CorrespondentCategories";
            this.mnCorrespondentCategories.Text = "Категорія заявника";
            this.mnCorrespondentCategories.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnCorrespondentSocialStatus
            // 
            this.mnCorrespondentSocialStatus.Name = "mnCorrespondentSocialStatus";
            this.mnCorrespondentSocialStatus.Size = new System.Drawing.Size(227, 22);
            this.mnCorrespondentSocialStatus.Tag = "CorrespondentSocialStatuses";
            this.mnCorrespondentSocialStatus.Text = "Соціальний стан заявника";
            this.mnCorrespondentSocialStatus.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnSummarys
            // 
            this.mnSummarys.Name = "mnSummarys";
            this.mnSummarys.Size = new System.Drawing.Size(227, 22);
            this.mnSummarys.Tag = "Summarys";
            this.mnSummarys.Text = "Короткий зміст";
            this.mnSummarys.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnResolutions
            // 
            this.mnResolutions.Name = "mnResolutions";
            this.mnResolutions.Size = new System.Drawing.Size(227, 22);
            this.mnResolutions.Tag = "Resolutions";
            this.mnResolutions.Text = "Резолюція";
            this.mnResolutions.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnAgreeds
            // 
            this.mnAgreeds.Name = "mnAgreeds";
            this.mnAgreeds.Size = new System.Drawing.Size(227, 22);
            this.mnAgreeds.Tag = "Agreeds";
            this.mnAgreeds.Text = "Рішення";
            this.mnAgreeds.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnExecutants
            // 
            this.mnExecutants.Name = "mnExecutants";
            this.mnExecutants.Size = new System.Drawing.Size(227, 22);
            this.mnExecutants.Tag = "Executants";
            this.mnExecutants.Text = "Виконавець";
            this.mnExecutants.Click += new System.EventHandler(this.selectReferences);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddItem,
            this.btnEditItem,
            this.btnDeleteItem,
            this.toolStripSeparator1,
            this.txtFind,
            this.btnClearFind,
            this.toolStripSeparator2,
            this.btnJournal});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(698, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Enabled = false;
            this.btnAddItem.Image = global::mvCitizenStatement.Properties.Resources.add;
            this.btnAddItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(66, 22);
            this.btnAddItem.Text = "Додати";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Enabled = false;
            this.btnEditItem.Image = global::mvCitizenStatement.Properties.Resources.edit3;
            this.btnEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(87, 22);
            this.btnEditItem.Text = "Редагувати";
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Enabled = false;
            this.btnDeleteItem.Image = global::mvCitizenStatement.Properties.Resources.delete;
            this.btnDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(79, 22);
            this.btnDeleteItem.Text = "Видалити";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtFind
            // 
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(200, 25);
            this.txtFind.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFind.TextChanged += new System.EventHandler(this.FindRecords);
            // 
            // btnClearFind
            // 
            this.btnClearFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearFind.Image = global::mvCitizenStatement.Properties.Resources.clear;
            this.btnClearFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearFind.Name = "btnClearFind";
            this.btnClearFind.Size = new System.Drawing.Size(23, 22);
            this.btnClearFind.Text = "toolStripButton1";
            this.btnClearFind.Click += new System.EventHandler(this.btnClearFind_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnJournal
            // 
            this.btnJournal.CheckOnClick = true;
            this.btnJournal.Image = global::mvCitizenStatement.Properties.Resources.arrow_two_head;
            this.btnJournal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(71, 22);
            this.btnJournal.Text = "Журнал";
            this.btnJournal.Click += new System.EventHandler(this.btnJournal_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(5, 53);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(687, 340);
            this.dgv.TabIndex = 2;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtRecordCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 33);
            this.panel1.TabIndex = 3;
            // 
            // txtRecordCount
            // 
            this.txtRecordCount.AutoSize = true;
            this.txtRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRecordCount.Location = new System.Drawing.Point(100, 7);
            this.txtRecordCount.Name = "txtRecordCount";
            this.txtRecordCount.Size = new System.Drawing.Size(16, 17);
            this.txtRecordCount.TabIndex = 1;
            this.txtRecordCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Усього записів :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnMain);
            this.MainMenuStrip = this.mnMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem mnFile;
        private System.Windows.Forms.ToolStripMenuItem mnCreate;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnPrint;
        private System.Windows.Forms.ToolStripMenuItem mnSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddItem;
        private System.Windows.Forms.ToolStripButton btnEditItem;
        private System.Windows.Forms.ToolStripButton btnDeleteItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStripMenuItem mnReferences;
        private System.Windows.Forms.ToolStripMenuItem mnOrganizations;
        private System.Windows.Forms.ToolStripMenuItem mnTreatmentTypes;
        private System.Windows.Forms.ToolStripMenuItem mnCorrespondentTypes;
        private System.Windows.Forms.ToolStripMenuItem mnRecieveTypes;
        private System.Windows.Forms.ToolStripMenuItem mnSubquestionsIndexes;
        private System.Windows.Forms.ToolStripMenuItem mnCorrespondentCategories;
        private System.Windows.Forms.ToolStripMenuItem mnSummarys;
        private System.Windows.Forms.ToolStripMenuItem mnResolutions;
        private System.Windows.Forms.ToolStripMenuItem mnAgreeds;
        private System.Windows.Forms.ToolStripMenuItem mnExecutants;
        private System.Windows.Forms.ToolStripMenuItem mnPrintSingle;
        private System.Windows.Forms.ToolStripMenuItem mnPrintAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripTextBox txtFind;
        private System.Windows.Forms.ToolStripButton btnClearFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnReceiveSign;
        private System.Windows.Forms.ToolStripMenuItem mnCorrespondentSocialStatus;
        private System.Windows.Forms.ToolStripButton btnJournal;
    }
}

