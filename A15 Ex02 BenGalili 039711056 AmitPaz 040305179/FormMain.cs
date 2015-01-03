using System.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using A15_Ex02_BenGalili_039711056_AmitPaz_040305179.Log;

namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179
{
    public partial class FormMain : Form
    {
        private readonly string r_AppId = "540432436034011";
        private readonly string[] r_Permission = { "user_about_me", "publish_actions", "user_friends", "friends_about_me", "friends_events", "publish_stream", "user_events", "read_stream", "user_status", "rsvp_event" };

        public ViewModel ViewModel { get; set; }

        public FormMain()
        {
            InitializeComponent();
            ViewModel = new ViewModel();
            Logger.Instance.LogInfo("App Init");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {

                bool IsloggedIn = ViewModel.LoginSuccess(r_AppId, r_Permission);

                if (IsloggedIn)
                {
                    fetchUserInfo();
                    Logger.Instance.LogInfo("LoggedIn");
                }
                else
                {
                    MessageBox.Show("Could not Login");
                }
            }

            catch (Facebook.FacebookOAuthException ex)
            {
                string msg = "Error attempting to login with saved token";

                Logger.Instance.LogError(msg);
                MessageBox.Show(msg);

            }

            catch (Exception ex)
            {
                string msg = "Error attempting to login";

                Logger.Instance.LogError(msg);
                MessageBox.Show(msg);

            }

        }

        private void fetchUserInfo()
        {
            picture_smallPictureBox.LoadAsync(ViewModel.LoggedInUser.PictureNormalURL);
            labelName.Text = ViewModel.LoggedInUser.Name;
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            ViewModel.LoggedInUser.PostStatus(textBoxStatus.Text);
        }

        private void linkNewsFeed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxNewsFeed.Items.Clear();
            new Thread(fetchNewsFeed).Start();
        }

        private void fetchNewsFeed()
        {
            var allFeeds = ViewModel.LoggedInUser.NewsFeed;
            listBoxNewsFeed.Invoke(new Action(
                () =>
                {
                    foreach (Post post in allFeeds)
                    {
                        if (post.Message != null)
                        {
                            listBoxNewsFeed.Items.Add(post.Message);
                        }
                        else if (post.Caption != null)
                        {
                            listBoxNewsFeed.Items.Add(post.Caption);
                        }
                        else
                        {
                            listBoxNewsFeed.Items.Add(string.Format("[{0}]", post.Type));
                        }
                    }
                }
                                            )
                                    );
        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxFriends.Items.Clear();
            new Thread(fetchFriends).Start();
        }

        private void fetchFriends()
        {
            var allFriends = ViewModel.LoggedInUser.Friends;
            listBoxFriends.Invoke(new Action(
                () =>
                {
                    foreach (User friend in allFriends)
                    {
                        listBoxFriends.Items.Add(friend);
                    }
                }
                                             )
                                  );
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend(listBoxFriends, pictureBoxFriend);
        }

        private void displaySelectedFriend(ListBox i_ListBox, PictureBox i_PictureBox)
        {
            if (i_ListBox.SelectedItems.Count == 1)
            {
                User selectedFriend = i_ListBox.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    i_PictureBox.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    picture_smallPictureBox.Image = picture_smallPictureBox.ErrorImage;
                }
            }
        }

        private void linkCheckins_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxCheckins.Items.Clear();
            new Thread(fetchCheckins).Start();
        }

        private void fetchCheckins()
        {
            var allCheckins = ViewModel.LoggedInUser.Checkins;
            listBoxCheckins.Invoke(new Action(
                () =>
                {
                    foreach (Checkin checkin in allCheckins)
                    {
                        listBoxCheckins.Items.Add(string.Format("{0}, {1}, {2}", checkin.Place.Name, checkin.Place.Location.City, checkin.CreatedTime));
                    }
                }
                                             )
                                  );
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //listBoxEvents.Items.Clear();
            this.eventBindingSource.DataSource = ViewModel.GetUserEvents(ViewModel.LoggedInUser);
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;

            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            listBoxFilteredStatuses.Items.Clear();
            labelStatusOwnerName.Text = null;
            pictureBoxStatusOwner.Image = null;

            List<Status> resStatuses = ViewModel.GetFriendsStatus(textBoxFilterFriendsStatuses.Text);

            listBoxFilteredStatuses.Items.AddRange(resStatuses.ToArray());
            this.labelNumberOfStatusesText.Text = string.Format(
               "The number of friends statuses that contains the filter text is {0}",
               listBoxFilteredStatuses.Items.Count);
            this.labelChooseStatus.Text = "Click on a status to see the the friend who wrote it";
        }

        private void listBoxFilteredStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayFriendOfSelectedStatus();
        }

        private void displayFriendOfSelectedStatus()
        {
            if (listBoxFilteredStatuses.SelectedItems.Count == 1)
            {
                User selectedFriend = ViewModel.GetStatusOwner((Status)listBoxFilteredStatuses.SelectedItem);
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxStatusOwner.LoadAsync(selectedFriend.PictureNormalURL);
                    labelStatusOwnerName.Text = selectedFriend.Name;
                }
                else
                {
                    picture_smallPictureBox.Image = picture_smallPictureBox.ErrorImage;
                }
            }
        }

        private void buttonEventFilter_Click(object sender, EventArgs e)
        {
            listFriendsEventsFiltered.Items.Clear();
            labelEventName.Text = null;
            pictureBoxEventOfFriend.Image = null;
            listBoxGoingFriends.Items.Clear();
            pictureBoxGoingFriend.Image = null;
            textBoxEventDescription.Text = null;

            List<ListViewItem> resEventList = ViewModel.GetFriendsEvent(textBoxFriendsEventFilter.Text);

            listFriendsEventsFiltered.Items.AddRange(resEventList.ToArray());
        }

        private void listFriendsEventsFiltered_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxGoingFriends.Items.Clear();
            pictureBoxGoingFriend.Image = null;
            if (listFriendsEventsFiltered.SelectedItems.Count == 1)
            {
                int friendsGoingToEvent = 0;
                Event fbEvent = (Event)listFriendsEventsFiltered.SelectedItems[0].Tag;
                labelEventName.Text = fbEvent.Name;
                textBoxEventDescription.Text = fbEvent.Description;
                pictureBoxEventOfFriend.LoadAsync(fbEvent.PictureNormalURL);
                IEnumerator<User> attendingUsers = fbEvent.AttendingUsers.GetEnumerator();
                while (attendingUsers.MoveNext())
                {
                    foreach (User friend in ViewModel.LoggedInUser.Friends)
                    {
                        if (friend.Name == attendingUsers.Current.Name)
                        {
                            friendsGoingToEvent++;
                            listBoxGoingFriends.Items.Add(attendingUsers.Current);
                        }
                    }
                }
            }
        }

        private void listBoxGoingFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend(listBoxGoingFriends, pictureBoxGoingFriend);
        }

        private void buttonJoinEvent_Click(object sender, EventArgs e)
        {
            if (listFriendsEventsFiltered.SelectedItems.Count == 1)
            {
                Event fbEvent = (Event)listFriendsEventsFiltered.SelectedItems[0].Tag;

                if (fbEvent.Privacy.Equals(Event.ePrivacy.Open) && fbEvent.Respond(Event.eRsvpType.Attending))
                {
                    MessageBox.Show("You have joined this event");
                }
                else
                {
                    MessageBox.Show("You cannot join this event");
                }
            }
        }
    }
}
