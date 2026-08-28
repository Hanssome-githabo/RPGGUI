using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RPGGUI
{
    public partial class AddEquipmentForm : Form
    {
        public AddEquipmentForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent; // 弹窗居中显示();
        }

        private void AddEquipmentForm_Load(object sender, EventArgs e)
        {
            // 复选框的数据源
            comboBoxType.DataSource = Enum.GetValues(typeof(EquipmentType));
        }

        // 只读属性装备，用来把用户填好的数据组装成 Equipment 对象交给调用方
        public Equipment NewEquipment
        {
            get
            {
                return new Equipment
                        (
                     textBoxEquipmentName.Text,
                     (int)numericUpDownAttack.Value,
                     (int)numericUpDownHP.Value,
                     (EquipmentType)comboBoxType.SelectedItem
                        );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 校验：装备名称不能为空
            if (string.IsNullOrWhiteSpace(textBoxEquipmentName.Text))
            {
                MessageBox.Show("请输入装备名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEquipmentName.Focus(); // 把光标聚焦到名称输入框
                return; // 阻止关闭
            }

            // 校验通过，设置 DialogResult 为 OK 并关闭窗口
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}