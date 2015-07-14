﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class BaseResponseUnmarshaller : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 7 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"

    protected void AddCommonUsingStatements()
    {

        
        #line default
        #line hidden
        
        #line 10 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Globalization;\r\nus" +
        "ing System.IO;\r\nusing System.Net;\r\nusing System.Text;\r\nusing System.Xml.Serializ" +
        "ation;\r\n\r\nusing ");

        
        #line default
        #line hidden
        
        #line 19 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));

        
        #line default
        #line hidden
        
        #line 19 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(".Model;\r\nusing Amazon.Runtime;\r\nusing Amazon.Runtime.Internal;\r\nusing Amazon.Runt" +
        "ime.Internal.Transform;\r\nusing Amazon.Runtime.Internal.Util;\r\n");

        
        #line default
        #line hidden
        
        #line 24 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"

    }

    // Set to true when the service model specifies a shape that should be wrapped in a response. ElastiCache CreateCacheCluster is an example of this.
    public bool IsWrapped { get; set; }

    // set to the name of the member in the base Result class for operations where response data is moved from the result
    // class into a structure member. If not set, the response members are assumed to be in the result base class itself.
    public string WrappedResultMember { get; set; }

    // The operation to unmarshall a response from
    public Operation Operation { get; set; }

    Shape _structure;

	// Set if we are generating what is effectively a void response from an operation - no result class or other
	// members were generated
	public bool HasSuppressedResult { get; set; }

	public string BaseException { get; set; }

    // The shape of the response
    public Shape Structure 
    { 
        get 
        { 
            if(this.Operation != null)
			{
				if(this.Operation.IsResponseWrapped)
					return this.Operation.ResponseStructure.Members[0].Shape;
				else
					return this.Operation.ResponseStructure;
			}
            return this._structure; 
        }
        set { this._structure = value; }
    }

    public string UnmarshallerBaseName
    {
        get
        {
            if(this.Operation != null)
                return this.Operation.Name;

            return this.Structure.Name;
        }
    }

    protected void AddResponseSingletonMethod()
    {

        
        #line default
        #line hidden
        
        #line 75 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("        private static ");

        
        #line default
        #line hidden
        
        #line 76 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 76 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("ResponseUnmarshaller _instance = new ");

        
        #line default
        #line hidden
        
        #line 76 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 76 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("ResponseUnmarshaller();        \r\n\r\n\t\tinternal static ");

        
        #line default
        #line hidden
        
        #line 78 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 78 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("ResponseUnmarshaller GetInstance()\r\n\t\t{\r\n\t\t\treturn _instance;\r\n\t\t}\r\n\t\tpublic stat" +
        "ic ");

        
        #line default
        #line hidden
        
        #line 82 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 82 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("ResponseUnmarshaller Instance\r\n\t\t{\r\n\t\t\tget\r\n\t\t\t{\r\n\t\t\t\treturn _instance;\r\n\t\t\t}\r\n\t\t" +
        "}\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 90 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"

    }

    protected void AddStructureSingletonMethod()
    {

        
        #line default
        #line hidden
        
        #line 95 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("        private static ");

        
        #line default
        #line hidden
        
        #line 96 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 96 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("Unmarshaller _instance = new ");

        
        #line default
        #line hidden
        
        #line 96 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 96 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("Unmarshaller();        \r\n\r\n\t\tpublic static ");

        
        #line default
        #line hidden
        
        #line 98 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));

        
        #line default
        #line hidden
        
        #line 98 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("Unmarshaller Instance\r\n\t\t{\r\n\t\t\tget\r\n\t\t\t{\r\n\t\t\t\treturn _instance;\r\n\t\t\t}\r\n\t\t}\r\n");

        
        #line default
        #line hidden
        
        #line 105 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"

	}

    // Generates code to parse present header members into the response object
	protected void UnmarshallHeaders()
	{
		if( this.Operation.ResponseHeaderMembers.Count() > 0 )
		{
			foreach (var member in this.Operation.ResponseHeaderMembers)
			{

        
        #line default
        #line hidden
        
        #line 115 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("\t\t\tif (context.ResponseData.IsHeaderPresent(\"");

        
        #line default
        #line hidden
        
        #line 116 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 116 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("\"))\r\n\t\t\t\tresponse.");

        
        #line default
        #line hidden
        
        #line 117 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 117 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(" = context.ResponseData.GetHeaderValue(\"");

        
        #line default
        #line hidden
        
        #line 117 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 117 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("\");\r\n");

        
        #line default
        #line hidden
        
        #line 118 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
			
			}
		}
	}

    // Generates code to set the status code of the response, example: 404, 200, etc
	protected void ProcessStatusCode()
	{
		if( this.Operation.ResponseStatusCodeMember != null)
		{

        
        #line default
        #line hidden
        
        #line 128 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("\t\t\tresponse.");

        
        #line default
        #line hidden
        
        #line 129 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.ResponseStatusCodeMember.PropertyName));

        
        #line default
        #line hidden
        
        #line 129 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(" = (int)context.ResponseData.StatusCode;\r\n");

        
        #line default
        #line hidden
        
        #line 130 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
						
		}
	}
/*
    // Generates code to set the response body to the response stream if the operation has a response stream member
	protected void ProcessResponseStream_()
	{
		if( this.Operation.ResponseStreamingMember != null)
		{

        
        #line default
        #line hidden
        
        #line 139 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write("\t\t\tresponse.");

        
        #line default
        #line hidden
        
        #line 140 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.ResponseStreamingMember.PropertyName));

        
        #line default
        #line hidden
        
        #line 140 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
this.Write(" = context.Stream;\r\n");

        
        #line default
        #line hidden
        
        #line 141 "C:\dev\net\service.updates\sdk\src\ServiceClientGenerator\Generators\BaseResponseUnmarshaller.tt"
						
		}
	}
*/

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
