# EditChain

EditChain is a lightweight library for tracking previous versions of objects. Works with anything that implements ISerializable or is marked with the [Serializable] attribute.

## API
To use EditChain, just wrap the object you want to track in an EditChain.

#### Update(T newVersion)
Pushes a new version of the object.

#### GetCurrentVersion()
Gets the most recently pushed version of the object.

#### GetAllVersions()
Returns a list of all versions of the object.

#### GetAllVersionsMatching(Func<T, bool> predicate)
Lets you pass a predicate and returns any versions of the object that match the predicate.