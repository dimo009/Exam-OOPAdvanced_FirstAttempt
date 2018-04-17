using Last_Army.Entities.Soldiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Last_Army.Core
{
    public class SoldiersFactory:ISoldierFactory
    {
        

        public ISoldier CreateSoldier(string soldierTypeName, string name, int age, double experience, double endurance)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] models = assembly.GetTypes();
            Type model = assembly.GetTypes().FirstOrDefault(s => s.Name == soldierTypeName);

            if (model==null)
            {
                throw new ArgumentException("Invalid soldier type!");
            }

            if (!typeof(ISoldier).IsAssignableFrom(model))
            {
                throw new InvalidOperationException($"The {soldierTypeName} is not a valid for this class!");
            }

            var constructor = model.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public, null,new[] { typeof(string), typeof(string), typeof(int), typeof(double), typeof(double) },null);

            ISoldier soldier = (ISoldier)constructor.Invoke(new object[] { soldierTypeName, name, age, experience, endurance});
            return soldier;
        }
    }
}