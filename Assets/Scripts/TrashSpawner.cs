using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    private float spawnRate = 2f;
    private float timeSinceTrash = 0;
    public GameObject[] TrashSprites;

    void Start()
    {

    }

    void Update()
    {
        timeSinceTrash += Time.deltaTime;
        if (timeSinceTrash >= spawnRate)
        {
            timeSinceTrash = 0;
            SpawnTrash();
        }
    }
    void SpawnTrash()
    {
        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPosition = new Vector3(randomX, 6, 0);

        int randomTrash = Random.Range(0, TrashSprites.Length);
        GameObject trash = Instantiate(TrashSprites[randomTrash], spawnPosition, Quaternion.identity);
    }
}
