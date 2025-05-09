using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU.C969.SoftwareII.Tools
{
    public class Appointment
    {
        public static void AddAppointment(DateTime start, DateTime end, string user, string customerName, string location, string contact, string type, string title, string desc)
        {

        }

        internal static bool CheckAvailability(DateTime start, DateTime end, string user)
        {
            throw new NotImplementedException();
        }

        internal static bool CheckBusinessHours(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
