using Serenity.ComponentModel;

namespace JSPM.Syllabus.Forms;

[FormScript("Syllabus.Topics")]
[BasedOnRow(typeof(TopicsRow), CheckNames = true)]
public class TopicsForm
{
    public int SubjectId { get; set; }
    public int ChapterId { get; set; }
    public string TopicName { get; set; }
    public string Description { get; set; }
    public int Index { get; set; }
}