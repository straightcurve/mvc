﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallModel : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    
    private void Awake() {
        if(rb == null)
            rb = GetComponent<Rigidbody>();
    }

    public void Die(Vector3 restartPosition) {
        rb.velocity = Vector3.zero;
        transform.position = restartPosition;

        
    }

    public void Move(Vector3 force) {
        rb.AddForce(force, ForceMode.Acceleration);
    }
}