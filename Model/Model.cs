namespace Model
{
        public class Report
        {
            public int reportId { get; set; }
            public int id { get; set; }
            public string reportTitle { get; set; }
            public string reportDescription { get; set; }
            public string priority { get; set; }
            public string status { get; set; }
            public string notes { get; set; }
            // public string attch { get; set; }
        }
        public class User
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public string email { get; set; }
            public string password { get; set; }
        }
        public class Roles
        {
            public int roleId { get; set; }
            public string roleName { get; set; }
        }
}
