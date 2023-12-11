using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject balloonPrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(balloonPrefab, new Vector3(-40.0f, Random.Range(-4.0f, 10.0f), Random.Range(-15.0f, 5.0f)), Quaternion.identity);
        }
    }
}
