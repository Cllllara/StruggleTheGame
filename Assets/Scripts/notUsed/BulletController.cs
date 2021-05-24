using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float BulletSpeed;
    public float damage;

    private void Start()
    {
        transform.GetComponent<Rigidbody>().velocity = transform.forward * BulletSpeed;
    }

    private void Update()
    {
        Destroy(gameObject, 2);
    }


    private void OnCollisionEnter(Collision collision) //damage interaction between bullet and asteroid
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            collision.transform.GetComponent<Asteroid_Controller>().stats.currentHealth -= damage;
            Destroy(gameObject);
        }
    }
}
