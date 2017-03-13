using UnityEngine;

public class LifeLoss : MonoBehaviour
{
    public uiManager uiObj;
    public Vector2 spawnPoint;
   
    // Use this for initialization
    void Start()
    {
        uiObj = GameObject.FindObjectOfType(typeof(uiManager)) as uiManager;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            collision.gameObject.GetComponent<Animator>().SetTrigger("Death");
            uiObj.lifesUpdate();
        }
    }

}