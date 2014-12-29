namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.picture_smallPictureBox = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBasicFeatues = new System.Windows.Forms.TabPage();
            this.labelEvents = new System.Windows.Forms.LinkLabel();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.linkCheckins = new System.Windows.Forms.LinkLabel();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.linkFriends = new System.Windows.Forms.LinkLabel();
            this.linkNewsFeed = new System.Windows.Forms.LinkLabel();
            this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.tabFriendStatusFilter = new System.Windows.Forms.TabPage();
            this.labelChooseStatus = new System.Windows.Forms.Label();
            this.labelNumberOfStatusesText = new System.Windows.Forms.Label();
            this.labelStatusOwnerName = new System.Windows.Forms.Label();
            this.pictureBoxStatusOwner = new System.Windows.Forms.PictureBox();
            this.listBoxFilteredStatuses = new System.Windows.Forms.ListBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelFilterFriendsStatuses = new System.Windows.Forms.Label();
            this.textBoxFilterFriendsStatuses = new System.Windows.Forms.TextBox();
            this.tabFriendsEvent = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonJoinEvent = new System.Windows.Forms.Button();
            this.groupBoxEventDetails = new System.Windows.Forms.GroupBox();
            this.pictureBoxEventOfFriend = new System.Windows.Forms.PictureBox();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.labelEventName = new System.Windows.Forms.Label();
            this.pictureBoxGoingFriend = new System.Windows.Forms.PictureBox();
            this.listBoxGoingFriends = new System.Windows.Forms.ListBox();
            this.buttonShowEventFiltered = new System.Windows.Forms.Button();
            this.labelFilterEvents = new System.Windows.Forms.Label();
            this.textBoxFriendsEventFilter = new System.Windows.Forms.TextBox();
            this.listFriendsEventsFiltered = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabBasicFeatues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.tabFriendStatusFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusOwner)).BeginInit();
            this.tabFriendsEvent.SuspendLayout();
            this.groupBoxEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventOfFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoingFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(23, 11);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(87, 32);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // picture_smallPictureBox
            // 
            this.picture_smallPictureBox.Location = new System.Drawing.Point(10, 47);
            this.picture_smallPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picture_smallPictureBox.Name = "picture_smallPictureBox";
            this.picture_smallPictureBox.Size = new System.Drawing.Size(115, 102);
            this.picture_smallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_smallPictureBox.TabIndex = 1;
            this.picture_smallPictureBox.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(35, 151);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBasicFeatues);
            this.tabControl1.Controls.Add(this.tabFriendStatusFilter);
            this.tabControl1.Controls.Add(this.tabFriendsEvent);
            this.tabControl1.Location = new System.Drawing.Point(127, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 639);
            this.tabControl1.TabIndex = 48;
            // 
            // tabBasicFeatues
            // 
            this.tabBasicFeatues.Controls.Add(this.labelEvents);
            this.tabBasicFeatues.Controls.Add(this.pictureBoxEvent);
            this.tabBasicFeatues.Controls.Add(this.listBoxEvents);
            this.tabBasicFeatues.Controls.Add(this.linkCheckins);
            this.tabBasicFeatues.Controls.Add(this.listBoxCheckins);
            this.tabBasicFeatues.Controls.Add(this.pictureBoxFriend);
            this.tabBasicFeatues.Controls.Add(this.listBoxFriends);
            this.tabBasicFeatues.Controls.Add(this.linkFriends);
            this.tabBasicFeatues.Controls.Add(this.linkNewsFeed);
            this.tabBasicFeatues.Controls.Add(this.listBoxNewsFeed);
            this.tabBasicFeatues.Controls.Add(this.buttonPostStatus);
            this.tabBasicFeatues.Controls.Add(this.textBoxStatus);
            this.tabBasicFeatues.Controls.Add(this.labelPostStatus);
            this.tabBasicFeatues.Location = new System.Drawing.Point(4, 22);
            this.tabBasicFeatues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBasicFeatues.Name = "tabBasicFeatues";
            this.tabBasicFeatues.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBasicFeatues.Size = new System.Drawing.Size(650, 613);
            this.tabBasicFeatues.TabIndex = 0;
            this.tabBasicFeatues.Text = "Basic Featues";
            this.tabBasicFeatues.UseVisualStyleBackColor = true;
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.labelEvents.Location = new System.Drawing.Point(286, 202);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(190, 30);
            this.labelEvents.TabIndex = 60;
            this.labelEvents.TabStop = true;
            this.labelEvents.Text = "Fetch Events \r\n(Click on an event to view it\'s picture)";
            this.labelEvents.UseCompatibleTextRendering = true;
            this.labelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelEvents_LinkClicked);
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(484, 233);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(145, 173);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEvent.TabIndex = 59;
            this.pictureBoxEvent.TabStop = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.DisplayMember = "name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(286, 234);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(193, 173);
            this.listBoxEvents.TabIndex = 58;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // linkCheckins
            // 
            this.linkCheckins.AutoSize = true;
            this.linkCheckins.LinkArea = new System.Windows.Forms.LinkArea(0, 14);
            this.linkCheckins.Location = new System.Drawing.Point(22, 419);
            this.linkCheckins.Name = "linkCheckins";
            this.linkCheckins.Size = new System.Drawing.Size(82, 17);
            this.linkCheckins.TabIndex = 57;
            this.linkCheckins.TabStop = true;
            this.linkCheckins.Text = "Fetch Checkins";
            this.linkCheckins.UseCompatibleTextRendering = true;
            this.linkCheckins.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCheckins_LinkClicked);
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCheckins.DisplayMember = "name";
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.Location = new System.Drawing.Point(22, 439);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(608, 173);
            this.listBoxCheckins.TabIndex = 56;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(143, 233);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(137, 173);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFriend.TabIndex = 55;
            this.pictureBoxFriend.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(22, 234);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(109, 173);
            this.listBoxFriends.TabIndex = 54;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // linkFriends
            // 
            this.linkFriends.AutoSize = true;
            this.linkFriends.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkFriends.Location = new System.Drawing.Point(22, 202);
            this.linkFriends.Name = "linkFriends";
            this.linkFriends.Size = new System.Drawing.Size(185, 30);
            this.linkFriends.TabIndex = 53;
            this.linkFriends.TabStop = true;
            this.linkFriends.Text = "Fetch Friends \r\n(Click on a friend to view it\'s picture)";
            this.linkFriends.UseCompatibleTextRendering = true;
            this.linkFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFriends_LinkClicked);
            // 
            // linkNewsFeed
            // 
            this.linkNewsFeed.AutoSize = true;
            this.linkNewsFeed.Location = new System.Drawing.Point(20, 42);
            this.linkNewsFeed.Name = "linkNewsFeed";
            this.linkNewsFeed.Size = new System.Drawing.Size(91, 13);
            this.linkNewsFeed.TabIndex = 52;
            this.linkNewsFeed.TabStop = true;
            this.linkNewsFeed.Text = "Fetch News Feed";
            this.linkNewsFeed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNewsFeed_LinkClicked);
            // 
            // listBoxNewsFeed
            // 
            this.listBoxNewsFeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNewsFeed.DisplayMember = "name";
            this.listBoxNewsFeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNewsFeed.FormattingEnabled = true;
            this.listBoxNewsFeed.ItemHeight = 19;
            this.listBoxNewsFeed.Location = new System.Drawing.Point(22, 59);
            this.listBoxNewsFeed.Name = "listBoxNewsFeed";
            this.listBoxNewsFeed.Size = new System.Drawing.Size(608, 137);
            this.listBoxNewsFeed.TabIndex = 51;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPostStatus.Location = new System.Drawing.Point(541, 11);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonPostStatus.TabIndex = 50;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(113, 14);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(416, 20);
            this.textBoxStatus.TabIndex = 49;
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Location = new System.Drawing.Point(40, 16);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(64, 13);
            this.labelPostStatus.TabIndex = 48;
            this.labelPostStatus.Text = "Post Status:";
            // 
            // tabFriendStatusFilter
            // 
            this.tabFriendStatusFilter.Controls.Add(this.labelChooseStatus);
            this.tabFriendStatusFilter.Controls.Add(this.labelNumberOfStatusesText);
            this.tabFriendStatusFilter.Controls.Add(this.labelStatusOwnerName);
            this.tabFriendStatusFilter.Controls.Add(this.pictureBoxStatusOwner);
            this.tabFriendStatusFilter.Controls.Add(this.listBoxFilteredStatuses);
            this.tabFriendStatusFilter.Controls.Add(this.buttonFilter);
            this.tabFriendStatusFilter.Controls.Add(this.labelFilterFriendsStatuses);
            this.tabFriendStatusFilter.Controls.Add(this.textBoxFilterFriendsStatuses);
            this.tabFriendStatusFilter.Location = new System.Drawing.Point(4, 22);
            this.tabFriendStatusFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabFriendStatusFilter.Name = "tabFriendStatusFilter";
            this.tabFriendStatusFilter.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabFriendStatusFilter.Size = new System.Drawing.Size(650, 613);
            this.tabFriendStatusFilter.TabIndex = 1;
            this.tabFriendStatusFilter.Text = "Friend Status Filter";
            this.tabFriendStatusFilter.UseVisualStyleBackColor = true;
            // 
            // labelChooseStatus
            // 
            this.labelChooseStatus.AutoSize = true;
            this.labelChooseStatus.Location = new System.Drawing.Point(3, 294);
            this.labelChooseStatus.Name = "labelChooseStatus";
            this.labelChooseStatus.Size = new System.Drawing.Size(0, 13);
            this.labelChooseStatus.TabIndex = 59;
            // 
            // labelNumberOfStatusesText
            // 
            this.labelNumberOfStatusesText.AutoSize = true;
            this.labelNumberOfStatusesText.Location = new System.Drawing.Point(32, 75);
            this.labelNumberOfStatusesText.Name = "labelNumberOfStatusesText";
            this.labelNumberOfStatusesText.Size = new System.Drawing.Size(0, 13);
            this.labelNumberOfStatusesText.TabIndex = 58;
            // 
            // labelStatusOwnerName
            // 
            this.labelStatusOwnerName.AutoSize = true;
            this.labelStatusOwnerName.Location = new System.Drawing.Point(306, 111);
            this.labelStatusOwnerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatusOwnerName.Name = "labelStatusOwnerName";
            this.labelStatusOwnerName.Size = new System.Drawing.Size(0, 13);
            this.labelStatusOwnerName.TabIndex = 57;
            // 
            // pictureBoxStatusOwner
            // 
            this.pictureBoxStatusOwner.Location = new System.Drawing.Point(251, 140);
            this.pictureBoxStatusOwner.Name = "pictureBoxStatusOwner";
            this.pictureBoxStatusOwner.Size = new System.Drawing.Size(174, 165);
            this.pictureBoxStatusOwner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStatusOwner.TabIndex = 56;
            this.pictureBoxStatusOwner.TabStop = false;
            // 
            // listBoxFilteredStatuses
            // 
            this.listBoxFilteredStatuses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFilteredStatuses.DisplayMember = "name";
            this.listBoxFilteredStatuses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFilteredStatuses.FormattingEnabled = true;
            this.listBoxFilteredStatuses.ItemHeight = 19;
            this.listBoxFilteredStatuses.Location = new System.Drawing.Point(3, 311);
            this.listBoxFilteredStatuses.Name = "listBoxFilteredStatuses";
            this.listBoxFilteredStatuses.Size = new System.Drawing.Size(644, 289);
            this.listBoxFilteredStatuses.TabIndex = 53;
            this.listBoxFilteredStatuses.SelectedIndexChanged += new System.EventHandler(this.listBoxFilteredStatuses_SelectedIndexChanged);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.Location = new System.Drawing.Point(458, 14);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 52;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // labelFilterFriendsStatuses
            // 
            this.labelFilterFriendsStatuses.AutoSize = true;
            this.labelFilterFriendsStatuses.Location = new System.Drawing.Point(32, 19);
            this.labelFilterFriendsStatuses.Name = "labelFilterFriendsStatuses";
            this.labelFilterFriendsStatuses.Size = new System.Drawing.Size(177, 13);
            this.labelFilterFriendsStatuses.TabIndex = 51;
            this.labelFilterFriendsStatuses.Text = "Show friends statuses that contains:";
            // 
            // textBoxFilterFriendsStatuses
            // 
            this.textBoxFilterFriendsStatuses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterFriendsStatuses.Location = new System.Drawing.Point(214, 16);
            this.textBoxFilterFriendsStatuses.Name = "textBoxFilterFriendsStatuses";
            this.textBoxFilterFriendsStatuses.Size = new System.Drawing.Size(222, 20);
            this.textBoxFilterFriendsStatuses.TabIndex = 50;
            // 
            // tabFriendsEvent
            // 
            this.tabFriendsEvent.Controls.Add(this.label1);
            this.tabFriendsEvent.Controls.Add(this.buttonJoinEvent);
            this.tabFriendsEvent.Controls.Add(this.groupBoxEventDetails);
            this.tabFriendsEvent.Controls.Add(this.pictureBoxGoingFriend);
            this.tabFriendsEvent.Controls.Add(this.listBoxGoingFriends);
            this.tabFriendsEvent.Controls.Add(this.buttonShowEventFiltered);
            this.tabFriendsEvent.Controls.Add(this.labelFilterEvents);
            this.tabFriendsEvent.Controls.Add(this.textBoxFriendsEventFilter);
            this.tabFriendsEvent.Controls.Add(this.listFriendsEventsFiltered);
            this.tabFriendsEvent.Location = new System.Drawing.Point(4, 22);
            this.tabFriendsEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabFriendsEvent.Name = "tabFriendsEvent";
            this.tabFriendsEvent.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabFriendsEvent.Size = new System.Drawing.Size(650, 613);
            this.tabFriendsEvent.TabIndex = 2;
            this.tabFriendsEvent.Text = "Friends Event Filter";
            this.tabFriendsEvent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 470);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Going Friends:";
            // 
            // buttonJoinEvent
            // 
            this.buttonJoinEvent.Location = new System.Drawing.Point(454, 527);
            this.buttonJoinEvent.Name = "buttonJoinEvent";
            this.buttonJoinEvent.Size = new System.Drawing.Size(156, 23);
            this.buttonJoinEvent.TabIndex = 82;
            this.buttonJoinEvent.Text = "Join Selected Event";
            this.buttonJoinEvent.UseVisualStyleBackColor = true;
            this.buttonJoinEvent.Click += new System.EventHandler(this.buttonJoinEvent_Click);
            // 
            // groupBoxEventDetails
            // 
            this.groupBoxEventDetails.Controls.Add(this.pictureBoxEventOfFriend);
            this.groupBoxEventDetails.Controls.Add(this.textBoxEventDescription);
            this.groupBoxEventDetails.Controls.Add(this.labelEventName);
            this.groupBoxEventDetails.Location = new System.Drawing.Point(33, 274);
            this.groupBoxEventDetails.Name = "groupBoxEventDetails";
            this.groupBoxEventDetails.Size = new System.Drawing.Size(584, 180);
            this.groupBoxEventDetails.TabIndex = 81;
            this.groupBoxEventDetails.TabStop = false;
            this.groupBoxEventDetails.Text = "Event Details";
            // 
            // pictureBoxEventOfFriend
            // 
            this.pictureBoxEventOfFriend.Location = new System.Drawing.Point(7, 19);
            this.pictureBoxEventOfFriend.Name = "pictureBoxEventOfFriend";
            this.pictureBoxEventOfFriend.Size = new System.Drawing.Size(142, 141);
            this.pictureBoxEventOfFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEventOfFriend.TabIndex = 74;
            this.pictureBoxEventOfFriend.TabStop = false;
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(165, 30);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.ReadOnly = true;
            this.textBoxEventDescription.Size = new System.Drawing.Size(414, 130);
            this.textBoxEventDescription.TabIndex = 74;
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(167, 11);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(0, 13);
            this.labelEventName.TabIndex = 76;
            // 
            // pictureBoxGoingFriend
            // 
            this.pictureBoxGoingFriend.Location = new System.Drawing.Point(280, 470);
            this.pictureBoxGoingFriend.Name = "pictureBoxGoingFriend";
            this.pictureBoxGoingFriend.Size = new System.Drawing.Size(137, 133);
            this.pictureBoxGoingFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGoingFriend.TabIndex = 68;
            this.pictureBoxGoingFriend.TabStop = false;
            // 
            // listBoxGoingFriends
            // 
            this.listBoxGoingFriends.DisplayMember = "Name";
            this.listBoxGoingFriends.FormattingEnabled = true;
            this.listBoxGoingFriends.Location = new System.Drawing.Point(117, 470);
            this.listBoxGoingFriends.Name = "listBoxGoingFriends";
            this.listBoxGoingFriends.Size = new System.Drawing.Size(142, 134);
            this.listBoxGoingFriends.TabIndex = 67;
            this.listBoxGoingFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxGoingFriends_SelectedIndexChanged);
            // 
            // buttonShowEventFiltered
            // 
            this.buttonShowEventFiltered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowEventFiltered.Location = new System.Drawing.Point(502, 13);
            this.buttonShowEventFiltered.Name = "buttonShowEventFiltered";
            this.buttonShowEventFiltered.Size = new System.Drawing.Size(75, 23);
            this.buttonShowEventFiltered.TabIndex = 65;
            this.buttonShowEventFiltered.Text = "Show Event";
            this.buttonShowEventFiltered.UseVisualStyleBackColor = true;
            this.buttonShowEventFiltered.Click += new System.EventHandler(this.buttonEventFilter_Click);
            // 
            // labelFilterEvents
            // 
            this.labelFilterEvents.AutoSize = true;
            this.labelFilterEvents.Location = new System.Drawing.Point(75, 18);
            this.labelFilterEvents.Name = "labelFilterEvents";
            this.labelFilterEvents.Size = new System.Drawing.Size(170, 13);
            this.labelFilterEvents.TabIndex = 64;
            this.labelFilterEvents.Text = "Show friends events that contains:";
            // 
            // textBoxFriendsEventFilter
            // 
            this.textBoxFriendsEventFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFriendsEventFilter.Location = new System.Drawing.Point(257, 15);
            this.textBoxFriendsEventFilter.Name = "textBoxFriendsEventFilter";
            this.textBoxFriendsEventFilter.Size = new System.Drawing.Size(222, 20);
            this.textBoxFriendsEventFilter.TabIndex = 63;
            // 
            // listFriendsEventsFiltered
            // 
            this.listFriendsEventsFiltered.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listFriendsEventsFiltered.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listFriendsEventsFiltered.Location = new System.Drawing.Point(33, 50);
            this.listFriendsEventsFiltered.Name = "listFriendsEventsFiltered";
            this.listFriendsEventsFiltered.Size = new System.Drawing.Size(584, 218);
            this.listFriendsEventsFiltered.TabIndex = 66;
            this.listFriendsEventsFiltered.UseCompatibleStateImageBehavior = false;
            this.listFriendsEventsFiltered.View = System.Windows.Forms.View.Details;
            this.listFriendsEventsFiltered.SelectedIndexChanged += new System.EventHandler(this.listFriendsEventsFiltered_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Event Title";
            this.columnHeader1.Width = 360;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "When";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Going";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 65;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 652);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.picture_smallPictureBox);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "A15_Ex02_BenGalili_039711056_AmitPaz_040305179";
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabBasicFeatues.ResumeLayout(false);
            this.tabBasicFeatues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.tabFriendStatusFilter.ResumeLayout(false);
            this.tabFriendStatusFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatusOwner)).EndInit();
            this.tabFriendsEvent.ResumeLayout(false);
            this.tabFriendsEvent.PerformLayout();
            this.groupBoxEventDetails.ResumeLayout(false);
            this.groupBoxEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventOfFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoingFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox picture_smallPictureBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBasicFeatues;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.TabPage tabFriendStatusFilter;
        private System.Windows.Forms.LinkLabel linkNewsFeed;
        private System.Windows.Forms.ListBox listBoxNewsFeed;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.LinkLabel linkFriends;
        private System.Windows.Forms.LinkLabel linkCheckins;
        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.LinkLabel labelEvents;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.TextBox textBoxFilterFriendsStatuses;
        private System.Windows.Forms.Label labelFilterFriendsStatuses;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ListBox listBoxFilteredStatuses;
        private System.Windows.Forms.PictureBox pictureBoxStatusOwner;
        private System.Windows.Forms.Label labelStatusOwnerName;
        private System.Windows.Forms.Label labelNumberOfStatusesText;
        private System.Windows.Forms.Label labelChooseStatus;
        private System.Windows.Forms.TabPage tabFriendsEvent;
        private System.Windows.Forms.Button buttonShowEventFiltered;
        private System.Windows.Forms.Label labelFilterEvents;
        private System.Windows.Forms.TextBox textBoxFriendsEventFilter;
        private System.Windows.Forms.ListView listFriendsEventsFiltered;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBoxGoingFriend;
        private System.Windows.Forms.ListBox listBoxGoingFriends;
        private System.Windows.Forms.GroupBox groupBoxEventDetails;
        private System.Windows.Forms.PictureBox pictureBoxEventOfFriend;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Button buttonJoinEvent;
        private System.Windows.Forms.Label label1;
    }
}