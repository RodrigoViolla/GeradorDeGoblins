using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipamento{
	private string nome;
	private string descricao;
	private int dano;
	private int defesa;

	public Equipamento(string nome, string descricao, int dano, int defesa){
		this.nome = nome;
		this.descricao = descricao;
		this.dano = dano;
		this.defesa = defesa;
	}
	public string Nome{
		get{return nome;}
	}
	public string Descricao{
		get{return descricao;}
	}
	public int Dano{
		get{return dano;}
	}
	public int Defesa{
		get{return defesa;}
	}
}
