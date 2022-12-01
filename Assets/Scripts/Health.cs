using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    GameObject healthFill;

    [SerializeField]
    private float maxHealthPoints = 10f;

    private float healthPoints;

    private void Awake()
    {
        healthPoints = maxHealthPoints;
    }

    private void Update()
    {
        float ratio = healthPoints / maxHealthPoints;
        healthFill.transform.localScale = new Vector3(ratio, 1, 1);
    }
}
