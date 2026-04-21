using UnityEngine;

namespace View
{
    public abstract class View<T> : MonoBehaviour where T : class
    {
        public T Target { get; private set; }

        private void OnDisable()
        {
            Detach();
        }

        public void AttachTo(T target)
        {
            if (Target != null)
                Detach();

            Target = target;
            OnAttached();
        }

        public void Detach()
        {
            if (Target == null)
                return;

            OnDetaching();
            Target = null;
        }

        public void DetachFrom(T target)
        {
            if (target == Target)
                Detach();
        }

        protected abstract void OnAttached();
        protected abstract void OnDetaching();
    }
}