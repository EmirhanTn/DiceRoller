namespace DiceRoller
{
    partial class FormDiceRoller
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
            picClose = new PictureBox();
            PicDice = new PictureBox();
            BtnRoll = new Button();
            PicDice2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicDice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicDice2).BeginInit();
            SuspendLayout();
            // 
            // picClose
            // 
            picClose.Image = Properties.Resources.close_window_48;
            picClose.Location = new Point(733, 23);
            picClose.Name = "picClose";
            picClose.Size = new Size(35, 35);
            picClose.SizeMode = PictureBoxSizeMode.Zoom;
            picClose.TabIndex = 0;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            picClose.MouseHover += picClose_MouseHover;
            // 
            // PicDice
            // 
            PicDice.Image = Properties.Resources.dice_6;
            PicDice.Location = new Point(99, 100);
            PicDice.Name = "PicDice";
            PicDice.Size = new Size(222, 222);
            PicDice.SizeMode = PictureBoxSizeMode.Zoom;
            PicDice.TabIndex = 1;
            PicDice.TabStop = false;
            // 
            // BtnRoll
            // 
            BtnRoll.BackColor = Color.DodgerBlue;
            BtnRoll.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnRoll.ForeColor = Color.White;
            BtnRoll.Location = new Point(287, 341);
            BtnRoll.Name = "BtnRoll";
            BtnRoll.Size = new Size(164, 67);
            BtnRoll.TabIndex = 2;
            BtnRoll.Text = "ZAR AT";
            BtnRoll.UseVisualStyleBackColor = false;
            BtnRoll.Click += BtnRoll_Click;
            // 
            // PicDice2
            // 
            PicDice2.Image = Properties.Resources.dice_2;
            PicDice2.Location = new Point(419, 100);
            PicDice2.Name = "PicDice2";
            PicDice2.Size = new Size(222, 222);
            PicDice2.SizeMode = PictureBoxSizeMode.Zoom;
            PicDice2.TabIndex = 3;
            PicDice2.TabStop = false;
            // 
            // FormDiceRoller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(PicDice2);
            Controls.Add(BtnRoll);
            Controls.Add(PicDice);
            Controls.Add(picClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDiceRoller";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zar At";
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicDice).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicDice2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picClose;
        private PictureBox PicDice;
        private Button BtnRoll;
        private PictureBox PicDice2;
    }
}
