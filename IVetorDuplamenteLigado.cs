using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorDuplamenteLigado
{
    internal interface IVetorDuplamenteLigado
    {
        //Retorna o elemento no índice pos
        public object ElemAtRank(int pos);

        //Remove e retorna o elemento no índice pos
        public object RemoveAtRank(int pos);

        //Substitui o elemento no índice pos por novo
        //e retorna o elemento antigo
        public object ReplaceAtRank(int pos, object novo);

        //Insere um novo elemento no índice pos
        public void InserAtRank(int pos, object novo);
    }
}
