using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeLeftX = -20f;
    private float spawnRangeRightX = 20.00001f;
    private float spawnPointZ = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            int animalIndex = Random.Range(0,animalPrefabs.Length);
            GameObject animal = animalPrefabs[animalIndex];
            Vector3 spawningPosition = new Vector3(Random.Range(spawnRangeLeftX, spawnRangeRightX), 0, spawnPointZ);
            Instantiate(animal, spawningPosition, animal.transform.rotation);
            //Instantiate<GameObject>(AnimalPrefabs[1]); // T constraint of Object.
        };
    }
}
