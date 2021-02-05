using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineBomb : MonoBehaviour
{
    [SerializeField] private string detecTag;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(detecTag)) return;

        Destroy(other.gameObject);
    }
}
