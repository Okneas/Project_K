using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject[] spawns;
    public float xpGain = 5;
    private float HP = 100;
    public Slider heathBar;

    private void Start()
    {
        transform.name = "Enemy";
    }
    void Update()
    {
        heathBar.value = HP;
        spawns = GameObject.FindGameObjectsWithTag("Respawn");
    }

    public void TakeDamage(float damageAmount)
    {
        HP -= damageAmount * GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerClass>().DamageMult;

        if(HP <= 0)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerClass>().XP += xpGain;
            Destroy(gameObject);
            int numSpawn = Random.Range(0, spawns.Length);
            Instantiate(enemyPrefab, spawns[numSpawn].transform.position, spawns[numSpawn].transform.rotation);
        }
    }
}
