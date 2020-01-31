using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeView : MonoBehaviour
{
    [SerializeField] private KeyCode up = KeyCode.W;
    [SerializeField] private KeyCode down = KeyCode.S;
    [SerializeField] private KeyCode left = KeyCode.A;
    [SerializeField] private KeyCode right = KeyCode.D;

    [SerializeField] private Dispatcher dispatcher;

    private void Awake() {
        if(dispatcher == null)
            enabled = false;
    }

    private void Update() {
        var keys = new bool[4] {
            Input.GetKey(up),
            Input.GetKey(down),
            Input.GetKey(left),
            Input.GetKey(right),
        };
            
        dispatcher.Notify("input", keys);
    }
}