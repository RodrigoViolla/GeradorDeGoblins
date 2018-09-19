using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classe{
	private string nome, especial;
	private int combate, conhecimento, habilidade, sorte;
	private Equipamento equip;

	public Classe(string nome, string especial, int combate, int conhecimento, int habilidade, int sorte, Equipamento[] tabela){
		RolaDados dado = new RolaDados ();
		this.nome = nome;
		this.combate = combate;
		this.conhecimento = conhecimento;
		this.habilidade = habilidade;
		this.sorte = sorte;
		this.especial = especial;
		equip = tabela [dado.RolarDados(1)];
	}
	public Classe(string nome, string especial, int combate, int conhecimento, int habilidade, int sorte){//Exclusivo para Xamã
		this.nome = nome;
		this.combate = combate;
		this.conhecimento = conhecimento;
		this.habilidade = habilidade;
		this.sorte = sorte;
		this.especial = especial;
		equip = new Equipamento ("Cajado", "Você começa com 8 pontos de magia", 1, 0);
	}
	public string Nome{
		get{return nome;}
	}
	public int Combate{
		get{return combate;}
	}
	public int Conhecimento{
		get{return conhecimento;}
	}
	public int Habilidade{
		get{return habilidade;}
	}
	public int Sorte{
		get{return sorte;}
	}
	public string Especial{
		get{return especial;}
	}
	public Equipamento Equip{
		get{return equip;}
	}
}
