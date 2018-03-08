namespace Planos_Magic2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic_plano = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.Viajar_destino = new System.Windows.Forms.Button();
            this.btn_Viajar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lista_planos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_plano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_plano
            // 
            this.pic_plano.Location = new System.Drawing.Point(28, 12);
            this.pic_plano.Name = "pic_plano";
            this.pic_plano.Size = new System.Drawing.Size(588, 367);
            this.pic_plano.TabIndex = 0;
            this.pic_plano.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(569, 385);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Planeswalk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Viajar_destino
            // 
            this.Viajar_destino.Location = new System.Drawing.Point(348, 414);
            this.Viajar_destino.Name = "Viajar_destino";
            this.Viajar_destino.Size = new System.Drawing.Size(125, 46);
            this.Viajar_destino.TabIndex = 3;
            this.Viajar_destino.Text = "Viajar a Desitno";
            this.Viajar_destino.UseVisualStyleBackColor = true;
            this.Viajar_destino.Click += new System.EventHandler(this.Viajar_Destino_Click);
            // 
            // btn_Viajar
            // 
            this.btn_Viajar.Location = new System.Drawing.Point(16, 56);
            this.btn_Viajar.Name = "btn_Viajar";
            this.btn_Viajar.Size = new System.Drawing.Size(106, 34);
            this.btn_Viajar.TabIndex = 4;
            this.btn_Viajar.Text = "¡Vamos!";
            this.btn_Viajar.UseVisualStyleBackColor = true;
            this.btn_Viajar.Click += new System.EventHandler(this.btn_Viajar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lista_planos);
            this.panel1.Controls.Add(this.btn_Viajar);
            this.panel1.Location = new System.Drawing.Point(12, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 100);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // lista_planos
            // 
            this.lista_planos.FormattingEnabled = true;
            this.lista_planos.Items.AddRange(new object[] {
            "Academy at Tolaria West",
            "Agyrem",
            "Akoum",
            "Aretopolis",
            "Astral Arena",
            "Bant",
            "Bloodhill Bastion",
            "Cliffside Market",
            "Edge of Malacol",
            "Eloren Wilds",
            "Feeding Grounds",
            "Fields of Summer",
            "Furnace Layer",
            "Gavony",
            "Glen Elendra",
            "Glimmervoid Bastin",
            "Goldmeadow",
            "Grand Ossuary",
            "Grixis",
            "Grove of the Dreampods",
            "Hedron Fields of Agadeem",
            "Immersturm",
            "Isle of Vesuva",
            "Izzet Steam Maze",
            "Jund",
            "Kessig",
            "Kharasha Foothills",
            "Kilinspire District",
            "Krosa",
            "Lair of the Ashen Idol",
            "Lethe Lake",
            "Llanowar",
            "Minamo",
            "Mount Keralia",
            "Murasa",
            "Naar Isle",
            "Naya",
            "Nephalia",
            "Norn\'s Dominion",
            "Onakke Catacomb",
            "Orochi Colony",
            "Orzhava",
            "Otaria",
            "Panopticon",
            "Pools of Becoming",
            "Pravh",
            "Quicksilver Sea",
            "Raven´s Run",
            "Sanctum of Serra",
            "Sea of Sand",
            "Selesnya Loft Gardens",
            "Shiv",
            "Skybreen",
            "Sokenzan",
            "Stairs to Infinity",
            "Stensia",
            "Stronghold Furnance",
            "Takenuma",
            "Talon Gates",
            "Tazeem",
            "The AEther Flues",
            "The Dark Barony",
            "The Eon Fog",
            "The Fourth Sphere",
            "The Great Forest",
            "The Hippodrome",
            "The Maelstrom",
            "The Zephyr Maze",
            "Trail of the Mage-Rings",
            "Truga Jungle",
            "Turri Island",
            "Velis Vel",
            "Windriddle Palaces",
            "Undercity Reaches ",
            "Chaotic AEther",
            "Interplanar Tunnel",
            "Morphic Tide",
            "Mutual Epiphany",
            "Planewide Disaster",
            "Reality Shaping",
            "Spatial Merging",
            "Time Distortion"});
            this.lista_planos.Location = new System.Drawing.Point(16, 24);
            this.lista_planos.Name = "lista_planos";
            this.lista_planos.Size = new System.Drawing.Size(213, 24);
            this.lista_planos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(656, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Viajar_destino);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pic_plano);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_plano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_plano;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Viajar_destino;
        private System.Windows.Forms.Button btn_Viajar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox lista_planos;
    }
}

