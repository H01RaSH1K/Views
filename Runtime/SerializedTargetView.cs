using UnityEngine;

namespace Anhertis.Views
{
    public abstract class SerializedTargetView<T> : View<T> where T : class
    {
        [SerializeField] private T _startTarget;

        protected virtual void Start()
        {
            if (Target == null)
                AttachTo(_startTarget);
        }
    }
}