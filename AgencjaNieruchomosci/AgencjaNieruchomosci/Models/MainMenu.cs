using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AgencjaNieruchomosci.Models
{
    public class MainMenu
    {
        
        

        public MainMenu()
        {

        }

        public static List<String> PrzeszukajBD(String szukana)
        {
            SqlDataAdapter sda;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\workspace\PwS.NET-AgencjaNieruchomosci-MVC\AgencjaNieruchomosci\AgencjaNieruchomosci\App_Data\BazaDanych.mdf;Integrated Security=True");
            SqlCommand Sq;

            sda = new SqlDataAdapter("select count(*) from LISTING where HLCN='" + szukana + "'", conn);
            DataTable dtt = new DataTable();
            sda.Fill(dtt);

            if (dtt.Rows[0][0].ToString() == "1")
            {
                sda = new SqlDataAdapter("select * from LISTING where HLCN='" + szukana + "'", conn);
                DataTable dttt = new DataTable();
                sda.Fill(dttt);

                List<String> rezultat = new List<String>();
                string IDL = Convert.ToString(dttt.Rows[0][0]);

                for (int i = 1; i < dttt.Columns.Count; i++)
                {
                    rezultat.Add(Convert.ToString(dttt.Rows[0][i]));
                }

                return rezultat;
            }
            else
            {
                return null;
            }
        }
    }
}