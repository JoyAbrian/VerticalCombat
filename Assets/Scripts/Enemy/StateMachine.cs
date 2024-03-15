using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public BaseStates activeState;
    public PatrolStates patrolStates;

    public void Initialize()
    {
        patrolStates = new PatrolStates();
        ChangeState(patrolStates);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (activeState != null)
        {
            activeState.Performed();
        }
    }

    public void ChangeState(BaseStates newState)
    {
        // check activeState != null
        if (activeState != null)
        {
            // Cleanup activeState
            activeState.Exit();
        }

        // Change into newState
        activeState = newState;

        // Fail-safe null check to make sure new state wasn't null
        if (activeState != null)
        {
            // Setup new state
            activeState.stateMachine = this;
            activeState.enemy = GetComponent<Enemy>();
            activeState.Enter();
        }
    }
}
