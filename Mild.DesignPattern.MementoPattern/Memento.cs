using Newtonsoft.Json;

namespace Mild.DesignPattern.MementoPattern
{
    public class Memento<T>
    {
        public string Type { get; }
        private readonly string _serializedData;
        public T Object => JsonConvert.DeserializeObject<T>(_serializedData);

        public Memento(T serializeObject)
        {
            Type = typeof(T).ToString();
            _serializedData = JsonConvert.SerializeObject(serializeObject);
        }
    }
}