VetorDuplamenteLigado.VetorDuplamenteLigado vetor = new();

vetor.InserAtRank(0, 1);
vetor.InserAtRank(1, 2);
vetor.InserAtRank(2, 3);
vetor.InserAtRank(3, 4);

//(0) - 1
//(1) - 2
//(2) - 3
//(3) - 4

vetor.InserAtRank(2, "dois");

//(0) - 1
//(1) - 2
//(2) - "dois"
//(3) - 3
//(4) - 4

vetor.ReplaceAtRank(1, "um");

//(0) - 1
//(1) - "um"
//(2) - "dois"
//(3) - 3
//(4) - 4

vetor.RemoveAtRank(3);

//(0) - 1
//(1) - "um"
//(2) - "dois"
//(3) - 4

vetor.RemoveAtRank(4);

//"O rank 4 não existe"