
namespace notebook
{
    partial class noteBookForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(noteBookForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagesTabs = new System.Windows.Forms.ImageList(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.settings = new System.Windows.Forms.TabPage();
            this.sortSettingsBox = new System.Windows.Forms.GroupBox();
            this.sortPlansSettingsRBtnsPanel = new System.Windows.Forms.Panel();
            this.sortPlansNameSettingsRBtn = new System.Windows.Forms.RadioButton();
            this.sortPlansDateSettingsRBtn = new System.Windows.Forms.RadioButton();
            this.sortNotesSettingsRBtnsPanel = new System.Windows.Forms.Panel();
            this.sortNotesNameSettingsRBtn = new System.Windows.Forms.RadioButton();
            this.sortNotesDateSettingsRBtn = new System.Windows.Forms.RadioButton();
            this.noteSortSettingsLabel = new System.Windows.Forms.Label();
            this.planSortSettingsLabel = new System.Windows.Forms.Label();
            this.applySettingsBtn = new System.Windows.Forms.Button();
            this.fontSettingsBox = new System.Windows.Forms.GroupBox();
            this.textsFontSize = new System.Windows.Forms.ComboBox();
            this.generalFontSize = new System.Windows.Forms.ComboBox();
            this.textsFontNameText = new System.Windows.Forms.TextBox();
            this.generalFontNameText = new System.Windows.Forms.TextBox();
            this.generalFontLabel = new System.Windows.Forms.Label();
            this.textslFontLabel = new System.Windows.Forms.Label();
            this.plans = new System.Windows.Forms.TabPage();
            this.splitContainerPlans = new System.Windows.Forms.SplitContainer();
            this.deletePointBtn = new System.Windows.Forms.Button();
            this.createNewPointBtn = new System.Windows.Forms.Button();
            this.createNewPlanBtn = new System.Windows.Forms.Button();
            this.copyPlanBtn = new System.Windows.Forms.Button();
            this.clearPlanBtn = new System.Windows.Forms.Button();
            this.savePlanButton = new System.Windows.Forms.Button();
            this.pointsPlanBox = new System.Windows.Forms.GroupBox();
            this.listBoxPoints = new System.Windows.Forms.ListBox();
            this.datePlanBox = new System.Windows.Forms.GroupBox();
            this.textDatePlan = new System.Windows.Forms.MaskedTextBox();
            this.namePlanBox = new System.Windows.Forms.GroupBox();
            this.textNamePlan = new System.Windows.Forms.TextBox();
            this.sortListBoxPlansDateRBtn = new System.Windows.Forms.RadioButton();
            this.sortListBoxPlansNameRBtn = new System.Windows.Forms.RadioButton();
            this.sortListBoxPlansLabel = new System.Windows.Forms.Label();
            this.deleteListBoxPlansBtn = new System.Windows.Forms.Button();
            this.groupListPlansBox = new System.Windows.Forms.GroupBox();
            this.listBoxPlans = new System.Windows.Forms.ListBox();
            this.notes = new System.Windows.Forms.TabPage();
            this.splitContainerNotes = new System.Windows.Forms.SplitContainer();
            this.createNewNoteBtn = new System.Windows.Forms.Button();
            this.copyNoteBtn = new System.Windows.Forms.Button();
            this.clearNoteBtn = new System.Windows.Forms.Button();
            this.saveNoteBtn = new System.Windows.Forms.Button();
            this.textNoteBox = new System.Windows.Forms.GroupBox();
            this.mainTextNote = new System.Windows.Forms.RichTextBox();
            this.dateNoteBox = new System.Windows.Forms.GroupBox();
            this.textDateNote = new System.Windows.Forms.MaskedTextBox();
            this.nameNoteBox = new System.Windows.Forms.GroupBox();
            this.textNameNote = new System.Windows.Forms.TextBox();
            this.sortListBoxNotesLabel = new System.Windows.Forms.Label();
            this.sortListBoxNotesDateRBtn = new System.Windows.Forms.RadioButton();
            this.sortListBoxNotesNameRBtn = new System.Windows.Forms.RadioButton();
            this.deleteListBoxNotesBtn = new System.Windows.Forms.Button();
            this.groupListNotesBox = new System.Windows.Forms.GroupBox();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.settings.SuspendLayout();
            this.sortSettingsBox.SuspendLayout();
            this.sortPlansSettingsRBtnsPanel.SuspendLayout();
            this.sortNotesSettingsRBtnsPanel.SuspendLayout();
            this.fontSettingsBox.SuspendLayout();
            this.plans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPlans)).BeginInit();
            this.splitContainerPlans.Panel1.SuspendLayout();
            this.splitContainerPlans.Panel2.SuspendLayout();
            this.splitContainerPlans.SuspendLayout();
            this.pointsPlanBox.SuspendLayout();
            this.datePlanBox.SuspendLayout();
            this.namePlanBox.SuspendLayout();
            this.groupListPlansBox.SuspendLayout();
            this.notes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNotes)).BeginInit();
            this.splitContainerNotes.Panel1.SuspendLayout();
            this.splitContainerNotes.Panel2.SuspendLayout();
            this.splitContainerNotes.SuspendLayout();
            this.textNoteBox.SuspendLayout();
            this.dateNoteBox.SuspendLayout();
            this.nameNoteBox.SuspendLayout();
            this.groupListNotesBox.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryToolStripMenuItem,
            this.printToolStripMenuItem,
            this.referenceToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(759, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.entryToolStripMenuItem.Text = "Запись";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNoteToolStripMenuItem,
            this.createPlanToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.createToolStripMenuItem.Text = "Создать";
            // 
            // createNoteToolStripMenuItem
            // 
            this.createNoteToolStripMenuItem.Name = "createNoteToolStripMenuItem";
            this.createNoteToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.createNoteToolStripMenuItem.Text = "Заметка";
            this.createNoteToolStripMenuItem.Click += new System.EventHandler(this.createNoteToolStripMenuItem_Click);
            // 
            // createPlanToolStripMenuItem
            // 
            this.createPlanToolStripMenuItem.Name = "createPlanToolStripMenuItem";
            this.createPlanToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.createPlanToolStripMenuItem.Text = "План";
            this.createPlanToolStripMenuItem.Click += new System.EventHandler(this.createPlanToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.printToolStripMenuItem.Text = "Печать";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.referenceToolStripMenuItem.Text = "Справка";
            // 
            // instructionToolStripMenuItem
            // 
            this.instructionToolStripMenuItem.Name = "instructionToolStripMenuItem";
            this.instructionToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.instructionToolStripMenuItem.Text = "Руководство пользователя";
            this.instructionToolStripMenuItem.Click += new System.EventHandler(this.instructionToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.informationToolStripMenuItem.Text = "Информация о разработчике";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // imagesTabs
            // 
            this.imagesTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesTabs.ImageStream")));
            this.imagesTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imagesTabs.Images.SetKeyName(0, "nostesPicture.png");
            this.imagesTabs.Images.SetKeyName(1, "plansPicture.png");
            this.imagesTabs.Images.SetKeyName(2, "settingsPicture.png");
            // 
            // settings
            // 
            this.settings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settings.Controls.Add(this.sortSettingsBox);
            this.settings.Controls.Add(this.applySettingsBtn);
            this.settings.Controls.Add(this.fontSettingsBox);
            this.settings.ImageIndex = 2;
            this.settings.Location = new System.Drawing.Point(40, 4);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(715, 409);
            this.settings.TabIndex = 2;
            this.settings.UseVisualStyleBackColor = true;
            // 
            // sortSettingsBox
            // 
            this.sortSettingsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sortSettingsBox.Controls.Add(this.sortPlansSettingsRBtnsPanel);
            this.sortSettingsBox.Controls.Add(this.sortNotesSettingsRBtnsPanel);
            this.sortSettingsBox.Controls.Add(this.noteSortSettingsLabel);
            this.sortSettingsBox.Controls.Add(this.planSortSettingsLabel);
            this.sortSettingsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortSettingsBox.Location = new System.Drawing.Point(8, 89);
            this.sortSettingsBox.Margin = new System.Windows.Forms.Padding(8, 5, 5, 0);
            this.sortSettingsBox.Name = "sortSettingsBox";
            this.sortSettingsBox.Padding = new System.Windows.Forms.Padding(0);
            this.sortSettingsBox.Size = new System.Drawing.Size(257, 79);
            this.sortSettingsBox.TabIndex = 11;
            this.sortSettingsBox.TabStop = false;
            this.sortSettingsBox.Text = "Сортировка при запуске";
            // 
            // sortPlansSettingsRBtnsPanel
            // 
            this.sortPlansSettingsRBtnsPanel.Controls.Add(this.sortPlansNameSettingsRBtn);
            this.sortPlansSettingsRBtnsPanel.Controls.Add(this.sortPlansDateSettingsRBtn);
            this.sortPlansSettingsRBtnsPanel.Location = new System.Drawing.Point(95, 48);
            this.sortPlansSettingsRBtnsPanel.Name = "sortPlansSettingsRBtnsPanel";
            this.sortPlansSettingsRBtnsPanel.Size = new System.Drawing.Size(159, 21);
            this.sortPlansSettingsRBtnsPanel.TabIndex = 12;
            // 
            // sortPlansNameSettingsRBtn
            // 
            this.sortPlansNameSettingsRBtn.AutoSize = true;
            this.sortPlansNameSettingsRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sortPlansNameSettingsRBtn.Location = new System.Drawing.Point(2, -2);
            this.sortPlansNameSettingsRBtn.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.sortPlansNameSettingsRBtn.Name = "sortPlansNameSettingsRBtn";
            this.sortPlansNameSettingsRBtn.Size = new System.Drawing.Size(90, 21);
            this.sortPlansNameSettingsRBtn.TabIndex = 11;
            this.sortPlansNameSettingsRBtn.TabStop = true;
            this.sortPlansNameSettingsRBtn.Text = "Название";
            this.sortPlansNameSettingsRBtn.UseVisualStyleBackColor = true;
            // 
            // sortPlansDateSettingsRBtn
            // 
            this.sortPlansDateSettingsRBtn.AutoSize = true;
            this.sortPlansDateSettingsRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sortPlansDateSettingsRBtn.Location = new System.Drawing.Point(96, 0);
            this.sortPlansDateSettingsRBtn.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.sortPlansDateSettingsRBtn.Name = "sortPlansDateSettingsRBtn";
            this.sortPlansDateSettingsRBtn.Size = new System.Drawing.Size(60, 21);
            this.sortPlansDateSettingsRBtn.TabIndex = 12;
            this.sortPlansDateSettingsRBtn.TabStop = true;
            this.sortPlansDateSettingsRBtn.Text = "Дата";
            this.sortPlansDateSettingsRBtn.UseVisualStyleBackColor = true;
            // 
            // sortNotesSettingsRBtnsPanel
            // 
            this.sortNotesSettingsRBtnsPanel.Controls.Add(this.sortNotesNameSettingsRBtn);
            this.sortNotesSettingsRBtnsPanel.Controls.Add(this.sortNotesDateSettingsRBtn);
            this.sortNotesSettingsRBtnsPanel.Location = new System.Drawing.Point(95, 19);
            this.sortNotesSettingsRBtnsPanel.Name = "sortNotesSettingsRBtnsPanel";
            this.sortNotesSettingsRBtnsPanel.Size = new System.Drawing.Size(159, 21);
            this.sortNotesSettingsRBtnsPanel.TabIndex = 4;
            // 
            // sortNotesNameSettingsRBtn
            // 
            this.sortNotesNameSettingsRBtn.AutoSize = true;
            this.sortNotesNameSettingsRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sortNotesNameSettingsRBtn.Location = new System.Drawing.Point(2, 0);
            this.sortNotesNameSettingsRBtn.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.sortNotesNameSettingsRBtn.Name = "sortNotesNameSettingsRBtn";
            this.sortNotesNameSettingsRBtn.Size = new System.Drawing.Size(90, 21);
            this.sortNotesNameSettingsRBtn.TabIndex = 11;
            this.sortNotesNameSettingsRBtn.TabStop = true;
            this.sortNotesNameSettingsRBtn.Text = "Название";
            this.sortNotesNameSettingsRBtn.UseVisualStyleBackColor = true;
            // 
            // sortNotesDateSettingsRBtn
            // 
            this.sortNotesDateSettingsRBtn.AutoSize = true;
            this.sortNotesDateSettingsRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sortNotesDateSettingsRBtn.Location = new System.Drawing.Point(96, 0);
            this.sortNotesDateSettingsRBtn.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.sortNotesDateSettingsRBtn.Name = "sortNotesDateSettingsRBtn";
            this.sortNotesDateSettingsRBtn.Size = new System.Drawing.Size(60, 21);
            this.sortNotesDateSettingsRBtn.TabIndex = 12;
            this.sortNotesDateSettingsRBtn.TabStop = true;
            this.sortNotesDateSettingsRBtn.Text = "Дата";
            this.sortNotesDateSettingsRBtn.UseVisualStyleBackColor = true;
            // 
            // noteSortSettingsLabel
            // 
            this.noteSortSettingsLabel.AutoSize = true;
            this.noteSortSettingsLabel.Location = new System.Drawing.Point(5, 21);
            this.noteSortSettingsLabel.Margin = new System.Windows.Forms.Padding(5);
            this.noteSortSettingsLabel.Name = "noteSortSettingsLabel";
            this.noteSortSettingsLabel.Size = new System.Drawing.Size(64, 17);
            this.noteSortSettingsLabel.TabIndex = 0;
            this.noteSortSettingsLabel.Text = "Заметки";
            // 
            // planSortSettingsLabel
            // 
            this.planSortSettingsLabel.AutoSize = true;
            this.planSortSettingsLabel.Location = new System.Drawing.Point(5, 48);
            this.planSortSettingsLabel.Margin = new System.Windows.Forms.Padding(5);
            this.planSortSettingsLabel.Name = "planSortSettingsLabel";
            this.planSortSettingsLabel.Size = new System.Drawing.Size(52, 17);
            this.planSortSettingsLabel.TabIndex = 3;
            this.planSortSettingsLabel.Text = "Планы";
            // 
            // applySettingsBtn
            // 
            this.applySettingsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.applySettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.applySettingsBtn.Location = new System.Drawing.Point(8, 171);
            this.applySettingsBtn.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.applySettingsBtn.Name = "applySettingsBtn";
            this.applySettingsBtn.Size = new System.Drawing.Size(110, 45);
            this.applySettingsBtn.TabIndex = 10;
            this.applySettingsBtn.Text = "Применить";
            this.applySettingsBtn.UseVisualStyleBackColor = true;
            this.applySettingsBtn.Click += new System.EventHandler(this.applySettingsBtn_Click);
            // 
            // fontSettingsBox
            // 
            this.fontSettingsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fontSettingsBox.Controls.Add(this.textsFontSize);
            this.fontSettingsBox.Controls.Add(this.generalFontSize);
            this.fontSettingsBox.Controls.Add(this.textsFontNameText);
            this.fontSettingsBox.Controls.Add(this.generalFontNameText);
            this.fontSettingsBox.Controls.Add(this.generalFontLabel);
            this.fontSettingsBox.Controls.Add(this.textslFontLabel);
            this.fontSettingsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontSettingsBox.Location = new System.Drawing.Point(8, 5);
            this.fontSettingsBox.Margin = new System.Windows.Forms.Padding(8, 5, 5, 0);
            this.fontSettingsBox.Name = "fontSettingsBox";
            this.fontSettingsBox.Padding = new System.Windows.Forms.Padding(0);
            this.fontSettingsBox.Size = new System.Drawing.Size(695, 79);
            this.fontSettingsBox.TabIndex = 5;
            this.fontSettingsBox.TabStop = false;
            this.fontSettingsBox.Text = "Шрифт";
            // 
            // textsFontSize
            // 
            this.textsFontSize.FormattingEnabled = true;
            this.textsFontSize.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.textsFontSize.Location = new System.Drawing.Point(413, 45);
            this.textsFontSize.Margin = new System.Windows.Forms.Padding(5);
            this.textsFontSize.Name = "textsFontSize";
            this.textsFontSize.Size = new System.Drawing.Size(277, 24);
            this.textsFontSize.TabIndex = 7;
            // 
            // generalFontSize
            // 
            this.generalFontSize.FormattingEnabled = true;
            this.generalFontSize.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.generalFontSize.Location = new System.Drawing.Point(413, 18);
            this.generalFontSize.Margin = new System.Windows.Forms.Padding(5);
            this.generalFontSize.Name = "generalFontSize";
            this.generalFontSize.Size = new System.Drawing.Size(277, 24);
            this.generalFontSize.TabIndex = 6;
            // 
            // textsFontNameText
            // 
            this.textsFontNameText.BackColor = System.Drawing.Color.White;
            this.textsFontNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textsFontNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textsFontNameText.Location = new System.Drawing.Point(145, 46);
            this.textsFontNameText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 0);
            this.textsFontNameText.MaxLength = 100;
            this.textsFontNameText.Name = "textsFontNameText";
            this.textsFontNameText.Size = new System.Drawing.Size(258, 23);
            this.textsFontNameText.TabIndex = 5;
            this.textsFontNameText.TextChanged += new System.EventHandler(this.textsFontNameText_TextChanged);
            // 
            // generalFontNameText
            // 
            this.generalFontNameText.BackColor = System.Drawing.Color.White;
            this.generalFontNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generalFontNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generalFontNameText.Location = new System.Drawing.Point(145, 19);
            this.generalFontNameText.Margin = new System.Windows.Forms.Padding(5);
            this.generalFontNameText.MaxLength = 100;
            this.generalFontNameText.Name = "generalFontNameText";
            this.generalFontNameText.Size = new System.Drawing.Size(258, 23);
            this.generalFontNameText.TabIndex = 4;
            this.generalFontNameText.TextChanged += new System.EventHandler(this.generalFontNameText_TextChanged);
            // 
            // generalFontLabel
            // 
            this.generalFontLabel.AutoSize = true;
            this.generalFontLabel.Location = new System.Drawing.Point(5, 21);
            this.generalFontLabel.Margin = new System.Windows.Forms.Padding(5);
            this.generalFontLabel.Name = "generalFontLabel";
            this.generalFontLabel.Size = new System.Drawing.Size(54, 17);
            this.generalFontLabel.TabIndex = 0;
            this.generalFontLabel.Text = "Общий";
            // 
            // textslFontLabel
            // 
            this.textslFontLabel.AutoSize = true;
            this.textslFontLabel.Location = new System.Drawing.Point(5, 48);
            this.textslFontLabel.Margin = new System.Windows.Forms.Padding(5);
            this.textslFontLabel.Name = "textslFontLabel";
            this.textslFontLabel.Size = new System.Drawing.Size(130, 17);
            this.textslFontLabel.TabIndex = 3;
            this.textslFontLabel.Text = "В текстовых полях";
            // 
            // plans
            // 
            this.plans.Controls.Add(this.splitContainerPlans);
            this.plans.ImageIndex = 1;
            this.plans.Location = new System.Drawing.Point(40, 4);
            this.plans.Name = "plans";
            this.plans.Size = new System.Drawing.Size(715, 409);
            this.plans.TabIndex = 1;
            this.plans.UseVisualStyleBackColor = true;
            // 
            // splitContainerPlans
            // 
            this.splitContainerPlans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPlans.IsSplitterFixed = true;
            this.splitContainerPlans.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPlans.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerPlans.Name = "splitContainerPlans";
            // 
            // splitContainerPlans.Panel1
            // 
            this.splitContainerPlans.Panel1.Controls.Add(this.deletePointBtn);
            this.splitContainerPlans.Panel1.Controls.Add(this.createNewPointBtn);
            this.splitContainerPlans.Panel1.Controls.Add(this.createNewPlanBtn);
            this.splitContainerPlans.Panel1.Controls.Add(this.copyPlanBtn);
            this.splitContainerPlans.Panel1.Controls.Add(this.clearPlanBtn);
            this.splitContainerPlans.Panel1.Controls.Add(this.savePlanButton);
            this.splitContainerPlans.Panel1.Controls.Add(this.pointsPlanBox);
            this.splitContainerPlans.Panel1.Controls.Add(this.datePlanBox);
            this.splitContainerPlans.Panel1.Controls.Add(this.namePlanBox);
            // 
            // splitContainerPlans.Panel2
            // 
            this.splitContainerPlans.Panel2.Controls.Add(this.sortListBoxPlansDateRBtn);
            this.splitContainerPlans.Panel2.Controls.Add(this.sortListBoxPlansNameRBtn);
            this.splitContainerPlans.Panel2.Controls.Add(this.sortListBoxPlansLabel);
            this.splitContainerPlans.Panel2.Controls.Add(this.deleteListBoxPlansBtn);
            this.splitContainerPlans.Panel2.Controls.Add(this.groupListPlansBox);
            this.splitContainerPlans.Size = new System.Drawing.Size(715, 409);
            this.splitContainerPlans.SplitterDistance = 385;
            this.splitContainerPlans.SplitterWidth = 1;
            this.splitContainerPlans.TabIndex = 0;
            // 
            // deletePointBtn
            // 
            this.deletePointBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deletePointBtn.Location = new System.Drawing.Point(193, 321);
            this.deletePointBtn.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.deletePointBtn.Name = "deletePointBtn";
            this.deletePointBtn.Size = new System.Drawing.Size(180, 27);
            this.deletePointBtn.TabIndex = 16;
            this.deletePointBtn.Text = "Удалить пункт";
            this.deletePointBtn.UseVisualStyleBackColor = true;
            this.deletePointBtn.Click += new System.EventHandler(this.deletePointBtn_Click);
            // 
            // createNewPointBtn
            // 
            this.createNewPointBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createNewPointBtn.Location = new System.Drawing.Point(8, 321);
            this.createNewPointBtn.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.createNewPointBtn.Name = "createNewPointBtn";
            this.createNewPointBtn.Size = new System.Drawing.Size(180, 27);
            this.createNewPointBtn.TabIndex = 15;
            this.createNewPointBtn.Text = "Добавить пункт";
            this.createNewPointBtn.UseVisualStyleBackColor = true;
            this.createNewPointBtn.Click += new System.EventHandler(this.createNewPointBtn_Click);
            // 
            // createNewPlanBtn
            // 
            this.createNewPlanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createNewPlanBtn.Location = new System.Drawing.Point(8, 354);
            this.createNewPlanBtn.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.createNewPlanBtn.Name = "createNewPlanBtn";
            this.createNewPlanBtn.Size = new System.Drawing.Size(20, 45);
            this.createNewPlanBtn.TabIndex = 13;
            this.createNewPlanBtn.Text = "+";
            this.createNewPlanBtn.UseVisualStyleBackColor = true;
            this.createNewPlanBtn.Click += new System.EventHandler(this.createNewPlanBtn_Click);
            // 
            // copyPlanBtn
            // 
            this.copyPlanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.copyPlanBtn.Location = new System.Drawing.Point(33, 354);
            this.copyPlanBtn.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.copyPlanBtn.Name = "copyPlanBtn";
            this.copyPlanBtn.Size = new System.Drawing.Size(110, 45);
            this.copyPlanBtn.TabIndex = 7;
            this.copyPlanBtn.Text = "Копировать";
            this.copyPlanBtn.UseVisualStyleBackColor = true;
            this.copyPlanBtn.Click += new System.EventHandler(this.copyPlanBtn_Click);
            // 
            // clearPlanBtn
            // 
            this.clearPlanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearPlanBtn.Location = new System.Drawing.Point(148, 354);
            this.clearPlanBtn.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.clearPlanBtn.Name = "clearPlanBtn";
            this.clearPlanBtn.Size = new System.Drawing.Size(110, 45);
            this.clearPlanBtn.TabIndex = 8;
            this.clearPlanBtn.Text = "Очистить";
            this.clearPlanBtn.UseVisualStyleBackColor = true;
            this.clearPlanBtn.Click += new System.EventHandler(this.clearPlanBtn_Click);
            // 
            // savePlanButton
            // 
            this.savePlanButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.savePlanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.savePlanButton.Location = new System.Drawing.Point(263, 354);
            this.savePlanButton.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.savePlanButton.Name = "savePlanButton";
            this.savePlanButton.Size = new System.Drawing.Size(110, 45);
            this.savePlanButton.TabIndex = 9;
            this.savePlanButton.Text = "Сохранить";
            this.savePlanButton.UseVisualStyleBackColor = true;
            this.savePlanButton.Click += new System.EventHandler(this.savePlanButton_Click);
            // 
            // pointsPlanBox
            // 
            this.pointsPlanBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pointsPlanBox.Controls.Add(this.listBoxPoints);
            this.pointsPlanBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsPlanBox.Location = new System.Drawing.Point(8, 58);
            this.pointsPlanBox.Name = "pointsPlanBox";
            this.pointsPlanBox.Padding = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.pointsPlanBox.Size = new System.Drawing.Size(365, 257);
            this.pointsPlanBox.TabIndex = 12;
            this.pointsPlanBox.TabStop = false;
            this.pointsPlanBox.Text = "Пункты";
            // 
            // listBoxPoints
            // 
            this.listBoxPoints.BackColor = System.Drawing.Color.White;
            this.listBoxPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPoints.FormattingEnabled = true;
            this.listBoxPoints.ItemHeight = 16;
            this.listBoxPoints.Location = new System.Drawing.Point(10, 22);
            this.listBoxPoints.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxPoints.Name = "listBoxPoints";
            this.listBoxPoints.Size = new System.Drawing.Size(349, 229);
            this.listBoxPoints.TabIndex = 0;
            // 
            // datePlanBox
            // 
            this.datePlanBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePlanBox.Controls.Add(this.textDatePlan);
            this.datePlanBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePlanBox.Location = new System.Drawing.Point(193, 5);
            this.datePlanBox.Margin = new System.Windows.Forms.Padding(0);
            this.datePlanBox.Name = "datePlanBox";
            this.datePlanBox.Padding = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.datePlanBox.Size = new System.Drawing.Size(180, 50);
            this.datePlanBox.TabIndex = 11;
            this.datePlanBox.TabStop = false;
            this.datePlanBox.Text = "Дата";
            // 
            // textDatePlan
            // 
            this.textDatePlan.AsciiOnly = true;
            this.textDatePlan.BackColor = System.Drawing.Color.White;
            this.textDatePlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDatePlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDatePlan.Location = new System.Drawing.Point(10, 22);
            this.textDatePlan.Mask = "00-00-0000";
            this.textDatePlan.Name = "textDatePlan";
            this.textDatePlan.Size = new System.Drawing.Size(164, 16);
            this.textDatePlan.TabIndex = 1;
            this.textDatePlan.Leave += new System.EventHandler(this.textDatePlan_Leave);
            // 
            // namePlanBox
            // 
            this.namePlanBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namePlanBox.Controls.Add(this.textNamePlan);
            this.namePlanBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namePlanBox.Location = new System.Drawing.Point(8, 5);
            this.namePlanBox.Margin = new System.Windows.Forms.Padding(0);
            this.namePlanBox.Name = "namePlanBox";
            this.namePlanBox.Padding = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.namePlanBox.Size = new System.Drawing.Size(180, 50);
            this.namePlanBox.TabIndex = 10;
            this.namePlanBox.TabStop = false;
            this.namePlanBox.Text = "Название";
            // 
            // textNamePlan
            // 
            this.textNamePlan.BackColor = System.Drawing.Color.White;
            this.textNamePlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNamePlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNamePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNamePlan.Location = new System.Drawing.Point(10, 22);
            this.textNamePlan.MaxLength = 40;
            this.textNamePlan.Name = "textNamePlan";
            this.textNamePlan.Size = new System.Drawing.Size(164, 16);
            this.textNamePlan.TabIndex = 1;
            this.textNamePlan.TextChanged += new System.EventHandler(this.textNamePlan_TextChanged);
            // 
            // sortListBoxPlansDateRBtn
            // 
            this.sortListBoxPlansDateRBtn.AutoSize = true;
            this.sortListBoxPlansDateRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sortListBoxPlansDateRBtn.Location = new System.Drawing.Point(130, 331);
            this.sortListBoxPlansDateRBtn.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.sortListBoxPlansDateRBtn.Name = "sortListBoxPlansDateRBtn";
            this.sortListBoxPlansDateRBtn.Size = new System.Drawing.Size(60, 21);
            this.sortListBoxPlansDateRBtn.TabIndex = 11;
            this.sortListBoxPlansDateRBtn.TabStop = true;
            this.sortListBoxPlansDateRBtn.Text = "Дата";
            this.sortListBoxPlansDateRBtn.UseVisualStyleBackColor = true;
            this.sortListBoxPlansDateRBtn.CheckedChanged += new System.EventHandler(this.sortListBoxPlansDateRBtn_CheckedChanged);
            // 
            // sortListBoxPlansNameRBtn
            // 
            this.sortListBoxPlansNameRBtn.AutoSize = true;
            this.sortListBoxPlansNameRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sortListBoxPlansNameRBtn.Location = new System.Drawing.Point(130, 307);
            this.sortListBoxPlansNameRBtn.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.sortListBoxPlansNameRBtn.Name = "sortListBoxPlansNameRBtn";
            this.sortListBoxPlansNameRBtn.Size = new System.Drawing.Size(90, 21);
            this.sortListBoxPlansNameRBtn.TabIndex = 10;
            this.sortListBoxPlansNameRBtn.TabStop = true;
            this.sortListBoxPlansNameRBtn.Text = "Название";
            this.sortListBoxPlansNameRBtn.UseVisualStyleBackColor = true;
            this.sortListBoxPlansNameRBtn.CheckedChanged += new System.EventHandler(this.sortListBoxPlansNameRBtn_CheckedChanged);
            // 
            // sortListBoxPlansLabel
            // 
            this.sortListBoxPlansLabel.AutoSize = true;
            this.sortListBoxPlansLabel.Location = new System.Drawing.Point(8, 321);
            this.sortListBoxPlansLabel.Name = "sortListBoxPlansLabel";
            this.sortListBoxPlansLabel.Size = new System.Drawing.Size(117, 17);
            this.sortListBoxPlansLabel.TabIndex = 9;
            this.sortListBoxPlansLabel.Text = "Сортировать по:";
            // 
            // deleteListBoxPlansBtn
            // 
            this.deleteListBoxPlansBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteListBoxPlansBtn.Location = new System.Drawing.Point(8, 357);
            this.deleteListBoxPlansBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.deleteListBoxPlansBtn.Name = "deleteListBoxPlansBtn";
            this.deleteListBoxPlansBtn.Size = new System.Drawing.Size(311, 45);
            this.deleteListBoxPlansBtn.TabIndex = 8;
            this.deleteListBoxPlansBtn.Text = "Удалить";
            this.deleteListBoxPlansBtn.UseVisualStyleBackColor = true;
            this.deleteListBoxPlansBtn.Click += new System.EventHandler(this.deleteListBoxPlansBtn_Click);
            // 
            // groupListPlansBox
            // 
            this.groupListPlansBox.Controls.Add(this.listBoxPlans);
            this.groupListPlansBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupListPlansBox.Location = new System.Drawing.Point(8, 5);
            this.groupListPlansBox.Name = "groupListPlansBox";
            this.groupListPlansBox.Padding = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.groupListPlansBox.Size = new System.Drawing.Size(311, 297);
            this.groupListPlansBox.TabIndex = 6;
            this.groupListPlansBox.TabStop = false;
            this.groupListPlansBox.Text = "Планы";
            // 
            // listBoxPlans
            // 
            this.listBoxPlans.BackColor = System.Drawing.Color.White;
            this.listBoxPlans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPlans.FormattingEnabled = true;
            this.listBoxPlans.ItemHeight = 16;
            this.listBoxPlans.Location = new System.Drawing.Point(10, 22);
            this.listBoxPlans.Name = "listBoxPlans";
            this.listBoxPlans.Size = new System.Drawing.Size(295, 269);
            this.listBoxPlans.TabIndex = 0;
            this.listBoxPlans.SelectedIndexChanged += new System.EventHandler(this.listBoxPlans_SelectedIndexChanged);
            // 
            // notes
            // 
            this.notes.Controls.Add(this.splitContainerNotes);
            this.notes.ImageIndex = 0;
            this.notes.Location = new System.Drawing.Point(40, 4);
            this.notes.Margin = new System.Windows.Forms.Padding(0);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(715, 409);
            this.notes.TabIndex = 0;
            this.notes.UseVisualStyleBackColor = true;
            // 
            // splitContainerNotes
            // 
            this.splitContainerNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerNotes.IsSplitterFixed = true;
            this.splitContainerNotes.Location = new System.Drawing.Point(0, 0);
            this.splitContainerNotes.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerNotes.Name = "splitContainerNotes";
            // 
            // splitContainerNotes.Panel1
            // 
            this.splitContainerNotes.Panel1.Controls.Add(this.createNewNoteBtn);
            this.splitContainerNotes.Panel1.Controls.Add(this.copyNoteBtn);
            this.splitContainerNotes.Panel1.Controls.Add(this.clearNoteBtn);
            this.splitContainerNotes.Panel1.Controls.Add(this.saveNoteBtn);
            this.splitContainerNotes.Panel1.Controls.Add(this.textNoteBox);
            this.splitContainerNotes.Panel1.Controls.Add(this.dateNoteBox);
            this.splitContainerNotes.Panel1.Controls.Add(this.nameNoteBox);
            // 
            // splitContainerNotes.Panel2
            // 
            this.splitContainerNotes.Panel2.Controls.Add(this.sortListBoxNotesLabel);
            this.splitContainerNotes.Panel2.Controls.Add(this.sortListBoxNotesDateRBtn);
            this.splitContainerNotes.Panel2.Controls.Add(this.sortListBoxNotesNameRBtn);
            this.splitContainerNotes.Panel2.Controls.Add(this.deleteListBoxNotesBtn);
            this.splitContainerNotes.Panel2.Controls.Add(this.groupListNotesBox);
            this.splitContainerNotes.Size = new System.Drawing.Size(715, 409);
            this.splitContainerNotes.SplitterDistance = 385;
            this.splitContainerNotes.SplitterWidth = 1;
            this.splitContainerNotes.TabIndex = 0;
            // 
            // createNewNoteBtn
            // 
            this.createNewNoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createNewNoteBtn.Location = new System.Drawing.Point(8, 354);
            this.createNewNoteBtn.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.createNewNoteBtn.Name = "createNewNoteBtn";
            this.createNewNoteBtn.Size = new System.Drawing.Size(20, 45);
            this.createNewNoteBtn.TabIndex = 4;
            this.createNewNoteBtn.Text = "+";
            this.createNewNoteBtn.UseVisualStyleBackColor = true;
            this.createNewNoteBtn.Click += new System.EventHandler(this.createNewNoteBtn_Click);
            // 
            // copyNoteBtn
            // 
            this.copyNoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.copyNoteBtn.Location = new System.Drawing.Point(33, 354);
            this.copyNoteBtn.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.copyNoteBtn.Name = "copyNoteBtn";
            this.copyNoteBtn.Size = new System.Drawing.Size(110, 45);
            this.copyNoteBtn.TabIndex = 1;
            this.copyNoteBtn.Text = "Копировать";
            this.copyNoteBtn.UseVisualStyleBackColor = true;
            this.copyNoteBtn.Click += new System.EventHandler(this.copyNoteBtn_Click);
            // 
            // clearNoteBtn
            // 
            this.clearNoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearNoteBtn.Location = new System.Drawing.Point(148, 354);
            this.clearNoteBtn.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.clearNoteBtn.Name = "clearNoteBtn";
            this.clearNoteBtn.Size = new System.Drawing.Size(110, 45);
            this.clearNoteBtn.TabIndex = 2;
            this.clearNoteBtn.Text = "Очистить";
            this.clearNoteBtn.UseVisualStyleBackColor = true;
            this.clearNoteBtn.Click += new System.EventHandler(this.clearNoteBtn_Click);
            // 
            // saveNoteBtn
            // 
            this.saveNoteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveNoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveNoteBtn.Location = new System.Drawing.Point(263, 354);
            this.saveNoteBtn.Margin = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.saveNoteBtn.Name = "saveNoteBtn";
            this.saveNoteBtn.Size = new System.Drawing.Size(110, 45);
            this.saveNoteBtn.TabIndex = 3;
            this.saveNoteBtn.Text = "Сохранить";
            this.saveNoteBtn.UseVisualStyleBackColor = true;
            this.saveNoteBtn.Click += new System.EventHandler(this.saveNoteButton_Click);
            // 
            // textNoteBox
            // 
            this.textNoteBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textNoteBox.Controls.Add(this.mainTextNote);
            this.textNoteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNoteBox.Location = new System.Drawing.Point(8, 58);
            this.textNoteBox.Name = "textNoteBox";
            this.textNoteBox.Padding = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.textNoteBox.Size = new System.Drawing.Size(365, 290);
            this.textNoteBox.TabIndex = 2;
            this.textNoteBox.TabStop = false;
            this.textNoteBox.Text = "Текст";
            // 
            // mainTextNote
            // 
            this.mainTextNote.BackColor = System.Drawing.Color.White;
            this.mainTextNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTextNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextNote.Location = new System.Drawing.Point(10, 22);
            this.mainTextNote.Margin = new System.Windows.Forms.Padding(0);
            this.mainTextNote.MaxLength = 10000;
            this.mainTextNote.Name = "mainTextNote";
            this.mainTextNote.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.mainTextNote.Size = new System.Drawing.Size(349, 262);
            this.mainTextNote.TabIndex = 0;
            this.mainTextNote.Text = "";
            this.mainTextNote.TextChanged += new System.EventHandler(this.mainTextNote_TextChanged);
            // 
            // dateNoteBox
            // 
            this.dateNoteBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateNoteBox.Controls.Add(this.textDateNote);
            this.dateNoteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateNoteBox.Location = new System.Drawing.Point(193, 5);
            this.dateNoteBox.Margin = new System.Windows.Forms.Padding(0);
            this.dateNoteBox.Name = "dateNoteBox";
            this.dateNoteBox.Padding = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.dateNoteBox.Size = new System.Drawing.Size(180, 50);
            this.dateNoteBox.TabIndex = 1;
            this.dateNoteBox.TabStop = false;
            this.dateNoteBox.Text = "Дата";
            // 
            // textDateNote
            // 
            this.textDateNote.AsciiOnly = true;
            this.textDateNote.BackColor = System.Drawing.Color.White;
            this.textDateNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDateNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDateNote.Location = new System.Drawing.Point(10, 22);
            this.textDateNote.Mask = "00-00-0000";
            this.textDateNote.Name = "textDateNote";
            this.textDateNote.Size = new System.Drawing.Size(164, 16);
            this.textDateNote.TabIndex = 0;
            this.textDateNote.Leave += new System.EventHandler(this.textDataNote_Leave);
            // 
            // nameNoteBox
            // 
            this.nameNoteBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameNoteBox.Controls.Add(this.textNameNote);
            this.nameNoteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameNoteBox.Location = new System.Drawing.Point(8, 5);
            this.nameNoteBox.Margin = new System.Windows.Forms.Padding(5);
            this.nameNoteBox.Name = "nameNoteBox";
            this.nameNoteBox.Padding = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.nameNoteBox.Size = new System.Drawing.Size(180, 50);
            this.nameNoteBox.TabIndex = 0;
            this.nameNoteBox.TabStop = false;
            this.nameNoteBox.Text = "Название";
            // 
            // textNameNote
            // 
            this.textNameNote.BackColor = System.Drawing.Color.White;
            this.textNameNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNameNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNameNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNameNote.Location = new System.Drawing.Point(10, 22);
            this.textNameNote.MaxLength = 40;
            this.textNameNote.Name = "textNameNote";
            this.textNameNote.Size = new System.Drawing.Size(164, 16);
            this.textNameNote.TabIndex = 1;
            this.textNameNote.TextChanged += new System.EventHandler(this.textNameNote_TextChanged);
            // 
            // sortListBoxNotesLabel
            // 
            this.sortListBoxNotesLabel.AutoSize = true;
            this.sortListBoxNotesLabel.Location = new System.Drawing.Point(8, 321);
            this.sortListBoxNotesLabel.Name = "sortListBoxNotesLabel";
            this.sortListBoxNotesLabel.Size = new System.Drawing.Size(117, 17);
            this.sortListBoxNotesLabel.TabIndex = 6;
            this.sortListBoxNotesLabel.Text = "Сортировать по:";
            // 
            // sortListBoxNotesDateRBtn
            // 
            this.sortListBoxNotesDateRBtn.AutoSize = true;
            this.sortListBoxNotesDateRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sortListBoxNotesDateRBtn.Location = new System.Drawing.Point(130, 331);
            this.sortListBoxNotesDateRBtn.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.sortListBoxNotesDateRBtn.Name = "sortListBoxNotesDateRBtn";
            this.sortListBoxNotesDateRBtn.Size = new System.Drawing.Size(60, 21);
            this.sortListBoxNotesDateRBtn.TabIndex = 5;
            this.sortListBoxNotesDateRBtn.TabStop = true;
            this.sortListBoxNotesDateRBtn.Text = "Дата";
            this.sortListBoxNotesDateRBtn.UseVisualStyleBackColor = true;
            this.sortListBoxNotesDateRBtn.CheckedChanged += new System.EventHandler(this.sortListBoxNotesDateRBtn_CheckedChanged);
            // 
            // sortListBoxNotesNameRBtn
            // 
            this.sortListBoxNotesNameRBtn.AutoSize = true;
            this.sortListBoxNotesNameRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sortListBoxNotesNameRBtn.Location = new System.Drawing.Point(130, 307);
            this.sortListBoxNotesNameRBtn.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.sortListBoxNotesNameRBtn.Name = "sortListBoxNotesNameRBtn";
            this.sortListBoxNotesNameRBtn.Size = new System.Drawing.Size(90, 21);
            this.sortListBoxNotesNameRBtn.TabIndex = 4;
            this.sortListBoxNotesNameRBtn.TabStop = true;
            this.sortListBoxNotesNameRBtn.Text = "Название";
            this.sortListBoxNotesNameRBtn.UseVisualStyleBackColor = true;
            this.sortListBoxNotesNameRBtn.CheckedChanged += new System.EventHandler(this.sortListBoxNotesNameRBtn_CheckedChanged);
            // 
            // deleteListBoxNotesBtn
            // 
            this.deleteListBoxNotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteListBoxNotesBtn.Location = new System.Drawing.Point(8, 357);
            this.deleteListBoxNotesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.deleteListBoxNotesBtn.Name = "deleteListBoxNotesBtn";
            this.deleteListBoxNotesBtn.Size = new System.Drawing.Size(311, 45);
            this.deleteListBoxNotesBtn.TabIndex = 3;
            this.deleteListBoxNotesBtn.Text = "Удалить";
            this.deleteListBoxNotesBtn.UseVisualStyleBackColor = true;
            this.deleteListBoxNotesBtn.Click += new System.EventHandler(this.deleteListBoxNotesBtn_Click);
            // 
            // groupListNotesBox
            // 
            this.groupListNotesBox.Controls.Add(this.listBoxNotes);
            this.groupListNotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupListNotesBox.Location = new System.Drawing.Point(8, 5);
            this.groupListNotesBox.Name = "groupListNotesBox";
            this.groupListNotesBox.Padding = new System.Windows.Forms.Padding(10, 6, 6, 6);
            this.groupListNotesBox.Size = new System.Drawing.Size(311, 297);
            this.groupListNotesBox.TabIndex = 0;
            this.groupListNotesBox.TabStop = false;
            this.groupListNotesBox.Text = "Заметки";
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.BackColor = System.Drawing.Color.White;
            this.listBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.ItemHeight = 16;
            this.listBoxNotes.Location = new System.Drawing.Point(10, 22);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(295, 269);
            this.listBoxNotes.TabIndex = 0;
            this.listBoxNotes.SelectedIndexChanged += new System.EventHandler(this.listBoxNotes_SelectedIndexChanged);
            // 
            // mainTabs
            // 
            this.mainTabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainTabs.Controls.Add(this.notes);
            this.mainTabs.Controls.Add(this.plans);
            this.mainTabs.Controls.Add(this.settings);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mainTabs.ImageList = this.imagesTabs;
            this.mainTabs.ItemSize = new System.Drawing.Size(40, 36);
            this.mainTabs.Location = new System.Drawing.Point(0, 24);
            this.mainTabs.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabs.Multiline = true;
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.Padding = new System.Drawing.Point(2, 4);
            this.mainTabs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(759, 417);
            this.mainTabs.TabIndex = 1;
            // 
            // noteBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 441);
            this.Controls.Add(this.mainTabs);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "noteBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Блокнот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.noteBookForm_FormClosing);
            this.Load += new System.EventHandler(this.noteBookForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.settings.ResumeLayout(false);
            this.sortSettingsBox.ResumeLayout(false);
            this.sortSettingsBox.PerformLayout();
            this.sortPlansSettingsRBtnsPanel.ResumeLayout(false);
            this.sortPlansSettingsRBtnsPanel.PerformLayout();
            this.sortNotesSettingsRBtnsPanel.ResumeLayout(false);
            this.sortNotesSettingsRBtnsPanel.PerformLayout();
            this.fontSettingsBox.ResumeLayout(false);
            this.fontSettingsBox.PerformLayout();
            this.plans.ResumeLayout(false);
            this.splitContainerPlans.Panel1.ResumeLayout(false);
            this.splitContainerPlans.Panel2.ResumeLayout(false);
            this.splitContainerPlans.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPlans)).EndInit();
            this.splitContainerPlans.ResumeLayout(false);
            this.pointsPlanBox.ResumeLayout(false);
            this.datePlanBox.ResumeLayout(false);
            this.datePlanBox.PerformLayout();
            this.namePlanBox.ResumeLayout(false);
            this.namePlanBox.PerformLayout();
            this.groupListPlansBox.ResumeLayout(false);
            this.notes.ResumeLayout(false);
            this.splitContainerNotes.Panel1.ResumeLayout(false);
            this.splitContainerNotes.Panel2.ResumeLayout(false);
            this.splitContainerNotes.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNotes)).EndInit();
            this.splitContainerNotes.ResumeLayout(false);
            this.textNoteBox.ResumeLayout(false);
            this.dateNoteBox.ResumeLayout(false);
            this.dateNoteBox.PerformLayout();
            this.nameNoteBox.ResumeLayout(false);
            this.nameNoteBox.PerformLayout();
            this.groupListNotesBox.ResumeLayout(false);
            this.mainTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.TabPage plans;
        private System.Windows.Forms.SplitContainer splitContainerPlans;
        private System.Windows.Forms.TabPage notes;
        private System.Windows.Forms.SplitContainer splitContainerNotes;
        private System.Windows.Forms.Button clearNoteBtn;
        private System.Windows.Forms.Button saveNoteBtn;
        private System.Windows.Forms.RichTextBox mainTextNote;
        private System.Windows.Forms.GroupBox dateNoteBox;
        private System.Windows.Forms.GroupBox nameNoteBox;
        private System.Windows.Forms.TextBox textNameNote;
        private System.Windows.Forms.RadioButton sortListBoxNotesDateRBtn;
        private System.Windows.Forms.RadioButton sortListBoxNotesNameRBtn;
        private System.Windows.Forms.Button deleteListBoxNotesBtn;
        private System.Windows.Forms.GroupBox groupListNotesBox;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.Button copyPlanBtn;
        private System.Windows.Forms.Button clearPlanBtn;
        private System.Windows.Forms.Button savePlanButton;
        private System.Windows.Forms.GroupBox pointsPlanBox;
        private System.Windows.Forms.GroupBox datePlanBox;
        private System.Windows.Forms.GroupBox namePlanBox;
        private System.Windows.Forms.TextBox textNamePlan;
        private System.Windows.Forms.Button deleteListBoxPlansBtn;
        private System.Windows.Forms.GroupBox groupListPlansBox;
        private System.Windows.Forms.ListBox listBoxPlans;
        private System.Windows.Forms.ListBox listBoxPoints;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button applySettingsBtn;
        private System.Windows.Forms.GroupBox fontSettingsBox;
        private System.Windows.Forms.Label textslFontLabel;
        private System.Windows.Forms.Label generalFontLabel;
        private System.Windows.Forms.TextBox generalFontNameText;
        private System.Windows.Forms.ComboBox textsFontSize;
        private System.Windows.Forms.ComboBox generalFontSize;
        private System.Windows.Forms.TextBox textsFontNameText;
        private System.Windows.Forms.GroupBox textNoteBox;
        private System.Windows.Forms.Button createNewPlanBtn;
        private System.Windows.Forms.Button createNewNoteBtn;
        private System.Windows.Forms.MaskedTextBox textDateNote;
        private System.Windows.Forms.Label sortListBoxNotesLabel;
        private System.Windows.Forms.Label sortListBoxPlansLabel;
        private System.Windows.Forms.RadioButton sortListBoxPlansNameRBtn;
        private System.Windows.Forms.RadioButton sortListBoxPlansDateRBtn;
        private System.Windows.Forms.MaskedTextBox textDatePlan;
        private System.Windows.Forms.Button deletePointBtn;
        private System.Windows.Forms.Button createNewPointBtn;
        private System.Windows.Forms.GroupBox sortSettingsBox;
        private System.Windows.Forms.Label noteSortSettingsLabel;
        private System.Windows.Forms.Label planSortSettingsLabel;
        private System.Windows.Forms.RadioButton sortNotesDateSettingsRBtn;
        private System.Windows.Forms.RadioButton sortNotesNameSettingsRBtn;
        private System.Windows.Forms.Panel sortPlansSettingsRBtnsPanel;
        private System.Windows.Forms.RadioButton sortPlansNameSettingsRBtn;
        private System.Windows.Forms.RadioButton sortPlansDateSettingsRBtn;
        private System.Windows.Forms.Panel sortNotesSettingsRBtnsPanel;
        private System.Windows.Forms.ImageList imagesTabs;
        private System.Windows.Forms.Button copyNoteBtn;
    }
}

