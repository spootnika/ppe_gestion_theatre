using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class ToHave
    {
        private Nationality toHave_nationality;
        private Actor toHave_actor;

        public Nationality ToHave_nationality { get => toHave_nationality; set => toHave_nationality = value; }
        public Actor ToHave_actor { get => toHave_actor; set => toHave_actor = value; }
    }
}
