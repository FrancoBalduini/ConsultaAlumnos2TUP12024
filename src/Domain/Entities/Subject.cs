namespace ConsultaAlummos2TUP12024.Domain.Entities;

public class Subject
{
    public int Id { get; set; }

    public string Name { get; set; }


    public Subject(string name)
    {
        Name = name;
    }
}

