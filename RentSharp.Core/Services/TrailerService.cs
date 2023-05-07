using RentSharp.Web.Server.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSharp.Core.Services
{
    internal class TrailerService
    {
        public Trailer CreateTrailer(Trailer trailer)
        {
            return trailer;
        }

        public Boolean DeleteTrailer(Guid trailerID)
        {
            // set as inactive
            return true;
        }

        public Trailer UpdateTrailer(Trailer trailer)
        {
            return trailer;
        }
    }
}
