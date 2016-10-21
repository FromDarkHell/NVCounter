namespace NV_AUC
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Diddly = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CAH = new System.Windows.Forms.ColorDialog();
            this.Neighborino = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Diddly
            // 
            this.Diddly.FormattingEnabled = true;
            this.Diddly.Items.AddRange(new object[] {
            "Black Mountain - Annabelle",
            "Repconn HQ - Matter Modulator",
            "Nephi - Nephi\'s Golf Driver",
            "Sunset Sarsaparilla HQ - Pew Pew",
            "North Sewers - Humble Cudgel",
            "Vault 22 - AER14 prototype",
            "Wins\' Hideout - Vance\'s 9mm SMG",
            "Mercenary Camp - YCS/186",
            "Ruby Hill Mine - Pushy",
            "Carrie Boyd - This Machine",
            "The Tops Casino - Maria",
            "Lucky 38 - Goldne Gloves",
            "Sergio - Figaro",
            "Simon",
            "Field\'s Shack - Abilene Kid LE BB Gun",
            "Nellis Array - Thump-Thump",
            "Chance\'s Grave - Chance\'s Knife",
            "Bonnie Springs - Love and Hate",
            "Lonesome Drifter - Mysterious Magnum",
            "Black Rock Cave - Paladin Toaster",
            "Old Lady Gibson - Big Boomer",
            "Novac - That Gun",
            "Dead Sea - Liberator",
            "Broc Flower Cave - Ratslayer",
            "Wolfhorn Ranch - Chopper",
            "Primm - Lucky",
            "Freeisde East Gate - Euclid\'s C-Finder",
            "Vault 34 Armory -  All-American/Pulse Gun",
            "Devil\'s Throat - CZ57 Avenger",
            "Charleston Cave - Oh, Baby!",
            "Fire Dept. - Knock-Knock",
            "Sniper\'s Nest - Gobi Campaign Scout Rifle",
            "Cottonwood Cove - Recompense of the Fallen",
            "Crashed Vertibird - Tesla-Beaton Prototype",
            "Dead Wind Cavern - Mercy",
            "Bleed Me Dry - Dinner Bell",
            "Little Buster - Cram Opener",
            "Corporal Sterling - La Longue Carabine",
            "Legate Lanius - Blade of the East"});
            this.Diddly.Location = new System.Drawing.Point(1, 4);
            this.Diddly.Name = "Diddly";
            this.Diddly.Size = new System.Drawing.Size(268, 589);
            this.Diddly.TabIndex = 0;
            this.Diddly.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Background";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 643);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Text Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 691);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Diddly);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Unique Counter ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Diddly;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog CAH;
        private System.Windows.Forms.ColorDialog Neighborino;
        private System.Windows.Forms.Button button2;
    }
}