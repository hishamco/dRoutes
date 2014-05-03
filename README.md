dRoutes
=======

Declarative Routing API for ASP.NET WebForms

<h3>Features</h3>
<ul>
    <li>Declarative Routes using decorated attributes</li>
    <li>Zero configuration</li>
    <li>Integrated with ASP.NET Routing</li>
</ul>
<h3>Usage</h3>
<ul>
    <li>
        Single Routes
        <pre>
<b>&lt;Route("Home")&gt;</b>
Public Class Default
    Inherites Page
'
'
'
End Class
</pre>
    </li>
    <li>
        Named Routes
          <pre>
<b>&lt;Route("NewsPress","News")&gt;</b>
Public Class News
    Inherites Page
'
'
'
End Class
</pre>
        </li>
        <li>Parameterized Routes</li>
        <li>Multiple Routes</li>
</ul>
