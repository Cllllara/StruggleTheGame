using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
   /* public class Ship_Stats
    {
        public int maxHealth = 4;
        public int currentHealth;
    } 

    Rigidbody rb;

    public Ship_Stats stats;
    
    public float moveSpeed = 10f;
    public float tiltAngle;
    //public float maxRotation = 25f;
    
    private float minX, maxX, minY, maxY;
    public GameObject explosionPrefab;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetUpBoundries();

        stats.currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotatePlayer();
        //FireRockets();

        CalculateBoundries();
    }

    private void CalculateBoundries()
    {
        Vector3 currentPosition = transform.position;

        currentPosition.x = Mathf.Clamp(currentPosition.x, minX, maxX);
        currentPosition.y = Mathf.Clamp(currentPosition.x, minX, maxX);

        transform.position = currentPosition;
    }

    private void SetUpBoundries() //ship dont go out screen
    {
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorners = Camera.main.ViewportToWorldPoint(new Vector3(0f, 0f, camDistance));
        Vector2 topCorners = Camera.main.ViewportToWorldPoint(new Vector3(1f, 1f, camDistance));

        //calculate the size of the gameobject
        Bounds gameObjectBouds = GetComponent<Collider>().bounds;
        float objectWidth = gameObjectBouds.size.x;
        float objectHeight = gameObjectBouds.size.y;

        minX = bottomCorners.x + objectWidth;
        maxX = topCorners.x - objectWidth;

        minY = bottomCorners.y + objectHeight;
        maxY = topCorners.y - objectHeight;

        //set up the asteroid manager
        Asteroid_Manager.Instance.maxX = maxX;
        Asteroid_Manager.Instance.minX = minX;
        Asteroid_Manager.Instance.maxY = maxY;
        Asteroid_Manager.Instance.minY = minY;
    }

    private void MovePlayer()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 movementVector = new Vector3(horizontalMovement, verticalMovement, 0f);

        rb.velocity = movementVector * moveSpeed;
    }

    private void RotatePlayer()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        rb.rotation = Quaternion.Euler(Vector3.forward * horizontalMovement * -tiltAngle);

        float currentX = transform.position.x;
        float newRotationZ;

        if(currentX < 0)
        {
            //rotate negative
            newRotationZ = Mathf.Lerp(0f, -maxRotation, currentX / minX);
        }

        else
        {
            //rotate positive
            newRotationZ = Mathf.Lerp(0f, maxRotation, currentX / maxX);
        }

        Vector3 currentRotationVector3 = new Vector3(0f, 0f, newRotationZ);
        Quaternion newRotation = Quaternion.Euler(currentRotationVector3);
        transform.localRotation = newRotation;*/
    }