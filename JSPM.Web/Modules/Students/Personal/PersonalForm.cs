using Serenity.ComponentModel;
using System;

namespace JSPM.Students.Forms;

[FormScript("Students.Personal")]
[BasedOnRow(typeof(PersonalRow), CheckNames = true)]
public class PersonalForm
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string Email { get; set; }
    public int MobileNumber { get; set; }
    public string Pnr { get; set; }
    public string PermanentAddress { get; set; }
    public string City { get; set; }
    public int Pin { get; set; }
    public string CurrentAddress { get; set; }
    public string CurrentCity { get; set; }
    public string Gender { get; set; }
    public DateTime Dob { get; set; }
    public DateTime AdmissionDate { get; set; }
    public int DepartmentId { get; set; }
    public int BranchId { get; set; }
    public int DivisionId { get; set; }
}