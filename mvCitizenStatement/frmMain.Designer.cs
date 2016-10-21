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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddItem = new System.Windows.Forms.ToolStripButton();
            this.btnEditItem = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.mnReferences = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOrganizations = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTreatmentTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCorrespondentTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRecieveTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSubquestionsIndexes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCorrespondentCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSummarys = new System.Windows.Forms.ToolStripMenuItem();
            this.mnResolutions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAgreeds = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExecutants = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.mnCreate.Name = "mnCreate";
            this.mnCreate.Size = new System.Drawing.Size(134, 22);
            this.mnCreate.Text = "Создать";
            this.mnCreate.Click += new System.EventHandler(this.mnCreate_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(134, 22);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(131, 6);
            // 
            // mnPrint
            // 
            this.mnPrint.Name = "mnPrint";
            this.mnPrint.Size = new System.Drawing.Size(134, 22);
            this.mnPrint.Text = "Печать";
            // 
            // mnSettings
            // 
            this.mnSettings.Name = "mnSettings";
            this.mnSettings.Size = new System.Drawing.Size(134, 22);
            this.mnSettings.Text = "Настройки";
            this.mnSettings.Click += new System.EventHandler(this.mnSettings_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(131, 6);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(134, 22);
            this.mnExit.Text = "Выход";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddItem,
            this.btnEditItem,
            this.btnDeleteItem,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(698, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddItem
            // 
            this.btnAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(63, 22);
            this.btnAddItem.Text = "Добавить";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditItem.Image = ((System.Drawing.Image)(resources.GetObject("btnEditItem.Image")));
            this.btnEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(91, 22);
            this.btnEditItem.Text = "Редактировать";
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItem.Image")));
            this.btnDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(55, 22);
            this.btnDeleteItem.Text = "Удалить";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.dgv.Location = new System.Drawing.Point(13, 53);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(673, 338);
            this.dgv.TabIndex = 2;
            // 
            // mnReferences
            // 
            this.mnReferences.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOrganizations,
            this.mnTreatmentTypes,
            this.mnCorrespondentTypes,
            this.mnRecieveTypes,
            this.mnSubquestionsIndexes,
            this.mnCorrespondentCategories,
            this.mnSummarys,
            this.mnResolutions,
            this.mnAgreeds,
            this.mnExecutants});
            this.mnReferences.Name = "mnReferences";
            this.mnReferences.Size = new System.Drawing.Size(191, 20);
            this.mnReferences.Text = "Дополнительные справочники";
            // 
            // mnOrganizations
            // 
            this.mnOrganizations.Name = "mnOrganizations";
            this.mnOrganizations.Size = new System.Drawing.Size(224, 22);
            this.mnOrganizations.Tag = "Organizations";
            this.mnOrganizations.Text = "Получено";
            this.mnOrganizations.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnTreatmentTypes
            // 
            this.mnTreatmentTypes.Name = "mnTreatmentTypes";
            this.mnTreatmentTypes.Size = new System.Drawing.Size(224, 22);
            this.mnTreatmentTypes.Tag = "TreatmentTypes";
            this.mnTreatmentTypes.Text = "Тип обращения";
            this.mnTreatmentTypes.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnCorrespondentTypes
            // 
            this.mnCorrespondentTypes.Name = "mnCorrespondentTypes";
            this.mnCorrespondentTypes.Size = new System.Drawing.Size(224, 22);
            this.mnCorrespondentTypes.Tag = "CorrespondentTypes";
            this.mnCorrespondentTypes.Text = "Тип корреспондента";
            this.mnCorrespondentTypes.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnRecieveTypes
            // 
            this.mnRecieveTypes.Name = "mnRecieveTypes";
            this.mnRecieveTypes.Size = new System.Drawing.Size(224, 22);
            this.mnRecieveTypes.Tag = "RecieveTypes";
            this.mnRecieveTypes.Text = "Тип получения";
            this.mnRecieveTypes.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnSubquestionsIndexes
            // 
            this.mnSubquestionsIndexes.Name = "mnSubquestionsIndexes";
            this.mnSubquestionsIndexes.Size = new System.Drawing.Size(224, 22);
            this.mnSubquestionsIndexes.Tag = "SubquestionsIndexes";
            this.mnSubquestionsIndexes.Text = "Индексы подкатегорий";
            this.mnSubquestionsIndexes.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnCorrespondentCategories
            // 
            this.mnCorrespondentCategories.Name = "mnCorrespondentCategories";
            this.mnCorrespondentCategories.Size = new System.Drawing.Size(224, 22);
            this.mnCorrespondentCategories.Tag = "CorrespondentCategories";
            this.mnCorrespondentCategories.Text = "Категории кореспондентов";
            this.mnCorrespondentCategories.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnSummarys
            // 
            this.mnSummarys.Name = "mnSummarys";
            this.mnSummarys.Size = new System.Drawing.Size(224, 22);
            this.mnSummarys.Tag = "Summarys";
            this.mnSummarys.Text = "Краткое содержание";
            this.mnSummarys.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnResolutions
            // 
            this.mnResolutions.Name = "mnResolutions";
            this.mnResolutions.Size = new System.Drawing.Size(224, 22);
            this.mnResolutions.Tag = "Resolutions";
            this.mnResolutions.Text = "Резолюция";
            this.mnResolutions.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnAgreeds
            // 
            this.mnAgreeds.Name = "mnAgreeds";
            this.mnAgreeds.Size = new System.Drawing.Size(224, 22);
            this.mnAgreeds.Tag = "Agreeds";
            this.mnAgreeds.Text = "Решение";
            this.mnAgreeds.Click += new System.EventHandler(this.selectReferences);
            // 
            // mnExecutants
            // 
            this.mnExecutants.Name = "mnExecutants";
            this.mnExecutants.Size = new System.Drawing.Size(224, 22);
            this.mnExecutants.Tag = "Executants";
            this.mnExecutants.Text = "Исполнители";
            this.mnExecutants.Click += new System.EventHandler(this.selectReferences);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 429);
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
    }
}

