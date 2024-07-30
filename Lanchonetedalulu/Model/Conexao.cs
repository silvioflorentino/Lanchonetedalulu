using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonetedalulu.Model
{
    internal class Conexao
    {
        public static string Conectar() {
        
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\silvio.wflorentino\source\repos\Lanchonetedalulu\Lanchonetedalulu\Dados\lanchonetebd.mdf;Integrated Security=True";
        }
    }
}
