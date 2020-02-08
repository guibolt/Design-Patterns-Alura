using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public  class EnviaSMS : IAcaoAposGerarNota
    {
        public void Executa() => Console.WriteLine("enviando por sms");
    }
}
