using Serenity.ComponentModel;
using System.ComponentModel;

namespace JSPM.Syllabus.Columns;

[ColumnsScript("Syllabus.Topics")]
[BasedOnRow(typeof(TopicsRow), CheckNames = true)]
public class TopicsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string SubjectName { get; set; }
    public string ChapterName { get; set; }
    [EditLink]
    public string TopicName { get; set; }
    public string Description { get; set; }
    public int Index { get; set; }
}