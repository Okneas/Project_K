using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour


{
    public Bow bow;
    public Rigidbody Rigidbody;
    public int Damage = 4;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetToRope(Transform ropeTransform) {
        transform.parent = ropeTransform;
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        Rigidbody.isKinematic = true;

    }
    public void Shot(float velocity) {
        transform.parent = null;
        Rigidbody.isKinematic = false;
        Rigidbody.velocity = transform.forward * velocity;
    }
    private void OntriggerEnter(Collider other)
    {
    bow.ArrowCount++;
    Destroy(gameObject);
    }
    /*private void Enemutrigger( Collider3D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.TakeDamage(Damage);
        }
    }*/
     
}
