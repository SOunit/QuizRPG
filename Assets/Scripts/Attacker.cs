using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField]
    GameObject waitFill = null;

    [SerializeField]
    Health target;

    [SerializeField]
    float attackWaitMaxTime = 5f;

    [SerializeField]
    float intervalTime = .5f;

    float attackWaitTime = 0f;

    private void Update()
    {
        updateWaitTimeBar();
    }

    private void updateWaitTimeBar()
    {
        if (attackWaitTime < attackWaitMaxTime)
        {
            attackWaitTime += Time.deltaTime;
        }
        else
        {
            Invoke(nameof(resetWaitTime), intervalTime);
        }

        float percentage = attackWaitTime / attackWaitMaxTime;
        waitFill.transform.localScale = new Vector3(percentage, 1, 1);
    }

    private void resetWaitTime()
    {
        attackWaitTime = 0f;
    }
}
