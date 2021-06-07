using System.Collections.Generic;

namespace Mild.DesignPattern.MementoPattern
{
    public class Editor
    {
        public Editor(string title, string text, int fontSize, string fontFace)
        {
            this.Title = title;
            this.Text = text;
            this.FontSize = fontSize;
            this.FontFace = fontFace;

        }
        public string Title { get; private set; }
        public string Text { get; private set; }
        public int FontSize { get; private set; }
        public string FontFace { get; private set; }

        public Memento<Editor> CreateState()
        {
            return new Memento<Editor>(this);
        }

        public void RestoreState(Memento<Editor> memento)
        {
            Title = memento.Object.Title;
            Text = memento.Object.Text;
            FontSize = memento.Object.FontSize;
            FontFace = memento.Object.FontFace;
        }

        public override string ToString()
        {
            return $"{Title} {Text} {FontFace} {FontSize}";
        }
    }
}