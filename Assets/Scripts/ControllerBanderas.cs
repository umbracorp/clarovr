using UnityEngine;
using System.Collections;

public class ControllerBanderas : MonoBehaviour {

	public GameObject BanderaPartida;
	public GameObject BanderaSinTexto;
	public GameObject BanderaFinish;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (!Constantes.touchFinishLine && !Constantes.ultimaVuelta) {
             BanderaPartida.SetActive (true);
			BanderaSinTexto.SetActive (false);
			BanderaFinish.SetActive(false);
        }


		
		if (Constantes.touchFinishLine && !Constantes.ultimaVuelta) {
			
			BanderaPartida.SetActive (false);
			BanderaSinTexto.SetActive (true);
			BanderaFinish.SetActive(false);
			
		} else if (Constantes.ultimaVuelta) {
			BanderaPartida.SetActive (false);
			BanderaSinTexto.SetActive (false);
			BanderaFinish.SetActive(true);
		}
	}
}
