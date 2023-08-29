using UnityEngine;

public abstract class Duck
{
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehavior;

    public Duck()
    {

    }

    public abstract void Display();

    public void SetFlyBehavior(IFlyBehavior fb)
    {
        flyBehavior = fb;
    }

    public void SetQuackBehavior(IQuackBehavior qb)
    {
        quackBehavior = qb;
    }

    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    public void PerformQuack()
    {
        quackBehavior.Quack();
    }

    public void Swim()
    {
        Debug.Log("��� ������ ���� ��ϴ�. ��¥ ������ ����");
    }
}
