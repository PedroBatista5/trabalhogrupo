
using System;
using System.Collections.Generic;
using System.Configuration;
using MySql.Data.MySqlClient;



namespace trabalhogrupo
{
    internal class conexao
    {
        private const string servidor = "localhost"; //Servidor do MYSQL WorkBench
        private const string basedados = "mydb"; //Nome do esquema
        private const string utilizador = "root"; //Nome do utilizador (Predefenição)
        private const string pass = ""; //Palavra passe da conexão

        static public string strligar = $"server={servidor}; User ID={utilizador}; database={basedados}; password={pass}";
    }
}