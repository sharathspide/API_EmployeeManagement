using System.ComponentModel.DataAnnotations;
using System.Net;

namespace EmployeeWebAPI.Model
{
	/// <summary>
	/// Data Model for the Employee CRUD activity
	/// NOTE: Commented Lines below represent Future Actions/ Enhancements
	/// </summary>
    public class Employee_Model
    {
		[Key]
        public int employee_id { get; set; }
		public int company_id {  get; set; }
		public string? employee_name { get; set; }
		public Address? address { get; set; }
		public string? country { get; set; }
		public string? state {  get; set; }
		public string? zipcode { get; set; }
		public Contact? contact_number { get; set; }

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
		public int? updated_by {  get; set; }
		public DateTime? updated_date { get; set; }
		public int authorized_admin {  get; set; }
		//public Roles roles { get; set; }
		//public Rights rights { get; set; }
		//public List<Asset> Assets { get; set; }
		public DateTime? lastLoginDate { get; set; }
		public TimeOnly? lastLoginTime { get; set; }
		public DateTime? dateOfJoining { get; set; }
		public string? yearsOfExperiance { get; set; }
		//public Attendance employeeAttendance { get; set; }
    }

	
	
}
