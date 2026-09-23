using System.ComponentModel.DataAnnotations;

namespace EmployeeWebAPI.DBModel
{
    public class EmployeeDBModel
    {
        [Key]
        public int employee_id { get; set; }
        public int company_id { get; set; }
        public string? employee_name { get; set; }
        public string? country { get; set; }
        public string? state { get; set; }
        public string? zipcode { get; set; }

        //banking_details{
        //    type,
        //	IFSC_code,
        //	Account_Number,
        //	Employee_Benificiary_Name,
        //},
        //ID_Proofs {
        //    aadhar/gov.ID Card,
        //	ID_Type,
        //	Nationality,
        //},
        public int created_by { get; set; }
        public DateTime? created_date { get; set; }
        public int? updated_by { get; set; }
        public DateTime? updated_date { get; set; }
        public int authorized_admin { get; set; }
        //public Roles roles { get; set; }
        //public Rights rights { get; set; }
        //public List<Asset> Assets { get; set; }
        public DateTime? lastLoginDate { get; set; }
        public TimeOnly? lastLoginTime { get; set; }
        public DateTime? dateOfJoining { get; set; }
        public string? yearsOfExperiance { get; set; }
    }
}
