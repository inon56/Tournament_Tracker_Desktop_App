using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibary
{
    /// <summary>
    /// Represents what the prize is for the given place
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The uniquue identifier for the prize
        /// </summary>
        public int Id { get; set; }

        public int PlaceNumber { get; set; } 
        
        public string PlaceName { get; set; }

        public decimal PriceAmount { get; set; }

        public double PricePercentage { get; set; }
    }
}
