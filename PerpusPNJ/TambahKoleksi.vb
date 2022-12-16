Public Class TambahKoleksi


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Perpustakaan.data_perpus.GSnama_koleksi = TextBox1.Text
        Perpustakaan.data_perpus.GSjenis_koleksi = ComboBox1.Text
        Perpustakaan.data_perpus.GSdeskripsi = RichTextBox1.Text
        Perpustakaan.data_perpus.GSpenerbit = TextBox2.Text
        Perpustakaan.data_perpus.GStahun_terbit = TextBox3.Text
        Perpustakaan.data_perpus.GSlokasi_rak = TextBox4.Text
        Perpustakaan.data_perpus.GStgl_masuk = DateTimePicker1.Value.ToShortDateString
        Perpustakaan.data_perpus.GSstok = TextBox5.Text
        Perpustakaan.data_perpus.GSbahasa = GroupBox1.Text

        If CheckBox1.Checked Then
            Perpustakaan.data_perpus.GSkategori.Add("Sains")
        End If

        If CheckBox2.Checked Then
            Perpustakaan.data_perpus.GSkategori.Add("Sosial")
        End If

        If CheckBox3.Checked Then
            Perpustakaan.data_perpus.GSkategori.Add("Teknologi")
        End If

        If CheckBox4.Checked Then
            Perpustakaan.data_perpus.GSkategori.Add("Budaya")
        End If

        Dim convertedKoleksi = Perpustakaan.data_perpus.ConvertKoleksiToString(Perpustakaan.data_perpus.GSkategori)
        Perpustakaan.data_perpus.GSAddKoleksiDataTable(Perpustakaan.data_perpus.GSnama_koleksi,
                                          Perpustakaan.data_perpus.GSjenis_koleksi,
                                          Perpustakaan.data_perpus.GSpenerbit,
                                          Perpustakaan.data_perpus.GSdeskripsi,
                                          Perpustakaan.data_perpus.GStahun_terbit,
                                          Perpustakaan.data_perpus.GSlokasi_rak,
                                          Perpustakaan.data_perpus.GStgl_masuk,
                                          Perpustakaan.data_perpus.GSstok,
                                          Perpustakaan.data_perpus.GSbahasa,
                                          convertedKoleksi)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filereader As System.IO.StreamReader
        OpenFileDialog1.InitialDirectory = "~/Pictures"
        OpenFileDialog1.Title = "Buka Foto"
        OpenFileDialog1.Filter = "All Format|*.*|Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
        OpenFileDialog1.ShowDialog()
        Perpustakaan.data_perpus.GSpict = OpenFileDialog1.FileName
        PictureBox1.Load(Perpustakaan.data_perpus.GSpict)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class