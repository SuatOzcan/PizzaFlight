using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 10.0f;
    private float xRange = 10.0f;
    private float timeHolder = 0.0f;
    private float fireTime = 0.65f;
    private float pizzaPositionYOffset = 1.25f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        else if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time  >= timeHolder)
            {
                Vector3 pizzaPosition = new Vector3(transform.position.x,
                                                                                   transform.position.y  + pizzaPositionYOffset ,
                                                                                   transform.position.z);
                GameObject.Instantiate(projectilePrefab, pizzaPosition, Quaternion.identity);
                timeHolder = Time.time + fireTime;
            }
        }
    }
}
