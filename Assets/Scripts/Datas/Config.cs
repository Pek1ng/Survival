using System;
using UnityEngine;

namespace Survival.Shared
{
    public sealed class Config
    {
        private Config _instance = new Lazy<Config>(new Config()).Value;

        private Config() {}

        public void Get()
        {
           
        }
    }
}
