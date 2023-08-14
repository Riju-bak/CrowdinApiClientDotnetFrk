﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crowdin.Api.Tests.Core.Resources {
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
    internal class SourceFiles {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SourceFiles() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Crowdin.Api.Tests.Core.Resources.SourceFiles", typeof(SourceFiles).Assembly);
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
        ///   Looks up a localized string similar to {
        ///  &quot;storageId&quot;: 61,
        ///  &quot;name&quot;: &quot;umbrella_app.docx&quot;,
        ///  &quot;branchId&quot;: 34,
        ///  &quot;directoryId&quot;: 4,
        ///  &quot;title&quot;: &quot;source_app_info&quot;,
        ///  &quot;type&quot;: &quot;docx&quot;,
        ///  &quot;importOptions&quot;: {
        ///    &quot;cleanTagsAggressively&quot;: false,
        ///    &quot;contentSegmentation&quot;: true,
        ///    &quot;srxStorageId&quot;: 1
        ///  },
        ///  &quot;excludedTargetLanguages&quot;: [
        ///    &quot;en&quot;,
        ///    &quot;es&quot;,
        ///    &quot;pl&quot;
        ///  ],
        ///  &quot;attachLabelIds&quot;: [
        ///    1
        ///  ]
        ///}.
        /// </summary>
        internal static string AddFile_Docx_Request {
            get {
                return ResourceManager.GetString("AddFile_Docx_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;storageId&quot;: 1,
        ///    &quot;importOptions&quot;: {
        ///        &quot;excludedElements&quot;: [
        ///            &quot;.div&quot;
        ///        ],
        ///        &quot;contentSegmentation&quot;: true,
        ///        &quot;srxStorageId&quot;: 2
        ///    }
        ///}.
        /// </summary>
        internal static string AddFile_Html_Request {
            get {
                return ResourceManager.GetString("AddFile_Html_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;storageId&quot;: 1,
        ///    &quot;importOptions&quot;: {
        ///        &quot;excludedElements&quot;: [
        ///            &quot;.div&quot;
        ///        ],
        ///        &quot;excludedFrontMatterElements&quot;: [
        ///            &quot;br&quot;
        ///        ],
        ///        &quot;contentSegmentation&quot;: true,
        ///        &quot;srxStorageId&quot;: 2
        ///    }
        ///}.
        /// </summary>
        internal static string AddFile_HtmlWithFrontMatter_Request {
            get {
                return ResourceManager.GetString("AddFile_HtmlWithFrontMatter_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///            &quot;storageId&quot;: 1,
        ///            &quot;name&quot;: &quot;fooFile.js&quot;,
        ///            &quot;branchId&quot;: 34,
        ///            &quot;directoryId&quot;: 4,
        ///            &quot;title&quot;: &quot;Foo File&quot;,
        ///            &quot;type&quot;: &quot;js&quot;,
        ///            &quot;exportOptions&quot;: {
        ///                &quot;exportPattern&quot;: &quot;/files/fooFile.js&quot;,
        ///                &quot;exportQuotes&quot;: &quot;double&quot;,
        ///            },
        ///        }.
        /// </summary>
        internal static string AddFile_JavaScript_Request {
            get {
                return ResourceManager.GetString("AddFile_JavaScript_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///            &quot;id&quot;: 44,
        ///            &quot;projectId&quot; : 1,
        ///            &quot;branchId&quot;: 34,
        ///            &quot;directoryId&quot;: 4,
        ///            &quot;name&quot;: &quot;fooFile.js&quot;,
        ///            &quot;title&quot;: &quot;Foo File&quot;,
        ///            &quot;type&quot;: &quot;js&quot;,
        ///            &quot;path&quot; : &quot;/files/fooFile.js&quot;,
        ///            &quot;status&quot; : &quot;active&quot;,
        ///            &quot;revisionId&quot;: 1,
        ///            &quot;priority&quot; : &quot;normal&quot;,
        ///            &quot;importOptions&quot;: null,
        ///            &quot;exportOptions&quot;: {
        ///                &quot;exportPattern&quot;: &quot;/files/fooFile.js&quot;,
        ///                &quot;exportQuotes&quot;: &quot;d [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AddFile_JavaScript_Response {
            get {
                return ResourceManager.GetString("AddFile_JavaScript_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;storageId&quot;: 1,
        ///    &quot;importOptions&quot;: {
        ///        &quot;excludedFrontMatterElements&quot;: [
        ///            &quot;br&quot;
        ///        ],
        ///        &quot;excludeCodeBlocks&quot;: true,
        ///        &quot;contentSegmentation&quot;: true,
        ///        &quot;srxStorageId&quot;: 2
        ///    }
        ///}.
        /// </summary>
        internal static string AddFile_MdxV1_Request {
            get {
                return ResourceManager.GetString("AddFile_MdxV1_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;storageId&quot;:1,&quot;name&quot;:&quot;Test name&quot;,&quot;importOptions&quot;:{&quot;scheme&quot;:{&quot;context&quot;:123,&quot;ua&quot;:1,&quot;ru&quot;:2,&quot;en&quot;:3}}}.
        /// </summary>
        internal static string AddFile_Request {
            get {
                return ResourceManager.GetString("AddFile_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///            &quot;data&quot;: {
        ///                &quot;id&quot;: 44,
        ///                &quot;projectId&quot;: 2,
        ///                &quot;branchId&quot;: 34,
        ///                &quot;directoryId&quot;: 4,
        ///                &quot;name&quot;: &quot;umbrella_app.xliff&quot;,
        ///                &quot;title&quot;: &quot;source_app_info&quot;,
        ///                &quot;type&quot;: &quot;xliff&quot;,
        ///                &quot;path&quot;: &quot;/directory1/directory2/filename.extension&quot;,
        ///                &quot;status&quot;: &quot;active&quot;,
        ///                &quot;revisionId&quot;: 1,
        ///                &quot;priority&quot;: &quot;normal&quot;,
        ///                &quot;importOptions&quot;: {
        ///                 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AddFile_Response {
            get {
                return ResourceManager.GetString("AddFile_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;data&quot;: {
        ///    &quot;url&quot;: &quot;https://production-enterprise-importer.downloads.crowdin.com/992000002/2/14.xliff?response-content-disposition=attachment%3B%20filename%3D%22APP.xliff%22&amp;X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&amp;X-Amz-Algorithm=AWS4-HMAC-SHA256&amp;X-Amz-Credential=AKIAIGJKLQV66ZXPMMEA%2F20190920%2Fus-east-1%2Fs3%2Faws4_request&amp;X-Amz-Date=20190920T093121Z&amp;X-Amz-SignedHeaders=host&amp;X-Amz-Expires=3600&amp;X-Amz-Signature=439ebd69a1b7e4c23e6d17891a491c94f832e0c82e4692dedb35a6cd1e624b62&quot;,
        ///    &quot;expireIn&quot;: &quot;2019- [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DownloadFilePreview_Response {
            get {
                return ResourceManager.GetString("DownloadFilePreview_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///            &quot;id&quot;: 44,
        ///            &quot;projectId&quot; : 2,
        ///            &quot;branchId&quot;: 34,
        ///            &quot;directoryId&quot;: 4,
        ///            &quot;name&quot;: &quot;fooFile.js&quot;,
        ///            &quot;title&quot;: &quot;Foo File&quot;,
        ///            &quot;type&quot;: &quot;js&quot;,
        ///            &quot;path&quot; : &quot;/files/fooFile.js&quot;,
        ///            &quot;status&quot; : &quot;active&quot;,
        ///            &quot;revisionId&quot;: 1,
        ///            &quot;priority&quot; : &quot;normal&quot;,
        ///            &quot;importOptions&quot;: null,
        ///            &quot;exportOptions&quot;: {
        ///                &quot;exportPattern&quot;: &quot;/files/fooFile.js&quot;,
        ///                &quot;exportQuotes&quot;: &quot;s [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EditFile_JavaScript_Response {
            get {
                return ResourceManager.GetString("EditFile_JavaScript_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{&quot;path&quot;:&quot;/exportOptions/exportQuotes&quot;,&quot;op&quot;:&quot;replace&quot;,&quot;value&quot;:&quot;single&quot;}].
        /// </summary>
        internal static string EditFile_JavaScriptRequest {
            get {
                return ResourceManager.GetString("EditFile_JavaScriptRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{&quot;path&quot;:&quot;/priority&quot;,&quot;op&quot;:&quot;replace&quot;,&quot;value&quot;:&quot;high&quot;},{&quot;path&quot;:&quot;/directoryId&quot;,&quot;op&quot;:&quot;replace&quot;,&quot;value&quot;:3}].
        /// </summary>
        internal static string EditFile_Request {
            get {
                return ResourceManager.GetString("EditFile_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///&quot;data&quot;: {
        ///&quot;id&quot;: 44,
        ///&quot;projectId&quot;: 2,
        ///&quot;branchId&quot;: 34,
        ///&quot;directoryId&quot;: 4,
        ///&quot;name&quot;: &quot;umbrella_app.xliff&quot;,
        ///&quot;title&quot;: &quot;source_app_info&quot;,
        ///&quot;type&quot;: &quot;xliff&quot;,
        ///&quot;path&quot;: &quot;/directory1/directory2/filename.extension&quot;,
        ///&quot;status&quot;: &quot;active&quot;,
        ///&quot;revisionId&quot;: 1,
        ///&quot;priority&quot;: &quot;normal&quot;,
        ///&quot;importOptions&quot;: {
        ///&quot;firstLineContainsHeader&quot;: false,
        ///&quot;importTranslations&quot;: true,
        ///&quot;scheme&quot;: {}
        ///},
        ///&quot;exportOptions&quot;: {
        ///&quot;exportPattern&quot;: &quot;/localization/%locale%/%file_name%.%file_extension%&quot;
        ///},
        ///&quot;excludedTargetLanguages&quot;: [
        ///&quot;en&quot;,
        ///&quot;es&quot;, [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EditFile_Response {
            get {
                return ResourceManager.GetString("EditFile_Response", resourceCulture);
            }
        }
    }
}
