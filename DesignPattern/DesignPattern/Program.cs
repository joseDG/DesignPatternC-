using DesignPattern._1_SingletonPattern;

class Program
{
    static void Main(string[] args)
    {
        var log = Log.Instance;
        log.Save("A");
        log.Save("B");
    }
}