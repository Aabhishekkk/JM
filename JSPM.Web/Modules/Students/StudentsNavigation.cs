using Serenity.Navigation;
using MyPages = JSPM.Students.Pages;

[assembly: NavigationLink(int.MaxValue, "Students/Personal", typeof(MyPages.PersonalPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Students/Project", typeof(MyPages.ProjectPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Students/Skills", typeof(MyPages.SkillsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Students/Teacher Endorsement", typeof(MyPages.TeacherEndorsementPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Students/Institute Academic", typeof(MyPages.InstituteAcademicPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Students/Academic Subject Level", typeof(MyPages.AcademicSubjectLevelPage), icon: null)]