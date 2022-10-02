using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class AddFriendView
    {
        UserService userService;
        public AddFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var userAddFriendData = new UserAddFriendData();

                Console.Write("Введите Email пользователя которого хотите добавить в друзья: ");

                userAddFriendData.FriendEmail = Console.ReadLine();
                userAddFriendData.UserId = user.Id;

                this.userService.AddFriend(userAddFriendData);

                SuccessMessage.Show("Пользователь добавлен в друзья!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь с указанным Email не найден!");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произоша ошибка при добавлении пользователя в друзья!");
            }

        }
    }
}
