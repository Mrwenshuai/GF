using GameFramework.Fsm;
using ProjectName;
using UnityEngine;

public class FsmDemo : MonoBehaviour
{
    IFsm<FsmDemo> fsm;
    // Start is called before the first frame update
    void Start()
    {
        State_01 s1 = new State_01();
        State_02 s2 = new State_02();
        FsmState<FsmDemo>[] fsmStates = new FsmState<FsmDemo>[2] { s1, s2 };
        fsm = GameEntry.Fsm.CreateFsm<FsmDemo>("FSMtest", this, null);
        var states = fsm.GetAllStates();
        foreach (var item in states)
        {
            Debug.LogError(">>> " + item);
        }
        fsm.Start(s1.GetType());
        Debug.LogError("CURRENT :  " + fsm.IsRunning + " NAME: " + fsm.CurrentState);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            State_01 s1 = new State_01();
            fsm.Start(s1.GetType());
        }
    }
}

public class State_01 : FsmState<FsmDemo>
{
    protected internal override void OnEnter(IFsm<FsmDemo> fsm)
    {
        base.OnEnter(fsm);
        Debug.LogError("Enter Fsm");
    }

    protected internal override void OnInit(IFsm<FsmDemo> fsm)
    {
        base.OnInit(fsm);
        Debug.LogError("Init Fsm");
    }

    protected internal override void OnUpdate(IFsm<FsmDemo> fsm, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);
        Debug.Log("Update Fsm 01");
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeState<State_02>(fsm);
        }
    }

    protected internal override void OnLeave(IFsm<FsmDemo> fsm, bool isShutdown)
    {
        base.OnLeave(fsm, isShutdown);
        Debug.LogError("Leave Fsm 01");

    }
}

public class State_02 : FsmState<FsmDemo>
{
    protected internal override void OnEnter(IFsm<FsmDemo> fsm)
    {
        base.OnEnter(fsm);
        Debug.LogError("Enter Fsm 02 ");
    }

    protected internal override void OnInit(IFsm<FsmDemo> fsm)
    {
        base.OnInit(fsm);
        Debug.LogError("Init Fsm 02 ");
    }

    protected internal override void OnUpdate(IFsm<FsmDemo> fsm, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);
        Debug.Log("Update Fsm 02");
    }

    protected internal override void OnLeave(IFsm<FsmDemo> fsm, bool isShutdown)
    {
        base.OnLeave(fsm, isShutdown);
        Debug.LogError("Leave Fsm 02");
    }
}