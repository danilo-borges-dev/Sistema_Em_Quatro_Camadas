namespace Sistema.Dados
{
    internal class Conexao
    {
        private string _base;
        private string _servidor;
        private string _usuario;
        private string _chave;
        private bool _seguranca;
        private static Conexao _con = null;
        private Conexao()
        {
            _base = "DbSistema";
            _servidor = @"DESKTOP-5HC68GT\SQLEXPRESS";
            _usuario = "sa";
            _chave = "123456";
            _seguranca = seguranca;
        }
    }
}
