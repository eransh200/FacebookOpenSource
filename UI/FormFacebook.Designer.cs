using A20_Ex01_HarelLevi_308549807_EranShmuel_205477383.UI;

namespace A20_Ex02_HarelLevi_308549807_EranShmuel_205477383.UI
{
	partial class FormFacebook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacebook));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new RoundPictureBoxProxy();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxPost = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonstart = new System.Windows.Forms.Button();
            this.buttonUnlike = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLike = new System.Windows.Forms.Button();
            this.m_pictureBoxMale = new RoundPictureBoxProxy();
            this.m_pictureBoxfemale = new RoundPictureBoxProxy();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewTopTenFriends = new System.Windows.Forms.ListView();
            this.imageListTopTenFriends = new System.Windows.Forms.ImageList(this.components);
            this.buttonShowBestFriendList = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_labelHello = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxfemale)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogin.Location = new System.Drawing.Point(11, 218);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(183, 67);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(15, 323);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(173, 151);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 1;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogout.Location = new System.Drawing.Point(11, 218);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(183, 67);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(222, 90);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 447);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(252, 124);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 413);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage3.Controls.Add(this.listBoxFriends);
            this.tabPage3.Controls.Add(this.listBoxEvents);
            this.tabPage3.Controls.Add(this.listBoxPosts);
            this.tabPage3.Controls.Add(this.buttonPost);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.TextBoxPost);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(723, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Facebook page";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(26, 97);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(290, 116);
            this.listBoxFriends.TabIndex = 12;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(185, 250);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(290, 116);
            this.listBoxEvents.TabIndex = 11;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(357, 97);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(290, 116);
            this.listBoxPosts.TabIndex = 10;
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonPost.Location = new System.Drawing.Point(576, 27);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(71, 34);
            this.buttonPost.TabIndex = 9;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(287, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Events";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(113, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Friends";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(467, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Posts";
            // 
            // TextBoxPost
            // 
            this.TextBoxPost.Location = new System.Drawing.Point(239, 26);
            this.TextBoxPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxPost.Name = "TextBoxPost";
            this.TextBoxPost.Size = new System.Drawing.Size(324, 37);
            this.TextBoxPost.TabIndex = 3;
            this.TextBoxPost.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(62, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Post status:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage1.Controls.Add(this.buttonstart);
            this.tabPage1.Controls.Add(this.buttonUnlike);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonLike);
            this.tabPage1.Controls.Add(this.m_pictureBoxMale);
            this.tabPage1.Controls.Add(this.m_pictureBoxfemale);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(723, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Find love";
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(482, 26);
            this.buttonstart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(117, 43);
            this.buttonstart.TabIndex = 8;
            this.buttonstart.Text = "Start";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonStartFindLoveFeature_Click);
            // 
            // buttonUnlike
            // 
            this.buttonUnlike.BackColor = System.Drawing.Color.Red;
            this.buttonUnlike.Location = new System.Drawing.Point(197, 318);
            this.buttonUnlike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUnlike.Name = "buttonUnlike";
            this.buttonUnlike.Size = new System.Drawing.Size(102, 46);
            this.buttonUnlike.TabIndex = 7;
            this.buttonUnlike.Text = "Unlike";
            this.buttonUnlike.UseVisualStyleBackColor = false;
            this.buttonUnlike.Click += new System.EventHandler(this.buttonUnlike_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(173, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Find your love";
            // 
            // buttonLike
            // 
            this.buttonLike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLike.Location = new System.Drawing.Point(335, 318);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(102, 46);
            this.buttonLike.TabIndex = 5;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = false;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // m_pictureBoxMale
            // 
            this.m_pictureBoxMale.Image = ((System.Drawing.Image)(resources.GetObject("m_pictureBoxMale.Image")));
            this.m_pictureBoxMale.Location = new System.Drawing.Point(118, 143);
            this.m_pictureBoxMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_pictureBoxMale.Name = "m_pictureBoxMale";
            this.m_pictureBoxMale.Size = new System.Drawing.Size(148, 156);
            this.m_pictureBoxMale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pictureBoxMale.TabIndex = 2;
            this.m_pictureBoxMale.TabStop = false;
            // 
            // m_pictureBoxfemale
            // 
            this.m_pictureBoxfemale.Image = ((System.Drawing.Image)(resources.GetObject("m_pictureBoxfemale.Image")));
            this.m_pictureBoxfemale.Location = new System.Drawing.Point(365, 143);
            this.m_pictureBoxfemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_pictureBoxfemale.Name = "m_pictureBoxfemale";
            this.m_pictureBoxfemale.Size = new System.Drawing.Size(148, 156);
            this.m_pictureBoxfemale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pictureBoxfemale.TabIndex = 1;
            this.m_pictureBoxfemale.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage2.Controls.Add(this.listViewTopTenFriends);
            this.tabPage2.Controls.Add(this.buttonShowBestFriendList);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(723, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Best Friend";
            // 
            // listViewTopTenFriends
            // 
            this.listViewTopTenFriends.HideSelection = false;
            this.listViewTopTenFriends.LargeImageList = this.imageListTopTenFriends;
            this.listViewTopTenFriends.Location = new System.Drawing.Point(106, 88);
            this.listViewTopTenFriends.Name = "listViewTopTenFriends";
            this.listViewTopTenFriends.Size = new System.Drawing.Size(412, 265);
            this.listViewTopTenFriends.SmallImageList = this.imageListTopTenFriends;
            this.listViewTopTenFriends.TabIndex = 5;
            this.listViewTopTenFriends.UseCompatibleStateImageBehavior = false;
            this.listViewTopTenFriends.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imageListTopTenFriends
            // 
            this.imageListTopTenFriends.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListTopTenFriends.ImageSize = new System.Drawing.Size(120, 120);
            this.imageListTopTenFriends.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonShowBestFriendList
            // 
            this.buttonShowBestFriendList.Location = new System.Drawing.Point(488, 43);
            this.buttonShowBestFriendList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowBestFriendList.Name = "buttonShowBestFriendList";
            this.buttonShowBestFriendList.Size = new System.Drawing.Size(125, 40);
            this.buttonShowBestFriendList.TabIndex = 1;
            this.buttonShowBestFriendList.Text = "Start";
            this.buttonShowBestFriendList.UseVisualStyleBackColor = true;
            this.buttonShowBestFriendList.Click += new System.EventHandler(this.buttonStartBestFriendsFeature_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(23, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(434, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Find Your 10 best facebook friends";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // m_labelHello
            // 
            this.m_labelHello.AutoSize = true;
            this.m_labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_labelHello.Location = new System.Drawing.Point(48, 130);
            this.m_labelHello.Name = "m_labelHello";
            this.m_labelHello.Size = new System.Drawing.Size(99, 20);
            this.m_labelHello.TabIndex = 9;
            this.m_labelHello.Text = "Hello guest!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(11, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Welcome to Facebook";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-2, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(985, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // FormFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(990, 557);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_labelHello);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormFacebook";
            this.Text = "FormFacebook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxfemale)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.PictureBox pictureBoxProfile;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.PictureBox m_pictureBoxMale;
		private System.Windows.Forms.PictureBox m_pictureBoxfemale;
		private System.Windows.Forms.Button buttonLike;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonUnlike;
		private System.Windows.Forms.Button buttonstart;
		private System.Windows.Forms.Label m_labelHello;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox TextBoxPost;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonShowBestFriendList;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.ListView listViewTopTenFriends;
		private System.Windows.Forms.ImageList imageListTopTenFriends;
		private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}

