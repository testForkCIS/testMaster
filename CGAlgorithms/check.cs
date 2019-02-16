using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGUtilities;

namespace CGAlgorithms
{
    class check : Algorithm
    {


        public override void Run(List<Point> points, List<Line> lines, List<Polygon> polygons, ref List<Point> outPoints, ref List<Line> outLines, ref List<Polygon> outPolygons)
        {

          double x= points[0].X ;
          double y = points[0].Y;

          double startx= lines[0].Start.X;
          double starty = lines[0].Start.Y;

          double endx = lines[0].End.X;
          double endy = lines[0].End.Y;

          double result1 = (endx - startx) * (y - endy);
          double result2 = (endy - starty) * (x - endx);
          double result = 0.5 * (result1 - result2);
          if (result > 0)
          {
              outPoints = points;
          }
          else if(result == 0)
            {
                outPoints = points;
                outLines = lines;
          }
          else
          {
              outLines = lines;
          }

        }

        public override string ToString()
        {
            return "testc6";
        }
    }
}
