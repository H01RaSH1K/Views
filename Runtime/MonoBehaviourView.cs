using UnityEngine;

public abstract class MonoBehaviourView<T> : View<T> where T : MonoBehaviour
{
    [SerializeField] private T _target;

    protected virtual void Awake()
    {
        AttachTo(_target);
    }

    protected virtual void OnValidate()
    {
        AttachTo(_target);
    }
}
