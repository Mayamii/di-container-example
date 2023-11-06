public interface IFooService
{
    void Foo();
}

public interface IBarService
{
    void Bar();
}

public interface IBlaService
{
    void Bla();
}

public class FooService : IFooService
{
    public FooService()
    {
        Console.WriteLine("ctor fooService");
    }

    public void Foo()
    {
        System.Console.WriteLine("foo");
    }
}


public class BarService : IBarService
{
    public BarService()
    {
        Console.WriteLine("ctor BarService");
    }

    public void Bar()
    {
        System.Console.WriteLine("bar");
    }
}


public class BlaService : IBlaService
{

    private readonly IFooService Foo;
    private readonly IBarService Bar;
    public BlaService(IFooService foo, IBarService bar)
    {
        Console.WriteLine("ctor blaService");
        Foo = foo;
        Bar = bar;
    }

    public void Bla()
    {
        this.Foo.Foo();
        this.Bar.Bar();
        System.Console.WriteLine("bla");
    }
}