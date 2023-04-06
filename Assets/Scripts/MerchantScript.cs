using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantScript : MonoBehaviour
{
    public GameObject[] prefabs;
    public void buyArrow()
    {
        if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerClass>().gold >= 3)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerClass>().gold -= 3;
            Instantiate(prefabs[0], GameObject.Find("MerchantSpawnBuy").transform.position, GameObject.Find("MerchantSpawnBuy").transform.rotation);
        }
    }
}
