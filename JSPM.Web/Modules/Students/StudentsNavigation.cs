using Serenity.Navigation;
using MyPages = JSPM.Students.Pages;

[assembly: NavigationLink(int.MaxValue, "Students/Personal", typeof(MyPages.PersonalPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Students/StudentsSkills", typeof(MyPages.StudentsSkillsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Students/Teacher Endorsement", typeof(MyPages.TeacherEndorsementPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Students/Institute Academic", typeof(MyPages.InstituteAcademicPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Students/Academic Subject Level", typeof(MyPages.AcademicSubjectLevelPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Students/Academic", typeof(MyPages.AcademicPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Students/Academics", typeof(MyPages.AcademicsPage), icon: null)]