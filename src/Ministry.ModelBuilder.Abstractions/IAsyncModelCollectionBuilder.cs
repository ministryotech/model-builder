using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Ministry.ModelBuilder.Abstractions
{
    /// <summary>
    /// Base Builder Interface
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public interface IAsyncModelCollectionBuilder<TModel, in TSourceObject>
    {
        /// <summary>
        /// Builds the model collection.
        /// </summary>
        /// <param name="sourceObject">The source object to trigger the build, be it an entity or an identifier.</param>
        /// <returns>A Model collection</returns>
        Task<ICollection<TModel>> BuildCollectionAsync(TSourceObject sourceObject);
    }

    /// <summary>
    /// Base Builder Interface
    /// </summary>       
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public interface IAsyncModelCollectionBuilder<TModel, in TSourceObject, in TSecondObject>
    {
        /// <summary>
        /// Builds the model collection.
        /// </summary>
        /// <param name="sourceObject">The source object to trigger the build, be it an entity or an identifier.</param>
        /// <param name="secondObject">A second parameter to use.</param>            
        /// <returns>A Model collection</returns>
        Task<ICollection<TModel>> BuildCollectionAsync(TSourceObject sourceObject, TSecondObject secondObject);
    }

    /// <summary>
    /// Base Builder Interface
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public interface IAsyncModelCollectionBuilder<TModel, in TSourceObject, in TSecondObject, in TThirdObject>
    {
        /// <summary>
        /// Builds the model collection.
        /// </summary>
        /// <param name="sourceObject">The source object to trigger the build, be it an entity or an identifier.</param>
        /// <param name="secondObject">A second parameter to use.</param>            
        /// <param name="thirdObject">A third parameter to use.</param>            
        /// <returns>A Model collection</returns>
        Task<ICollection<TModel>> BuildCollectionAsync(TSourceObject sourceObject, TSecondObject secondObject, TThirdObject thirdObject);
    }
}