namespace Lara
{
    /// <summary>
    /// Provides a easy way of building/filling entities with random information.
    /// </summary>
    public static class EntityBuilder
    {
        /// <summary>
        /// Initializes the Entity Builder class with the type to be returned.
        /// </summary>
        /// <typeparam name="T">The type of the object(s) to be builded and returned.</typeparam>
        public static IEntityBuilderFill<T> Fill<T>()
            where T : new()
        {
            return new EntityBuilderFill<T>();
        }
    }
}
