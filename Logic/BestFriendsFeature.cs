using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A20_Ex02_HarelLevi_308549807_EranShmuel_205477383.Logic
{
    public class BestFriendsFeature
    {
        public List<UserWrapper> BestFriendList { get; set; }
        public void MakeAndCalculateBestFriendList(User i_LoggedInUser)
        {
            // scanning all posts and albums posted ever by user to calculate friend list
            BestFriendList = new List<UserWrapper>();
            foreach (Post post in i_LoggedInUser.Posts)
            {
                updateBestFriendList(post);
            }
            // the folowing loop can generate about 500 API calls,(scan maximum of 25 albums and 25 photos)
            // that may cause an high Rate Limit exception:"Application request limit reached"
            // to prevent this exception , we comment the folowing 7 lines of code.

            //foreach (Album album in i_LoggedInUser.Albums)
            //{
            //    foreach (Photo photo in album.Photos)
            //    {
            //        updateBestFriendList(photo);
            //    }
            //}

            foreach (UserWrapper userWrapper in BestFriendList)
            {
                userWrapper.CalculateGrade();
            }
            BestFriendList = BestFriendList.OrderByDescending(x => x.TotalGrade).Take(10).ToList();

        }
        private void updateBestFriendList(PostedItem i_PostedItem)
        {
            // this method probably wont work,
            // because there are no permissions to get Likes and Comments of posted item.
            foreach (User friend in i_PostedItem.LikedBy)
                
            {
                UserWrapper result = BestFriendList.Find((i_UserWrapper) => friend.UserName == i_UserWrapper.User.UserName);
                if (result == null)
                {// user not found, so we make new one
                    BestFriendList.Add(new UserWrapper(friend) { TotalLikes = 1 });
                }
                else
                {
                    result.TotalLikes++;
                }

            }
            foreach (Comment comment in i_PostedItem.Comments)
            {
                UserWrapper result = BestFriendList.Find((i_UserWrapper) => comment.From == i_UserWrapper.User);
                if (result == null)
                {// user not found, so we make new one
                    BestFriendList.Add(new UserWrapper(comment.From) { TotalComments = 1 });
                }
                else
                {
                    result.TotalComments++;
                }
            }

           
        }
    }
}
