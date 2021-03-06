﻿namespace TabularEditor
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Crad.Windows.Forms.Actions.ActionList actionsMain;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.actToggleDisplayFolders = new TabularEditor.UI.UIModelAction();
            this.actToggleHidden = new TabularEditor.UI.UIModelAction();
            this.actToggleMetadataOrder = new TabularEditor.UI.UIModelAction();
            this.actToggleMeasures = new TabularEditor.UI.UIModelAction();
            this.actToggleColumns = new TabularEditor.UI.UIModelAction();
            this.actToggleHierarchies = new TabularEditor.UI.UIModelAction();
            this.actToggleInfoColumns = new TabularEditor.UI.UIModelAction();
            this.actToggleFilter = new TabularEditor.UI.UIModelAction();
            this.actToggleAllObjectTypes = new TabularEditor.UI.UIModelAction();
            this.actExpressionAcceptEdit = new TabularEditor.UI.UIModelAction();
            this.actExpressionCancelEdit = new TabularEditor.UI.UIModelAction();
            this.actOpenFile = new Crad.Windows.Forms.Actions.Action();
            this.actOpenDB = new Crad.Windows.Forms.Actions.Action();
            this.actSave = new TabularEditor.UI.UIModelAction();
            this.actSaveAs = new TabularEditor.UI.UIModelAction();
            this.actSaveToFolder = new TabularEditor.UI.UIModelAction();
            this.actExit = new Crad.Windows.Forms.Actions.Action();
            this.actCollapseAll = new TabularEditor.UI.UIModelAction();
            this.actExpandAll = new TabularEditor.UI.UIModelAction();
            this.actDelete = new TabularEditor.UI.UIDeleteAction();
            this.actUndo = new TabularEditor.UI.Actions.UIUndoRedoAction();
            this.actRedo = new TabularEditor.UI.Actions.UIUndoRedoAction();
            this.actExpressionFormatDAX = new TabularEditor.UI.UIModelAction();
            this.actFind = new TabularEditor.UI.UIModelAction();
            this.actReplace = new TabularEditor.UI.UIModelAction();
            this.actExecuteScript = new TabularEditor.UI.UIModelAction();
            this.actDeploy = new TabularEditor.UI.UIModelAction();
            this.actSaveCustomAction = new Crad.Windows.Forms.Actions.Action();
            this.actCut = new TabularEditor.UI.Actions.CutAction();
            this.actCopy = new TabularEditor.UI.Actions.CopyAction();
            this.actPaste = new TabularEditor.UI.Actions.PasteAction();
            this.actSelectAll = new TabularEditor.UI.Actions.SelectAllAction();
            this.actComment = new Crad.Windows.Forms.Actions.Action();
            this.actUncomment = new Crad.Windows.Forms.Actions.Action();
            this.actNewModel = new Crad.Windows.Forms.Actions.Action();
            this.actOpenScript = new Crad.Windows.Forms.Actions.Action();
            this.actSaveScript = new Crad.Windows.Forms.Actions.Action();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fromDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.tbShowDisplayFolders = new System.Windows.Forms.ToolStripButton();
            this.tbShowHidden = new System.Windows.Forms.ToolStripButton();
            this.tbShowMeasures = new System.Windows.Forms.ToolStripButton();
            this.tbShowColumns = new System.Windows.Forms.ToolStripButton();
            this.tbShowHierarchies = new System.Windows.Forms.ToolStripButton();
            this.tbApplyFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metadataInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.btnReplace = new System.Windows.Forms.ToolStripButton();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatDAXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFormatDAX = new System.Windows.Forms.ToolStripButton();
            this.btnRun = new System.Windows.Forms.ToolStripButton();
            this.deployToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveCustomAction = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbShowAllObjectTypes = new System.Windows.Forms.ToolStripButton();
            this.showAllObjectTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSortAlphabetically = new System.Windows.Forms.ToolStripButton();
            this.sortAlphabeticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.saveToFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveScript = new System.Windows.Forms.ToolStripButton();
            this.btnOpenScript = new System.Windows.Forms.ToolStripButton();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbPerspective = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbTranslation = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvModel = new Aga.Controls.Tree.TreeViewAdv();
            this._colName = new Aga.Controls.Tree.TreeColumn();
            this._colType = new Aga.Controls.Tree.TreeColumn();
            this._colFormatString = new Aga.Controls.Tree.TreeColumn();
            this._colDataType = new Aga.Controls.Tree.TreeColumn();
            this._colDescription = new Aga.Controls.Tree.TreeColumn();
            this.nodeTextBox1 = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.nodeTextBox2 = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.nodeTextBox3 = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.nodeTextBox4 = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.toolTreeView = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFilter = new TabularEditor.ToolStripSpringTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtExpression = new FastColoredTextBoxNS.FastColoredTextBox();
            this.lblCurrentMeasure = new System.Windows.Forms.Label();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtAdvanced = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUndoErrors = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.samplesMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.customActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.propertyGrid1 = new TabularEditor.PropertyGridExtension.NavigatablePropertyGrid();
            this.tvMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblErrors = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblScriptStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.dAXExpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dynamicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestPracticeAnalyzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabularTreeImages = new System.Windows.Forms.ImageList(this.components);
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this._type = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this._formatString = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this._dataType = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this._description = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.treeColumn1 = new Aga.Controls.Tree.TreeColumn();
            this.ofdScript = new System.Windows.Forms.OpenFileDialog();
            this.sfdScript = new System.Windows.Forms.SaveFileDialog();
            actionsMain = new Crad.Windows.Forms.Actions.ActionList();
            ((System.ComponentModel.ISupportInitialize)(actionsMain)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolTreeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdvanced)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsMain
            // 
            actionsMain.Actions.Add(this.actToggleDisplayFolders);
            actionsMain.Actions.Add(this.actToggleHidden);
            actionsMain.Actions.Add(this.actToggleMetadataOrder);
            actionsMain.Actions.Add(this.actToggleMeasures);
            actionsMain.Actions.Add(this.actToggleColumns);
            actionsMain.Actions.Add(this.actToggleHierarchies);
            actionsMain.Actions.Add(this.actToggleInfoColumns);
            actionsMain.Actions.Add(this.actToggleFilter);
            actionsMain.Actions.Add(this.actToggleAllObjectTypes);
            actionsMain.Actions.Add(this.actExpressionAcceptEdit);
            actionsMain.Actions.Add(this.actExpressionCancelEdit);
            actionsMain.Actions.Add(this.actOpenFile);
            actionsMain.Actions.Add(this.actOpenDB);
            actionsMain.Actions.Add(this.actSave);
            actionsMain.Actions.Add(this.actSaveAs);
            actionsMain.Actions.Add(this.actSaveToFolder);
            actionsMain.Actions.Add(this.actExit);
            actionsMain.Actions.Add(this.actCollapseAll);
            actionsMain.Actions.Add(this.actExpandAll);
            actionsMain.Actions.Add(this.actDelete);
            actionsMain.Actions.Add(this.actUndo);
            actionsMain.Actions.Add(this.actRedo);
            actionsMain.Actions.Add(this.actExpressionFormatDAX);
            actionsMain.Actions.Add(this.actFind);
            actionsMain.Actions.Add(this.actReplace);
            actionsMain.Actions.Add(this.actExecuteScript);
            actionsMain.Actions.Add(this.actDeploy);
            actionsMain.Actions.Add(this.actSaveCustomAction);
            actionsMain.Actions.Add(this.actCut);
            actionsMain.Actions.Add(this.actCopy);
            actionsMain.Actions.Add(this.actPaste);
            actionsMain.Actions.Add(this.actSelectAll);
            actionsMain.Actions.Add(this.actComment);
            actionsMain.Actions.Add(this.actUncomment);
            actionsMain.Actions.Add(this.actNewModel);
            actionsMain.Actions.Add(this.actOpenScript);
            actionsMain.Actions.Add(this.actSaveScript);
            actionsMain.ContainerControl = this;
            // 
            // actToggleDisplayFolders
            // 
            this.actToggleDisplayFolders.Checked = true;
            this.actToggleDisplayFolders.CheckOnClick = true;
            this.actToggleDisplayFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.actToggleDisplayFolders.Enabled = false;
            this.actToggleDisplayFolders.Image = global::TabularEditor.Resources.FolderOpen;
            this.actToggleDisplayFolders.Text = "Display Folders";
            this.actToggleDisplayFolders.ToolTipText = "Show/hide display folders";
            this.actToggleDisplayFolders.Execute += new System.EventHandler(this.actViewOptions_Execute);
            // 
            // actToggleHidden
            // 
            this.actToggleHidden.CheckOnClick = true;
            this.actToggleHidden.Enabled = false;
            this.actToggleHidden.Image = global::TabularEditor.Resources.Hidden;
            this.actToggleHidden.Text = "Hidden Objects";
            this.actToggleHidden.ToolTipText = "Show/hide hidden objects";
            this.actToggleHidden.Execute += new System.EventHandler(this.actViewOptions_Execute);
            // 
            // actToggleMetadataOrder
            // 
            this.actToggleMetadataOrder.Checked = true;
            this.actToggleMetadataOrder.CheckOnClick = true;
            this.actToggleMetadataOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.actToggleMetadataOrder.Enabled = false;
            this.actToggleMetadataOrder.Image = global::TabularEditor.Resources.SortAscending_16x;
            this.actToggleMetadataOrder.Text = "Sort alphabetically";
            this.actToggleMetadataOrder.ToolTipText = "Toggle alphabetical/metadata ordering of items";
            this.actToggleMetadataOrder.Execute += new System.EventHandler(this.actViewOptions_Execute);
            // 
            // actToggleMeasures
            // 
            this.actToggleMeasures.Checked = true;
            this.actToggleMeasures.CheckOnClick = true;
            this.actToggleMeasures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.actToggleMeasures.Enabled = false;
            this.actToggleMeasures.Image = global::TabularEditor.Resources.Sigma;
            this.actToggleMeasures.Text = "Measures";
            this.actToggleMeasures.ToolTipText = "Show/hide measures";
            this.actToggleMeasures.Execute += new System.EventHandler(this.actViewOptions_Execute);
            // 
            // actToggleColumns
            // 
            this.actToggleColumns.Checked = true;
            this.actToggleColumns.CheckOnClick = true;
            this.actToggleColumns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.actToggleColumns.Enabled = false;
            this.actToggleColumns.Image = global::TabularEditor.Resources.Column;
            this.actToggleColumns.Text = "Columns";
            this.actToggleColumns.ToolTipText = "Show/hide columns";
            this.actToggleColumns.Execute += new System.EventHandler(this.actViewOptions_Execute);
            // 
            // actToggleHierarchies
            // 
            this.actToggleHierarchies.Checked = true;
            this.actToggleHierarchies.CheckOnClick = true;
            this.actToggleHierarchies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.actToggleHierarchies.Enabled = false;
            this.actToggleHierarchies.Image = global::TabularEditor.Resources.Hierarchy;
            this.actToggleHierarchies.Text = "Hierarchies";
            this.actToggleHierarchies.ToolTipText = "Show/hide hierarchies";
            this.actToggleHierarchies.Execute += new System.EventHandler(this.actViewOptions_Execute);
            // 
            // actToggleInfoColumns
            // 
            this.actToggleInfoColumns.CheckOnClick = true;
            this.actToggleInfoColumns.Image = global::TabularEditor.Resources.Columns;
            this.actToggleInfoColumns.Text = "Metadata Information";
            this.actToggleInfoColumns.ToolTipText = "Show/hide metadata information columns";
            this.actToggleInfoColumns.Execute += new System.EventHandler(this.actToggleInfoColumns_Execute);
            // 
            // actToggleFilter
            // 
            this.actToggleFilter.CheckOnClick = true;
            this.actToggleFilter.Image = global::TabularEditor.Resources.Filter;
            this.actToggleFilter.Text = "Filter";
            this.actToggleFilter.ToolTipText = "Filter objects by name";
            this.actToggleFilter.UpdateEx += new System.EventHandler<TabularEditor.UI.UpdateExEventArgs>(this.actToggleFilter_UpdateEx);
            this.actToggleFilter.Execute += new System.EventHandler(this.actViewOptions_Execute);
            // 
            // actToggleAllObjectTypes
            // 
            this.actToggleAllObjectTypes.Checked = true;
            this.actToggleAllObjectTypes.CheckOnClick = true;
            this.actToggleAllObjectTypes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.actToggleAllObjectTypes.Enabled = false;
            this.actToggleAllObjectTypes.Image = global::TabularEditor.Resources.ShowDetails_16x;
            this.actToggleAllObjectTypes.Text = "Show All Object Types";
            this.actToggleAllObjectTypes.ToolTipText = "Show/hide all object types (perspectives, roles, data sources, etc.) in addition " +
    "to tables";
            this.actToggleAllObjectTypes.Execute += new System.EventHandler(this.actViewOptions_Execute);
            // 
            // actExpressionAcceptEdit
            // 
            this.actExpressionAcceptEdit.Image = global::TabularEditor.Resources.Check;
            this.actExpressionAcceptEdit.Text = "Accept edit";
            this.actExpressionAcceptEdit.ToolTipText = "Accept changes";
            this.actExpressionAcceptEdit.UpdateEx += new System.EventHandler<TabularEditor.UI.UpdateExEventArgs>(this.actExpressionAcceptEdit_UpdateEx);
            this.actExpressionAcceptEdit.Execute += new System.EventHandler(this.actExpressionAcceptEdit_Execute);
            // 
            // actExpressionCancelEdit
            // 
            this.actExpressionCancelEdit.Image = global::TabularEditor.Resources.Cancel;
            this.actExpressionCancelEdit.Text = "Cancel edit";
            this.actExpressionCancelEdit.ToolTipText = "Cancel changes";
            this.actExpressionCancelEdit.UpdateEx += new System.EventHandler<TabularEditor.UI.UpdateExEventArgs>(this.actExpressionCancelEdit_UpdateEx);
            this.actExpressionCancelEdit.Execute += new System.EventHandler(this.actExpressionCancelEdit_Execute);
            // 
            // actOpenFile
            // 
            this.actOpenFile.Image = global::TabularEditor.Resources.Open;
            this.actOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.actOpenFile.Text = "From File...";
            this.actOpenFile.ToolTipText = "Open a Tabular Model from a Model.bim file or database.json folder structure";
            this.actOpenFile.Execute += new System.EventHandler(this.actOpenFile_Execute);
            // 
            // actOpenDB
            // 
            this.actOpenDB.Image = global::TabularEditor.Resources.CubeOpen;
            this.actOpenDB.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.actOpenDB.Text = "From DB...";
            this.actOpenDB.ToolTipText = "Open a Tabular Model from an existing database";
            this.actOpenDB.Execute += new System.EventHandler(this.btnConnect_Click);
            // 
            // actSave
            // 
            this.actSave.Image = global::TabularEditor.Resources.Save;
            this.actSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.actSave.Text = "Save .bim file";
            this.actSave.UpdateEx += new System.EventHandler<TabularEditor.UI.UpdateExEventArgs>(this.actSave_UpdateEx);
            this.actSave.Execute += new System.EventHandler(this.actSave_Execute);
            // 
            // actSaveAs
            // 
            this.actSaveAs.Text = "Save As...";
            this.actSaveAs.Execute += new System.EventHandler(this.actSaveAs_Execute);
            // 
            // actSaveToFolder
            // 
            this.actSaveToFolder.Text = "Save to Folder...";
            this.actSaveToFolder.Execute += new System.EventHandler(this.actSaveToFolder_Execute);
            // 
            // actExit
            // 
            this.actExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.actExit.Text = "Exit";
            this.actExit.Execute += new System.EventHandler(this.actExit_Execute);
            // 
            // actCollapseAll
            // 
            this.actCollapseAll.Image = global::TabularEditor.Resources.CollapseAll;
            this.actCollapseAll.Text = "Collapse All";
            this.actCollapseAll.Execute += new System.EventHandler(this.actCollapseExpand_Execute);
            // 
            // actExpandAll
            // 
            this.actExpandAll.Image = global::TabularEditor.Resources.ExpandAll;
            this.actExpandAll.Text = "Expand All";
            this.actExpandAll.Execute += new System.EventHandler(this.actCollapseExpand_Execute);
            // 
            // actDelete
            // 
            this.actDelete.Image = global::TabularEditor.Resources.Delete;
            this.actDelete.Text = "&Delete";
            this.actDelete.ToolTipText = "Delete";
            // 
            // actUndo
            // 
            this.actUndo.Kind = TabularEditor.UI.Actions.UndoRedo.Undo;
            this.actUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.actUndo.Text = "Undo";
            this.actUndo.Execute += new System.EventHandler(this.actUndoRedo_Execute);
            // 
            // actRedo
            // 
            this.actRedo.Kind = TabularEditor.UI.Actions.UndoRedo.Redo;
            this.actRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.actRedo.Text = "Redo";
            this.actRedo.Execute += new System.EventHandler(this.actUndoRedo_Execute);
            // 
            // actExpressionFormatDAX
            // 
            this.actExpressionFormatDAX.Image = global::TabularEditor.Resources.DAXFormatter;
            this.actExpressionFormatDAX.Text = "Format DAX";
            this.actExpressionFormatDAX.ToolTipText = "Format using www.daxformatter.com";
            this.actExpressionFormatDAX.UpdateEx += new System.EventHandler<TabularEditor.UI.UpdateExEventArgs>(this.actExpression_UpdateEx);
            this.actExpressionFormatDAX.Execute += new System.EventHandler(this.actExpressionFormatDAX_Execute);
            // 
            // actFind
            // 
            this.actFind.Image = global::TabularEditor.Resources.Find;
            this.actFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.actFind.Text = "Find";
            this.actFind.UpdateEx += new System.EventHandler<TabularEditor.UI.UpdateExEventArgs>(this.actExpression_UpdateEx);
            this.actFind.Execute += new System.EventHandler(this.actFind_Execute);
            // 
            // actReplace
            // 
            this.actReplace.Image = global::TabularEditor.Resources.Replace;
            this.actReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.actReplace.Text = "Replace";
            this.actReplace.UpdateEx += new System.EventHandler<TabularEditor.UI.UpdateExEventArgs>(this.actExpression_UpdateEx);
            this.actReplace.Execute += new System.EventHandler(this.actReplace_Execute);
            // 
            // actExecuteScript
            // 
            this.actExecuteScript.Image = global::TabularEditor.Resources.Run;
            this.actExecuteScript.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.actExecuteScript.Text = "Replace";
            this.actExecuteScript.Execute += new System.EventHandler(this.actExecuteScript_Execute);
            // 
            // actDeploy
            // 
            this.actDeploy.Image = global::TabularEditor.Resources.Deploy;
            this.actDeploy.Text = "Deploy...";
            this.actDeploy.ToolTipText = "Lets you deploy the currently loaded model to an SSAS Tabular Server.";
            this.actDeploy.Execute += new System.EventHandler(this.actDeploy_Execute);
            // 
            // actSaveCustomAction
            // 
            this.actSaveCustomAction.Image = global::TabularEditor.Resources.action_add_16xLG;
            this.actSaveCustomAction.Text = "Save as Custom Action...";
            this.actSaveCustomAction.Execute += new System.EventHandler(this.actSaveCustomAction_Execute);
            this.actSaveCustomAction.Update += new System.EventHandler(this.actSaveCustomAction_Update);
            // 
            // actCut
            // 
            this.actCut.Image = ((System.Drawing.Image)(resources.GetObject("actCut.Image")));
            this.actCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.actCut.Text = "Cu&t";
            this.actCut.ToolTipText = "Cut";
            // 
            // actCopy
            // 
            this.actCopy.Image = ((System.Drawing.Image)(resources.GetObject("actCopy.Image")));
            this.actCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.actCopy.Text = "&Copy";
            this.actCopy.ToolTipText = "Copy";
            // 
            // actPaste
            // 
            this.actPaste.Image = ((System.Drawing.Image)(resources.GetObject("actPaste.Image")));
            this.actPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.actPaste.Text = "&Paste";
            this.actPaste.ToolTipText = "Paste";
            // 
            // actSelectAll
            // 
            this.actSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad5)));
            this.actSelectAll.Text = "Select &All";
            this.actSelectAll.ToolTipText = "Select All";
            // 
            // actComment
            // 
            this.actComment.Image = global::TabularEditor.Resources.CommentCode_16x;
            this.actComment.Text = "Comment lines";
            this.actComment.ToolTipText = "Comment the selected lines";
            this.actComment.Execute += new System.EventHandler(this.actComment_Execute);
            this.actComment.Update += new System.EventHandler(this.CanComment);
            // 
            // actUncomment
            // 
            this.actUncomment.Image = global::TabularEditor.Resources.UncommentCode_16x;
            this.actUncomment.Text = "Uncomment Lines";
            this.actUncomment.ToolTipText = "Uncomment the selected lines";
            this.actUncomment.Execute += new System.EventHandler(this.actUncomment_Execute);
            this.actUncomment.Update += new System.EventHandler(this.CanComment);
            // 
            // actNewModel
            // 
            this.actNewModel.Text = "New model";
            this.actNewModel.ToolTipText = "Creates a new blank Model.bim file";
            this.actNewModel.Execute += new System.EventHandler(this.actNewModel_Execute);
            // 
            // actOpenScript
            // 
            this.actOpenScript.Image = global::TabularEditor.Resources.Open;
            this.actOpenScript.Text = "Open script";
            this.actOpenScript.ToolTipText = "Opens a C# script from a file";
            // 
            // actSaveScript
            // 
            this.actSaveScript.Image = global::TabularEditor.Resources.Save;
            this.actSaveScript.Text = "Save script";
            this.actSaveScript.ToolTipText = "Saves the script to a file";
            // 
            // toolStripButton8
            // 
            actionsMain.SetAction(this.toolStripButton8, this.actOpenFile);
            this.toolStripButton8.AutoToolTip = false;
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::TabularEditor.Resources.Open;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "From File...";
            this.toolStripButton8.ToolTipText = "Open a Tabular Model from a Model.bim file or database.json folder structure";
            // 
            // fileToolStripMenuItem1
            // 
            actionsMain.SetAction(this.fileToolStripMenuItem1, this.actOpenFile);
            this.fileToolStripMenuItem1.Image = global::TabularEditor.Resources.Open;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.fileToolStripMenuItem1.Text = "From File...";
            this.fileToolStripMenuItem1.ToolTipText = "Open a Tabular Model from a Model.bim file or database.json folder structure";
            // 
            // fromDBToolStripMenuItem
            // 
            actionsMain.SetAction(this.fromDBToolStripMenuItem, this.actOpenDB);
            this.fromDBToolStripMenuItem.Image = global::TabularEditor.Resources.CubeOpen;
            this.fromDBToolStripMenuItem.Name = "fromDBToolStripMenuItem";
            this.fromDBToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+O";
            this.fromDBToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.fromDBToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.fromDBToolStripMenuItem.Text = "From DB...";
            this.fromDBToolStripMenuItem.ToolTipText = "Open a Tabular Model from an existing database";
            // 
            // exitToolStripMenuItem
            // 
            actionsMain.SetAction(this.exitToolStripMenuItem, this.actExit);
            this.exitToolStripMenuItem.AutoToolTip = true;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnConnect
            // 
            actionsMain.SetAction(this.btnConnect, this.actOpenDB);
            this.btnConnect.AutoToolTip = false;
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConnect.Image = global::TabularEditor.Resources.CubeOpen;
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(23, 22);
            this.btnConnect.Text = "From DB...";
            this.btnConnect.ToolTipText = "Open a Tabular Model from an existing database";
            // 
            // tbShowDisplayFolders
            // 
            actionsMain.SetAction(this.tbShowDisplayFolders, this.actToggleDisplayFolders);
            this.tbShowDisplayFolders.AutoToolTip = false;
            this.tbShowDisplayFolders.Checked = true;
            this.tbShowDisplayFolders.CheckOnClick = true;
            this.tbShowDisplayFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbShowDisplayFolders.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbShowDisplayFolders.Enabled = false;
            this.tbShowDisplayFolders.Image = global::TabularEditor.Resources.FolderOpen;
            this.tbShowDisplayFolders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbShowDisplayFolders.Name = "tbShowDisplayFolders";
            this.tbShowDisplayFolders.Size = new System.Drawing.Size(23, 22);
            this.tbShowDisplayFolders.Text = "Display Folders";
            this.tbShowDisplayFolders.ToolTipText = "Show/hide display folders";
            // 
            // tbShowHidden
            // 
            actionsMain.SetAction(this.tbShowHidden, this.actToggleHidden);
            this.tbShowHidden.AutoToolTip = false;
            this.tbShowHidden.CheckOnClick = true;
            this.tbShowHidden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbShowHidden.Enabled = false;
            this.tbShowHidden.Image = global::TabularEditor.Resources.Hidden;
            this.tbShowHidden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbShowHidden.Name = "tbShowHidden";
            this.tbShowHidden.Size = new System.Drawing.Size(23, 22);
            this.tbShowHidden.Text = "Hidden Objects";
            this.tbShowHidden.ToolTipText = "Show/hide hidden objects";
            // 
            // tbShowMeasures
            // 
            actionsMain.SetAction(this.tbShowMeasures, this.actToggleMeasures);
            this.tbShowMeasures.AutoToolTip = false;
            this.tbShowMeasures.Checked = true;
            this.tbShowMeasures.CheckOnClick = true;
            this.tbShowMeasures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbShowMeasures.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbShowMeasures.Enabled = false;
            this.tbShowMeasures.Image = global::TabularEditor.Resources.Sigma;
            this.tbShowMeasures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbShowMeasures.Name = "tbShowMeasures";
            this.tbShowMeasures.Size = new System.Drawing.Size(23, 22);
            this.tbShowMeasures.Text = "Measures";
            this.tbShowMeasures.ToolTipText = "Show/hide measures";
            // 
            // tbShowColumns
            // 
            actionsMain.SetAction(this.tbShowColumns, this.actToggleColumns);
            this.tbShowColumns.AutoToolTip = false;
            this.tbShowColumns.Checked = true;
            this.tbShowColumns.CheckOnClick = true;
            this.tbShowColumns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbShowColumns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbShowColumns.Enabled = false;
            this.tbShowColumns.Image = global::TabularEditor.Resources.Column;
            this.tbShowColumns.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbShowColumns.Name = "tbShowColumns";
            this.tbShowColumns.Size = new System.Drawing.Size(23, 22);
            this.tbShowColumns.Text = "Columns";
            this.tbShowColumns.ToolTipText = "Show/hide columns";
            // 
            // tbShowHierarchies
            // 
            actionsMain.SetAction(this.tbShowHierarchies, this.actToggleHierarchies);
            this.tbShowHierarchies.AutoToolTip = false;
            this.tbShowHierarchies.Checked = true;
            this.tbShowHierarchies.CheckOnClick = true;
            this.tbShowHierarchies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbShowHierarchies.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbShowHierarchies.Enabled = false;
            this.tbShowHierarchies.Image = global::TabularEditor.Resources.Hierarchy;
            this.tbShowHierarchies.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbShowHierarchies.Name = "tbShowHierarchies";
            this.tbShowHierarchies.Size = new System.Drawing.Size(23, 22);
            this.tbShowHierarchies.Text = "Hierarchies";
            this.tbShowHierarchies.ToolTipText = "Show/hide hierarchies";
            // 
            // tbApplyFilter
            // 
            actionsMain.SetAction(this.tbApplyFilter, this.actToggleFilter);
            this.tbApplyFilter.AutoToolTip = false;
            this.tbApplyFilter.CheckOnClick = true;
            this.tbApplyFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbApplyFilter.Image = global::TabularEditor.Resources.Filter;
            this.tbApplyFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbApplyFilter.Name = "tbApplyFilter";
            this.tbApplyFilter.Size = new System.Drawing.Size(23, 22);
            this.tbApplyFilter.Text = "Filter";
            this.tbApplyFilter.ToolTipText = "Filter objects by name";
            // 
            // toolStripButton6
            // 
            actionsMain.SetAction(this.toolStripButton6, this.actToggleInfoColumns);
            this.toolStripButton6.AutoToolTip = false;
            this.toolStripButton6.CheckOnClick = true;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::TabularEditor.Resources.Columns;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Metadata Information";
            this.toolStripButton6.ToolTipText = "Show/hide metadata information columns";
            // 
            // btnSave
            // 
            actionsMain.SetAction(this.btnSave, this.actSave);
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::TabularEditor.Resources.Save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Save .bim file";
            // 
            // saveToolStripMenuItem
            // 
            actionsMain.SetAction(this.saveToolStripMenuItem, this.actSave);
            this.saveToolStripMenuItem.Image = global::TabularEditor.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToolStripMenuItem.Text = "Save .bim file";
            // 
            // saveAsToolStripMenuItem
            // 
            actionsMain.SetAction(this.saveAsToolStripMenuItem, this.actSaveAs);
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // undoToolStripMenuItem
            // 
            actionsMain.SetAction(this.undoToolStripMenuItem, this.actUndo);
            this.undoToolStripMenuItem.AutoToolTip = true;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            actionsMain.SetAction(this.redoToolStripMenuItem, this.actRedo);
            this.redoToolStripMenuItem.AutoToolTip = true;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Y";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // deleteToolStripMenuItem
            // 
            actionsMain.SetAction(this.deleteToolStripMenuItem, this.actDelete);
            this.deleteToolStripMenuItem.Image = global::TabularEditor.Resources.Delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "None";
            this.deleteToolStripMenuItem.ShowShortcutKeys = false;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.ToolTipText = "Delete";
            // 
            // displayFoldersToolStripMenuItem
            // 
            actionsMain.SetAction(this.displayFoldersToolStripMenuItem, this.actToggleDisplayFolders);
            this.displayFoldersToolStripMenuItem.Checked = true;
            this.displayFoldersToolStripMenuItem.CheckOnClick = true;
            this.displayFoldersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayFoldersToolStripMenuItem.Enabled = false;
            this.displayFoldersToolStripMenuItem.Image = global::TabularEditor.Resources.FolderOpen;
            this.displayFoldersToolStripMenuItem.Name = "displayFoldersToolStripMenuItem";
            this.displayFoldersToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.displayFoldersToolStripMenuItem.Text = "Display Folders";
            this.displayFoldersToolStripMenuItem.ToolTipText = "Show/hide display folders";
            // 
            // hiddenObjectsToolStripMenuItem
            // 
            actionsMain.SetAction(this.hiddenObjectsToolStripMenuItem, this.actToggleHidden);
            this.hiddenObjectsToolStripMenuItem.CheckOnClick = true;
            this.hiddenObjectsToolStripMenuItem.Enabled = false;
            this.hiddenObjectsToolStripMenuItem.Image = global::TabularEditor.Resources.Hidden;
            this.hiddenObjectsToolStripMenuItem.Name = "hiddenObjectsToolStripMenuItem";
            this.hiddenObjectsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.hiddenObjectsToolStripMenuItem.Text = "Hidden Objects";
            this.hiddenObjectsToolStripMenuItem.ToolTipText = "Show/hide hidden objects";
            // 
            // mEasToolStripMenuItem
            // 
            actionsMain.SetAction(this.mEasToolStripMenuItem, this.actToggleMeasures);
            this.mEasToolStripMenuItem.Checked = true;
            this.mEasToolStripMenuItem.CheckOnClick = true;
            this.mEasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mEasToolStripMenuItem.Enabled = false;
            this.mEasToolStripMenuItem.Image = global::TabularEditor.Resources.Sigma;
            this.mEasToolStripMenuItem.Name = "mEasToolStripMenuItem";
            this.mEasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.mEasToolStripMenuItem.Text = "Measures";
            this.mEasToolStripMenuItem.ToolTipText = "Show/hide measures";
            // 
            // xToolStripMenuItem
            // 
            actionsMain.SetAction(this.xToolStripMenuItem, this.actToggleColumns);
            this.xToolStripMenuItem.Checked = true;
            this.xToolStripMenuItem.CheckOnClick = true;
            this.xToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xToolStripMenuItem.Enabled = false;
            this.xToolStripMenuItem.Image = global::TabularEditor.Resources.Column;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.xToolStripMenuItem.Text = "Columns";
            this.xToolStripMenuItem.ToolTipText = "Show/hide columns";
            // 
            // yToolStripMenuItem
            // 
            actionsMain.SetAction(this.yToolStripMenuItem, this.actToggleHierarchies);
            this.yToolStripMenuItem.Checked = true;
            this.yToolStripMenuItem.CheckOnClick = true;
            this.yToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yToolStripMenuItem.Enabled = false;
            this.yToolStripMenuItem.Image = global::TabularEditor.Resources.Hierarchy;
            this.yToolStripMenuItem.Name = "yToolStripMenuItem";
            this.yToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.yToolStripMenuItem.Text = "Hierarchies";
            this.yToolStripMenuItem.ToolTipText = "Show/hide hierarchies";
            // 
            // metadataInformationToolStripMenuItem
            // 
            actionsMain.SetAction(this.metadataInformationToolStripMenuItem, this.actToggleInfoColumns);
            this.metadataInformationToolStripMenuItem.CheckOnClick = true;
            this.metadataInformationToolStripMenuItem.Image = global::TabularEditor.Resources.Columns;
            this.metadataInformationToolStripMenuItem.Name = "metadataInformationToolStripMenuItem";
            this.metadataInformationToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.metadataInformationToolStripMenuItem.Text = "Metadata Information";
            this.metadataInformationToolStripMenuItem.ToolTipText = "Show/hide metadata information columns";
            // 
            // expandAllToolStripMenuItem
            // 
            actionsMain.SetAction(this.expandAllToolStripMenuItem, this.actExpandAll);
            this.expandAllToolStripMenuItem.AutoToolTip = true;
            this.expandAllToolStripMenuItem.Image = global::TabularEditor.Resources.ExpandAll;
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            // 
            // collapseAllToolStripMenuItem
            // 
            actionsMain.SetAction(this.collapseAllToolStripMenuItem, this.actCollapseAll);
            this.collapseAllToolStripMenuItem.AutoToolTip = true;
            this.collapseAllToolStripMenuItem.Image = global::TabularEditor.Resources.CollapseAll;
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            // 
            // toolStripButton9
            // 
            actionsMain.SetAction(this.toolStripButton9, this.actExpressionAcceptEdit);
            this.toolStripButton9.AutoToolTip = false;
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = global::TabularEditor.Resources.Check;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Accept edit";
            this.toolStripButton9.ToolTipText = "Accept changes";
            // 
            // toolStripButton10
            // 
            actionsMain.SetAction(this.toolStripButton10, this.actExpressionCancelEdit);
            this.toolStripButton10.AutoToolTip = false;
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = global::TabularEditor.Resources.Cancel;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Cancel edit";
            this.toolStripButton10.ToolTipText = "Cancel changes";
            // 
            // btnFind
            // 
            actionsMain.SetAction(this.btnFind, this.actFind);
            this.btnFind.AutoToolTip = false;
            this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFind.Image = global::TabularEditor.Resources.Find;
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(23, 22);
            this.btnFind.Text = "Find";
            // 
            // btnReplace
            // 
            actionsMain.SetAction(this.btnReplace, this.actReplace);
            this.btnReplace.AutoToolTip = false;
            this.btnReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReplace.Image = global::TabularEditor.Resources.Replace;
            this.btnReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(23, 22);
            this.btnReplace.Text = "Replace";
            // 
            // findToolStripMenuItem
            // 
            actionsMain.SetAction(this.findToolStripMenuItem, this.actFind);
            this.findToolStripMenuItem.AutoToolTip = true;
            this.findToolStripMenuItem.Image = global::TabularEditor.Resources.Find;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // replaceToolStripMenuItem
            // 
            actionsMain.SetAction(this.replaceToolStripMenuItem, this.actReplace);
            this.replaceToolStripMenuItem.AutoToolTip = true;
            this.replaceToolStripMenuItem.Image = global::TabularEditor.Resources.Replace;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            // 
            // formatDAXToolStripMenuItem
            // 
            actionsMain.SetAction(this.formatDAXToolStripMenuItem, this.actExpressionFormatDAX);
            this.formatDAXToolStripMenuItem.Image = global::TabularEditor.Resources.DAXFormatter;
            this.formatDAXToolStripMenuItem.Name = "formatDAXToolStripMenuItem";
            this.formatDAXToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.formatDAXToolStripMenuItem.Text = "Format DAX";
            this.formatDAXToolStripMenuItem.ToolTipText = "Format using www.daxformatter.com";
            // 
            // btnFormatDAX
            // 
            actionsMain.SetAction(this.btnFormatDAX, this.actExpressionFormatDAX);
            this.btnFormatDAX.AutoToolTip = false;
            this.btnFormatDAX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFormatDAX.Image = global::TabularEditor.Resources.DAXFormatter;
            this.btnFormatDAX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFormatDAX.Name = "btnFormatDAX";
            this.btnFormatDAX.Size = new System.Drawing.Size(23, 22);
            this.btnFormatDAX.Text = "Format DAX";
            this.btnFormatDAX.ToolTipText = "Format using www.daxformatter.com";
            // 
            // btnRun
            // 
            actionsMain.SetAction(this.btnRun, this.actExecuteScript);
            this.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRun.Image = global::TabularEditor.Resources.Run;
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(23, 22);
            this.btnRun.Text = "Replace";
            // 
            // deployToolStripMenuItem
            // 
            actionsMain.SetAction(this.deployToolStripMenuItem, this.actDeploy);
            this.deployToolStripMenuItem.Image = global::TabularEditor.Resources.Deploy;
            this.deployToolStripMenuItem.Name = "deployToolStripMenuItem";
            this.deployToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.deployToolStripMenuItem.Text = "Deploy...";
            this.deployToolStripMenuItem.ToolTipText = "Lets you deploy the currently loaded model to an SSAS Tabular Server.";
            // 
            // btnSaveCustomAction
            // 
            actionsMain.SetAction(this.btnSaveCustomAction, this.actSaveCustomAction);
            this.btnSaveCustomAction.AutoToolTip = false;
            this.btnSaveCustomAction.Image = global::TabularEditor.Resources.action_add_16xLG;
            this.btnSaveCustomAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCustomAction.Name = "btnSaveCustomAction";
            this.btnSaveCustomAction.Size = new System.Drawing.Size(157, 22);
            this.btnSaveCustomAction.Text = "Save as Custom Action...";
            // 
            // cutToolStripMenuItem
            // 
            actionsMain.SetAction(this.cutToolStripMenuItem, this.actCut);
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.ToolTipText = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            actionsMain.SetAction(this.copyToolStripMenuItem, this.actCopy);
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.ToolTipText = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            actionsMain.SetAction(this.pasteToolStripMenuItem, this.actPaste);
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.ToolTipText = "Paste";
            // 
            // selectAllToolStripMenuItem
            // 
            actionsMain.SetAction(this.selectAllToolStripMenuItem, this.actSelectAll);
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad5)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.ToolTipText = "Select All";
            // 
            // tbShowAllObjectTypes
            // 
            actionsMain.SetAction(this.tbShowAllObjectTypes, this.actToggleAllObjectTypes);
            this.tbShowAllObjectTypes.AutoToolTip = false;
            this.tbShowAllObjectTypes.Checked = true;
            this.tbShowAllObjectTypes.CheckOnClick = true;
            this.tbShowAllObjectTypes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbShowAllObjectTypes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbShowAllObjectTypes.Enabled = false;
            this.tbShowAllObjectTypes.Image = global::TabularEditor.Resources.ShowDetails_16x;
            this.tbShowAllObjectTypes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbShowAllObjectTypes.Name = "tbShowAllObjectTypes";
            this.tbShowAllObjectTypes.Size = new System.Drawing.Size(23, 22);
            this.tbShowAllObjectTypes.Text = "Show All Object Types";
            this.tbShowAllObjectTypes.ToolTipText = "Show/hide all object types (perspectives, roles, data sources, etc.) in addition " +
    "to tables";
            // 
            // showAllObjectTypesToolStripMenuItem
            // 
            actionsMain.SetAction(this.showAllObjectTypesToolStripMenuItem, this.actToggleAllObjectTypes);
            this.showAllObjectTypesToolStripMenuItem.Checked = true;
            this.showAllObjectTypesToolStripMenuItem.CheckOnClick = true;
            this.showAllObjectTypesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAllObjectTypesToolStripMenuItem.Enabled = false;
            this.showAllObjectTypesToolStripMenuItem.Image = global::TabularEditor.Resources.ShowDetails_16x;
            this.showAllObjectTypesToolStripMenuItem.Name = "showAllObjectTypesToolStripMenuItem";
            this.showAllObjectTypesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showAllObjectTypesToolStripMenuItem.Text = "Show All Object Types";
            this.showAllObjectTypesToolStripMenuItem.ToolTipText = "Show/hide all object types (perspectives, roles, data sources, etc.) in addition " +
    "to tables";
            // 
            // tbSortAlphabetically
            // 
            actionsMain.SetAction(this.tbSortAlphabetically, this.actToggleMetadataOrder);
            this.tbSortAlphabetically.AutoToolTip = false;
            this.tbSortAlphabetically.Checked = true;
            this.tbSortAlphabetically.CheckOnClick = true;
            this.tbSortAlphabetically.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbSortAlphabetically.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSortAlphabetically.Enabled = false;
            this.tbSortAlphabetically.Image = global::TabularEditor.Resources.SortAscending_16x;
            this.tbSortAlphabetically.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSortAlphabetically.Name = "tbSortAlphabetically";
            this.tbSortAlphabetically.Size = new System.Drawing.Size(23, 22);
            this.tbSortAlphabetically.Text = "Sort alphabetically";
            this.tbSortAlphabetically.ToolTipText = "Toggle alphabetical/metadata ordering of items";
            // 
            // sortAlphabeticalToolStripMenuItem
            // 
            actionsMain.SetAction(this.sortAlphabeticalToolStripMenuItem, this.actToggleMetadataOrder);
            this.sortAlphabeticalToolStripMenuItem.Checked = true;
            this.sortAlphabeticalToolStripMenuItem.CheckOnClick = true;
            this.sortAlphabeticalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortAlphabeticalToolStripMenuItem.Enabled = false;
            this.sortAlphabeticalToolStripMenuItem.Image = global::TabularEditor.Resources.SortAscending_16x;
            this.sortAlphabeticalToolStripMenuItem.Name = "sortAlphabeticalToolStripMenuItem";
            this.sortAlphabeticalToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.sortAlphabeticalToolStripMenuItem.Text = "Sort alphabetically";
            this.sortAlphabeticalToolStripMenuItem.ToolTipText = "Toggle alphabetical/metadata ordering of items";
            // 
            // toolStripButton1
            // 
            actionsMain.SetAction(this.toolStripButton1, this.actComment);
            this.toolStripButton1.AutoToolTip = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TabularEditor.Resources.CommentCode_16x;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Comment lines";
            this.toolStripButton1.ToolTipText = "Comment the selected lines";
            // 
            // toolStripButton2
            // 
            actionsMain.SetAction(this.toolStripButton2, this.actUncomment);
            this.toolStripButton2.AutoToolTip = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::TabularEditor.Resources.UncommentCode_16x;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Uncomment Lines";
            this.toolStripButton2.ToolTipText = "Uncomment the selected lines";
            // 
            // saveToFolderToolStripMenuItem
            // 
            actionsMain.SetAction(this.saveToFolderToolStripMenuItem, this.actSaveToFolder);
            this.saveToFolderToolStripMenuItem.AutoToolTip = true;
            this.saveToFolderToolStripMenuItem.Name = "saveToFolderToolStripMenuItem";
            this.saveToFolderToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToFolderToolStripMenuItem.Text = "Save to Folder...";
            // 
            // newModelToolStripMenuItem
            // 
            actionsMain.SetAction(this.newModelToolStripMenuItem, this.actNewModel);
            this.newModelToolStripMenuItem.Name = "newModelToolStripMenuItem";
            this.newModelToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.newModelToolStripMenuItem.Text = "New model";
            this.newModelToolStripMenuItem.ToolTipText = "Creates a new blank Model.bim file";
            // 
            // btnSaveScript
            // 
            actionsMain.SetAction(this.btnSaveScript, this.actSaveScript);
            this.btnSaveScript.AutoToolTip = false;
            this.btnSaveScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveScript.Image = global::TabularEditor.Resources.Save;
            this.btnSaveScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveScript.Name = "btnSaveScript";
            this.btnSaveScript.Size = new System.Drawing.Size(23, 22);
            this.btnSaveScript.Text = "Save script";
            this.btnSaveScript.ToolTipText = "Saves the script to a file";
            this.btnSaveScript.Click += new System.EventHandler(this.btnSaveScript_Click);
            // 
            // btnOpenScript
            // 
            actionsMain.SetAction(this.btnOpenScript, this.actOpenScript);
            this.btnOpenScript.AutoToolTip = false;
            this.btnOpenScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenScript.Image = global::TabularEditor.Resources.Open;
            this.btnOpenScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenScript.Name = "btnOpenScript";
            this.btnOpenScript.Size = new System.Drawing.Size(23, 22);
            this.btnOpenScript.Text = "Open script";
            this.btnOpenScript.ToolTipText = "Opens a C# script from a file";
            this.btnOpenScript.Click += new System.EventHandler(this.btnOpenScript_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences...";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton8,
            this.btnConnect,
            this.toolStripSeparator3,
            this.btnSave,
            this.toolStripSeparator4,
            this.toolStripLabel1,
            this.cmbPerspective,
            this.toolStripSeparator5,
            this.toolStripLabel2,
            this.cmbTranslation,
            this.toolStripSeparator10});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1067, 25);
            this.toolStrip2.TabIndex = 13;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel1.Text = "Perspective:";
            // 
            // cmbPerspective
            // 
            this.cmbPerspective.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerspective.Name = "cmbPerspective";
            this.cmbPerspective.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel2.Text = "Translation:";
            // 
            // cmbTranslation
            // 
            this.cmbTranslation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTranslation.MaxDropDownItems = 25;
            this.cmbTranslation.Name = "cmbTranslation";
            this.cmbTranslation.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvModel);
            this.splitContainer1.Panel1.Controls.Add(this.toolTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 569);
            this.splitContainer1.SplitterDistance = 405;
            this.splitContainer1.TabIndex = 16;
            // 
            // tvModel
            // 
            this.tvModel.AllowDrop = true;
            this.tvModel.BackColor = System.Drawing.SystemColors.Window;
            this.tvModel.Columns.Add(this._colName);
            this.tvModel.Columns.Add(this._colType);
            this.tvModel.Columns.Add(this._colFormatString);
            this.tvModel.Columns.Add(this._colDataType);
            this.tvModel.Columns.Add(this._colDescription);
            this.tvModel.DefaultToolTipProvider = null;
            this.tvModel.DisplayDraggingNodes = true;
            this.tvModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvModel.DragDropMarkColor = System.Drawing.Color.Black;
            this.tvModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvModel.FullRowSelect = true;
            this.tvModel.Indent = 12;
            this.tvModel.Location = new System.Drawing.Point(0, 25);
            this.tvModel.Model = null;
            this.tvModel.Name = "tvModel";
            this.tvModel.NodeControls.Add(this.nodeTextBox1);
            this.tvModel.NodeControls.Add(this.nodeTextBox2);
            this.tvModel.NodeControls.Add(this.nodeTextBox3);
            this.tvModel.NodeControls.Add(this.nodeTextBox4);
            this.tvModel.SelectedNode = null;
            this.tvModel.SelectionMode = Aga.Controls.Tree.TreeSelectionMode.MultiSameParent;
            this.tvModel.ShowLines = false;
            this.tvModel.ShowNodeToolTips = true;
            this.tvModel.ShowPlusMinus = false;
            this.tvModel.Size = new System.Drawing.Size(405, 544);
            this.tvModel.TabIndex = 19;
            this.tvModel.Text = "treeViewAdv1";
            this.tvModel.UseColumns = true;
            // 
            // _colName
            // 
            this._colName.Header = "Name";
            this._colName.SortOrder = System.Windows.Forms.SortOrder.None;
            this._colName.TooltipText = null;
            this._colName.Width = 200;
            // 
            // _colType
            // 
            this._colType.Header = "Type";
            this._colType.SortOrder = System.Windows.Forms.SortOrder.None;
            this._colType.TooltipText = null;
            this._colType.Width = 80;
            // 
            // _colFormatString
            // 
            this._colFormatString.Header = "Format";
            this._colFormatString.SortOrder = System.Windows.Forms.SortOrder.None;
            this._colFormatString.TooltipText = null;
            // 
            // _colDataType
            // 
            this._colDataType.Header = "Data type";
            this._colDataType.SortOrder = System.Windows.Forms.SortOrder.None;
            this._colDataType.TooltipText = null;
            this._colDataType.Width = 60;
            // 
            // _colDescription
            // 
            this._colDescription.Header = "Description";
            this._colDescription.SortOrder = System.Windows.Forms.SortOrder.None;
            this._colDescription.TooltipText = null;
            this._colDescription.Width = 100;
            // 
            // nodeTextBox1
            // 
            this.nodeTextBox1.DataPropertyName = "DataType";
            this.nodeTextBox1.IncrementalSearchEnabled = true;
            this.nodeTextBox1.LeftMargin = 3;
            this.nodeTextBox1.ParentColumn = this._colDataType;
            // 
            // nodeTextBox2
            // 
            this.nodeTextBox2.DataPropertyName = "Description";
            this.nodeTextBox2.IncrementalSearchEnabled = true;
            this.nodeTextBox2.LeftMargin = 3;
            this.nodeTextBox2.ParentColumn = this._colDescription;
            // 
            // nodeTextBox3
            // 
            this.nodeTextBox3.DataPropertyName = "FormatString";
            this.nodeTextBox3.IncrementalSearchEnabled = true;
            this.nodeTextBox3.LeftMargin = 3;
            this.nodeTextBox3.ParentColumn = this._colFormatString;
            // 
            // nodeTextBox4
            // 
            this.nodeTextBox4.DataPropertyName = "ObjectTypeName";
            this.nodeTextBox4.IncrementalSearchEnabled = true;
            this.nodeTextBox4.LeftMargin = 3;
            this.nodeTextBox4.ParentColumn = this._colType;
            this.nodeTextBox4.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            // 
            // toolTreeView
            // 
            this.toolTreeView.CanOverflow = false;
            this.toolTreeView.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.tbShowDisplayFolders,
            this.tbShowHidden,
            this.tbShowAllObjectTypes,
            this.tbSortAlphabetically,
            this.toolStripSeparator1,
            this.tbShowMeasures,
            this.tbShowColumns,
            this.tbShowHierarchies,
            this.toolStripSeparator2,
            this.txtFilter,
            this.tbApplyFilter,
            this.toolStripSeparator6,
            this.toolStripButton6});
            this.toolTreeView.Location = new System.Drawing.Point(0, 0);
            this.toolTreeView.Name = "toolTreeView";
            this.toolTreeView.Size = new System.Drawing.Size(405, 25);
            this.toolTreeView.Stretch = true;
            this.toolTreeView.TabIndex = 18;
            this.toolTreeView.Text = "Tree";
            this.toolTreeView.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolTreeView_ItemClicked);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txtFilter
            // 
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.MaxLength = 0;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(146, 25);
            this.txtFilter.ToolTipText = "Only show measures, columns and hierarchies containing the filter text";
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer2.Size = new System.Drawing.Size(658, 569);
            this.splitContainer2.SplitterDistance = 273;
            this.splitContainer2.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 273);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtExpression);
            this.tabPage1.Controls.Add(this.lblCurrentMeasure);
            this.tabPage1.Controls.Add(this.toolStrip3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Expression Editor";
            // 
            // txtExpression
            // 
            this.txtExpression.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtExpression.AutoIndentChars = false;
            this.txtExpression.AutoIndentExistingLines = false;
            this.txtExpression.AutoScrollMinSize = new System.Drawing.Size(2, 15);
            this.txtExpression.BackBrush = null;
            this.txtExpression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpression.CharHeight = 15;
            this.txtExpression.CharWidth = 7;
            this.txtExpression.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExpression.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpression.Enabled = false;
            this.txtExpression.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtExpression.IsReplaceMode = false;
            this.txtExpression.Location = new System.Drawing.Point(3, 46);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Paddings = new System.Windows.Forms.Padding(0);
            this.txtExpression.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtExpression.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtExpression.ServiceColors")));
            this.txtExpression.ShowLineNumbers = false;
            this.txtExpression.Size = new System.Drawing.Size(644, 198);
            this.txtExpression.TabIndex = 23;
            this.txtExpression.Zoom = 100;
            // 
            // lblCurrentMeasure
            // 
            this.lblCurrentMeasure.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurrentMeasure.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMeasure.Location = new System.Drawing.Point(3, 28);
            this.lblCurrentMeasure.Name = "lblCurrentMeasure";
            this.lblCurrentMeasure.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.lblCurrentMeasure.Size = new System.Drawing.Size(644, 18);
            this.lblCurrentMeasure.TabIndex = 24;
            this.lblCurrentMeasure.Visible = false;
            this.lblCurrentMeasure.Paint += new System.Windows.Forms.PaintEventHandler(this.lblCurrentMeasure_Paint);
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator7,
            this.btnFormatDAX,
            this.toolStripSeparator8,
            this.btnFind,
            this.btnReplace,
            this.toolStripSeparator13,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(644, 25);
            this.toolStrip3.TabIndex = 22;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtAdvanced);
            this.tabPage2.Controls.Add(this.toolStrip4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(650, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced Scripting";
            // 
            // txtAdvanced
            // 
            this.txtAdvanced.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtAdvanced.AutoIndentChars = false;
            this.txtAdvanced.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txtAdvanced.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.txtAdvanced.BackBrush = null;
            this.txtAdvanced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdvanced.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtAdvanced.CharHeight = 14;
            this.txtAdvanced.CharWidth = 8;
            this.txtAdvanced.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdvanced.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdvanced.IsReplaceMode = false;
            this.txtAdvanced.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txtAdvanced.LeftBracket = '(';
            this.txtAdvanced.LeftBracket2 = '{';
            this.txtAdvanced.Location = new System.Drawing.Point(3, 28);
            this.txtAdvanced.Name = "txtAdvanced";
            this.txtAdvanced.Paddings = new System.Windows.Forms.Padding(0);
            this.txtAdvanced.RightBracket = ')';
            this.txtAdvanced.RightBracket2 = '}';
            this.txtAdvanced.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtAdvanced.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtAdvanced.ServiceColors")));
            this.txtAdvanced.Size = new System.Drawing.Size(644, 216);
            this.txtAdvanced.TabIndex = 16;
            this.txtAdvanced.Zoom = 100;
            this.txtAdvanced.ZoomChanged += new System.EventHandler(this.txtAdvanced_ZoomChanged);
            // 
            // toolStrip4
            // 
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenScript,
            this.btnSaveScript,
            this.toolStripSeparator18,
            this.btnRun,
            this.btnUndoErrors,
            this.toolStripSeparator11,
            this.samplesMenu,
            this.toolStripSeparator15,
            this.btnSaveCustomAction,
            this.toolStripSeparator20,
            this.toolStripComboBox1,
            this.toolStripButton3});
            this.toolStrip4.Location = new System.Drawing.Point(3, 3);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(644, 25);
            this.toolStrip4.TabIndex = 15;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // btnUndoErrors
            // 
            this.btnUndoErrors.Checked = true;
            this.btnUndoErrors.CheckOnClick = true;
            this.btnUndoErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnUndoErrors.Image = global::TabularEditor.Resources.Undo_grey_16x;
            this.btnUndoErrors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndoErrors.Name = "btnUndoErrors";
            this.btnUndoErrors.Size = new System.Drawing.Size(117, 22);
            this.btnUndoErrors.Text = "Rollback on error";
            this.btnUndoErrors.ToolTipText = "When this is enabled, changes done by the script will be rolled back in case of e" +
    "rrors.";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // samplesMenu
            // 
            this.samplesMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.samplesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customActionsToolStripMenuItem,
            this.toolStripSeparator17});
            this.samplesMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.samplesMenu.Name = "samplesMenu";
            this.samplesMenu.Size = new System.Drawing.Size(64, 22);
            this.samplesMenu.Text = "Samples";
            // 
            // customActionsToolStripMenuItem
            // 
            this.customActionsToolStripMenuItem.Name = "customActionsToolStripMenuItem";
            this.customActionsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.customActionsToolStripMenuItem.Text = "Custom Actions";
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(156, 6);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.toolStripComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toolStripComboBox1.DropDownWidth = 75;
            this.toolStripComboBox1.IntegralHeight = false;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "50 %",
            "75 %",
            "100 %",
            "125 %",
            "150 %",
            "200 %",
            "300 %",
            "400 %"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBox1.Text = "100 %";
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(77, 22);
            this.toolStripButton3.Text = "References...";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(658, 292);
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.InactiveBorder;
            this.propertyGrid1.TabIndex = 14;
            // 
            // tvMenu
            // 
            this.tvMenu.Enabled = false;
            this.tvMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblErrors,
            this.lblScriptStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 618);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(200, 17);
            this.lblStatus.Text = "(No model loaded)";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = false;
            this.lblErrors.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblErrors.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(100, 17);
            this.lblErrors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrors.Click += new System.EventHandler(this.lblErrors_Click);
            // 
            // lblScriptStatus
            // 
            this.lblScriptStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblScriptStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblScriptStatus.Name = "lblScriptStatus";
            this.lblScriptStatus.Size = new System.Drawing.Size(752, 17);
            this.lblScriptStatus.Spring = true;
            this.lblScriptStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.modelToolStripMenuItem,
            this.dynamicToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newModelToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToFolderToolStripMenuItem,
            this.toolStripMenuItem3,
            this.preferencesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.recentFilesToolStripMenuItem,
            this.toolStripSeparator12,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fromDBToolStripMenuItem,
            this.fromFolderToolStripMenuItem});
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // fromFolderToolStripMenuItem
            // 
            this.fromFolderToolStripMenuItem.Name = "fromFolderToolStripMenuItem";
            this.fromFolderToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.fromFolderToolStripMenuItem.Text = "From Folder...";
            this.fromFolderToolStripMenuItem.Click += new System.EventHandler(this.fromFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 6);
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.recentFilesToolStripMenuItem.Text = "Recent Files";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(181, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator16,
            this.toolStripMenuItem9,
            this.toolStripMenuItem7,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem8,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator9,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.toolStripSeparator14,
            this.dAXExpressionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(206, 6);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(209, 22);
            this.toolStripMenuItem9.Text = "Show history...";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(206, 6);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(206, 6);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(206, 6);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(206, 6);
            // 
            // dAXExpressionToolStripMenuItem
            // 
            this.dAXExpressionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatDAXToolStripMenuItem,
            this.evaluateToolStripMenuItem});
            this.dAXExpressionToolStripMenuItem.Name = "dAXExpressionToolStripMenuItem";
            this.dAXExpressionToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.dAXExpressionToolStripMenuItem.Text = "DAX Editor";
            // 
            // evaluateToolStripMenuItem
            // 
            this.evaluateToolStripMenuItem.Enabled = false;
            this.evaluateToolStripMenuItem.Name = "evaluateToolStripMenuItem";
            this.evaluateToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.evaluateToolStripMenuItem.Text = "Evaluate";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayFoldersToolStripMenuItem,
            this.hiddenObjectsToolStripMenuItem,
            this.showAllObjectTypesToolStripMenuItem,
            this.sortAlphabeticalToolStripMenuItem,
            this.toolStripMenuItem4,
            this.mEasToolStripMenuItem,
            this.xToolStripMenuItem,
            this.yToolStripMenuItem,
            this.toolStripMenuItem5,
            this.metadataInformationToolStripMenuItem,
            this.toolStripMenuItem6,
            this.expandAllToolStripMenuItem,
            this.collapseAllToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(188, 6);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deployToolStripMenuItem});
            this.modelToolStripMenuItem.Enabled = false;
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.modelToolStripMenuItem.Text = "Model";
            // 
            // dynamicToolStripMenuItem
            // 
            this.dynamicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator19});
            this.dynamicToolStripMenuItem.Name = "dynamicToolStripMenuItem";
            this.dynamicToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.dynamicToolStripMenuItem.Text = "Dynamic";
            this.dynamicToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(57, 6);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestPracticeAnalyzerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // bestPracticeAnalyzerToolStripMenuItem
            // 
            this.bestPracticeAnalyzerToolStripMenuItem.Name = "bestPracticeAnalyzerToolStripMenuItem";
            this.bestPracticeAnalyzerToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.bestPracticeAnalyzerToolStripMenuItem.Text = "Best Practice Analyzer...";
            this.bestPracticeAnalyzerToolStripMenuItem.Click += new System.EventHandler(this.bestPracticeAnalyzerToolStripMenuItem_Click);
            // 
            // tabularTreeImages
            // 
            this.tabularTreeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabularTreeImages.ImageStream")));
            this.tabularTreeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.tabularTreeImages.Images.SetKeyName(0, "folder");
            this.tabularTreeImages.Images.SetKeyName(1, "folderOpen");
            this.tabularTreeImages.Images.SetKeyName(2, "table");
            this.tabularTreeImages.Images.SetKeyName(3, "hierarchy");
            this.tabularTreeImages.Images.SetKeyName(4, "column");
            this.tabularTreeImages.Images.SetKeyName(5, "calculator");
            this.tabularTreeImages.Images.SetKeyName(6, "kpi");
            this.tabularTreeImages.Images.SetKeyName(7, "measure");
            this.tabularTreeImages.Images.SetKeyName(8, "sigma");
            this.tabularTreeImages.Images.SetKeyName(9, "cube");
            this.tabularTreeImages.Images.SetKeyName(10, "link");
            this.tabularTreeImages.Images.SetKeyName(11, "level");
            this.tabularTreeImages.Images.SetKeyName(12, "calccolumn");
            this.tabularTreeImages.Images.SetKeyName(13, "level01");
            this.tabularTreeImages.Images.SetKeyName(14, "level02");
            this.tabularTreeImages.Images.SetKeyName(15, "level03");
            this.tabularTreeImages.Images.SetKeyName(16, "level04");
            this.tabularTreeImages.Images.SetKeyName(17, "level05");
            this.tabularTreeImages.Images.SetKeyName(18, "level06");
            this.tabularTreeImages.Images.SetKeyName(19, "level07");
            this.tabularTreeImages.Images.SetKeyName(20, "level08");
            this.tabularTreeImages.Images.SetKeyName(21, "level09");
            this.tabularTreeImages.Images.SetKeyName(22, "level10");
            this.tabularTreeImages.Images.SetKeyName(23, "level11");
            this.tabularTreeImages.Images.SetKeyName(24, "level12");
            this.tabularTreeImages.Images.SetKeyName(25, "warning");
            this.tabularTreeImages.Images.SetKeyName(26, "question");
            this.tabularTreeImages.Images.SetKeyName(27, "method");
            this.tabularTreeImages.Images.SetKeyName(28, "property");
            this.tabularTreeImages.Images.SetKeyName(29, "exmethod");
            this.tabularTreeImages.Images.SetKeyName(30, "enum");
            this.tabularTreeImages.Images.SetKeyName(31, "calctable");
            this.tabularTreeImages.Images.SetKeyName(32, "perspective");
            this.tabularTreeImages.Images.SetKeyName(33, "translation");
            this.tabularTreeImages.Images.SetKeyName(34, "role");
            this.tabularTreeImages.Images.SetKeyName(35, "culture");
            this.tabularTreeImages.Images.SetKeyName(36, "datasource");
            this.tabularTreeImages.Images.SetKeyName(37, "sort");
            this.tabularTreeImages.Images.SetKeyName(38, "partition");
            this.tabularTreeImages.Images.SetKeyName(39, "gauge");
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "bim";
            this.dlgSaveFile.FileName = "Model.bim";
            this.dlgSaveFile.Filter = "Tabular Model Files|*.bim|All files|*.*";
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "Model.bim";
            this.dlgOpenFile.Filter = "Tabular Model Files|*.bim;database.json|All files|*.*";
            // 
            // _type
            // 
            this._type.DataPropertyName = "TypeName";
            this._type.IncrementalSearchEnabled = true;
            this._type.LeftMargin = 3;
            this._type.ParentColumn = this._colType;
            this._type.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            // 
            // _formatString
            // 
            this._formatString.DataPropertyName = "FormatString";
            this._formatString.IncrementalSearchEnabled = true;
            this._formatString.LeftMargin = 3;
            this._formatString.ParentColumn = this._colFormatString;
            this._formatString.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _dataType
            // 
            this._dataType.DataPropertyName = "DataType";
            this._dataType.IncrementalSearchEnabled = true;
            this._dataType.LeftMargin = 3;
            this._dataType.ParentColumn = this._colDataType;
            // 
            // _description
            // 
            this._description.DataPropertyName = "Description";
            this._description.IncrementalSearchEnabled = true;
            this._description.LeftMargin = 3;
            this._description.ParentColumn = this._colDescription;
            // 
            // treeColumn1
            // 
            this.treeColumn1.Header = "";
            this.treeColumn1.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeColumn1.TooltipText = null;
            // 
            // ofdScript
            // 
            this.ofdScript.FileName = "Script.cs";
            this.ofdScript.Filter = "C# files|*.cs|All files|*.*";
            // 
            // sfdScript
            // 
            this.sfdScript.Filter = "C# files|*.cs|All files|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1067, 640);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Tabular Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(actionsMain)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolTreeView.ResumeLayout(false);
            this.toolTreeView.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdvanced)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbPerspective;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbTranslation;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private TabularEditor.PropertyGridExtension.NavigatablePropertyGrid propertyGrid1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblErrors;
        private System.Windows.Forms.ContextMenuStrip tvMenu;
        private System.Windows.Forms.ToolStripStatusLabel lblScriptStatus;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripDropDownButton samplesMenu;
        private System.Windows.Forms.ToolStripButton btnRun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private TabularEditor.UI.UIModelAction actToggleDisplayFolders;
        private TabularEditor.UI.UIModelAction actToggleMetadataOrder;
        private TabularEditor.UI.UIModelAction actToggleInfoColumns;
        private TabularEditor.UI.UIModelAction actExpressionAcceptEdit;
        private TabularEditor.UI.UIModelAction actExpressionCancelEdit;
        private Crad.Windows.Forms.Actions.Action actOpenFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private Crad.Windows.Forms.Actions.Action actOpenDB;
        private TabularEditor.UI.UIModelAction actSaveAs;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fromDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private Crad.Windows.Forms.Actions.Action actExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deployToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayFoldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiddenObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mEasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem metadataInformationToolStripMenuItem;
        private TabularEditor.UI.UIModelAction actCollapseAll;
        private TabularEditor.UI.UIModelAction actExpandAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private TabularEditor.UI.UIDeleteAction actDelete;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private TabularEditor.UI.Actions.UIUndoRedoAction actUndo;
        private TabularEditor.UI.Actions.UIUndoRedoAction actRedo;
        private System.Windows.Forms.ToolStripButton btnUndoErrors;
        private FastColoredTextBoxNS.FastColoredTextBox txtAdvanced;
        private System.Windows.Forms.ImageList tabularTreeImages;
        private Aga.Controls.Tree.TreeViewAdv tvModel;
        private Aga.Controls.Tree.TreeColumn _colName;
        private Aga.Controls.Tree.TreeColumn _colType;
        private Aga.Controls.Tree.NodeControls.NodeTextBox _type;
        private Aga.Controls.Tree.TreeColumn _colFormatString;
        private Aga.Controls.Tree.TreeColumn _colDataType;
        private Aga.Controls.Tree.TreeColumn _colDescription;
        private Aga.Controls.Tree.NodeControls.NodeTextBox _formatString;
        private Aga.Controls.Tree.NodeControls.NodeTextBox _dataType;
        private Aga.Controls.Tree.NodeControls.NodeTextBox _description;
        private System.Windows.Forms.ToolStrip toolTreeView;
        private System.Windows.Forms.ToolStripButton tbShowDisplayFolders;
        private System.Windows.Forms.ToolStripButton tbShowHidden;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbShowMeasures;
        private System.Windows.Forms.ToolStripButton tbShowColumns;
        private System.Windows.Forms.ToolStripButton tbShowHierarchies;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbApplyFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private FastColoredTextBoxNS.FastColoredTextBox txtExpression;
        private System.Windows.Forms.Label lblCurrentMeasure;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnFormatDAX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripButton btnReplace;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private Aga.Controls.Tree.TreeColumn treeColumn1;
        private UI.UIModelAction actExpressionFormatDAX;
        private UI.UIModelAction actFind;
        private UI.UIModelAction actReplace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem dAXExpressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatDAXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private UI.UIModelAction actExecuteScript;
        private System.Windows.Forms.ToolStripButton btnSaveCustomAction;
        private UI.UIModelAction actDeploy;
        private System.Windows.Forms.ToolStripMenuItem customActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private Crad.Windows.Forms.Actions.Action actSaveCustomAction;
        public System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBox1;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBox2;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBox3;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBox4;
        private TabularEditor.UI.Actions.CopyAction actCopy;
        private TabularEditor.UI.Actions.PasteAction actPaste;
        private TabularEditor.UI.Actions.SelectAllAction actSelectAll;
        private TabularEditor.UI.Actions.CutAction actCut;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripButton tbShowAllObjectTypes;
        private System.Windows.Forms.ToolStripMenuItem showAllObjectTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestPracticeAnalyzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton tbSortAlphabetically;
        private System.Windows.Forms.ToolStripMenuItem sortAlphabeticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private Crad.Windows.Forms.Actions.Action actComment;
        private Crad.Windows.Forms.Actions.Action actUncomment;
        private UI.UIModelAction actSaveToFolder;
        private Crad.Windows.Forms.Actions.Action actNewModel;
        private System.Windows.Forms.ToolStripMenuItem newModelToolStripMenuItem;
        private Crad.Windows.Forms.Actions.Action actOpenScript;
        private Crad.Windows.Forms.Actions.Action actSaveScript;
        private System.Windows.Forms.ToolStripButton btnOpenScript;
        private System.Windows.Forms.ToolStripButton btnSaveScript;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        public UI.UIModelAction actToggleAllObjectTypes;
        public UI.UIModelAction actToggleHidden;
        public UI.UIModelAction actToggleMeasures;
        public UI.UIModelAction actToggleColumns;
        public UI.UIModelAction actToggleHierarchies;
        public UI.UIModelAction actToggleFilter;
        private System.Windows.Forms.ToolStripMenuItem dynamicToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        public UI.UIModelAction actSave;
        private System.Windows.Forms.OpenFileDialog ofdScript;
        private System.Windows.Forms.SaveFileDialog sfdScript;
        private ToolStripSpringTextBox txtFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

