using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caracteristicas{
	public Caracteristica[] tabela = new Caracteristica[7];

	public void Carregar(){
		tabela [1] = new Caracteristica ("Insano", "Você não tem controle de seus atos. Sempre que o mestre quiser, ele pode pedir um teste de Sorte (dificuldade 5). Se você falhar, o mestre poderá decidir um ato idiota para seu personagem fazer.");
		tabela [2] = new Caracteristica ("Fedorento", "Você fede e ninguém gosta de ficar perto. Qualquer um que fique por mais de 1 minuto perto de você, poderá ficar nauseado e vomitar.");
		tabela [3] = new Caracteristica ("Cicatrizes", "Você possui muitas cicatrizes de muitas batalhas. As fêmeas goblins nunca olharão para você.");
		tabela [4] = new Caracteristica ("Gordo", "Você é obeso e tem problemas em passar em buracos estreitos, se esconder e não consegue correr por muito tempo.");
		tabela [5] = new Caracteristica ("Fala Errado", "Você tem algum problema de comunicação (gagueira, língua presa, troca letras, etc) e isso irrita muito os seus companheiros.");
		tabela [6] = new Caracteristica ();
	}
}
