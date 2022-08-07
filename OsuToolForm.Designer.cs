namespace osu_tournament_management
{
    partial class OsuToolForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OsuToolForm));
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxTeam = new System.Windows.Forms.ListBox();
            this.listBoxPlayer = new System.Windows.Forms.ListBox();
            this.listBoxScore = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "AddTeam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddTeam_Click);
            // 
            // listBoxTeam
            // 
            this.listBoxTeam.FormattingEnabled = true;
            this.listBoxTeam.Location = new System.Drawing.Point(49, 142);
            this.listBoxTeam.Name = "listBoxTeam";
            this.listBoxTeam.Size = new System.Drawing.Size(207, 394);
            this.listBoxTeam.TabIndex = 1;
            this.listBoxTeam.SelectedValueChanged += new System.EventHandler(this.listBoxTeam_SelectedValueChanged);
            // 
            // listBoxPlayer
            // 
            this.listBoxPlayer.FormattingEnabled = true;
            this.listBoxPlayer.Location = new System.Drawing.Point(361, 142);
            this.listBoxPlayer.Name = "listBoxPlayer";
            this.listBoxPlayer.Size = new System.Drawing.Size(207, 394);
            this.listBoxPlayer.TabIndex = 2;
            this.listBoxPlayer.SelectedValueChanged += new System.EventHandler(this.listBoxPlayer_SelectedValueChanged);
            // 
            // listBoxScore
            // 
            this.listBoxScore.FormattingEnabled = true;
            this.listBoxScore.Location = new System.Drawing.Point(678, 142);
            this.listBoxScore.Name = "listBoxScore";
            this.listBoxScore.Size = new System.Drawing.Size(207, 394);
            this.listBoxScore.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "AddPlayer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddPlayer_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(678, 569);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "AddScore";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddScore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 68);
            this.label1.TabIndex = 6;
            this.label1.Text = "Osu Tournament Management";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(170, 568);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 24);
            this.button4.TabIndex = 7;
            this.button4.Text = "DeleteTeam";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.DeleteTeam_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(486, 568);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 24);
            this.button5.TabIndex = 8;
            this.button5.Text = "DeletePlayer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.DeletePlayer_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(803, 568);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 24);
            this.button6.TabIndex = 9;
            this.button6.Text = "DeleteScore";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.DeleteScore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Teams :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Player :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(757, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Score :";
            // 
            // OsuToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBoxScore);
            this.Controls.Add(this.listBoxPlayer);
            this.Controls.Add(this.listBoxTeam);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OsuToolForm";
            this.Text = "Osu_tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxTeam;
        private System.Windows.Forms.ListBox listBoxPlayer;
        private System.Windows.Forms.ListBox listBoxScore;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

