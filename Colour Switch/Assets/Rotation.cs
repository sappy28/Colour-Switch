﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float RotationSpeed = 100f;
	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.Rotate(0f , 0f , RotationSpeed * Time.deltaTime);
	}
}
