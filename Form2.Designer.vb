<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TxtBox3 = New TextBox()
        TxtBox2 = New TextBox()
        TxtBox4 = New TextBox()
        TxtBox5 = New TextBox()
        TxtBox6 = New TextBox()
        Label6 = New Label()
        Btn1 = New Button()
        Btn2 = New Button()
        Btn3 = New Button()
        Btn4 = New Button()
        DataGridView1 = New DataGridView()
        TxtBox1 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(13, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 20)
        Label1.TabIndex = 0
        Label1.Text = "NUM DE VOL       :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(13, 332)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 20)
        Label2.TabIndex = 1
        Label2.Text = "HEURE                 :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(4, 424)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 20)
        Label3.TabIndex = 2
        Label3.Text = "NB DE PLACE DISPO:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(4, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 20)
        Label4.TabIndex = 3
        Label4.Text = "DESTINATION        :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(13, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 20)
        Label5.TabIndex = 4
        Label5.Text = "DATE                    :"
        ' 
        ' TxtBox3
        ' 
        TxtBox3.BackColor = Color.IndianRed
        TxtBox3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBox3.Location = New Point(173, 217)
        TxtBox3.Name = "TxtBox3"
        TxtBox3.Size = New Size(191, 47)
        TxtBox3.TabIndex = 7
        ' 
        ' TxtBox2
        ' 
        TxtBox2.BackColor = Color.IndianRed
        TxtBox2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBox2.Location = New Point(173, 119)
        TxtBox2.Name = "TxtBox2"
        TxtBox2.Size = New Size(191, 47)
        TxtBox2.TabIndex = 8
        ' 
        ' TxtBox4
        ' 
        TxtBox4.BackColor = Color.IndianRed
        TxtBox4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBox4.Location = New Point(173, 312)
        TxtBox4.Name = "TxtBox4"
        TxtBox4.Size = New Size(191, 47)
        TxtBox4.TabIndex = 9
        ' 
        ' TxtBox5
        ' 
        TxtBox5.BackColor = Color.IndianRed
        TxtBox5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBox5.Location = New Point(173, 404)
        TxtBox5.Name = "TxtBox5"
        TxtBox5.Size = New Size(191, 47)
        TxtBox5.TabIndex = 10
        ' 
        ' TxtBox6
        ' 
        TxtBox6.BackColor = Color.IndianRed
        TxtBox6.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBox6.Location = New Point(173, 485)
        TxtBox6.Name = "TxtBox6"
        TxtBox6.Size = New Size(191, 47)
        TxtBox6.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(12, 505)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 20)
        Label6.TabIndex = 12
        Label6.Text = "PRIX                     :"
        ' 
        ' Btn1
        ' 
        Btn1.BackColor = Color.IndianRed
        Btn1.ForeColor = SystemColors.ActiveCaptionText
        Btn1.Location = New Point(845, 332)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(94, 29)
        Btn1.TabIndex = 13
        Btn1.Text = "AJOUTER"
        Btn1.UseVisualStyleBackColor = False
        ' 
        ' Btn2
        ' 
        Btn2.BackColor = Color.IndianRed
        Btn2.ForeColor = SystemColors.ActiveCaptionText
        Btn2.Location = New Point(677, 378)
        Btn2.Name = "Btn2"
        Btn2.Size = New Size(94, 29)
        Btn2.TabIndex = 14
        Btn2.Text = "MODIFIER"
        Btn2.UseVisualStyleBackColor = False
        ' 
        ' Btn3
        ' 
        Btn3.BackColor = Color.IndianRed
        Btn3.ForeColor = SystemColors.ActiveCaptionText
        Btn3.Location = New Point(845, 420)
        Btn3.Name = "Btn3"
        Btn3.Size = New Size(94, 29)
        Btn3.TabIndex = 15
        Btn3.Text = "SUPPRIMER"
        Btn3.UseVisualStyleBackColor = False
        ' 
        ' Btn4
        ' 
        Btn4.BackColor = Color.IndianRed
        Btn4.ForeColor = SystemColors.ActiveCaptionText
        Btn4.Location = New Point(977, 378)
        Btn4.Name = "Btn4"
        Btn4.Size = New Size(94, 29)
        Btn4.TabIndex = 16
        Btn4.Text = "AFFICHER"
        Btn4.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(414, 17)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(801, 240)
        DataGridView1.TabIndex = 17
        ' 
        ' TxtBox1
        ' 
        TxtBox1.BackColor = Color.IndianRed
        TxtBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBox1.Location = New Point(173, 24)
        TxtBox1.Name = "TxtBox1"
        TxtBox1.Size = New Size(191, 47)
        TxtBox1.TabIndex = 6
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LemonChiffon
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1279, 554)
        Controls.Add(DataGridView1)
        Controls.Add(Btn4)
        Controls.Add(Btn3)
        Controls.Add(Btn2)
        Controls.Add(Btn1)
        Controls.Add(Label6)
        Controls.Add(TxtBox6)
        Controls.Add(TxtBox5)
        Controls.Add(TxtBox4)
        Controls.Add(TxtBox2)
        Controls.Add(TxtBox3)
        Controls.Add(TxtBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TxtBox3 As TextBox
    Friend WithEvents TxtBox2 As TextBox
    Friend WithEvents TxtBox4 As TextBox
    Friend WithEvents TxtBox5 As TextBox
    Friend WithEvents TxtBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtBox1 As TextBox
End Class
