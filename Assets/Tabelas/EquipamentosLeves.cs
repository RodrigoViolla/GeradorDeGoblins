using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipamentosLeves{
	public Equipamento[] tabela = new Equipamento[7];

	public void Carregar(){
		tabela[1] = new Equipamento ("Duas Adagas", "", 2, 0);
		tabela[2] = new Equipamento ("Uma adaga e um escudo", "", 2, 1);
		tabela[3] = new Equipamento ("Arco Simples", "Distancia", 2, 0);
		tabela[4] = new Equipamento ("Arco Composto", "Distancia", 3, 0);
		tabela[5] = new Equipamento ("Quatro Adagas", "", 2, 0);
		tabela[6] = new Equipamento ("Besta e Helmo", "Distancia", 3, 1);
	}
}
