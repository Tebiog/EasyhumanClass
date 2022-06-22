using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;

namespace SimpleOOP.Geomenty
{
    class DrawGraphic
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        public static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDc);

        [DllImport("gdi32.dll")]
        static extern IntPtr DeleteDC(IntPtr hDc);

        static IntPtr hWnd = IntPtr.Zero; 
        static IntPtr hDC = IntPtr.Zero;                                            
        public static void Draw()
        {
            hWnd = GetConsoleWindow();
            if (hWnd != IntPtr.Zero)
            {
                hDC = GetDC(hWnd);
                if (hDC != IntPtr.Zero)
                {
                    using (Graphics consoleGraphics = Graphics.FromHdc(hDC))
                    {

                        Pen whitePen = new Pen(Color.White);
                        Pen redPen = new Pen(Color.Red, 2);
                        Font font = new Font("verdana", 13);

                        consoleGraphics.DrawLine(whitePen, new Point(0, 30), new Point(300, 30));
                        consoleGraphics.DrawLine(whitePen, new Point(30, 0), new Point(30, 300));
                        consoleGraphics.DrawString("X", font, Brushes.White, 310, 10);
                        consoleGraphics.DrawString("Y", font, Brushes.White, 40, 250);
                        consoleGraphics.DrawString("График функции : y = x + 2", font, Brushes.White, 80, 60);
                        
                        int y = 0;
                        int x = 100;
                        for (; x < 250; x++)
                        {
                            y = x + 2;
                            consoleGraphics.DrawRectangle(redPen, x, y, 2, 2);
                        }
                        font.Dispose();
                        whitePen.Dispose();
                        redPen.Dispose();
                    }
                }
                ReleaseDC(hWnd, hDC);
                DeleteDC(hDC);
            }
            Console.ReadKey();
        }
    }
}


