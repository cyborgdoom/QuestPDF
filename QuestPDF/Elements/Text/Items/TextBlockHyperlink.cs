﻿using QuestPDF.Elements.Text.Calculation;
using QuestPDF.Infrastructure;

namespace QuestPDF.Elements.Text.Items
{
    internal class TextBlockHyperlink : TextBlockSpan
    {
        public string Url { get; set; }

        public override void Draw(TextDrawingRequest request)
        {
            Canvas.Translate(new Position(0, request.TotalAscent));
            Canvas.DrawHyperlink(Url, new Size(request.TextSize.Width, request.TextSize.Height));
            Canvas.Translate(new Position(0, -request.TotalAscent));
            
            base.Draw(request);
        }
    }
}