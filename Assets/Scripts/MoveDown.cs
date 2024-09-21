using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = -20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,
                                         transform.position.y,
                                         transform.position.z + (speed * Time.deltaTime));

        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
