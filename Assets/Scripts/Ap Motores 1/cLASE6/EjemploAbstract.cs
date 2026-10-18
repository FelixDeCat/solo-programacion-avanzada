using UnityEngine;

public class EjemploAbstract : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // nivel Nativo
        MyClassNormal normal = new MyClassNormal();
        MyClassExample example = new MyHeritanceExample();

        HumanBase guard = new Guard();

        HumanBase[] aldeanos = new HumanBase[20];

        aldeanos[0] = new Miner();
        aldeanos[1] = new Miner();
        aldeanos[2] = new Miner();
        aldeanos[3] = new Guard();
        aldeanos[4] = new Guard();
        aldeanos[5] = new Guard();

        for (int i = 0; i < aldeanos.Length; i++)
        {
            aldeanos[i].Jump();
            aldeanos[i].GiveRations(20);
        }


        State idle = new IdleState();

        idle.BeginState();
    }

}

public class MyClassNormal
{

}

public abstract class MyClassExample /// restringido para la Instancia
{

}

public class MyHeritanceExample : MyClassExample
{

}

public abstract class HumanBase
{
    public int age;
    public string name;
    public bool isAlive;

    public void GiveRations(int ration)
    {

    }

    public abstract void Jump();
}


public class Guard : HumanBase
{
    public override void Jump()
    {
        // saltar 10 pies
    }
}
public class Miner : HumanBase
{
    public override void Jump()
    {
        // saltar 15 pies
    }
}
public class ZarazOficio : HumanBase
{
    public override void Jump()
    {
        // saltar 5 pies
    }
}



public class IdleState : State
{
    protected override void OnBegin()
    {
        
    }

    protected override void OnEnd()
    {
        
    }

    protected override void OnTick(float deltaTime)
    {
        
    }
}


public abstract class State
{

    ////// ACCESO PUBLICO
    bool isActive = false;
    public void BeginState()
    {
        isActive = true;
        OnBegin();
    }
    public void EndState()
    {
        isActive = false;
        OnEnd();
    }
    public void Tick(float deltaTime) // lo esta llamando un Update
    {
        if (isActive)
        {
            OnTick(deltaTime);
        }
    }

    protected abstract void OnBegin();
    protected abstract void OnEnd();
    protected abstract void OnTick(float deltaTime);
}


