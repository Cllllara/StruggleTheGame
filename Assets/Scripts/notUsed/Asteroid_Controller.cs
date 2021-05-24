using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Asteroid_Controller : MonoBehaviour
{
    public class Asteroid_Stats
    {
        public float maxHealth;
        public float currentHealth;

        public float damage;
    }


    public Asteroid_Stats stats;

    private Quaternion randomRotation;

    public GameObject explosionPrefab;

    private void Start()
    {
        stats.currentHealth = stats.maxHealth;

        randomRotation = Random.rotation;
    }


    private void Update()
    {
        transform.Rotate(randomRotation.eulerAngles * 0, 1f * Time.deltaTime);

        if (stats.currentHealth <= 0)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
