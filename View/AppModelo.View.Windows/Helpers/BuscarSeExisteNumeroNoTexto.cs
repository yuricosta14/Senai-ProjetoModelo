namespace AppModelo.View.Windows.Helpers
{
    internal static partial class Componentes
    {
        /// <summary>
        /// Verifica se existe múmero no texto, foi utilizado no formulario de cadastro de naturalidade 
        /// para que não seja cadastrado naturalidades com números
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        internal static bool ExisteNumeroNoTexto(string texto)
        {
            foreach (var letra in texto)
            {
                if (char.IsNumber(letra))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
