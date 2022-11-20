using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomManager : MonoBehaviour
{


    void Start()
    {
        float randomValue = UnityEngine.Random.value;
        Debug.Log(randomValue);

        transform.rotation = UnityEngine.Random.rotation;
        Debug.Log(transform.rotation);

        transform.rotation = UnityEngine.Random.rotationUniform;
        Debug.Log(transform.rotation);
    }

  

   





}
