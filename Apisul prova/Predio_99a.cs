using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apisul_prova
{
    
    internal class Predio_99a: IElevadorService
    {
        Input input = new Input();
        public int Andares = 16;
        public string[] Elevadores = new string[5] { "A", "B", "C", "D", "E"};

        public List<int> andarMenosUtilizado()
        {
            List<int> resultadoFinal = new List<int>();
            Dictionary<int, int> resultados = new Dictionary<int, int>();
            var dados = input.RecebeDados();

            foreach (var i in dados)
            {
                if (resultados.ContainsKey(i.Andar))
                {
                    resultados[i.Andar]++;
                }
                else
                {
                    resultados.Add(i.Andar, 1);
                }
            }
            foreach (int i in Enumerable.Range(0, 17))
            {
                if (!resultados.ContainsKey(i))
                {
                resultados.Add(i, 0);
                }
            }
            var resultadoOrganizado = resultados.OrderBy(x => x.Value)
                .ToDictionary(
                x => x.Key,
                x => x.Value
                );

            foreach (var i in resultadoOrganizado)
            {
                resultadoFinal.Add(i.Key);
            }

            return resultadoFinal;

            throw new NotImplementedException();
        }

        public List<char> elevadorMaisFrequentado()
        {
            List<char> resultadoFinal = new List<char>();
            Dictionary<string, int> resultados = new Dictionary<string, int>();
            var dados = input.RecebeDados();

            foreach (var i in dados)
            {
                if (i.Elevador == Elevadores[0])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[1])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[2])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[3])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[4])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
            }

            var resultadosOrganizados = resultados.OrderByDescending(x => x.Value)
                .ToDictionary(
                x => x.Key,
                x => x.Value);

            foreach (var i in resultadosOrganizados)
            {
                resultadoFinal.Add(Convert.ToChar(i.Key));
            }

            return resultadoFinal;
        }

        public List<char> elevadorMenosFrequentado()
        {
            List<char> resultadoFinal = new List<char>();
            Dictionary<string, int> resultados = new Dictionary<string, int>();
            var dados = input.RecebeDados();

            foreach (var i in dados)
            {
                if (i.Elevador == Elevadores[0])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[1])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[2])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[3])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[4])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
            }

            var resultadosOrganizados = resultados.OrderBy(x => x.Value)
                .ToDictionary(
                x => x.Key,
                x => x.Value);

            foreach (var i in resultadosOrganizados)
            {
                resultadoFinal.Add(Convert.ToChar(i.Key));
            }

            return resultadoFinal;
        }

        public float percentualDeUsoElevadorA()
        {
            float final;
            Dictionary<string, int> resultados = new Dictionary<string, int>();
            var dados = input.RecebeDados();
            
            foreach (var i in dados)
            {
                if (i.Elevador == Elevadores[0])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[1])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[2])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[3])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[4])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
            }
            
            int somaDeTodosOsValores = resultados["A"] + resultados["B"] + resultados["C"] + resultados["D"] + resultados["E"];

            final = ((float)resultados["A"] / somaDeTodosOsValores) * 100;

            return final;
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorB()
        {
            float final;
            Dictionary<string, int> resultados = new Dictionary<string, int>();
            var dados = input.RecebeDados();

            foreach (var i in dados)
            {
                if (i.Elevador == Elevadores[0])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[1])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[2])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[3])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[4])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
            }

            int somaDeTodosOsValores = resultados["A"] + resultados["B"] + resultados["C"] + resultados["D"] + resultados["E"];

            final = ((float)resultados["B"] / somaDeTodosOsValores) * 100;

            return final;
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorC()
        {
            float final;
            Dictionary<string, int> resultados = new Dictionary<string, int>();
            var dados = input.RecebeDados();

            foreach (var i in dados)
            {
                if (i.Elevador == Elevadores[0])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[1])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[2])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[3])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[4])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
            }

            int somaDeTodosOsValores = resultados["A"] + resultados["B"] + resultados["C"] + resultados["D"] + resultados["E"];

            final = ((float)resultados["C"] / somaDeTodosOsValores) * 100;

            return final;
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorD()
        {
            float final;
            Dictionary<string, int> resultados = new Dictionary<string, int>();
            var dados = input.RecebeDados();

            foreach (var i in dados)
            {
                if (i.Elevador == Elevadores[0])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[1])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[2])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[3])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[4])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
            }

            int somaDeTodosOsValores = resultados["A"] + resultados["B"] + resultados["C"] + resultados["D"] + resultados["E"];

            final = ((float)resultados["D"] / somaDeTodosOsValores) * 100;

            return final;
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorE()
        {
            float final;
            Dictionary<string, int> resultados = new Dictionary<string, int>();
            var dados = input.RecebeDados();

            foreach (var i in dados)
            {
                if (i.Elevador == Elevadores[0])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[1])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[2])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[3])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
                else if (i.Elevador == Elevadores[4])
                {
                    if (resultados.ContainsKey(i.Elevador))
                    {
                        resultados[i.Elevador]++;
                    }
                    else
                    {
                        resultados.Add(i.Elevador, 1);
                    }
                }
            }

            int somaDeTodosOsValores = resultados["A"] + resultados["B"] + resultados["C"] + resultados["D"] + resultados["E"];

            final = ((float)resultados["E"] / somaDeTodosOsValores) * 100;

            return final;
            throw new NotImplementedException();
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            char elevador = elevadorMaisFrequentado()[0];
            List<char> resultado = new List<char>();
            Dictionary<char, int> resultados = new Dictionary<char, int>();

            foreach (var i in input.RecebeDados())
            {
                if (Convert.ToChar(i.Elevador) == elevador)
                {
                    if (resultados.ContainsKey(Convert.ToChar(i.Turno)))
                    {
                        resultados[Convert.ToChar(i.Turno)]++;
                    }
                    else
                    {
                        resultados.Add(Convert.ToChar(i.Turno), 1);
                    }
                }
            }

            var resultadoOrganizado = resultados.OrderByDescending(x => x.Value)
                .ToDictionary(
                x => x.Key,
                x => x.Value
                );

            foreach (var i in resultadoOrganizado)
            {
                resultado.Add(i.Key);
            }

            foreach (char i in new List<char>() { 'M', 'V', 'N' })
            {
                if (!resultado.Contains(i))
                {
                    resultado.Add(i);
                }
            }

            return resultado;
            throw new NotImplementedException();
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            List<char> resultadoFinal = new List<char>();
            Dictionary<char, int> resultados = new Dictionary<char, int>();
            var dados = input.RecebeDados();

            foreach (var i in dados)
            {
                if (resultados.ContainsKey(Convert.ToChar(i.Turno)))
                {
                    resultados[Convert.ToChar(i.Turno)]++;
                }
                else
                {
                    resultados.Add(Convert.ToChar(i.Turno), 1);
                }
            }

            var resultadosOrganizados = resultados.OrderByDescending(x => x.Value)
                .ToDictionary(
                x => x.Key,
                x => x.Value);

            foreach (var i in resultadosOrganizados)
            {
                resultadoFinal.Add(Convert.ToChar(i.Key));
            }

            return resultadoFinal;
            throw new NotImplementedException();
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            char elevador = elevadorMaisFrequentado()[elevadorMaisFrequentado().Count - 1];
            List<char> resultado = new List<char>();
            Dictionary<char, int> resultados = new Dictionary<char, int>();

            foreach (var i in input.RecebeDados())
            {
                if (Convert.ToChar(i.Elevador) == elevador)
                {
                    if (resultados.ContainsKey(Convert.ToChar(i.Turno)))
                    {
                        resultados[Convert.ToChar(i.Turno)]++;
                    }
                    else
                    {
                        resultados.Add(Convert.ToChar(i.Turno), 1);
                    }
                }
            }

            var resultadoOrganizado = resultados.OrderBy(x => x.Value)
                .ToDictionary(
                x => x.Key,
                x => x.Value
                );

            foreach (var i in resultadoOrganizado)
            {
                resultado.Add(i.Key);
            }

            foreach (char i in new List<char>() { 'M', 'V', 'N'})
            {
                if (!resultado.Contains(i))
                {
                    resultado.Add(i);
                }
            }

            return resultado;
            throw new NotImplementedException();
        }
    }
}
