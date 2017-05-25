Public Class RestServiceImpl
	Implements IRestServiceImpl
	#Region "IRestServiceImpl Members"

	Public Function XMLData(id As String) As String Implements IRestServiceImpl.XMLData
        Return "You requested product ABC" & id
	End Function

	Public Function JSONData(id As String) As String Implements IRestServiceImpl.JSONData
        Return "You requested product  ABC" & id
	End Function

	#End Region
End Class
