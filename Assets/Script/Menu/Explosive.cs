using UnityEngine;
using System.Collections;

public class Explosive : MonoBehaviour {
	public Remains Remain;
	public GameObject Blast;
	
	void Start()
	{
	
	}
	
	void Update()
	{
		if(Remain.Enemies > Remain.MaxEnemy)
		{
			Blast.SetActive(true);
		}
	}
}