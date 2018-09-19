using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin{
	private string nome;
	private Classe classe;
	private Cor cor;
	private Caracteristica caracteristica;
	private int combate, conhecimento, habilidade, sorte;

	public Goblin(string nome, Classe classe, Cor cor, Caracteristica caracteristica){
		this.nome = nome;
		this.cor = cor;
		this.caracteristica = caracteristica;
		this.classe = classe;

		combate = classe.Combate + cor.Combate;
		conhecimento = classe.Conhecimento + cor.Conhecimento;
		habilidade = classe.Habilidade + cor.Habilidade;
		sorte = classe.Sorte + cor.Sorte;
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
	public Classe Classe{
		get{return classe;}
	}
	public Cor Cor{
		get{return cor;}
	}
	public Caracteristica Caracteristica{
		get{return caracteristica;}
	}
}
