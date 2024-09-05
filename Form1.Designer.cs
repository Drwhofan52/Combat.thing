namespace combat_thing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BattleBtn = new Button();
            TRTBtn = new Button();
            TLTBtn = new Button();
            BLTbtn = new Button();
            BRTBtn = new Button();
            TargetPnl = new Panel();
            panel1 = new Panel();
            HealthBar = new ProgressBar();
            HthLbl = new Label();
            panel2 = new Panel();
            DnPwrbtn = new Button();
            UpPwrbtn = new Button();
            PwrTxtBox = new TextBox();
            HthLbl2 = new Label();
            TargetPnl.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BattleBtn
            // 
            BattleBtn.Location = new Point(269, 492);
            BattleBtn.Name = "BattleBtn";
            BattleBtn.Size = new Size(325, 57);
            BattleBtn.TabIndex = 0;
            BattleBtn.Text = "Battle";
            BattleBtn.UseVisualStyleBackColor = true;
            BattleBtn.Click += BattleBtn_Click;
            // 
            // TRTBtn
            // 
            TRTBtn.Location = new Point(139, 3);
            TRTBtn.Name = "TRTBtn";
            TRTBtn.Size = new Size(106, 96);
            TRTBtn.TabIndex = 1;
            TRTBtn.Text = "TR";
            TRTBtn.UseVisualStyleBackColor = true;
            TRTBtn.Click += TRTBtn_Click;
            // 
            // TLTBtn
            // 
            TLTBtn.Location = new Point(3, 3);
            TLTBtn.Name = "TLTBtn";
            TLTBtn.Size = new Size(106, 96);
            TLTBtn.TabIndex = 2;
            TLTBtn.Text = "TL";
            TLTBtn.UseVisualStyleBackColor = true;
            TLTBtn.Click += TLTBtn_Click;
            // 
            // BLTbtn
            // 
            BLTbtn.Location = new Point(3, 134);
            BLTbtn.Name = "BLTbtn";
            BLTbtn.Size = new Size(106, 96);
            BLTbtn.TabIndex = 3;
            BLTbtn.Text = "BL";
            BLTbtn.UseVisualStyleBackColor = true;
            BLTbtn.Click += BLTbtn_Click;
            // 
            // BRTBtn
            // 
            BRTBtn.Location = new Point(139, 134);
            BRTBtn.Name = "BRTBtn";
            BRTBtn.Size = new Size(106, 96);
            BRTBtn.TabIndex = 4;
            BRTBtn.Text = "BR";
            BRTBtn.UseVisualStyleBackColor = true;
            BRTBtn.Click += BRTBtn_Click;
            // 
            // TargetPnl
            // 
            TargetPnl.BackColor = Color.Gray;
            TargetPnl.Controls.Add(TLTBtn);
            TargetPnl.Controls.Add(BRTBtn);
            TargetPnl.Controls.Add(BLTbtn);
            TargetPnl.Controls.Add(TRTBtn);
            TargetPnl.Location = new Point(12, 12);
            TargetPnl.Name = "TargetPnl";
            TargetPnl.Size = new Size(252, 234);
            TargetPnl.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(270, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 474);
            panel1.TabIndex = 7;
            // 
            // HealthBar
            // 
            HealthBar.Location = new Point(0, 13);
            HealthBar.Maximum = 10;
            HealthBar.Name = "HealthBar";
            HealthBar.Size = new Size(252, 24);
            HealthBar.TabIndex = 0;
            // 
            // HthLbl
            // 
            HthLbl.AutoSize = true;
            HthLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HthLbl.Location = new Point(0, 40);
            HthLbl.Name = "HthLbl";
            HthLbl.Size = new Size(84, 32);
            HthLbl.TabIndex = 1;
            HthLbl.Text = "Health";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(DnPwrbtn);
            panel2.Controls.Add(UpPwrbtn);
            panel2.Controls.Add(PwrTxtBox);
            panel2.Controls.Add(HthLbl2);
            panel2.Controls.Add(HthLbl);
            panel2.Controls.Add(HealthBar);
            panel2.Location = new Point(12, 252);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 297);
            panel2.TabIndex = 6;
            // 
            // DnPwrbtn
            // 
            DnPwrbtn.Location = new Point(186, 132);
            DnPwrbtn.Name = "DnPwrbtn";
            DnPwrbtn.Size = new Size(59, 23);
            DnPwrbtn.TabIndex = 5;
            DnPwrbtn.UseVisualStyleBackColor = true;
            DnPwrbtn.Click += DnPwrbtn_Click;
            // 
            // UpPwrbtn
            // 
            UpPwrbtn.Location = new Point(186, 43);
            UpPwrbtn.Name = "UpPwrbtn";
            UpPwrbtn.Size = new Size(59, 23);
            UpPwrbtn.TabIndex = 4;
            UpPwrbtn.UseVisualStyleBackColor = true;
            UpPwrbtn.Click += UpPwrbtn_Click;
            // 
            // PwrTxtBox
            // 
            PwrTxtBox.Location = new Point(186, 72);
            PwrTxtBox.Name = "PwrTxtBox";
            PwrTxtBox.Size = new Size(59, 54);
            PwrTxtBox.TabIndex = 3;
            // 
            // HthLbl2
            // 
            HthLbl2.AutoSize = true;
            HthLbl2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HthLbl2.Location = new Point(90, 40);
            HthLbl2.Name = "HthLbl2";
            HthLbl2.Size = new Size(70, 32);
            HthLbl2.TabIndex = 2;
            HthLbl2.Text = "=  10";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DimGray;
            ClientSize = new Size(601, 561);
            Controls.Add(panel1);
            Controls.Add(BattleBtn);
            Controls.Add(panel2);
            Controls.Add(TargetPnl);
            Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 9, 8, 9);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            TargetPnl.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BattleBtn;
        private Button TRTBtn;
        private Button TLTBtn;
        private Button BLTbtn;
        private Button BRTBtn;
        private Panel TargetPnl;
        private Panel panel1;
        private ProgressBar HealthBar;
        private Label HthLbl;
        private Panel panel2;
        private Label HthLbl2;
        private Button DnPwrbtn;
        private Button UpPwrbtn;
        private TextBox PwrTxtBox;
    }
}
