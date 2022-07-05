using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    [SerializeField] private float outOfBounds = -5.0f;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    private void Update()
    {
        if (gameObject.transform.position.y <= outOfBounds)
        {
            Destroy(gameObject);
            LoadCurrentScene();
            
        }        
    }

    private void LoadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
