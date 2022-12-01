using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField]
    Health target;

    [SerializeField]
    float attackWaitMaxTime = 5f;

    float attackWaitTime = 0f;

    private void Update()
    {
        attackWaitTime += Time.deltaTime;
        if (attackWaitTime > attackWaitMaxTime)
        {
            Debug.Log("attackWaitTime completed");
            attackWaitTime = 0f;
        }
    }
}
