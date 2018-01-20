namespace AccesBases
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SQLServer = new System.Windows.Forms.RadioButton();
            this.MySql = new System.Windows.Forms.RadioButton();
            this.testCnx = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.SQLServer);
            this.groupBox1.Controls.Add(this.MySql);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix Du serveur";
            // 
            // SQLServer
            // 
            this.SQLServer.AutoSize = true;
            this.SQLServer.Location = new System.Drawing.Point(27, 44);
            this.SQLServer.Name = "SQLServer";
            this.SQLServer.Size = new System.Drawing.Size(80, 17);
            this.SQLServer.TabIndex = 1;
            this.SQLServer.TabStop = true;
            this.SQLServer.Text = "SQL Server";
            this.SQLServer.UseVisualStyleBackColor = true;
            this.SQLServer.Click += new System.EventHandler(this.changerBase);
            // 
            // MySql
            // 
            this.MySql.AutoSize = true;
            this.MySql.Location = new System.Drawing.Point(27, 19);
            this.MySql.Name = "MySql";
            this.MySql.Size = new System.Drawing.Size(63, 17);
            this.MySql.TabIndex = 0;
            this.MySql.TabStop = true;
            this.MySql.Text = "My SQL";
            this.MySql.UseVisualStyleBackColor = true;
            this.MySql.Click += new System.EventHandler(this.changerBase);
            // 
            // testCnx
            // 
            this.testCnx.Location = new System.Drawing.Point(155, 33);
            this.testCnx.Name = "testCnx";
            this.testCnx.Size = new System.Drawing.Size(124, 23);
            this.testCnx.TabIndex = 1;
            this.testCnx.Text = "Tester la connexion";
            this.testCnx.UseVisualStyleBackColor = true;
            this.testCnx.Click += new System.EventHandler(this.testCnx_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(39, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(375, 237);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAjouterClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(367, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ajouter Client";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(161, 144);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterClient.TabIndex = 0;
            this.btnAjouterClient.Text = "Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRafraichir);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.btnSupprimer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(367, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supprimer client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(135, 161);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 0;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 23);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(218, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Location = new System.Drawing.Point(189, 57);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(75, 23);
            this.btnRafraichir.TabIndex = 3;
            this.btnRafraichir.Text = "rafraichir";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 477);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.testCnx);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SQLServer;
        private System.Windows.Forms.RadioButton MySql;
        private System.Windows.Forms.Button testCnx;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRafraichir;
    }
}

