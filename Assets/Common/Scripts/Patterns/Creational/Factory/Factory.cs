using System.Collections.Generic;

namespace Patterns.Factory
{
    public abstract class Factory<KeyObject, Type>
    {
        private Dictionary<KeyObject, Type> _factoryIds = new Dictionary<KeyObject, Type>();

        protected void AddObjectToFactory(KeyObject keyObject, Type type)
        {
            _factoryIds.Add(keyObject, type);
        }

        public Type GetObjectType(KeyObject keyObject)
        {
            if (keyObject == null)
                return default;

            if(_factoryIds.ContainsKey(keyObject))
                return _factoryIds[keyObject];

            throw new System.Exception("The key object doesn't exist");
        }
    }
}