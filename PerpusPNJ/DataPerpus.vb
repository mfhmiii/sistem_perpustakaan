Imports System.Text

Public Class DataPerpus
    Private nama_koleksi As String
    Private jenis_koleksi As String
    Private deskripsi As String
    Private penerbit As String
    Private tahun_terbit As Integer
    Private lokasi_rak As String
    Private tgl_masuk As Date
    Private stok As String
    Private bahasa As String
    Private kategori As New List(Of String)
    Private pict As String
    Private koleksiDataTable As New ArrayList()

    Public Property GSnama_koleksi As String
        Get
            Return nama_koleksi
        End Get
        Set(value As String)
            nama_koleksi = value
        End Set
    End Property

    Public Property GSjenis_koleksi As String
        Get
            Return jenis_koleksi
        End Get
        Set(value As String)
            jenis_koleksi = value
        End Set
    End Property
    Public Property GSdeskripsi As String
        Get
            Return deskripsi
        End Get
        Set(value As String)
            deskripsi = value
        End Set
    End Property
    Public Property GSpenerbit As String
        Get
            Return penerbit
        End Get
        Set(value As String)
            penerbit = value
        End Set
    End Property
    Public Property GStahun_terbit As Integer
        Get
            Return tahun_terbit
        End Get
        Set(value As Integer)
            tahun_terbit = value
        End Set
    End Property
    Public Property GSlokasi_rak As String
        Get
            Return lokasi_rak
        End Get
        Set(value As String)
            lokasi_rak = value
        End Set
    End Property

    Public Property GStgl_masuk As Date
        Get
            Return tgl_masuk
        End Get
        Set(value As Date)
            tgl_masuk = value
        End Set
    End Property

    Public Property GSstok As String
        Get
            Return stok
        End Get
        Set(value As String)
            stok = value
        End Set
    End Property

    Public Property GSbahasa As String
        Get
            Return bahasa
        End Get
        Set(value As String)
            bahasa = value
        End Set
    End Property

    Public Property GSkategori As List(Of String)
        Get
            Return kategori
        End Get
        Set(value As List(Of String))
            kategori = value
        End Set
    End Property
    Public Property GSpict As String
        Get
            Return pict
        End Get
        Set(value As String)
            pict = value
        End Set
    End Property

    Public Function GSAddKoleksiDataTable(nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit As String,
                                        deskripsi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tgl_masuk As String,
                                        stok As String,
                                        bahasa As String,
                                        kategori As String)
        koleksiDataTable.Add({nama_koleksi, jenis_koleksi, penerbit, deskripsi, tahun_terbit, lokasi_rak, tgl_masuk, stok, bahasa, kategori})
    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.Remove(index)
    End Function

    Public ReadOnly Property getKoleksiDatatable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each Val As String In vals
            builder.Append(Val).Append("|")
        Next

        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

End Class
