using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Syllabus.Columns;

[ColumnsScript("Syllabus.Chapters")]
[BasedOnRow(typeof(ChaptersRow), CheckNames = true)]
public class ChaptersColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string SubjectName { get; set; }
    [EditLink]
    public string ChapterName { get; set; }
    public string Description { get; set; }
    public int Index { get; set; }
}