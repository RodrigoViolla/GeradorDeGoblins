using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RolaDados{

	public int RolarDados (int quantidade){
		int resultado = 0;

		for (int cnt = 0; cnt < quantidade; cnt++)
			resultado += Random.Range (1, 7);

		return resultado;
	}
}