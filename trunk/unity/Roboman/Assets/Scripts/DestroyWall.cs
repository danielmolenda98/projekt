<<<<<<< .mine
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    public uiManager uiObj;

    // Use this for initialization
    void Start ()
    {
		uiObj = GameObject.FindObjectOfType(typeof(uiManager)) as uiManager;
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
||||||| .r0
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    public uiManager uiObj;
    // Use this for initialization
    void Start ()
    {
		uiObj = GameObject.FindObjectOfType(typeof(uiManager)) as uiManager;
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
>>>>>>> .r98
