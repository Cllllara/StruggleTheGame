using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private PlatformManager platformManager;

    public GameObject[] obstacles;
    public GameObject gold;

    public float timerSpawn;
    public float obstacleSpeedMovement;

    private List<Vector3> listPosition = new List<Vector3>();


    // Start is called before the first frame update
    void Start()
    {
        int i = -5;
        while(i <= 5)
        {
            Vector3 pos = transform.position + new Vector3(0, 0, i);
            listPosition.Add(pos);
            i += 2;
        }

        StartCoroutine(SpawnObstacle());

    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<PlayerController>().gameOver)
        {
            obstacleSpeedMovement = 15;
        }
           
    }

    IEnumerator SpawnObstacle()
    {
        yield return new WaitForSeconds(timerSpawn);

        if (FindObjectOfType<PlatformManager>()/*.finishMoveGround*/ && !FindObjectOfType<PlayerController>().gameOver)
        {
            int indexPositionOfObstacle = Random.Range(0, listPosition.Count);

            if(Random.value <= .7)
            {
                int indexPositionOfGold = Random.Range(0, listPosition.Count);
                while(indexPositionOfGold == indexPositionOfObstacle)
                {
                    indexPositionOfGold = Random.Range(0, listPosition.Count);
                }

                Instantiate(gold, listPosition[indexPositionOfGold] + new Vector3(10f, 0f, 0f), Quaternion.identity);
                
            }

            GameObject currentObstacle = Instantiate(obstacles[Random.Range(0, obstacles.Length)],
                listPosition[indexPositionOfObstacle] + new Vector3(10, 0, 0), Quaternion.identity);

            StartCoroutine(SpawnObstacle());

        }
    }
}
