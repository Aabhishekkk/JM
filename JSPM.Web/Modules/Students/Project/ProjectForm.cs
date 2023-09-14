using Serenity.ComponentModel;

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
}