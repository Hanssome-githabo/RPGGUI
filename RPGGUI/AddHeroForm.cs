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
    public partial class AddHeroForm : Form
    {
        public AddHeroForm()
        {
            InitializeComponent();
        }

        // 只读属性 NewHero，用来把用户填好的数据组装成 Hero 对象交给调用方
        public Hero NewHero
        {
            get
            {
                if(string.IsNullOrWhiteSpace(textBoxHeroName.Text))
                {
                    MessageBox.Show("请输入英雄名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxHeroName.Focus(); // 把光标聚焦到名称输入框
                    return null; // 阻止关闭
                }
                string gender = comboBoxGender.SelectedItem.ToString() == "男" ? "M" : "F";
                switch (comboBoxHeroType.SelectedItem.ToString())
                {
                    case "Warrior":
                        return new Warrior(textBoxHeroName.Text, (int)numericUpDownLevel.Value, gender, (float)numericUpDownAttack.Value, (int)numericUpDownSpecial.Value);
                    case "Mage":
                        return new Mage(textBoxHeroName.Text, (int)numericUpDownLevel.Value, gender, (float)numericUpDownAttack.Value, (int)numericUpDownSpecial.Value);
                    case "Assassin":
                        return new Assassin(textBoxHeroName.Text, (int)numericUpDownLevel.Value, gender, (float)numericUpDownAttack.Value, (int)numericUpDownSpecial.Value);
                    default:
                        MessageBox.Show("请选择有效的职业！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                        return null; 
                }
            }
        }

        #region 用户在 AddHeroForm 中选择职业（战士/法师/刺客）后lblSpecial.Text自动变为对应的特殊属性名
        private void comboBoxHeroType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxHeroType.SelectedItem.ToString())
            {
                case "Warrior":
                    lblSpecial.Text = "耐力："; // Warrior 的初始耐力
                    break;
                case "Mage":
                    lblSpecial.Text = "法力："   ; // Mage 的初始法力
                    break;
                case "Assassin":
                    lblSpecial.Text = "敏捷："; // Assassin 的初始敏捷
                    break;
            }
        }
        #endregion

        #region 窗体加载，初始化 comboBoxGender和comboBoxHeroType 的数据源
        private void AddHeroForm_Load(object sender, EventArgs e)
        {
            comboBoxHeroType.DataSource = new List<string> { "Warrior", "Mage", "Assassin" };
            comboBoxGender.DataSource = new List<string> { "男", "女" };
            comboBoxHeroType.SelectedIndex = 0;
            comboBoxGender.SelectedIndex = 0;
        }
        #endregion


    }
}
