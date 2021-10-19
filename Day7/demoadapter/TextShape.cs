using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoadapter
{
    public class TextShape : Shape
    {
        private Text text;

        public TextShape()
        {
            text = new Text();
        }

        public TextShape(string content)
        {
            text = new Text(content);
        }

        public string Content 
        {
            get { return text.Content; }
            set { text.Content = value; }
        }

        public override void Draw()
        {
            text.Print();
        }
        public override Shape Clone()
        {
            TextShape copyTextShape = new TextShape(text.Content);
            return copyTextShape;
        }
    }
}