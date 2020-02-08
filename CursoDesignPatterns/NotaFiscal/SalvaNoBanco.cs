using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class SalvaNoBanco: IAcaoAposGerarNota
    {
        public void Executa() => Console.WriteLine("salvando no banco");
    }
}
