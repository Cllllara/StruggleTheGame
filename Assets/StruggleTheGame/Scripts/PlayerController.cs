using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 7f;

    public ParticleSystem particle;

    private Vector3 dir;
    private bool dirTurn;
    public bool gameOver, touchDisable;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && FindObjectOfType<PlatformManager>() && !touchDisable)
        {
            dirTurn = !dirTurn;

            if (dirTurn)
                dir = Vector3.forward;
            else
                dir = Vector3.back;
        }

  

        transform.position = transform.position + dir * playerSpeed * Time.deltaTime; //bougerplayer

        RaycastHit hit;
        Ray rayDown = new Ray(transform.position, Vector3.down);

        if (!Physics.Raycast(rayDown, out hit, .5f))//player die
        {
            gameOver = true;
            touchDisable = true;
            playerSpeed = 20;
            dir = Vector3.down;
        }

    }


    public void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Obstacle")
        {
            gameOver = true;
            touchDisable = true;
            dir = Vector3.left;
        }

        if (target.tag == "Gold")
        {

            ScoreManager.instance.AddPoint();

            ParticleSystem goldParticle;
            goldParticle = Instantiate(particle, target.transform.position, Quaternion.identity);
            goldParticle.Simulate(.5f, true, false);
            goldParticle.Play();

            Destroy(goldParticle, 0.5f);
            Destroy(target.gameObject);
        }
    }

 
}