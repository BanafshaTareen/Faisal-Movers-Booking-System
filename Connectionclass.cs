using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faisal_Movers_Booking_System
{
    public class Connectionclass
    {
        
            public static SqlConnection GetConnection()
            {
                return new SqlConnection(
                    @"Data Source=LAPTOP-2J3A2MB0;Initial Catalog=FaisalMovers;Integrated Security=True");
            }
        

    }
}
