using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipamentosPesados{
	public Equipamento[] tabela = new Equipamento[7];

	public void Carregar(){
		tabela[1] = new Equipamento ("Espada e Escudo", "", 3, 1);
		tabela[2] = new Equipamento ("Machado e Helmo", "", 4, 1);
		tabela[3] = new Equipamento ("Duas Machadinhas", "", 3, 0);
		tabela[4] = new Equipamento ("Espadona", "", 5, 0);
		tabela[5] = new Equipamento ("Duas Espadas e Armadura", "", 3, 1);
		tabela[6] = new Equipamento ("Adaga, Espada e Armadura", "Adaga(Dano 2), Espada(Dano 3)", 3, 1);
	}
}
