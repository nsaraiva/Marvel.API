using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppClient
{
    public partial class ApiClient
    {
        public async Task<List<Data>> GetUsers()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "User/GetAllUsers"));
            return await GetAsync<List<UsersModel>>(requestUrl);
        }

        public async Task<Message<UsersModel>> SaveUser(UsersModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "User/SaveUser"));
            return await PostAsync<UsersModel>(requestUrl, model);
        }
    }


}
