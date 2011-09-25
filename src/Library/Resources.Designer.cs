//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpTest.Net
{
    using System;
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This partial class was auto-generated by the StronglyTypedResourceBuilder
    // partial class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal partial class Resources
    {
        private static global::System.Resources.ResourceManager resourceMan;
        private static global::System.Globalization.CultureInfo resourceCulture;
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CSharpTest.Net.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
        /// <summary>
        ///   Looks up a localized string similar to Failed to compress/decompress the full input stream..
        /// </summary>
        internal static string IOStreamCompressionFailed
        {
            get
            {
                return ResourceManager.GetString("IOStreamCompressionFailed", resourceCulture);
            }
        }
        /// <summary>
        ///   Looks up a localized string similar to Failed to read from input stream..
        /// </summary>
        internal static string IOStreamFailedToRead
        {
            get
            {
                return ResourceManager.GetString("IOStreamFailedToRead", resourceCulture);
            }
        }
        /// <summary>
        ///   Looks up a localized string similar to The running process must first exit..
        /// </summary>
        internal static string ProcessRunnerAlreadyRunning
        {
            get
            {
                return ResourceManager.GetString("ProcessRunnerAlreadyRunning", resourceCulture);
            }
        }
  

        /// <summary>
        /// Invalid file extension: '{0}'.
        /// </summary>
        public static string InvalidFileExtension(string ext)
        {
            return String.Format(resourceCulture, CSharpTest.Net.Resources.FormatStrings.InvalidFileExtension_string_ext_, ext);
        }
        /// <summary>
        /// The type {0} is not convertable from a string.
        /// </summary>
        public static string StringConverterTryParse(System.Type type)
        {
            return String.Format(resourceCulture, CSharpTest.Net.Resources.FormatStrings.StringConverterTryParse_System_Type_type_, type);
        }
        /// <summary>
        /// The singleton for type {0} threw an excpetion.
        /// </summary>
        public static string FailedToConstructSingleton(System.Type type)
        {
            return String.Format(resourceCulture, CSharpTest.Net.Resources.FormatStrings.FailedToConstructSingleton_System_Type_type_, type);
        }
        
        /// <summary>
        /// Returns the raw format strings.
        /// </summary>
        [global::System.Diagnostics.DebuggerStepThroughAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("CSharpTest.Net.Generators", "1.11.426.305")]
        public static partial class FormatStrings
        {
            /// <summary>
            /// Invalid file extension: '{0}'.
            /// </summary>
            public static string InvalidFileExtension_string_ext_ { get { return ResourceManager.GetString("InvalidFileExtension(string ext)", resourceCulture); } }
            /// <summary>
            /// The type {0} is not convertable from a string.
            /// </summary>
            public static string StringConverterTryParse_System_Type_type_ { get { return ResourceManager.GetString("StringConverterTryParse(System.Type type)", resourceCulture); } }
            /// <summary>
            /// The singleton for type {0} threw an excpetion.
            /// </summary>
            public static string FailedToConstructSingleton_System_Type_type_ { get { return ResourceManager.GetString("FailedToConstructSingleton(System.Type type)", resourceCulture); } }
        }
        
        /// <summary>
        /// Returns the raw exception strings.
        /// </summary>
        [global::System.Diagnostics.DebuggerStepThroughAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("CSharpTest.Net.Generators", "1.11.426.305")]
        public static partial class ExceptionStrings
        {
            /// <summary>
            /// Formats a message for an exception
            /// </summary>
            internal static string SafeFormat(string message, params object[] args)
            {
                try
                {
                    return string.Format(resourceCulture, message, args);
                }
                catch
                {
                    return message ?? string.Empty;
                }
            }
            /// <summary>
            /// </summary>
            internal static string HelpLinkFormat(int hResult, string typeName)
            {
                return SafeFormat("", hResult, typeName);
            }
            /// <summary>
            /// Debug Assertion Failed: {0}
            /// </summary>
            public static string DebugAssertionFailedException_string_message_ { get { return ResourceManager.GetString("DebugAssertionFailedException(string message)", resourceCulture); } }
        }
    
     }

    /// <summary>
    /// Exception class: DebugAssertionFailedException
    /// Debug Assertion Failed: {0}
    /// </summary>
    [System.SerializableAttribute()]
    [global::System.Diagnostics.DebuggerStepThroughAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("CSharpTest.Net.Generators", "1.11.426.305")]
    public partial class DebugAssertionFailedException : System.ApplicationException
    {
        /// <summary>
        /// Serialization constructor
        /// </summary>
        protected DebugAssertionFailedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
        /// <summary>
        /// Used to create this exception from an hresult and message bypassing the message formatting
        /// </summary>
        internal static System.Exception Create(int hResult, string message)
        {
            return new DebugAssertionFailedException((System.Exception)null, hResult, message);
        }
        /// <summary>
        /// Constructs the exception from an hresult and message bypassing the message formatting
        /// </summary>
        protected DebugAssertionFailedException(System.Exception innerException, int hResult, string message) : base(message, innerException)
        {
            base.HResult = hResult;
            base.HelpLink = CSharpTest.Net.Resources.ExceptionStrings.HelpLinkFormat(HResult, GetType().FullName);
        }
        /// <summary>
        /// Debug Assertion Failed: {0}
        /// </summary>
        public DebugAssertionFailedException(string message)
        	: this((System.Exception)null, -1, CSharpTest.Net.Resources.ExceptionStrings.SafeFormat(CSharpTest.Net.Resources.ExceptionStrings.DebugAssertionFailedException_string_message_, message))
        {
        }
        /// <summary>
        /// Debug Assertion Failed: {0}
        /// </summary>
        public DebugAssertionFailedException(string message, System.Exception innerException)
        	: this(innerException, -1, CSharpTest.Net.Resources.ExceptionStrings.SafeFormat(CSharpTest.Net.Resources.ExceptionStrings.DebugAssertionFailedException_string_message_, message))
        {
        }
        /// <summary>
        /// if(condition == false) throws Debug Assertion Failed: {0}
        /// </summary>
        public static void Assert(bool condition, string message)
        {
            if (!condition) throw new DebugAssertionFailedException(message);
        }
    }


}

