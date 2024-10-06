using System.Collections.Generic;
using System;

public class AlphaMessenger
{
    private static readonly AlphaMessenger _instance = new AlphaMessenger();
    private readonly Dictionary<Type, List<Action<object>>> _subscribers = new Dictionary<Type, List<Action<object>>>();

    private AlphaMessenger() { }

    public static AlphaMessenger Instance => _instance;

    public void Subscribe<T>(Action<T> action)
    {
        var key = typeof(T);
        if (!_subscribers.ContainsKey(key))
        {
            _subscribers[key] = new List<Action<object>>();
        }

        _subscribers[key].Add(o => action((T)o));
    }

    public void Publish<T>(T message)
    {
        var key = typeof(T);
        if (_subscribers.ContainsKey(key))
        {
            foreach (var action in _subscribers[key])
            {
                action(message);
            }
        }
    }
}