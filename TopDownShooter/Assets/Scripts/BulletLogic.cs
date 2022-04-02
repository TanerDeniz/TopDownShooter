using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    Rigidbody rigidbody;
    float bulletSpeed = 8.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        if (rigidbody)
        {
            rigidbody.velocity = transform.up * bulletSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
      
       if (other.tag == "Target")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
    }
}
