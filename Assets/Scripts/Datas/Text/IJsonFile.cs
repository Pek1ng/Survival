using System;

namespace Survival.Datas
{
    public abstract class IJsonFile : ITextFile
    {
        [NonSerialized]
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public IJsonFile()
        {
            _name = this.GetType().Name;
        }
    }
}
