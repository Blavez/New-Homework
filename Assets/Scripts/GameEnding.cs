using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public GameObject enemy;

    void Update()
    {
        if ((enemy == null)&&(Coin.collect==3))
        {
            Coin.collect = 0;
            SceneManager.LoadScene(0);
        }
    }
}
