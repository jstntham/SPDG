﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPDG.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SPDG.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     &lt;Compile Include=&quot;sps\{0}&quot; /&gt;.
        /// </summary>
        internal static string strCompileInclude {
            get {
                return ResourceManager.GetString("strCompileInclude", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Project ToolsVersion=&quot;4.0&quot; DefaultTargets=&quot;Build&quot; xmlns=&quot;http://schemas.microsoft.com/developer/msbuild/2003&quot;&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;Configuration Condition=&quot; &apos;$(Configuration)&apos; == &apos;&apos; &quot;&gt;Debug&lt;/Configuration&gt;
        ///    &lt;Platform Condition=&quot; &apos;$(Platform)&apos; == &apos;&apos; &quot;&gt;AnyCPU&lt;/Platform&gt;
        ///    &lt;ProductVersion&gt;8.0.30703&lt;/ProductVersion&gt;
        ///    &lt;SchemaVersion&gt;2.0&lt;/SchemaVersion&gt;
        ///    &lt;ProjectGuid&gt;&lt;/ProjectGuid&gt;
        ///    &lt;OutputType&gt;Library&lt;/OutputType&gt;
        ///    &lt;AppDesignerFolder&gt;Properties [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string strCSPROJ {
            get {
                return ResourceManager.GetString("strCSPROJ", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///
        ///namespace {0}
        ///&lt;&lt;
        ///    interface IExecuteDataReader
        ///    &lt;&lt;
        ///        System.Data.SqlClient.SqlDataReader ExecuteDataReader();
        ///    &gt;&gt;
        ///&gt;&gt;.
        /// </summary>
        internal static string strIExecuteDataReader {
            get {
                return ResourceManager.GetString("strIExecuteDataReader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public System.Data.SqlClient.SqlDataReader ExecuteDataReader()
        ///        &lt;&lt;
        ///            return base.ExecuteDataReader({0});
        ///        &gt;&gt;.
        /// </summary>
        internal static string strIExecuteDataReaderImplementation {
            get {
                return ResourceManager.GetString("strIExecuteDataReaderImplementation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///
        ///namespace {0}
        ///&lt;&lt;
        ///    interface IExecuteDataSet
        ///    &lt;&lt;
        ///        System.Data.DataSet ExecuteDataSet();
        ///    &gt;&gt;
        ///&gt;&gt;.
        /// </summary>
        internal static string strIExecuteDataSet {
            get {
                return ResourceManager.GetString("strIExecuteDataSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to         public System.Data.DataSet ExecuteDataSet()
        ///        &lt;&lt;
        ///            return base.ExecuteDataSet({0});
        ///        &gt;&gt;.
        /// </summary>
        internal static string strIExecuteDataSetImplementation {
            get {
                return ResourceManager.GetString("strIExecuteDataSetImplementation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///
        ///namespace {0}
        ///&lt;&lt;
        ///    interface IExecuteNonQuery
        ///    &lt;&lt;
        ///        void ExecuteNonQuery();
        ///    &gt;&gt;
        ///&gt;&gt;.
        /// </summary>
        internal static string strIExecuteNonQuery {
            get {
                return ResourceManager.GetString("strIExecuteNonQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to         public void ExecuteNonQuery()
        ///        &lt;&lt;
        ///            base.ExecuteNonQuery({0});
        ///        &gt;&gt;.
        /// </summary>
        internal static string strIExecuteNonQueryImplementation {
            get {
                return ResourceManager.GetString("strIExecuteNonQueryImplementation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///
        ///namespace {0}
        ///&lt;&lt;
        ///    interface IExecuteScalar
        ///    &lt;&lt;
        ///        object ExecuteScalar();
        ///    &gt;&gt;
        ///&gt;&gt;.
        /// </summary>
        internal static string strIExecuteScalar {
            get {
                return ResourceManager.GetString("strIExecuteScalar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to         public object ExecuteScalar()
        ///        &lt;&lt;
        ///            return base.ExecuteScalar({0});
        ///        &gt;&gt;.
        /// </summary>
        internal static string strIExecuteScalarImplementation {
            get {
                return ResourceManager.GetString("strIExecuteScalarImplementation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///
        ///namespace {0}
        ///&lt;&lt;
        ///    interface IExecuteXML
        ///    &lt;&lt;
        ///        string ExecuteXML();
        ///    &gt;&gt;
        ///&gt;&gt;.
        /// </summary>
        internal static string strIExecuteXML {
            get {
                return ResourceManager.GetString("strIExecuteXML", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to         public string ExecuteXML()
        ///        &lt;&lt;
        ///            return base.ExecuteXML({0});
        ///        &gt;&gt;.
        /// </summary>
        internal static string strIExecuteXMLImplementation {
            get {
                return ResourceManager.GetString("strIExecuteXMLImplementation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to         public {0} {1} &lt;&lt; get; set; &gt;&gt;.
        /// </summary>
        internal static string strProperty {
            get {
                return ResourceManager.GetString("strProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Data;
        ///using System.Data.SqlClient;
        ///using System.Text;
        ///using System.Reflection;
        ///using System.Configuration;
        ///
        ///namespace {0}
        ///&lt;&lt;
        ///    public abstract class spbase&lt;tfields&gt; : IDisposable
        ///    &lt;&lt;
        ///        private SqlParameter[] sqlparams &lt;&lt; get; set; &gt;&gt;
        ///        private SqlConnection SQLConnection &lt;&lt; get; set; &gt;&gt;
        ///        protected abstract string StoredProcedureName &lt;&lt; get; &gt;&gt;
        ///        protected abstract bool[] eFieldsIO &lt;&lt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string strSPBase {
            get {
                return ResourceManager.GetString("strSPBase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///
        ///namespace {0}
        ///&lt;&lt;
        ///    public class {1}: spbase&lt;{1}.eFields&gt;{2}
        ///    &lt;&lt;
        ///        {3}
        ///       protected override bool[] eFieldsIO &lt;&lt; get &lt;&lt; return new bool[] &lt;&lt;{8}&gt;&gt;; &gt;&gt; &gt;&gt;
        ///
        ///        public {1} ( {6} )
        ///        &lt;&lt;
        ///{7}
        ///        &gt;&gt;
        ///
        ///{4}
        ///
        ///{5}
        ///
        ///        protected override string StoredProcedureName &lt;&lt; get &lt;&lt; return &quot;{1}&quot;; &gt;&gt; &gt;&gt;
        ///    &gt;&gt;
        ///&gt;&gt;.
        /// </summary>
        internal static string strSPClass {
            get {
                return ResourceManager.GetString("strSPClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public {0} ( {1} )
        ///&lt;&lt;
        ///{2}        
        ///&gt;&gt;.
        /// </summary>
        internal static string strSPConstructor {
            get {
                return ResourceManager.GetString("strSPConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to             this.{0} = {0};.
        /// </summary>
        internal static string strSPConstructorBodyEntry {
            get {
                return ResourceManager.GetString("strSPConstructorBodyEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Data;
        ///using System.Xml;
        ///using System.Data.SqlClient;
        ///using System.Collections;
        ///
        ///    /// &lt;summary&gt;
        ///    /// The SqlHelper class is intended to encapsulate high performance, scalable best practices for 
        ///    /// common uses of SqlClient
        ///    /// &lt;/summary&gt;
        ///    public sealed class SqlHelper
        ///    {
        ///        #region private utility methods &amp; constructors
        ///
        ///        // Since this class provides only static methods, make the default constructor private to prevent 
        ///        // inst [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string strSQLHelper {
            get {
                return ResourceManager.GetString("strSQLHelper", resourceCulture);
            }
        }
    }
}
