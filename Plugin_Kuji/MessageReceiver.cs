using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Plugin_Kuji
{
    public class MessageReceiver
    {
        // メッセージ受信イベント
        public delegate void OnReceive(string Message);
        public event OnReceive OnReceiveEvent;

        // 受信待機中フラグ
        public bool IsWorking { get; set; }
        // 受信パイプ名
        public string PipeName { get; set; }
        // インターバル
        public int Wait { get; set; }

        // コンストラクタ
        public MessageReceiver(string pipeName, int wait)
        {
            PipeName = pipeName;
            IsWorking = false;
            Wait = wait;
        }

        // 受信待機開始
        public void Start()
        {
            Receive();
        }

        // 受信待機終了
        public void Stop()
        {
            IsWorking = false;
        }

        // 受信待機処理
        private void Receive()
        {
            IsWorking = true;
            while (IsWorking)
            {
                // 指定したパイプ名のパイプを生成
                using (NamedPipeServerStream server = new NamedPipeServerStream(PipeName))
                {
                    // 受信があるまで待機
                    server.WaitForConnection();

                    // 受信後、ストリームから内容を読み込む
                    while (server.IsConnected)
                    {
                        using (BinaryReader sr = new BinaryReader(server, Encoding.UTF8))
                        {
                            // ストリームから1行ずつ読込
                            string line = sr.ReadString();
                            line = line.Trim();
                            if (line.Length > 0)
                            {
                                // メッセージ内容と共にイベント発生
                                Thread t = new Thread(() =>
                                {
                                    OnReceiveEvent.Invoke(line);
                                });
                                t.Start();
                            }
                        }
                    }
                }
                Thread.Sleep(Wait);
            }
        }
    }
}
