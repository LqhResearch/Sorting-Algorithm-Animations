
namespace SortingAlgorithmSimulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAlgorithms = new System.Windows.Forms.Label();
            this.cboAlgorithms = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRun = new Guna.UI2.WinForms.Guna2Button();
            this.nudNode = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pnlCustomize = new System.Windows.Forms.Panel();
            this.rdbDecreasing = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbAscending = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblNode = new System.Windows.Forms.Label();
            this.btnMode = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNote = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSimulation = new System.Windows.Forms.Panel();
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.bgwBubbleSort = new System.ComponentModel.BackgroundWorker();
            this.bgwInterchangeSort = new System.ComponentModel.BackgroundWorker();
            this.bgwSelectionSort = new System.ComponentModel.BackgroundWorker();
            this.bgwQuickSort = new System.ComponentModel.BackgroundWorker();
            this.bgwInsertionSort = new System.ComponentModel.BackgroundWorker();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNode)).BeginInit();
            this.pnlCustomize.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1000, 50);
            this.pnlTitle.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.DisabledState.Parent = this.btnExit;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(950, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(362, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Sorting Algorithm Simulation";
            // 
            // lblAlgorithms
            // 
            this.lblAlgorithms.AutoSize = true;
            this.lblAlgorithms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgorithms.ForeColor = System.Drawing.Color.White;
            this.lblAlgorithms.Location = new System.Drawing.Point(269, 17);
            this.lblAlgorithms.Name = "lblAlgorithms";
            this.lblAlgorithms.Size = new System.Drawing.Size(79, 17);
            this.lblAlgorithms.TabIndex = 1;
            this.lblAlgorithms.Text = "Algorithm: ";
            // 
            // cboAlgorithms
            // 
            this.cboAlgorithms.BackColor = System.Drawing.Color.Transparent;
            this.cboAlgorithms.BorderRadius = 10;
            this.cboAlgorithms.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAlgorithms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlgorithms.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboAlgorithms.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboAlgorithms.FocusedState.Parent = this.cboAlgorithms;
            this.cboAlgorithms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAlgorithms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboAlgorithms.HoverState.Parent = this.cboAlgorithms;
            this.cboAlgorithms.ItemHeight = 30;
            this.cboAlgorithms.Items.AddRange(new object[] {
            "Bubble Sort",
            "Interchange Sort",
            "Selection Sort",
            "Quick Sort",
            "Insertion Sort"});
            this.cboAlgorithms.ItemsAppearance.Parent = this.cboAlgorithms;
            this.cboAlgorithms.Location = new System.Drawing.Point(354, 7);
            this.cboAlgorithms.Name = "cboAlgorithms";
            this.cboAlgorithms.ShadowDecoration.Parent = this.cboAlgorithms;
            this.cboAlgorithms.Size = new System.Drawing.Size(160, 36);
            this.cboAlgorithms.StartIndex = 0;
            this.cboAlgorithms.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.BorderRadius = 10;
            this.btnRun.CheckedState.Parent = this.btnRun;
            this.btnRun.CustomImages.Parent = this.btnRun;
            this.btnRun.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRun.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRun.DisabledState.Parent = this.btnRun;
            this.btnRun.Enabled = false;
            this.btnRun.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(102)))), ((int)(((byte)(92)))));
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.HoverState.Parent = this.btnRun;
            this.btnRun.Location = new System.Drawing.Point(520, 7);
            this.btnRun.Name = "btnRun";
            this.btnRun.ShadowDecoration.Parent = this.btnRun;
            this.btnRun.Size = new System.Drawing.Size(60, 36);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // nudNode
            // 
            this.nudNode.BackColor = System.Drawing.Color.Transparent;
            this.nudNode.BorderRadius = 10;
            this.nudNode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNode.DisabledState.Parent = this.nudNode;
            this.nudNode.FocusedState.Parent = this.nudNode;
            this.nudNode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNode.ForeColor = System.Drawing.Color.Black;
            this.nudNode.Location = new System.Drawing.Point(67, 7);
            this.nudNode.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudNode.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.nudNode.Name = "nudNode";
            this.nudNode.ShadowDecoration.Parent = this.nudNode;
            this.nudNode.Size = new System.Drawing.Size(75, 36);
            this.nudNode.TabIndex = 5;
            this.nudNode.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(102)))), ((int)(((byte)(92)))));
            this.nudNode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlCustomize
            // 
            this.pnlCustomize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCustomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(170)))), ((int)(((byte)(246)))));
            this.pnlCustomize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomize.Controls.Add(this.rdbDecreasing);
            this.pnlCustomize.Controls.Add(this.rdbAscending);
            this.pnlCustomize.Controls.Add(this.lblNode);
            this.pnlCustomize.Controls.Add(this.btnMode);
            this.pnlCustomize.Controls.Add(this.btnClear);
            this.pnlCustomize.Controls.Add(this.btnRun);
            this.pnlCustomize.Controls.Add(this.cboAlgorithms);
            this.pnlCustomize.Controls.Add(this.nudNode);
            this.pnlCustomize.Controls.Add(this.lblAlgorithms);
            this.pnlCustomize.Controls.Add(this.btnAddNote);
            this.pnlCustomize.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomize.Location = new System.Drawing.Point(0, 50);
            this.pnlCustomize.Name = "pnlCustomize";
            this.pnlCustomize.Size = new System.Drawing.Size(1000, 50);
            this.pnlCustomize.TabIndex = 6;
            // 
            // rdbDecreasing
            // 
            this.rdbDecreasing.AutoSize = true;
            this.rdbDecreasing.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbDecreasing.CheckedState.BorderThickness = 0;
            this.rdbDecreasing.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbDecreasing.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbDecreasing.CheckedState.InnerOffset = -4;
            this.rdbDecreasing.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDecreasing.ForeColor = System.Drawing.Color.White;
            this.rdbDecreasing.Location = new System.Drawing.Point(794, 15);
            this.rdbDecreasing.Name = "rdbDecreasing";
            this.rdbDecreasing.Size = new System.Drawing.Size(94, 21);
            this.rdbDecreasing.TabIndex = 6;
            this.rdbDecreasing.Text = "Decreasing";
            this.rdbDecreasing.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbDecreasing.UncheckedState.BorderThickness = 2;
            this.rdbDecreasing.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbDecreasing.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbAscending
            // 
            this.rdbAscending.AutoSize = true;
            this.rdbAscending.Checked = true;
            this.rdbAscending.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbAscending.CheckedState.BorderThickness = 0;
            this.rdbAscending.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbAscending.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbAscending.CheckedState.InnerOffset = -4;
            this.rdbAscending.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAscending.ForeColor = System.Drawing.Color.White;
            this.rdbAscending.Location = new System.Drawing.Point(698, 15);
            this.rdbAscending.Name = "rdbAscending";
            this.rdbAscending.Size = new System.Drawing.Size(90, 21);
            this.rdbAscending.TabIndex = 6;
            this.rdbAscending.TabStop = true;
            this.rdbAscending.Text = "Ascending";
            this.rdbAscending.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbAscending.UncheckedState.BorderThickness = 2;
            this.rdbAscending.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbAscending.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lblNode
            // 
            this.lblNode.AutoSize = true;
            this.lblNode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNode.ForeColor = System.Drawing.Color.White;
            this.lblNode.Location = new System.Drawing.Point(12, 17);
            this.lblNode.Name = "lblNode";
            this.lblNode.Size = new System.Drawing.Size(49, 17);
            this.lblNode.TabIndex = 1;
            this.lblNode.Text = "Node: ";
            // 
            // btnMode
            // 
            this.btnMode.BorderRadius = 10;
            this.btnMode.CheckedState.Parent = this.btnMode;
            this.btnMode.CustomImages.Parent = this.btnMode;
            this.btnMode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMode.DisabledState.Parent = this.btnMode;
            this.btnMode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(102)))), ((int)(((byte)(92)))));
            this.btnMode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode.ForeColor = System.Drawing.Color.White;
            this.btnMode.HoverState.Parent = this.btnMode;
            this.btnMode.Image = global::SortingAlgorithmSimulation.Properties.Resources.Night_mode;
            this.btnMode.Location = new System.Drawing.Point(951, 7);
            this.btnMode.Name = "btnMode";
            this.btnMode.ShadowDecoration.Parent = this.btnMode;
            this.btnMode.Size = new System.Drawing.Size(36, 36);
            this.btnMode.TabIndex = 3;
            this.btnMode.Tag = "Night mode";
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 10;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.DisabledState.Parent = this.btnClear;
            this.btnClear.Enabled = false;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(102)))), ((int)(((byte)(92)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(586, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(60, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.BorderRadius = 10;
            this.btnAddNote.CheckedState.Parent = this.btnAddNote;
            this.btnAddNote.CustomImages.Parent = this.btnAddNote;
            this.btnAddNote.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNote.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNote.DisabledState.Parent = this.btnAddNote;
            this.btnAddNote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(102)))), ((int)(((byte)(92)))));
            this.btnAddNote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNote.ForeColor = System.Drawing.Color.White;
            this.btnAddNote.HoverState.Parent = this.btnAddNote;
            this.btnAddNote.Location = new System.Drawing.Point(148, 7);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.ShadowDecoration.Parent = this.btnAddNote;
            this.btnAddNote.Size = new System.Drawing.Size(60, 36);
            this.btnAddNote.TabIndex = 3;
            this.btnAddNote.Text = "Add";
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // pnlSimulation
            // 
            this.pnlSimulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.pnlSimulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSimulation.Location = new System.Drawing.Point(0, 100);
            this.pnlSimulation.Name = "pnlSimulation";
            this.pnlSimulation.Size = new System.Drawing.Size(1000, 400);
            this.pnlSimulation.TabIndex = 7;
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 25;
            this.Elipse.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnlTitle;
            // 
            // bgwBubbleSort
            // 
            this.bgwBubbleSort.WorkerReportsProgress = true;
            this.bgwBubbleSort.WorkerSupportsCancellation = true;
            this.bgwBubbleSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBubbleSort_DoWork);
            this.bgwBubbleSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwBubbleSort_ProgressChanged);
            this.bgwBubbleSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBubbleSort_RunWorkerCompleted);
            // 
            // bgwInterchangeSort
            // 
            this.bgwInterchangeSort.WorkerReportsProgress = true;
            this.bgwInterchangeSort.WorkerSupportsCancellation = true;
            this.bgwInterchangeSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwInterchangeSort_DoWork);
            this.bgwInterchangeSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwInterchangeSort_ProgressChanged);
            this.bgwInterchangeSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwInterchangeSort_RunWorkerCompleted);
            // 
            // bgwSelectionSort
            // 
            this.bgwSelectionSort.WorkerReportsProgress = true;
            this.bgwSelectionSort.WorkerSupportsCancellation = true;
            this.bgwSelectionSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSelectionSort_DoWork);
            this.bgwSelectionSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSelectionSort_ProgressChanged);
            this.bgwSelectionSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSelectionSort_RunWorkerCompleted);
            // 
            // bgwQuickSort
            // 
            this.bgwQuickSort.WorkerReportsProgress = true;
            this.bgwQuickSort.WorkerSupportsCancellation = true;
            this.bgwQuickSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwQuickSort_DoWork);
            this.bgwQuickSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwQuickSort_ProgressChanged);
            this.bgwQuickSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwQuickSort_RunWorkerCompleted);
            // 
            // bgwInsertionSort
            // 
            this.bgwInsertionSort.WorkerReportsProgress = true;
            this.bgwInsertionSort.WorkerSupportsCancellation = true;
            this.bgwInsertionSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwInsertionSort_DoWork);
            this.bgwInsertionSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwInsertionSort_ProgressChanged);
            this.bgwInsertionSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwInsertionSort_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnAddNote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.pnlSimulation);
            this.Controls.Add(this.pnlCustomize);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuật toán sắp xếp";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNode)).EndInit();
            this.pnlCustomize.ResumeLayout(false);
            this.pnlCustomize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAlgorithms;
        private Guna.UI2.WinForms.Guna2ComboBox cboAlgorithms;
        private Guna.UI2.WinForms.Guna2Button btnRun;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNode;
        private System.Windows.Forms.Panel pnlCustomize;
        private System.Windows.Forms.Panel pnlSimulation;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.ComponentModel.BackgroundWorker bgwBubbleSort;
        private System.ComponentModel.BackgroundWorker bgwInterchangeSort;
        private System.ComponentModel.BackgroundWorker bgwSelectionSort;
        private System.ComponentModel.BackgroundWorker bgwQuickSort;
        private System.ComponentModel.BackgroundWorker bgwInsertionSort;
        private Guna.UI2.WinForms.Guna2RadioButton rdbDecreasing;
        private Guna.UI2.WinForms.Guna2RadioButton rdbAscending;
        private System.Windows.Forms.Label lblNode;
        private Guna.UI2.WinForms.Guna2Button btnAddNote;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnMode;
    }
}

