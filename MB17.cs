using Proje.Models.Dashbord;
using Proje.Models.Dashbord.Compannets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proje.Models.KutuModelleri
{
    public class MB17
    {
        public string swg { get; set; }
        public MB17(double malzeme, double a, double b, double h, double m1, double m4, double m9, double z, double d, double f, double g, double c, int typeModel, int dilKodu, int AskilikType, double r1, int ParmakType, int mX, int mY, double ParentX , double ParentY)
        {

            double aa = a;
            double bb = b - malzeme;
            double e = b - 1.5;
            double e2 = malzeme;


            double z1 = 2;
            double z2 = malzeme;
            double z3 = b;



            double d1 = d / 2;
            double d2 = d / 2;
            double d3 = d / 5;
            double d4 = d / 4;
            double d5 = d + 1;
            double d6 = 1;
            double dxtt = 1;

            double beta = 15;


            double c1 = 75;
            double c2 = 75;
            double c3 = h;
            double f1 = malzeme;
            double f2 = 0.75;
            double f3 = 1.5;
            double f4 = z + 2;
            double f5 = a;

             ParentX += c * mX;

            if ((m1 +m1+5)> (e + f + malzeme) & AskilikType !=1)
            {
                ParentY += (2 * m1 + 5) * mY;
           
            }
            else
            {
                ParentY += (e + f + malzeme) * mY;
            }
          
            int UstDilType = 0;
            int AltDilType = 0;
            var compannet04 = (new cmp04
            {
                mX =  mX,
                mY = mY,
                x1 = ParentX,
                y1 = ParentY,
                c = c,
                c1 = c1,
                c2 = c2,
                c3 = c3,
                position = "horizontol",
                title = "sol kenar "

            });

            swg += compannet04.svgBody();


            swg += new LineModel(compannet04.X1, compannet04.Y1 - ((h / 2) * mY), compannet04.X1 + (a * mX),
                compannet04.Y1 - ((h / 2) * mY), "B", 1, "A",mX,mY).line;
            var line = new LineModel(compannet04.X1, compannet04.Y1, compannet04.X1 + (a * mX), compannet04.Y1, "R", 0, "", mX, mY);
            if (ParmakType == 3 | ParmakType == 4)
            {

                //swg += line.line;
                var cmp08 = (new cmp08 { x1 = compannet04.X1, y1 = compannet04.Y1, a = aa, r1 = r1, mY = mY, mX = mX });
                swg += cmp08.svgBody();
                line = new LineModel(cmp08.X1, cmp08.Y1, cmp08.X1, cmp08.Y1, "R", 0, "", mX, mY);
            }

            else if (dilKodu == 3 | dilKodu == 4)
            {
                AltDilType = 1;
                var linec = new LineModel(compannet04.X1, compannet04.Y1, compannet04.X1 + ((a / 2 - d / 2) * mX), compannet04.Y1, "R", 0, "", mX, mY);
                swg += linec.line;
                var cmp06 = (new cmp06 { x1 = linec.X1, y1 = linec.Y1, mX = mX, mY = -1 * mY, d = d });
                swg += cmp06.svgBody();
                linec = new LineModel(cmp06.X1, cmp06.Y1, cmp06.X1 + ((a / 2 - d / 2) * mX), cmp06.Y1, "R", 0, "", mX, mY);
                swg += linec.line;
            }
            else
            {

                line = new LineModel(compannet04.X1, compannet04.Y1, compannet04.X1 + (a * mX), compannet04.Y1, "R", 0, "", mX, mY);

                swg += line.line;
            }
            swg += new LineModel(line.X1, line.Y1 - ((h / 2) * mY), line.X1 + (b * mX), line.Y1 - ((h / 2) * mY), "B", 1, "B",mX,mY).line;
            swg += new LineModel(line.X1, line.Y1, line.X1, line.Y1 - (h * mY), "G", 0, "",mX,mY).line;
            var compannet02 = (new cmp02 { type = typeModel, mX = mX, mY = -1 * mY, x1 = line.X1, y1 = line.Y1, z = z, z1 = z1, z2 = z2, z3 = z3, g = g, title = "alt sol kulak" });
            swg += compannet02.svgBody();
            swg += new LineModel(compannet02.X1, compannet02.Y1, compannet02.X1, compannet02.Y1 - (h * mY), "G", 0, "",mX,mY).line;
            ////kompannet gelecek



            line = new LineModel(compannet02.X1, compannet02.Y1, compannet02.X1, compannet02.Y1 + (malzeme * mY), "R", 0, "", mX, mY);
            var mlline = line.line;
            line = new LineModel(line.X1, line.Y1, line.X1 + (aa * mX), line.Y1, "G", 0, "", mX, mY);

            swg += line.line;


            var line1 = new LineModel(line.X1, line.Y1, line.X1 + (aa * mX), line.Y1, "G", 0, "", mX, mY);





            if (typeModel == 1)
            {
                line1 = new LineModel(line.X1, line.Y1, line.X1, line.Y1 + ((g - malzeme) * mY), "G", 0, "", mX, mY);
                line1 = new LineModel(line1.X1, line1.Y1, line1.X1, line1.Y1 + ((e - (g - malzeme)) * mY), "R", 0, "", mX, mY);
                swg += line1.line;
            }
            else
            {
                swg += mlline;
                line1 = new LineModel(line.X1, line.Y1, line.X1, line.Y1 + ((e) * mY), "R", 0, "", mX, mY);
                swg += line1.line;
            }
            var compannet03 = (new cmp03
            {
                type = typeModel,
                mX = -1 * mX,
                mY = -1 * mY,
                x1 = line1.X1,
                y1 = line1.Y1,
                f = f,
                f1 = f1,
                f2 = f2,
                f3 = f3,
                f4 = f4,
                f5 = f5,
                dxtt = dxtt,
                d5 = d5,
                malzeme = malzeme,
                DilType = AltDilType


            });
            swg += compannet03.svgBody();
            if (typeModel == 1)
            {
                line1 = new LineModel(compannet03.X1, compannet03.Y1, compannet03.X1, compannet03.Y1 - ((e - (g - malzeme)) * mY), "R", 0, "", mX, mY);
            }
            else
            {
                line1 = new LineModel(compannet03.X1, compannet03.Y1, compannet03.X1, compannet03.Y1 - ((e) * mY), "R", 0, "", mX, mY);
            }
            swg += line1.line;
            line = new LineModel(line.X1, line.Y1, line.X1, line.Y1 - (malzeme * mY), "R", 0, "", mX, mY);
            swg += line.line;
            swg += new LineModel(line.X1, line.Y1, line.X1, line.Y1 - (h * mY), "G", 0, "", mX, mY).line;
            swg += new LineModel(line.X1 + ((bb / 3) * mX), line.Y1, line.X1 + ((bb / 3) * mX), line.Y1 - (h * mY), "B", 1, "H", mX, mY).line;
            line = new LineModel(line.X1, line.Y1, line.X1 + (bb * mX), line.Y1, "G", 0, "", mX, mY);

            compannet02 = (new cmp02 { type = typeModel, mX = -1 * mX, mY = -1 * mY, x1 = line.X1, y1 = line.Y1, z = z, z1 = z1, z2 = 0, z3 = bb, g = g, title = "alt sol kulak" });
            swg += compannet02.svgBody();

            line = new LineModel(line.X1, line.Y1, line.X1, line.Y1 - (h * mY), "R", 0, "", mX, mY);
            swg += line.line;

            line = new LineModel(line.X1, line.Y1, line.X1 - (bb * mX), line.Y1, "G", 0, "", mX, mY);

            compannet02 = (new cmp02 { type = typeModel, mX = 1 * mX, mY = 1 * mY, x1 = line.X1, y1 = line.Y1, z = z, z1 = z1, z2 = z2, z3 = bb, g = g, title = "alt sol kulak" });
            swg += compannet02.svgBody();


            if (AskilikType != 1)
            {
                double m = aa;
                double m2 = 1;
                line = new LineModel(line.X1, line.Y1, line.X1 - (aa * mX), line.Y1, "R", 0, "", mX, mY);
                var compannet05 = (new cmp05a { type = typeModel, mX = 1 * mX, mY = 1 * mY, x1 = line.X1, y1 = line.Y1, m = m, m1 = m1, m2 = m2, m4 = m4, m9 = m9, title = "üst askılık" });
                swg += compannet05.svgBody();
            }
            else if (dilKodu == 2 | dilKodu == 4)
            {
                UstDilType = 1;
                line = new LineModel(line.X1, line.Y1, line.X1 - ((aa / 2 - d / 2) * mX), line.Y1, "R", 0, "", mX, mY);
                swg += line.line;
                var cmp06 = (new cmp06
                {
                    x1 = line.X1,
                    y1 = line.Y1,
                    mX = -1 * mX,
                    mY = mY,
                    d = d
                });
                swg += cmp06.svgBody();
                line = new LineModel(cmp06.X1, cmp06.Y1, cmp06.X1 - ((aa / 2 - d / 2) * mX), cmp06.Y1, "R", 0, "", mX, mY);
                swg += line.line;
            }
            else if (ParmakType == 2 | ParmakType == 4)
            {
                line = new LineModel(line.X1, line.Y1, line.X1 - (aa * mX), line.Y1, "R", 0, "", mX, mY);
                //swg += line.line;
                var cmp08 = (new cmp08 { x1 = line.X1, y1 = line.Y1, mY = -1 * mY, mX = mX, a = aa, r1 = r1 });
                swg += cmp08.svgBody();
            }
            else
            {
                line = new LineModel(line.X1, line.Y1, line.X1 - (aa * mX), line.Y1, "R", 0, "", mX, mY);
                swg += line.line;
            }
            compannet02 = (new cmp02 { type = typeModel, mX = -1 * mX, mY = mY, x1 = line.X1, y1 = line.Y1, z = z, z1 = z1, z2 = z2, z3 = b, g = g, title = "üst sol kulak" });
            swg += compannet02.svgBody();
            line = new LineModel(compannet02.X1, compannet02.Y1, compannet02.X1, compannet02.Y1 - (malzeme * mY), "R", 0, "", mX, mY);
            line = new LineModel(line.X1, line.Y1, line.X1 - (a * mX), line.Y1, "G", 0, "", mX, mY);
            swg += line.line;
            swg += new LineModel(line.X1, line.Y1, line.X1, line.Y1 + (malzeme * mY), "R", 0, "", mX, mY).line;
            line = new LineModel(line.X1, line.Y1, line.X1, line.Y1 - (e * mY), "R", 0, "", mX, mY);
            swg += line.line;

            compannet03 = (new cmp03
            {
                type = typeModel,
                mX = mX,
                mY = mY,
                x1 = line.X1,
                y1 = line.Y1,
                f = f,
                f1 = f1,
                f2 = f2,
                f3 = f3,
                f4 = f4,
                f5 = f5,
                d5 = d5,
                dxtt = dxtt,
                malzeme = malzeme,
                DilType = UstDilType
            });
            swg += compannet03.svgBody();
            if (typeModel == 1)
            {
                line = new LineModel(compannet03.X1, compannet03.Y1, compannet03.X1, compannet03.Y1 + ((e - (g - malzeme)) * mY), "R", 0, "", mX, mY);
                swg += line.line;
            }
            else
            {
                line = new LineModel(compannet03.X1, compannet03.Y1, compannet03.X1, compannet03.Y1 + ((e + malzeme) * mY), "R", 0, "", mX, mY);
                swg += line.line;
            }


        }
    }
}