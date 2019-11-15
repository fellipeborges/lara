using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Lara
{
    public interface IEntityBuilderFill<T>
    {
        /// <summary>
        /// Adds a rule to override the default random function that is applied on the field.
        /// </summary>
        /// <param name="property">The property to have the rule applied. Example: x => x.Name</param>
        /// <param name="func">A delegate to the function that will be called to fill the property. Example: () => Randomizer.Person.Name()</param>
        IEntityBuilderFill<T> WithRule(Expression<Func<T, object>> property, Func<object> func);

        /// <summary>
        /// Adds a rule to override the default random function that is applied on the field.
        /// </summary>
        /// <param name="property">The property to have the rule applied. Example: x => x.Name</param>
        /// <param name="func">The value that will be filled in the property. Example: "John"</param>
        IEntityBuilderFill<T> WithRule(Expression<Func<T, object>> property, object value);

        /// <summary>
        /// Ignores a property on the entity. The property will be kept with its default value.
        /// </summary>
        /// <param name="property">The property to be ignored. Example: x => x.Age</param>
        IEntityBuilderFill<T> Except(Expression<Func<T, object>> property);

        /// <summary>
        /// Fills the entity with random information.
        /// </summary>
        /// <returns>An object of type T</returns>
        T Build();

        /// <summary>
        /// Fills a List of Entities with random information.
        /// </summary>
        /// <param name="quantity">The number of entities to be created and returned.</param>
        /// <returns>A List of objects of type T</returns>
        List<T> BuildList(int quantity);
    }
}
