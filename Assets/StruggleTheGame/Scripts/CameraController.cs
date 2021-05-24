using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    /*public UIManager UIManager;
    [HideInInspector]
    public bool startToRotateCamera = false;

    private bool isCameraRotateFinish = true;

    private float rotateSpeed = 90f;
    private float rotateAngle = 90f;

    // Start is called before the first frame update
    void Start()
    {
        startToRotateCamera = false;
        StartCoroutine(RotateCamera());
    }

    IEnumerator RotateCamera()
    {
        while (true)
        {
            if ((ScoreManager.Instance.score != 0 && (ScoreManager.Instance.score % UIManager.scoreToScaleCamera == 0) && !isCameraRotateFinish
                && !FindObjectOfType<PlayerController>().gameOver))
            {
                isCameraRotateFinish = false;
                startToRotateCamera = true;
                FindObjectOfType<PlayerController>().touchDisable = true;

                float currentAngle = 0f;
                while(currentAngle < rotateAngle)
                {
                    transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
                    currentAngle += rotateSpeed * Time.deltaTime;
                    yield return null;
                }

                startToRotateCamera = false;
                isCameraRotateFinish = true; 
                FindObjectOfType<PlayerController>().touchDisable = false;
            }
            yield return null;
        }
    }*/
}
