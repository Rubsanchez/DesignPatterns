using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.Serialization.Extensions
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
