using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{

    class SalonElement : MapObject, IComposite
    {
        private List<MapObject> elementen = new List<MapObject>();

        public SalonElement(Point salonLoc)
        {

            elementen.Add(new ZetelElement(new Point(1, 1), 3, '+'));
            elementen.Add(new ZetelElement(new Point(4, 7), 3, '+'));

            Location = salonLoc;
        }

        public override void Paint()
        {
            for (int i = 0; i < elementen.Count; i++)
            {
                elementen[i].Paint();
            }

        }

        public void UpdateElements(Point offset)
        {
            for (int i = 0; i < elementen.Count; i++)
            {
                Point elementLoc = elementen[i].Location;
                elementLoc.X += offset.X;
                elementLoc.Y += offset.Y;
                elementen[i].Location = elementLoc;
            }
        }
    }

}
