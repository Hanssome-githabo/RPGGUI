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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Hero> heroes;
        private void Form1_Load(object sender, EventArgs e)
        {
            heroes = RPGModel.LoadGame();
            if (heroes == null || heroes.Count == 0)
            {
                heroes = new List<Hero>();

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

                Console.WriteLine("第一次登陆或没有保存的游戏数据，已创建默认英雄。");
            }


            RefreshHeroList();


        }

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

        }

        // 显示选中英雄的详细信息
        private void DisplayHeroDetails(Hero hero)
        {
            if (hero != null)
            {
                lblName.Text = $"英雄名称：{hero.Name}";
                lblLevel.Text = $"英雄等级：{hero.Level.ToString()}";
                string Sex = hero.Sex == "M" ? "男" : "女";
                lblSex.Text = $"英雄性别：{Sex}";
                lblClass.Text = $"英雄职业：{hero.GetType().Name}";
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
                

                RefreshBagList(hero);
            }
        }

        // 刷新背包列表
        private void RefreshBagList(Hero hero)
        {
            listBoxBag.Items.Clear();
            if (hero != null)
            {
                foreach (var item in hero.Bag)
                {
                    listBoxBag.Items.Add($"{item.Name} (攻击力: {item.Attack}, 血量: {item.HP}, 类型: {item.Type})");
                }
            }
            else
            {
                listBoxBag.Items.Add("（空）");
            }
        }

        // 点击英雄列表时，显示选中英雄的详细信息
        private void listBoxHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxHeroes.SelectedIndex < 0 || listBoxHeroes.SelectedIndex >= heroes.Count)
            {
                return;
            }

            Hero selectedHero = heroes[listBoxHeroes.SelectedIndex];
            DisplayHeroDetails(selectedHero);
        }



    }
}
