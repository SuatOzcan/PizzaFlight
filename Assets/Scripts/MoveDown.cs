using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {

        Vector3 result = Vector3.Scale(Vector3.up, Vector3.forward);
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x,
        //                                 transform.position.y,
        //                                 transform.position.z + (speed * Time.deltaTime));

        transform.Translate(speed * Time.deltaTime * Vector3.forward, Space.World);
        Debug.Log(speed * Time.deltaTime * Vector3.back);
        Debug.Log(Vector3.back);
        //Debug.Log(Time.deltaTime);
    }
}
