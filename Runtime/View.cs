using UnityEngine;

namespace Anhertis.Views
{
    public abstract class View<T> : MonoBehaviour where T : class
    {
        private bool _isBound;

        public T Target { get; private set; }

        protected virtual void OnEnable()
        {
            Bind();
        }

        protected virtual void OnDisable()
        {
            Unbind();
        }

        public void AttachTo(T target)
        {
            Detach();
            Target = target;

            if (isActiveAndEnabled)
                Bind();
        }

        public void Detach()
        {
            Unbind();
            Target = null;
        }

        public void DetachFrom(T target)
        {
            if (target == Target)
                Detach();
        }

        protected virtual void OnBind()
        {
        }

        protected virtual void OnUnbind()
        {
        }

        private void Bind()
        {
            if (_isBound || Target == null)
                return;

            _isBound = true;
            OnBind();
        }

        private void Unbind()
        {
            if (_isBound == false)
                return;

            _isBound = false;
            OnUnbind();
        }
    }
}