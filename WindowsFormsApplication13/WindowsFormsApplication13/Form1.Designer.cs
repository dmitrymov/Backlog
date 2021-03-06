﻿using System.Drawing;
using System.Collections.Generic;
namespace WindowsFormsApplication13
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
        public System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        public bool isLoaded = false;
        public List<Index> updatedTaskIndexes = new List<Index>();
        public List<Index> updatedStoryIndexes = new List<Index>();
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
       public void RedrawGraph2()
        {


            /*Chart1.Series.Add("Series2");
            Chart1.Series["Series2"].ChartType = SeriesChartType.Column;
            Chart1.Series["Series2"].Points.AddY(20);
            Chart1.Series["Series2"].ChartArea = "ChartArea1";*/
            MathManager math = new MathManager();
            series1.Points.Clear();
            series2.Points.Clear();

            System.Windows.Forms.DataVisualization.Charting.DataPoint[] expectedPoints = new System.Windows.Forms.DataVisualization.Charting.DataPoint[2];
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] realPoints = new System.Windows.Forms.DataVisualization.Charting.DataPoint[56];
            expectedPoints[0] = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            expectedPoints[1] = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);

            // updating points values of expected graph from DB

            math.updateEstimatedGraphPoints(expectedPoints);
            //System.Windows.Forms.DataVisualization.Charting.DataPoint[] realPoints = new System.Windows.Forms.DataVisualization.Charting.DataPoint[56];
            realPoints[0] = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);/////////////////////////////////
            for (int i = 0; i < realPoints.Length; i++) // initalizating the realPoints values to zeros
            {
                realPoints[i] = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            }

            math.updateRealGraphPoints(realPoints);

            series1.Points.Add(expectedPoints[0]);
            series1.Points.Add(expectedPoints[1]);

            series2.Points.Add(realPoints[0]);////////////////////////////////
            for (int i = 0; i < realPoints.Length; i++)
            {
                series2.Points.Add(realPoints[i]);
            }
            Refresh();
        }



       public void RedrawGraph()
       {
           MathManager math = new MathManager();
           series1.Points.Clear();
           series2.Points.Clear();

           System.Windows.Forms.DataVisualization.Charting.DataPoint[] expectedPoints = new System.Windows.Forms.DataVisualization.Charting.DataPoint[2];
           System.Windows.Forms.DataVisualization.Charting.DataPoint[] realPoints = new System.Windows.Forms.DataVisualization.Charting.DataPoint[56];
           expectedPoints[0] = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
           expectedPoints[1] = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);

           // updating points values of expected graph from DB

           math.updateEstimatedGraphPoints(expectedPoints);
           //System.Windows.Forms.DataVisualization.Charting.DataPoint[] realPoints = new System.Windows.Forms.DataVisualization.Charting.DataPoint[56];
           realPoints[0] = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);/////////////////////////////////
           for (int i = 0; i < realPoints.Length; i++) // initalizating the realPoints values to zeros
           {
               realPoints[i] = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
           }

           math.updateRealGraphPoints(realPoints);

           series1.Points.Add(expectedPoints[0]);
           series1.Points.Add(expectedPoints[1]);

           series2.Points.Add(realPoints[0]);////////////////////////////////
           for (int i = 0; i < realPoints.Length; i++)
           {
               series2.Points.Add(realPoints[i]);
           }
           Refresh();
       }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.storyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.storyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApplication13.Database1DataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.storyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.storyDataGridView = new System.Windows.Forms.DataGridView();
            this.storyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storyPriorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storyOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storyCurrentSprintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storyDemoDESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storyDemoPICDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.storyDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storyWorkStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChangeBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.storyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new WindowsFormsApplication13.Database1DataSet2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.taskDataGridView = new System.Windows.Forms.DataGridView();
            this.taskStoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskPriorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskOvnerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApplication13.Database1DataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewAoutputDataAnliz = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBuffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExpectedWorkingHouer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActualWorkHoures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRisks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programmerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMamberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSprintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storyTableAdapter = new WindowsFormsApplication13.Database1DataSet1TableAdapters.StoryTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication13.Database1DataSet1TableAdapters.TableAdapterManager();
            this.programmerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programmerTableAdapter = new WindowsFormsApplication13.Database1DataSet1TableAdapters.ProgrammerTableAdapter();
            this.sprintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprintTableAdapter = new WindowsFormsApplication13.Database1DataSet1TableAdapters.SprintTableAdapter();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTableAdapter = new WindowsFormsApplication13.Database1DataSet1TableAdapters.TaskTableAdapter();
            this.taskTableAdapter1 = new WindowsFormsApplication13.Database1DataSetTableAdapters.TaskTableAdapter();
            this.storyTableAdapter1 = new WindowsFormsApplication13.Database1DataSet2TableAdapters.StoryTableAdapter();
            this.programmerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingNavigator)).BeginInit();
            this.storyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAoutputDataAnliz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // storyBindingNavigator
            // 
            this.storyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.storyBindingNavigator.BindingSource = this.storyBindingSource;
            this.storyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.storyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.storyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.storyBindingNavigatorSaveItem});
            this.storyBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.storyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.storyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.storyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.storyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.storyBindingNavigator.Name = "storyBindingNavigator";
            this.storyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.storyBindingNavigator.Size = new System.Drawing.Size(1055, 25);
            this.storyBindingNavigator.TabIndex = 0;
            this.storyBindingNavigator.Text = "bindingNavigator1";
            this.storyBindingNavigator.RefreshItems += new System.EventHandler(this.storyBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // storyBindingSource
            // 
            this.storyBindingSource.DataMember = "Story";
            this.storyBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // storyBindingNavigatorSaveItem
            // 
            this.storyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.storyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("storyBindingNavigatorSaveItem.Image")));
            this.storyBindingNavigatorSaveItem.Name = "storyBindingNavigatorSaveItem";
            this.storyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.storyBindingNavigatorSaveItem.Text = "Save Data";
            this.storyBindingNavigatorSaveItem.Click += new System.EventHandler(this.storyBindingNavigatorSaveItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1055, 517);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.storyDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1047, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // storyDataGridView
            // 
            this.storyDataGridView.AutoGenerateColumns = false;
            this.storyDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.storyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storyIDDataGridViewTextBoxColumn,
            this.storyPriorityDataGridViewTextBoxColumn,
            this.storyOwnerDataGridViewTextBoxColumn,
            this.storyCurrentSprintDataGridViewTextBoxColumn,
            this.storyDemoDESDataGridViewTextBoxColumn,
            this.storyDemoPICDataGridViewImageColumn,
            this.storyDescriptionDataGridViewTextBoxColumn,
            this.storyWorkStatusDataGridViewTextBoxColumn,
            this.ColumnChangeBtn,
            this.ColumnDelBtn});
            this.storyDataGridView.DataSource = this.storyBindingSource1;
            this.storyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storyDataGridView.Location = new System.Drawing.Point(3, 3);
            this.storyDataGridView.Name = "storyDataGridView";
            this.storyDataGridView.Size = new System.Drawing.Size(1041, 485);
            this.storyDataGridView.TabIndex = 0;
            this.storyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.storyDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_StoryCellValueChanged);
            // 
            // storyIDDataGridViewTextBoxColumn
            // 
            this.storyIDDataGridViewTextBoxColumn.DataPropertyName = "Story_ID";
            this.storyIDDataGridViewTextBoxColumn.HeaderText = "Story ID";
            this.storyIDDataGridViewTextBoxColumn.Name = "storyIDDataGridViewTextBoxColumn";
            this.storyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.storyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // storyPriorityDataGridViewTextBoxColumn
            // 
            this.storyPriorityDataGridViewTextBoxColumn.DataPropertyName = "Story_Priority";
            this.storyPriorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.storyPriorityDataGridViewTextBoxColumn.Name = "storyPriorityDataGridViewTextBoxColumn";
            // 
            // storyOwnerDataGridViewTextBoxColumn
            // 
            this.storyOwnerDataGridViewTextBoxColumn.HeaderText = "Story Owner";
            this.storyOwnerDataGridViewTextBoxColumn.Name = "storyOwnerDataGridViewTextBoxColumn";
            this.storyOwnerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // storyCurrentSprintDataGridViewTextBoxColumn
            // 
            this.storyCurrentSprintDataGridViewTextBoxColumn.DataPropertyName = "Story_Current_Sprint";
            this.storyCurrentSprintDataGridViewTextBoxColumn.HeaderText = "Sprint";
            this.storyCurrentSprintDataGridViewTextBoxColumn.Name = "storyCurrentSprintDataGridViewTextBoxColumn";
            // 
            // storyDemoDESDataGridViewTextBoxColumn
            // 
            this.storyDemoDESDataGridViewTextBoxColumn.DataPropertyName = "Story_Demo_DES";
            this.storyDemoDESDataGridViewTextBoxColumn.HeaderText = "Story_Demo_DES";
            this.storyDemoDESDataGridViewTextBoxColumn.Name = "storyDemoDESDataGridViewTextBoxColumn";
            this.storyDemoDESDataGridViewTextBoxColumn.Visible = false;
            // 
            // storyDemoPICDataGridViewImageColumn
            // 
            this.storyDemoPICDataGridViewImageColumn.DataPropertyName = "Story_Demo_PIC";
            this.storyDemoPICDataGridViewImageColumn.HeaderText = "Story_Demo_PIC";
            this.storyDemoPICDataGridViewImageColumn.Name = "storyDemoPICDataGridViewImageColumn";
            this.storyDemoPICDataGridViewImageColumn.Visible = false;
            // 
            // storyDescriptionDataGridViewTextBoxColumn
            // 
            this.storyDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Story_Description";
            this.storyDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.storyDescriptionDataGridViewTextBoxColumn.Name = "storyDescriptionDataGridViewTextBoxColumn";
            this.storyDescriptionDataGridViewTextBoxColumn.Width = 500;
            // 
            // storyWorkStatusDataGridViewTextBoxColumn
            // 
            this.storyWorkStatusDataGridViewTextBoxColumn.DataPropertyName = "Story_Work_Status";
            this.storyWorkStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.storyWorkStatusDataGridViewTextBoxColumn.Name = "storyWorkStatusDataGridViewTextBoxColumn";
            // 
            // ColumnChangeBtn
            // 
            this.ColumnChangeBtn.HeaderText = "Change";
            this.ColumnChangeBtn.Name = "ColumnChangeBtn";
            this.ColumnChangeBtn.Width = 50;
            // 
            // ColumnDelBtn
            // 
            this.ColumnDelBtn.HeaderText = "Delete";
            this.ColumnDelBtn.Name = "ColumnDelBtn";
            this.ColumnDelBtn.Width = 50;
            // 
            // storyBindingSource1
            // 
            this.storyBindingSource1.DataMember = "Story";
            this.storyBindingSource1.DataSource = this.database1DataSet2;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.taskDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1047, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // taskDataGridView
            // 
            this.taskDataGridView.AutoGenerateColumns = false;
            this.taskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskStoryIDDataGridViewTextBoxColumn,
            this.taskIDDataGridViewTextBoxColumn,
            this.taskPriorityDataGridViewTextBoxColumn,
            this.taskOvnerIdDataGridViewTextBoxColumn,
            this.ColumnOwnerName,
            this.taskDescriptionDataGridViewTextBoxColumn});
            this.taskDataGridView.DataSource = this.taskBindingSource1;
            this.taskDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskDataGridView.Location = new System.Drawing.Point(3, 3);
            this.taskDataGridView.Name = "taskDataGridView";
            this.taskDataGridView.Size = new System.Drawing.Size(1041, 485);
            this.taskDataGridView.TabIndex = 0;
            this.taskDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.taskDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_TaskCellValueChanged);
			this.taskDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskDataGridView_CellEndEdit);
            // 
            // taskStoryIDDataGridViewTextBoxColumn
            // 
            this.taskStoryIDDataGridViewTextBoxColumn.DataPropertyName = "Task_Story_ID";
            this.taskStoryIDDataGridViewTextBoxColumn.HeaderText = "Story ID";
            this.taskStoryIDDataGridViewTextBoxColumn.Name = "taskStoryIDDataGridViewTextBoxColumn";
            this.taskStoryIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // taskIDDataGridViewTextBoxColumn
            // 
            this.taskIDDataGridViewTextBoxColumn.DataPropertyName = "Task_ID";
            this.taskIDDataGridViewTextBoxColumn.HeaderText = "Task ID";
            this.taskIDDataGridViewTextBoxColumn.Name = "taskIDDataGridViewTextBoxColumn";
            this.taskIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.taskIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // taskPriorityDataGridViewTextBoxColumn
            // 
            this.taskPriorityDataGridViewTextBoxColumn.DataPropertyName = "Task_Priority";
            this.taskPriorityDataGridViewTextBoxColumn.HeaderText = "Task Priority";
            this.taskPriorityDataGridViewTextBoxColumn.Name = "taskPriorityDataGridViewTextBoxColumn";
            this.taskPriorityDataGridViewTextBoxColumn.Width = 50;
            // 
            // taskOvnerIdDataGridViewTextBoxColumn
            // 
            this.taskOvnerIdDataGridViewTextBoxColumn.DataPropertyName = "Task_Ovner_Id";
            this.taskOvnerIdDataGridViewTextBoxColumn.HeaderText = "Ovner ID";
            this.taskOvnerIdDataGridViewTextBoxColumn.Name = "taskOvnerIdDataGridViewTextBoxColumn";
            this.taskOvnerIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // ColumnOwnerName
            // 
            this.ColumnOwnerName.HeaderText = "Owner Name";
            this.ColumnOwnerName.Name = "ColumnOwnerName";
            // 
            // taskDescriptionDataGridViewTextBoxColumn
            // 
            this.taskDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Task_Description";
            this.taskDescriptionDataGridViewTextBoxColumn.HeaderText = "Task Description";
            this.taskDescriptionDataGridViewTextBoxColumn.Name = "taskDescriptionDataGridViewTextBoxColumn";
            this.taskDescriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // taskBindingSource1
            // 
            this.taskBindingSource1.DataMember = "Task";
            this.taskBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1047, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sprint Proggress";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 20;
            chartArea1.Area3DStyle.PointGapDepth = 20;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Estimated progress";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Real progress";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1041, 448);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1047, 491);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Story Proggress";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewAoutputDataAnliz);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1047, 491);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "summary";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAoutputDataAnliz
            // 
            this.dataGridViewAoutputDataAnliz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAoutputDataAnliz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnBuffer,
            this.ColumnExpectedWorkingHouer,
            this.ColumnActualWorkHoures,
            this.ColumnRisks});
            this.dataGridViewAoutputDataAnliz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAoutputDataAnliz.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAoutputDataAnliz.Name = "dataGridViewAoutputDataAnliz";
            this.dataGridViewAoutputDataAnliz.Size = new System.Drawing.Size(1041, 485);
            this.dataGridViewAoutputDataAnliz.TabIndex = 1;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnBuffer
            // 
            this.ColumnBuffer.HeaderText = "Buffer";
            this.ColumnBuffer.Name = "ColumnBuffer";
            // 
            // ColumnExpectedWorkingHouer
            // 
            this.ColumnExpectedWorkingHouer.HeaderText = "Expected Working Houers";
            this.ColumnExpectedWorkingHouer.Name = "ColumnExpectedWorkingHouer";
            this.ColumnExpectedWorkingHouer.ReadOnly = true;
            // 
            // ColumnActualWorkHoures
            // 
            this.ColumnActualWorkHoures.HeaderText = "Actual Working Houres";
            this.ColumnActualWorkHoures.Name = "ColumnActualWorkHoures";
            this.ColumnActualWorkHoures.ReadOnly = true;
            // 
            // ColumnRisks
            // 
            this.ColumnRisks.HeaderText = "Risk";
            this.ColumnRisks.Name = "ColumnRisks";
            this.ColumnRisks.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamToolStripMenuItem,
            this.sprintToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.bugsReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberToolStripMenuItem,
            this.removeMamberToolStripMenuItem,
            this.teamSettingsToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.teamToolStripMenuItem.Text = "Team";
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addMemberToolStripMenuItem.Text = "Add member";
            this.addMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // removeMamberToolStripMenuItem
            // 
            this.removeMamberToolStripMenuItem.Name = "removeMamberToolStripMenuItem";
            this.removeMamberToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.removeMamberToolStripMenuItem.Text = "Remove mamber";
            // 
            // teamSettingsToolStripMenuItem
            // 
            this.teamSettingsToolStripMenuItem.Name = "teamSettingsToolStripMenuItem";
            this.teamSettingsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.teamSettingsToolStripMenuItem.Text = "Team settings";
            this.teamSettingsToolStripMenuItem.Click += new System.EventHandler(this.teamSettingsToolStripMenuItem_Click);
            // 
            // sprintToolStripMenuItem
            // 
            this.sprintToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSprintToolStripMenuItem,
            this.editSprintToolStripMenuItem});
            this.sprintToolStripMenuItem.Name = "sprintToolStripMenuItem";
            this.sprintToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sprintToolStripMenuItem.Text = "Sprint";
            // 
            // newSprintToolStripMenuItem
            // 
            this.newSprintToolStripMenuItem.Name = "newSprintToolStripMenuItem";
            this.newSprintToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newSprintToolStripMenuItem.Text = "New Sprint";
            this.newSprintToolStripMenuItem.Click += new System.EventHandler(this.newSprintToolStripMenuItem_Click);
            // 
            // editSprintToolStripMenuItem
            // 
            this.editSprintToolStripMenuItem.Name = "editSprintToolStripMenuItem";
            this.editSprintToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editSprintToolStripMenuItem.Text = "Edit Sprint";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowOptionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // windowOptionsToolStripMenuItem
            // 
            this.windowOptionsToolStripMenuItem.Name = "windowOptionsToolStripMenuItem";
            this.windowOptionsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.windowOptionsToolStripMenuItem.Text = "Window options";
            // 
            // bugsReportToolStripMenuItem
            // 
            this.bugsReportToolStripMenuItem.Name = "bugsReportToolStripMenuItem";
            this.bugsReportToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.bugsReportToolStripMenuItem.Text = "Report Bugs ";
            this.bugsReportToolStripMenuItem.Click += new System.EventHandler(this.bugsReportToolStripMenuItem_Click);
            // 
            // storyTableAdapter
            // 
            this.storyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DateTableAdapter = null;
            this.tableAdapterManager.Programmer1TableAdapter = null;
            this.tableAdapterManager.ProgrammerTableAdapter = null;
            this.tableAdapterManager.SprintTableAdapter = null;
            this.tableAdapterManager.Story_In_SprintTableAdapter = null;
            this.tableAdapterManager.StoryTableAdapter = this.storyTableAdapter;
            this.tableAdapterManager.TaskTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication13.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Work_hoursTableAdapter = null;
            // 
            // programmerBindingSource
            // 
            this.programmerBindingSource.DataMember = "Programmer";
            this.programmerBindingSource.DataSource = this.database1DataSet1;
            // 
            // programmerTableAdapter
            // 
            this.programmerTableAdapter.ClearBeforeFill = true;
            // 
            // sprintBindingSource
            // 
            this.sprintBindingSource.DataMember = "Sprint";
            this.sprintBindingSource.DataSource = this.database1DataSet1;
            // 
            // sprintTableAdapter
            // 
            this.sprintTableAdapter.ClearBeforeFill = true;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.database1DataSet1;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // taskTableAdapter1
            // 
            this.taskTableAdapter1.ClearBeforeFill = true;
            // 
            // storyTableAdapter1
            // 
            this.storyTableAdapter1.ClearBeforeFill = true;
            // 
            // programmerBindingSource1
            // 
            this.programmerBindingSource1.DataMember = "Programmer";
            this.programmerBindingSource1.DataSource = this.database1DataSet1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 566);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.storyBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingNavigator)).EndInit();
            this.storyBindingNavigator.ResumeLayout(false);
            this.storyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAoutputDataAnliz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            isLoaded = true;
        }

        #endregion

        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource storyBindingSource;
        private Database1DataSet1TableAdapters.StoryTableAdapter storyTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator storyBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton storyBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource programmerBindingSource;
        private Database1DataSet1TableAdapters.ProgrammerTableAdapter programmerTableAdapter;
        private System.Windows.Forms.BindingSource sprintBindingSource;
        private Database1DataSet1TableAdapters.SprintTableAdapter sprintTableAdapter;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMamberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSprintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowOptionsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private Database1DataSet1TableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem teamSettingsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage5;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource taskBindingSource1;
        private Database1DataSetTableAdapters.TaskTableAdapter taskTableAdapter1;
        private System.Windows.Forms.DataGridView storyDataGridView;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource storyBindingSource1;
        private Database1DataSet2TableAdapters.StoryTableAdapter storyTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewAoutputDataAnliz;
        private System.Windows.Forms.BindingSource programmerBindingSource1;
        private System.Windows.Forms.BindingSource programmerBindingSource2;
        private System.Windows.Forms.ToolStripMenuItem bugsReportToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBuffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExpectedWorkingHouer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActualWorkHoures;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRisks;
        private System.Windows.Forms.DataGridView taskDataGridView;

        public System.Windows.Forms.DataGridView TaskDataGridView
        {
            get { return taskDataGridView; }
            set { taskDataGridView = value; }
        }
        private System.Windows.Forms.DataGridViewTextBoxColumn taskStoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskPriorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskOvnerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn storyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storyPriorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storyOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storyCurrentSprintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storyDemoDESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn storyDemoPICDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storyDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storyWorkStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnChangeBtn;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelBtn;

    }
}

