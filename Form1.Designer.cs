﻿namespace Universal_Launcher {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mpSidePanel = new MetroFramework.Controls.MetroPanel();
            this.mpBottomSideBarPanell = new MetroFramework.Controls.MetroPanel();
            this.ibSettings = new FontAwesome.Sharp.IconButton();
            this.ibDarkMode = new FontAwesome.Sharp.IconButton();
            this.mpNotesNReminders = new MetroFramework.Controls.MetroPanel();
            this.mpReminders = new MetroFramework.Controls.MetroPanel();
            this.mpPinnedNote = new MetroFramework.Controls.MetroPanel();
            this.mpRecentlyUsed = new MetroFramework.Controls.MetroPanel();
            this.mpAccount = new MetroFramework.Controls.MetroPanel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.ipbUserPicture = new FontAwesome.Sharp.IconPictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Home = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.lvReminders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnRemoveNotes = new System.Windows.Forms.Button();
            this.lbNotes = new System.Windows.Forms.ListBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.panelFavorites = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tpTestChildren = new MetroFramework.Controls.MetroTabPage();
            this.flpLibrary = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddFlow = new MetroFramework.Controls.MetroButton();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.mpSidePanel.SuspendLayout();
            this.mpBottomSideBarPanell.SuspendLayout();
            this.mpNotesNReminders.SuspendLayout();
            this.mpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbUserPicture)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFavorites.SuspendLayout();
            this.tpTestChildren.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpSidePanel
            // 
            this.mpSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mpSidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpSidePanel.Controls.Add(this.mpBottomSideBarPanell);
            this.mpSidePanel.Controls.Add(this.mpNotesNReminders);
            this.mpSidePanel.Controls.Add(this.mpAccount);
            this.mpSidePanel.HorizontalScrollbarBarColor = false;
            this.mpSidePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mpSidePanel.HorizontalScrollbarSize = 10;
            this.mpSidePanel.Location = new System.Drawing.Point(0, 5);
            this.mpSidePanel.Name = "mpSidePanel";
            this.mpSidePanel.Size = new System.Drawing.Size(213, 500);
            this.mpSidePanel.Style = MetroFramework.MetroColorStyle.Black;
            this.mpSidePanel.TabIndex = 0;
            this.mpSidePanel.VerticalScrollbarBarColor = true;
            this.mpSidePanel.VerticalScrollbarHighlightOnWheel = false;
            this.mpSidePanel.VerticalScrollbarSize = 10;
            // 
            // mpBottomSideBarPanell
            // 
            this.mpBottomSideBarPanell.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mpBottomSideBarPanell.Controls.Add(this.ibSettings);
            this.mpBottomSideBarPanell.Controls.Add(this.ibDarkMode);
            this.mpBottomSideBarPanell.HorizontalScrollbarBarColor = false;
            this.mpBottomSideBarPanell.HorizontalScrollbarHighlightOnWheel = false;
            this.mpBottomSideBarPanell.HorizontalScrollbarSize = 10;
            this.mpBottomSideBarPanell.Location = new System.Drawing.Point(0, 465);
            this.mpBottomSideBarPanell.Name = "mpBottomSideBarPanell";
            this.mpBottomSideBarPanell.Size = new System.Drawing.Size(212, 34);
            this.mpBottomSideBarPanell.TabIndex = 8;
            this.mpBottomSideBarPanell.VerticalScrollbarBarColor = true;
            this.mpBottomSideBarPanell.VerticalScrollbarHighlightOnWheel = false;
            this.mpBottomSideBarPanell.VerticalScrollbarSize = 10;
            // 
            // ibSettings
            // 
            this.ibSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibSettings.FlatAppearance.BorderSize = 0;
            this.ibSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.ibSettings.IconColor = System.Drawing.Color.Black;
            this.ibSettings.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibSettings.IconSize = 30;
            this.ibSettings.Location = new System.Drawing.Point(180, 6);
            this.ibSettings.Name = "ibSettings";
            this.ibSettings.Size = new System.Drawing.Size(32, 28);
            this.ibSettings.TabIndex = 6;
            this.ibSettings.UseVisualStyleBackColor = true;
            // 
            // ibDarkMode
            // 
            this.ibDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibDarkMode.FlatAppearance.BorderSize = 0;
            this.ibDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDarkMode.IconChar = FontAwesome.Sharp.IconChar.Moon;
            this.ibDarkMode.IconColor = System.Drawing.Color.Black;
            this.ibDarkMode.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibDarkMode.IconSize = 25;
            this.ibDarkMode.Location = new System.Drawing.Point(1, 6);
            this.ibDarkMode.Name = "ibDarkMode";
            this.ibDarkMode.Size = new System.Drawing.Size(32, 28);
            this.ibDarkMode.TabIndex = 7;
            this.ibDarkMode.UseVisualStyleBackColor = true;
            // 
            // mpNotesNReminders
            // 
            this.mpNotesNReminders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mpNotesNReminders.AutoScroll = true;
            this.mpNotesNReminders.Controls.Add(this.mpReminders);
            this.mpNotesNReminders.Controls.Add(this.mpPinnedNote);
            this.mpNotesNReminders.Controls.Add(this.mpRecentlyUsed);
            this.mpNotesNReminders.HorizontalScrollbar = true;
            this.mpNotesNReminders.HorizontalScrollbarBarColor = true;
            this.mpNotesNReminders.HorizontalScrollbarHighlightOnWheel = false;
            this.mpNotesNReminders.HorizontalScrollbarSize = 10;
            this.mpNotesNReminders.Location = new System.Drawing.Point(0, 67);
            this.mpNotesNReminders.Name = "mpNotesNReminders";
            this.mpNotesNReminders.Size = new System.Drawing.Size(212, 356);
            this.mpNotesNReminders.TabIndex = 9;
            this.mpNotesNReminders.VerticalScrollbar = true;
            this.mpNotesNReminders.VerticalScrollbarBarColor = true;
            this.mpNotesNReminders.VerticalScrollbarHighlightOnWheel = false;
            this.mpNotesNReminders.VerticalScrollbarSize = 10;
            // 
            // mpReminders
            // 
            this.mpReminders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mpReminders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mpReminders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpReminders.HorizontalScrollbarBarColor = true;
            this.mpReminders.HorizontalScrollbarHighlightOnWheel = false;
            this.mpReminders.HorizontalScrollbarSize = 10;
            this.mpReminders.Location = new System.Drawing.Point(0, 197);
            this.mpReminders.Name = "mpReminders";
            this.mpReminders.Size = new System.Drawing.Size(212, 77);
            this.mpReminders.TabIndex = 3;
            this.mpReminders.VerticalScrollbarBarColor = true;
            this.mpReminders.VerticalScrollbarHighlightOnWheel = false;
            this.mpReminders.VerticalScrollbarSize = 10;
            // 
            // mpPinnedNote
            // 
            this.mpPinnedNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mpPinnedNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mpPinnedNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpPinnedNote.HorizontalScrollbarBarColor = true;
            this.mpPinnedNote.HorizontalScrollbarHighlightOnWheel = false;
            this.mpPinnedNote.HorizontalScrollbarSize = 10;
            this.mpPinnedNote.Location = new System.Drawing.Point(0, 89);
            this.mpPinnedNote.Name = "mpPinnedNote";
            this.mpPinnedNote.Size = new System.Drawing.Size(212, 109);
            this.mpPinnedNote.TabIndex = 2;
            this.mpPinnedNote.VerticalScrollbarBarColor = true;
            this.mpPinnedNote.VerticalScrollbarHighlightOnWheel = false;
            this.mpPinnedNote.VerticalScrollbarSize = 10;
            // 
            // mpRecentlyUsed
            // 
            this.mpRecentlyUsed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mpRecentlyUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpRecentlyUsed.HorizontalScrollbarBarColor = true;
            this.mpRecentlyUsed.HorizontalScrollbarHighlightOnWheel = false;
            this.mpRecentlyUsed.HorizontalScrollbarSize = 10;
            this.mpRecentlyUsed.Location = new System.Drawing.Point(0, 0);
            this.mpRecentlyUsed.Name = "mpRecentlyUsed";
            this.mpRecentlyUsed.Size = new System.Drawing.Size(212, 89);
            this.mpRecentlyUsed.TabIndex = 1;
            this.mpRecentlyUsed.VerticalScrollbarBarColor = true;
            this.mpRecentlyUsed.VerticalScrollbarHighlightOnWheel = false;
            this.mpRecentlyUsed.VerticalScrollbarSize = 10;
            // 
            // mpAccount
            // 
            this.mpAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpAccount.Controls.Add(this.metroTextBox1);
            this.mpAccount.Controls.Add(this.ipbUserPicture);
            this.mpAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.mpAccount.HorizontalScrollbarBarColor = true;
            this.mpAccount.HorizontalScrollbarHighlightOnWheel = false;
            this.mpAccount.HorizontalScrollbarSize = 10;
            this.mpAccount.Location = new System.Drawing.Point(0, 0);
            this.mpAccount.Name = "mpAccount";
            this.mpAccount.Size = new System.Drawing.Size(211, 67);
            this.mpAccount.TabIndex = 2;
            this.mpAccount.VerticalScrollbarBarColor = true;
            this.mpAccount.VerticalScrollbarHighlightOnWheel = false;
            this.mpAccount.VerticalScrollbarSize = 10;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Enabled = false;
            this.metroTextBox1.CustomButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroTextBox1.CustomButton.FlatAppearance.BorderSize = 0;
            this.metroTextBox1.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Enabled = false;
            this.metroTextBox1.Lines = new string[] {
        "Username"};
            this.metroTextBox1.Location = new System.Drawing.Point(58, 3);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(103, 23);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Text = "Username";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ipbUserPicture
            // 
            this.ipbUserPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ipbUserPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ipbUserPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.ipbUserPicture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbUserPicture.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ipbUserPicture.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbUserPicture.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ipbUserPicture.IconSize = 52;
            this.ipbUserPicture.Location = new System.Drawing.Point(0, 0);
            this.ipbUserPicture.Name = "ipbUserPicture";
            this.ipbUserPicture.Size = new System.Drawing.Size(52, 65);
            this.ipbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ipbUserPicture.TabIndex = 2;
            this.ipbUserPicture.TabStop = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.Home);
            this.metroTabControl1.Controls.Add(this.tpTestChildren);
            this.metroTabControl1.Location = new System.Drawing.Point(218, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(787, 418);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.metroLabel1);
            this.Home.Controls.Add(this.metroLabel3);
            this.Home.Controls.Add(this.metroLabel2);
            this.Home.Controls.Add(this.panel3);
            this.Home.Controls.Add(this.panel2);
            this.Home.Controls.Add(this.panelFavorites);
            this.Home.HorizontalScrollbarBarColor = true;
            this.Home.HorizontalScrollbarHighlightOnWheel = false;
            this.Home.HorizontalScrollbarSize = 10;
            this.Home.Location = new System.Drawing.Point(4, 38);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(779, 376);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.VerticalScrollbarBarColor = true;
            this.Home.VerticalScrollbarHighlightOnWheel = false;
            this.Home.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Favorites";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(408, 176);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Reminders";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(408, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Notes";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnAddReminder);
            this.panel3.Controls.Add(this.lvReminders);
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.panel3.Location = new System.Drawing.Point(408, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 175);
            this.panel3.TabIndex = 4;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddReminder.Location = new System.Drawing.Point(247, 149);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(104, 23);
            this.btnAddReminder.TabIndex = 4;
            this.btnAddReminder.Text = "Add";
            this.btnAddReminder.UseVisualStyleBackColor = true;
            // 
            // lvReminders
            // 
            this.lvReminders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvReminders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvReminders.HideSelection = false;
            this.lvReminders.Location = new System.Drawing.Point(20, 16);
            this.lvReminders.Name = "lvReminders";
            this.lvReminders.Size = new System.Drawing.Size(331, 131);
            this.lvReminders.TabIndex = 0;
            this.lvReminders.UseCompatibleStateImageBehavior = false;
            this.lvReminders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Check";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Task";
            this.columnHeader2.Width = 213;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.Width = 81;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnAddNote);
            this.panel2.Controls.Add(this.btnRemoveNotes);
            this.panel2.Controls.Add(this.lbNotes);
            this.panel2.Controls.Add(this.rtbNotes);
            this.panel2.Location = new System.Drawing.Point(408, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 150);
            this.panel2.TabIndex = 3;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNote.Location = new System.Drawing.Point(137, 124);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(104, 23);
            this.btnAddNote.TabIndex = 3;
            this.btnAddNote.Text = "Add";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnRemoveNotes
            // 
            this.btnRemoveNotes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemoveNotes.Location = new System.Drawing.Point(247, 124);
            this.btnRemoveNotes.Name = "btnRemoveNotes";
            this.btnRemoveNotes.Size = new System.Drawing.Size(104, 23);
            this.btnRemoveNotes.TabIndex = 2;
            this.btnRemoveNotes.Text = "Remove";
            this.btnRemoveNotes.UseVisualStyleBackColor = true;
            this.btnRemoveNotes.Click += new System.EventHandler(this.btnRemoveNotes_Click);
            // 
            // lbNotes
            // 
            this.lbNotes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNotes.FormattingEnabled = true;
            this.lbNotes.Location = new System.Drawing.Point(137, 23);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(214, 95);
            this.lbNotes.TabIndex = 1;
            this.lbNotes.SelectedIndexChanged += new System.EventHandler(this.lbNotes_SelectedIndexChanged);
            // 
            // rtbNotes
            // 
            this.rtbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNotes.Location = new System.Drawing.Point(20, 23);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(99, 104);
            this.rtbNotes.TabIndex = 0;
            this.rtbNotes.Text = "";
            this.rtbNotes.TextChanged += new System.EventHandler(this.rtbNotes_TextChanged);
            // 
            // panelFavorites
            // 
            this.panelFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelFavorites.Controls.Add(this.listView1);
            this.panelFavorites.Location = new System.Drawing.Point(3, 23);
            this.panelFavorites.Name = "panelFavorites";
            this.panelFavorites.Size = new System.Drawing.Size(390, 350);
            this.panelFavorites.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(349, 301);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tpTestChildren
            // 
            this.tpTestChildren.Controls.Add(this.flpLibrary);
            this.tpTestChildren.HorizontalScrollbarBarColor = true;
            this.tpTestChildren.HorizontalScrollbarHighlightOnWheel = false;
            this.tpTestChildren.HorizontalScrollbarSize = 10;
            this.tpTestChildren.Location = new System.Drawing.Point(4, 38);
            this.tpTestChildren.Name = "tpTestChildren";
            this.tpTestChildren.Size = new System.Drawing.Size(779, 376);
            this.tpTestChildren.TabIndex = 1;
            this.tpTestChildren.Text = "Library";
            this.tpTestChildren.VerticalScrollbarBarColor = true;
            this.tpTestChildren.VerticalScrollbarHighlightOnWheel = false;
            this.tpTestChildren.VerticalScrollbarSize = 10;
            // 
            // flpLibrary
            // 
            this.flpLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpLibrary.AutoScroll = true;
            this.flpLibrary.Location = new System.Drawing.Point(0, 0);
            this.flpLibrary.Name = "flpLibrary";
            this.flpLibrary.Size = new System.Drawing.Size(779, 376);
            this.flpLibrary.TabIndex = 4;
            // 
            // btnAddFlow
            // 
            this.btnAddFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFlow.Location = new System.Drawing.Point(822, 34);
            this.btnAddFlow.Name = "btnAddFlow";
            this.btnAddFlow.Size = new System.Drawing.Size(75, 23);
            this.btnAddFlow.TabIndex = 1;
            this.btnAddFlow.Text = "add";
            this.btnAddFlow.UseSelectable = true;
            this.btnAddFlow.Click += new System.EventHandler(this.btnAddFlow_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(928, 34);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "remove";
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 504);
            this.Controls.Add(this.mpSidePanel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddFlow);
            this.Controls.Add(this.metroTabControl1);
            this.MinimumSize = new System.Drawing.Size(1036, 504);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mpSidePanel.ResumeLayout(false);
            this.mpBottomSideBarPanell.ResumeLayout(false);
            this.mpNotesNReminders.ResumeLayout(false);
            this.mpAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbUserPicture)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelFavorites.ResumeLayout(false);
            this.tpTestChildren.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpSidePanel;
        private MetroFramework.Controls.MetroPanel mpAccount;
        private FontAwesome.Sharp.IconPictureBox ipbUserPicture;
        private MetroFramework.Controls.MetroPanel mpPinnedNote;
        private MetroFramework.Controls.MetroPanel mpReminders;
        private MetroFramework.Controls.MetroPanel mpRecentlyUsed;
        private FontAwesome.Sharp.IconButton ibSettings;
        private FontAwesome.Sharp.IconButton ibDarkMode;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroPanel mpBottomSideBarPanell;
        private MetroFramework.Controls.MetroPanel mpNotesNReminders;

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Home;
        private System.Windows.Forms.Panel panelFavorites;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Button btnRemoveNotes;
        private System.Windows.Forms.ListBox lbNotes;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.ListView lvReminders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView1;

        private MetroFramework.Controls.MetroTabPage tpTestChildren;
        private MetroFramework.Controls.MetroButton btnAddFlow;
        private MetroFramework.Controls.MetroButton btnRemove;
        private System.Windows.Forms.FlowLayoutPanel flpLibrary;
    }
}

