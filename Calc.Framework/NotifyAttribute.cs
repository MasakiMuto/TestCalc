using System;
using System.Diagnostics;

namespace Calc.Framework
{
    [Conditional("NEVER_USED_AT_RUNTIME")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    internal sealed class NotifyAttribute : Attribute,
        // option, you can customize naming convention rule
        NotifyAttribute.ILeadingUnderscore
    {
        // naming convention markers
        internal interface IPlain { }
        internal interface ILeadingUnderscore { }
        internal interface ITrailingUnderscore { }

        /// <summary>
        /// No option.
        /// </summary>
        public NotifyAttribute() { }

        /// <summary>
        /// Specify options.
        /// </summary>
        /// <param name="compareMethod">Comppare kind for raise property changed.</param>
//        public NotifyAttribute(NotifyCompareMethod compareMethod) { }
    }
}