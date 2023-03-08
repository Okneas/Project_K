using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackscript : MonoBehaviour
{
    Animator animator;
    public Collider sword;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        sword.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("attack", true);
            sword.enabled = true;

        }
        else if (Input.GetButtonUp("Fire1"))
        {
            sword.enabled = true;
            animator.SetBool("attack", false);
        }
    }
}
