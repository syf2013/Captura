using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Captura
{
    public class InkToolToIconConverter : OneWayConverter
    {
        public override object Convert(object Value, Type TargetType, object Parameter, CultureInfo Culture)
        {
            var app = Application.Current;

            switch (Value)
            {
                case InkCanvasEditingMode.Ink:
                case ExtendedInkTool.Pen:
                    return app.FindResource("Icon_Pencil");

                case InkCanvasEditingMode.EraseByPoint:
                case ExtendedInkTool.Eraser:
                    return app.FindResource("Icon_Eraser");

                case InkCanvasEditingMode.EraseByStroke:
                case ExtendedInkTool.StrokeEraser:
                    return app.FindResource("Icon_StrokeEraser");

                case InkCanvasEditingMode.Select:
                    return app.FindResource("Icon_Select");

                case ExtendedInkTool.Line:
                    return app.FindResource("Icon_Line");
            }

            return app.FindResource("Icon_Cursor");
        }
    }
}