using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] fruits;

    private bool run = true;
    private float spawnRate = 1.0f;
    void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    IEnumerator SpawnFruits()
    {
        while (run)
        {
            yield return new WaitForSeconds(spawnRate);
            int randomIndex = Random.Range(0, fruits.Length);
            Instantiate(fruits[randomIndex]);
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
