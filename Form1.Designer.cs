namespace osu_tournament_management
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxTeam = new System.Windows.Forms.ListBox();
            this.listBoxPlayer = new System.Windows.Forms.ListBox();
            this.listBoxScore = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "AddTeam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddTeam_Click);
            // 
            // listBox1
            // 
            this.listBoxTeam.FormattingEnabled = true;
            this.listBoxTeam.Location = new System.Drawing.Point(45, 111);
            this.listBoxTeam.Name = "listBox1";
            this.listBoxTeam.Size = new System.Drawing.Size(207, 394);
            this.listBoxTeam.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBoxPlayer.FormattingEnabled = true;
            this.listBoxPlayer.Location = new System.Drawing.Point(357, 111);
            this.listBoxPlayer.Name = "listBox2";
            this.listBoxPlayer.Size = new System.Drawing.Size(207, 394);
            this.listBoxPlayer.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBoxScore.FormattingEnabled = true;
            this.listBoxScore.Location = new System.Drawing.Point(674, 111);
            this.listBoxScore.Name = "listBox3";
            this.listBoxScore.Size = new System.Drawing.Size(207, 394);
            this.listBoxScore.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "AddPlayer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(739, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "AddScore";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBoxScore);
            this.Controls.Add(this.listBoxPlayer);
            this.Controls.Add(this.listBoxTeam);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxTeam;
        private System.Windows.Forms.ListBox listBoxPlayer;
        private System.Windows.Forms.ListBox listBoxScore;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

