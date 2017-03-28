using System.Collections.Generic;
using BankinApi.Client.Models;

namespace BankinApi.Client
{
    public partial class ApiClient
    {
        public User CreateUser(User user)
        {
            var queryParams = new Dictionary<string, string> {{"email", user.Email}, {"password", user.Password}};
            var uri = CreateUri("users", queryParams);
            var result = PostAsync<object, User>(uri, null);
            result.Password = user.Password;
            return result;
        }

        public AuthenticatedUser Authenticate(User user)
        {
            var queryParams = new Dictionary<string, string> { { "email", user.Email }, { "password", user.Password } };
            var uri = CreateUri("authenticate", queryParams);
            var authenticatedUser = PostAsync<object, AuthenticatedUser>(uri, null);
            AddRequestHeader("Authorization", "Bearer " + authenticatedUser.AccessToken);
            return authenticatedUser;
        }

        public void LogOut(AuthenticatedUser user)
        {
            var uri = CreateUri("logout", null);
            PostAsync<object, object>(uri, null);
            RemoveRequestHeader("Authorization");
        }
        
        public object DeleteAllUsers()
        {
            var uri = CreateUri("users", null);
            return DeleteAsync<object>(uri);
        }
    }
}
