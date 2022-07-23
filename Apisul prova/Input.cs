using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apisul_prova
{
    internal class Input
    {
        public int Andar { get; set; }
        public string Elevador { get; set; }
        public string Turno { get; set; }

        public List<Input> RecebeDados()
        {
            return new List<Input>()
            {
                new Input()
                {
                    Andar = 11,
                    Elevador = "A",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 12,
                    Elevador = "A",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 14,
                    Elevador = "A",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 0,
                    Elevador = "A",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 1,
                    Elevador = "A",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 15,
                    Elevador = "B",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 13,
                    Elevador = "B",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 1,
                    Elevador = "C",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 2,
                    Elevador = "C",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 4,
                    Elevador = "C",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 3,
                    Elevador = "C",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 4,
                    Elevador = "C",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 5,
                    Elevador = "D",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 6,

                    Elevador = "E",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 7,
                    Elevador = "A",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 10,
                    Elevador = "A",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 9,
                    Elevador = "A",
                    Turno = "M"
                },

                new Input()
                {
                    Andar = 15,
                    Elevador = "B",
                    Turno = "V"
                },

                new Input()
                {
                    Andar = 13,
                    Elevador = "B",
                    Turno = "V"
                },

                new Input()
                {
                    Andar = 1,
                    Elevador = "C",
                    Turno = "V"
                },

                new Input()
                {
                    Andar = 2,
                    Elevador = "C",
                    Turno = "V"
                },

                new Input()
                {
                    Andar = 4,
                    Elevador = "C",
                    Turno = "N"
                },

                new Input()
                {
                    Andar = 3,
                    Elevador = "C",
                    Turno = "V"
                }
            };
        }
    }
}
