using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    private float HP = 100;
    public Slider heathBar;

    // Update is called once per frame
    void Update()
    {
        heathBar.value = HP;
    }

    public void TakeDamage(float damageAmount)
    {
        HP -= damageAmount;

        if(HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
