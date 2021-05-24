using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids_Controller : MonoBehaviour
{
    public float damage;
    public float moveSpeed = 20f;
    private Rigidbody rb;
    private Vector3 randomRotation;
    private float removePositionZ;

    public GameObject explosionPrefeb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        randomRotation = new Vector3(Random.Range(0f, 100f), Random.Range(0f, 100f), Random.Range(0f, 100f));
        removePositionZ = Camera.main.transform.position.z;
    }

    void Update()
    {
        if(transform.position.z < removePositionZ)
        {
            Destroy(gameObject);
        }

        Vector3 movementVector = new Vector3(0f, 0f, -moveSpeed * Time.deltaTime);
        rb.velocity = movementVector;

        transform.Rotate(randomRotation * Time.deltaTime);
    }

    public void DestroyAsteroid()
    {
        //play partical effect

        //disable movement

        //disable colliders

        //destroy game object with a delay
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
      
    }
}
