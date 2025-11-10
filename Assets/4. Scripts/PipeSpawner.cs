using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Timeline;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    float maxTime = 1.5f;
    [SerializeField]
    float heightRange = 0.5f;
    [SerializeField]
    GameObject PipePrefab;

    float timer;

    void Update()
    {
        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;

    }
    
    void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0f, Random.Range(-heightRange, heightRange), 0f);
        GameObject pipe = Instantiate(PipePrefab, spawnPos, Quaternion.identity);

        Destroy(pipe, 5f);
    }
}
