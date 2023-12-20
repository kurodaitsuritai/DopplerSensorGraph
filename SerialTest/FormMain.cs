using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;



namespace SerialTest
{

    public partial class FormMain : Form
    {
        #region PInvoke

        [DllImport("setupapi.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetupDiGetClassDevs(ref Guid classGuid, [MarshalAs(UnmanagedType.LPTStr)] string enumerator, IntPtr hwndParent, uint flags);

        [DllImport("setupapi.dll")]
        public static extern bool SetupDiEnumDeviceInfo(IntPtr deviceInfoSet, uint memberIndex, ref SP_DEVINFO_DATA deviceInfoData);

        [DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetupDiGetDeviceRegistryProperty(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, uint property, out UInt32 propertyRegDataType, byte[] propertyBuffer, uint propertyBufferSize, out UInt32 requiredSize);

        [DllImport("msports.dll")]
        public static extern int SerialDisplayAdvancedSettings(IntPtr parentHwnd, IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData);

        [DllImport("setupapi.dll", SetLastError = true)]
        public static extern bool SetupDiDestroyDeviceInfoList(IntPtr DeviceInfoSet);

        [StructLayout(LayoutKind.Sequential)]
        public struct SP_DEVINFO_DATA
        {
            public UInt32 CbSize;
            public Guid ClassGuid;
            public UInt32 DevInst;
            public IntPtr Reserved;
        }

        #endregion // PInvoke

        public int OK = 0;
        public int nnn = 0;
        public int num = 0;
        static int[] t = new int[2000];

//        int pt, temp;
//        string wk;


        int[] array = new int[1000];

        #region フィールド

        /// <summary>
        /// クラブ選択ボタン配列
        /// </summary>
        private Button[] buttonClubArray;

        /// <summary>
        /// 最後に選択されたクラブ番号
        /// </summary>
        private int m_LastSelectedClubIndex = -1;

        /// <summary>
        /// 受信終了監視タイマー
        /// </summary>
        private Timer m_RecvCompletedCheckTimer = new Timer();

        private int m_RecvTextLength = 0;
        #endregion フィールド

        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            // クラブ選択ボタンの配列化
            buttonClubArray = new Button[]
            {
                buttonClub1, 
                buttonClub2, 
                buttonClub3, 
                buttonClub4, 
                buttonClub5,
                buttonClub6, 
                buttonClub7, 
                buttonClub8, 
                buttonClub9,
                buttonClub10, 
                buttonClub11, 
                buttonClub12, 
                buttonClub13
            };

            // クラブ選択ボタンにコマンドを設定する
            buttonClub1.Tag = "DZ 1";
            buttonClub2.Tag = "DZ 2";
            buttonClub3.Tag = "DZ 2";
            buttonClub4.Tag = "DZ 2";
            buttonClub5.Tag = "DZ 2";
            buttonClub6.Tag = "DZ 2";
            buttonClub7.Tag = "DZ 2";
            buttonClub8.Tag = "DZ 2";
            buttonClub9.Tag = "DZ 2";
            buttonClub10.Tag = "DZ 2";
            buttonClub11.Tag = "DZ 3";
            buttonClub12.Tag = "DZ 3";
            buttonClub13.Tag = "DZ 3";

            // クラブ選択ボタンのイベント登録
            foreach( var b in buttonClubArray)
            {
                b.Click += (ss, ee) =>
                {
                    //foreach( var btn in buttonClubArray)
                    for( int i=0; i<buttonClubArray.Length; i++)
                    {
                        var btn = buttonClubArray[i];
                        if( btn == ss)
                        {
                            btn.BackColor = Color.Cyan;
                            m_LastSelectedClubIndex = i;
                        }
                        else
                        {
                            btn.BackColor = Color.WhiteSmoke;
                        }
                    }

                    // コマンドを送信する
                    textBoxCommand.Text = (ss as Button).Tag as string; ;
                    buttonSend.PerformClick();

                };
            }

        }

        #endregion コンストラクタ

        #region GUIイベント

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender">送信元オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // USB-Serialポートの検索
            const uint vid = 0x0403;
            const uint pid = 0x6015;
            var comPort = find_comport(vid, pid);
            if( !string.IsNullOrEmpty(comPort))
            {
                // COMポート名をテキストボックスに設定
                textBoxComPortName.Text = comPort;

                // 接続ボタンをクリックする
                buttonCOMOpen.PerformClick();
                System.Threading.Thread.Sleep(100);

                // 結果をクリアする
                ClearResult(false);

                // 「RESET」コマンドを送信する
                textBoxCommand.Text = "RESET";
                buttonSend.PerformClick();
                System.Threading.Thread.Sleep(200);

                // 「DG 1」コマンドを送信する
                textBoxCommand.Text = "DG 1";
                buttonSend.PerformClick();
                System.Threading.Thread.Sleep(200);

                //// 「DZ 3」コマンドを送信する
                //textBoxCommand.Text = "DZ 3";
                //buttonSend.PerformClick();

                // 「1W」ボタンをクリックする
                buttonClub1.PerformClick();

            }
        }

        /// <summary>
        /// Shown
        /// </summary>
        /// <param name="sender">送信元オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            // 受信終了監視タイマーの設定
            m_RecvCompletedCheckTimer.Interval = 200;
            m_RecvCompletedCheckTimer.Tick += (ss, ee) =>
            {
                if( textBoxRecv.Text.Length != m_RecvTextLength)
                {
                    m_RecvTextLength = textBoxRecv.Text.Length;
                }
                else
                {
                    chart1_Click(chart1, new EventArgs());
                    m_RecvCompletedCheckTimer.Stop();

                    // 結果を表示する
                    ShowResult();
                }
            };
        }

        #endregion GUIイベント

        /// <summary>
        /// [接続]ボタンをクリックした場合の処理。
        /// 当該COMポートが利用可能な場合は接続を行う。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCOMOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    MessageBox.Show(this.textBoxComPortName.Text + " はすでに開かれています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // ポート番号文字列=this.textBox1.Text, 115200bps/N81/ハードウェアフロー/UTF8/改行=CR
                    this.serialPort1.PortName = this.textBoxComPortName.Text;
                    this.serialPort1.BaudRate = 19200;
                    this.serialPort1.Parity = System.IO.Ports.Parity.None;
                    this.serialPort1.DataBits = 8;
                    this.serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    this.serialPort1.Handshake = System.IO.Ports.Handshake.RequestToSend;
                    this.serialPort1.Encoding = Encoding.UTF8;
                    this.serialPort1.NewLine = "\r\n";
                    serialPort1.Open();

                    this.buttonCOMOpen.Enabled = false;
                    this.buttonCOMClose.Enabled = true;
                }

                // 「COMポート名」テキストボックスを無効化する
                textBoxComPortName.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// [切断]ボタンをクリックした場合の処理。
        /// 現在開いているCOMポートを切断する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCOMClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                this.buttonCOMOpen.Enabled = true;
                this.buttonCOMClose.Enabled = false;

                // 「COMポート名」テキストボックスを有効化する
                textBoxComPortName.Enabled = true;
            }
        }

        /// <summary>
        /// [送信]ボタンをクリックした場合の処理。
        /// 入力フォーム内の文字列を送信する。入力フォームには複数行の文字列を
        /// 貼り付け可能。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendString();
        }

        /// <summary>
        /// 入力フォーム内でEnterキーを押した場合の処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBoxCommand.Text += "\r\n";
                SendString();
            }
        }

        /// <summary>
        /// 送信処理。改行コードは接続時に設定したものに変更する。
        /// </summary>
        /// <param name="text">送信文字列</param>
        private void SendString(string text)
        {
            try
            {
                text = text + "\r" + "\n";
                this.serialPort1.Write(text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SendString()
        {
            string str = this.textBoxCommand.Text;
            str = str.Replace("\r\n", serialPort1.NewLine);
            SendString(str);

            this.textBoxCommand.Text = "";
            this.textBoxCommand.Focus();
        }

        /// <summary>
        /// 受信処理。本メソッドはFormとは別スレッドで処理されるため、
        /// Formの値の書き換えを行う場合にはdelegateを利用してForm側のスレッドで処理させる。
        /// </summary>
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // 受信文字列の取得
            string receivedData;
            try
            {
                receivedData = this.serialPort1.ReadExisting();
                receivedData = receivedData.Replace(this.serialPort1.NewLine, "\r\n");

                // 「321」で始まる場合は、既存の受信データをクリアする
                if(receivedData.StartsWith("321"))
                {
                    Invoke((MethodInvoker)delegate {
                        ClearResult(true);
                        buttonClear.PerformClick(); 
                    });

                    // 受信完了監視タイマーを起動する
                    Invoke((MethodInvoker)delegate {
                        m_RecvTextLength = 0;
                        m_RecvCompletedCheckTimer.Start();
                    });
                }
                

            }
            catch (Exception ex)
            {
                receivedData = ex.Message;
            }

            // richTextBox側のスレッドに AddRecievedDataメソッドのポインタを渡して、
            // 受信文字列を追加させる
            AddRecievedDataDelegate add = new AddRecievedDataDelegate(AddRecievedData);
            this.richTextBox1.Invoke(add, receivedData);
        }
        private delegate void AddRecievedDataDelegate(string data);
        private void AddRecievedData(string data)
        {
            this.richTextBox1.Text += data;


            // 表示部の最後までスクロール
            this.richTextBox1.Focus();
            this.richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            this.richTextBox1.ScrollToCaret();

            // 入力フォームへフォーカスを移動
            this.textBoxCommand.Focus();


            //strに「OK!」が含まれているか調べる
            if (0 <= data.IndexOf("OK!"))   //　USB接続確認
            {
                OK = 1;
            }

            if (OK == 2)    //　速度ﾃﾞｰﾀ転送ﾀｲﾐﾝｸﾞ
            {
                this.textBoxRecv.Text += data;      //　OK!以降のデータが転送される(n_byte毎に周期的に)

            }

            if (OK == 1)
            {
                OK = 2;                         // この位置
            }

        }

        

        private void chart1_Click(object sender, EventArgs e)
        {

            try
            {
                int pt, temp;

                //chart1.Series.Clear();
                //chart1.Series.Add("Series1");

                string wk = textBoxRecv.Text;

                for (num = 0; num < 2000; num++)
                {
                    //Console.WriteLine("{0}", wk);
                    pt = wk.IndexOf(' ');               // 3桁数字ならば　pt=3  

                    if (pt > 0)
                    {
                        //t[num] = Convert.ToInt32(wk.Substring(0, pt));
                        temp = Convert.ToInt32(wk.Substring(0, pt));
                        if (temp >= 10) t[num] = temp; else t[num] = 2000;
                        wk = wk.Substring(pt + 1);

                        chart1.Series["Series1"].Points.AddY(temp);


                    }
                    else num = 2000;

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show(
                //    this,
                //    ex.Message,
                //    System.Windows.Forms.Application.ProductName,
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Error);
            }



        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
  //          textBox3.ResetText();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRecv.ResetText();

            chart1.Series.Clear();
            chart1.Series.Add("Series1");

            //            while(countHistory.Count <= MAX_HISTORY)
            //            {
            //                countHistory.Enqueue(0);
            //            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // [名前を付けて保存]ダイアログを表示
            if(saveFileDialogText.ShowDialog()==DialogResult.OK)
            {
                // ファイル名
                string fileName = saveFileDialogText.FileName;
                // ﾌｧｲﾙの書き出し
                using (StreamWriter streamWriter = new StreamWriter(fileName))
                {
                    // テキストボックスの内容を書き込む
                    streamWriter.WriteLine(textBoxRecv.Text);
                }
            }
        }

        private void openFileDialogText_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // [開く]ダイアログを表示
            if (openFileDialogText.ShowDialog() == DialogResult.OK)
            {
                // ファイル|名
                string fileName = openFileDialogText.FileName;
                // ﾌｧｲﾙの読み込み
                using (StreamReader streamReader = new StreamReader(fileName))
                {
                    // 全ての内容をｔｅｘｔＭａｉｎへ
                    textBoxRecv.Text = streamReader.ReadToEnd();
                }

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialogText_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            SendStringData();

        }

        /// <summary>
        /// 送信処理。改行コードは接続時に設定したものに変更する。
        /// </summary>
        /// <param name="text">送信文字列</param>
        private void SendStringData(string text)
        {
            try
            {
                this.serialPort1.Write(text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SendStringData()
        {
            string str = this.textBoxRecv.Text;
            str = str.Replace("\r\n", serialPort1.NewLine);
            SendStringData(str);

            this.textBoxRecv.Text = "";
            this.textBoxRecv.Focus();
        }






        #region ローカルメソッド

        /// <summary>
        /// 結果を表示する
        /// </summary>
        private void ShowResult()
        {
            try
            {
                // 結果をクリアする
                ClearResult(false);

                var strArray = textBoxRecv.Text.Trim().Split(' ');
                if (0 < strArray.Length)
                {
                    int hs = 0;
                    int bs = 0;
                    int sf = 0;

                    double dbl_bs = double.NaN;
                    
                    // HS
                    if( int.TryParse(strArray[strArray.Length-6], out hs))
                    {
                        labelHS.Text = (hs * 0.1).ToString("0.0");
                    }
                    // BS
                    if (int.TryParse(strArray[strArray.Length - 5], out bs))
                    {
                        labelBS.Text = (bs * 0.1).ToString("0.0");

                        dbl_bs = bs * 0.1;
                    }
                    // S/F
                    if (int.TryParse(strArray[strArray.Length - 4], out sf))
                    {
                        labelSF.Text = (sf * 0.01).ToString("0.00");
                    }
                    // YDS
                    if( !double.IsNaN(dbl_bs))
                    {
                        double total = 0.0;

                        double[] slope = new double[]
                        {
                            485,
                            450,
                            415,
                            383,
                            379,
                            375,
                            386,
                            396,
                            351,
                            307,
                            262,
                            350,
                            270,
                        };

                        double[] ofs = new double[]
                        {
                            -45, //-55,
                            -43,
                            -30,
                            -15,
                            -18,
                            -20,
                            -27,
                            -33,
                            -20,
                            -8 ,
                            5,
                            -15,
                            0,
                        };

                        total = ofs[m_LastSelectedClubIndex] + dbl_bs * slope[m_LastSelectedClubIndex] * 0.01;
                        labelYDS.Text = total.ToString("0");

                    }
                }

                
            }
            catch(Exception ex)
            {
                //MessageBox.Show(
                //    this, 
                //    ex.Message,
                //    System.Windows.Forms.Application.ProductName, 
                //    MessageBoxButtons.OK, 
                //    MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 結果をファイル保存する
        /// </summary>
        /// <param name="sender">送信元オブジェクト</param>
        /// <param name="e">イベント引数</param>
        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            try
            {
                if( labelHS.Text == "-")
                {
                    MessageBox.Show(
                    this,
                    "データがありません。",
                    System.Windows.Forms.Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }

                var desktopDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                var now = DateTime.Now;
                var dateDir = $"{now.Year.ToString("0000")}-{now.Month.ToString("00")}-{now.Day.ToString("00")}";
                var outputDir = Path.Combine(desktopDir, dateDir);
                if( !System.IO.Directory.Exists(outputDir))
                {
                    System.IO.Directory.CreateDirectory(outputDir);
                }

                var filename_graph = System.IO.Path.Combine(outputDir, $"{now.Year.ToString("0000")}-{now.Month.ToString("00")}-{now.Day.ToString("00")}_{now.Hour.ToString("00")}{now.Minute.ToString("00")}{now.Second.ToString("00")}_graph.txt");
                var filename_data = System.IO.Path.Combine(outputDir, $"{now.Year.ToString("0000")}-{now.Month.ToString("00")}-{now.Day.ToString("00")}_{now.Hour.ToString("00")}{now.Minute.ToString("00")}{now.Second.ToString("00")}_data.txt");

                // グラフデータ
                using( var sw = new System.IO.StreamWriter(filename_graph, false, Encoding.Default))
                {
                    sw.WriteLine(textBoxRecv.Text);
                }

                // 結果
                using (var sw = new System.IO.StreamWriter(filename_data, false, Encoding.Default))
                {
                    sw.WriteLine($"HS:{labelHS.Text}");
                    sw.WriteLine($"BS:{labelBS.Text}");
                    sw.WriteLine($"SF:{labelSF.Text}");
                    sw.WriteLine($"YDS:{labelYDS.Text}");
                    sw.WriteLine($"HS正解:{textBoxHS.Text}");
                    sw.WriteLine($"BS正解:{textBoxBS.Text}");
                    sw.WriteLine($"SF正解:{textBoxSF.Text}");
                    sw.WriteLine($"YDS正解:{textBoxYDS.Text}");
                    sw.WriteLine($"メモ:{textBoxMemo.Text}");
                }

                //結果をクリアする
                ClearResult(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    ex.Message,
                    System.Windows.Forms.Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// 結果をクリアする
        /// </summary>
        private void ClearResult(bool clearRecvText)
        {
            labelHS.Text =
            labelBS.Text =
            labelSF.Text =
            labelYDS.Text = "-";

            textBoxHS.Text =
            textBoxBS.Text =
            textBoxSF.Text =
            textBoxYDS.Text = string.Empty;

            if(clearRecvText)
            {
                textBoxRecv.Text = string.Empty;

                buttonClear.PerformClick();
            }
        }

        /// <summary>
        /// 指定したVID・PIDを有するデバイスのCOMポート名を取得する
        /// </summary>
        /// <param name="vid">VendorID</param>
        /// <param name="pid">ProductID</param>
        /// <returns>COMポート名</returns>
        private static string find_comport(uint vid, uint pid)
        {
            var ret = string.Empty;

            // ポートのクラスGUID
            var deviceClassGuid = Guid.Parse("{4d36e978-e325-11ce-bfc1-08002be10318}");
            const int DIGCF_PRESENT = 0x2;
            var deviceInfoSetHandle = SetupDiGetClassDevs(ref deviceClassGuid, null, IntPtr.Zero, DIGCF_PRESENT);
            const int INVALID_HANDLE_VALUE = -1;
            if (deviceInfoSetHandle.ToInt64() == INVALID_HANDLE_VALUE)
            {
                return ret;
            }

            try
            {
                var deviceInfoData = new SP_DEVINFO_DATA();
                deviceInfoData.CbSize = (uint)Marshal.SizeOf(deviceInfoData);

                uint index = 0;
                while (SetupDiEnumDeviceInfo(deviceInfoSetHandle, index++, ref deviceInfoData))
                {
                    const uint SPDRP_FRIENDLYNAME = 0xC;
                    const uint SPDRP_HARDWAREID = 0x00000001;

                    // --------------------------------------------
                    // フレンドリ名の取得
                    var friendlyName = get_value(deviceInfoSetHandle, ref deviceInfoData, SPDRP_FRIENDLYNAME);

                    // --------------------------------------------
                    // ハードウェアIDの取得
                    var hardwareid = get_value(deviceInfoSetHandle, ref deviceInfoData, SPDRP_HARDWAREID);


                    uint _vid = 0x00;
                    uint _pid = 0x00;
                    if (!string.IsNullOrEmpty(hardwareid))
                    {
                        foreach (var data in hardwareid.ToUpper().Split('\0'))
                        {
                            var found_vid = false;
                            var found_pid = false;
                            foreach (var d in data.Split(new char[] { '\\', '&' }))
                            {
                                if (d.Contains("VID_"))
                                {
                                    found_vid = uint.TryParse(d.Replace("VID_", ""), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _vid);
                                }
                                if (d.Contains("PID_"))
                                {
                                    found_pid = uint.TryParse(d.Replace("PID_", ""), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _pid);
                                }
                            }
                            if (found_vid && found_pid)
                            {
                                if (_vid == vid && _pid == pid)
                                {
                                    var check = new System.Text.RegularExpressions.Regex("(COM[1-9][0-9]?[0-9]?)");
                                    if (check.IsMatch(friendlyName))
                                    {
                                        for (int i = 0; i < friendlyName.Length - 1; i++)
                                        {
                                            if (friendlyName[i] == '(')
                                            {
                                                for (int j = i; j < friendlyName.Length; j++)
                                                {
                                                    if (friendlyName[j] == ')')
                                                    {
                                                        var str_comportnumber = friendlyName.Substring(i + 1, (j - i - 1));
                                                        var check2 = new System.Text.RegularExpressions.Regex("COM[1-9][0-9]?[0-9]?");
                                                        if (check2.IsMatch(str_comportnumber))
                                                        {
                                                            ret = str_comportnumber;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (!string.IsNullOrEmpty(ret))
                            {
                                break;
                            }
                        }
                    }
                }
            }
            finally
            {
                SetupDiDestroyDeviceInfoList(deviceInfoSetHandle);
            }

            return ret;
        }

        /// <summary>
        /// デバイスマネージャの項目値を取得する
        /// </summary>
        /// <param name="deviceInfoSetHandle"></param>
        /// <param name="deviceInfoData"></param>
        /// <param name="spdrp">SPDRP_*(SetupAPI.h)</param>
        /// <returns>成功した場合は項目値を、そうでない場合は空文字を返す</returns>
        private static string get_value(IntPtr deviceInfoSetHandle, ref SP_DEVINFO_DATA deviceInfoData, uint spdrp)
        {
            var ret = string.Empty;

            try
            {
                var buffer = new byte[300];
                if (!SetupDiGetDeviceRegistryProperty(deviceInfoSetHandle, ref deviceInfoData, spdrp, out var _, buffer, (uint)buffer.Length, out var _))
                {
                    // 失敗
                }
                else
                {
                    ret = Encoding.Unicode.GetString(buffer).TrimEnd('\0');
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return ret;
        }


        #endregion ローカルメソッド

        
    }
}
