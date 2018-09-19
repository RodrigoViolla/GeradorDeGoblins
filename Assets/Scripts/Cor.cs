using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cor {
	private string nome;
	private int combate, conhecimento, habilidade, sorte;
	public Cor(string nome, int combate, int conhecimento, int habilidade, int sorte){
		this.nome = nome;
		this.combate = combate;
		this.conhecimento = conhecimento;
		this.habilidade = habilidade;
		this.sorte = sorte;
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
}
