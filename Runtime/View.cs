using UnityEngine;

namespace Anhertis.Views
{
    public abstract class View<T> : MonoBehaviour where T : class
    {
        public T Target { get; private set; }

        protected virtual void OnEnable()
        {
            if (Target != null)
                OnAttached();
        }

        protected virtual void OnDisable()
        {
            if (Target != null)
                OnDetaching();
        }

        public void AttachTo(T target)
        {
            Detach();
            Target = target;

            if (isActiveAndEnabled)
                OnAttached();
        }

        public void Detach()
        {
            if (Target == null)
                return;

            if (isActiveAndEnabled)
                OnDetaching();

            Target = null;
        }

        public void DetachFrom(T target)
        {
            if (target == Target)
                Detach();
        }

        protected virtual void OnAttached()
        {
        }

        protected virtual void OnDetaching()
        {
        }
    }
}