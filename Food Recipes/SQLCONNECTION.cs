using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Food_Recipes
{
    class SQLCONNECTION
    {
        public SqlConnection cs;

        public void Connection()
        {
            cs = new SqlConnection("Data Source=DESKTOP-AM7OELU\\MYSQLSERVER;Initial Catalog=FoodRecipes;Integrated Security=True");
        }
    }
}
