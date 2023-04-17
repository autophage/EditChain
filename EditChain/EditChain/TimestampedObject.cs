using System.Runtime.Serialization;

namespace EHonour.Utilities.EditChain
{
    internal class TimestampedObject<T> where T : ISerializable
    {
        public TimestampedObject(T value){
            this.Value = value;
        }

        public DateTime Timestamp { get; set; }
        public T Value { get; set; }
    }
}