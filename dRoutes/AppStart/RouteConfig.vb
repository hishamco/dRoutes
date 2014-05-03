Imports dRoutes.Routing

Public Class RouteConfig
    Public Shared Sub RegisterRoutes(routes As Web.Routing.RouteCollection)
        For Each routeInfo As RouteInfo In RouteManager.Routes
            routes.MapPageRoute(routeInfo.Name, routeInfo.Url, routeInfo.File)
        Next
    End Sub
End Class