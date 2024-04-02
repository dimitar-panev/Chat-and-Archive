namespace Program;

class ArchiveMessage // Прави се за архива.
{
    public Person Sender { get; set; }
    public string Content { get; set; } // Правим гетъри и сетъри, за да могат да бъдат достъпени в конструктора.

    public ArchiveMessage(Person sender, string content)
    {
        Sender = sender;
        Content = content;
    }
}