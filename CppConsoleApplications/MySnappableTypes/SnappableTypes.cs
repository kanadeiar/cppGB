using System;

namespace MySnappableTypes
{
    public interface IAppFunctionality
    {
        void DoIt();
    }
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class MyInfoAttribute : Attribute
    {
        public string CompanyName { get; set; }
    }
}
