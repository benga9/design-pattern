using System;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179
{
    public class ViewModel
    {
        public User LoggedInUser { get; set; }

        public string Token { get; set; }

        public bool LoginSuccess(string i_AppId, string[] i_Permission)
        {
            // change to desire limit - limit too high will cause long wait every time the user go to FB server
            // 50 is reasonable
            FacebookService.s_CollectionLimit = 200;
            
            LoginResult result;
            string autologin = ConfigurationManager.AppSettings["autologin"];

            if (autologin.Equals("true"))
            {
                string acessToken = ConfigurationManager.AppSettings["token"];
                result = FacebookService.Connect(acessToken);
            }
            else
            {
                result = FacebookService.Login(i_AppId, i_Permission);
            }

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                LoggedInUser = result.LoggedInUser;
                Token = result.AccessToken;
            }
            else
            {
                return false;
            }

            return true;
        }

        public User GetStatusOwner(Status i_status)
        {
            return i_status.From;
        }

        public List<Event> GetUserEvents(User i_User)
        {
            List<Event> events = null;

            if (isUserHaveEvents(i_User))
            {
                events = new List<Event>(i_User.Events);
            }

            return events;
        }

        private bool isUserHaveEvents(User i_User)
        {
            return i_User.Events != null && i_User.Events.Count > 0;
        }

        public List<Status> GetFriendsStatus(string i_TextInStatus)
        {
            List<Status> resStatuses = new List<Status>();
            foreach (User friend in LoggedInUser.Friends)
            {
                foreach (Status status in friend.Statuses)
                {
                    if (status.Message != null && status.Message.Contains(i_TextInStatus))
                    {
                        resStatuses.Add(status);
                    }
                }
            }

            return resStatuses;
        }

        public List<ListViewItem> GetFriendsEvent(string i_TextInEventTitle)
        {
            List<Event> eventList;
            List<ListViewItem> resEventsList = new List<ListViewItem>();

            foreach (User friend in LoggedInUser.Friends)
            {
                eventList = GetUserEvents(friend);
                if (eventList != null)
                {
                    foreach (Event fbEvent in eventList)
                    {
                        if (fbEvent.Name != null && fbEvent.Name.Contains(i_TextInEventTitle))
                        {
                            ListViewItem eventItem = new ListViewItem(new[]
					        {
					            fbEvent.Name,
					            fbEvent.StartTime.Value.ToString(),
					            fbEvent.AttendingUsers.Count.ToString(),
					        });
                            resEventsList.Add(eventItem);
                            eventItem.Tag = fbEvent;
                        }
                    }
                }
            }

            return resEventsList;
        }      
    }
}
