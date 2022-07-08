using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorDuplamenteLigado
{
    public class VetorDuplamenteLigado : IVetorDuplamenteLigado
    {
        public LinkedList<object> LinkedList { get; set; }

        //Construtor
        public VetorDuplamenteLigado()
        {
            this.LinkedList = new LinkedList<object>();
        }
        public object ElemAtRank(int rank)
        {
            EmptyExceptionCheck();
            RankExceptionCheck(rank);
            return Search(rank).Value;
        }
        public void InserAtRank(int rank, object novo)
        {
            //Checa se o rank é válido para inserção
            InsertExceptionCheck(rank);
            //Novo nó a ser inserido
            LinkedListNode<object> newNode = new(novo);

            //Se o vetor estiver vazio
            if (IsEmpty())
            {
                LinkedList.AddFirst(newNode);
            }
            else if (rank == LinkedList.Count)
            {
                LinkedList.AddLast(newNode);
            }
            else
            {
                LinkedList.AddBefore(Search(rank), newNode);
            }
        }
        private bool IsEmpty()
        {
            return LinkedList.Count == 0;
        }
        public object RemoveAtRank(int rank)
        {
            EmptyExceptionCheck();
            RankExceptionCheck(rank);
            object ret = Search(rank).Value;
            LinkedList.Remove(Search(rank));
            return ret;
        }
        public object ReplaceAtRank(int rank, object novo)
        {
            EmptyExceptionCheck();
            RankExceptionCheck(rank);
            object ret = Search(rank).Value;
            Search(rank).Value = novo;
            return ret;
        }

        //Retorna o nó do rank informado
        private LinkedListNode<object> Search(int rank)
        {
            //Se o rank procurado estiver no começo da lista, começa
            //a busca pelo começo da lista
            if (rank < LinkedList.Count / 2)
            {
                LinkedListNode<object> node = LinkedList.First;
                //Buscando o n
                for (int i = 0; i < rank; i++)
                {
                    node = node.Next;
                }
                return node;
            }
            //Se o rank procurado estiver no final da lista, começa
            //a busca pelo final da lista
            else
            {
                LinkedListNode<object> node = LinkedList.Last;
                for (int i = LinkedList.Count - 1; i > rank; i--)
                {
                    node = node.Previous;
                }
                return node;
            }
        }

        //Checar exceções
        private void EmptyExceptionCheck()
        {
            if (IsEmpty())
            {
                throw new VetorVazioException("O vetor está vazio");
            }
        }
        private void InsertExceptionCheck(int rank)
        {
            if (rank < 0 || rank > LinkedList.Count)
            {
                throw new InsercaoForaDeAlcanceException($"O rank { rank } não está acessível");
            }
        }
        private void RankExceptionCheck(int rank)
        {
            if (rank < 0 || rank > LinkedList.Count-1)
            {
                throw new InsercaoForaDeAlcanceException($"O rank { rank } não existe");
            }
        }
    }
}
