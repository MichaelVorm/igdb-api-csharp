using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class UserProfileService : IUserProfileService
    {
        private IApiClient _apiClient;

        public UserProfileService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public UserProfile GetUserProfileById(int id)
        {
            string requestUri = string.Format("/me/{0}?fields=*", id);
            var userProfile = _apiClient.Get<List<UserProfile>>(requestUri).Result;

            return userProfile[0];
        }

        public List<UserProfile> SearchUserProfilesByName(string name)
        {
            string requestUri = string.Format("/me/?search={0}&fields=*", name);
            var userProfiles = _apiClient.Get<List<UserProfile>>(requestUri).Result;

            return userProfiles;
        }
    }
}
