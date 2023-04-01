using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTorque : MonoBehaviour
{
    
    public Rigidbody Rigidbody;
    public float AnqularVelocityMult;

    public float VelocityMult;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 cross = Vector3.Cross(transform.forward, Rigidbody.velocity.normalized);

        Rigidbody.AddTorque(cross * Rigidbody.velocity.magnitude * VelocityMult);

        Rigidbody.AddTorque((Vector3.Project(Rigidbody.angularVelocity, transform.forward)-Rigidbody.angularVelocity) * Rigidbody.velocity.magnitude * AnqularVelocityMult);
        

    }
}
