namespace Program;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; } // Правим гетъри и сетъри, за да могат да бъдат достъпени в конструктора.

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

