using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindCube : MonoBehaviour
{
    [SerializeField]
    //float _windForce = 0f;

    public float lerpTime;
    public float timeRandomness;
    public float dirRandomness;
    public GameObject curDirVisualizer;

    private float curLerpTime;
    private float timer;

    private Vector3 zoneDir;
    private Vector3 curDir;
    private Vector3 oldDir;
    private Vector3 randDir;
   

    private void Start()
    {
        zoneDir = transform.up;
        curDir = zoneDir;

        randDir.x = Random.Range(zoneDir.x - dirRandomness, zoneDir.x + dirRandomness);
        randDir.y = zoneDir.y;
        randDir.z = zoneDir.z;
        //Debug.Log(zoneDir.x + " , " + zoneDir.y + ", " + zoneDir.z);
    }

    private void OnTriggerStay(Collider other)
    {
        var hitObj = other.gameObject;

        if (hitObj != null)
        {
            var rb = hitObj.GetComponent<Rigidbody>();

            if (Vector3.Distance(curDir, randDir) <= 0.1)
            {
                //Debug.Log("New dir who dis");
                oldDir = randDir;
                randDir.x = Random.Range(zoneDir.x - dirRandomness, zoneDir.x + dirRandomness);
                randDir.y = Random.Range(zoneDir.y - dirRandomness, zoneDir.y + dirRandomness);
                randDir.z = Random.Range(zoneDir.z - dirRandomness, zoneDir.z + dirRandomness);

                timer = 0;
                curLerpTime = Random.Range(lerpTime - timeRandomness, lerpTime + timeRandomness);
            }

            timer += Time.deltaTime;
            curDir = Vector3.Lerp(oldDir, randDir, timer/curLerpTime);
            curDirVisualizer.transform.rotation = Quaternion.Euler(curDir);
            //Debug.Log(curDir.x + ", " + curDir.y + ", " + curDir.z);

            //Debug.Log(Vector3.Distance(curDir, randDir) <= 0.1);
            //Debug.Log("x: " + curDir.x + " y: " + curDir.y + " z: " + curDir.z);
            //Debug.Log(timer / curLerpTime);

            //rb.velocity = Vector3.zero;
            rb.AddForce(curDir * Random.Range(0.0f, 0.6f));
            //Debug.Log(other.gameObject.name);

        }

    }
}