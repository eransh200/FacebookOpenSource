using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.IO;
using System.Threading;
using A20_Ex02_HarelLevi_308549807_EranShmuel_205477383.Logic;

namespace A20_Ex02_HarelLevi_308549807_EranShmuel_205477383.UI
{
    public partial class FormFacebook : Form
    {
        
        public FormFacebook()
        {
            InitializeComponent();
        }
        private void updateUILogin()
        {
            buttonLogin.Visible = false;
            buttonLogout.Visible = true;
            string HelloMsg = string.Format("Hello {0}! ", FacebookManager.Instance.LoggedInUser.FirstName);
            m_labelHello.Text = HelloMsg;
            new Thread(fetchUserInfo).Start();
            new Thread(fetchPosts).Start();
            new Thread(fetchFriends).Start();
            new Thread(fetchEvents).Start();

        }
        private void fetchUserInfo()
        {
            this.Invoke(new Action(() =>
            {
                pictureBoxProfile.LoadAsync(FacebookManager.Instance.LoggedInUser.PictureNormalURL);
                if (FacebookManager.Instance.LoggedInUser.Gender == User.eGender.male)
                {
                    m_pictureBoxMale.LoadAsync(FacebookManager.Instance.LoggedInUser.PictureNormalURL);
                }
                else
                {
                    m_pictureBoxfemale.LoadAsync(FacebookManager.Instance.LoggedInUser.PictureNormalURL);
                }
            }));

        }
        private void fetchPosts()
        {
            FacebookObjectCollection<Post> newListOfPosts = new FacebookObjectCollection<Post>();
            foreach (Post post in FacebookManager.Instance.LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    newListOfPosts.Add(post);
                }
            }

            postBindingSource.DataSource = newListOfPosts;
            listBoxPosts.Invoke(new Action(() =>
            {
                listBoxPosts.DisplayMember = "Message";
                listBoxPosts.DataSource = this.postBindingSource;

            }));


            if (newListOfPosts.Count == 0)
            {
                this.Invoke(new Action(() => MessageBox.Show("No Posts to retrieve :(")));
            }
        }
        private void fetchFriends()
        {
            userBindingSource.DataSource = FacebookManager.Instance.LoggedInUser.Friends;
            listBoxFriends.Invoke(new Action(() =>
            {
                listBoxFriends.DisplayMember = "Name";
                listBoxFriends.DataSource = this.userBindingSource;

            }));
            if (FacebookManager.Instance.LoggedInUser.Friends.Count == 0)
            {
                this.Invoke(new Action(() => MessageBox.Show("No Friends to retrieve :(")));
            }
        }
        private void fetchEvents()
        {
            eventBindingSource.DataSource = FacebookManager.Instance.LoggedInUser.Events;
            listBoxEvents.Invoke(new Action(() =>
            {
                listBoxEvents.DataSource = this.eventBindingSource;
                listBoxEvents.DisplayMember = "Name";
            }));
            if (FacebookManager.Instance.LoggedInUser.Events.Count == 0)
            {
                this.Invoke(new Action(() => MessageBox.Show("No Events to retrieve :(")));
            }
        }
        private void fetchBestFriendList()
        {
            List<UserWrapper> bestFriendsList = FacebookManager.Instance.GetBestFriendsList();
            if (bestFriendsList.Count > 1)
            {
                int i = 0;
                foreach (UserWrapper friend in bestFriendsList)
                {
                    fetchBestFriendDetails(i, friend.User.Name, friend.User.PictureNormalURL);
                    i++;
                }
            }
            else
            {
                // simulating the feature
                fetchBestFriendDetails(0, "Bil gates", "https://images.wsj.net/im-105325?width=620&size=1.5");
                fetchBestFriendDetails(1, "Steve Jobs", "https://codigoespagueti.com/wp-content/uploads/2019/04/steve-jobs-wikileaks-vih-filtracion-1080x600.jpg");

            }
        }
        private void fetchBestFriendDetails(int i_SerialNumber, string i_FriendName, string i_PictureUrl)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(i_PictureUrl);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);

            string nameOfFriendFormat = $"#{i_SerialNumber + 1}: {i_FriendName}";
            imageListTopTenFriends.Images.Add(img);
            this.imageListTopTenFriends.Images.SetKeyName(i_SerialNumber, i_PictureUrl);
            ListViewItem itemToAdd = new ListViewItem(nameOfFriendFormat, i_SerialNumber)
            {
                Font = new Font("Gill Sans Ultra Bold", 12F),
                ForeColor = SystemColors.Highlight,

            };
            listViewTopTenFriends.Items.Add(itemToAdd);
        }
        private void cleanUI()
        {
            eventBindingSource.DataSource = typeof(Event);
            userBindingSource.DataSource = typeof(User);
            postBindingSource.DataSource = typeof(Post);
            listBoxEvents.DataSource = null;
            listBoxPosts.DataSource = null;
            listBoxFriends.DataSource = null;

            this.m_labelHello.Text = "Hello guest!";
            pictureBoxProfile.Image = null;
            m_pictureBoxMale.Image = null;
            buttonLogin.Visible = true;
            buttonLogout.Visible = false;
            listViewTopTenFriends.Clear();
        }
        public void UploadNewMatchLove()
        {
            try
            {
                if (FacebookManager.Instance.LoggedInUser.Gender == User.eGender.female)
                {
                    if (FacebookManager.Instance.FindLove() != null)
                    {
                        m_pictureBoxfemale.LoadAsync(FacebookManager.Instance.FindLove());
                    }
                }
                else
                {
                    if (FacebookManager.Instance.FindLove() != null)
                    {
                        m_pictureBoxMale.LoadAsync(FacebookManager.Instance.FindLove());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("not found friends!\n probably because lack of permissions.");
            }
        }

        //click events
        private void buttonStartFindLoveFeature_Click(object sender, EventArgs e)
        {
            try
            {
                UploadNewMatchLove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonStartBestFriendsFeature_Click(object sender, EventArgs e)
        {
            try
            {
                fetchBestFriendList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonPost_Click(object sender, EventArgs e)
        {
            string UserPostInputText = TextBoxPost.Text;
            if (!string.IsNullOrEmpty(UserPostInputText))
            {
                try
                {
                    FacebookManager.Instance.LoggedInUser.PostStatus(UserPostInputText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nothing was happened");
            }

        }
        private void buttonLike_Click(object sender, EventArgs e)
        {
            FormUserChoice sendEmailChoice = new FormUserChoice(string.Format(@"Would you like send your match" +"\n friend a message? "));
            sendEmailChoice.ShowDialog();
            if (sendEmailChoice.Choice)
            {
                FacebookManager.Instance.SendMail();
            }
        }
        private void buttonUnlike_Click(object sender, EventArgs e)
        {
            try
            {
                UploadNewMatchLove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
				FacebookManager.Instance.Login();
                updateUILogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookManager.Instance.Logout();
            cleanUI();
        }
    }
}