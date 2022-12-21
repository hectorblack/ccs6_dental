Imports System.Drawing.Drawing2D
Imports System.Drawing.Rectangle

Module moduleGradientPanel

    Public Sub gradientPanel(obj As Panel)

        '''''''FOR THE COLOR'''''''''''''
        Dim iBackground As New Bitmap(obj.Width, obj.Height)
        Dim g As Graphics = Graphics.FromImage(iBackground)

        'g.FillRectangle(New Drawing2D.LinearGradientBrush(obj.ClientRectangle, Color.Red, Color.White, LinearGradientMode.ForwardDiagonal), obj.ClientRectangle)
        g.FillRectangle(New Drawing2D.LinearGradientBrush(obj.ClientRectangle, Color.FromArgb(111, 206, 201), Color.FromArgb(94, 170, 214), LinearGradientMode.ForwardDiagonal), obj.ClientRectangle)

        obj.BackgroundImage = iBackground

        g.Dispose()

    End Sub

End Module
