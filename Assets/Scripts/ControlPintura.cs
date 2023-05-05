using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPintura : MonoBehaviour
{
    public GameObject brocha;
	public bool trigeando;
	private void OnTriggerStay(Collider other)
	{
		if (other.CompareTag("pared"))
		{
			brocha.SetActive(true);
		}
		trigeando = true;
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("pared"))
		{
			brocha.SetActive(false);
		}
		trigeando = false;
	}
}
