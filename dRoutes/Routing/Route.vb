Namespace Routing
    <AttributeUsage(AttributeTargets.Class, AllowMultiple:=False)>
    Public Class Route
        Inherits Attribute

        Private ReadOnly _url As String
        Public Sub New(routeUrl As String)
            _url = routeUrl
        End Sub

        Public ReadOnly Property Url As String
            Get
                Return _url
            End Get
        End Property
    End Class
End Namespace