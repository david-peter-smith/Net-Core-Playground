using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Playground.Models.User;

namespace Playground.Repositories
{
    public abstract class UserRepository
    {
        public abstract bool UserCreate(UserRequestModel oUserRequestModel);
        public abstract UserResponseModel UserRead();
        public abstract bool UserUpdate(UserRequestModel oUserRequestModel);
        public abstract bool UserDelete(Guid oUserGuid);

    }
}
