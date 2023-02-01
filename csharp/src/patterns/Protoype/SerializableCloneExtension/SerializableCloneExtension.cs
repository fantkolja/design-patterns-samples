using System.Xml.Serialization;

namespace DesignPatterns.Protoype.ExtensionMethods
{
  public static class CloningExtensions
  {
    public static T DeepClone<T>(this T obj)
    {
      var serializer = new XmlSerializer(typeof(T));
      var memoryStream = new MemoryStream();
      serializer.Serialize(memoryStream, obj);
      memoryStream.Seek(0, SeekOrigin.Begin);
      T? clonedObj = (T?) serializer.Deserialize(memoryStream);
      memoryStream.Close();
      if (clonedObj == null)
      {
        throw new Exception("Could not deserialize Person");
      }
      return clonedObj;
    }
  }
}