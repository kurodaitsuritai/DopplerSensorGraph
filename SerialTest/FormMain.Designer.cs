namespace SerialTest
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonData = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonCOMClose = new System.Windows.Forms.Button();
            this.textBoxComPortName = new System.Windows.Forms.TextBox();
            this.buttonCOMOpen = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxRecv = new System.Windows.Forms.TextBox();
            this.saveFileDialogText = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogText = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClub13 = new System.Windows.Forms.Button();
            this.buttonClub12 = new System.Windows.Forms.Button();
            this.buttonClub11 = new System.Windows.Forms.Button();
            this.buttonClub10 = new System.Windows.Forms.Button();
            this.buttonClub9 = new System.Windows.Forms.Button();
            this.buttonClub8 = new System.Windows.Forms.Button();
            this.buttonClub7 = new System.Windows.Forms.Button();
            this.buttonClub6 = new System.Windows.Forms.Button();
            this.buttonClub5 = new System.Windows.Forms.Button();
            this.buttonClub4 = new System.Windows.Forms.Button();
            this.buttonClub3 = new System.Windows.Forms.Button();
            this.buttonClub2 = new System.Windows.Forms.Button();
            this.buttonClub1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHS = new System.Windows.Forms.TextBox();
            this.textBoxBS = new System.Windows.Forms.TextBox();
            this.textBoxSF = new System.Windows.Forms.TextBox();
            this.textBoxYDS = new System.Windows.Forms.TextBox();
            this.labelHS = new System.Windows.Forms.Label();
            this.labelBS = new System.Windows.Forms.Label();
            this.labelSF = new System.Windows.Forms.Label();
            this.labelYDS = new System.Windows.Forms.Label();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.buttonSaveResult = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox1.Location = new System.Drawing.Point(549, 6);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1353, 77);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonData);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonSend);
            this.panel1.Controls.Add(this.textBoxCommand);
            this.panel1.Controls.Add(this.buttonCOMClose);
            this.panel1.Controls.Add(this.textBoxComPortName);
            this.panel1.Controls.Add(this.buttonCOMOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 256);
            this.panel1.TabIndex = 0;
            // 
            // buttonData
            // 
            this.buttonData.Location = new System.Drawing.Point(333, 42);
            this.buttonData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(100, 29);
            this.buttonData.TabIndex = 9;
            this.buttonData.Text = "再表示通信";
            this.buttonData.UseVisualStyleBackColor = true;
            this.buttonData.Click += new System.EventHandler(this.buttonData_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(441, 6);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(100, 29);
            this.buttonOpen.TabIndex = 8;
            this.buttonOpen.Text = "ファイル開く";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(333, 6);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 29);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "ファイル保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buttonClear.Location = new System.Drawing.Point(441, 42);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 29);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "データー消去";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(225, 42);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 29);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "コマンド送信";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.AcceptsReturn = true;
            this.textBoxCommand.Location = new System.Drawing.Point(16, 42);
            this.textBoxCommand.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCommand.Multiline = true;
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(200, 23);
            this.textBoxCommand.TabIndex = 4;
            this.textBoxCommand.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // buttonCOMClose
            // 
            this.buttonCOMClose.Location = new System.Drawing.Point(225, 6);
            this.buttonCOMClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCOMClose.Name = "buttonCOMClose";
            this.buttonCOMClose.Size = new System.Drawing.Size(100, 29);
            this.buttonCOMClose.TabIndex = 3;
            this.buttonCOMClose.Text = "切断(&X)";
            this.buttonCOMClose.UseVisualStyleBackColor = true;
            this.buttonCOMClose.Click += new System.EventHandler(this.buttonCOMClose_Click);
            // 
            // textBoxComPortName
            // 
            this.textBoxComPortName.Location = new System.Drawing.Point(16, 9);
            this.textBoxComPortName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComPortName.Name = "textBoxComPortName";
            this.textBoxComPortName.Size = new System.Drawing.Size(92, 22);
            this.textBoxComPortName.TabIndex = 1;
            this.textBoxComPortName.Text = "COM11";
            this.textBoxComPortName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonCOMOpen
            // 
            this.buttonCOMOpen.Location = new System.Drawing.Point(117, 6);
            this.buttonCOMOpen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCOMOpen.Name = "buttonCOMOpen";
            this.buttonCOMOpen.Size = new System.Drawing.Size(100, 29);
            this.buttonCOMOpen.TabIndex = 2;
            this.buttonCOMOpen.Text = "接続(&C)";
            this.buttonCOMOpen.UseVisualStyleBackColor = true;
            this.buttonCOMOpen.Click += new System.EventHandler(this.buttonCOMOpen_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 304);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTimeOffset;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1547, 354);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // textBoxRecv
            // 
            this.textBoxRecv.Location = new System.Drawing.Point(16, 91);
            this.textBoxRecv.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRecv.Multiline = true;
            this.textBoxRecv.Name = "textBoxRecv";
            this.textBoxRecv.Size = new System.Drawing.Size(1545, 204);
            this.textBoxRecv.TabIndex = 2;
            this.textBoxRecv.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // saveFileDialogText
            // 
            this.saveFileDialogText.DefaultExt = "txt";
            this.saveFileDialogText.Filter = "テキストファイル|*.txt";
            this.saveFileDialogText.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogText_FileOk);
            // 
            // openFileDialogText
            // 
            this.openFileDialogText.Filter = "テキストファイル|*.txt";
            this.openFileDialogText.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogText_FileOk);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 13;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.Controls.Add(this.buttonClub13, 12, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClub12, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClub11, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClub10, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClub9, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClub8, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClub7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClub6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClub5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClub4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClub3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClub2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClub1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 669);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1547, 91);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonClub13
            // 
            this.buttonClub13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClub13.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClub13.Location = new System.Drawing.Point(1426, 4);
            this.buttonClub13.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClub13.Name = "buttonClub13";
            this.buttonClub13.Size = new System.Drawing.Size(117, 83);
            this.buttonClub13.TabIndex = 12;
            this.buttonClub13.Text = "SW";
            this.buttonClub13.UseVisualStyleBackColor = true;
            // 
            // buttonClub12
            // 
            this.buttonClub12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClub12.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClub12.Location = new System.Drawing.Point(1307, 4);
            this.buttonClub12.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClub12.Name = "buttonClub12";
            this.buttonClub12.Size = new System.Drawing.Size(111, 83);
            this.buttonClub12.TabIndex = 11;
            this.buttonClub12.Text = "AW";
            this.buttonClub12.UseVisualStyleBackColor = true;
            // 
            // buttonClub11
            // 
            this.buttonClub11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClub11.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClub11.Location = new System.Drawing.Point(1188, 4);
            this.buttonClub11.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClub11.Name = "buttonClub11";
            this.buttonClub11.Size = new System.Drawing.Size(111, 83);
            this.buttonClub11.TabIndex = 10;
            this.buttonClub11.Text = "PW";
            this.buttonClub11.UseVisualStyleBackColor = true;
            // 
            // buttonClub10
            // 
            this.buttonClub10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClub10.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClub10.Location = new System.Drawing.Point(1069, 4);
            this.buttonClub10.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClub10.Name = "buttonClub10";
            this.buttonClub10.Size = new System.Drawing.Size(111, 83);
            this.buttonClub10.TabIndex = 9;
            this.buttonClub10.Text = "9I";
            this.buttonClub10.UseVisualStyleBackColor = true;
            // 
            // buttonClub9
            // 
            this.buttonClub9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClub9.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClub9.Location = new System.Drawing.Point(950, 4);
            this.buttonClub9.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClub9.Name = "buttonClub9";
            this.buttonClub9.Size = new System.Drawing.Size(111, 83);
            this.buttonClub9.TabIndex = 8;
            this.buttonClub9.Text = "8I";
            this.buttonClub9.UseVisualStyleBackColor = true;
            // 
            // buttonClub8
            // 
            this.buttonClub8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClub8.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClub8.Location = new System.Drawing.Point(831, 4);
            this.buttonClub8.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClub8.Name = "buttonClub8";
            this.buttonClub8.Size = new System.Drawing.Size(111, 83);
            this.buttonClub8.TabIndex = 7;
            this.buttonClub8.Text = "7I";
            this.buttonClub8.UseVisualStyleBackColor = true;
            // 
            // buttonClub7
            // 
            this.buttonClub7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClub7.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClub7.Location = new System.Drawing.Point(712, 4);
            this.buttonClub7.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClub7.Name = "buttonClub7";
            this.buttonClub7.Size = new System.Drawing.Size(111, 83);
            this.buttonClub7.TabIndex = 6;
            this.buttonClub7.Text = "6I";
            this.buttonClub7.UseVisualStyleBackColor = true;
            // 
            // buttonClub6
            // 
            this.buttonClub6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClub6.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClub6.Location = new System.Drawing.Point(604, 4);
            this.buttonClub6.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClub6.Name = "buttonClub6";
            this.buttonClub6.Size = new System.Drawing.Size(100, 83);
            this.buttonClub6.TabIndex = 5;
            this.buttonClub6.Text = "5I";
            this.buttonClub6.UseVisualStyleBackColor = true;
            // 
            // buttonClub5
            // 
            this.buttonClub5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClub5.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClub5.Location = new System.Drawing.Point(480, 4);
            this.buttonClub5.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClub5.Name = "buttonClub5";
            this.buttonClub5.Size = new System.Drawing.Size(116, 83);
            this.buttonClub5.TabIndex = 4;
            this.buttonClub5.Text = "4U";
            this.buttonClub5.UseVisualStyleBackColor = true;
            // 
            // buttonClub4
            // 
            this.buttonClub4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClub4.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClub4.Location = new System.Drawing.Point(361, 4);
            this.buttonClub4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClub4.Name = "buttonClub4";
            this.buttonClub4.Size = new System.Drawing.Size(111, 83);
            this.buttonClub4.TabIndex = 3;
            this.buttonClub4.Text = "3U";
            this.buttonClub4.UseVisualStyleBackColor = true;
            // 
            // buttonClub3
            // 
            this.buttonClub3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClub3.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClub3.Location = new System.Drawing.Point(242, 4);
            this.buttonClub3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClub3.Name = "buttonClub3";
            this.buttonClub3.Size = new System.Drawing.Size(111, 83);
            this.buttonClub3.TabIndex = 2;
            this.buttonClub3.Text = "5W";
            this.buttonClub3.UseVisualStyleBackColor = true;
            // 
            // buttonClub2
            // 
            this.buttonClub2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClub2.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClub2.Location = new System.Drawing.Point(123, 4);
            this.buttonClub2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClub2.Name = "buttonClub2";
            this.buttonClub2.Size = new System.Drawing.Size(111, 83);
            this.buttonClub2.TabIndex = 1;
            this.buttonClub2.Text = "3W";
            this.buttonClub2.UseVisualStyleBackColor = true;
            // 
            // buttonClub1
            // 
            this.buttonClub1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClub1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonClub1.Location = new System.Drawing.Point(4, 4);
            this.buttonClub1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClub1.Name = "buttonClub1";
            this.buttonClub1.Size = new System.Drawing.Size(111, 83);
            this.buttonClub1.TabIndex = 0;
            this.buttonClub1.Text = "1W";
            this.buttonClub1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.textBoxHS, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxBS, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSF, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBoxYDS, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelHS, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelBS, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelSF, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelYDS, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMemo, 1, 8);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1571, 91);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(333, 496);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(4, 440);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 56);
            this.label9.TabIndex = 3;
            this.label9.Text = "メモ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "HS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "BS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(4, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "S/F";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(4, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 55);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yds";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(4, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 55);
            this.label5.TabIndex = 0;
            this.label5.Text = "HS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(4, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 55);
            this.label6.TabIndex = 0;
            this.label6.Text = "BS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(4, 330);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 55);
            this.label7.TabIndex = 0;
            this.label7.Text = "S/F";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(4, 385);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 55);
            this.label8.TabIndex = 0;
            this.label8.Text = "Yds";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxHS
            // 
            this.textBoxHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHS.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxHS.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxHS.Location = new System.Drawing.Point(137, 224);
            this.textBoxHS.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHS.Name = "textBoxHS";
            this.textBoxHS.Size = new System.Drawing.Size(192, 54);
            this.textBoxHS.TabIndex = 1;
            this.textBoxHS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBS
            // 
            this.textBoxBS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBS.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxBS.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxBS.Location = new System.Drawing.Point(137, 279);
            this.textBoxBS.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBS.Name = "textBoxBS";
            this.textBoxBS.Size = new System.Drawing.Size(192, 54);
            this.textBoxBS.TabIndex = 1;
            this.textBoxBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSF
            // 
            this.textBoxSF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSF.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSF.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxSF.Location = new System.Drawing.Point(137, 334);
            this.textBoxSF.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSF.Name = "textBoxSF";
            this.textBoxSF.Size = new System.Drawing.Size(192, 54);
            this.textBoxSF.TabIndex = 1;
            this.textBoxSF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxYDS
            // 
            this.textBoxYDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxYDS.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxYDS.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxYDS.Location = new System.Drawing.Point(137, 389);
            this.textBoxYDS.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYDS.Name = "textBoxYDS";
            this.textBoxYDS.Size = new System.Drawing.Size(192, 54);
            this.textBoxYDS.TabIndex = 1;
            this.textBoxYDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHS
            // 
            this.labelHS.AutoSize = true;
            this.labelHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHS.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHS.Location = new System.Drawing.Point(137, 0);
            this.labelHS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHS.Name = "labelHS";
            this.labelHS.Size = new System.Drawing.Size(192, 55);
            this.labelHS.TabIndex = 2;
            this.labelHS.Text = "123.4";
            this.labelHS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBS
            // 
            this.labelBS.AutoSize = true;
            this.labelBS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBS.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelBS.Location = new System.Drawing.Point(137, 55);
            this.labelBS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBS.Name = "labelBS";
            this.labelBS.Size = new System.Drawing.Size(192, 55);
            this.labelBS.TabIndex = 2;
            this.labelBS.Text = "123.4";
            this.labelBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSF
            // 
            this.labelSF.AutoSize = true;
            this.labelSF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSF.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSF.Location = new System.Drawing.Point(137, 110);
            this.labelSF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSF.Name = "labelSF";
            this.labelSF.Size = new System.Drawing.Size(192, 55);
            this.labelSF.TabIndex = 2;
            this.labelSF.Text = "123.4";
            this.labelSF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYDS
            // 
            this.labelYDS.AutoSize = true;
            this.labelYDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelYDS.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelYDS.Location = new System.Drawing.Point(137, 165);
            this.labelYDS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYDS.Name = "labelYDS";
            this.labelYDS.Size = new System.Drawing.Size(192, 55);
            this.labelYDS.TabIndex = 2;
            this.labelYDS.Text = "123.4";
            this.labelYDS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMemo.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxMemo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxMemo.Location = new System.Drawing.Point(137, 444);
            this.textBoxMemo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new System.Drawing.Size(192, 54);
            this.textBoxMemo.TabIndex = 1;
            this.textBoxMemo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSaveResult
            // 
            this.buttonSaveResult.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSaveResult.Location = new System.Drawing.Point(1571, 597);
            this.buttonSaveResult.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveResult.Name = "buttonSaveResult";
            this.buttonSaveResult.Size = new System.Drawing.Size(336, 61);
            this.buttonSaveResult.TabIndex = 5;
            this.buttonSaveResult.Text = "保存";
            this.buttonSaveResult.UseVisualStyleBackColor = true;
            this.buttonSaveResult.Click += new System.EventHandler(this.buttonSaveResult_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 775);
            this.Controls.Add(this.buttonSaveResult);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBoxRecv);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "シリアルポート利用サンプル";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button buttonCOMClose;
        private System.Windows.Forms.TextBox textBoxComPortName;
        private System.Windows.Forms.Button buttonCOMOpen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxRecv;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialogText;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialogText;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonClub1;
        private System.Windows.Forms.Button buttonClub13;
        private System.Windows.Forms.Button buttonClub12;
        private System.Windows.Forms.Button buttonClub11;
        private System.Windows.Forms.Button buttonClub10;
        private System.Windows.Forms.Button buttonClub9;
        private System.Windows.Forms.Button buttonClub8;
        private System.Windows.Forms.Button buttonClub7;
        private System.Windows.Forms.Button buttonClub6;
        private System.Windows.Forms.Button buttonClub5;
        private System.Windows.Forms.Button buttonClub4;
        private System.Windows.Forms.Button buttonClub3;
        private System.Windows.Forms.Button buttonClub2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxHS;
        private System.Windows.Forms.TextBox textBoxBS;
        private System.Windows.Forms.TextBox textBoxSF;
        private System.Windows.Forms.TextBox textBoxYDS;
        private System.Windows.Forms.Label labelHS;
        private System.Windows.Forms.Label labelBS;
        private System.Windows.Forms.Label labelSF;
        private System.Windows.Forms.Label labelYDS;
        private System.Windows.Forms.Button buttonSaveResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMemo;
    }
}

