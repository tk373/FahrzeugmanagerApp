
namespace FahrezeugManagerProject
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitelMainPAge = new System.Windows.Forms.Label();
            this.listViewCars = new System.Windows.Forms.ListView();
            this.newButtons = new System.Windows.Forms.Button();
            this.listViewCustomers = new System.Windows.Forms.ListView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitelMainPAge
            // 
            this.TitelMainPAge.AutoSize = true;
            this.TitelMainPAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitelMainPAge.Location = new System.Drawing.Point(12, 9);
            this.TitelMainPAge.Name = "TitelMainPAge";
            this.TitelMainPAge.Size = new System.Drawing.Size(280, 37);
            this.TitelMainPAge.TabIndex = 0;
            this.TitelMainPAge.Text = "Fahrzeugmanager";
            this.TitelMainPAge.Click += new System.EventHandler(this.label1_Click);
            // 
            // listViewCars
            // 
            this.listViewCars.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewCars.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewCars.GridLines = true;
            this.listViewCars.HideSelection = false;
            this.listViewCars.Location = new System.Drawing.Point(28, 73);
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(138, 506);
            this.listViewCars.TabIndex = 1;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            this.listViewCars.SelectedIndexChanged += new System.EventHandler(this.listViewCars_SelectedIndexChanged);
            this.listViewCars.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewCars_MouseDoubleClick);
            // 
            // newButtons
            // 
            this.newButtons.BackColor = System.Drawing.SystemColors.Info;
            this.newButtons.Location = new System.Drawing.Point(240, 468);
            this.newButtons.Name = "newButtons";
            this.newButtons.Size = new System.Drawing.Size(89, 32);
            this.newButtons.TabIndex = 2;
            this.newButtons.Text = "New Employee";
            this.newButtons.UseVisualStyleBackColor = false;
            this.newButtons.Click += new System.EventHandler(this.newButtons_Click);
            // 
            // listViewCustomers
            // 
            this.listViewCustomers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewCustomers.HideSelection = false;
            this.listViewCustomers.Location = new System.Drawing.Point(552, 73);
            this.listViewCustomers.Name = "listViewCustomers";
            this.listViewCustomers.Size = new System.Drawing.Size(148, 506);
            this.listViewCustomers.TabIndex = 3;
            this.listViewCustomers.UseCompatibleStateImageBehavior = false;
            this.listViewCustomers.SelectedIndexChanged += new System.EventHandler(this.listViewCustomers_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.Info;
            this.deleteButton.Location = new System.Drawing.Point(301, 387);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 32);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(772, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(361, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "New Vehicle ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(772, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.listViewCustomers);
            this.Controls.Add(this.newButtons);
            this.Controls.Add(this.listViewCars);
            this.Controls.Add(this.TitelMainPAge);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(788, 645);
            this.Name = "Form1";
            this.Text = "Fahrzeugmanager";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitelMainPAge;
        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.Button newButtons;
        private System.Windows.Forms.ListView listViewCustomers;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button button1;
    }
}

