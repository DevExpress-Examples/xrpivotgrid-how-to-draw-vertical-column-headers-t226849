﻿Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Using report As New XtraReport1()
			Using tool As New ReportPrintTool(report)
				tool.ShowPreviewDialog()
			End Using
			End Using
		End Sub


	End Class
End Namespace