using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A20_Ex02_HarelLevi_308549807_EranShmuel_205477383
{
    public class UserWrapper
    {
        public User User { get; set; }
        public int TotalLikes { get; set; } 
        public int TotalComments { get; set; } 
        public double TotalGrade{ get; set; }

        public UserWrapper(User i_User)
        {
            this.User = i_User;
        }
        public void CalculateGrade()
        {
            TotalGrade = TotalLikes * 0.4 + TotalComments * 0.6;
        }

    }
}
