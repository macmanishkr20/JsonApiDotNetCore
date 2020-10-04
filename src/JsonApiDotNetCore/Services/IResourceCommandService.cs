using JsonApiDotNetCore.Resources;

namespace JsonApiDotNetCore.Services
{
    /// <summary>
    /// Groups write operations.
    /// </summary>
    /// <typeparam name="TResource">The resource type.</typeparam>
    public interface IResourceCommandService<TResource> : 
        ICreateService<TResource>,
        IUpdateService<TResource>,
        IDeleteService<TResource>,
        IAddRelationshipService<TResource>,
        ISetRelationshipService<TResource>,
        IDeleteRelationshipService<TResource>,
        IResourceCommandService<TResource, int>
        where TResource : class, IIdentifiable<int>
    { }

    /// <summary>
    /// Groups write operations.
    /// </summary>
    /// <typeparam name="TResource">The resource type.</typeparam>
    /// <typeparam name="TId">The resource identifier type.</typeparam>
    public interface IResourceCommandService<TResource, in TId> : 
        ICreateService<TResource, TId>,
        IUpdateService<TResource, TId>,
        IDeleteService<TResource, TId>,
        IAddRelationshipService<TResource, TId>,
        ISetRelationshipService<TResource, TId>,
        IDeleteRelationshipService<TResource, TId>
        where TResource : class, IIdentifiable<TId>
    { }
}
