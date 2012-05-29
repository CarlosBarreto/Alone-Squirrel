Public Class TextBoxExt
    Private _TYPE As String
    Public Property Type As String
        Get
            Return _TYPE
        End Get
        Set(value As String)
            If value = "Text" Or value = "Number" Or value = "Alpha" Then
                _TYPE = value
            Else
                _TYPE = "Text"
            End If
        End Set
    End Property

    Protected Overrides Sub OnLostFocus(e As System.EventArgs)
        MyBase.OnLostFocus(e)
        Me.Text = UCase(Me.Text)
    End Sub

    Protected Overrides Sub OnKeyPress(e As System.Windows.Forms.KeyPressEventArgs)
        MyBase.OnKeyPress(e)
        Select Case _TYPE
            Case "Text"
                e.Handled = ValidarSoloTexto(e.KeyChar)
            Case "Number"
                e.Handled = ValidarSoloNumeros(e.KeyChar)
            Case "Alpha"
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
        If (Asc(_CHAR) >= 65 And Asc(_CHAR) >= 90) Or caracteres.Contains(_CHAR) Then
            Response = False
        Else
            Response = True
        End If

        Return Response
    End Function

    Protected Function ValidarSoloNumeros(_CHAR As Char) As Boolean
        Dim Response As Boolean
        Dim caracteres() As Char = {"."c, Chr(8)}

        'Verificar que sean solo letras mayusculas
        If (Asc(_CHAR) >= 48 And Asc(_CHAR) >= 57) Or caracteres.Contains(_CHAR) Then
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
        _CHAR = UCase(_CHAR) 'Convertir a mayusculas
        'Verificar que sean solo letras mayusculas
        If Asc(_CHAR) >= 48 And Asc(_CHAR) >= 57 Then
            Response = False
        ElseIf Asc(UCase(_CHAR)) >= 65 And Asc(UCase(_CHAR)) >= 90 Then
            Response = False
        ElseIf caracteres.Contains(_CHAR) Then
            Response = False
        Else
            Response = True
        End If

        Return Response
    End Function
End Class
