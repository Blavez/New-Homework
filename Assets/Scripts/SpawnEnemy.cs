using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private Vector3 SpawnPos;
    [SerializeField] private GameObject Enemy;
    [SerializeField] private float TimeSpawn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawmCD());
    }

    void Repeat()
    {
        StartCoroutine(SpawmCD());
    }

    IEnumerator SpawmCD()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(Enemy, SpawnPos, Quaternion.identity);
        Repeat();
    }
}

