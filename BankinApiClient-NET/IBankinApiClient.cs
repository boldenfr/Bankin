using System;
using System.Collections.Generic;
using BankinApi.Client.Models;

namespace BankinApi.Client
{
    public interface IBankinApiClient : IDisposable
    {
        User CreateUser(User user);
        AuthenticatedUser Authenticate(User user);
        void LogOut(AuthenticatedUser user);
        object DeleteAllUsers();
        List<Bank> GetBanks();
        Bank GetBank(long id);
        string Connect(long bankId, string accessToken, string redirectUrl = null);
        List<Item> GetItems();
        Item GetItem(long id);
        string EditItem(long itemId, string accessToken, string redirectUrl = null);
        RefreshStatus GetItemResRefreshStatus(long itemId, string authToken);
        List<Transaction> GetTransactions();
        List<Category> GetCategories();
        Category GetCategory(long categoryId);
        PagedArrayResult<Account> GetAccounts();
        Account GetAccount(long id);
        void SendMfa(long itemId, string otp);
    }
}
