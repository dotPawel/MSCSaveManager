namespace MSCSaveManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PathText = new System.Windows.Forms.Label();
            this.slotsTree = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.loadslotButton = new System.Windows.Forms.Button();
            this.selectedslotText = new System.Windows.Forms.Label();
            this.saveslotButton = new System.Windows.Forms.Button();
            this.slotnameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.refreshtreeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.deleteslotButton = new System.Windows.Forms.Button();
            this.openslotButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSC Save Manager // dotPaweł // https://github.com/dotPawel // Not associated wit" +
    "h Amistech";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSC Save Manager";
            // 
            // PathText
            // 
            this.PathText.AutoSize = true;
            this.PathText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathText.Location = new System.Drawing.Point(12, 63);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(48, 19);
            this.PathText.TabIndex = 2;
            this.PathText.Text = "Path : ";
            // 
            // slotsTree
            // 
            this.slotsTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.slotsTree.ForeColor = System.Drawing.SystemColors.Control;
            this.slotsTree.Location = new System.Drawing.Point(12, 109);
            this.slotsTree.Name = "slotsTree";
            this.slotsTree.Size = new System.Drawing.Size(183, 352);
            this.slotsTree.TabIndex = 3;
            this.slotsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.slotsTree_AfterSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your save slots";
            // 
            // loadslotButton
            // 
            this.loadslotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadslotButton.Location = new System.Drawing.Point(201, 152);
            this.loadslotButton.Name = "loadslotButton";
            this.loadslotButton.Size = new System.Drawing.Size(287, 68);
            this.loadslotButton.TabIndex = 5;
            this.loadslotButton.Text = "Load selected save";
            this.loadslotButton.UseVisualStyleBackColor = true;
            this.loadslotButton.Click += new System.EventHandler(this.loadslotButton_Click);
            // 
            // selectedslotText
            // 
            this.selectedslotText.AutoSize = true;
            this.selectedslotText.Location = new System.Drawing.Point(201, 134);
            this.selectedslotText.Name = "selectedslotText";
            this.selectedslotText.Size = new System.Drawing.Size(82, 15);
            this.selectedslotText.TabIndex = 6;
            this.selectedslotText.Text = "Selected slot : ";
            // 
            // saveslotButton
            // 
            this.saveslotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveslotButton.Location = new System.Drawing.Point(201, 307);
            this.saveslotButton.Name = "saveslotButton";
            this.saveslotButton.Size = new System.Drawing.Size(287, 68);
            this.saveslotButton.TabIndex = 7;
            this.saveslotButton.Text = "Save current as slot";
            this.saveslotButton.UseVisualStyleBackColor = true;
            this.saveslotButton.Click += new System.EventHandler(this.saveslotButton_Click);
            // 
            // slotnameBox
            // 
            this.slotnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.slotnameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slotnameBox.ForeColor = System.Drawing.SystemColors.Control;
            this.slotnameBox.Location = new System.Drawing.Point(201, 278);
            this.slotnameBox.Name = "slotnameBox";
            this.slotnameBox.Size = new System.Drawing.Size(287, 23);
            this.slotnameBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Slot name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(201, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Loading saves";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(201, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Backing-up saves";
            // 
            // refreshtreeLinkLabel
            // 
            this.refreshtreeLinkLabel.ActiveLinkColor = System.Drawing.Color.Green;
            this.refreshtreeLinkLabel.AutoSize = true;
            this.refreshtreeLinkLabel.LinkColor = System.Drawing.Color.White;
            this.refreshtreeLinkLabel.Location = new System.Drawing.Point(402, 404);
            this.refreshtreeLinkLabel.Name = "refreshtreeLinkLabel";
            this.refreshtreeLinkLabel.Size = new System.Drawing.Size(86, 15);
            this.refreshtreeLinkLabel.TabIndex = 12;
            this.refreshtreeLinkLabel.TabStop = true;
            this.refreshtreeLinkLabel.Text = "Refresh slot list";
            this.refreshtreeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshtreeLinkLabel_LinkClicked);
            // 
            // deleteslotButton
            // 
            this.deleteslotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteslotButton.Location = new System.Drawing.Point(201, 422);
            this.deleteslotButton.Name = "deleteslotButton";
            this.deleteslotButton.Size = new System.Drawing.Size(137, 39);
            this.deleteslotButton.TabIndex = 13;
            this.deleteslotButton.Text = "Delete selected slot";
            this.deleteslotButton.UseVisualStyleBackColor = true;
            this.deleteslotButton.Click += new System.EventHandler(this.deleteslotButton_Click);
            // 
            // openslotButton
            // 
            this.openslotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openslotButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openslotButton.Location = new System.Drawing.Point(356, 422);
            this.openslotButton.Name = "openslotButton";
            this.openslotButton.Size = new System.Drawing.Size(132, 39);
            this.openslotButton.TabIndex = 14;
            this.openslotButton.Text = "Open selected slot in explorer";
            this.openslotButton.UseVisualStyleBackColor = true;
            this.openslotButton.Click += new System.EventHandler(this.openslotButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(201, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Other";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(369, 19);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(116, 15);
            this.versionLabel.TabIndex = 16;
            this.versionLabel.Text = "version number here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(500, 485);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.openslotButton);
            this.Controls.Add(this.deleteslotButton);
            this.Controls.Add(this.refreshtreeLinkLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.slotnameBox);
            this.Controls.Add(this.saveslotButton);
            this.Controls.Add(this.selectedslotText);
            this.Controls.Add(this.loadslotButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.slotsTree);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MSC Save Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label PathText;
        private TreeView slotsTree;
        private Label label3;
        private Button loadslotButton;
        private Label selectedslotText;
        private Button saveslotButton;
        private TextBox slotnameBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private LinkLabel refreshtreeLinkLabel;
        private Button deleteslotButton;
        private Button openslotButton;
        private Label label7;
        private Label versionLabel;
    }
}