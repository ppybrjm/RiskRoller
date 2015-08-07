namespace WindowsFormsApplication1
{
    partial class RiskRoller1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiskRoller1));
            this.Attack2on1 = new System.Windows.Forms.Button();
            this.Attack1on1 = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.lblDefend = new System.Windows.Forms.Label();
            this.comboDefenders = new System.Windows.Forms.ComboBox();
            this.lblBattle = new System.Windows.Forms.Label();
            this.Attack3on1 = new System.Windows.Forms.Button();
            this.SingleRoll = new System.Windows.Forms.GroupBox();
            this.Attack3on2 = new System.Windows.Forms.Button();
            this.Attack2on2 = new System.Windows.Forms.Button();
            this.Attack1on2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toTheBloodyEnd = new System.Windows.Forms.CheckBox();
            this.RollingAttack = new System.Windows.Forms.Button();
            this.lblAttack = new System.Windows.Forms.Label();
            this.comboAttackers = new System.Windows.Forms.ComboBox();
            this.clearall = new System.Windows.Forms.Button();
            this.SingleRoll.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Attack2on1
            // 
            this.Attack2on1.BackColor = System.Drawing.Color.LightBlue;
            this.Attack2on1.Location = new System.Drawing.Point(85, 41);
            this.Attack2on1.Name = "Attack2on1";
            this.Attack2on1.Size = new System.Drawing.Size(53, 24);
            this.Attack2on1.TabIndex = 3;
            this.Attack2on1.Text = "2 on 1";
            this.Attack2on1.UseVisualStyleBackColor = false;
            this.Attack2on1.Click += new System.EventHandler(this.Attack2on1_Click);
            // 
            // Attack1on1
            // 
            this.Attack1on1.BackColor = System.Drawing.Color.LightBlue;
            this.Attack1on1.Location = new System.Drawing.Point(26, 41);
            this.Attack1on1.Name = "Attack1on1";
            this.Attack1on1.Size = new System.Drawing.Size(53, 24);
            this.Attack1on1.TabIndex = 1;
            this.Attack1on1.Text = "1 on 1";
            this.Attack1on1.UseVisualStyleBackColor = false;
            this.Attack1on1.Click += new System.EventHandler(this.Attack1on1_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 138);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(510, 149);
            this.Output.TabIndex = 6;
            this.Output.TabStop = false;
            // 
            // lblDefend
            // 
            this.lblDefend.AutoSize = true;
            this.lblDefend.Location = new System.Drawing.Point(16, 58);
            this.lblDefend.Name = "lblDefend";
            this.lblDefend.Size = new System.Drawing.Size(56, 13);
            this.lblDefend.TabIndex = 3;
            this.lblDefend.Text = "Defenders";
            // 
            // comboDefenders
            // 
            this.comboDefenders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDefenders.FormattingEnabled = true;
            this.comboDefenders.Location = new System.Drawing.Point(102, 55);
            this.comboDefenders.Name = "comboDefenders";
            this.comboDefenders.Size = new System.Drawing.Size(159, 21);
            this.comboDefenders.TabIndex = 7;
            // 
            // lblBattle
            // 
            this.lblBattle.AutoSize = true;
            this.lblBattle.Location = new System.Drawing.Point(15, 16);
            this.lblBattle.Name = "lblBattle";
            this.lblBattle.Size = new System.Drawing.Size(110, 13);
            this.lblBattle.TabIndex = 6;
            this.lblBattle.Text = "Attacks on Defenders";
            // 
            // Attack3on1
            // 
            this.Attack3on1.BackColor = System.Drawing.Color.LightBlue;
            this.Attack3on1.Location = new System.Drawing.Point(144, 41);
            this.Attack3on1.Name = "Attack3on1";
            this.Attack3on1.Size = new System.Drawing.Size(53, 24);
            this.Attack3on1.TabIndex = 5;
            this.Attack3on1.Text = "3 on 1";
            this.Attack3on1.UseVisualStyleBackColor = false;
            this.Attack3on1.Click += new System.EventHandler(this.Attack3on1_Click);
            // 
            // SingleRoll
            // 
            this.SingleRoll.Controls.Add(this.Attack3on2);
            this.SingleRoll.Controls.Add(this.Attack3on1);
            this.SingleRoll.Controls.Add(this.Attack2on2);
            this.SingleRoll.Controls.Add(this.lblBattle);
            this.SingleRoll.Controls.Add(this.Attack1on2);
            this.SingleRoll.Controls.Add(this.Attack2on1);
            this.SingleRoll.Controls.Add(this.Attack1on1);
            this.SingleRoll.Location = new System.Drawing.Point(12, 12);
            this.SingleRoll.Name = "SingleRoll";
            this.SingleRoll.Size = new System.Drawing.Size(220, 111);
            this.SingleRoll.TabIndex = 7;
            this.SingleRoll.TabStop = false;
            this.SingleRoll.Text = "Single Roll";
            // 
            // Attack3on2
            // 
            this.Attack3on2.BackColor = System.Drawing.Color.LightBlue;
            this.Attack3on2.Location = new System.Drawing.Point(144, 71);
            this.Attack3on2.Name = "Attack3on2";
            this.Attack3on2.Size = new System.Drawing.Size(53, 24);
            this.Attack3on2.TabIndex = 6;
            this.Attack3on2.Text = "3 on 2";
            this.Attack3on2.UseVisualStyleBackColor = false;
            this.Attack3on2.Click += new System.EventHandler(this.Attack3on2_Click);
            // 
            // Attack2on2
            // 
            this.Attack2on2.BackColor = System.Drawing.Color.LightBlue;
            this.Attack2on2.Location = new System.Drawing.Point(85, 71);
            this.Attack2on2.Name = "Attack2on2";
            this.Attack2on2.Size = new System.Drawing.Size(53, 24);
            this.Attack2on2.TabIndex = 4;
            this.Attack2on2.Text = "2 on 2";
            this.Attack2on2.UseVisualStyleBackColor = false;
            this.Attack2on2.Click += new System.EventHandler(this.Attack2on2_Click);
            // 
            // Attack1on2
            // 
            this.Attack1on2.BackColor = System.Drawing.Color.LightBlue;
            this.Attack1on2.Location = new System.Drawing.Point(26, 71);
            this.Attack1on2.Name = "Attack1on2";
            this.Attack1on2.Size = new System.Drawing.Size(53, 24);
            this.Attack1on2.TabIndex = 2;
            this.Attack1on2.Text = "1 on 2";
            this.Attack1on2.UseVisualStyleBackColor = false;
            this.Attack1on2.Click += new System.EventHandler(this.Attack1on2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toTheBloodyEnd);
            this.groupBox1.Controls.Add(this.RollingAttack);
            this.groupBox1.Controls.Add(this.lblAttack);
            this.groupBox1.Controls.Add(this.comboAttackers);
            this.groupBox1.Controls.Add(this.lblDefend);
            this.groupBox1.Controls.Add(this.comboDefenders);
            this.groupBox1.Location = new System.Drawing.Point(238, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rolling Battle";
            // 
            // toTheBloodyEnd
            // 
            this.toTheBloodyEnd.AutoSize = true;
            this.toTheBloodyEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTheBloodyEnd.ForeColor = System.Drawing.Color.DarkRed;
            this.toTheBloodyEnd.Location = new System.Drawing.Point(146, 86);
            this.toTheBloodyEnd.Name = "toTheBloodyEnd";
            this.toTheBloodyEnd.Size = new System.Drawing.Size(135, 17);
            this.toTheBloodyEnd.TabIndex = 10;
            this.toTheBloodyEnd.Text = "To The Bloody End";
            this.toTheBloodyEnd.UseVisualStyleBackColor = true;
            // 
            // RollingAttack
            // 
            this.RollingAttack.BackColor = System.Drawing.Color.Lavender;
            this.RollingAttack.Location = new System.Drawing.Point(19, 82);
            this.RollingAttack.Name = "RollingAttack";
            this.RollingAttack.Size = new System.Drawing.Size(115, 23);
            this.RollingAttack.TabIndex = 9;
            this.RollingAttack.Text = "Push Onward Men";
            this.RollingAttack.UseVisualStyleBackColor = false;
            this.RollingAttack.Click += new System.EventHandler(this.RollingAttack_Click);
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Location = new System.Drawing.Point(16, 31);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(52, 13);
            this.lblAttack.TabIndex = 3;
            this.lblAttack.Text = "Attackers";
            // 
            // comboAttackers
            // 
            this.comboAttackers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAttackers.FormattingEnabled = true;
            this.comboAttackers.Location = new System.Drawing.Point(102, 28);
            this.comboAttackers.Name = "comboAttackers";
            this.comboAttackers.Size = new System.Drawing.Size(159, 21);
            this.comboAttackers.TabIndex = 8;
            // 
            // clearall
            // 
            this.clearall.BackColor = System.Drawing.Color.SlateGray;
            this.clearall.Location = new System.Drawing.Point(450, 138);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(53, 25);
            this.clearall.TabIndex = 11;
            this.clearall.Text = "Clear";
            this.clearall.UseVisualStyleBackColor = false;
            this.clearall.Click += new System.EventHandler(this.clearAll_click);
            // 
            // RiskRoller1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(531, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SingleRoll);
            this.Controls.Add(this.clearall);
            this.Controls.Add(this.Output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RiskRoller1";
            this.Text = "Risk Roller";
            this.SingleRoll.ResumeLayout(false);
            this.SingleRoll.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Attack2on1;
        private System.Windows.Forms.Button Attack1on1;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label lblDefend;
        private System.Windows.Forms.ComboBox comboDefenders;
        private System.Windows.Forms.Label lblBattle;
        private System.Windows.Forms.Button Attack3on1;
        private System.Windows.Forms.GroupBox SingleRoll;
        private System.Windows.Forms.Button Attack3on2;
        private System.Windows.Forms.Button Attack2on2;
        private System.Windows.Forms.Button Attack1on2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.ComboBox comboAttackers;
        private System.Windows.Forms.Button RollingAttack;
        private System.Windows.Forms.CheckBox toTheBloodyEnd;
        private System.Windows.Forms.Button clearall;
    }
}

