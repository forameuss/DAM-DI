﻿#ExternalChecksum("C:\Users\anavarro\Desktop\DI\Visual Studio\Hello Worlds\01-HelloWorldUW\01-HelloWorldUW-VB\MainPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "7E00726732D227E866332BF9137D438F")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Namespace Global._01_HelloWorldUW_VB

    Partial Class MainPage
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2


        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "14.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Connect(ByVal connectionId As Integer, ByVal target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
            Select Case connectionid
            Case 1
                    Me.textNombre = CType(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                    Exit Select
            Case 2
                    Me.textApellidos = CType(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                    Exit Select
            Case 3
                    Me.textPais = CType(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                    Exit Select
            Case 4
                    Me.genNombre = CType(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                    Exit Select
            Case 5
                    Me.genApellidos = CType(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                    Exit Select
            Case 6
                    Me.genPais = CType(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                    Exit Select
            Case 7
                    Me.button = CType(target, Global.Windows.UI.Xaml.Controls.Button)
                    Exit Select
            Case 8
                    Me.button1 = CType(target, Global.Windows.UI.Xaml.Controls.Button)
                    Exit Select
                    Case Else
                        Exit Select
            End Select
                Me._contentLoaded = true
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "14.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function GetBindingConnector(connectionId As Integer, target As Object) As Global.Windows.UI.Xaml.Markup.IComponentConnector Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2.GetBindingConnector
            Dim returnValue As Global.Windows.UI.Xaml.Markup.IComponentConnector = Nothing
            Return returnValue
        End Function
    End Class

End Namespace

