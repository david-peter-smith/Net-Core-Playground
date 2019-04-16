using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Playground.Repositories;
using Playground.Models;

namespace Playground.Authorities
{
    public class UserAuthority
    {
        private UserRepository _UserRepository = null;

        public UserAuthority(UserRepository oUserRepository) {
            this._UserRepository = oUserRepository;
        }

        public void UserCreate(UserModel oUserModel) {
            if (oUserModel == null) {
                throw new ArgumentNullException("oUserModel");
            }
            this._UserRepository.UserCreate(oUserModel);
        }

    }
}
