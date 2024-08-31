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
            CloseBtn = new Label();
            Atkbtn = new Button();
            SuspendLayout();
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.BackColor = SystemColors.Desktop;
            CloseBtn.ForeColor = Color.CornflowerBlue;
            CloseBtn.Location = new Point(439, -1);
            CloseBtn.Margin = new Padding(5, 0, 5, 0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(60, 24);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "close";
            CloseBtn.Click += CloseBtn_Click;
            // 
            // Atkbtn
            // 
            Atkbtn.Location = new Point(183, 233);
            Atkbtn.Name = "Atkbtn";
            Atkbtn.Size = new Size(75, 64);
            Atkbtn.TabIndex = 1;
            Atkbtn.Text = "fuck";
            Atkbtn.UseVisualStyleBackColor = true;
            Atkbtn.Click += Atkbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(500, 500);
            Controls.Add(Atkbtn);
            Controls.Add(CloseBtn);
            Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CloseBtn;
        private Button Atkbtn;
    }
}
