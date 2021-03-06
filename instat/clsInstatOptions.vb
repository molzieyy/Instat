﻿Imports System.Threading
Imports System.Globalization
Imports unvell.ReoGrid

<Serializable()> Public Class InstatOptions
    Public bIncludeRDefaultParameters As Boolean
    Public fntOutput, fntScript, fntComment, fntEditor As Font
    Public clrOutput, clrScript, clrComment, clrEditor As Color
    Public strComment, strLanguageCultureCode As String
    Public strWorkingDirectory As String
    Public iPreviewRows As Integer
    Public iMaxRows As Integer
    Public lstColourPalette As List(Of Color)

    Public Sub New()
        'TODO Is this sensible to do in constructor?
        bIncludeRDefaultParameters = False
        SetFormatOutput(New Font(FontFamily.GenericMonospace, 8, FontStyle.Regular), Color.Blue)
        SetFormatComment(New Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular), Color.Green)
        SetFormatCommand(New Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular), Color.Black)
        SetEditorFormat(New Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular), Color.Black)
        SetPreviewRows(10)
        SetMaxRows(1000)
        SetComment("code generated by the dialog")
        'TODO is this sensible?
        SetLanguageCultureCode(Thread.CurrentThread.CurrentCulture.Name)
        SetWorkingDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
        SetColorPalette(({Color.Aqua, Color.Gray, Color.LightGreen, Color.AliceBlue, Color.Maroon, Color.Green, Color.LightPink, Color.LightSkyBlue, Color.Brown, Color.MediumPurple, Color.White}).ToList)
    End Sub

    Public Sub SetMaxRows(iRows As Integer)
        iMaxRows = iRows
        frmMain.clsGrids.SetMaxRows(iMaxRows)
    End Sub

    Public Sub SetFormatOutput(fntNew As Font, clrNew As Color)
        fntOutput = fntNew
        clrOutput = clrNew
        frmMain.clsRLink.setFormatOutput(fntOutput, clrOutput)
    End Sub

    Public Sub SetFormatCommand(fntNew As Font, clrNew As Color)
        fntScript = fntNew
        clrScript = clrNew
        frmMain.clsRLink.setFormatScript(fntScript, clrScript)
    End Sub

    Public Sub SetFormatComment(fntNew As Font, clrNew As Color)
        fntComment = fntNew
        clrComment = clrNew
        frmMain.clsRLink.setFormatComment(fntComment, clrComment)
    End Sub

    Public Sub SetEditorFormat(fntNew As Font, clrNew As Color)
        fntEditor = fntNew
        clrEditor = clrNew
        frmMain.clsGrids.SetFormatDataView(fntEditor, clrEditor)
    End Sub

    Public Sub SetPreviewRows(intlines As Integer)
        iPreviewRows = intlines
        dlgImportDataset.setLinesToRead(iPreviewRows)
    End Sub

    Public Sub SetComment(strText As String)
        strComment = strText
    End Sub

    Public Sub SetLanguageCultureCode(strLanguage As String)
        strLanguageCultureCode = strLanguage
        Select Case strLanguageCultureCode
            Case "en-GB"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
            Case "fr-FR"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("fr-FR")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr-FR")
            Case "sw-KE"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("sw-KE")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("sw-KE")
            Case "es-ES"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-ES")
            Case Else
                Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
        End Select
    End Sub

    Public Sub SetWorkingDirectory(strWD As String)
        strWorkingDirectory = strWD
        'frmMain.clsRLink.RunScript("setwd(" & Chr(34) & strWorkingDirectory & Chr(34) & ")")
    End Sub

    Public Sub SetColorPalette(lstColours As List(Of Color))
        lstColourPalette = lstColours
    End Sub
End Class