using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitBehaviour : MonoBehaviour
{
    Rigidbody rb;
    private float xRange = 11;
    private float ySpawnPoint = -7;
    private float zSpawnPoint = 0.4f;

    private float minForce = 12;
    private float maxForce = 19;

    private float minTorqueX = 10;
    private float minTorqueY = 10;
    private float minTorqueZ = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = GetRandomPosition();
        rb.AddForce(GetRandomForce(), ForceMode.Impulse);
        rb.AddTorque(GetRandomTorque());
    }

    private void Update()
    {
       if (transform.position.y < ySpawnPoint - 1)
       {
            Destroy(gameObject);
       }
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
    Vector3 GetRandomPosition()
    {
        float x = Random.Range(-xRange, xRange);
        return new Vector3(x, ySpawnPoint, zSpawnPoint);
    }

    Vector3 GetRandomForce()
    {
        return Vector3.up * Random.Range(minForce, maxForce);
    }

    Vector3 GetRandomTorque()
    {
        float x = Random.Range(-minTorqueX, minTorqueX);
        float y = Random.Range(-minTorqueY, minTorqueY);
        float z = Random.Range(-minTorqueZ, minTorqueZ);
        return new Vector3(x, y, z);
    }
}
