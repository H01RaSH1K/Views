using UnityEngine;

namespace View
{
    public abstract class SerializedTargetView<T> : View<T> where T : class
    {
        [SerializeField] private T _serializedTarget;

        protected virtual void Awake()
        {
            AttachTo(_serializedTarget);
        }

        protected virtual void OnValidate()
        {
            if (ReferenceEquals(Target, _serializedTarget))
                return;

            AttachTo(_serializedTarget);
        }

        protected override void OnAttached()
        {
            _serializedTarget = Target;
        }

        protected override void OnDetaching()
        {
            _serializedTarget = null;
        }
    }
}