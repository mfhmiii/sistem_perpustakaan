Public Class Perpustakaan
    Public Shared data_perpus As DataPerpus
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_perpus = New DataPerpus
        UpdateDataTableArrayList()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tambah_koleksi = New TambahKoleksi
        tambah_koleksi.Show()
    End Sub

    Public Sub UpdateDataTableArrayList()
        DataGridView1.Rows.Clear()
        For Each rowKoleksi In data_perpus.getKoleksiDatatable()
            Dim dataTable As String() = {rowKoleksi(0),
                                         rowKoleksi(1),
                                         rowKoleksi(2),
                                         rowKoleksi(3),
                                         rowKoleksi(4),
                                         rowKoleksi(5),
                                         rowKoleksi(6),
                                         rowKoleksi(7),
                                         rowKoleksi(8),
                                         rowKoleksi(9)}
            DataGridView1.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub Perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDataTableArrayList()
    End Sub
End Class
