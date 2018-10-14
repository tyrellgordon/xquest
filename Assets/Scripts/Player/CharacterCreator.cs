using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CharacterCreator : MonoBehaviour {

    public InputField nameField;

    public string charName;


    public void OnSubmit(){
        charName = nameField.text;

        Player.playerName = charName;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
