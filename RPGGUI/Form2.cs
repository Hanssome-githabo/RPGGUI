using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGUI
{
    public partial class LoadingForm : Form
    {
        public bool IsLoadingCompleted { get; private set; } = false;
        public List<Hero> LoadedHeroes { get; private set; }
        private Random random = new Random();
        public LoadingForm()
        {
            InitializeComponent();
        }

        private async void LoadingForm_Load(object sender, EventArgs e)
        {
            await Task.Run(() => DoLoadingWork());
        }

        private void DoLoadingWork()
        {
            // 步骤 1：初始化日志（5%）
            UpdateProgress(5, "正在初始化日志系统…");
            // 你实际的日志初始化代码放这里（或在 Program.cs 里完成）

            // 步骤 2：读取存档（30%）
            UpdateProgress(30, "正在读取存档…");
            List<Hero> heroes = RPGModel.LoadGame<Hero>();

            // 步骤 3：没有存档则创建默认英雄（60%）
            if (heroes == null || heroes.Count == 0)
            {
                UpdateProgress(50, "首次启动，正在创建默认英雄…");
                heroes = CreateDefaultHeroes();
            }
            UpdateProgress(70, "正在加载英雄数据…");

            // 步骤 4：准备数据（100%）
            LoadedHeroes = heroes;
            UpdateProgress(100, "加载完成！");

            // 标记加载完成
            IsLoadingCompleted = true;

            // 关闭加载窗体（切回 UI 线程）
            this.Invoke(new Action(() =>
            {
                closeTimer.Start();  // 延时后关闭，让用户看到 100%
            }));
        }

        // 更新进度条（线程安全）
        private void UpdateProgress(int value, string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateProgress(value, text)));
                return;
            }
            progressBar1.Value = Math.Min(value, progressBar1.Maximum);
            labelStatus.Text = text;
        }

        private List<Hero> CreateDefaultHeroes()
        {
            // 把你原来的创建默认英雄逻辑搬过来
            List<Hero> heroes = new List<Hero>();

            Warrior defaultHero1 = new Warrior("剑圣", 5, "M", 60.0f, 100);
            defaultHero1.Bag.Add(new Equipment("铁剑", 12, 0, EquipmentType.Weapon));
            defaultHero1.Bag.Add(new Equipment("残暴之力", 80, 200, EquipmentType.Weapon));
            defaultHero1.Bag.Add(new Equipment("饮血剑", 90, 500, EquipmentType.Weapon));
            defaultHero1.Bag.Add(new Equipment("鬼索的狂暴之刃", 60, 300, EquipmentType.Weapon));
            defaultHero1.Bag.Add(new Equipment("破败王者之刃", 50, 300, EquipmentType.Weapon));

            Mage defaultHero2 = new Mage("阿狸", 5, "F", 50.0f, 100);
            defaultHero2.Bag.Add(new Equipment("魔力戒指", 4, 20, EquipmentType.Accessory));

            Assassin defaultHero3 = new Assassin("劫", 5, "M", 55.0f, 50);
            defaultHero3.Bag.Add(new Equipment("皮甲", 2, 10, EquipmentType.Armor));

            heroes.Add(defaultHero1);
            heroes.Add(defaultHero2);
            heroes.Add(defaultHero3);

            return heroes;
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Stop();
            // IsLoadingCompleted = true;
            // MessageBox.Show($"关闭时进度值：{progressBar1.Value}，最大值：{progressBar1.Maximum}");
            this.Close();
        }
    }
}
