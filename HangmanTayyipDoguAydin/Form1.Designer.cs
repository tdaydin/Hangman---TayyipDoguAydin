namespace HangmanTayyipDoguAydin
{
    partial class hangmanProg
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbSentence = new System.Windows.Forms.RichTextBox();
            this.bSendSentence = new System.Windows.Forms.Button();
            this.lbShow = new System.Windows.Forms.ListBox();
            this.lbGuess = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.bSendLetter = new System.Windows.Forms.Button();
            this.lbErrorCount = new System.Windows.Forms.ListBox();
            this.lbHangedOne = new System.Windows.Forms.ListBox();
            this.lbHangedThree = new System.Windows.Forms.ListBox();
            this.lbHangedTwo = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bReplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(140, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1233, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "This program will choose a word from your sentece and will have you guess.\r\nPleas" +
    "e enter your sentence down below!\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbSentence
            // 
            this.rtbSentence.Location = new System.Drawing.Point(148, 158);
            this.rtbSentence.Name = "rtbSentence";
            this.rtbSentence.Size = new System.Drawing.Size(1225, 65);
            this.rtbSentence.TabIndex = 2;
            this.rtbSentence.Text = "";
            // 
            // bSendSentence
            // 
            this.bSendSentence.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSendSentence.Location = new System.Drawing.Point(545, 248);
            this.bSendSentence.Name = "bSendSentence";
            this.bSendSentence.Size = new System.Drawing.Size(373, 76);
            this.bSendSentence.TabIndex = 3;
            this.bSendSentence.Text = "Send Sentence";
            this.bSendSentence.UseVisualStyleBackColor = true;
            this.bSendSentence.Click += new System.EventHandler(this.bSendSentence_Click);
            // 
            // lbShow
            // 
            this.lbShow.Font = new System.Drawing.Font("Times New Roman", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbShow.FormattingEnabled = true;
            this.lbShow.ItemHeight = 31;
            this.lbShow.Location = new System.Drawing.Point(80, 720);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(325, 190);
            this.lbShow.TabIndex = 5;
            // 
            // lbGuess
            // 
            this.lbGuess.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbGuess.FormattingEnabled = true;
            this.lbGuess.ItemHeight = 61;
            this.lbGuess.Location = new System.Drawing.Point(68, 354);
            this.lbGuess.Name = "lbGuess";
            this.lbGuess.Size = new System.Drawing.Size(1381, 65);
            this.lbGuess.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(309, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter a character";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLetter
            // 
            this.tbLetter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbLetter.Location = new System.Drawing.Point(658, 488);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(82, 53);
            this.tbLetter.TabIndex = 8;
            // 
            // bSendLetter
            // 
            this.bSendLetter.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSendLetter.Location = new System.Drawing.Point(779, 488);
            this.bSendLetter.Name = "bSendLetter";
            this.bSendLetter.Size = new System.Drawing.Size(259, 61);
            this.bSendLetter.TabIndex = 9;
            this.bSendLetter.Text = "Send Letter";
            this.bSendLetter.UseVisualStyleBackColor = true;
            this.bSendLetter.Click += new System.EventHandler(this.bSendLetter_Click);
            // 
            // lbErrorCount
            // 
            this.lbErrorCount.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbErrorCount.FormattingEnabled = true;
            this.lbErrorCount.ItemHeight = 61;
            this.lbErrorCount.Location = new System.Drawing.Point(80, 587);
            this.lbErrorCount.Name = "lbErrorCount";
            this.lbErrorCount.Size = new System.Drawing.Size(325, 126);
            this.lbErrorCount.TabIndex = 10;
            // 
            // lbHangedOne
            // 
            this.lbHangedOne.BackColor = System.Drawing.SystemColors.Control;
            this.lbHangedOne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbHangedOne.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbHangedOne.FormattingEnabled = true;
            this.lbHangedOne.ItemHeight = 53;
            this.lbHangedOne.Location = new System.Drawing.Point(554, 662);
            this.lbHangedOne.Name = "lbHangedOne";
            this.lbHangedOne.Size = new System.Drawing.Size(291, 53);
            this.lbHangedOne.TabIndex = 11;
            // 
            // lbHangedThree
            // 
            this.lbHangedThree.BackColor = System.Drawing.SystemColors.Control;
            this.lbHangedThree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbHangedThree.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbHangedThree.FormattingEnabled = true;
            this.lbHangedThree.ItemHeight = 53;
            this.lbHangedThree.Location = new System.Drawing.Point(554, 785);
            this.lbHangedThree.Name = "lbHangedThree";
            this.lbHangedThree.Size = new System.Drawing.Size(291, 53);
            this.lbHangedThree.TabIndex = 13;
            // 
            // lbHangedTwo
            // 
            this.lbHangedTwo.BackColor = System.Drawing.SystemColors.Control;
            this.lbHangedTwo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbHangedTwo.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbHangedTwo.ForeColor = System.Drawing.Color.Black;
            this.lbHangedTwo.FormattingEnabled = true;
            this.lbHangedTwo.ItemHeight = 53;
            this.lbHangedTwo.Location = new System.Drawing.Point(554, 722);
            this.lbHangedTwo.Name = "lbHangedTwo";
            this.lbHangedTwo.Size = new System.Drawing.Size(291, 53);
            this.lbHangedTwo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(519, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 46);
            this.label3.TabIndex = 15;
            this.label3.Text = "Your man is down here!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bReplay
            // 
            this.bReplay.Font = new System.Drawing.Font("Times New Roman", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bReplay.Location = new System.Drawing.Point(1079, 486);
            this.bReplay.Name = "bReplay";
            this.bReplay.Size = new System.Drawing.Size(354, 82);
            this.bReplay.TabIndex = 16;
            this.bReplay.Text = "Replay";
            this.bReplay.UseVisualStyleBackColor = true;
            this.bReplay.Click += new System.EventHandler(this.bReplay_Click);
            // 
            // hangmanProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1489, 1008);
            this.Controls.Add(this.bReplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbHangedTwo);
            this.Controls.Add(this.lbHangedThree);
            this.Controls.Add(this.lbHangedOne);
            this.Controls.Add(this.lbErrorCount);
            this.Controls.Add(this.bSendLetter);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGuess);
            this.Controls.Add(this.lbShow);
            this.Controls.Add(this.bSendSentence);
            this.Controls.Add(this.rtbSentence);
            this.Controls.Add(this.label1);
            this.Name = "hangmanProg";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbSentence;
        private System.Windows.Forms.Button bSendSentence;
        private System.Windows.Forms.ListBox lbShow;
        private System.Windows.Forms.ListBox lbGuess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Button bSendLetter;
        private System.Windows.Forms.ListBox lbErrorCount;
        private System.Windows.Forms.ListBox lbHangedOne;
        private System.Windows.Forms.ListBox lbHangedThree;
        private System.Windows.Forms.ListBox lbHangedTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bReplay;
    }
}

