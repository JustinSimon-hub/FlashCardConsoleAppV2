// See https://aka.ms/new-console-template for more information
//set up sql server for vs code mac

//added sqlserver package  

//next configure docker and azure data studio to this program

//watch this vid to connect to azure data studiogit init

//https://www.google.com/search?sca_esv=ebfe579d5b8c900a&q=sql+server+mac&tbm=vid&source=lnms&prmd=ivnsmbt&sa=X&ved=2ahUKEwjDl8vLnJiGAxV5D0QIHTJTCZ4Q0pQJegQIExAB&biw=1090&bih=791&dpr=1.8#fpstate=ive&vld=cid:ac0bea9a,vid:3BFxALltQaM,st:0 

using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace FlashCardConsoleApp
{


    class Program
    {
        
            static void Main(string[] args)
            {
                //REMEMBER TO GET CONN STRING FROM AZURE STUDIOS
                string connectionString = "CONNECTION STRING INSERTED HERE LATER FROM AZURE STUDIOS";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                       
                    
                }
                



            }
    }
}