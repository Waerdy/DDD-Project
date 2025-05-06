using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAction : MonoBehaviour
{

    public Transform looking; //looking at player
    public float timing = 0.2f; //value for how fast the camera moves
    public Vector3 offset; //position of camera
    private Vector3 speed = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //this is empty
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = looking.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref speed, timing); //makes the camera follow smoothly
    }
}
