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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.listBoxBag = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.75F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxBag, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 904);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.49351F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.50649F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxHeroes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(487, 560);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listBoxHeroes
            // 
            this.listBoxHeroes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHeroes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxHeroes.FormattingEnabled = true;
            this.listBoxHeroes.ItemHeight = 24;
            this.listBoxHeroes.Location = new System.Drawing.Point(3, 3);
            this.listBoxHeroes.Name = "listBoxHeroes";
            this.listBoxHeroes.Size = new System.Drawing.Size(147, 554);
            this.listBoxHeroes.TabIndex = 0;
            this.listBoxHeroes.SelectedIndexChanged += new System.EventHandler(this.listBoxHeroes_SelectedIndexChanged);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(156, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(328, 554);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(2, 2);
            this.lblName.Margin = new System.Windows.Forms.Padding(2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(308, 75);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSkill.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSkill.Location = new System.Drawing.Point(2, 476);
            this.lblSkill.Margin = new System.Windows.Forms.Padding(2);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(308, 76);
            this.lblSkill.TabIndex = 5;
            this.lblSkill.Text = "label6";
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpecial.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSpecial.Location = new System.Drawing.Point(2, 397);
            this.lblSpecial.Margin = new System.Windows.Forms.Padding(2);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(308, 75);
            this.lblSpecial.TabIndex = 4;
            this.lblSpecial.Text = "label5";
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAttack.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAttack.Location = new System.Drawing.Point(2, 318);
            this.lblAttack.Margin = new System.Windows.Forms.Padding(2);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(308, 75);
            this.lblAttack.TabIndex = 3;
            this.lblAttack.Text = "label4";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClass.Location = new System.Drawing.Point(2, 239);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(308, 75);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "label3";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLevel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLevel.Location = new System.Drawing.Point(2, 160);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(2);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(308, 75);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "label2";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSex.Location = new System.Drawing.Point(2, 81);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(308, 75);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "label1";
            // 
            // listBoxBag
            // 
            this.listBoxBag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBag.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxBag.FormattingEnabled = true;
            this.listBoxBag.ItemHeight = 24;
            this.listBoxBag.Location = new System.Drawing.Point(496, 3);
            this.listBoxBag.Name = "listBoxBag";
            this.listBoxBag.Size = new System.Drawing.Size(759, 560);
            this.listBoxBag.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 904);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1280, 960);
            this.Name = "Form1";
            this.Text = "主菜单";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.ListBox listBoxBag;
        private System.Windows.Forms.Label lblSex;
    }
}

