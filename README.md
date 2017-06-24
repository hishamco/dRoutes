dRoutes
=======

Declarative Routing API for ASP.NET WebForms

### Features
* Declarative Routes using decorated attributes</li>
* Zero configuration</li>
* Integrated with ASP.NET Routing</li>

### Usage
* Single Routes
        
```vb
<Route("Home")>
Public Class Default
    Inherites Page
'
'
'
End Class
````

* Named Routes
          

```vb
<Route("NewsPress","News")>
Public Class News
    Inherites Page
'
'
'
End Class
```

* Parameterized Routes
* Multiple Routes
