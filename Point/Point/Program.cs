using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("===============================");
            Console.WriteLine("L - Working with Lines");
            Console.WriteLine("C - Working with Circles");
            Console.WriteLine("S - Working with Squars");
            Console.WriteLine("T - Working with Triangles");
            Console.WriteLine("Q - Quit");
            Console.WriteLine("===============================");
            Console.WriteLine("Enter Choice: ");
            Char answer = char.Parse(Console.ReadLine());

            while ((answer != 'q') && (answer!='Q'))
            {
                switch (answer)
                {
                    case 'L':
                    case 'l':
                        Console.WriteLine("enter x value of the first point:");
                        int xLine1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter y value of the first point:");
                        int yLine1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter x value of the second point:");
                        int xLine2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter y value of the second point:");
                        int yLine2 = int.Parse(Console.ReadLine());
                        MyPoint p1Line = new MyPoint(xLine1, yLine1);
                        MyPoint p2Line = new MyPoint(xLine2, yLine2);
                        Line Line = new Line(p1Line, p2Line);
                        Line.print_deatails();
                        break;
                    case 'c':
                    case 'C':
                        Console.WriteLine("enter x value of the first point of the Raduis:");
                        int x1Radius = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter y value of the first point of the Raduis:");
                        int y1Radius = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter x value of the second point of the Radius:");
                        int x2Radius = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter y value of the second point of the Radius:");
                        int y2Radius = int.Parse(Console.ReadLine());
                        MyPoint p1Radius = new MyPoint(x1Radius, y1Radius);
                        MyPoint p2Radius = new MyPoint(x2Radius, y2Radius);
                        Line Radius = new Line(p1Radius, p2Radius);
                        Circle circle = new Circle(Radius);
                        Radius.print_deatails();
                        Console.WriteLine("the S of the circle is: {0}", circle.GetSCircle());
                        Console.WriteLine("the P of the circle is: {0}", circle.GetPCircle());
                        break;
                    case 's':
                    case 'S':
                        Console.WriteLine("enter x value of the left above point of the squar:");
                        int x1Squar = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter y value of the left above point of the squar:");
                        int y1Squar = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter x value of the right above point of the squar:");
                        int x2Squar = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter y value of the right above point of the squar:");
                        int y2Squar = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter x value of the right down point of the squar:");
                        int x3Squar = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter y value of the right down above point of the squar:");
                        int y3Squar = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter x value of the left down point of the squar:");
                        int x4Squar = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter y value of the left down point of the squar:");
                        int y4Squar = int.Parse(Console.ReadLine());
                        MyPoint p1Squar = new MyPoint(x1Squar, y1Squar);
                        MyPoint p2Squar = new MyPoint(x2Squar, y2Squar);
                        MyPoint p3Squar = new MyPoint(x3Squar, y3Squar);
                        MyPoint p4Squar = new MyPoint(x4Squar, y4Squar);
                        Squar squar = new Squar(p1Squar, p2Squar, p3Squar, p4Squar);
                        squar.print_squar();
                        Console.WriteLine("the S of the squar: {0}", squar.SSquar());
                        Console.WriteLine("the P of the squar :{0}", squar.PSquar());
                        break;
                    case 'T':
                    case 't':
                        Console.WriteLine("enter x value of the first point of the Triangle:");
                        int x1Triangle = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter y value of the first point of the Triangle:");
                        int y1Triangle = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter x value of the second point of the Triangle:");
                        int x2Triangle = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter y value of the second point of the Triangle:");
                        int y2Triangle = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter x value of the third point of the Triangle:");
                        int x3Triangle = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter y value of the third point of the Triangle:");
                        int y3Triangle = int.Parse(Console.ReadLine());
                        MyPoint p1Triangle = new MyPoint(x1Triangle, y1Triangle);
                        MyPoint p2Triangle = new MyPoint(x2Triangle, y2Triangle);
                        MyPoint p3Triangle = new MyPoint(x3Triangle, y3Triangle);
                        Tringle Triangle = new Tringle(p1Triangle, p2Triangle, p3Triangle);
                        Triangle.print_triangle();
                        Console.WriteLine("the S of the triangle: {0}", Triangle.STriangle());
                        Console.WriteLine("the P of the triangle: {0}", Triangle.PTriangle());
                        break;

                    default: Console.WriteLine("try again");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Enter another choice: ");
                answer = char.Parse(Console.ReadLine());
            }
            
        }
    }
}
