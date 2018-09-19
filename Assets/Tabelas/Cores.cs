using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cores{
	public Cor[] tabela = new Cor[7];

	public void Carregar(){
		tabela [1] = new Cor ("Verde Claro", 2, 2, 1, 1);
		tabela [2] = new Cor ("Vermelho", 2, 1, 1, 2);
		tabela [3] = new Cor ("Verde Escuro", 2, 1, 2, 1);
		tabela [4] = new Cor ("Amarelo", 1, 1, 2, 2);
		tabela [5] = new Cor ("Vermelho", 1, 2, 2, 1);
		tabela [6] = new Cor ("Azul", 1, 2, 1, 2);
	}
}
