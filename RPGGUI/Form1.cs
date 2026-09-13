using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; // 用于 InputBox


namespace RPGGUI
{
    public partial class Form1 : Form
    {
        private List<Hero> heroes;
        int maxCapacity = 10; // 假设背包最大容量为 10
        private int saveGameTimerTickCount = 0;   // 记录保存提示的 Tick 次数

        public Form1(List<Hero> loadedHeroes)
        {
            InitializeComponent();
            // ?? 左边为空时，使用右边的默认值
            heroes = loadedHeroes ?? new List<Hero>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 清空现有分组
            listViewBag.Groups.Clear();

            // 创建三个分组
            listViewBag.Groups.Add(new ListViewGroup("weapon", "武器"));
            listViewBag.Groups.Add(new ListViewGroup("armor", "护甲"));
            listViewBag.Groups.Add(new ListViewGroup("accessory", "饰品"));

            
            RefreshHeroList();
        }

        #region 显示选中英雄的详细信息
        // 显示选中英雄的详细信息
        private void DisplayHeroDetails(Hero hero)
        {
            if (hero == null)
            {
                ClearHeroDetails();
                return;
            }

            #region 使用 switch 表达式来映射职业名称
            // 使用 switch 表达式来映射职业名称
            string className;
            switch (hero.GetType().Name)
            {
                case "Warrior":
                    className = "战士";
                    break;
                case "Mage":
                    className = "法师";
                    break;
                case "Assassin":
                    className = "刺客";
                    break;
                default:
                    className = hero.GetType().Name;
                    break;
            }
            #endregion

            lblName.Text = $"英雄名称：{hero.Name}";
            lblLevel.Text = $"英雄等级：{hero.Level.ToString()}";
            string Sex = hero.Sex == "M" ? "男" : "女";
            lblSex.Text = $"英雄性别：{Sex}";
            lblClass.Text = $"英雄职业：{className}";
            lblAttack.Text = $"英雄攻击力：{hero.TotalAttack}";
            // 对于攻击力的计算被调用时总会累加，调用一次就累加一次，所以在这里
            // 调用的GetHeroAttack中定义了一个totalAttack变量来存储总攻击力，
            // 每次调用时都会重新计算总攻击力，而不是累加之前的值。

            if (hero is Warrior warrior)
                lblSpecial.Text = $"耐力：{warrior.Stamina}";
            else if (hero is Mage mage)
                lblSpecial.Text = $"法力：{mage.Mana}";
            else if (hero is Assassin assassin)
                lblSpecial.Text = $"敏捷：{assassin.Agility}";
            lblSkill.Text = hero.GetSkillDescription();

            // ⭐ 更新状态栏
            lblStatusHero.Text = $"当前英雄：{hero.Name}";
            lblStatusBag.Text = $"装备数：{hero.Bag.Count}";

            RefreshBagList(hero);

        }
        #endregion

        #region 显示英雄信息
        // 点击英雄列表时，显示选中英雄的详细信息
        private void listBoxHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHeroes.SelectedIndex < 0 || listBoxHeroes.SelectedIndex >= heroes.Count)
            {
                return;
            }

            Hero selectedHero = heroes[listBoxHeroes.SelectedIndex];
            DisplayHeroDetails(selectedHero);
        }
        #endregion

        #region 刷新英雄列表
        // 刷新英雄列表
        private void RefreshHeroList()
        {
            listBoxHeroes.Items.Clear();
            foreach (var hero in heroes)
            {
                listBoxHeroes.Items.Add(hero.Name);
            }
            if (listBoxHeroes.Items.Count > 0)
            {
                listBoxHeroes.SelectedIndex = 0;
                DisplayHeroDetails(heroes[0]);
            }
            else
            {
                // 没有英雄时，清空详情显示
                ClearHeroDetails();
            }

        }
        #endregion

        #region 清空英雄详情显示
        private void ClearHeroDetails()
        {
            lblName.Text = "英雄名称：";
            lblLevel.Text = "英雄等级：";
            lblSex.Text = "英雄性别：";
            lblClass.Text = "英雄职业：";
            lblAttack.Text = "英雄攻击力：";
            lblSpecial.Text = "特殊属性：";
            lblSkill.Text = "技能：";
            listViewBag.Items.Clear();
            listViewBag.Items.Add("（空）");
        }
        #endregion

        #region  刷新背包列表
        // 刷新背包列表
        private void RefreshBagList(Hero hero)
        {
            listViewBag.Items.Clear();

            // 更新背包标题
            // 如果?.左边为 null，则整个表达式返回 null，?? 运算符会返回右边的值 0
            int currentCount = hero?.Bag.Count ?? 0; // 如果 hero 为 null，则当前数量为 0
            lblBagTitle.Text = $"背包（{currentCount}/{maxCapacity}）";

            // 1. 先处理 hero 为 null 或背包为空的情况
            if (hero == null || hero.Bag.Count == 0)
            {
                listViewBag.Items.Add("（空）");
                return;
            }

            // 2. 再处理有装备的情况
            foreach (var item in hero.Bag)
            {
                // 用传统 switch 找分组
                ListViewGroup group = null;
                switch (item.Type)
                {
                    case EquipmentType.Weapon:
                        group = listViewBag.Groups["weapon"];
                        break;
                    case EquipmentType.Armor:
                        group = listViewBag.Groups["armor"];
                        break;
                    case EquipmentType.Accessory:
                        group = listViewBag.Groups["accessory"];
                        break;
                }

                // 创建列表项
                var lvi = new ListViewItem(new[]
                {
                    item.Name,
                    item.Attack.ToString(),
                    item.HP.ToString(),
                    item.Type.ToString()
                });
                lvi.Group = group;

                /// 用传统 switch 设置颜色
                switch (item.Type)
                {
                    case EquipmentType.Weapon:
                        lvi.ForeColor = Color.Red;
                        break;
                    case EquipmentType.Armor:
                        lvi.ForeColor = Color.DarkOrange;
                        break;
                    case EquipmentType.Accessory:
                        lvi.ForeColor = Color.Purple;
                        break;
                    default:
                        lvi.ForeColor = Color.Black;
                        break;
                }

                // 把原始索引存在 Tag 中，以便后续操作（如删除）使用
                lvi.Tag = hero.Bag.IndexOf(item);

                listViewBag.Items.Add(lvi);

            }
        }
        #endregion

        #region 添加英雄
        private void btnAddHero_Click(object sender, EventArgs e)
        {
            AddHeroForm addHeroForm = new AddHeroForm();
            if (addHeroForm.ShowDialog() == DialogResult.OK)
            {
                Hero newHero = addHeroForm.NewHero;
                if (newHero == null)
                {
                    MessageBox.Show("未创建新英雄。");
                    return;
                }
                else
                {
                    heroes.Add(newHero);
                    RefreshHeroList();
                    RPGModel.SaveGame(heroes);
                    MessageBox.Show($"已添加新英雄：{newHero.Name}");
                }

            }
        }

        #endregion

        #region 删除英雄
        private void btnRemoveHero_Click(object sender, EventArgs e)
        {
            if (heroes == null || heroes.Count == 0)
            {
                MessageBox.Show("没有英雄可删除！");
                return;
            }
            if (listBoxHeroes.SelectedIndex < 0 || listBoxHeroes.SelectedIndex >= heroes.Count)
            {
                MessageBox.Show("请先选择一个英雄！");
                return;
            }
            DialogResult result = MessageBox.Show(
                $"确定要删除英雄：{heroes[listBoxHeroes.SelectedIndex].Name}吗？",
                "确认删除",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                heroes.RemoveAt(listBoxHeroes.SelectedIndex);
                RefreshHeroList();
                RPGModel.SaveGame(heroes);
            }
        }

        #endregion

        #region 添加装备
        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            // 检查是否选中了英雄
            if (listBoxHeroes.SelectedIndex < 0)
            {
                MessageBox.Show("请先选择一个英雄！");
                return;
            }

            // 背包容量限制
            if (heroes[listBoxHeroes.SelectedIndex].Bag.Count >= maxCapacity)
            {
                MessageBox.Show("背包已满，无法添加新装备！");
                return;
            }

            // 弹出添加装备窗口
            AddEquipmentForm addEquipmentForm = new AddEquipmentForm();
            
            if (addEquipmentForm.ShowDialog() == DialogResult.OK)
            {
                // 获取用户输入的装备
                Equipment newEquip = addEquipmentForm.NewEquipment;

                // 添加到当前英雄的背包
                Hero currentHero = heroes[listBoxHeroes.SelectedIndex];
                currentHero.Bag.Add(newEquip);

                // 刷新界面
                RefreshBagList(currentHero);
                MessageBox.Show($"已添加装备：{newEquip.Name}");
            }
        }
        #endregion

        #region 删除装备
        // 如果你想在删除后自动选中下一件装备（比如删除第 2 件，自动选中第 3 件），
        // 可以加一段逻辑，但当前方案已经足够，用户自己重新选择即可。
        private void btnRemoveEquipment_Click(object sender, EventArgs e)
        {
            // 边界条件检查：确保选中了英雄和装备
            if (listBoxHeroes.SelectedIndex < 0)
            {
                MessageBox.Show("请先选择一个英雄！");
                return;
            }
            Hero currentHero = heroes[listBoxHeroes.SelectedIndex];
            if (listViewBag.SelectedIndices.Count == 0)
            {
                MessageBox.Show("请先选择一个装备！");
                return;
            }

            // ⭐ 从 Tag 里取真实的 Bag 索引
            int selectedIndex = (int)listViewBag.SelectedItems[0].Tag;

            // ⭐ 再检查索引有效性
            if (selectedIndex < 0 || selectedIndex >= currentHero.Bag.Count)
            {
                MessageBox.Show("装备索引无效！");
                return;
            }

            // 弹出确认删除对话框
            DialogResult result = MessageBox.Show(
                $"确定要删除装备：{currentHero.Bag[selectedIndex].Name}吗？",
                "确认删除",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                currentHero.Bag.RemoveAt(selectedIndex);
                RefreshBagList(currentHero);
                RPGModel.SaveGame(heroes);
            }
        }
        #endregion

        #region 窗体关闭
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // 窗体关闭事件，提示保存游戏数据
        {
            DialogResult result = MessageBox.Show(
                "是否保存游戏数据？",             // 提示文本
                "提示",                           // 标题
                MessageBoxButtons.YesNoCancel,    // 按钮类型
                MessageBoxIcon.Question           // 图标类型
                );         

            if (result == DialogResult.Yes)
            {
                // 保存游戏数据
                RPGModel.SaveGame(heroes);
                MessageBox.Show("游戏数据已保存。","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true; // 取消关闭窗口
            }
        }
        #endregion

        #region 保存游戏
        private void btnSaveGame_Click(object sender, EventArgs e) // 保存游戏数据按钮点击事件
        {
            // 无英雄数据时，提示用户没有数据可保存
            if (heroes == null || heroes.Count == 0)
            {
                MessageBox.Show("没有英雄数据可保存。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 保存游戏数据
            RPGModel.SaveGame(heroes);
            lblStatusMessage.Text = "已保存游戏数据！";
            saveGameTimerTickCount = 0; // 重置计数器
            saveGameTimer.Start();   // 启动定时器
            MessageBox.Show("游戏数据已保存。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region 退出游戏
        private void btnQuitGame_Main_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "是否保存游戏数据？",             // 提示文本
                "提示",                           // 标题
                MessageBoxButtons.YesNoCancel,    // 按钮类型
                MessageBoxIcon.Question           // 图标类型
                );
            if (result == DialogResult.Yes)
            {
                // 直接保存并关闭，跳过 FormClosing 的二次提醒
                RPGModel.SaveGame(heroes);
                MessageBox.Show("游戏数据已保存。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0); // 强制退出，不触发 FormClosing
                                     // 或者 this.Close(); 但会触发 FormClosing
            }


        }


        #endregion

        #region 右键菜单事件处理
        // 右键菜单打开事件，动态设置菜单项的可用状态
        private void contextMenuBag_Opening(object sender, CancelEventArgs e)
        {
            if (listViewBag.SelectedItems.Count == 0 ||
                listViewBag.SelectedItems[0].Tag == null)
            {
                menuItemDelete.Enabled = false;
                menuItemCopy.Enabled = false;
                menuItemEquip.Enabled = false;
            }
            else
            {
                menuItemDelete.Enabled = true;
                menuItemCopy.Enabled = true;
                menuItemEquip.Enabled = true;
            }
        }
        // 背包框鼠标右键点击事件，选中对应的项
        private void listViewBag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // 根据鼠标位置找到对应的项
                ListViewItem item = listViewBag.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    item.Focused = true;
                }
            }
        }
        // 右键菜单删除装备事件
        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            // 先判断选中的项是否是“（空）”
            if (listViewBag.SelectedItems.Count == 0) return;
            // 检查是否有选中项
            if (listBoxHeroes.SelectedIndex < 0 || listBoxHeroes.SelectedIndex >= heroes.Count)
                return;
            
            // 从 Tag 中取得真实索引
            int realIndex = (int)listViewBag.SelectedItems[0].Tag;
            Hero currentHero = heroes[listBoxHeroes.SelectedIndex];

            // 确认删除
            DialogResult result = MessageBox.Show(
                $"确定要删除装备：{currentHero.Bag[realIndex].Name}吗？",
                "确认删除",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                currentHero.Bag.RemoveAt(realIndex);
                RefreshBagList(currentHero);
                RPGModel.SaveGame(heroes);
            }

        }
        // 右键菜单复制装备事件
        private void menuItemCopy_Click(object sender, EventArgs e)
        {
            if (listBoxHeroes.SelectedIndex < 0 || listBoxHeroes.SelectedIndex >= heroes.Count)
                return;
            if (listViewBag.SelectedItems.Count == 0) return;
            
            int realIndex = (int)listViewBag.SelectedItems[0].Tag;
            Hero currentHero = heroes[listBoxHeroes.SelectedIndex];

            if(currentHero.Bag.Count >= maxCapacity)
            {
                MessageBox.Show("背包已满，无法复制！");
                return;
            }

            // Equipment 是结构体，直接赋值是值拷贝，会得到一份完全一样的数据
            Equipment source = currentHero.Bag[realIndex];
            Equipment copy = new Equipment(source.Name + "（副本）", source.Attack, source.HP, source.Type);

            currentHero.Bag.Add(copy);
            RefreshBagList(currentHero);
            RPGModel.SaveGame(heroes);
        }
        // 右键菜单装备装备事件
        private void menuItemEquip_Click(object sender, EventArgs e)
        {
            if (listBoxHeroes.SelectedIndex < 0 || listBoxHeroes.SelectedIndex >= heroes.Count)
                return;
            if (listViewBag.SelectedItems.Count == 0) return;

            int realIndex = (int)listViewBag.SelectedItems[0].Tag;
            Hero currentHero = heroes[listBoxHeroes.SelectedIndex];

            Equipment equip = currentHero.Bag[realIndex];

            // 简单的装备逻辑：弹出提示（具体逻辑根据你的设计来）
            MessageBox.Show(
                $"英雄 {currentHero.Name} 装备了 {equip.Name}\n" +
                $"攻击力 +{equip.Attack}\n" +
                $"血量 +{equip.HP}",
                "装备成功",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // 更复杂的逻辑：比如从背包移除、记录已装备的装备列表等
            // currentHero.Bag.RemoveAt(realIndex);
            // RefreshBagList(currentHero);
        }
        #endregion

        // 双击英雄列表项，弹出输入框修改英雄名称
        private void listBoxHeroes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listBoxHeroes.SelectedIndex < 0 || listBoxHeroes.SelectedIndex >= heroes.Count)
            {
                return;
            }

            Hero currentHero = heroes[listBoxHeroes.SelectedIndex];

            // 弹出输入框，默认显示当前名字
            string newName = Interaction.InputBox(
                "请输入新的英雄名称：", 
                "修改英雄名称", 
                currentHero.Name
            );
            
            if (string.IsNullOrWhiteSpace(newName))
            {
                return; // 用户取消或输入为空，不修改
            }

            currentHero.Name = newName;
            RefreshHeroList();
            RPGModel.SaveGame(heroes);
        }

        private void saveGameTimer_Tick(object sender, EventArgs e)
        {
            saveGameTimerTickCount++; 
            if(saveGameTimerTickCount == 1)  
            {
                // 第一次 Tick：显示"已保存"
                lblStatusMessage.Text = $"游戏数据已保存。{DateTime.Now:HH:mm:ss}";
            }
            else if (saveGameTimerTickCount == 2)
            {
                // 第二次 Tick：显示"正在游玩"
                lblStatusMessage.Text = "正在游玩中…";
                saveGameTimer.Stop();   // 停止 Timer
            }
        }

        
    }
}
