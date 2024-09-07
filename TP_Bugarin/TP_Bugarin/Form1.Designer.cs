namespace TP_Bugarin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_wordGuess = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.WrongList = new System.Windows.Forms.ListBox();
            this.tb_guess = new System.Windows.Forms.Button();
            this.lb_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_wordGuess
            // 
            this.lb_wordGuess.AutoSize = true;
            this.lb_wordGuess.BackColor = System.Drawing.Color.Transparent;
            this.lb_wordGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_wordGuess.Location = new System.Drawing.Point(141, 126);
            this.lb_wordGuess.Name = "lb_wordGuess";
            this.lb_wordGuess.Size = new System.Drawing.Size(202, 39);
            this.lb_wordGuess.TabIndex = 0;
            this.lb_wordGuess.Text = "wordGuess";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wrong Guess";
            // 
            // tb_answer
            // 
            this.tb_answer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_answer.Location = new System.Drawing.Point(128, 186);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(229, 38);
            this.tb_answer.TabIndex = 2;
            // 
            // WrongList
            // 
            this.WrongList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongList.FormattingEnabled = true;
            this.WrongList.ItemHeight = 16;
            this.WrongList.Location = new System.Drawing.Point(435, 170);
            this.WrongList.Name = "WrongList";
            this.WrongList.Size = new System.Drawing.Size(112, 148);
            this.WrongList.TabIndex = 3;
            // 
            // tb_guess
            // 
            this.tb_guess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_guess.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_guess.Location = new System.Drawing.Point(177, 244);
            this.tb_guess.Name = "tb_guess";
            this.tb_guess.Size = new System.Drawing.Size(127, 58);
            this.tb_guess.TabIndex = 4;
            this.tb_guess.Text = "Guess";
            this.tb_guess.UseVisualStyleBackColor = false;
            this.tb_guess.Click += new System.EventHandler(this.tb_guess_Click);
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.BackColor = System.Drawing.Color.Transparent;
            this.lb_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score.Location = new System.Drawing.Point(604, 170);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(91, 33);
            this.lb_score.TabIndex = 5;
            this.lb_score.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 480);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.tb_guess);
            this.Controls.Add(this.WrongList);
            this.Controls.Add(this.tb_answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_wordGuess);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_wordGuess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.ListBox WrongList;
        private System.Windows.Forms.Button tb_guess;
        private System.Windows.Forms.Label lb_score;
    }
}

