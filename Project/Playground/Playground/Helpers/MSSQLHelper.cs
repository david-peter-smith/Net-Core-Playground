﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Playground.Helpers
{
    public class MSSQLHelper
    {
        private SqlConnection _SqlConnection;
        private string _parameter_prefix = "(@";
        private string _parameter_suffix = ")";


        public bool IsConnected() {
            bool _result = false;
            if (this._SqlConnection.State == System.Data.ConnectionState.Open) {
                _result = true;
            }
            return _result;
        }

        public void Connect(string ConnetionString) {
            if (!this.IsConnected()) {
                if (String.IsNullOrEmpty(ConnetionString)) {
                    throw new ArgumentException("Parameter 'SQL' may not be null or empty.", "SQL");
                }
                this._SqlConnection = new SqlConnection(ConnetionString);
                this._SqlConnection.Open();
            }
        }

        public SqlDataReader Query(string SQL)
        {
            SqlDataReader _SqlDataReader = null;
            if (String.IsNullOrEmpty(SQL)) {
                throw new ArgumentException("Parameter 'SQL' may not be null or empty.", "SQL");
            }
            SqlCommand _SqlCommand = new SqlCommand(SQL, this._SqlConnection);
            _SqlDataReader = _SqlCommand.ExecuteReader();
            return _SqlDataReader;
        }

        public SqlDataReader Query(string SQL, Hashtable ParametersList)
        {
            SqlDataReader _SqlDataReader = null;
            if (String.IsNullOrEmpty(SQL)) {
                throw new ArgumentException("Parameter 'SQL' may not be null or empty.", "SQL");
            }
            if (ParametersList.Count <= 0) {
                throw new ArgumentException("Parameter 'ParametersList' may not be null or empty.", "ParametersList");
            }
            SqlCommand _SqlCommand = new SqlCommand(SQL, this._SqlConnection);
            foreach (string ParamName in ParametersList.Keys) {
                if (!String.IsNullOrEmpty(ParamName) && !String.IsNullOrEmpty(ParamName.Trim())) {
                    _SqlCommand.Parameters.AddWithValue(
                        (this._parameter_prefix + ParamName + this._parameter_suffix)
                        , ParametersList[ParamName]
                    );
                }
            }
            _SqlDataReader = _SqlCommand.ExecuteReader();
            return _SqlDataReader;
        }
        public int Execute(string SQL)
        {
            int _rows_affected = 0;
            if (String.IsNullOrEmpty(SQL)) {
                throw new ArgumentException("Parameter 'SQL' may not be null or empty.", "SQL");
            }
            SqlCommand _SqlCommand = new SqlCommand(SQL, this._SqlConnection);
            _rows_affected = _SqlCommand.ExecuteNonQuery();
            return _rows_affected;
        }

        public int Execute(string SQL, Hashtable ParametersList)
        {
            int _rows_affected = 0;
            if (String.IsNullOrEmpty(SQL)) {
                throw new ArgumentException("Parameter 'SQL' may not be null or empty.", "SQL");
            }
            if (ParametersList.Count <= 0) {
                throw new ArgumentException("Parameter 'ParametersList' may not be null or empty.", "ParametersList");
            }            
            SqlCommand _SqlCommand = new SqlCommand(SQL, this._SqlConnection);
            foreach (string ParamName in ParametersList.Keys)
            {
                if (!String.IsNullOrEmpty(ParamName) && !String.IsNullOrEmpty(ParamName.Trim()))
                {
                    _SqlCommand.Parameters.AddWithValue(
                        (this._parameter_prefix + ParamName + this._parameter_suffix)
                        , ParametersList[ParamName]
                    );
                }
            }
            _rows_affected = _SqlCommand.ExecuteNonQuery();
            return _rows_affected;
        }
    }

}
