Imports WebCam_Capture

Public Class ImageDialog


    Private cam As WebCam


    Private _image As Image
    Public Property Image() As Image
        Get
            Return _image
        End Get
        Set(ByVal value As Image)
            _image = value
            ptbMain.Image = Image

        End Set
    End Property


#Region "method"


    Private Sub startCam()

        Try
            cam = New WebCam()
            cam.InitializeWebCam(ptbMain)
            cam.Start()
        Catch ex As Exception
            cam = Nothing
            MessageBox.Show("Can not start webcam properly!")
        End Try



    End Sub

    Private Sub stopCam()

        Try
            cam.Stop()
        Catch ex As Exception
            cam = Nothing
            MessageBox.Show("Can not stop webcam properly!")
        End Try



    End Sub


#End Region


#Region "event"

    Private Sub ImageDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        If cam Is Nothing Then
            startCam()

        Else
            stopCam()
            Image = ptbMain.Image
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

    End Sub


#End Region




End Class