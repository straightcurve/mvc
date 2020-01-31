using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private Dispatcher dispatcher;
    
    private void Awake() {
        if(dispatcher == null) {
            enabled = false;
            return;
        }

        dispatcher.Subscribe("input", OnInput);
    }

    public void OnInput(object e) {
        var keys = (bool[])e;

        dispatcher.Notify("move", GetDirectionFromKeys(keys));
    }

    private Vector3 GetDirectionFromKeys(bool[] keys) {
        var direction = new Vector3();
        direction.x = keys[3] ? 1 : keys[2] ? -1 : 0;
        direction.y = keys[0] ? 1 : keys[1] ? -1 : 0;
        return direction;
    }
}