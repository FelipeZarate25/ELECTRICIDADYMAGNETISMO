Public Class Form1

    Dim N, I As Integer
    Dim A(), B(), C() As Double


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        N = TextBox1.Text
        'NUMERO DE COLUMNAS A
        DataGridView1.ColumnCount = N

        'NUMERO DE FILAS A
        DataGridView1.RowCount = 1


        'NUMERO DE COLUMNAS B
        DataGridView2.ColumnCount = N

        'NUMERO DE FILAS B
        DataGridView2.RowCount = 1



    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'REDIMENCIONAR LOS VECTORES
        ReDim A(N)
        ReDim B(N)
        ReDim C(N)


        'INTRODUCIR EL VECTOR A
        For I = 0 To N - 1
            A(I) = DataGridView1.Item(I, 0).Value
        Next

        'INTRODUCIR EL VECTOR B
        For I = 0 To N - 1
            B(I) = DataGridView2.Item(I, 0).Value
        Next



        'SUMAR A+B
        For I = 0 To N - 1
            C(I) = A(I) + B(I)
        Next

        'NUMERO DE COLUMNAS C
        DataGridView3.ColumnCount = N

        'NUMERO DE FILAS C
        DataGridView3.RowCount = 1

        'MOSTRAR C
        For I = 0 To N - 1
            DataGridView3.Item(I, 0).Value = C(I)
        Next

    End Sub


End Class
