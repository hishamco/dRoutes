Imports System.Web.Routing
Imports dRoutes.Routing
Imports System.Reflection

Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        RouteManager.Load()
        Dim types = Assembly.GetExecutingAssembly().GetTypes().Where(Function(t) t.BaseType.FullName = "System.Web.UI.Page" AndAlso t.GetCustomAttributes(False).OfType(Of Routing.Route).Any())
        Dim routes As New Routing.RouteCollection()
        For Each type In types
            Dim url As String = type.GetCustomAttributes(GetType(Routing.Route), False).Single().Url
            If RouteManager.Routes.Any(Function(r) r.Url = url) = False Then
                routes.Add(New RouteInfo() With {.Name = "", .Url = url, .File = String.Format("~/{0}.aspx", type.Name)})
            End If
        Next
        RouteManager.Save(routes)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
    End Sub

End Class