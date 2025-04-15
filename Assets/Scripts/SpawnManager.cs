using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeLeftX = -10.0f;
    private float spawnRangeRightX = 10.0f;
    private float spawnPointZ = 20.0f;
    private float spawningRate = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomAnimal", 1, spawningRate);
        InvokeRepeating(nameof(SpawnRandomAnimal), 1, spawningRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        GameObject animal = animalPrefabs[animalIndex];
        Vector3 spawningPosition = new Vector3(Random.Range(spawnRangeLeftX, spawnRangeRightX), 0, spawnPointZ);
        //Vector3 spawningPosition = new Vector3(0, 0, spawnPointZ);
        Instantiate(animal, spawningPosition, animal.transform.rotation);
        //Instantiate<GameObject>(AnimalPrefabs[1]); // T constraint of Object.
    }
}
