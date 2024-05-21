using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nextLvl : MonoBehaviour
{
    public Button button;

    // Start is called before the first frame update
    void Start()
    {

        button = GetComponent<Button>();
        button.onClick.AddListener(Next);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Next()
    {
        SceneManager.LoadScene("Escena2");
    }
}
