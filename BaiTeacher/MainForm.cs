using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;
using System.IO;
using System.Collections;

namespace BaiTeacher
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            InitializeComponent();
            syn = new SpeechSynthesizer();
            syn.Rate = -3;
            syn.Volume = 100;
            al = new ArrayList();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        SpeechSynthesizer syn;
        string fName;
        ArrayList al;
        public int Delayed
        {
            get
            {
                return (int)nudSecond.Value * 1000;
            }
        }

        /// <summary>
        /// 读出某一个文本内容.
        /// </summary>
        /// <param name="voice"></param>
        void speak(string voice)
        {
            //syn.SelectVoice("Microsoft Huihui Desktop - Chinese (Simplified)");
            syn.SpeakAsync(voice);
        }

        /// <summary>
        /// 从指定的路径(Path)的文本文件中读取内容,并保存到arraylist中。
        /// </summary>
        /// <param name="path"></param>
        public void readFile(string path)
        {
            clbWord.Items.Clear();
            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] split = line.Split(new Char[] { '\t' });
                foreach (string s in split)
                {
                    if (s.Trim() != "")
                        al.Add(s);
                }
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if ((fName == "") || (fName == null))
            {
                return;
            }

            clbWord.Items.Clear();
            al.Clear();//清理al中的所有的内容。
            readFile(fName);//将文件中的内容填入到al中。
            speak("大家好,我是白老师,现在我们开始听写练习吧.");
            Thread.Sleep(12000);
            for (int i = 0; i < al.Count; i++)
            {
                string voice = al[i].ToString();
                clbWord.Items.Add(voice);
                speak(voice);

                //Thread.Sleep(Delayed);
                Thread.CurrentThread.Join(Delayed);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "文本文件|*.txt";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;
            }
            tbFile.Text = fName;
        }
    }
}
