using System;

namespace Survival.Extensions
{
    [Serializable]
    public struct Optional<T>
    {
        /// <summary>
        /// 该属性是否启用
        /// </summary>
        public bool Enable;

        /// <summary>
        /// 该属性的值
        /// </summary>
        public T Value;

        public Optional(T value)
        {
            Enable = true;
            Value = value;
        }

        public static implicit operator bool(Optional<T> optional)
        {
            return optional.Enable;
        }

        public static implicit operator T(Optional<T> optional)
        {
            return optional.Value;
        }
    }
}
