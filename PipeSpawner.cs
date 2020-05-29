﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;
    
    void Start()
    {
        StartCoroutine(Spawner());
    }


    private IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            float rand = Random.Range(-0.5f, 2.8f);
            GameObject newPipes = Instantiate(Pipes, new Vector3(2, rand, 0), Quaternion.identity);
            Destroy(newPipes, 7);
        }
    }
}
