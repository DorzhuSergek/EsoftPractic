using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
  partial  class RealEstateAgencyEntities3
    {
        public static RealEstateAgencyEntities3 _context;
        public static RealEstateAgencyEntities3 GetContext()
        {
            if (_context == null)
            {
                _context = new RealEstateAgencyEntities3();
            }
            return _context;
        }
    }
}
