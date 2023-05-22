<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        ListBox1 = New ListBox()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button3 = New Button()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(519, 68)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(609, 12)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(170, 424)
        ListBox1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(60, 308)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 2
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(12, 178)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 4
        Label1.Text = "Label1"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(79, 119)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 5
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(32, 54)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 6
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 7
        Label2.Text = "Label2"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Location = New Point(278, 187)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(163, 91)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(Button2)
        Controls.Add(ListBox1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
