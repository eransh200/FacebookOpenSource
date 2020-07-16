using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A20_Ex02_HarelLevi_308549807_EranShmuel_205477383.Logic
{
    public class FacebookConnection
    {
        public void Login(out User io_LoggedInUser)
        {

            LoginResult result = FacebookService.Login("2316795371946312",
           "public_profile",
           "email",
           "publish_to_groups",
           "user_birthday",
           "user_age_range",
           "user_gender",
           "user_link",
           "user_tagged_places",
           "user_videos",
           "publish_to_groups",
           "groups_access_member_info",
           "user_friends",
           "user_events",
           "user_likes",
           "user_location",
           "user_photos",
           "user_posts",
           "user_hometown");

            io_LoggedInUser = result.LoggedInUser;
        }
        public void Logout(out User io_LoggedInUser)
        {
            FacebookService.Logout(null);
            io_LoggedInUser = null;
        }
    }
}
