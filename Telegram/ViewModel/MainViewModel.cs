using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Model;

namespace Telegram.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }    
        public ObservableCollection<ContactModel> ContactModel { get; set; }
        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            ContactModel = new ObservableCollection<ContactModel>();
            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username="Elchin",
                    UsernameColor="#409aff",
                    ImageSource="https://images.unsplash.com/photo-1503023345310-bd7c1de61c7d?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8aHVtYW58ZW58MHx8MHx8&w=1000&q=80",
                    Message="Test",
                    Time=DateTime.Now,
                    IsNativeOrigin=false,
                    FirstMessage=true

                });
            }

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username="Islam",
                    UsernameColor="#409aff",
                    ImageSource="https://www.unigreet.com/wp-content/uploads/2022/11/100-very-special-good-morning-images-quotes-photos.jpg",
                    Message="Last",
                    Time=DateTime.Now,
                    IsNativeOrigin=true,
                });
            }

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username="Rustam",
                    UsernameColor="#409aff",
                    ImageSource="https://gratisography.com/wp-content/uploads/2023/02/gratisography-colorful-kittenfree-stock-photo-800x525.jpg",
                    Message="Last",
                    Time=DateTime.Now,
                    IsNativeOrigin=true,
                });
            }

        }
    }
}
