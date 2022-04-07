
namespace SamePixelTool
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.labThreshold = new System.Windows.Forms.Label();
            this.btnLeftClear = new System.Windows.Forms.Button();
            this.btnLeftDel = new System.Windows.Forms.Button();
            this.btnLeftDown = new System.Windows.Forms.Button();
            this.lstLeft = new System.Windows.Forms.ListBox();
            this.btnLeftUp = new System.Windows.Forms.Button();
            this.trbThreshold = new System.Windows.Forms.TrackBar();
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.btnRightClear = new System.Windows.Forms.Button();
            this.btnRightDel = new System.Windows.Forms.Button();
            this.btnRightDown = new System.Windows.Forms.Button();
            this.btnRightUp = new System.Windows.Forms.Button();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.grpSavePath = new System.Windows.Forms.GroupBox();
            this.tlpSavePath = new System.Windows.Forms.TableLayoutPanel();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnBrower = new System.Windows.Forms.Button();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.tlpColor = new System.Windows.Forms.TableLayoutPanel();
            this.labBlue = new System.Windows.Forms.Label();
            this.labGreen = new System.Windows.Forms.Label();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.trbGreen = new System.Windows.Forms.TrackBar();
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.labRed = new System.Windows.Forms.Label();
            this.btnProcessing = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpMain.SuspendLayout();
            this.grpLeft.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbThreshold)).BeginInit();
            this.grpRight.SuspendLayout();
            this.tlpRight.SuspendLayout();
            this.grpSavePath.SuspendLayout();
            this.tlpSavePath.SuspendLayout();
            this.grpColor.SuspendLayout();
            this.tlpColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Controls.Add(this.grpLeft, 0, 1);
            this.tlpMain.Controls.Add(this.grpRight, 2, 1);
            this.tlpMain.Controls.Add(this.grpSavePath, 0, 0);
            this.tlpMain.Controls.Add(this.grpColor, 0, 2);
            this.tlpMain.Controls.Add(this.btnProcessing, 3, 2);
            this.tlpMain.Controls.Add(this.statusStrip, 0, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(944, 502);
            this.tlpMain.TabIndex = 0;
            // 
            // grpLeft
            // 
            this.tlpMain.SetColumnSpan(this.grpLeft, 2);
            this.grpLeft.Controls.Add(this.tlpLeft);
            this.grpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLeft.Location = new System.Drawing.Point(3, 63);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(466, 354);
            this.grpLeft.TabIndex = 0;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "图像列表(源图)";
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 2;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpLeft.Controls.Add(this.labThreshold, 1, 4);
            this.tlpLeft.Controls.Add(this.btnLeftClear, 1, 3);
            this.tlpLeft.Controls.Add(this.btnLeftDel, 1, 2);
            this.tlpLeft.Controls.Add(this.btnLeftDown, 1, 1);
            this.tlpLeft.Controls.Add(this.lstLeft, 0, 0);
            this.tlpLeft.Controls.Add(this.btnLeftUp, 1, 0);
            this.tlpLeft.Controls.Add(this.trbThreshold, 1, 5);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(3, 17);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 6;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLeft.Size = new System.Drawing.Size(460, 334);
            this.tlpLeft.TabIndex = 0;
            // 
            // labThreshold
            // 
            this.labThreshold.AutoSize = true;
            this.labThreshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labThreshold.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labThreshold.Location = new System.Drawing.Point(428, 140);
            this.labThreshold.Name = "labThreshold";
            this.labThreshold.Size = new System.Drawing.Size(29, 35);
            this.labThreshold.TabIndex = 6;
            this.labThreshold.Text = "10";
            this.labThreshold.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnLeftClear
            // 
            this.btnLeftClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeftClear.Enabled = false;
            this.btnLeftClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeftClear.Location = new System.Drawing.Point(428, 108);
            this.btnLeftClear.Name = "btnLeftClear";
            this.btnLeftClear.Size = new System.Drawing.Size(29, 29);
            this.btnLeftClear.TabIndex = 4;
            this.btnLeftClear.Text = "清";
            this.btnLeftClear.UseVisualStyleBackColor = true;
            this.btnLeftClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnLeftDel
            // 
            this.btnLeftDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeftDel.Enabled = false;
            this.btnLeftDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeftDel.Location = new System.Drawing.Point(428, 73);
            this.btnLeftDel.Name = "btnLeftDel";
            this.btnLeftDel.Size = new System.Drawing.Size(29, 29);
            this.btnLeftDel.TabIndex = 3;
            this.btnLeftDel.Text = "删";
            this.btnLeftDel.UseVisualStyleBackColor = true;
            this.btnLeftDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnLeftDown
            // 
            this.btnLeftDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeftDown.Enabled = false;
            this.btnLeftDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeftDown.Location = new System.Drawing.Point(428, 38);
            this.btnLeftDown.Name = "btnLeftDown";
            this.btnLeftDown.Size = new System.Drawing.Size(29, 29);
            this.btnLeftDown.TabIndex = 2;
            this.btnLeftDown.Text = "下";
            this.btnLeftDown.UseVisualStyleBackColor = true;
            this.btnLeftDown.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // lstLeft
            // 
            this.lstLeft.AllowDrop = true;
            this.lstLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.HorizontalScrollbar = true;
            this.lstLeft.ItemHeight = 12;
            this.lstLeft.Location = new System.Drawing.Point(3, 3);
            this.lstLeft.Name = "lstLeft";
            this.tlpLeft.SetRowSpan(this.lstLeft, 6);
            this.lstLeft.ScrollAlwaysVisible = true;
            this.lstLeft.Size = new System.Drawing.Size(419, 328);
            this.lstLeft.TabIndex = 0;
            this.lstLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.Control_DragDrop);
            this.lstLeft.DragEnter += new System.Windows.Forms.DragEventHandler(this.Control_DragEnter);
            // 
            // btnLeftUp
            // 
            this.btnLeftUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeftUp.Enabled = false;
            this.btnLeftUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeftUp.Location = new System.Drawing.Point(428, 3);
            this.btnLeftUp.Name = "btnLeftUp";
            this.btnLeftUp.Size = new System.Drawing.Size(29, 29);
            this.btnLeftUp.TabIndex = 1;
            this.btnLeftUp.Text = "上";
            this.btnLeftUp.UseVisualStyleBackColor = true;
            this.btnLeftUp.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // trbThreshold
            // 
            this.trbThreshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trbThreshold.Location = new System.Drawing.Point(428, 178);
            this.trbThreshold.Maximum = 255;
            this.trbThreshold.Name = "trbThreshold";
            this.trbThreshold.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbThreshold.Size = new System.Drawing.Size(29, 153);
            this.trbThreshold.TabIndex = 5;
            this.trbThreshold.TickFrequency = 16;
            this.trbThreshold.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trbThreshold.Value = 10;
            this.trbThreshold.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // grpRight
            // 
            this.tlpMain.SetColumnSpan(this.grpRight, 2);
            this.grpRight.Controls.Add(this.tlpRight);
            this.grpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRight.Location = new System.Drawing.Point(475, 63);
            this.grpRight.Name = "grpRight";
            this.grpRight.Size = new System.Drawing.Size(466, 354);
            this.grpRight.TabIndex = 1;
            this.grpRight.TabStop = false;
            this.grpRight.Text = "图像列表(背景)";
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 2;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpRight.Controls.Add(this.btnRightClear, 1, 3);
            this.tlpRight.Controls.Add(this.btnRightDel, 1, 2);
            this.tlpRight.Controls.Add(this.btnRightDown, 1, 1);
            this.tlpRight.Controls.Add(this.btnRightUp, 1, 0);
            this.tlpRight.Controls.Add(this.lstRight, 0, 0);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(3, 17);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 6;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRight.Size = new System.Drawing.Size(460, 334);
            this.tlpRight.TabIndex = 1;
            // 
            // btnRightClear
            // 
            this.btnRightClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRightClear.Enabled = false;
            this.btnRightClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRightClear.Location = new System.Drawing.Point(428, 108);
            this.btnRightClear.Name = "btnRightClear";
            this.btnRightClear.Size = new System.Drawing.Size(29, 29);
            this.btnRightClear.TabIndex = 8;
            this.btnRightClear.Text = "清";
            this.btnRightClear.UseVisualStyleBackColor = true;
            this.btnRightClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnRightDel
            // 
            this.btnRightDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRightDel.Enabled = false;
            this.btnRightDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRightDel.Location = new System.Drawing.Point(428, 73);
            this.btnRightDel.Name = "btnRightDel";
            this.btnRightDel.Size = new System.Drawing.Size(29, 29);
            this.btnRightDel.TabIndex = 7;
            this.btnRightDel.Text = "删";
            this.btnRightDel.UseVisualStyleBackColor = true;
            this.btnRightDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnRightDown
            // 
            this.btnRightDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRightDown.Enabled = false;
            this.btnRightDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRightDown.Location = new System.Drawing.Point(428, 38);
            this.btnRightDown.Name = "btnRightDown";
            this.btnRightDown.Size = new System.Drawing.Size(29, 29);
            this.btnRightDown.TabIndex = 6;
            this.btnRightDown.Text = "下";
            this.btnRightDown.UseVisualStyleBackColor = true;
            this.btnRightDown.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // btnRightUp
            // 
            this.btnRightUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRightUp.Enabled = false;
            this.btnRightUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRightUp.Location = new System.Drawing.Point(428, 3);
            this.btnRightUp.Name = "btnRightUp";
            this.btnRightUp.Size = new System.Drawing.Size(29, 29);
            this.btnRightUp.TabIndex = 5;
            this.btnRightUp.Text = "上";
            this.btnRightUp.UseVisualStyleBackColor = true;
            this.btnRightUp.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // lstRight
            // 
            this.lstRight.AllowDrop = true;
            this.lstRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRight.FormattingEnabled = true;
            this.lstRight.HorizontalScrollbar = true;
            this.lstRight.ItemHeight = 12;
            this.lstRight.Location = new System.Drawing.Point(3, 3);
            this.lstRight.Name = "lstRight";
            this.tlpRight.SetRowSpan(this.lstRight, 7);
            this.lstRight.ScrollAlwaysVisible = true;
            this.lstRight.Size = new System.Drawing.Size(419, 328);
            this.lstRight.TabIndex = 1;
            this.lstRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.Control_DragDrop);
            this.lstRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.Control_DragEnter);
            // 
            // grpSavePath
            // 
            this.tlpMain.SetColumnSpan(this.grpSavePath, 4);
            this.grpSavePath.Controls.Add(this.tlpSavePath);
            this.grpSavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSavePath.Location = new System.Drawing.Point(3, 3);
            this.grpSavePath.Name = "grpSavePath";
            this.grpSavePath.Size = new System.Drawing.Size(938, 54);
            this.grpSavePath.TabIndex = 2;
            this.grpSavePath.TabStop = false;
            this.grpSavePath.Text = "被处理图像保存位置";
            // 
            // tlpSavePath
            // 
            this.tlpSavePath.ColumnCount = 2;
            this.tlpSavePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSavePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpSavePath.Controls.Add(this.txtSavePath, 0, 0);
            this.tlpSavePath.Controls.Add(this.btnBrower, 1, 0);
            this.tlpSavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSavePath.Location = new System.Drawing.Point(3, 17);
            this.tlpSavePath.Name = "tlpSavePath";
            this.tlpSavePath.RowCount = 1;
            this.tlpSavePath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSavePath.Size = new System.Drawing.Size(932, 34);
            this.tlpSavePath.TabIndex = 0;
            // 
            // txtSavePath
            // 
            this.txtSavePath.AllowDrop = true;
            this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavePath.Location = new System.Drawing.Point(3, 6);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(846, 21);
            this.txtSavePath.TabIndex = 0;
            this.txtSavePath.TextChanged += new System.EventHandler(this.TxtSavePath_TextChanged);
            this.txtSavePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.Control_DragDrop);
            this.txtSavePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.Control_DragEnter);
            // 
            // btnBrower
            // 
            this.btnBrower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrower.Location = new System.Drawing.Point(855, 3);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(74, 28);
            this.btnBrower.TabIndex = 1;
            this.btnBrower.Text = "浏览";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler(this.BtnBrower_Click);
            // 
            // grpColor
            // 
            this.tlpMain.SetColumnSpan(this.grpColor, 3);
            this.grpColor.Controls.Add(this.tlpColor);
            this.grpColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpColor.Location = new System.Drawing.Point(3, 423);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(702, 54);
            this.grpColor.TabIndex = 3;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "同像素填充颜色";
            this.grpColor.Visible = false;
            // 
            // tlpColor
            // 
            this.tlpColor.ColumnCount = 6;
            this.tlpColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpColor.Controls.Add(this.labBlue, 5, 0);
            this.tlpColor.Controls.Add(this.labGreen, 3, 0);
            this.tlpColor.Controls.Add(this.trbBlue, 4, 0);
            this.tlpColor.Controls.Add(this.trbGreen, 2, 0);
            this.tlpColor.Controls.Add(this.trbRed, 0, 0);
            this.tlpColor.Controls.Add(this.labRed, 1, 0);
            this.tlpColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpColor.Location = new System.Drawing.Point(3, 17);
            this.tlpColor.Name = "tlpColor";
            this.tlpColor.RowCount = 1;
            this.tlpColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpColor.Size = new System.Drawing.Size(696, 34);
            this.tlpColor.TabIndex = 0;
            // 
            // labBlue
            // 
            this.labBlue.AutoSize = true;
            this.labBlue.BackColor = System.Drawing.Color.White;
            this.labBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labBlue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBlue.Location = new System.Drawing.Point(653, 0);
            this.labBlue.Name = "labBlue";
            this.labBlue.Size = new System.Drawing.Size(40, 34);
            this.labBlue.TabIndex = 6;
            this.labBlue.Text = "000";
            this.labBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labGreen
            // 
            this.labGreen.AutoSize = true;
            this.labGreen.BackColor = System.Drawing.Color.White;
            this.labGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labGreen.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGreen.Location = new System.Drawing.Point(423, 0);
            this.labGreen.Name = "labGreen";
            this.labGreen.Size = new System.Drawing.Size(34, 34);
            this.labGreen.TabIndex = 5;
            this.labGreen.Text = "000";
            this.labGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trbBlue
            // 
            this.trbBlue.BackColor = System.Drawing.Color.Blue;
            this.trbBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trbBlue.Location = new System.Drawing.Point(463, 3);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(184, 28);
            this.trbBlue.TabIndex = 2;
            this.trbBlue.TickFrequency = 16;
            this.trbBlue.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // trbGreen
            // 
            this.trbGreen.BackColor = System.Drawing.Color.Green;
            this.trbGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trbGreen.Location = new System.Drawing.Point(233, 3);
            this.trbGreen.Maximum = 255;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Size = new System.Drawing.Size(184, 28);
            this.trbGreen.TabIndex = 1;
            this.trbGreen.TickFrequency = 16;
            this.trbGreen.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // trbRed
            // 
            this.trbRed.BackColor = System.Drawing.Color.Red;
            this.trbRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trbRed.Location = new System.Drawing.Point(3, 3);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(184, 28);
            this.trbRed.TabIndex = 0;
            this.trbRed.TickFrequency = 16;
            this.trbRed.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // labRed
            // 
            this.labRed.AutoSize = true;
            this.labRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labRed.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRed.Location = new System.Drawing.Point(193, 0);
            this.labRed.Name = "labRed";
            this.labRed.Size = new System.Drawing.Size(34, 34);
            this.labRed.TabIndex = 4;
            this.labRed.Text = "000";
            this.labRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProcessing
            // 
            this.btnProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcessing.Location = new System.Drawing.Point(711, 423);
            this.btnProcessing.Name = "btnProcessing";
            this.btnProcessing.Size = new System.Drawing.Size(230, 54);
            this.btnProcessing.TabIndex = 4;
            this.btnProcessing.Text = "透明化同像素";
            this.btnProcessing.UseVisualStyleBackColor = true;
            this.btnProcessing.Click += new System.EventHandler(this.BtnProcessing_Click);
            // 
            // statusStrip
            // 
            this.tlpMain.SetColumnSpan(this.statusStrip, 4);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.tsLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 480);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(944, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(200, 16);
            this.toolStripProgressBar.Step = 1;
            // 
            // tsLabel
            // 
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(27, 17);
            this.tsLabel.Text = "0/0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 502);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FrmMain";
            this.Text = "同像素透明化处理工具";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.grpLeft.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            this.tlpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbThreshold)).EndInit();
            this.grpRight.ResumeLayout(false);
            this.tlpRight.ResumeLayout(false);
            this.grpSavePath.ResumeLayout(false);
            this.tlpSavePath.ResumeLayout(false);
            this.tlpSavePath.PerformLayout();
            this.grpColor.ResumeLayout(false);
            this.tlpColor.ResumeLayout(false);
            this.tlpColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.Button btnLeftClear;
        private System.Windows.Forms.Button btnLeftDel;
        private System.Windows.Forms.Button btnLeftDown;
        private System.Windows.Forms.Button btnLeftUp;
        private System.Windows.Forms.Button btnRightClear;
        private System.Windows.Forms.Button btnRightDel;
        private System.Windows.Forms.Button btnRightDown;
        private System.Windows.Forms.Button btnRightUp;
        private System.Windows.Forms.ListBox lstRight;
        private System.Windows.Forms.GroupBox grpSavePath;
        private System.Windows.Forms.TableLayoutPanel tlpSavePath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.Button btnProcessing;
        private System.Windows.Forms.TableLayoutPanel tlpColor;
        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.TrackBar trbGreen;
        private System.Windows.Forms.TrackBar trbRed;
        private System.Windows.Forms.Label labBlue;
        private System.Windows.Forms.Label labGreen;
        private System.Windows.Forms.Label labRed;
        private System.Windows.Forms.Label labThreshold;
        private System.Windows.Forms.TrackBar trbThreshold;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel tsLabel;
    }
}

