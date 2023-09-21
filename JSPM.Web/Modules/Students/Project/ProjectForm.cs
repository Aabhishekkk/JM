using Serenity.ComponentModel;
using System;
namespace JSPM.Students.Forms;

[FormScript("Students.Project")]
[BasedOnRow(typeof(ProjectRow), CheckNames = true)]
public class ProjectForm
{
    public int StudentId { get; set; }
    public string Type { get; set; }
    public string ProjectTitle { get; set; }
    public string ProjectDetails { get; set; }
    public string ProjectReport { get; set; }
    public int DepartmentId { get; set; }
    public int SemesterId { get; set; }

}