using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    [SerializeField] GameObject targetPrefab; // It is private and we can also see in the inspector

    private void Start()
    {
        SpawnTarget();
    }
    void SpawnTarget() 
    {
        Instantiate(targetPrefab);
    }

}
