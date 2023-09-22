using Serenity.ComponentModel;
using System;

namespace JSPM.Examinations.Forms;

[FormScript("Examinations.ExamSections")]
[BasedOnRow(typeof(ExamSectionsRow), CheckNames = true)]
public class ExamSectionsForm
{
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public Guid ExamId { get; set; }
    public string Instructions { get; set; }
    public int SectionDurationInSeconds { get; set; }
    public int NumberOfQuestions { get; set; }
    public int NumberofMandatoryQuestions { get; set; }
}