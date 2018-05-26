using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coger : MonoBehaviour 
{
	float velDesplazamiento = 3;

	public GameObject puntoDeReferencia;
	public GameObject[] puntoDeInteractuacion;
	GameObject recogido;

	bool keyMover = false;

	bool cogido = false;

	int objetos = 0;


	void OnTriggerStay(Collider collider)
	{
		if (collider.gameObject.tag == "Objeto") 
		{
			Inputs (collider,0);
		}
		if (collider.gameObject.tag == "E_Objeto_1") 
		{
			Inputs (collider, 1);
		}
		if (collider.gameObject.tag == "E_Objeto_2") 
		{
			Inputs (collider, 2);
		}
		if (collider.gameObject.tag == "E_Objeto_3") 
		{
			Inputs (collider, 3);
		}
		if (collider.gameObject.tag == "E_Objeto_4") 
		{
			Inputs (collider, 4);
		}

	}

	void Inputs(Collider collider, int i)
	{
		if (Input.GetKey (KeyCode.E)) 
		{
			if (cogido == false) 
			{
				recogido = collider.gameObject;
				CogerObjeto (recogido);
				cogido = true;
			} 

			else if (cogido == true) 
			{
			
				if (objetos == 0) 
				{
					SoltarObjeto (recogido);
					cogido = false;
					recogido = null;
				}

				if (objetos == 1) 
				{
					ColocarEnUnPunto (recogido, i);
				}

				if (objetos == 2)
				{
					ColocarEnUnPunto (recogido, i);
				}

				if (objetos == 3) 
				{
					ColocarEnUnPunto (recogido, i);
				} 

				if (objetos == 4) 
				{
					ColocarEnUnPunto (recogido, i);
				} 
			}
		}
	}

	void CogerObjeto(GameObject objetoCogible)
	{
		objetoCogible.gameObject.transform.position = puntoDeReferencia.gameObject.transform.position;
		objetoCogible.transform.parent = puntoDeReferencia.transform;
		objetoCogible.GetComponent<Rigidbody> ().isKinematic = true;
		objetoCogible.GetComponent<Rigidbody> ().useGravity = false;
	}
		
	void SoltarObjeto (GameObject objetoCogible)
	{
		objetoCogible.transform.parent = null;
		objetoCogible.GetComponent<Rigidbody> ().isKinematic = false;
		objetoCogible.GetComponent<Rigidbody> ().useGravity = true;
	}

	void Destruir(GameObject objetoCogible)
	{
		Destroy (objetoCogible);
	}

	void ColocarEnUnPunto(GameObject objetoCogible, int i)
	{
		objetoCogible.gameObject.transform.position = puntoDeInteractuacion[i].gameObject.transform.position;
		objetoCogible.transform.parent = null;
		objetoCogible.GetComponent<Rigidbody> ().useGravity = false;
	}
}