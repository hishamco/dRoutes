Namespace Routing
    Public Class RouteCollection
        Implements ICollection(Of RouteInfo)

        Private ReadOnly _routes As New List(Of RouteInfo)

        Public Sub Add(item As RouteInfo) Implements ICollection(Of RouteInfo).Add
            _routes.Add(item)
        End Sub

        Public Sub Clear() Implements ICollection(Of RouteInfo).Clear
            _routes.Clear()
        End Sub

        Public Function Contains(item As RouteInfo) As Boolean Implements ICollection(Of RouteInfo).Contains
            Return _routes.Contains(item)
        End Function

        Public Sub CopyTo(array() As RouteInfo, arrayIndex As Integer) Implements ICollection(Of RouteInfo).CopyTo
            _routes.CopyTo(array, arrayIndex)
        End Sub

        Public ReadOnly Property Count As Integer Implements ICollection(Of RouteInfo).Count
            Get
                Return _routes.Count
            End Get
        End Property

        Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of RouteInfo).IsReadOnly
            Get
                Return False
            End Get
        End Property

        Public Function Remove(item As RouteInfo) As Boolean Implements ICollection(Of RouteInfo).Remove
            Return _routes.Remove(item)
        End Function

        Public Function GetEnumerator() As IEnumerator(Of RouteInfo) Implements IEnumerable(Of RouteInfo).GetEnumerator
            Return _routes.GetEnumerator()
        End Function

        Public Function GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator
            Return GetEnumerator()
        End Function
    End Class
End Namespace