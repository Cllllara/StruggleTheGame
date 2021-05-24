using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Manager : MonoBehaviour
{
    #region Singleton
    public static Asteroid_Manager Instance;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    #endregion

    public GameObject[] asteroidPrefabs;
    public float asteroidSpawnDistance = 80f;

    public float spawnTime = 2f;
    private float timer = 0f;

    [HideInInspector]
    public float minX, maxX, minY, maxY;

    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 
        if(timer >= spawnTime)
        {
            //spawn asteroids
            SpawnNewAsteroid();
            timer = 0f;
        }

        void SpawnNewAsteroid()
        {
            float newX = Random.Range(minX, maxX);
            float newY = Random.Range(minX, maxY);

            Vector3 spawnPos = new Vector3(newX, newY, asteroidSpawnDistance);

            Instantiate(asteroidPrefabs[Random.Range(0, asteroidPrefabs.Length)], spawnPos, Quaternion.identity);
        }
    }
}
