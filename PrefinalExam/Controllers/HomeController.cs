using Microsoft.AspNetCore.Mvc;
using PrefinalExam.Models;

namespace PrefinalExam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Questions(int number = 1)
        {
            List<ExamQuestion> questions = GetQuestions();

            if (number < 1)
            {
                number = 1;
            }

            if (number > questions.Count)
            {
                number = questions.Count;
            }

            ExamQuestion currentQuestion = questions[number - 1];

            ViewBag.TotalQuestions = questions.Count;

            return View(currentQuestion);
        }


        private List<ExamQuestion> GetQuestions()
        {
            List<ExamQuestion> questions = new List<ExamQuestion>();


            // QUESTION 1 - Answered
            questions.Add(new ExamQuestion
            {
                Number = 1,

                Question = "What is the main problem solved by using a database instead of an in-memory collection?",

                OptionA = "It makes C# code shorter",

                OptionB = "It prevents the application from restarting",

                OptionC = "It allows data to persist after the application stops",

                OptionD = "It removes the need for MVC",

                SelectedAnswer = "C"
            });


            // QUESTION 2 - Answered
            questions.Add(new ExamQuestion
            {
                Number = 2,

                Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?",

                OptionA = "Code-First",

                OptionB = "Database-First",

                OptionC = "Model-First",

                OptionD = "Controller-First",

                SelectedAnswer = "B"
            });


            // QUESTION 3 - Answered
            questions.Add(new ExamQuestion
            {
                Number = 3,

                Question = "What is the primary purpose of Entity Framework Core?",

                OptionA = "To create HTML pages automatically",

                OptionB = "To replace the MVC Controller",

                OptionC = "To map objects in code to relational database data",

                OptionD = "To replace the C# compiler",

                SelectedAnswer = "B"
            });


            // QUESTION 4 - Answered
            questions.Add(new ExamQuestion
            {
                Number = 4,

                Question = "Which EF Core component is primarily responsible for communicating with the database?",

                OptionA = "DbContext",

                OptionB = "DbSetView",

                OptionC = "ControllerContext",

                OptionD = "RazorContext",

                SelectedAnswer = "A"
            });


            // QUESTION 5 - Answered
            questions.Add(new ExamQuestion
            {
                Number = 5,

                Question = "What does the dotnet ef dbcontext scaffold command primarily do?",

                OptionA = "Deletes the database",

                OptionB = "Creates a new MVC project",

                OptionC = "Generates EF Core models and a DbContext from an existing database",

                OptionD = "Starts the MVC application",

                SelectedAnswer = "C"
            });


            // QUESTION 6 - Answered
            questions.Add(new ExamQuestion
            {
                Number = 6,

                Question = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",

                OptionA = "Program.cs only",

                OptionB = "appsettings.json",

                OptionC = "Index.cshtml",

                OptionD = "Student.cs",

                SelectedAnswer = "B"
            });


            // QUESTION 7 - Answered
            questions.Add(new ExamQuestion
            {
                Number = 7,

                Question = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",

                OptionA = "One-to-One",

                OptionB = "One-to-Many",

                OptionC = "Many-to-Many",

                OptionD = "Many-to-One only",

                SelectedAnswer = "C"
            });


            // QUESTION 8 - Answered
            questions.Add(new ExamQuestion
            {
                Number = 8,

                Question = "In the following example, what is SectionId? public int SectionId { get; set; } public Section Section { get; set; }",

                OptionA = "Primary key of Student",

                OptionB = "Foreign key referencing Section",

                OptionC = "Navigation property",

                OptionD = "Database connection string",

                SelectedAnswer = "B"
            });


            // QUESTION 9 - Answered
            questions.Add(new ExamQuestion
            {
                Number = 9,

                Question = "What is the purpose of a navigation property such as public Section Section { get; set; }?",

                OptionA = "It stores the database password",

                OptionB = "It represents a relationship to another entity",

                OptionC = "It creates a new database",

                OptionD = "It validates the student's name",

                SelectedAnswer = "B"
            });


            // QUESTION 10 - Answered
            questions.Add(new ExamQuestion
            {
                Number = 10,

                Question = "What does .Include() generally allow EF Core to do?",

                OptionA = "Delete the Section table",

                OptionB = "Load related Section data together with Students",

                OptionC = "Create a new Student",

                OptionD = "Validate Student input",

                SelectedAnswer = "B"
            });


            // QUESTION 11 - Answered
            questions.Add(new ExamQuestion
            {
                Number = 11,

                Question = "Why might a ViewModel be used when displaying Student and Section information?",

                OptionA = "To replace the database",

                OptionB = "To combine or shape the data specifically needed by the view",

                OptionC = "To automatically create database tables",

                OptionD = "To prevent controllers from using LINQ",

                SelectedAnswer = "D"
            });


            // QUESTION 12 - Answered
            questions.Add(new ExamQuestion
            {
                Number = 12,

                Question = "Consider this query: var students = _context.Students.Include(s => s.Section).ToList(); What is the main benefit of Include(s => s.Section)?",

                OptionA = "It loads the related Section navigation property",

                OptionB = "It creates a Section object manually",

                OptionC = "It removes the foreign key",

                OptionD = "It prevents the query from accessing the database",

                SelectedAnswer = "A"
            });


            // QUESTION 13
            questions.Add(new ExamQuestion
            {
                Number = 13,

                Question = "Which type of validation occurs in the browser before a request is sent to the server?",

                OptionA = "Database-level validation",

                OptionB = "Client-side validation",

                OptionC = "Server-side validation",

                OptionD = "EF Core migration validation",

                SelectedAnswer = "B"
            });


            // QUESTION 14
            questions.Add(new ExamQuestion
            {
                Number = 14,

                Question = "Why is server-side validation still necessary if client-side validation exists?",

                OptionA = "Client-side validation can be bypassed",

                OptionB = "Client-side validation automatically modifies the database",

                OptionC = "Server-side validation only works with SQLite",

                OptionD = "Client-side validation cannot display messages",

                SelectedAnswer = "A"
            });


            // QUESTION 15
            questions.Add(new ExamQuestion
            {
                Number = 15,

                Question = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",

                OptionA = "Student Number should always be nullable",

                OptionB = "Student Number should be unique",

                OptionC = "Student Number should always be the same",

                OptionD = "Student Number should contain only spaces",

                SelectedAnswer = "B"
            });


            // QUESTION 16
            questions.Add(new ExamQuestion
            {
                Number = 16,

                Question = "Which is the best reason for having a database-level unique constraint on StudentNumber?",

                OptionA = "It protects data integrity even if application-level validation is bypassed",

                OptionB = "It makes Razor Views render faster",

                OptionC = "It removes the need for a Controller",

                OptionD = "It automatically creates a ViewModel",

                SelectedAnswer = "B"
            });


            // QUESTION 17
            questions.Add(new ExamQuestion
            {
                Number = 17,

                Question = "What is the purpose of a try...catch block in a controller?",

                OptionA = "To create navigation properties",

                OptionB = "To catch and handle exceptions that may occur during execution",

                OptionC = "To generate database tables",

                OptionD = "To perform client-side validation",

                SelectedAnswer = "B"
            });


            // QUESTION 18
            questions.Add(new ExamQuestion
            {
                Number = 18,

                Question = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?",

                OptionA = "UseDatabase()",

                OptionB = "UseExceptionHandler()",

                OptionC = "UseValidationHandler()",

                OptionD = "UseMvcDatabase()",

                SelectedAnswer = "B"
            });


            // QUESTION 19
            questions.Add(new ExamQuestion
            {
                Number = 19,

                Question = "A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?",

                OptionA = "Display the student's information anyway",

                OptionB = "Display a Not Found (404) response/page",

                OptionC = "Delete Student 999",

                OptionD = "Create Student 999 automatically",

                SelectedAnswer = "D"
            });


            // QUESTION 20
            questions.Add(new ExamQuestion
            {
                Number = 20,

                Question = "A student already belongs to Section A for a particular subject. The application attempts to assign the same student to Section A again. What is the primary concern?",

                OptionA = "Data integrity",

                OptionB = "HTML formatting",

                OptionC = "CSS inheritance",

                OptionD = "Razor syntax",

                SelectedAnswer = "A"
            });


            return questions;
        }
    }
}