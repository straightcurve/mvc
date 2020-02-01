using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallView : MonoBehaviour
{
    [SerializeField] private bool keyboard = true;
    private Vector3 initialPosition;

    public event Action<Vector3> MoveInput;
    public event Action<Vector3> Died;

    public BallView Init(Vector3 initialPosition) {
        this.initialPosition = initialPosition;
        return this;
    }

    private void CheckBallFellOver() {
        if (transform.position.y <= GameManager.Deadline){
            if(Died != null)
                Died(initialPosition);
        }
    }

    private void Update() {
        CheckBallFellOver();

        var acceleration = new Vector3();
        if(keyboard) {
            acceleration.y = Input.GetKey(KeyCode.W) ? 1 : Input.GetKey(KeyCode.S) ? -1 : 0;
            acceleration.x = Input.GetKey(KeyCode.D) ? 1 : Input.GetKey(KeyCode.A) ? -1 : 0;
            acceleration *= 10f;
        }
        else {
            acceleration = Input.acceleration;
        }

        if(MoveInput != null)
            MoveInput(acceleration);
    }
}