Imports System.ServiceModel
Imports System.ServiceModel.Web


<ServiceContract> _
Public Interface IRestServiceImpl
	<OperationContract> _
	<WebInvoke(Method := "GET", ResponseFormat := WebMessageFormat.Xml, BodyStyle := WebMessageBodyStyle.Wrapped, UriTemplate := "xml/{id}")> _
	Function XMLData(id As String) As String

	<OperationContract> _
	<WebInvoke(Method := "GET", ResponseFormat := WebMessageFormat.Json, BodyStyle := WebMessageBodyStyle.Wrapped, UriTemplate := "json/{id}")> _
	Function JSONData(id As String) As String
End Interface
