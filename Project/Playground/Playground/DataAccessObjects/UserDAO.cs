using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Playground.Models.User;
using System.Collections;
using System.Data.SqlClient;
using Playground.Helpers;

namespace Playground.DataAccessObjects
{
    public class UserDAO
    {
        Playground.Helpers.MSSQLHelper oMSSQLHelper = new Playground.Helpers.MSSQLHelper();

        public UserDAO() { }

        public List<UserResponseModel> UserRead() {
            string _SQL = "SELECT * FROM users";
            SqlDataReader _oSqlDataReader = oMSSQLHelper.Query(_SQL);
            List<UserResponseModel> _oUserResponseModel = _oSqlDataReader.map_data_reader_to_object_list<UserResponseModel>();

            // approach 2
            // logic here to map _oSqlDataReader to _oUserResponseModel
            //while (_oSqlDataReader.Read()) {
            // string _dataType = _oSqlDataReader.GetDataTypeName(_oSqlDataReader.GetOrdinal("id"));
            // var _id = _oSqlDataReader.GetValue(_oSqlDataReader.GetOrdinal("id")); // (Guid)_oSqlDataReader.GetValue(0);
            //  _oUserResponseModel.id = _id;
            //}
            return _oUserResponseModel;
        }

    }
}
