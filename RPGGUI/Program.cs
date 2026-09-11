using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGUI
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // 1. 显示加载窗体，执行真实加载
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.ShowDialog();  // 加载窗体关闭后，这里才继续往下执行
            // 如果加载没有完成（用户手动关闭了），就直接退出程序
            if (!loadingForm.IsLoadingCompleted)
            {
                return;   // 不启动主窗口，退出
            }
            // 3. 把加载好的数据传给主窗体
            Application.Run(new Form1(loadingForm.LoadedHeroes));
        }
    }
}
