using UnityEngine;

public interface QuackBehavior
{
    public void Quack();
}

public class DefaultQuack : QuackBehavior
{
    public void Quack()
    {
        Debug.Log("��");
    }
}

public class MuteQuack : QuackBehavior
{
    public void Quack()
    {
        Debug.Log("<< ����~ >>");
    }
}

public class Squeak : QuackBehavior
{
    public void Quack()
    {
        Debug.Log("��");
    }
}
