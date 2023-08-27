using UnityEngine;

public interface IQuackBehavior
{
    public void Quack();
}

public class DefaultQuack : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("��");
    }
}

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("<< ����~ >>");
    }
}

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("��");
    }
}
