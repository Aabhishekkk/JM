using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Students.Columns;

[ColumnsScript("Students.TeacherEndorsement")]
[BasedOnRow(typeof(TeacherEndorsementRow), CheckNames = true)]
public class TeacherEndorsementColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public int TeacherId { get; set; }
    public string StudentFirstName { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string Details { get; set; }
}