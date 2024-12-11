using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;

    private float spanwnRangeX = 20;
    private float spanwnPosY = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimal()
    {
        // Sinh ngẫu nhiên vị trí
        Vector3 spanwPos = new Vector3(Random.Range(-spanwnRangeX, spanwnRangeX), 0, spanwnPosY);

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spanwPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
