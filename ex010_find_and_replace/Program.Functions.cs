partial class Program
{
    public static string FindAndReplace(string text, string oldText, string newText)
    {
        int idx = 0;
        bool encontrado = false;
        string replacedText = "";

        while (idx <= (text.Length - oldText.Length))
        {
            int coincidencia = 0;
            int idx_old = 0;

            for(int i = idx; i< idx + oldText.Length; i++)
            {
                if (text[i] == oldText[idx_old])
                {
                    coincidencia++;
                }

                idx_old++;
            }

            if (coincidencia == oldText.Length)
            {
                replacedText = string.Format("{0}{1}{2}", text[0..idx], newText, text[(idx+oldText.Length)..]);
                encontrado = true;
            }

            idx++;
        }

        if (!encontrado)
        {
            throw new Exception(message: "No se encuentra el texto a reemplazar");           
        }
        else
        {
            return replacedText;
        }

    }
}