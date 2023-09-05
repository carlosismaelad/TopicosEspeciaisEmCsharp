using System;
using System.Globalization;

namespace DateCultureInfo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            DateTime date = DateTime.Now;

            var br = new CultureInfo("pt-BR"); // Criando uma instância do Cultureinfo e passando o tipo de cultura (Português do Brasil)
            var pt = new CultureInfo("pt-PT"); // Português de Portugal
            var enUS = new CultureInfo("en-US"); // Inglês do EUA
            var enUK = new CultureInfo("en-GB"); // Inglês do Reino Unido (Britânico)
            var de = new CultureInfo("de-DE"); // Alemão da Alemanhã
            var fr = new CultureInfo("fr-FR"); // Lingua da Dinamarca
            var zhCN = new CultureInfo("zh-CN"); // Chinês Simplificado
            var koKR = new CultureInfo("ko-KR"); // Coreano
            var jaJP = new CultureInfo("ja-JP"); // Japonês
            var ruRU = new CultureInfo("ru-RU"); // Russo
            var localConfig = CultureInfo.CurrentCulture; // pega a cultura da maquina que estamos usando


            Console.WriteLine(date); // irá exibir no formato americano -> 05/09/2023 12:09:02

            Console.WriteLine(DateTime.Now.ToString("d")); // Parseando diretamente no Console -> 05/09/2023


            Console.WriteLine(DateTime.Now.ToString("D", enUK)); // informando a cultura que queremos -> Tuesday, September 5, 2023
            Console.WriteLine(DateTime.Now.ToString("D", de)); // Dienstag, 5. September 2023
            Console.WriteLine(DateTime.Now.ToString("D", fr)); // mardi 5 septembre 2023
            Console.WriteLine(DateTime.Now.ToString("D", zhCN)); // 2023年9月5日星期二 / Chinês
            Console.WriteLine(DateTime.Now.ToString("D", koKR)); // 2023년 9월 5일 화요일 / koreano
            Console.WriteLine(DateTime.Now.ToString("D", jaJP)); // 2023年9月5日火曜日 / japonês
            Console.WriteLine(DateTime.Now.ToString("D", ruRU)); // вторник, 5 сентября 2023 г. / Russo
            Console.WriteLine(DateTime.Now.ToString("D", localConfig)); // terça-feira, 5 de setembro de 2023







        }
    }
}