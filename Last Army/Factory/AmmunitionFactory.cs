using System;
using System.Linq;
using System.Reflection;

namespace Last_Army.Factory
{
    public class AmmunitionFactory:IAmmunitionFactory
    {

        public IAmmunition CreateAmmunition(string ammunitionName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] models = assembly.GetTypes();

            Type model = assembly.GetTypes().FirstOrDefault(a => a.Name == ammunitionName);

            if (model==null)
            {
                throw new ArgumentException("Invalid unit type!");


            }

            if (!typeof(IAmmunition).IsAssignableFrom(model))
            {
                throw new InvalidOperationException($"The {ammunitionName} is not a valid for this case!");
            }

            var constructor = model.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public, null, new Type[0], null);

            IAmmunition ammunition = (IAmmunition)Activator.CreateInstance(model);

            return ammunition;
        }
    }
}