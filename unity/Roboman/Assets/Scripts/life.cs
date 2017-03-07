using UnityEngine;
using System.Collections;

public class Life: MonoBehaviour
{
	//zycia
	public GUITexture zyciaGUITextura;
	public Texture2D[] zyciaTekstura;
	int zycia = 3;

		//Use this for initalization
		void Start()
		{
		}

		//Update is called once per frame
		void Update()
		{
			if (zycia == 2)
			{
				zyciaGUITextura.texture = zyciaTekstura[zycia];
			}
			else if (zycia == 1)
			{
				zyciaGUITextura.texture = zyciaTekstura[zycia];
			}
			else if (zycia == 0)
			{
				zyciaGUITextura.texture = zyciaTekstura[zycia];
			}
		}
}