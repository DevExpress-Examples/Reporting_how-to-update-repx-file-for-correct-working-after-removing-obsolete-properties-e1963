Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports System.Collections
Imports System.IO

Namespace RestoreLayoutWithOverlappedOptions
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnRestore_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRestore.Click

			Dim modifiedLayout As String = cleanupReportLayout(File.ReadAllText("TestLayout.repx"))
			File.WriteAllText("ModifiedLayout.repx", modifiedLayout)
			Dim report As XtraReport = XtraReport.FromFile("ModifiedLayout.repx", True)
			report.ShowPreview()
		End Sub
		Private Function cleanupReportLayout(ByVal ReportLayout As String) As String
			If (Not String.IsNullOrEmpty(ReportLayout)) Then

				' Cleanup Report Layout if Required

				If ReportLayout.Contains("OverlappingOptions") Then
					Dim controlNames As New ArrayList()
					Using sw As New StringWriter()
						Using sr As New StringReader(ReportLayout)

							Dim line As String
							line = sr.ReadLine()
							Do While line IsNot Nothing
								If (Not line.Contains("OverlappingOptions")) Then
									Dim bFound As Boolean = False
									For Each controlName As String In controlNames
										If line.Contains(controlName) Then
											bFound = True
											Exit For
										End If
									Next controlName
									If (Not bFound) Then
										If (Not line.Contains("OverlappingOptionsTypeName")) Then
											sw.WriteLine(line)
										End If
									End If
								Else
									Dim splitchar(0) As Char
									splitchar(0) = " "c
									Dim parms() As String = line.Trim().Split(splitchar)
									controlNames.Add(parms(0))
								End If
								line = sr.ReadLine()
							Loop
						End Using
						ReportLayout = sw.ToString()
					End Using
				End If
			End If
			Return ReportLayout
		End Function
	End Class
End Namespace