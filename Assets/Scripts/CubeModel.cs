using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeModel : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Dispatcher dispatcher;
    
    private void Awake() {
        if(dispatcher == null) {
            enabled = false;
            return;
        }

        dispatcher.Subscribe("move", OnMove);
    }

    private void OnMove(object e) {
        var direction = (Vector3)e;

        transform.position += direction * speed * Time.deltaTime;
    }
}