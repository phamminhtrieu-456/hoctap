using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Data.SqlClient;
using login.Models;

namespace login.Models
{
    public class QLTK
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        /*public int kiemtra(truyvan truyvan) 
        {
            SqlCommand cmd = new SqlCommand("QLTK", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("account", truyvan.account);
            cmd.Parameters.AddWithValue("password",truyvan.password);

        }*/
    }
}
