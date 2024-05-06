using System;

namespace Learn
{
    [Serializable]
    public class FloatReference
    {
        public bool useConstant = true;
        public float constantValue;
        public FloatVariable variable;

        public float value
        {
            get
            {
                return useConstant ?  constantValue : variable.value;
            }
        }
    }
}
