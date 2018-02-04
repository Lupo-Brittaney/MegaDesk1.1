using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_BrittaneyLupo
{
    class DeskQuote
    {
        public string CustomerName { get; set; }
        public int RushDays { get; set; }
        public DateTime QuoteDate { get; set; }
        public Desk Desk = new Desk();
        public int QuoteTotal { get; set; }

        private int SurfaceArea = 0;

        // Constants - 
        private const int BASE_PRICE = 200;
        private const int BASE_SIZE = 1000; //after 1000 in sq an  additional charge is accrued
        private const int DRAWER_PRICE = 50; //cost is 50 per drawer
        private const int SURFACEAREA_ADD_PRICE = 1; //extra charge per square inch over BASE_SIZE

        public DeskQuote( string customerName, DateTime quoteDate, int width, int depth, int drawers, int rush, DeskMaterial material)
        {
            //setting attributes
            CustomerName = customerName;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumberOfDrawers = drawers;
            Desk.DeskMaterial = material;
            RushDays = rush;

            //get surface area
            SurfaceArea = Desk.Width * Desk.Depth;
        }
        public int GetQuoteTotal()
        {
            return BASE_PRICE + SurfaceAreaCost() + DrawerCost() + RushCost() + (int)Desk.DeskMaterial;
        }

        private int SurfaceAreaCost()
        {
            int cost = 0;
            if (SurfaceArea > BASE_SIZE)
            {
                cost = (SurfaceArea - 1000) * SURFACEAREA_ADD_PRICE;
                return cost;
            }
            else
                return cost;
        }
        private int DrawerCost()
        {
            return Desk.NumberOfDrawers * DRAWER_PRICE;
        }
        private int RushCost()
        {
            int rushCost = 0;
            if (RushDays == 3)
            {
                if (SurfaceArea < 1000)
                {
                    rushCost = 60;
                }
                else if (SurfaceArea <= 2000)
                {
                    rushCost = 70;
                }
                else if (SurfaceArea > 2000)
                {
                    rushCost = 80;
                }
            }
            else if (RushDays == 5)
            {
                if (SurfaceArea < 1000)
                {
                    rushCost = 40;
                }
                else if (SurfaceArea <= 2000)
                {
                    rushCost = 50;
                }
                else if (SurfaceArea > 2000)
                {
                    rushCost = 60;
                }
            }
            else if (RushDays == 7)
            {
                if (SurfaceArea < 1000)
                {
                    rushCost = 30;
                }
                else if (SurfaceArea <= 2000)
                {
                    rushCost = 35;
                }
                else if (SurfaceArea > 2000)
                {
                    rushCost = 40;
                }
            }

            return rushCost;
        }
    }
}
