Imports Microsoft.VisualBasic
Imports System
Namespace RestoreLayoutWithOverlappedOptions
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.btnRestore = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' btnRestore
			' 
			Me.btnRestore.Location = New System.Drawing.Point(51, 24)
			Me.btnRestore.Name = "btnRestore"
			Me.btnRestore.Size = New System.Drawing.Size(127, 40)
			Me.btnRestore.TabIndex = 0
			Me.btnRestore.Text = "Show preview"
			Me.btnRestore.UseVisualStyleBackColor = True
'			Me.btnRestore.Click += New System.EventHandler(Me.btnRestore_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(234, 93)
			Me.Controls.Add(Me.btnRestore)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnRestore As System.Windows.Forms.Button
	End Class
End Namespace

