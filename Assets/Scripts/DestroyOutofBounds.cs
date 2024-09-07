using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float topBoundary = 30.0f;
    private float bottomBoundary = -30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBoundary)
        {
            Destroy(gameObject);
        }
    }
}
