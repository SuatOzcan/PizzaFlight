using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaMover : MonoBehaviour
{
    private float speed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x,
        //                                  transform.position.y,
        //                                  transform.position.z + (speed * Time.deltaTime));

        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }
}
