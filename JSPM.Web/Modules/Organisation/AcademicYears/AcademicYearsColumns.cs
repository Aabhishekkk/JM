using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace JSPM.Organisation.Columns;

[ColumnsScript("Organisation.AcademicYears")]
[BasedOnRow(typeof(AcademicYearsRow), CheckNames = true)]
public class AcademicYearsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public String AcademicYear { get; set; }
    public int Index { get; set; }
}