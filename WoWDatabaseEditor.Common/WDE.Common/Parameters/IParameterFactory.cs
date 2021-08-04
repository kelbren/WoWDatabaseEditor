﻿using System;
using System.Collections.Generic;
using WDE.Module.Attributes;

namespace WDE.Common.Parameters
{
    [UniqueProvider]
    public interface IParameterFactory
    {
        IParameter<long> Factory(string type);
        IParameter<string> FactoryString(string type);
        bool IsRegisteredLong(string type);
        bool IsRegisteredString(string type);
        void Register(string key, IParameter<long> parameter);
        void Register(string key, IParameter<string> parameter);

        void RegisterDepending(string name, string dependsOn, Func<IParameter<long>, IParameter<long>> creator);
        void RegisterDepending(string name, string dependsOn, Func<IParameter<long>, IParameter<string>> creator);
        void RegisterCombined(string name, string param1, string param2, Func<IParameter<long>, IParameter<long>, IParameter<long>> creator);
        
        IEnumerable<string> GetKeys();

        IObservable<IParameter> OnRegister(string key);
        IObservable<IParameter<long>> OnRegisterLong(string key);
        IObservable<IParameter<string>> OnRegisterString(string key);
        IObservable<IParameter> OnRegister();
    }
}