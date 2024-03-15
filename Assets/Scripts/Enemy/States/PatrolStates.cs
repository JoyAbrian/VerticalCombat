using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolStates : BaseStates
{
    // Track current waypoint
    public int waypointIndex;
    public float waitTimer;

    public override void Enter()
    {
    }

    public override void Performed()
    {
        PatrolCycle();
    }

    public override void Exit()
    {
    }

    public void PatrolCycle()
    {
        if (enemy.Agent.remainingDistance < 0.2f)
        {
            waitTimer += Time.deltaTime;
            if (waitTimer > 3)
            {
                if (waypointIndex < enemy.path.waypoints.Count - 1)
                {
                    waypointIndex++;
                }
                else
                {
                    waypointIndex = 0;
                }

                enemy.Agent.SetDestination(enemy.path.waypoints[waypointIndex].position);
                waitTimer = 0;
            }
        }
    }
}