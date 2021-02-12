using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int collect;
    private void OnTriggerEnter(Collider other)
    {
        collect += 1;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        Debug.Log(collect);
    }
}
