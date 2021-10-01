﻿Imports WebCam_Capture
Public Class WebCam
    Private webcam As WebCamCapture
    Private _FrameImage As System.Windows.Forms.PictureBox
    Private FrameNumber As Integer = 30

    Public Sub InitializeWebCam(ByRef ImageControl As System.Windows.Forms.PictureBox)
        webcam = New WebCamCapture()
        webcam.FrameNumber = 0UL
        webcam.TimeToCapture_milliseconds = FrameNumber
        AddHandler webcam.ImageCaptured, AddressOf webcam_ImageCaptured
        _FrameImage = ImageControl
    End Sub

    Private Sub webcam_ImageCaptured(ByVal source As Object, ByVal e As WebcamEventArgs)
        _FrameImage.Image = e.WebCamImage
    End Sub

    Public Sub Start()
        webcam.TimeToCapture_milliseconds = FrameNumber
        webcam.Start(0)
    End Sub

    Public Sub [Stop]()
        webcam.[Stop]()
    End Sub

    Public Sub [Continue]()
        webcam.TimeToCapture_milliseconds = FrameNumber
        webcam.Start(Me.webcam.FrameNumber)
    End Sub

    Public Sub ResolutionSetting()
        webcam.Config()
    End Sub

    Public Sub AdvanceSetting()
        webcam.Config2()
    End Sub


End Class

