﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonetedalulu.Model
{
    internal class Produtos
    {
        private static int id_Prod;
        private static string nome_Prod;
        private static int qtd_Prod;
        private static float preco_Prod;
        private static string tipo_Prod;

        public static int Id_Prod { get => id_Prod; set => id_Prod = value; }
        public static string Nome_Prod { get => nome_Prod; set => nome_Prod = value; }
        public static int Qtd_Prod { get => qtd_Prod; set => qtd_Prod = value; }
        public static float Preco_Prod { get => preco_Prod; set => preco_Prod = value; }
        public static string Tipo_Prod { get => tipo_Prod; set => tipo_Prod = value; }
    }
}
