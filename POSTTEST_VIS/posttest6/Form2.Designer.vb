<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtKodeProduk = New TextBox()
        txtNamaProduk = New TextBox()
        cmbJenis = New ComboBox()
        txtHarga = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        dgvProduk = New DataGridView()
        CType(dgvProduk, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtKodeProduk
        ' 
        txtKodeProduk.Location = New Point(30, 28)
        txtKodeProduk.Name = "txtKodeProduk"
        txtKodeProduk.Size = New Size(125, 27)
        txtKodeProduk.TabIndex = 0
        ' 
        ' txtNamaProduk
        ' 
        txtNamaProduk.Location = New Point(30, 89)
        txtNamaProduk.Name = "txtNamaProduk"
        txtNamaProduk.Size = New Size(125, 27)
        txtNamaProduk.TabIndex = 1
        ' 
        ' cmbJenis
        ' 
        cmbJenis.FormattingEnabled = True
        cmbJenis.Location = New Point(30, 149)
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(151, 28)
        cmbJenis.TabIndex = 2
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(30, 208)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(125, 27)
        txtHarga.TabIndex = 3
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(30, 273)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(176, 273)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 5
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(316, 273)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' dgvProduk
        ' 
        dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProduk.Location = New Point(303, 35)
        dgvProduk.Name = "dgvProduk"
        dgvProduk.RowHeadersWidth = 51
        dgvProduk.Size = New Size(300, 188)
        dgvProduk.TabIndex = 7
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvProduk)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtHarga)
        Controls.Add(cmbJenis)
        Controls.Add(txtNamaProduk)
        Controls.Add(txtKodeProduk)
        Name = "Form2"
        Text = "Form2"
        CType(dgvProduk, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtKodeProduk As TextBox
    Friend WithEvents txtNamaProduk As TextBox
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents dgvProduk As DataGridView
End Class
