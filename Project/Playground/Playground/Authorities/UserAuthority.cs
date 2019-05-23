using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Playground.Repositories;
using Playground.Models.User;

namespace Playground.Authorities
{
    public class UserAuthority
    {
        private UserRepository _UserRepository = null;

        public UserAuthority(UserRepository oUserRepository) {
            this._UserRepository = oUserRepository;
        }

        public bool UserCreate(UserRequestModel oUserRequestModel) {
            bool _result = false;
            if (oUserRequestModel == null) {
                throw new ArgumentNullException("oUserRequestModel", "UserRequestModel must be populated.");
            }
            _result = this._UserRepository.UserCreate(oUserRequestModel);
            return _result;
        }

    }
}
