using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes{
	public Classe[] tabela = new Classe[7];

	public void Carregar(){
		EquipamentosLeves leve = new EquipamentosLeves();
		EquipamentosPesados pesado = new EquipamentosPesados();
		EquipamentosExplosivos explosivo = new EquipamentosExplosivos();
		leve.Carregar ();
		pesado.Carregar ();
		explosivo.Carregar ();

		tabela [1] = new Classe ("Mercenario", "Mestre de Armas: Você sempre rola +1 dado em todos os ataques que você fizer lutando com sua arma favorita (Escolha uma).", 1, 0, 1, 0, pesado.tabela);
		tabela [2] = new Classe ("Caçador", "Rastrear: Com um teste bem sucedido de Conhecimento (dificuldade 3) você pode rastrear qualquer criatura.", 1, 0, 0, 1, leve.tabela);		
		tabela [3] = new Classe ("Piromaníaco", "Resistência: Você pode fazer um teste de Sorte (dificuldade 5) quando receber dano de fogo ou explosão de fogo. Se vencer, você não recebe dano.", 0, 0, 1, 1, explosivo.tabela);
		tabela [4] = new Classe ("Gatuno", "Roubar: Você pode roubar sem ser visto se vencer um teste resistido de Habilidade contra a vítima.", 0, 1, 1, 0, leve.tabela);
		tabela [5] = new Classe ("Lider","Grito de Guerra: Uma vez ao dia você pode dar um grito que permitirá que todos seus aliados rolem 1 dado a mais para se esquivar até o final da batalha.", 1, 1, 0, 0, pesado.tabela);
		tabela [6] = new Classe ("Xamã", "Raio de Energia: Você pode gastar pontos de magia para fazer ataques a distância. Cada ponto gasto causará um ponto de dano (pode gastar mais para fazer ataque com mais dano).", 0, 1, 0, 1);
	}
}
