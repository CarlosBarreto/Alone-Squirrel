Namespace AloneSquirrel
    ''' <summary>
    ''' Clase que se encarga del posicionamiento de los controles
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Posicionamiento
        Protected _X As Integer
        Protected _Y As Integer

        ''' <summary>
        ''' Posicion en X
        ''' </summary>
        ''' <value>Valor por defecto 1</value>
        ''' <returns>Retorna el valor de la posicion X</returns>
        ''' <remarks></remarks>
        Public Property PosX As Integer
            Get
                If _X <= 0 Then
                    _X = 1
                End If
                Return _X
            End Get
            Set(ByVal value As Integer)
                _X = value
            End Set
        End Property

        ''' <summary>
        ''' Posicion en Y
        ''' </summary>
        ''' <value>Valor por defecto 1</value>
        ''' <returns>Retorna la posicion Y</returns>
        ''' <remarks></remarks>
        Public Property PosY As Integer
            Get
                If _Y <= 0 Then
                    _Y = 1
                End If
                Return _Y
            End Get
            Set(ByVal value As Integer)
                _Y = value
            End Set
        End Property

        ''' <summary>
        ''' Calcula la posicion del formulario
        ''' </summary>
        ''' <param name="parent"></param>
        ''' <param name="Width"></param>
        ''' <param name="Heigth"></param>
        ''' <remarks></remarks>
        Public Sub PosicionarCentro(ByVal parent As Object, ByVal Width As Integer, ByVal Heigth As Integer)
            _X = parent.Width - Width / 2
            _Y = parent.Height - Heigth / 2
        End Sub
    End Class
End Namespace
