using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoad : MonoBehaviour
{
    public GameObject[] spawns;
    public GameObject[] objs;
    void Awake()
    {
        objs = GameObject.FindGameObjectsWithTag("Player");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
        spawns = GameObject.FindGameObjectsWithTag("Respawn");
        transform.position = spawns[0].transform.position;
    }
    private void Update()
    {
        spawns = GameObject.FindGameObjectsWithTag("Respawn");
        if (spawns.Length > 1)
        {
            Destroy(spawns[0].gameObject);
        }
    }
    private void OnLevelWasLoaded(int level)
    {
        if(level == 0)
        {
            Destroy(this.gameObject);
        }
        else if (PlayerPrefs.GetFloat("PosX") == 0)
        {
            transform.position = spawns[0].transform.position;
        }
    }
}
