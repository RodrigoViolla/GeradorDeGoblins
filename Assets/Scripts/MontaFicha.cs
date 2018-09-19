using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MontaFicha : MonoBehaviour {

	public GameObject ficha;
	public GameObject detalhes;
	public Text ocupacao;
	public Text equipamento;
	public Text cor;
	public Text combate;
	public Text conhecimento;
	public Text habilidade;
	public Text sorte;
	public Text nome;
	public Text dano;
	public Text protecao;
	public Text descricaoEquip;
	public Text especial;
	public Text caracteristica;
	public Sprite sprite;
	public Image vida1;
	public Image vida2;
	public Image vida3;
	public Image vida4;

	private CriadorDeGoblins criador;

	void Start () {
		criador = new CriadorDeGoblins ();
		MontarFicha ();
	}

	public void MontarFicha(){		
		Goblin goblin = criador.Criar ();

		nome.text = goblin.Nome;
		ocupacao.text = "Ocupação: " + goblin.Classe.Nome;
		equipamento.text = "Equipamento\n" + goblin.Classe.Equip.Nome;
		cor.text = "Aparência: " + goblin.Caracteristica.Nome + " e " + goblin.Cor.Nome;
		combate.text = "Combate: " + goblin.Combate;
		conhecimento.text = "Conhecimento: " + goblin.Conhecimento;
		habilidade.text = "Habilidade: " + goblin.Habilidade;
		sorte.text = "Sorte: " + goblin.Sorte;
		dano.text = "Dano: " + goblin.Classe.Equip.Dano;
		protecao.text = "Proteção: " + goblin.Classe.Equip.Defesa;
		descricaoEquip.text = goblin.Classe.Equip.Descricao;
		especial.text = "Nivel 1\n" + goblin.Classe.Especial;
		caracteristica.text = "Caracteristica\n"+goblin.Caracteristica.Descricao;

		vida1.sprite = sprite;
		vida2.sprite = sprite;
		vida3.sprite = sprite;
		vida4.sprite = sprite;
	}

	public void Detalhes(){
		if (ficha.activeSelf) {
			ficha.SetActive (false);
			detalhes.SetActive (true);
		} else {
			ficha.SetActive (true);
			detalhes.SetActive (false);
		}
	}
}
