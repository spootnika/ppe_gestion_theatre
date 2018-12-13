using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class PublicType
    {
        private int publicType_id;
        private string publicType_name;
        private List<TheaterPiece> publicType_theaterPieces;

        public PublicType(int id, string name, List<TheaterPiece> theaterPieces)
        {
            this.PublicType_id = id;
            this.PublicType_name = name;
            this.PublicType_theaterPieces = theaterPieces;
        }

        public int PublicType_id
        {
            get
            {
                return publicType_id;
            }

            set
            {
                publicType_id = value;
            }
        }

        public string PublicType_name
        {
            get
            {
                return publicType_name;
            }

            set
            {
                publicType_name = value;
            }
        }

        public List<TheaterPiece> PublicType_theaterPieces
        {
            get
            {
                return publicType_theaterPieces;
            }

            set
            {
                publicType_theaterPieces = value;
            }
        }
    }
}
