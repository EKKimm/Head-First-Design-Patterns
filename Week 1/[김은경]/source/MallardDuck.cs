using UnityEngine;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        quackBehavior = new DefaultQuack();
        flyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
        Debug.Log("���� �������Դϴ�");
    }
}
