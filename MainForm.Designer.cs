namespace Courseword_DN
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            Canvas = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ClearGraphB = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            RemoveVertexB = new Button();
            tableLayoutPanel10 = new TableLayoutPanel();
            RemoveVertexD = new ComboBox();
            label2 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            GreedyCoverB = new Button();
            AproxCoverB = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            LoadFileB = new Button();
            SaveAsB = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            label1 = new Label();
            RepresentationAdjR = new RadioButton();
            RepresentationIncR = new RadioButton();
            RepresentationEdgesR = new RadioButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            GenerateRandB = new Button();
            tableLayoutPanel11 = new TableLayoutPanel();
            label4 = new Label();
            GenVertCountN = new NumericUpDown();
            tableLayoutPanel12 = new TableLayoutPanel();
            SaveVertexCoverB = new Button();
            AddVertexB = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            ChangeEdgeVertexAD = new ComboBox();
            ChangeEdgeVertexBD = new ComboBox();
            label3 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            RemoveEdgeB = new Button();
            AddEdgeB = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GenVertCountN).BeginInit();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.None;
            splitContainer1.Panel1.Controls.Add(Canvas);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2.Margin = new Padding(10, 0, 0, 0);
            splitContainer1.Size = new Size(1264, 681);
            splitContainer1.SplitterDistance = 967;
            splitContainer1.TabIndex = 1;
            // 
            // Canvas
            // 
            Canvas.Dock = DockStyle.Fill;
            Canvas.Location = new Point(0, 0);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(967, 681);
            Canvas.TabIndex = 0;
            Canvas.Paint += Canvas_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlLight;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(ClearGraphB, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel12, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9051266F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6671848F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9051313F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9051313F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9051313F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9051313F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9051266F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9020348F));
            tableLayoutPanel1.Size = new Size(293, 681);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ClearGraphB
            // 
            ClearGraphB.Dock = DockStyle.Fill;
            ClearGraphB.Enabled = false;
            ClearGraphB.Location = new Point(6, 443);
            ClearGraphB.Margin = new Padding(6);
            ClearGraphB.Name = "ClearGraphB";
            ClearGraphB.Size = new Size(281, 69);
            ClearGraphB.TabIndex = 0;
            ClearGraphB.Text = "Clear graph";
            ClearGraphB.UseVisualStyleBackColor = true;
            ClearGraphB.Click += ClearGraphB_Click;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(RemoveVertexB, 0, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel10, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 359);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(287, 75);
            tableLayoutPanel8.TabIndex = 20;
            // 
            // RemoveVertexB
            // 
            RemoveVertexB.Anchor = AnchorStyles.Left;
            RemoveVertexB.Enabled = false;
            RemoveVertexB.Location = new Point(3, 12);
            RemoveVertexB.Name = "RemoveVertexB";
            RemoveVertexB.Size = new Size(125, 50);
            RemoveVertexB.TabIndex = 11;
            RemoveVertexB.Text = "Remove Vertex";
            RemoveVertexB.UseVisualStyleBackColor = true;
            RemoveVertexB.Click += RemoveVertexB_Click;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(RemoveVertexD, 0, 1);
            tableLayoutPanel10.Controls.Add(label2, 0, 0);
            tableLayoutPanel10.Location = new Point(146, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(138, 69);
            tableLayoutPanel10.TabIndex = 12;
            // 
            // RemoveVertexD
            // 
            RemoveVertexD.Dock = DockStyle.Fill;
            RemoveVertexD.FormattingEnabled = true;
            RemoveVertexD.Location = new Point(3, 37);
            RemoveVertexD.Name = "RemoveVertexD";
            RemoveVertexD.Size = new Size(132, 23);
            RemoveVertexD.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(26, 19);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 0;
            label2.Text = "Chosen vertex:";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(GreedyCoverB, 0, 0);
            tableLayoutPanel7.Controls.Add(AproxCoverB, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 197);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(287, 75);
            tableLayoutPanel7.TabIndex = 19;
            // 
            // GreedyCoverB
            // 
            GreedyCoverB.Anchor = AnchorStyles.Left;
            GreedyCoverB.Enabled = false;
            GreedyCoverB.Location = new Point(3, 12);
            GreedyCoverB.Name = "GreedyCoverB";
            GreedyCoverB.Size = new Size(125, 50);
            GreedyCoverB.TabIndex = 5;
            GreedyCoverB.Text = "Greedy Vertex Cover";
            GreedyCoverB.UseVisualStyleBackColor = true;
            GreedyCoverB.Click += GreedyCoverB_Click;
            // 
            // AproxCoverB
            // 
            AproxCoverB.Anchor = AnchorStyles.Right;
            AproxCoverB.Enabled = false;
            AproxCoverB.Location = new Point(159, 12);
            AproxCoverB.Name = "AproxCoverB";
            AproxCoverB.Size = new Size(125, 50);
            AproxCoverB.TabIndex = 4;
            AproxCoverB.Text = "Aprox Vertex Cover";
            AproxCoverB.UseVisualStyleBackColor = true;
            AproxCoverB.Click += AproxCoverB_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 84);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(287, 107);
            tableLayoutPanel4.TabIndex = 18;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(LoadFileB, 0, 0);
            tableLayoutPanel5.Controls.Add(SaveAsB, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(137, 101);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // LoadFileB
            // 
            LoadFileB.Anchor = AnchorStyles.Left;
            LoadFileB.AutoSize = true;
            LoadFileB.Location = new Point(5, 9);
            LoadFileB.Margin = new Padding(5);
            LoadFileB.Name = "LoadFileB";
            LoadFileB.Size = new Size(125, 32);
            LoadFileB.TabIndex = 1;
            LoadFileB.Text = "Choose from file";
            LoadFileB.UseVisualStyleBackColor = true;
            LoadFileB.Click += LoadFileB_Click;
            // 
            // SaveAsB
            // 
            SaveAsB.Anchor = AnchorStyles.Left;
            SaveAsB.AutoSize = true;
            SaveAsB.Enabled = false;
            SaveAsB.Location = new Point(5, 59);
            SaveAsB.Margin = new Padding(5);
            SaveAsB.Name = "SaveAsB";
            SaveAsB.Size = new Size(125, 33);
            SaveAsB.TabIndex = 3;
            SaveAsB.Text = "Save as";
            SaveAsB.UseVisualStyleBackColor = true;
            SaveAsB.Click += SaveAsB_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label1, 0, 0);
            tableLayoutPanel6.Controls.Add(RepresentationAdjR, 0, 1);
            tableLayoutPanel6.Controls.Add(RepresentationIncR, 0, 2);
            tableLayoutPanel6.Controls.Add(RepresentationEdgesR, 0, 3);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(146, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 4;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.Size = new Size(138, 101);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 10;
            label1.Text = "Graph representation:";
            // 
            // RepresentationAdjR
            // 
            RepresentationAdjR.Anchor = AnchorStyles.Left;
            RepresentationAdjR.AutoSize = true;
            RepresentationAdjR.Checked = true;
            RepresentationAdjR.Location = new Point(3, 28);
            RepresentationAdjR.Name = "RepresentationAdjR";
            RepresentationAdjR.Size = new Size(117, 19);
            RepresentationAdjR.TabIndex = 7;
            RepresentationAdjR.TabStop = true;
            RepresentationAdjR.Text = "Adjacency matrix";
            RepresentationAdjR.UseVisualStyleBackColor = true;
            // 
            // RepresentationIncR
            // 
            RepresentationIncR.Anchor = AnchorStyles.Left;
            RepresentationIncR.AutoSize = true;
            RepresentationIncR.Location = new Point(3, 53);
            RepresentationIncR.Name = "RepresentationIncR";
            RepresentationIncR.Size = new Size(113, 19);
            RepresentationIncR.TabIndex = 8;
            RepresentationIncR.TabStop = true;
            RepresentationIncR.Text = "Incidence matrix";
            RepresentationIncR.UseVisualStyleBackColor = true;
            // 
            // RepresentationEdgesR
            // 
            RepresentationEdgesR.Anchor = AnchorStyles.Left;
            RepresentationEdgesR.AutoSize = true;
            RepresentationEdgesR.Location = new Point(3, 78);
            RepresentationEdgesR.Name = "RepresentationEdgesR";
            RepresentationEdgesR.Size = new Size(77, 19);
            RepresentationEdgesR.TabIndex = 9;
            RepresentationEdgesR.TabStop = true;
            RepresentationEdgesR.Text = "Edges List";
            RepresentationEdgesR.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(GenerateRandB, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(287, 75);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // GenerateRandB
            // 
            GenerateRandB.Anchor = AnchorStyles.Right;
            GenerateRandB.Location = new Point(157, 12);
            GenerateRandB.Margin = new Padding(5);
            GenerateRandB.Name = "GenerateRandB";
            GenerateRandB.Size = new Size(125, 50);
            GenerateRandB.TabIndex = 2;
            GenerateRandB.Text = "Generate random";
            GenerateRandB.UseVisualStyleBackColor = true;
            GenerateRandB.Click += GenerateRandB_Click;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(label4, 0, 0);
            tableLayoutPanel11.Controls.Add(GenVertCountN, 0, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(137, 69);
            tableLayoutPanel11.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(21, 19);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 7;
            label4.Text = "Vertices amount:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GenVertCountN
            // 
            GenVertCountN.Anchor = AnchorStyles.Top;
            GenVertCountN.Location = new Point(3, 37);
            GenVertCountN.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            GenVertCountN.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            GenVertCountN.Name = "GenVertCountN";
            GenVertCountN.Size = new Size(131, 23);
            GenVertCountN.TabIndex = 6;
            GenVertCountN.TextAlign = HorizontalAlignment.Right;
            GenVertCountN.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(SaveVertexCoverB, 1, 0);
            tableLayoutPanel12.Controls.Add(AddVertexB, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 278);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(287, 75);
            tableLayoutPanel12.TabIndex = 23;
            // 
            // SaveVertexCoverB
            // 
            SaveVertexCoverB.Anchor = AnchorStyles.Right;
            SaveVertexCoverB.Enabled = false;
            SaveVertexCoverB.Location = new Point(159, 12);
            SaveVertexCoverB.Name = "SaveVertexCoverB";
            SaveVertexCoverB.Size = new Size(125, 50);
            SaveVertexCoverB.TabIndex = 0;
            SaveVertexCoverB.Text = "Save vertex cover";
            SaveVertexCoverB.UseVisualStyleBackColor = true;
            SaveVertexCoverB.Click += SaveVertexCoverB_Click;
            // 
            // AddVertexB
            // 
            AddVertexB.Anchor = AnchorStyles.Left;
            AddVertexB.Location = new Point(3, 12);
            AddVertexB.Name = "AddVertexB";
            AddVertexB.Size = new Size(125, 50);
            AddVertexB.TabIndex = 10;
            AddVertexB.Text = "Add vertex";
            AddVertexB.UseVisualStyleBackColor = true;
            AddVertexB.Click += AddVertexB_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.Controls.Add(ChangeEdgeVertexAD, 0, 0);
            tableLayoutPanel3.Controls.Add(ChangeEdgeVertexBD, 2, 0);
            tableLayoutPanel3.Controls.Add(label3, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 602);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(287, 76);
            tableLayoutPanel3.TabIndex = 22;
            // 
            // ChangeEdgeVertexAD
            // 
            ChangeEdgeVertexAD.Dock = DockStyle.Fill;
            ChangeEdgeVertexAD.FormattingEnabled = true;
            ChangeEdgeVertexAD.Location = new Point(3, 3);
            ChangeEdgeVertexAD.Name = "ChangeEdgeVertexAD";
            ChangeEdgeVertexAD.Size = new Size(94, 23);
            ChangeEdgeVertexAD.TabIndex = 15;
            // 
            // ChangeEdgeVertexBD
            // 
            ChangeEdgeVertexBD.Dock = DockStyle.Fill;
            ChangeEdgeVertexBD.FormattingEnabled = true;
            ChangeEdgeVertexBD.Location = new Point(189, 3);
            ChangeEdgeVertexBD.Name = "ChangeEdgeVertexBD";
            ChangeEdgeVertexBD.Size = new Size(95, 23);
            ChangeEdgeVertexBD.TabIndex = 14;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(104, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 0;
            label3.Text = "Chosen Edge\r\n<----------->";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(RemoveEdgeB, 1, 0);
            tableLayoutPanel9.Controls.Add(AddEdgeB, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 521);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(287, 75);
            tableLayoutPanel9.TabIndex = 21;
            // 
            // RemoveEdgeB
            // 
            RemoveEdgeB.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveEdgeB.Enabled = false;
            RemoveEdgeB.Location = new Point(159, 22);
            RemoveEdgeB.Name = "RemoveEdgeB";
            RemoveEdgeB.Size = new Size(125, 50);
            RemoveEdgeB.TabIndex = 13;
            RemoveEdgeB.Text = "Remove Edge";
            RemoveEdgeB.UseVisualStyleBackColor = true;
            RemoveEdgeB.Click += RemoveEdgeB_Click;
            // 
            // AddEdgeB
            // 
            AddEdgeB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddEdgeB.Enabled = false;
            AddEdgeB.Location = new Point(3, 22);
            AddEdgeB.Name = "AddEdgeB";
            AddEdgeB.Size = new Size(125, 50);
            AddEdgeB.TabIndex = 12;
            AddEdgeB.Text = "Add edge";
            AddEdgeB.UseVisualStyleBackColor = true;
            AddEdgeB.Click += AddEdgeB_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "MainForm";
            Text = "Vertex Cover";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GenVertCountN).EndInit();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel Canvas;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox ChangeEdgeVertexBD;
        private Label label3;
        private ComboBox ChangeEdgeVertexAD;
        private TableLayoutPanel tableLayoutPanel9;
        private Button RemoveEdgeB;
        private Button AddEdgeB;
        private TableLayoutPanel tableLayoutPanel8;
        private Button RemoveVertexB;
        private TableLayoutPanel tableLayoutPanel10;
        private ComboBox RemoveVertexD;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel7;
        private Button GreedyCoverB;
        private Button AproxCoverB;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button LoadFileB;
        private Button SaveAsB;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label1;
        private RadioButton RepresentationAdjR;
        private RadioButton RepresentationIncR;
        private RadioButton RepresentationEdgesR;
        private TableLayoutPanel tableLayoutPanel2;
        private NumericUpDown GenVertCountN;
        private Button GenerateRandB;
        private Button AddVertexB;
        private TableLayoutPanel tableLayoutPanel11;
        private Button SaveVertexCoverB;
        private TableLayoutPanel tableLayoutPanel12;
        private Button ClearGraphB;
    }
}
