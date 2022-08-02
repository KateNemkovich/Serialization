using System.Runtime.Serialization;

namespace Serialization;

[DataContract]
public class Student
{
   
    public Student(string name, int age)
    {
        //Проверка входных параметров.
        Name = name;
        Age = age;
    }
    [DataMember]
    public string Name { get; set; }
    
    [DataMember]
    public int Age { get; set; }
    
    [DataMember]
    public Group Group { get; set; }

    public override string ToString()
    {
        return Name;
    }
}