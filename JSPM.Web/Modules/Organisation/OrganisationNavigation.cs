using Serenity.Navigation;
using MyPages = JSPM.Organisation.Pages;

[assembly: NavigationLink(int.MaxValue, "Organisation/Institute", typeof(MyPages.InstitutePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Organisation/Departments", typeof(MyPages.DepartmentsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Organisation/Branches", typeof(MyPages.BranchesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Organisation/Academic Years", typeof(MyPages.AcademicYearsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Organisation/Semesters", typeof(MyPages.SemestersPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Organisation/Division", typeof(MyPages.DivisionPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Organisation/Batches", typeof(MyPages.BatchesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Organisation/Group", typeof(MyPages.GroupPage), icon: null)]