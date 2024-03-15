using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : BaseStates
{
    private float moveTimer;
    private float losePlayerTimer;

    public override void Enter()
    {
    }

    public override void Exit()
    {
    }

    public override void Performed()
    {
        if (enemy.CanSeePlayer())
        {
            losePlayerTimer = 0;
            moveTimer += Time.deltaTime;
            if (moveTimer > Random.Range(3, 7))
            {
                enemy.Agent.SetDestination(enemy.transform.position + (Random.insideUnitSphere * 5));
                moveTimer = 0;
            }
        }
        else
        {
            losePlayerTimer += Time.deltaTime;
            if (losePlayerTimer > 8)
            {
                // Change to search state
                stateMachine.ChangeState(new PatrolStates());
            }
        }
    }
}
