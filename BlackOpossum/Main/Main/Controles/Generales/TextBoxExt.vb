Public Class TextBoxExt
    Public Enum ValidType
        Text = 1
        Number = 2
        Alpha = 3
        DateTime = 4
        Mon = 5
    End Enum

    Private _TYPE As ValidType '= ValidType.Text

    Public Property Type As ValidType
        Get
            Return _TYPE
        End Get

        Set(value As ValidType)
            If value = ValidType.Text Or value = ValidType.Number Or value = ValidType.Alpha Then
                _TYPE = value
            Else
                _TYPE = ValidType.Text
            End If
        End Set
    End Property

    Protected Overrides Sub OnLostFocus(e As System.EventArgs)
        MyBase.OnLostFocus(e)
        Me.Text = UCase(Me.Text)
        Select Case _TYPE
            Case ValidType.Mon
                'Buscar si ya cuenta con el caracter $
                If InStr("$", Me.Text) = 0 Then Me.Text = "$" & Me.Text
        End Select
    End Sub

    Protected Overrides Sub OnKeyPress(e As System.Windows.Forms.KeyPressEventArgs)
        MyBase.OnKeyPress(e)
        Select Case _TYPE
            Case ValidType.Text '"Text"
                e.Handled = ValidarSoloTexto(e.KeyChar)
            Case ValidType.Number ' "Number"
                e.Handled = ValidarSoloNumeros(e.KeyChar)
            Case ValidType.Alpha '"Alpha"
                e.Handled = ValidarAlpha(e.KeyChar)
            Case ValidType.DateTime
                e.Handled = ValidarAlpha(e.KeyChar)
            Case ValidType.Mon
                e.Handled = ValidarAlpha(e.KeyChar)
        End Select
    End Sub

    'Validación, Text
    Protected Function ValidarSoloTexto(_CHAR As Char) As Boolean
        Dim Response As Boolean
        Dim caracteres() As Char = {"-"c, "_"c, " "c, "."c, ","c, ";"c, ":"c, Chr(8)}

        Response = True
        _CHAR = UCase(_CHAR)
        'Verificar que sean solo letras mayusculas
        If (Asc(_CHAR) >= 65 And Asc(_CHAR) <= 90) Or caracteres.Contains(_CHAR) Then
            Response = False
        Else
            Response = True
        End If

        Return Response
    End Function

    Protected Function ValidarSoloNumeros(_CHAR As Char) As Boolean
        Dim Response As Boolean
        Dim caracteres() As Char = {"-"c, "("c, ")"c, "+"c, "."c, Chr(8)}

        'Verificar que sean solo letras mayusculas
        If (Asc(_CHAR) >= 48 And Asc(_CHAR) <= 57) Or caracteres.Contains(_CHAR) Then
            Response = False
        Else
            Response = True
        End If

        Return Response
    End Function

    Protected Function ValidarAlpha(_CHAR As Char) As Boolean
        Dim Response As Boolean
        Dim caracteres() As Char = {"%"c, "&"c, "$"c, "#"c, "/"c, "-"c, "_"c, " "c, "@"c, "."c, ","c, ";"c, ":"c, Chr(8)}

        Response = True
        '_CHAR = UCase(_CHAR) 'Convertir a mayusculas
        'Verificar que sean solo letras mayusculas
        If Asc(_CHAR) >= 48 And Asc(_CHAR) <= 57 Then
            Response = False
        ElseIf Asc(UCase(_CHAR)) >= 65 And Asc(UCase(_CHAR)) <= 90 Then
            Response = False
        ElseIf caracteres.Contains(_CHAR) Then
            Response = False
        Else
            Response = True
        End If

        Return Response
    End Function
End Class
