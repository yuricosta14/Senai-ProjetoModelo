namespace AppModelo.Model.Infra.Databases
{
    public static class MySql
    {
        /// <summary>
        /// efetua a conexão do programa com o banco de dados
        /// </summary>
        /// <returns>Retorna o pedido de conexão do programa com o banco de dados</returns>
        public static string ConectionString()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline15;uid=wwonline15;password=aluno22senai;";
            return conn;
        }
    }
}
