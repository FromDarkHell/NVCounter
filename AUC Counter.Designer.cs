namespace NV_AUC
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
            this.Check = new System.Windows.Forms.CheckedListBox();
            this.cDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.Backcolor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cDialogue = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.CheckOnClick = true;
            this.Check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Check.FormattingEnabled = true;
            this.Check.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Check.Items.AddRange(new object[] {
            "Indiana Jones - Suave Gambler",
            "REPCONN - Space Suit",
            "Deathclaw Promontory - Remant\'s Power Armor",
            "Hidden Valley - Brotherhood Elder\'s Robe",
            "Mortimer - Tuxedo Hat",
            "The Tops - Benny\'s Suit",
            "Vault 21 Gift Shop - Vault 21 Jumpsuit",
            "Mick & Ralphs - Naughty Nightwear",
            "Mick & Ralphs - Eulogy Jones\' Hat",
            "Atomic Wrangler -  Caleb McCaffery\'s Hat",
            "The King - Viva Las Vegas",
            "Julie Farkas - Followers Lab Coat",
            "Orion Moreno - Explorer\'s Gear",
            "Win\'s Hideout - Vance\'s Lucky Hat/Vikki\'s Bonnet",
            "Dermot - Police Hat - RobCo Jumpsuit",
            "Follower Safehouse - All-purpose Sci. suit",
            "Silver Peak Mine - Remant\'s Power Helmet",
            "Vault 3 - Motor-Runner\'s Helmet",
            "Boulder City - Jessup\'s Bandana",
            "Hoover Dam - Chinese Stealth Armor",
            "The Fort - Caesar\'s Armor",
            "Legate\'s Camp - Legate\'s Helmet",
            "Legate\'s Camp - General Oliver\'s Cap",
            "Legate\'s Camp - General Oliver\'s Outfit"});
            this.Check.Location = new System.Drawing.Point(0, 0);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(262, 407);
            this.Check.TabIndex = 0;
            this.Check.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Backcolor
            // 
            this.Backcolor.Location = new System.Drawing.Point(0, 383);
            this.Backcolor.Name = "Backcolor";
            this.Backcolor.Size = new System.Drawing.Size(102, 23);
            this.Backcolor.TabIndex = 1;
            this.Backcolor.Text = "Background Color";
            this.Backcolor.UseVisualStyleBackColor = true;
            this.Backcolor.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Text Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Open AUW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 407);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Backcolor);
            this.Controls.Add(this.Check);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Unique Counter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Check;
        private System.Windows.Forms.ColorDialog cDialog;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button Backcolor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog cDialogue;
        public System.Windows.Forms.Button button2;
    }
}

