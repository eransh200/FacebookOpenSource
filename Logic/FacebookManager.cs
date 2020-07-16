using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace A20_Ex02_HarelLevi_308549807_EranShmuel_205477383.Logic
{
	public sealed class FacebookManager
	{
		private static FacebookManager s_FacebookManagerInstance = null;
		private static object s_LockObj = new object();

		private FacebookManager()
		{
		}

		public static FacebookManager Instance
		{
			get
			{
				if (s_FacebookManagerInstance == null)
				{
					lock (s_LockObj)
					{
						if (s_FacebookManagerInstance == null)
						{
							s_FacebookManagerInstance = new FacebookManager();
						}
					}
				}

				return s_FacebookManagerInstance;
			}
		}

		private User m_LoggedInUser;

		public User LoggedInUser
		{
			get { return m_LoggedInUser; }
			set { m_LoggedInUser = value; }
		}

        private volatile FindLoveFeature m_FindLoveFeature;
		public FindLoveFeature FindLoveFeature
		{
			get
			{
				if (m_FindLoveFeature == null)
				{
					m_FindLoveFeature = new FindLoveFeature();
				}

				return m_FindLoveFeature;
			}
		}

		private volatile BestFriendsFeature m_BestFriendsFeature;
		public BestFriendsFeature BestFriendsFeature
		{
			get
			{
				if (m_BestFriendsFeature == null)
				{
					m_BestFriendsFeature = new BestFriendsFeature();
				}

				return m_BestFriendsFeature;
			}
		}

		private volatile FacebookConnection m_FacebookConnection;
		public FacebookConnection FacebookConnection
		{
			get
			{
				if (m_FacebookConnection == null)
				{
					m_FacebookConnection = new FacebookConnection();
				}

				return m_FacebookConnection;
			}
		}


		//public FacebookManager()
		//{
		//    m_FindLoveFeature = new FindLoveFeature();
		//    m_BestFriendsFeature = new BestFriendsFeature();
		//    m_FacebookConnection = new FacebookConnection();
		//}
		public List<UserWrapper> GetBestFriendsList()
        {
			BestFriendsFeature.MakeAndCalculateBestFriendList(LoggedInUser);
            return BestFriendsFeature.BestFriendList;
        }

        public string FindLove()
        {
            return FindLoveFeature.FindLoveMatch(LoggedInUser);
        }
        public void SendMail()
        {
			FindLoveFeature.SendMail(LoggedInUser);
        }
        public void Logout()
        {
			FacebookConnection.Logout(out m_LoggedInUser);
        }
        public void Login()
        {
			FacebookConnection.Login(out m_LoggedInUser);
        }
    }
}
