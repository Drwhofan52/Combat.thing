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
            SuspendLayout();
            // 
            // BattleBtn
            // 
            BattleBtn.Location = new Point(416, 470);
            BattleBtn.Name = "BattleBtn";
            BattleBtn.Size = new Size(143, 79);
            BattleBtn.TabIndex = 0;
            BattleBtn.Text = "battle";
            BattleBtn.UseVisualStyleBackColor = true;
            BattleBtn.Click += BattleBtn_Click;
            // 
            // TRTBtn
            // 
            TRTBtn.Location = new Point(565, 241);
            TRTBtn.Name = "TRTBtn";
            TRTBtn.Size = new Size(106, 96);
            TRTBtn.TabIndex = 1;
            TRTBtn.Text = "TR";
            TRTBtn.UseVisualStyleBackColor = true;
            TRTBtn.Click += TRTBtn_Click;
            // 
            // TLTBtn
            // 
            TLTBtn.Location = new Point(304, 241);
            TLTBtn.Name = "TLTBtn";
            TLTBtn.Size = new Size(106, 96);
            TLTBtn.TabIndex = 2;
            TLTBtn.Text = "TL";
            TLTBtn.UseVisualStyleBackColor = true;
            // 
            // BLTbtn
            // 
            BLTbtn.Location = new Point(304, 380);
            BLTbtn.Name = "BLTbtn";
            BLTbtn.Size = new Size(106, 96);
            BLTbtn.TabIndex = 3;
            BLTbtn.Text = "BL";
            BLTbtn.UseVisualStyleBackColor = true;
            // 
            // BRTBtn
            // 
            BRTBtn.Location = new Point(565, 380);
            BRTBtn.Name = "BRTBtn";
            BRTBtn.Size = new Size(106, 96);
            BRTBtn.TabIndex = 4;
            BRTBtn.Text = "BR";
            BRTBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(984, 561);
            Controls.Add(BRTBtn);
            Controls.Add(BLTbtn);
            Controls.Add(TLTBtn);
            Controls.Add(TRTBtn);
            Controls.Add(BattleBtn);
            Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 9, 8, 9);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BattleBtn;
        private Button TRTBtn;
        private Button TLTBtn;
        private Button BLTbtn;
        private Button BRTBtn;
    }
}
