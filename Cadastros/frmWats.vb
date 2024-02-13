Imports System.Drawing
Imports System.Windows.Forms
'Imports OpenQA.Selenium
'Imports OpenQA.Selenium.Chrome

Public Class frmWats
    Private p As New Process
    Private Url As String
    Private blnConecta As Boolean = False

    '  Dim naveg As New ChromeDriver

    Public Sub New(ByVal Mensagem As String, NroWhats As String)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        txtMensagem.Text = Mensagem
        txtTelefone.Text = NroWhats

    End Sub
    Private Sub btoAnexo_Click(sender As Object, e As EventArgs) Handles btoAnexo.Click

        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "imagens|*.bmp;*.jpg;*.jpeg;*.png;*.gif"

        If openFileDialog.ShowDialog = DialogResult.OK Then ''openFileDialog.FileName Then
            Dim Caminho As String = openFileDialog.FileName

            Try
                Clipboard.SetImage(Image.FromFile(Caminho))
                lblAnexo.Text = "Arqui Anexo : " & openFileDialog.SafeFileName

            Catch ex As Exception
                MessageBox.Show("Erro ao carregar o caminho da imagem," & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim Mensagem As String = txtMensagem.Text
        Dim Numero As String = txtTelefone.Text

        p.StartInfo.FileName = "C:\Users\laerc\AppData\Local\WhatsApp\WhatsApp.exe"
        p.Start()

        Threading.Thread.Sleep(8000)
        SendKeys.SendWait("^n")
        SendKeys.SendWait("{ENTER}")

        Threading.Thread.Sleep(8000)
        SendKeys.SendWait(Numero)
        SendKeys.SendWait("{ENTER}")

        Threading.Thread.Sleep(2000)
        SendKeys.SendWait("^v")
        SendKeys.SendWait("{ENTER}")

        Threading.Thread.Sleep(8000)
        SendKeys.SendWait(Mensagem)
        SendKeys.SendWait("{ENTER}")

        Threading.Thread.Sleep(1000)
        'MessageBox.Show("enviada")

        Me.Close()

    End Sub
    Private Sub frmWats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'p.StartInfo.FileName = "C:\Users\laerc\AppData\Local\WhatsApp\WhatsApp.exe"
        'p.Start()

        'txtTelefone.Text = "17981351065"
        'txtMensagem.Text = "Ola Matilde," & vbCrLf _
        '        & "Obrigado por confiar o Banho de seu Pet com nós." & vbCrLf _
        '        & "As datas de agendamento segue abaixo" & vbCrLf _
        '        & "_____________________________________________" & vbCrLf _
        '        & "Obrigado." & vbCrLf & "Laercio" & Now

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SendWhatsApp(txtTelefone.Text, txtMensagem.Text)
    End Sub
    Private Sub SendWhatsApp(ByVal Nro As String, ByVal Msg As String)

        Nro = "55" & Nro

        System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" & Nro _
        & "&text=" & Uri.EscapeDataString(txtMensagem.Text)) ' Msg)


    End Sub
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        'Url = "http://web.whatsapp.com/send?phone=" + "55" + Uri.EscapeDataString(txtTelefone.Text) + "&text=" +
        '        Uri.EscapeDataString(txtMensagem.Text) + "&source=&data="
        'naveg.Navigate.GoToUrl(Url)
        'Threading.Thread.Sleep(8000)
        'blnConecta = True
    End Sub
    Private Sub btoMetodo3_Click(sender As Object, e As EventArgs) Handles btoMetodo3.Click

        ''' If blnConecta = True Then

        'Url = "http://web.whatsapp.com/send?phone=" + "55" + Uri.EscapeDataString(txtTelefone.Text) + "&text=" +
        '        Uri.EscapeDataString(txtMensagem.Text) + "&source=&data="

        'Dim naveg As New ChromeDriver
        'naveg.Navigate.GoToUrl(Url)

        'Threading.Thread.Sleep(8000)

        'Dim env = naveg.FindElements(By.XPath("//span[@data-icon='send']"))
        'Threading.Thread.Sleep(500)
        'SendKeys.SendWait("{ENTER}")

        '' env.click()

        ''  End If
    End Sub


End Class