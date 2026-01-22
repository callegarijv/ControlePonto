namespace ControlePonto.Validadores
{
    public static class ValidadorNome
    {
        public static bool Validar(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome)) return false;

            foreach (char c in nome)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    return false;
            }

            return true;
        }
    }
}
