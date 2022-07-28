namespace Serialization;

[Serializable]
public class Group
{
    [NonSerialized]
    private readonly Random rnd = new(DateTime.Now.Millisecond);

    private int privateint;
    
    public Group()
    {
        Number = rnd.Next(1, 10);
        Name = "Группа" + rnd;
    }

    public Group(int number, string name)
    {
        //Проверка входных данных
        Number = number;
        Name = name;
    }

    public int Number { get; set; }
    public string Name { get; set; }

    public  void SetPrivet(int i)
    {
        
    }
    
    public override string ToString()
    {
        return Name;
    }
}