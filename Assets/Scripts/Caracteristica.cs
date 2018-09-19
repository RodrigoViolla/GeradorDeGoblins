using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caracteristica{
	private string nome, descricao;
	private RolaDados dado = new RolaDados();
	public Caracteristica(string nome, string descricao){
		this.nome = nome;
		this.descricao = descricao;
	}
	public Caracteristica(){	
		descricao = "Você possui uma anomalia genética (algo comum entre goblins).";	
		rolarAnomalia ();
	}
	public string Nome{
		get{return nome;}
	}
	public string Descricao{
		get{return descricao;}
	}
	private void rolarAnomalia(){
		int rolagem = dado.RolarDados (2);

		string[] anomalias = new string[11];
		anomalias[2] = "Manchas Rosas";
		anomalias[3] = "Manchas Rosas";
		anomalias[4] = "Orelhas no suvaco";
		anomalias[5] = "Corcunda";
		anomalias[6] = "Braço extra atrofiado";
		anomalias[7] = dado.RolarDados(1)+" Olhos";
		anomalias[8] = "Olhos Gigantes";
		anomalias[9] = "Mãos Gigantes";
		anomalias[10] = "Duas Cabeças";

		if (rolagem == 11 || rolagem == 12) {
			rolarAnomalia ();
		} else {
			nome = anomalias [rolagem];
		}
	}
}
