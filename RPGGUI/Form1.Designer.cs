namespace RPGGUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxHeroes = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSkill = new System.Windows.Forms.Label();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitGame_Main = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveHero = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listViewBag = new System.Windows.Forms.ListView();
            this.装备名称 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.攻击力 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.血量 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.类型 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuBag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEquip = new System.Windows.Forms.ToolStripMenuItem();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblBagTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusHero = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusBag = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveGameTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.contextMenuBag.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.panel9.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.75F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.95846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.04154F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 625);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.03493F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.96507F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 452);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(374, 170);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.49351F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.50649F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxHeroes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(372, 441);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listBoxHeroes
            // 
            this.listBoxHeroes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHeroes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxHeroes.FormattingEnabled = true;
            this.listBoxHeroes.ItemHeight = 24;
            this.listBoxHeroes.Location = new System.Drawing.Point(4, 4);
            this.listBoxHeroes.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxHeroes.Name = "listBoxHeroes";
            this.listBoxHeroes.Size = new System.Drawing.Size(109, 433);
            this.listBoxHeroes.TabIndex = 0;
            this.listBoxHeroes.SelectedIndexChanged += new System.EventHandler(this.listBoxHeroes_SelectedIndexChanged);
            this.listBoxHeroes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxHeroes_MouseDoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.12195F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.878049F));
            this.tableLayoutPanel3.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSkill, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblSpecial, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblAttack, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblClass, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblLevel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblSex, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(121, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(247, 433);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(3, 3);
            this.lblName.Margin = new System.Windows.Forms.Padding(3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(228, 55);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "lblName";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSkill.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSkill.Location = new System.Drawing.Point(3, 369);
            this.lblSkill.Margin = new System.Windows.Forms.Padding(3);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(228, 61);
            this.lblSkill.TabIndex = 5;
            this.lblSkill.Text = "lblSkill";
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpecial.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSpecial.Location = new System.Drawing.Point(3, 308);
            this.lblSpecial.Margin = new System.Windows.Forms.Padding(3);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(228, 55);
            this.lblSpecial.TabIndex = 4;
            this.lblSpecial.Text = "lblSpecial";
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAttack.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAttack.Location = new System.Drawing.Point(3, 247);
            this.lblAttack.Margin = new System.Windows.Forms.Padding(3);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(228, 55);
            this.lblAttack.TabIndex = 3;
            this.lblAttack.Text = "lblAttack";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClass.Location = new System.Drawing.Point(3, 186);
            this.lblClass.Margin = new System.Windows.Forms.Padding(3);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(228, 55);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "lblClass";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLevel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLevel.Location = new System.Drawing.Point(3, 125);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(3);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(228, 55);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "lblLevel";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSex.Location = new System.Drawing.Point(3, 64);
            this.lblSex.Margin = new System.Windows.Forms.Padding(3);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(228, 55);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "lblSex";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(383, 452);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(584, 170);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Controls.Add(this.btnQuitGame_Main, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 88);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(578, 79);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // btnQuitGame_Main
            // 
            this.btnQuitGame_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuitGame_Main.Location = new System.Drawing.Point(435, 3);
            this.btnQuitGame_Main.Name = "btnQuitGame_Main";
            this.btnQuitGame_Main.Size = new System.Drawing.Size(140, 73);
            this.btnQuitGame_Main.TabIndex = 3;
            this.btnQuitGame_Main.Text = "结束游戏";
            this.btnQuitGame_Main.UseVisualStyleBackColor = true;
            this.btnQuitGame_Main.Click += new System.EventHandler(this.btnQuitGame_Main_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnQuitGame);
            this.panel6.Location = new System.Drawing.Point(291, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(138, 73);
            this.panel6.TabIndex = 2;
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuitGame.Location = new System.Drawing.Point(0, 0);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(138, 73);
            this.btnQuitGame.TabIndex = 2;
            this.btnQuitGame.Text = "结束游戏";
            this.btnQuitGame.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveGame);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 73);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveGame.Location = new System.Drawing.Point(0, 0);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(138, 73);
            this.btnSaveGame.TabIndex = 1;
            this.btnSaveGame.Text = "保存游戏";
            this.btnSaveGame.UseVisualStyleBackColor = true;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLoadGame);
            this.panel5.Location = new System.Drawing.Point(147, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(138, 73);
            this.panel5.TabIndex = 2;
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadGame.Location = new System.Drawing.Point(0, 0);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(138, 73);
            this.btnLoadGame.TabIndex = 3;
            this.btnLoadGame.Text = "加载游戏";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.btnRemoveHero, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(578, 79);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveHero.Location = new System.Drawing.Point(435, 3);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(140, 73);
            this.btnRemoveHero.TabIndex = 3;
            this.btnRemoveHero.Text = "删除英雄";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            this.btnRemoveHero.Click += new System.EventHandler(this.btnRemoveHero_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddHero);
            this.panel4.Location = new System.Drawing.Point(291, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 73);
            this.panel4.TabIndex = 2;
            // 
            // btnAddHero
            // 
            this.btnAddHero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddHero.Location = new System.Drawing.Point(0, 0);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(138, 73);
            this.btnAddHero.TabIndex = 2;
            this.btnAddHero.Text = "添加英雄";
            this.btnAddHero.UseVisualStyleBackColor = true;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddEquipment);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 73);
            this.panel2.TabIndex = 1;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddEquipment.Location = new System.Drawing.Point(0, 0);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(138, 73);
            this.btnAddEquipment.TabIndex = 0;
            this.btnAddEquipment.Text = "添加装备";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemoveEquipment);
            this.panel3.Location = new System.Drawing.Point(147, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 73);
            this.panel3.TabIndex = 2;
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveEquipment.Location = new System.Drawing.Point(0, 0);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(138, 73);
            this.btnRemoveEquipment.TabIndex = 3;
            this.btnRemoveEquipment.Text = "删除装备";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.btnRemoveEquipment_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(383, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.865979F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.13402F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(584, 443);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.listViewBag);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 42);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(578, 398);
            this.panel7.TabIndex = 0;
            // 
            // listViewBag
            // 
            this.listViewBag.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.装备名称,
            this.攻击力,
            this.血量,
            this.类型});
            this.listViewBag.ContextMenuStrip = this.contextMenuBag;
            this.listViewBag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBag.FullRowSelect = true;
            this.listViewBag.GridLines = true;
            this.listViewBag.HideSelection = false;
            this.listViewBag.Location = new System.Drawing.Point(0, 0);
            this.listViewBag.Name = "listViewBag";
            this.listViewBag.Size = new System.Drawing.Size(578, 398);
            this.listViewBag.TabIndex = 5;
            this.listViewBag.UseCompatibleStateImageBehavior = false;
            this.listViewBag.View = System.Windows.Forms.View.Details;
            this.listViewBag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewBag_MouseDown);
            // 
            // 装备名称
            // 
            this.装备名称.Text = "装备名称";
            this.装备名称.Width = 130;
            // 
            // 攻击力
            // 
            this.攻击力.Text = "攻击力";
            this.攻击力.Width = 130;
            // 
            // 血量
            // 
            this.血量.Text = "血量";
            this.血量.Width = 130;
            // 
            // 类型
            // 
            this.类型.Text = "类型";
            this.类型.Width = 130;
            // 
            // contextMenuBag
            // 
            this.contextMenuBag.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuBag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDelete,
            this.menuItemCopy,
            this.menuItemEquip});
            this.contextMenuBag.Name = "contextMenuStrip1";
            this.contextMenuBag.Size = new System.Drawing.Size(117, 94);
            this.contextMenuBag.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuBag_Opening);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(116, 30);
            this.menuItemDelete.Text = "删除";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Name = "menuItemCopy";
            this.menuItemCopy.Size = new System.Drawing.Size(116, 30);
            this.menuItemCopy.Text = "复制";
            this.menuItemCopy.Click += new System.EventHandler(this.menuItemCopy_Click);
            // 
            // menuItemEquip
            // 
            this.menuItemEquip.Name = "menuItemEquip";
            this.menuItemEquip.Size = new System.Drawing.Size(116, 30);
            this.menuItemEquip.Text = "装备";
            this.menuItemEquip.Click += new System.EventHandler(this.menuItemEquip_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblBagTitle);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(578, 33);
            this.panel8.TabIndex = 1;
            // 
            // lblBagTitle
            // 
            this.lblBagTitle.AutoSize = true;
            this.lblBagTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBagTitle.Location = new System.Drawing.Point(0, 0);
            this.lblBagTitle.Name = "lblBagTitle";
            this.lblBagTitle.Size = new System.Drawing.Size(142, 24);
            this.lblBagTitle.TabIndex = 0;
            this.lblBagTitle.Text = "lblBagTitle";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.panel9, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.91692F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.083086F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(978, 674);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.statusStrip1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 636);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(972, 35);
            this.panel9.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusHero,
            this.lblStatusBag,
            this.lblStatusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(972, 35);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusHero
            // 
            this.lblStatusHero.Name = "lblStatusHero";
            this.lblStatusHero.Size = new System.Drawing.Size(127, 28);
            this.lblStatusHero.Text = "lblStatusHero";
            // 
            // lblStatusBag
            // 
            this.lblStatusBag.Name = "lblStatusBag";
            this.lblStatusBag.Size = new System.Drawing.Size(118, 28);
            this.lblStatusBag.Text = "lblStatusBag";
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(161, 28);
            this.lblStatusMessage.Text = "lblStatusMessage";
            // 
            // saveGameTimer
            // 
            this.saveGameTimer.Interval = 5000;
            this.saveGameTimer.Tick += new System.EventHandler(this.saveGameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(978, 674);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 730);
            this.Name = "Form1";
            this.Text = "主菜单";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.contextMenuBag.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listBoxHeroes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuitGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Button btnRemoveEquipment;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnQuitGame_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnRemoveHero;
        private System.Windows.Forms.ListView listViewBag;
        private System.Windows.Forms.ColumnHeader 装备名称;
        private System.Windows.Forms.ColumnHeader 攻击力;
        private System.Windows.Forms.ColumnHeader 血量;
        private System.Windows.Forms.ColumnHeader 类型;
        private System.Windows.Forms.ContextMenuStrip contextMenuBag;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem menuItemEquip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblBagTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusHero;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusBag;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.Timer saveGameTimer;
    }
}

