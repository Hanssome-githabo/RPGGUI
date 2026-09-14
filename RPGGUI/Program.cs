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

            // 在这里创建具体的存储实现
            IDataStorage storage = new JsonStorage();

            // 把storage注入到LoadingForm
            LoadingForm loadingForm = new LoadingForm(storage);
            loadingForm.ShowDialog();

            if (!loadingForm.IsLoadingCompleted)
                return;

            // ⭐ 把 storage 和加载好的数据一起注入给 Form1
            Application.Run(new MainForm(loadingForm.LoadedHeroes, storage));

        }
    }
}
