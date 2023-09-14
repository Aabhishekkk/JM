using Serenity.ComponentModel;

namespace JSPM.Syllabus.Forms;

[FormScript("Syllabus.Chapters")]
[BasedOnRow(typeof(ChaptersRow), CheckNames = true)]
public class ChaptersForm
{
    public int SubjectId { get; set; }
    public string ChapterName { get; set; }
    public string Description { get; set; }
    public int Index { get; set; }
}