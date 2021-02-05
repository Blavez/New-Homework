using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 dir;

    void Update()
    {
        transform.Translate(speed * dir * Time.deltaTime);
    }
}
