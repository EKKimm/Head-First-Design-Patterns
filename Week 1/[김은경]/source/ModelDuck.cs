using UnityEngine;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        flyBehavior = new FlyNoWay();
        quackBehavior = new DefaultQuack();
    }
    public override void Display()
    {
        Debug.Log("���� ���� �����Դϴ�");
    }
}
