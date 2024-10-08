using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Mubarakshin.Database
{
    public partial class Book
    {
        //public SolidColorBrush DiscountColor
        //{
        //    get
        //    {
        //        if (Classes.DatabaseConnectionClass.DatabaseConnection.MaxDiscount.Where(c => c.MaxDiscountId == MaxDiscountId).First().Value > 15)
        //            return Brushes.Chartreuse;
        //        else return Brushes.Transparent;

        //    }

        //}
        public SolidColorBrush RowColor
        {
            get
            {
                if (MaxDiscount?.Value == 10)
                    return Brushes.LightGreen; 
                else if (MaxDiscount?.Value == 5)
                    return Brushes.LightCoral;
                //p/s если надо оставить выделение для скидки больше 15%
                else if (Classes.DatabaseConnectionClass.DatabaseConnection.MaxDiscount.Where(c => c.MaxDiscountId == MaxDiscountId).First().Value > 15)
                    return Brushes.Chartreuse;

                else
                    return Brushes.Transparent;

            }
        }


    }
}
