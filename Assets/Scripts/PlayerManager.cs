using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Security.Cryptography;

public class PlayerManager : MonoBehaviour
{
    public GameObject player;
    float HP;

    public void Start()
    {
        HP = player.GetComponent<PlayerClass>().HP;
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Enemy")
        {
            HP -= other.transform.GetComponent<DamageScriptEnemy>().damageCount;
        }
    }
}
