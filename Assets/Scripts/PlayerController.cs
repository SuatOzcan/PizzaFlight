using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    private float speed = 10.0f;
    private float leftBoundary = -10.0f;
    private float rightBoundary = 10.0f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= rightBoundary)
        {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
        }
        
        else if (transform.position.x <= leftBoundary)
        {
            transform.position = new Vector3(leftBoundary,transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Space))
        { 
            GameObject.Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}
