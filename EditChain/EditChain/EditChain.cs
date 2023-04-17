using System.Runtime.Serialization;

namespace EHonour.Utilities.EditChain
{
    [Serializable]
    public abstract class EditChain<T> where T : ISerializable
    {
        private List<TimestampedObject<T>> versions = new List<TimestampedObject<T>>();

        public void Update(T newVersion)
        {
            TimestampedObject<T> timestampedObject = new TimestampedObject<T>(newVersion);
            versions.Add(timestampedObject);
        }

        public T GetCurrentVersion()
        {
            return versions.Last().Value;
        }

        public List<T> GetAllVersions()
        {
            return versions.Select(x => x.Value).ToList();
        }

        public IEnumerable<T> GetAllVersionsMatching(Func<T, bool> predicate)
        {
            return GetAllVersions().Where(predicate);
        }
    }
}