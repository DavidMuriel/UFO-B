﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ScrPickup : MonoBehaviour
{
   

    [SerializeField]
    int velGir=1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0, 0, velGir * Time.deltaTime);
    }
}
