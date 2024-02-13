Imports System.Windows.Forms.FileDialog
Imports System.Security

Public Class Open

    Private OpenFileDialog1 As OpenFileDialog
    Private a_arqListAs() As String
    Public arq_opem As String
    '  Private SecurityException As Security.ex
    Public Function arqList() As String()
        Dim I As Long
        Dim File As String
        Dim dr As DialogResult = Me.OpenFileDialog1.ShowDialog()
        I = 0
        If (dr = System.Windows.Forms.DialogResult.OK) Then
            ' Read the files

            For Each File In OpenFileDialog1.FileNames
                ' Create a PictureBox for each file, and add that file to the FlowLayoutPanel.
                Try
                    If Not File = "" Then
                        ReDim Preserve a_arqListAs(I)
                        a_arqListAs(I) = File
                        arq_opem = File
                        ''   frmImportXMLntfe.CaminhoArquivo = File

                        I = I + 1
                    End If
                Catch SecEx As SecurityException
                    ' The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" &
                         "Mensagem : " & SecEx.Message & "\n\n" &
                        "Detalhes (enviar ao suporte):\n\n" & SecEx.StackTrace)
                Catch ex As Exception
                    ' Could not load the image - probably permissions-related.
                    MessageBox.Show(("Não é possível exibir a imagem : " & File.Substring(File.LastIndexOf("\"c)) &
                    ". Você pode não ter permissão para ler o arquivo , ou " + "ele pode estar corrompido" _
                    & ControlChars.Lf & ControlChars.Lf & "Erro reportado: " & ex.Message))
                End Try
            Next File
        End If
        Return a_arqListAs
    End Function

    Public Sub New()
        OpenFileDialog1 = New OpenFileDialog
        'SecurityException = New Exception
        ' Me.OpenFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        Me.OpenFileDialog1.Filter = "XML ( *.XML)|*.XML"
        ' Allow the user to select multiple images.
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.Title = "ARQUIVOS XML."
    End Sub

End Class
