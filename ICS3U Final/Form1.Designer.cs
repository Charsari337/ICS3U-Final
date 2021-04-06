
namespace ICS3U_Final
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.pOp1Butt = new System.Windows.Forms.Button();
            this.pOp2Butt = new System.Windows.Forms.Button();
            this.pOp3Butt = new System.Windows.Forms.Button();
            this.pOp4Butt = new System.Windows.Forms.Button();
            this.dialoguePictureBox = new System.Windows.Forms.PictureBox();
            this.dialogueTextBox = new System.Windows.Forms.Label();
            this.choiceMicon = new System.Windows.Forms.Label();
            this.choiceNicon = new System.Windows.Forms.Label();
            this.choiceNlabel = new System.Windows.Forms.Label();
            this.choiceMlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dialoguePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Papyrus", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(151, 190);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(903, 122);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Spooky School Legends";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subTitleLabel.Font = new System.Drawing.Font("Papyrus", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleLabel.ForeColor = System.Drawing.Color.White;
            this.subTitleLabel.Location = new System.Drawing.Point(151, 361);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(903, 380);
            this.subTitleLabel.TabIndex = 1;
            this.subTitleLabel.Text = "Press Space to Start or Escape to Exit";
            this.subTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pOp1Butt
            // 
            this.pOp1Butt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pOp1Butt.FlatAppearance.BorderSize = 2;
            this.pOp1Butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pOp1Butt.Font = new System.Drawing.Font("Papyrus", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOp1Butt.ForeColor = System.Drawing.Color.White;
            this.pOp1Butt.Location = new System.Drawing.Point(162, 97);
            this.pOp1Butt.Name = "pOp1Butt";
            this.pOp1Butt.Size = new System.Drawing.Size(96, 90);
            this.pOp1Butt.TabIndex = 2;
            this.pOp1Butt.Text = "1";
            this.pOp1Butt.UseVisualStyleBackColor = true;
            this.pOp1Butt.Click += new System.EventHandler(this.pOp1Butt_Click);
            // 
            // pOp2Butt
            // 
            this.pOp2Butt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pOp2Butt.FlatAppearance.BorderSize = 2;
            this.pOp2Butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pOp2Butt.Font = new System.Drawing.Font("Papyrus", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOp2Butt.ForeColor = System.Drawing.Color.White;
            this.pOp2Butt.Location = new System.Drawing.Point(409, 97);
            this.pOp2Butt.Name = "pOp2Butt";
            this.pOp2Butt.Size = new System.Drawing.Size(96, 90);
            this.pOp2Butt.TabIndex = 3;
            this.pOp2Butt.Text = "2";
            this.pOp2Butt.UseVisualStyleBackColor = true;
            this.pOp2Butt.Click += new System.EventHandler(this.pOp2Butt_Click);
            // 
            // pOp3Butt
            // 
            this.pOp3Butt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pOp3Butt.FlatAppearance.BorderSize = 2;
            this.pOp3Butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pOp3Butt.Font = new System.Drawing.Font("Papyrus", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOp3Butt.ForeColor = System.Drawing.Color.White;
            this.pOp3Butt.Location = new System.Drawing.Point(662, 97);
            this.pOp3Butt.Name = "pOp3Butt";
            this.pOp3Butt.Size = new System.Drawing.Size(96, 90);
            this.pOp3Butt.TabIndex = 4;
            this.pOp3Butt.Text = "3";
            this.pOp3Butt.UseVisualStyleBackColor = true;
            this.pOp3Butt.Click += new System.EventHandler(this.pOp3Butt_Click);
            // 
            // pOp4Butt
            // 
            this.pOp4Butt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pOp4Butt.FlatAppearance.BorderSize = 2;
            this.pOp4Butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pOp4Butt.Font = new System.Drawing.Font("Papyrus", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOp4Butt.ForeColor = System.Drawing.Color.White;
            this.pOp4Butt.Location = new System.Drawing.Point(927, 97);
            this.pOp4Butt.Name = "pOp4Butt";
            this.pOp4Butt.Size = new System.Drawing.Size(96, 90);
            this.pOp4Butt.TabIndex = 5;
            this.pOp4Butt.Text = "4";
            this.pOp4Butt.UseVisualStyleBackColor = true;
            this.pOp4Butt.Click += new System.EventHandler(this.pOp4Butt_Click);
            // 
            // dialoguePictureBox
            // 
            this.dialoguePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dialoguePictureBox.Location = new System.Drawing.Point(220, 12);
            this.dialoguePictureBox.Name = "dialoguePictureBox";
            this.dialoguePictureBox.Size = new System.Drawing.Size(757, 362);
            this.dialoguePictureBox.TabIndex = 6;
            this.dialoguePictureBox.TabStop = false;
            // 
            // dialogueTextBox
            // 
            this.dialogueTextBox.BackColor = System.Drawing.Color.Transparent;
            this.dialogueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dialogueTextBox.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogueTextBox.ForeColor = System.Drawing.Color.White;
            this.dialogueTextBox.Location = new System.Drawing.Point(141, 388);
            this.dialogueTextBox.Name = "dialogueTextBox";
            this.dialogueTextBox.Size = new System.Drawing.Size(903, 240);
            this.dialogueTextBox.TabIndex = 7;
            this.dialogueTextBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // choiceMicon
            // 
            this.choiceMicon.BackColor = System.Drawing.Color.Transparent;
            this.choiceMicon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choiceMicon.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceMicon.ForeColor = System.Drawing.Color.White;
            this.choiceMicon.Location = new System.Drawing.Point(215, 668);
            this.choiceMicon.Name = "choiceMicon";
            this.choiceMicon.Size = new System.Drawing.Size(75, 59);
            this.choiceMicon.TabIndex = 8;
            this.choiceMicon.Text = "M";
            this.choiceMicon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // choiceNicon
            // 
            this.choiceNicon.BackColor = System.Drawing.Color.Transparent;
            this.choiceNicon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choiceNicon.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceNicon.ForeColor = System.Drawing.Color.White;
            this.choiceNicon.Location = new System.Drawing.Point(657, 668);
            this.choiceNicon.Name = "choiceNicon";
            this.choiceNicon.Size = new System.Drawing.Size(75, 59);
            this.choiceNicon.TabIndex = 9;
            this.choiceNicon.Text = "N";
            this.choiceNicon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // choiceNlabel
            // 
            this.choiceNlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.choiceNlabel.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceNlabel.ForeColor = System.Drawing.Color.White;
            this.choiceNlabel.Location = new System.Drawing.Point(738, 668);
            this.choiceNlabel.Name = "choiceNlabel";
            this.choiceNlabel.Size = new System.Drawing.Size(239, 59);
            this.choiceNlabel.TabIndex = 11;
            this.choiceNlabel.Text = "Continue";
            this.choiceNlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // choiceMlabel
            // 
            this.choiceMlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.choiceMlabel.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceMlabel.ForeColor = System.Drawing.Color.White;
            this.choiceMlabel.Location = new System.Drawing.Point(296, 668);
            this.choiceMlabel.Name = "choiceMlabel";
            this.choiceMlabel.Size = new System.Drawing.Size(239, 59);
            this.choiceMlabel.TabIndex = 12;
            this.choiceMlabel.Text = "Continue";
            this.choiceMlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.choiceMlabel);
            this.Controls.Add(this.choiceNlabel);
            this.Controls.Add(this.choiceNicon);
            this.Controls.Add(this.choiceMicon);
            this.Controls.Add(this.dialogueTextBox);
            this.Controls.Add(this.dialoguePictureBox);
            this.Controls.Add(this.pOp4Butt);
            this.Controls.Add(this.pOp3Butt);
            this.Controls.Add(this.pOp2Butt);
            this.Controls.Add(this.pOp1Butt);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);

            ((System.ComponentModel.ISupportInitialize)(this.dialoguePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.Button pOp1Butt;
        private System.Windows.Forms.Button pOp2Butt;
        private System.Windows.Forms.Button pOp3Butt;
        private System.Windows.Forms.Button pOp4Butt;
        private System.Windows.Forms.PictureBox dialoguePictureBox;
        private System.Windows.Forms.Label dialogueTextBox;
        private System.Windows.Forms.Label choiceMicon;
        private System.Windows.Forms.Label choiceNicon;
        private System.Windows.Forms.Label choiceNlabel;
        private System.Windows.Forms.Label choiceMlabel;
    }
}

