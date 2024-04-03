using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifePlayer : MonoBehaviour
{
    public AudioSource aus;
    public AudioClip deadSound;    

    private void Update()
    {
        if (transform.position.y < -1f)
        {
            Die();        
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
           // GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<MoveBehaviour>().enabled = false;
            aus.PlayOneShot(deadSound);
            Debug.Log("deadSound");
            Die();
        }
    }
    void Die()
    {
        Invoke(nameof(ReloadLevel), 0.5f);
      
    }
    void ReloadLevel()
    {     
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
