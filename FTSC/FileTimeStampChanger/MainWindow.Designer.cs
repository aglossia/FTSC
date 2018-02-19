namespace FileTimeStampChanger
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreate = new System.Windows.Forms.TextBox();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.txtAccess = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtStepStart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderList = new System.Windows.Forms.ListBox();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.minUD = new System.Windows.Forms.NumericUpDown();
            this.secUD = new System.Windows.Forms.NumericUpDown();
            this.hourUD = new System.Windows.Forms.NumericUpDown();
            this.dayUD = new System.Windows.Forms.NumericUpDown();
            this.monthUD = new System.Windows.Forms.NumericUpDown();
            this.yearUD = new System.Windows.Forms.NumericUpDown();
            this.btnWriteFolder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStepEnd = new System.Windows.Forms.TextBox();
            this.folderOpen = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.folderSelect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUD)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(69, 36);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(204, 19);
            this.txtFileName.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(296, 31);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(45, 24);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "作成日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "最終更新日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "最終アクセス日";
            // 
            // txtCreate
            // 
            this.txtCreate.Location = new System.Drawing.Point(183, 87);
            this.txtCreate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(142, 19);
            this.txtCreate.TabIndex = 5;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(183, 128);
            this.txtUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(142, 19);
            this.txtUpdate.TabIndex = 6;
            // 
            // txtAccess
            // 
            this.txtAccess.Location = new System.Drawing.Point(183, 176);
            this.txtAccess.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccess.Name = "txtAccess";
            this.txtAccess.Size = new System.Drawing.Size(142, 19);
            this.txtAccess.TabIndex = 7;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(87, 223);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(45, 23);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(183, 223);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(2);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(45, 23);
            this.btnWrite.TabIndex = 9;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(280, 223);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtStepStart
            // 
            this.txtStepStart.Location = new System.Drawing.Point(69, 324);
            this.txtStepStart.Name = "txtStepStart";
            this.txtStepStart.Size = new System.Drawing.Size(45, 19);
            this.txtStepStart.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "ステップ";
            // 
            // folderList
            // 
            this.folderList.FormattingEnabled = true;
            this.folderList.ItemHeight = 12;
            this.folderList.Location = new System.Drawing.Point(24, 84);
            this.folderList.Name = "folderList";
            this.folderList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.folderList.Size = new System.Drawing.Size(184, 172);
            this.folderList.TabIndex = 13;
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(49, 35);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(358, 19);
            this.txtFolderName.TabIndex = 16;
            this.txtFolderName.Text = "E:\\work\\desktop\\test3";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(507, 418);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTest);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.folderSelect);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.minUD);
            this.tabPage1.Controls.Add(this.secUD);
            this.tabPage1.Controls.Add(this.hourUD);
            this.tabPage1.Controls.Add(this.dayUD);
            this.tabPage1.Controls.Add(this.monthUD);
            this.tabPage1.Controls.Add(this.yearUD);
            this.tabPage1.Controls.Add(this.btnWriteFolder);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtStepEnd);
            this.tabPage1.Controls.Add(this.folderOpen);
            this.tabPage1.Controls.Add(this.folderList);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtFolderName);
            this.tabPage1.Controls.Add(this.txtStepStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(499, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "フォルダ指定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(408, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 36;
            this.label13.Text = "秒";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(342, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 35;
            this.label12.Text = "分";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "時";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "日";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "月";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "年";
            // 
            // minUD
            // 
            this.minUD.Location = new System.Drawing.Point(344, 291);
            this.minUD.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.minUD.Name = "minUD";
            this.minUD.Size = new System.Drawing.Size(40, 19);
            this.minUD.TabIndex = 29;
            this.minUD.ValueChanged += new System.EventHandler(this.minUD_ValueChanged);
            // 
            // secUD
            // 
            this.secUD.Location = new System.Drawing.Point(410, 291);
            this.secUD.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.secUD.Name = "secUD";
            this.secUD.Size = new System.Drawing.Size(40, 19);
            this.secUD.TabIndex = 28;
            this.secUD.ValueChanged += new System.EventHandler(this.secUD_ValueChanged);
            // 
            // hourUD
            // 
            this.hourUD.Location = new System.Drawing.Point(277, 291);
            this.hourUD.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hourUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.hourUD.Name = "hourUD";
            this.hourUD.Size = new System.Drawing.Size(40, 19);
            this.hourUD.TabIndex = 27;
            this.hourUD.ValueChanged += new System.EventHandler(this.hourUD_ValueChanged);
            // 
            // dayUD
            // 
            this.dayUD.Location = new System.Drawing.Point(212, 291);
            this.dayUD.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.dayUD.Name = "dayUD";
            this.dayUD.Size = new System.Drawing.Size(40, 19);
            this.dayUD.TabIndex = 26;
            this.dayUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayUD.ValueChanged += new System.EventHandler(this.dayUD_ValueChanged);
            // 
            // monthUD
            // 
            this.monthUD.Location = new System.Drawing.Point(142, 291);
            this.monthUD.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.monthUD.Name = "monthUD";
            this.monthUD.Size = new System.Drawing.Size(40, 19);
            this.monthUD.TabIndex = 25;
            this.monthUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthUD.ValueChanged += new System.EventHandler(this.monthUD_ValueChanged);
            // 
            // yearUD
            // 
            this.yearUD.AllowDrop = true;
            this.yearUD.Location = new System.Drawing.Point(69, 291);
            this.yearUD.Maximum = new decimal(new int[] {
            2051,
            0,
            0,
            0});
            this.yearUD.Minimum = new decimal(new int[] {
            1969,
            0,
            0,
            0});
            this.yearUD.Name = "yearUD";
            this.yearUD.Size = new System.Drawing.Size(46, 19);
            this.yearUD.TabIndex = 24;
            this.yearUD.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.yearUD.ValueChanged += new System.EventHandler(this.yearUD_ValueChanged);
            // 
            // btnWriteFolder
            // 
            this.btnWriteFolder.Location = new System.Drawing.Point(294, 342);
            this.btnWriteFolder.Name = "btnWriteFolder";
            this.btnWriteFolder.Size = new System.Drawing.Size(75, 23);
            this.btnWriteFolder.TabIndex = 23;
            this.btnWriteFolder.Text = "Write";
            this.btnWriteFolder.UseVisualStyleBackColor = true;
            this.btnWriteFolder.Click += new System.EventHandler(this.btnWriteFolder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "分　～";
            // 
            // txtStepEnd
            // 
            this.txtStepEnd.Location = new System.Drawing.Point(163, 323);
            this.txtStepEnd.Name = "txtStepEnd";
            this.txtStepEnd.Size = new System.Drawing.Size(45, 19);
            this.txtStepEnd.TabIndex = 20;
            // 
            // folderOpen
            // 
            this.folderOpen.Location = new System.Drawing.Point(423, 33);
            this.folderOpen.Name = "folderOpen";
            this.folderOpen.Size = new System.Drawing.Size(75, 23);
            this.folderOpen.TabIndex = 18;
            this.folderOpen.Text = "Open";
            this.folderOpen.UseVisualStyleBackColor = true;
            this.folderOpen.Click += new System.EventHandler(this.folderOpen_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtFileName);
            this.tabPage2.Controls.Add(this.btnWrite);
            this.tabPage2.Controls.Add(this.btnOpen);
            this.tabPage2.Controls.Add(this.btnClose);
            this.tabPage2.Controls.Add(this.btnRead);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtAccess);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtCreate);
            this.tabPage2.Controls.Add(this.txtUpdate);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(499, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ファイル指定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // folderSelect
            // 
            this.folderSelect.Location = new System.Drawing.Point(26, 35);
            this.folderSelect.Name = "folderSelect";
            this.folderSelect.Size = new System.Drawing.Size(19, 19);
            this.folderSelect.TabIndex = 38;
            this.folderSelect.Text = "📁";
            this.folderSelect.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "ファイルリスト";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 40;
            this.label14.Text = "フォルダパス";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 41;
            this.label15.Text = "開始日時";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(230, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 172);
            this.listBox1.TabIndex = 42;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(423, 114);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(70, 54);
            this.btnTest.TabIndex = 43;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 442);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileTimeStampChanger";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUD)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreate;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.TextBox txtAccess;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtStepStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox folderList;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button folderOpen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStepEnd;
        private System.Windows.Forms.Button btnWriteFolder;
        private System.Windows.Forms.NumericUpDown minUD;
        private System.Windows.Forms.NumericUpDown secUD;
        private System.Windows.Forms.NumericUpDown hourUD;
        private System.Windows.Forms.NumericUpDown dayUD;
        private System.Windows.Forms.NumericUpDown monthUD;
        private System.Windows.Forms.NumericUpDown yearUD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button folderSelect;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ListBox listBox1;
    }
}

