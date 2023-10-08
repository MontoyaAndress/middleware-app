Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaDatos()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ObjWsEjemplo As New WsEjemploMedico.Service
        Dim Respuesta As String
        Respuesta = ObjWsEjemplo.FnAgregarMedico(Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text, Me.TextBox4.Text, Me.TextBox5.Text)
        MessageBox.Show(Respuesta)
        CargaDatos()
        Me.TextBox1.Clear()
        Me.TextBox2.Clear()
        Me.TextBox3.Clear()
        Me.TextBox4.Clear()
        Me.TextBox5.Clear()


    End Sub
    Private Sub CargaDatos()
        Dim ObjWsEjemplo As New WsEjemploMedico.Service
        Dim DsX As New DataSet

        DsX = ObjWsEjemplo.FnMostrarRegistros
        Me.DGVMedicos.DataSource = DsX.Tables("Medicos")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim ObjWsEjemplo As New WsEjemploMedico.Service
        Dim Respuesta As String
        Respuesta = ObjWsEjemplo.FnEliminarMedico(Me.TextBox1.Text)
        MessageBox.Show(Respuesta)
        CargaDatos()
        Me.TextBox1.Clear()
    End Sub

End Class
