using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // DllImport
using System.Diagnostics;
using System.Collections;

namespace Hide_Process{
    public partial class Form1 : Form{
        public delegate bool EnumWindowCallback(int hwnd, int lParam);//得到进程的主窗口句柄
        [DllImport("user32")]
        public static extern int ShowWindow(int hwnd, int nCmdShow); //指定窗口状态
        ArrayList handleArray = null; //保存隐藏的进程

        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){  //初始化ListView,存取当前进程
            processListView.View = View.List;
            processListView.CheckBoxes = true;
            handleArray = new ArrayList();
            loadProcessList();
            this.btnHide.Click += FuncHide;
            this.btnShow.Click += FuncShow;
        }

        private void loadProcessList(){
            Process[] processVar = Process.GetProcesses();
            processListView.Items.Clear(); //防进程重复
            handleArray.Clear();

            foreach (Process process in processVar){     //循环获取进程加入ListView中
                if (!String.IsNullOrEmpty(process.MainWindowTitle)){ //获取标题
                    IntPtr mainHandle = process.MainWindowHandle;
                    handleArray.Add(mainHandle.ToInt32());
                    processListView.Items.Add(process.MainWindowTitle, handleArray.Count-1);
                }
            }
        }

        private void FuncHide(object sender, EventArgs e){         //指定窗口状态-隐藏
            for (int i = 0; i < processListView.Items.Count; i++){
                if (processListView.Items[i].Checked == true) {
                    ShowWindow((int)handleArray[i], 0);
                }
            }
        }

        private void FuncShow(object sender, EventArgs e){         //指定窗口状态-显示
            for (int i = 0; i < processListView.Items.Count; i++){
                if (processListView.Items[i].Checked == true){
                    ShowWindow((int)handleArray[i], 5);
                }
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
        }
    }
}
