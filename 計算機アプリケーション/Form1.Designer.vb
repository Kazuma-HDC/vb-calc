﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FormMain = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FormMain
        '
        Me.FormMain.Location = New System.Drawing.Point(279, 87)
        Me.FormMain.Name = "FormMain"
        Me.FormMain.Size = New System.Drawing.Size(281, 57)
        Me.FormMain.TabIndex = 0
        Me.FormMain.Text = "三角形の面積"
        Me.FormMain.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(279, 202)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(281, 60)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "台形の面積"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(279, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(281, 62)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "BMI指数"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.FormMain)
        Me.Name = "Form1"
        Me.Text = "メインメニュー"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormMain As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
