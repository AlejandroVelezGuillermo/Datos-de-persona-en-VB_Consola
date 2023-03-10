Public Class Persona
    Protected Nombre As String
    Public FechaNacimiento As DateTime
    Public Property NombreProp() As String
        Get
            Return Nombre
        End Get
        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property

    Public Property FechaNacimientoProp() As DateTime
        Get
            Return FechaNacimiento
        End Get
        Set()
            FechaNacimiento = Value
        End Set
    End Property

    Public edad As Integer
    Public Property EdadProp() As Integer
        Get
            edad = (DateTime.Now.Year - FechaNacimiento.Year)

            Return edad
        End Get
        Set()

        End Set
    End Property

    Public Sub Persona(NombreProp As String, FechaNacimientoProp As String)
        Nombre = NombreProp
        FechaNacimiento = FechaNacimientoProp
    End Sub
    Public Sub Persona()
        Nombre = String.Empty
        FechaNacimiento = Nothing
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre.ToString() + " " + Convert.ToString(EdadProp)
    End Function
End Class
