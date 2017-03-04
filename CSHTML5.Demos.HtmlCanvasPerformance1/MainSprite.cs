﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSHTML5.Native.Html.Controls;
using Windows.UI;

namespace CSHTML5.Demos.HtmlCanvasPerformance1
{
    public class MainSprite : ContainerElement
    {
        public double VelocityX;
        public double VelocityY;

        public MainSprite(int index)
        {
            Random rand = new Random(index);
            
            // Set a random background color:
            this.FillColor = Color.FromArgb((byte)rand.Next(256), (byte)rand.Next(256), (byte)rand.Next(256), (byte)rand.Next(256));

            // Set the size:
            this.Width = 20d + Math.Log10(index) * 5d;
            this.Height = 30d;

            // Display the index:
            var text = new TextElement()
            {
                Text = index.ToString(),
                FontHeight = 16d,
                X = 5,
                Y = 5
            };
            this.Children.Add(text);
        }
    }
}
