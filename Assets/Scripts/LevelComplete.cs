using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
     void OnTriggerEnter()
    {
        gameManager.completeLevel();
    }
}
