namespace Program;

class Program
{
    static void Main(string[] args)
    {
        // Да има клас Person, да има две деца - student и teacher, Student пише на teacher, teacher връща отговор.
        // Всичките съобщения трябва да се съхраняват в архив.
        
        
        Console.Write("Enter the teacher's first name: ");
        string teacherFirstName = Console.ReadLine();
        Console.WriteLine("Enter the teacher's last name: "); // Въвеждаме име и фамилия на преподавателя
        string teacherLastName = Console.ReadLine();

        Console.Write("Enter the student's first name: ");
        string studentFirstName = Console.ReadLine();
        Console.WriteLine("Enter the student's last name: "); // Въвеждаме име и фамилия на студента
        string studentLastName = Console.ReadLine();

        List<ArchiveMessage> chatArchive = new List<ArchiveMessage>(); // Създаваме лист, за да може да направим архив със съобщенията
        
        var student = new Student(studentFirstName, studentLastName);
        var teacher = new Teacher(teacherFirstName, teacherLastName); //Правим нова променлива студент и преподавател, за да може след като се съхранят, да може да се извикат директно от класовете.
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Welcome, {teacher.FirstName} {teacher.LastName} to the chat room!");
        Console.WriteLine($"{teacher.FirstName}, you are now chatting with {student.FirstName} {student.LastName}");
        Console.WriteLine($"Type 'exit' to stop chatting(Both persons need to type exit)");
        while (true) // създаваме while, за да може двамата да си комуникират и за да има някакъв начин чатът да спре(или съобщение след всеки два отговора, или просто, като се напише exit)
        {
            Console.Write($"{student.FirstName} (student): ");
            string studentMessage = Console.ReadLine();
            chatArchive.Add(new ArchiveMessage(student, studentMessage)); //list

            Console.Write($"{teacher.FirstName}(teacher): ");
            string teacherReply = Console.ReadLine();
            chatArchive.Add(new ArchiveMessage(teacher, teacherReply));//list
            
            if (teacherReply == "exit") // Програмата свършва, когато се въведе exit..
            {
                break;
            }
            else
            {
                Console.WriteLine("bad input");
            }
        }
        
        
        Console.WriteLine("\nArchive of the messages:"); // правим архив със въведените съобщения
        foreach (var message in chatArchive)
        {
            Console.WriteLine($"{message.Sender.FirstName}: {message.Content}"); // Отпечатва името на двамата и съобщенията(всичко).
        }
    }
}