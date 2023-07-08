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
            this.components = new System.ComponentModel.Container();
            this.mpSidePanel = new MetroFramework.Controls.MetroPanel();
            this.mpBottomSideBarPanell = new MetroFramework.Controls.MetroPanel();
            this.ibDarkMode = new FontAwesome.Sharp.IconButton();
            this.mpNotesNReminders = new MetroFramework.Controls.MetroPanel();
            this.mpReminders = new MetroFramework.Controls.MetroPanel();
            this.lvSideBarReminders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mpRecentlyUsed = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblNoteTitleSideBar = new System.Windows.Forms.TextBox();
            this.rtbSideBarNoteText = new System.Windows.Forms.RichTextBox();
            this.mpAccount = new MetroFramework.Controls.MetroPanel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.ipbUserPicture = new FontAwesome.Sharp.IconPictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Home = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddReminder = new MetroFramework.Controls.MetroButton();
            this.lvReminders = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoveNote = new MetroFramework.Controls.MetroButton();
            this.btnAddNote = new MetroFramework.Controls.MetroButton();
            this.lbNotes = new System.Windows.Forms.ListBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.panelFavorites = new System.Windows.Forms.Panel();
            this.ibRemoveFavorite = new FontAwesome.Sharp.IconButton();
            this.lvFavorites = new System.Windows.Forms.ListView();
            this.imgListIcons = new System.Windows.Forms.ImageList(this.components);
            this.tpTestChildren = new MetroFramework.Controls.MetroTabPage();
            this.btnAddFlow = new MetroFramework.Controls.MetroButton();
            this.flpLibrary = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddRemeinder = new MetroFramework.Controls.MetroButton();
            this.btnRemoveNotes = new MetroFramework.Controls.MetroButton();
            this.ttTipDoubleClick = new System.Windows.Forms.ToolTip(this.components);
            this.msmForm1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mpLoginScreen = new MetroFramework.Controls.MetroPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbEnterUsername = new MetroFramework.Controls.MetroTextBox();
            this.mpSidePanel.SuspendLayout();
            this.mpBottomSideBarPanell.SuspendLayout();
            this.mpNotesNReminders.SuspendLayout();
            this.mpReminders.SuspendLayout();
            this.mpRecentlyUsed.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.mpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbUserPicture)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFavorites.SuspendLayout();
            this.tpTestChildren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmForm1)).BeginInit();
            this.mpLoginScreen.SuspendLayout();
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
            this.mpSidePanel.Size = new System.Drawing.Size(213, 516);
            this.mpSidePanel.Style = MetroFramework.MetroColorStyle.Black;
            this.mpSidePanel.TabIndex = 0;
            this.mpSidePanel.VerticalScrollbarBarColor = true;
            this.mpSidePanel.VerticalScrollbarHighlightOnWheel = false;
            this.mpSidePanel.VerticalScrollbarSize = 10;
            // 
            // mpBottomSideBarPanell
            // 
            this.mpBottomSideBarPanell.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mpBottomSideBarPanell.Controls.Add(this.ibDarkMode);
            this.mpBottomSideBarPanell.HorizontalScrollbarBarColor = false;
            this.mpBottomSideBarPanell.HorizontalScrollbarHighlightOnWheel = false;
            this.mpBottomSideBarPanell.HorizontalScrollbarSize = 10;
            this.mpBottomSideBarPanell.Location = new System.Drawing.Point(0, 481);
            this.mpBottomSideBarPanell.Name = "mpBottomSideBarPanell";
            this.mpBottomSideBarPanell.Size = new System.Drawing.Size(212, 34);
            this.mpBottomSideBarPanell.TabIndex = 8;
            this.mpBottomSideBarPanell.VerticalScrollbarBarColor = true;
            this.mpBottomSideBarPanell.VerticalScrollbarHighlightOnWheel = false;
            this.mpBottomSideBarPanell.VerticalScrollbarSize = 10;
            // 
            // ibDarkMode
            // 
            this.ibDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibDarkMode.FlatAppearance.BorderSize = 0;
            this.ibDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDarkMode.IconChar = FontAwesome.Sharp.IconChar.Moon;
            this.ibDarkMode.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(150)))), ((int)(((byte)(14)))));
            this.ibDarkMode.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibDarkMode.IconSize = 25;
            this.ibDarkMode.Location = new System.Drawing.Point(1, 0);
            this.ibDarkMode.Name = "ibDarkMode";
            this.ibDarkMode.Size = new System.Drawing.Size(32, 34);
            this.ibDarkMode.TabIndex = 7;
            this.ibDarkMode.UseVisualStyleBackColor = true;
            this.ibDarkMode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ibDarkMode_MouseClick);
            // 
            // mpNotesNReminders
            // 
            this.mpNotesNReminders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mpNotesNReminders.AutoScroll = true;
            this.mpNotesNReminders.Controls.Add(this.mpReminders);
            this.mpNotesNReminders.Controls.Add(this.mpRecentlyUsed);
            this.mpNotesNReminders.HorizontalScrollbar = true;
            this.mpNotesNReminders.HorizontalScrollbarBarColor = true;
            this.mpNotesNReminders.HorizontalScrollbarHighlightOnWheel = false;
            this.mpNotesNReminders.HorizontalScrollbarSize = 10;
            this.mpNotesNReminders.Location = new System.Drawing.Point(0, 67);
            this.mpNotesNReminders.Name = "mpNotesNReminders";
            this.mpNotesNReminders.Size = new System.Drawing.Size(212, 412);
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
            this.mpReminders.Controls.Add(this.lvSideBarReminders);
            this.mpReminders.HorizontalScrollbarBarColor = true;
            this.mpReminders.HorizontalScrollbarHighlightOnWheel = false;
            this.mpReminders.HorizontalScrollbarSize = 10;
            this.mpReminders.Location = new System.Drawing.Point(0, 280);
            this.mpReminders.Name = "mpReminders";
            this.mpReminders.Size = new System.Drawing.Size(212, 132);
            this.mpReminders.TabIndex = 3;
            this.mpReminders.VerticalScrollbarBarColor = true;
            this.mpReminders.VerticalScrollbarHighlightOnWheel = false;
            this.mpReminders.VerticalScrollbarSize = 10;
            // 
            // lvSideBarReminders
            // 
            this.lvSideBarReminders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvSideBarReminders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSideBarReminders.CheckBoxes = true;
            this.lvSideBarReminders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.lvSideBarReminders.HideSelection = false;
            this.lvSideBarReminders.Location = new System.Drawing.Point(-2, -1);
            this.lvSideBarReminders.Name = "lvSideBarReminders";
            this.lvSideBarReminders.Size = new System.Drawing.Size(213, 132);
            this.lvSideBarReminders.TabIndex = 6;
            this.lvSideBarReminders.UseCompatibleStateImageBehavior = false;
            this.lvSideBarReminders.View = System.Windows.Forms.View.Details;
            this.lvSideBarReminders.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvSideBarReminders_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Task";
            this.columnHeader1.Width = 141;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time";
            this.columnHeader4.Width = 68;
            // 
            // mpRecentlyUsed
            // 
            this.mpRecentlyUsed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mpRecentlyUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpRecentlyUsed.Controls.Add(this.metroPanel1);
            this.mpRecentlyUsed.HorizontalScrollbarBarColor = true;
            this.mpRecentlyUsed.HorizontalScrollbarHighlightOnWheel = false;
            this.mpRecentlyUsed.HorizontalScrollbarSize = 10;
            this.mpRecentlyUsed.Location = new System.Drawing.Point(0, 0);
            this.mpRecentlyUsed.Name = "mpRecentlyUsed";
            this.mpRecentlyUsed.Size = new System.Drawing.Size(212, 282);
            this.mpRecentlyUsed.TabIndex = 1;
            this.mpRecentlyUsed.VerticalScrollbarBarColor = true;
            this.mpRecentlyUsed.VerticalScrollbarHighlightOnWheel = false;
            this.mpRecentlyUsed.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.lblNoteTitleSideBar);
            this.metroPanel1.Controls.Add(this.rtbSideBarNoteText);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-1, 166);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(213, 115);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblNoteTitleSideBar
            // 
            this.lblNoteTitleSideBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNoteTitleSideBar.Enabled = false;
            this.lblNoteTitleSideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteTitleSideBar.Location = new System.Drawing.Point(-2, 2);
            this.lblNoteTitleSideBar.Name = "lblNoteTitleSideBar";
            this.lblNoteTitleSideBar.Size = new System.Drawing.Size(213, 19);
            this.lblNoteTitleSideBar.TabIndex = 4;
            this.lblNoteTitleSideBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbSideBarNoteText
            // 
            this.rtbSideBarNoteText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSideBarNoteText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbSideBarNoteText.Enabled = false;
            this.rtbSideBarNoteText.Location = new System.Drawing.Point(-2, 19);
            this.rtbSideBarNoteText.Name = "rtbSideBarNoteText";
            this.rtbSideBarNoteText.Size = new System.Drawing.Size(213, 104);
            this.rtbSideBarNoteText.TabIndex = 3;
            this.rtbSideBarNoteText.Text = "";
            // 
            // mpAccount
            // 
            this.mpAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpAccount.Controls.Add(this.lblCurrentUser);
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
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(58, 25);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentUser.TabIndex = 3;
            this.lblCurrentUser.Text = "label7";
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
            this.metroTabControl1.Location = new System.Drawing.Point(218, 37);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(943, 460);
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
            this.Home.Size = new System.Drawing.Size(935, 418);
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
            this.panel3.Size = new System.Drawing.Size(522, 175);
            this.panel3.TabIndex = 4;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddReminder.Location = new System.Drawing.Point(408, 147);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(104, 23);
            this.btnAddReminder.TabIndex = 7;
            this.btnAddReminder.Text = "Add";
            this.btnAddReminder.UseSelectable = true;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // lvReminders
            // 
            this.lvReminders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvReminders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvReminders.CheckBoxes = true;
            this.lvReminders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lvReminders.HideSelection = false;
            this.lvReminders.Location = new System.Drawing.Point(13, 12);
            this.lvReminders.Name = "lvReminders";
            this.lvReminders.Size = new System.Drawing.Size(499, 131);
            this.lvReminders.TabIndex = 5;
            this.lvReminders.UseCompatibleStateImageBehavior = false;
            this.lvReminders.View = System.Windows.Forms.View.Details;
            this.lvReminders.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvReminders_ItemChecked);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Task";
            this.columnHeader2.Width = 414;
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
            this.panel2.Controls.Add(this.btnRemoveNote);
            this.panel2.Controls.Add(this.btnAddNote);
            this.panel2.Controls.Add(this.lbNotes);
            this.panel2.Controls.Add(this.rtbNotes);
            this.panel2.Location = new System.Drawing.Point(408, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 150);
            this.panel2.TabIndex = 3;
            // 
            // btnRemoveNote
            // 
            this.btnRemoveNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemoveNote.Location = new System.Drawing.Point(401, 123);
            this.btnRemoveNote.Name = "btnRemoveNote";
            this.btnRemoveNote.Size = new System.Drawing.Size(104, 23);
            this.btnRemoveNote.TabIndex = 6;
            this.btnRemoveNote.Text = "Remove";
            this.btnRemoveNote.UseSelectable = true;
            this.btnRemoveNote.Click += new System.EventHandler(this.btnRemoveNotes_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNote.Location = new System.Drawing.Point(291, 123);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(104, 23);
            this.btnAddNote.TabIndex = 5;
            this.btnAddNote.Text = "Add";
            this.btnAddNote.UseSelectable = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // lbNotes
            // 
            this.lbNotes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNotes.FormattingEnabled = true;
            this.lbNotes.Location = new System.Drawing.Point(291, 23);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(214, 91);
            this.lbNotes.TabIndex = 4;
            this.lbNotes.SelectedIndexChanged += new System.EventHandler(this.lbNotes_SelectedIndexChanged);
            this.lbNotes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbNotes_MouseDoubleClick);
            this.lbNotes.MouseHover += new System.EventHandler(this.lbNotes_MouseHover);
            // 
            // rtbNotes
            // 
            this.rtbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNotes.Location = new System.Drawing.Point(20, 23);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(265, 95);
            this.rtbNotes.TabIndex = 0;
            this.rtbNotes.Text = "";
            this.rtbNotes.TextChanged += new System.EventHandler(this.rtbNotes_TextChanged);
            // 
            // panelFavorites
            // 
            this.panelFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelFavorites.Controls.Add(this.ibRemoveFavorite);
            this.panelFavorites.Controls.Add(this.lvFavorites);
            this.panelFavorites.Location = new System.Drawing.Point(3, 23);
            this.panelFavorites.Name = "panelFavorites";
            this.panelFavorites.Size = new System.Drawing.Size(390, 350);
            this.panelFavorites.TabIndex = 2;
            // 
            // ibRemoveFavorite
            // 
            this.ibRemoveFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibRemoveFavorite.BackColor = System.Drawing.Color.Transparent;
            this.ibRemoveFavorite.FlatAppearance.BorderSize = 0;
            this.ibRemoveFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibRemoveFavorite.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.ibRemoveFavorite.IconColor = System.Drawing.Color.Black;
            this.ibRemoveFavorite.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibRemoveFavorite.IconSize = 25;
            this.ibRemoveFavorite.Location = new System.Drawing.Point(365, 0);
            this.ibRemoveFavorite.Name = "ibRemoveFavorite";
            this.ibRemoveFavorite.Size = new System.Drawing.Size(25, 23);
            this.ibRemoveFavorite.TabIndex = 8;
            this.ibRemoveFavorite.UseVisualStyleBackColor = false;
            this.ibRemoveFavorite.Click += new System.EventHandler(this.ibRemoveFavorite_Click);
            // 
            // lvFavorites
            // 
            this.lvFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvFavorites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvFavorites.HideSelection = false;
            this.lvFavorites.Location = new System.Drawing.Point(18, 23);
            this.lvFavorites.MultiSelect = false;
            this.lvFavorites.Name = "lvFavorites";
            this.lvFavorites.Size = new System.Drawing.Size(349, 301);
            this.lvFavorites.SmallImageList = this.imgListIcons;
            this.lvFavorites.TabIndex = 0;
            this.lvFavorites.UseCompatibleStateImageBehavior = false;
            this.lvFavorites.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFavorites_MouseDoubleClick);
            // 
            // imgListIcons
            // 
            this.imgListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListIcons.ImageSize = new System.Drawing.Size(32, 32);
            this.imgListIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tpTestChildren
            // 
            this.tpTestChildren.Controls.Add(this.btnAddFlow);
            this.tpTestChildren.Controls.Add(this.flpLibrary);
            this.tpTestChildren.HorizontalScrollbarBarColor = true;
            this.tpTestChildren.HorizontalScrollbarHighlightOnWheel = false;
            this.tpTestChildren.HorizontalScrollbarSize = 10;
            this.tpTestChildren.Location = new System.Drawing.Point(4, 38);
            this.tpTestChildren.Name = "tpTestChildren";
            this.tpTestChildren.Size = new System.Drawing.Size(935, 418);
            this.tpTestChildren.TabIndex = 1;
            this.tpTestChildren.Text = "Library";
            this.tpTestChildren.VerticalScrollbarBarColor = true;
            this.tpTestChildren.VerticalScrollbarHighlightOnWheel = false;
            this.tpTestChildren.VerticalScrollbarSize = 10;
            // 
            // btnAddFlow
            // 
            this.btnAddFlow.Location = new System.Drawing.Point(0, 3);
            this.btnAddFlow.Name = "btnAddFlow";
            this.btnAddFlow.Size = new System.Drawing.Size(75, 23);
            this.btnAddFlow.TabIndex = 1;
            this.btnAddFlow.Text = "Add";
            this.btnAddFlow.UseSelectable = true;
            this.btnAddFlow.Click += new System.EventHandler(this.btnAddFlow_Click);
            // 
            // flpLibrary
            // 
            this.flpLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpLibrary.AutoScroll = true;
            this.flpLibrary.Location = new System.Drawing.Point(0, 29);
            this.flpLibrary.Name = "flpLibrary";
            this.flpLibrary.Size = new System.Drawing.Size(935, 389);
            this.flpLibrary.TabIndex = 4;
            // 
            // btnAddRemeinder
            // 
            this.btnAddRemeinder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRemeinder.Location = new System.Drawing.Point(409, 147);
            this.btnAddRemeinder.Name = "btnAddRemeinder";
            this.btnAddRemeinder.Size = new System.Drawing.Size(104, 23);
            this.btnAddRemeinder.TabIndex = 6;
            this.btnAddRemeinder.Text = "Add";
            this.btnAddRemeinder.UseSelectable = true;
            this.btnAddRemeinder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // btnRemoveNotes
            // 
            this.btnRemoveNotes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemoveNotes.Location = new System.Drawing.Point(401, 123);
            this.btnRemoveNotes.Name = "btnRemoveNotes";
            this.btnRemoveNotes.Size = new System.Drawing.Size(104, 23);
            this.btnRemoveNotes.TabIndex = 6;
            this.btnRemoveNotes.Text = "Remove";
            this.btnRemoveNotes.UseSelectable = true;
            this.btnRemoveNotes.Click += new System.EventHandler(this.btnRemoveNotes_Click);
            // 
            // msmForm1
            // 
            this.msmForm1.Owner = this;
            // 
            // mpLoginScreen
            // 
            this.mpLoginScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpLoginScreen.Controls.Add(this.label6);
            this.mpLoginScreen.Controls.Add(this.label5);
            this.mpLoginScreen.Controls.Add(this.label4);
            this.mpLoginScreen.Controls.Add(this.label3);
            this.mpLoginScreen.Controls.Add(this.label2);
            this.mpLoginScreen.Controls.Add(this.label1);
            this.mpLoginScreen.Controls.Add(this.mtbEnterUsername);
            this.mpLoginScreen.HorizontalScrollbarBarColor = true;
            this.mpLoginScreen.HorizontalScrollbarHighlightOnWheel = false;
            this.mpLoginScreen.HorizontalScrollbarSize = 10;
            this.mpLoginScreen.Location = new System.Drawing.Point(1, 5);
            this.mpLoginScreen.Name = "mpLoginScreen";
            this.mpLoginScreen.Size = new System.Drawing.Size(1174, 516);
            this.mpLoginScreen.TabIndex = 10;
            this.mpLoginScreen.VerticalScrollbarBarColor = true;
            this.mpLoginScreen.VerticalScrollbarHighlightOnWheel = false;
            this.mpLoginScreen.VerticalScrollbarSize = 10;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1135, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "migriD";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1135, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "M-Jak";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1122, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nik0la23";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1108, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Powered By:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Login:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 69);
            this.label1.TabIndex = 8;
            this.label1.Text = "Universal Launcher";
            // 
            // mtbEnterUsername
            // 
            this.mtbEnterUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtbEnterUsername.CustomButton.Image = null;
            this.mtbEnterUsername.CustomButton.Location = new System.Drawing.Point(262, 2);
            this.mtbEnterUsername.CustomButton.Name = "";
            this.mtbEnterUsername.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtbEnterUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbEnterUsername.CustomButton.TabIndex = 1;
            this.mtbEnterUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbEnterUsername.CustomButton.UseSelectable = true;
            this.mtbEnterUsername.CustomButton.Visible = false;
            this.mtbEnterUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtbEnterUsername.Lines = new string[0];
            this.mtbEnterUsername.Location = new System.Drawing.Point(444, 228);
            this.mtbEnterUsername.MaxLength = 32767;
            this.mtbEnterUsername.Name = "mtbEnterUsername";
            this.mtbEnterUsername.PasswordChar = '\0';
            this.mtbEnterUsername.PromptText = "Enter username";
            this.mtbEnterUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbEnterUsername.SelectedText = "";
            this.mtbEnterUsername.SelectionLength = 0;
            this.mtbEnterUsername.SelectionStart = 0;
            this.mtbEnterUsername.ShortcutsEnabled = true;
            this.mtbEnterUsername.Size = new System.Drawing.Size(292, 32);
            this.mtbEnterUsername.TabIndex = 7;
            this.mtbEnterUsername.UseSelectable = true;
            this.mtbEnterUsername.WaterMark = "Enter username";
            this.mtbEnterUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbEnterUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbEnterUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbEnterUsername_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 520);
            this.Controls.Add(this.mpLoginScreen);
            this.Controls.Add(this.mpSidePanel);
            this.Controls.Add(this.metroTabControl1);
            this.MinimumSize = new System.Drawing.Size(1175, 520);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mpSidePanel.ResumeLayout(false);
            this.mpBottomSideBarPanell.ResumeLayout(false);
            this.mpNotesNReminders.ResumeLayout(false);
            this.mpReminders.ResumeLayout(false);
            this.mpRecentlyUsed.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.mpAccount.ResumeLayout(false);
            this.mpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbUserPicture)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelFavorites.ResumeLayout(false);
            this.tpTestChildren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msmForm1)).EndInit();
            this.mpLoginScreen.ResumeLayout(false);
            this.mpLoginScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpSidePanel;
        private MetroFramework.Controls.MetroPanel mpAccount;
        private FontAwesome.Sharp.IconPictureBox ipbUserPicture;
        private MetroFramework.Controls.MetroPanel mpReminders;
        private MetroFramework.Controls.MetroPanel mpRecentlyUsed;
        private FontAwesome.Sharp.IconButton ibDarkMode;
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

        private MetroFramework.Controls.MetroTabPage tpTestChildren;
        private MetroFramework.Controls.MetroButton btnAddFlow;
        private System.Windows.Forms.FlowLayoutPanel flpLibrary;
        private System.Windows.Forms.ListView lvReminders;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvSideBarReminders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolTip ttTipDoubleClick;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.RichTextBox rtbSideBarNoteText;
        private System.Windows.Forms.TextBox lblNoteTitleSideBar;
        private System.Windows.Forms.ListBox lbNotes;
        public System.Windows.Forms.ListView lvFavorites;
        private MetroFramework.Components.MetroStyleManager msmForm1;
        private MetroFramework.Controls.MetroButton btnAddRemeinder;
        private MetroFramework.Controls.MetroButton btnRemoveNotes;
        private MetroFramework.Controls.MetroButton btnAddNote;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.ImageList imgListIcons;
        private FontAwesome.Sharp.IconButton ibRemoveFavorite;
        private MetroFramework.Controls.MetroButton btnAddReminder;
        private MetroFramework.Controls.MetroButton btnRemoveNote;
        private MetroFramework.Controls.MetroPanel mpLoginScreen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox mtbEnterUsername;
    }
}

