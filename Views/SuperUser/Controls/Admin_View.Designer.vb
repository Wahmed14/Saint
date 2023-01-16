<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_View
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
        Me.P_ADMIN = New Guna.UI2.WinForms.Guna2Panel()
        Me.BT_UES = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_FACULTIES = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_ECUES = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_INSTITUTES = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_EMPLOYEES = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_USERS = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'P_ADMIN
        '
        Me.P_ADMIN.Location = New System.Drawing.Point(8, 154)
        Me.P_ADMIN.Name = "P_ADMIN"
        Me.P_ADMIN.Size = New System.Drawing.Size(1350, 592)
        Me.P_ADMIN.TabIndex = 0
        '
        'BT_UES
        '
        Me.BT_UES.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_UES.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_UES.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_UES.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_UES.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_UES.ForeColor = System.Drawing.Color.White
        Me.BT_UES.Location = New System.Drawing.Point(686, 2)
        Me.BT_UES.Name = "BT_UES"
        Me.BT_UES.Size = New System.Drawing.Size(220, 146)
        Me.BT_UES.TabIndex = 1
        Me.BT_UES.Text = "UES"
        '
        'BT_FACULTIES
        '
        Me.BT_FACULTIES.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_FACULTIES.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_FACULTIES.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_FACULTIES.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_FACULTIES.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_FACULTIES.ForeColor = System.Drawing.Color.White
        Me.BT_FACULTIES.Location = New System.Drawing.Point(460, 2)
        Me.BT_FACULTIES.Name = "BT_FACULTIES"
        Me.BT_FACULTIES.Size = New System.Drawing.Size(220, 146)
        Me.BT_FACULTIES.TabIndex = 2
        Me.BT_FACULTIES.Text = "FACULTES"
        '
        'BT_ECUES
        '
        Me.BT_ECUES.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_ECUES.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_ECUES.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_ECUES.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_ECUES.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ECUES.ForeColor = System.Drawing.Color.White
        Me.BT_ECUES.Location = New System.Drawing.Point(912, 2)
        Me.BT_ECUES.Name = "BT_ECUES"
        Me.BT_ECUES.Size = New System.Drawing.Size(220, 146)
        Me.BT_ECUES.TabIndex = 3
        Me.BT_ECUES.Text = "ECUES"
        '
        'BT_INSTITUTES
        '
        Me.BT_INSTITUTES.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_INSTITUTES.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_INSTITUTES.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_INSTITUTES.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_INSTITUTES.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_INSTITUTES.ForeColor = System.Drawing.Color.White
        Me.BT_INSTITUTES.Location = New System.Drawing.Point(234, 2)
        Me.BT_INSTITUTES.Name = "BT_INSTITUTES"
        Me.BT_INSTITUTES.Size = New System.Drawing.Size(220, 146)
        Me.BT_INSTITUTES.TabIndex = 4
        Me.BT_INSTITUTES.Text = "INSTITUTS"
        '
        'BT_EMPLOYEES
        '
        Me.BT_EMPLOYEES.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_EMPLOYEES.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_EMPLOYEES.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_EMPLOYEES.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_EMPLOYEES.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_EMPLOYEES.ForeColor = System.Drawing.Color.White
        Me.BT_EMPLOYEES.Location = New System.Drawing.Point(8, 2)
        Me.BT_EMPLOYEES.Name = "BT_EMPLOYEES"
        Me.BT_EMPLOYEES.Size = New System.Drawing.Size(220, 146)
        Me.BT_EMPLOYEES.TabIndex = 5
        Me.BT_EMPLOYEES.Text = "EMPLOYEES"
        '
        'BT_USERS
        '
        Me.BT_USERS.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_USERS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_USERS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_USERS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_USERS.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_USERS.ForeColor = System.Drawing.Color.White
        Me.BT_USERS.Location = New System.Drawing.Point(1138, 2)
        Me.BT_USERS.Name = "BT_USERS"
        Me.BT_USERS.Size = New System.Drawing.Size(220, 146)
        Me.BT_USERS.TabIndex = 6
        Me.BT_USERS.Text = "UTILISATEURS"
        '
        'Admin_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.BT_USERS)
        Me.Controls.Add(Me.BT_EMPLOYEES)
        Me.Controls.Add(Me.BT_INSTITUTES)
        Me.Controls.Add(Me.BT_ECUES)
        Me.Controls.Add(Me.BT_FACULTIES)
        Me.Controls.Add(Me.BT_UES)
        Me.Controls.Add(Me.P_ADMIN)
        Me.Name = "Admin_View"
        Me.Text = "Admin_View"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_ADMIN As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BT_UES As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_FACULTIES As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_ECUES As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_INSTITUTES As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_EMPLOYEES As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_USERS As Guna.UI2.WinForms.Guna2Button
End Class
