using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{  [SerializeField]
   public GameObject resaultObject;
    [SerializeField]
    public GameObject NumberObject;
    [SerializeField]
    public GameObject culumnObject;
    [SerializeField]
    public Text _matches;

    List<int> UserNumbers = new List<int>();
    List<int> RandomNumbers = new List<int>();
    List<RawImage> _rawlist = new List<RawImage>();
    List<Text> _text = new List<Text>();
    
    int counter = 0;
   
    private bool oneTime = true;
    int matches = 0;
    private void Start()
    {
        GetObject();
        
    }

    public void OnClickButton(int id)
    {
       
        Debug.Log("ID: " + id.ToString());
        if (!UserNumbers.Contains(id)) {
            UserNumbers.Add(id);
            _rawlist[id-1].color = Color.blue;
            
         
            
        }else
        {
            UserNumbers.Remove(id);
            _rawlist[id - 1].color = Color.white;

        }
        
        if (UserNumbers.Count == 5)
        {
          
            GetYourNumberText();
            ShowReasaults();
            for (int i = 0; i < UserNumbers.Count; i++)
            {
                for (int j = 0; j < RandomNumbers.Count; j++)
                {
                    if (UserNumbers[i] == RandomNumbers[j])
                        matches++;
                }
               
            }
            _matches.text = matches.ToString();
        }
       
    }

    public void ShowReasaults()
    {
       
        foreach (Text text in resaultObject.GetComponentsInChildren<Text>())
        {
           
            int resaults = (int)Random.Range(1, 45);
            if (RandomNumbers.Contains(resaults))
            {

                while (RandomNumbers.Contains(resaults))
                {
                    resaults = (int)Random.Range(1, 45);
                }
                RandomNumbers.Add(resaults);
                text.text = resaults.ToString();
            }
            else
            {
                RandomNumbers.Add(resaults);
                text.text = resaults.ToString();
            }
        }
    }
    public void GetYourNumberText()
    {
       
       
            foreach (Text text in NumberObject.GetComponentsInChildren<Text>())
            {

              text.text = UserNumbers[counter].ToString();
              counter++;
           

            }

    }
    public void GetObject()
    {


        foreach (RawImage raw in culumnObject.GetComponentsInChildren<RawImage>())
        {
          
            _rawlist.Add(raw.GetComponentInChildren<RawImage>());
          

        }

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
