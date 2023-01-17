using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula4.Models
{
    public class LogComReflection
    {
        public static void Log(object obj)
        {
            var tipo = obj.GetType();

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Log do " + tipo.Name);
            builder.AppendLine("Data: " + DateTime.Now);

            foreach (var prop in tipo.GetProperties())
            {
                builder.AppendLine(prop.Name + ": " + prop.GetValue(obj));
            }
            ImprimirLog(builder.ToString());


        }
        public static void ImprimirLog(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
