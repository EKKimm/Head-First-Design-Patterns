using UnityEngine;

public interface IFlyBehavior
{
    public void Fly();
}

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("���� �־��!!");
    }
}

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("���� �� ���ƿ�");
    }
}

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("���� �������� ���󰩴ϴ�");
    }
}