using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Apisul_prova
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            IElevadorService dados = new Predio_99a();

            Console.WriteLine($"O andar menos utilizado é o andar {dados.andarMenosUtilizado()[0]};\n");

            Console.WriteLine($"O elevador mais utilizado é o {dados.elevadorMaisFrequentado()[0]} no periodo do(a) {dados.periodoMaiorFluxoElevadorMaisFrequentado()[0]};\n");

            Console.WriteLine($"O elevador menos utilizado é o {dados.elevadorMenosFrequentado()[0]} no periodo do(a) {dados.periodoMenorFluxoElevadorMenosFrequentado()[0]};\n");

            Console.WriteLine($"O periodo de maior utilização do conjunto dos elevadores é de {dados.periodoMaiorUtilizacaoConjuntoElevadores()[0]}; \n");

            Console.WriteLine($"O percentual de uso de cada elevador é de:\n -A: {Math.Truncate(dados.percentualDeUsoElevadorA() * 100) / 100}%\n -B: {Math.Truncate(dados.percentualDeUsoElevadorB() * 100) / 100}%\n -C: {Math.Truncate(dados.percentualDeUsoElevadorC() * 100) / 100}%\n -D: {Math.Truncate(dados.percentualDeUsoElevadorD() * 100) / 100}%\n -E: {Math.Truncate(dados.percentualDeUsoElevadorE() * 100) / 100}%\n ");

            Console.ReadKey();
            
        }
    }
}
