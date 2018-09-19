using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipamentosExplosivos{
	public Equipamento[] tabela = new Equipamento[7];

	public void Carregar(){
		tabela[1] = new Equipamento ("Pistola e Helmo", "Distancia", 4, 1);
		tabela[2] = new Equipamento ("Duas Pistolas", "Distancia", 4, 0);
		tabela[3] = new Equipamento ("Três Galinhas Explosivas", "Distancia", 4, 0);
		tabela[4] = new Equipamento ("Barril de Polvora", "Dano em todos até 3m", 5, 0);
		tabela[5] = new Equipamento ("Pistola e duas Galinhas Explosivas", "Distancia", 4, 1);
		tabela[6] = new Equipamento ("Canhão", "Carregar[2 Turnos]", 8, 0);
	}
}
