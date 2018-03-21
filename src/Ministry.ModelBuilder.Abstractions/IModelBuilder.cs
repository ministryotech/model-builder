using System.Diagnostics.CodeAnalysis;

namespace Ministry.ModelBuilder.Abstractions
{
    /// <summary>
    /// Base Builder Interface
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public interface IModelBuilder<out TModel, in TSourceObject>
    {
        /// <summary>
        /// Builds the model.
        /// </summary>
        /// <param name="sourceObject">The source object to trigger the build, be it an entity or an identifier.</param>
        /// <returns>A Model</returns>
        TModel Build(TSourceObject sourceObject);
    }

    /// <summary>
    /// Base Builder Interface
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public interface IModelBuilder<out TModel, in TSourceObject, in TSecondObject>
    {
        /// <summary>
        /// Builds the model.
        /// </summary>
        /// <param name="sourceObject">The source object to trigger the build, be it an entity or an identifier.</param>  
        /// <param name="secondObject">A second parameter to use.</param>
        /// <returns>A Model</returns>
        TModel Build(TSourceObject sourceObject, TSecondObject secondObject);
    }

    /// <summary>
    /// Base Builder Interface
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public interface IModelBuilder<out TModel, in TSourceObject, in TSecondObject, in TThirdObject>
    {
        /// <summary>
        /// Builds the model.
        /// </summary>
        /// <param name="sourceObject">The source object to trigger the build, be it an entity or an identifier.</param>  
        /// <param name="secondObject">A second parameter to use.</param>
        /// <param name="thirdObject">A third parameter to use.</param>
        /// <returns>A Model</returns>
        TModel Build(TSourceObject sourceObject, TSecondObject secondObject, TThirdObject thirdObject);
    }
}