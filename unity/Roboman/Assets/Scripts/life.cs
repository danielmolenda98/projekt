using UnityEngine;
using System.Collections;

public class Life: MonoBehaviour
{
	//zycia
	public GUITexture zyciaGUITextura;
	public Texture2D[] lifeTextures;
	int zycia = 3;

    private void Awake()
    {
        Debug.Log("test0");
    }
    //Use this for initalization

    //Use this for initalization
    void Start()
    {
        if (true)
        {
        }
        Debug.Log("test");
    }
	//Update is called once per frame
	void Update()
	{
        Debug.Log("test2");
        zyciaGUITextura.texture = lifeTextures[zycia];		
	}
}