using UnityEngine;

public abstract class UnityObjectView<T> : View<T> where T : Object
{
    [SerializeField] private T _serializedTarget;

    protected virtual void Awake()
    {
        AttachTo(_serializedTarget);
    }

    protected virtual void OnValidate()
    {
        AttachTo(_serializedTarget);
    }

    protected override void OnAttached()
    {
        _serializedTarget = Target;
    }

    protected override void OnDetaching()
    {
        _serializedTarget = Target;
    }
}