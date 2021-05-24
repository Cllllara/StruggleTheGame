using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Ship_Stats
{
    public float maxHealth;
    public float currentHealth;
}

    public class ShipController : MonoBehaviour
    {
        private Rigidbody rb;

        public float moveSpeed;
        public float tiltAngle;
        private float minX, maxX, minY, maxY;


       public Ship_Stats stats;

        public GameObject explosionPrefab;

       

        void Start()
        {
            rb = GetComponent<Rigidbody>();

            stats.currentHealth = stats.maxHealth;
        }

       
        private void Update() //death
        {

            if (stats.currentHealth <= 0)
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }

        void FixedUpdate()//ShipInGame
        {
        //deplacement sur lecran
            float horizontalMovement = Input.GetAxis("Horizontal");
            float verticalMovement = Input.GetAxis("Vertical");

            Vector3 movementVector = new Vector3(horizontalMovement, 0f, verticalMovement);

            rb.velocity = movementVector * moveSpeed;
           
        //rotation de lavion
            rb.rotation = Quaternion.Euler(Vector3.forward * horizontalMovement * -tiltAngle);
            
        }

        private void OnCollisionEnter(Collision collision) //collision with asteroids ?
        {
            if (collision.gameObject.tag == "Asteroid")
            {
                stats.currentHealth -= collision.transform.GetComponent<Asteroid_Controller>().stats.damage;
                Destroy(collision.gameObject);
            }
        }

    }
