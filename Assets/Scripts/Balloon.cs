using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    private GameObject[] containerList;
    private GameObject container;

    private void OnTriggerExit(Collider other)
    {
        if (container == null)
        {
            containerList = GameObject.FindGameObjectsWithTag("Container");
            container = containerList[0];
        }

        if (other.gameObject.tag == "Wind")
        {
            //for (int i = 0; i == 28; i++)
            //{
            //    Destroy(container.transform.GetChild(0).gameObject);
            //}
            Destroy(this.gameObject);
        }
    }
}
