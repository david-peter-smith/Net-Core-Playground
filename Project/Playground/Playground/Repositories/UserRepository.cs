using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Playground.Models;

namespace Playground.Repositories
{
    public abstract class UserRepository
    {
        public abstract bool UserCreate(UserModel oUserModel);
        public abstract UserModel UserRead();
        public abstract bool UserUpdate(UserModel oUserModel);
        public abstract bool UserDelete(Guid oUserGuid);

    }
}
