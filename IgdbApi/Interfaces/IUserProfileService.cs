using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IUserProfileService
    {

        UserProfile GetUserProfileById(int id);
        List<UserProfile> SearchUserProfilesByName(string name);
    }
}
