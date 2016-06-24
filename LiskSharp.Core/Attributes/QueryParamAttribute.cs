using System;

namespace LiskSharp.Core.Attributes
{
    /// <summary>
    /// QueryParamAttribute flags a property for including in request query parameters
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class QueryParamAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
