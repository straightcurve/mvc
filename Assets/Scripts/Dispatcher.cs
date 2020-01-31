using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispatcher : MonoBehaviour
{
    private readonly Dictionary<string, Action<object>> events = new Dictionary<string, Action<object>>();

    public void Subscribe(string ev, Action<object> callback) {
        if(events.ContainsKey(ev))
            events[ev] += callback;
        else
            events.Add(ev, callback);
    }

    public void Notify(string ev, object message) {
        if(events.ContainsKey(ev))
            events[ev]?.Invoke(message);
    }

    public void Unsubscribe(string ev, Action<object> callback) {
        if(events.ContainsKey(ev))
            events[ev] -= callback;
    }
}