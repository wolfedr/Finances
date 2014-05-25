Module modSettings
    'Public variables used in graph construction and scaling -
    'scaleFactorX- scale multiplying coefficient used to draw new value diapason on X-axis:
    Public scaleFactorX As Single
    'scaleFactorY - scale multiplying coefficient used to draw new value diapason on Y-axis:
    Public scaleFactorY As Single

    'Distance from the borders of the graph in twips:
    Public BORDER_SPACE As Single

    'Variables to be used in calculations drawing the coordinates and graph:
    Public Xmin As Single
    Public Ymin As Single
    Public Xmax As Single
    Public Ymax As Single

    Public betweenMarkersX As Single
    Public betweenMarkersY As Single

    Public Graph As GraphObject


    'Definition of main structure "GraphObject" (this is similar to structure in C language):
    Structure GraphObject
        Dim MinX As Single 'Minimum X-value
        Dim MaxX As Single 'Maximum X-value
        Dim MinY As Single 'Minimum Y-value
        Dim MaxY As Single 'Maximum Y-value
        Dim AxisColor As Short 'Color of the axis

        Dim EqualScaleXY As Boolean '=True, for x- and y-axis to have the same distance between markers


    End Structure

    Function XinPoints(ByRef x As Single) As Single

        'Get "XinPoints" value of a given X coordinate:
        XinPoints = BORDER_SPACE + (-Xmin * betweenMarkersX) + (x * betweenMarkersX)

    End Function

    Function YinPoints(ByRef y As Single) As Single

        'Get "YinPoints" value of a given Y coordinate:
        YinPoints = BORDER_SPACE + (-Ymin * betweenMarkersY) + (y * betweenMarkersY)

    End Function

    'Subroutine to set initial parameters for a graph:

    Sub SetGraphParameters(ByRef initialGraph As GraphObject)

        '"With" statement allows you to perform a series of statements on a specified object
        ' without requalifying the name of the object,
        ' for example, to change a number of different properties on a single object:

        With initialGraph

            'Set initial value for Y-axis scale coefficient:
            scaleFactorY = 1

            'Set scales (X-Y minimum and maximum values).
            .MinX = 0
            .MaxX = 20
            .MinY = -6
            .MaxY = 14

        End With

    End Sub

End Module
