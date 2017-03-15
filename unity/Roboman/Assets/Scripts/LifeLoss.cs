using UnityEngine;

public class LifeLoss : MonoBehaviour
{
    public uiManager uiObj;
   
    // Use this for initialization
    void Start()
    {
        uiObj = GameObject.FindObjectOfType(typeof(uiManager)) as uiManager;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Animator>().SetTrigger("Death");
            uiObj.lifesUpdate();
            collision.gameObject.GetComponent<Respawn>().KillPlayer();
        }
    }
}