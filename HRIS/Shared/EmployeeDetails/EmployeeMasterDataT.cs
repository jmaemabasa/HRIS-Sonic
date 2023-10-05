using HRIS.Shared.MasterData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRIS.Shared.EmployeeDetails
{
    public class EmployeeMasterDataT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        //Personal Details
        public int Id { get; set; }
        public string Verify_Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        //Division -> Department -> Section
        public DDivisionT D_DivisionT { get; set; }
        public int D_DivisionId { get; set; }

        public DDepartmentT D_DepartmentT { get; set; }
        public int D_DepartmentId { get; set; }

        public DSectionT D_SectionT { get; set; }
        public int D_SectionId { get; set; }
    }
}
