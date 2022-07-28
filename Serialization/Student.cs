namespace Serialization;

[Serializable]
public class Student
{
    public Student(string name, int age)
    {
        //Проверка входных параметров.
        Name = name;
        Age = age;
    }

    public string Name { get; }
    public int Age { get; }

    public Group Group { get; set; }

    public override string ToString()
    {
        return Name;
    }
}