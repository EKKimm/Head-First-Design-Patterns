using UnityEngine;

public interface FlyBehavior
{
    public void Fly();
}

public class FlyWithWings : FlyBehavior
{
    public void Fly()
    {
        Debug.Log("���� �־��!!");
    }
}

public class FlyNoWay : FlyBehavior
{
    public void Fly()
    {
        Debug.Log("���� �� ���ƿ�");
    }
}

public class FlyRocketPowered : FlyBehavior
{
    public void Fly()
    {
        Debug.Log("���� �������� ���󰩴ϴ�");
    }
}