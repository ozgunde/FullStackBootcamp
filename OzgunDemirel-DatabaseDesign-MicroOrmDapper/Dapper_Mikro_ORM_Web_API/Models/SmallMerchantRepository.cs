using Dapper;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper_Mikro_ORM_Web_API.Models
{
    public class SmallMerchantRepository
    {
        private string connect; //to connect the database

        public SmallMerchantRepository()
        {
            connect = @"Data Source=(localdb)\Özgün;Initial Catalog=OzgunFirstDB;Integrated Security=True";
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connect);
            }

        }

        //Insert
        public void Add(SmallMerchant smallmerchant)
        {
            using (IDbConnection dbConnection = Connection)

            {
            string sql = @"INSERT INTO MerchantProp (MerchantNumber, MerchantName, MerchantAddress, MerchantContact, TransactionAmount) 
                           VALUES (@MerchantNumber, @MerchantName, @MerchantAddress, @MerchantContact, @TransactionAmount)";
            dbConnection.Open();
            dbConnection.Execute(sql, smallmerchant);
            }
        }

        // Get By ID
        public SmallMerchant GetByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sql = @"SELECT *FROM MerchantProp WHERE MerchantNumber = @id";

                dbConnection.Open();
                return dbConnection.Query<SmallMerchant>(sql, new { id = id }).FirstOrDefault();
            }
        }
    }
}
