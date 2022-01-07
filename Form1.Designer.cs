namespace SCRABBLE_SCHOOL_VERSION
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
            this.MAINSCORE = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.QUIT = new System.Windows.Forms.Button();
            this.START = new System.Windows.Forms.Button();
            this.MAINBOX = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.REFILLSET = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CLEAR = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.CorrectWords = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ENLETTER = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.WELDONE = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LOGINANDUSERNAME = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.USERNAME = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayerUsername = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.MAINBOX.SuspendLayout();
            this.LOGINANDUSERNAME.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MAINSCORE
            // 
            this.MAINSCORE.AutoSize = true;
            this.MAINSCORE.BackColor = System.Drawing.Color.Transparent;
            this.MAINSCORE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAINSCORE.Location = new System.Drawing.Point(17, 240);
            this.MAINSCORE.Name = "MAINSCORE";
            this.MAINSCORE.Size = new System.Drawing.Size(76, 20);
            this.MAINSCORE.TabIndex = 1;
            this.MAINSCORE.Text = "SCORE:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Stop Music";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // QUIT
            // 
            this.QUIT.Location = new System.Drawing.Point(1497, 12);
            this.QUIT.Name = "QUIT";
            this.QUIT.Size = new System.Drawing.Size(75, 23);
            this.QUIT.TabIndex = 8;
            this.QUIT.Text = "QUIT";
            this.QUIT.UseVisualStyleBackColor = true;
            this.QUIT.Click += new System.EventHandler(this.QUIT_Click);
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.Color.Transparent;
            this.START.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.START.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.START.ForeColor = System.Drawing.Color.Black;
            this.START.Location = new System.Drawing.Point(299, 227);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(175, 42);
            this.START.TabIndex = 9;
            this.START.Text = "START\r\n";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // MAINBOX
            // 
            this.MAINBOX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MAINBOX.Controls.Add(this.label5);
            this.MAINBOX.Controls.Add(this.REFILLSET);
            this.MAINBOX.Controls.Add(this.label2);
            this.MAINBOX.Controls.Add(this.CLEAR);
            this.MAINBOX.Controls.Add(this.button9);
            this.MAINBOX.Controls.Add(this.CorrectWords);
            this.MAINBOX.Controls.Add(this.label3);
            this.MAINBOX.Controls.Add(this.ENLETTER);
            this.MAINBOX.Controls.Add(this.G);
            this.MAINBOX.Controls.Add(this.F);
            this.MAINBOX.Controls.Add(this.E);
            this.MAINBOX.Controls.Add(this.D);
            this.MAINBOX.Controls.Add(this.C);
            this.MAINBOX.Controls.Add(this.B);
            this.MAINBOX.Controls.Add(this.A);
            this.MAINBOX.Location = new System.Drawing.Point(12, 292);
            this.MAINBOX.Name = "MAINBOX";
            this.MAINBOX.Size = new System.Drawing.Size(781, 484);
            this.MAINBOX.TabIndex = 10;
            this.MAINBOX.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "NOTE: You can only enter a word ONCE. ";
            // 
            // REFILLSET
            // 
            this.REFILLSET.Location = new System.Drawing.Point(303, 176);
            this.REFILLSET.Name = "REFILLSET";
            this.REFILLSET.Size = new System.Drawing.Size(73, 40);
            this.REFILLSET.TabIndex = 24;
            this.REFILLSET.Text = "REFILL SET";
            this.REFILLSET.UseVisualStyleBackColor = true;
            this.REFILLSET.Click += new System.EventHandler(this.REFILLSET_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(504, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Correct Words:";
            // 
            // CLEAR
            // 
            this.CLEAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CLEAR.Location = new System.Drawing.Point(395, 176);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(67, 40);
            this.CLEAR.TabIndex = 22;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(225, 176);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 40);
            this.button9.TabIndex = 21;
            this.button9.Text = "ENTER";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // CorrectWords
            // 
            this.CorrectWords.FormattingEnabled = true;
            this.CorrectWords.Location = new System.Drawing.Point(507, 176);
            this.CorrectWords.Name = "CorrectWords";
            this.CorrectWords.Size = new System.Drawing.Size(176, 212);
            this.CorrectWords.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ENTERED LETTERS:";
            // 
            // ENLETTER
            // 
            this.ENLETTER.AutoSize = true;
            this.ENLETTER.Location = new System.Drawing.Point(126, 190);
            this.ENLETTER.Name = "ENLETTER";
            this.ENLETTER.Size = new System.Drawing.Size(0, 13);
            this.ENLETTER.TabIndex = 18;
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(590, 32);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(75, 72);
            this.G.TabIndex = 17;
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.G_Click);
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(490, 32);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(75, 72);
            this.F.TabIndex = 16;
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.F_Click);
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(395, 32);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(75, 72);
            this.E.TabIndex = 15;
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.E_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(291, 32);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(75, 72);
            this.D.TabIndex = 14;
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(192, 32);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(75, 72);
            this.C.TabIndex = 13;
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(100, 32);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(75, 72);
            this.B.TabIndex = 12;
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(6, 32);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(75, 72);
            this.A.TabIndex = 11;
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // WELDONE
            // 
            this.WELDONE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WELDONE.BackgroundImage")));
            this.WELDONE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WELDONE.Location = new System.Drawing.Point(1186, 269);
            this.WELDONE.Name = "WELDONE";
            this.WELDONE.Size = new System.Drawing.Size(368, 348);
            this.WELDONE.TabIndex = 21;
            this.WELDONE.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Prisoner SF", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "SCRABBLE: PC VERSION";
            // 
            // LOGINANDUSERNAME
            // 
            this.LOGINANDUSERNAME.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LOGINANDUSERNAME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LOGINANDUSERNAME.Controls.Add(this.button2);
            this.LOGINANDUSERNAME.Controls.Add(this.label6);
            this.LOGINANDUSERNAME.Controls.Add(this.USERNAME);
            this.LOGINANDUSERNAME.Location = new System.Drawing.Point(36, 140);
            this.LOGINANDUSERNAME.Name = "LOGINANDUSERNAME";
            this.LOGINANDUSERNAME.Size = new System.Drawing.Size(569, 54);
            this.LOGINANDUSERNAME.TabIndex = 23;
            this.LOGINANDUSERNAME.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Username";
            // 
            // USERNAME
            // 
            this.USERNAME.Location = new System.Drawing.Point(316, 18);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(100, 20);
            this.USERNAME.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PlayerUsername);
            this.groupBox1.Location = new System.Drawing.Point(876, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 430);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // PlayerUsername
            // 
            this.PlayerUsername.AutoSize = true;
            this.PlayerUsername.Location = new System.Drawing.Point(94, 48);
            this.PlayerUsername.Name = "PlayerUsername";
            this.PlayerUsername.Size = new System.Drawing.Size(35, 13);
            this.PlayerUsername.TabIndex = 0;
            this.PlayerUsername.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 279);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 224);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Current Player:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("BacktalkSerif BTN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(42, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 18);
            this.label19.TabIndex = 13;
            this.label19.Text = "Leaderboard";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(1083, 362);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 14;
            this.Save.Text = "Save Score";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1658, 833);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LOGINANDUSERNAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WELDONE);
            this.Controls.Add(this.MAINBOX);
            this.Controls.Add(this.START);
            this.Controls.Add(this.QUIT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MAINSCORE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MAINBOX.ResumeLayout(false);
            this.MAINBOX.PerformLayout();
            this.LOGINANDUSERNAME.ResumeLayout(false);
            this.LOGINANDUSERNAME.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MAINSCORE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button QUIT;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.GroupBox MAINBOX;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ENLETTER;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListBox CorrectWords;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel WELDONE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button REFILLSET;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox LOGINANDUSERNAME;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox USERNAME;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PlayerUsername;
        private System.Windows.Forms.Button Save;
    }
}

