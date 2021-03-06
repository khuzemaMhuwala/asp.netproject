﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ImanHusseinPizza.App_Code
{
    public class OrderUti
    { 
           public string OrderId { get; set; }
    public string UserName { get; set; }
    public string PizzaSize { get; set; }
    public string PizzaStyle { get; set; }
    public string Toppings { get; set; }
    public double Price { get; set; }
    public string OrderTime { get; set; }
    public string Delivery_ID { get; set; }

    public void insertOrder()
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["pizzaDBSummer2017"].ConnectionString);
        conn.Open();
        string qry = "insert into [Order] ( PizzaSize,PizzaStyle,Toppings,Price, UserName,Delivery_ID) values (@PizzaSize,@PizzaStyle,@Toppings, @Price, @UserName,@Delivery_ID)";
        SqlCommand cmd = new SqlCommand(qry, conn);
        cmd.Parameters.AddWithValue("@UserName", UserName);
        cmd.Parameters.AddWithValue("@PizzaSize", PizzaSize);
        cmd.Parameters.AddWithValue("@PizzaStyle", PizzaStyle);
        cmd.Parameters.AddWithValue("@Toppings", Toppings);
        cmd.Parameters.AddWithValue("@Price", Price);
        cmd.Parameters.AddWithValue("@Delivery_ID", Delivery_ID);
        cmd.ExecuteNonQuery();
        conn.Close();
    }

}//close OrderUti class

}