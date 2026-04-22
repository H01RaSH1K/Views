using UnityEngine;

namespace View
{
    public abstract class SerializedTargetView<T> : View<T> where T : class
    {
        [SerializeField] private T _startTarget;

        protected virtual void Start()
        {
            AttachTo(_startTarget);
        }
    }
}