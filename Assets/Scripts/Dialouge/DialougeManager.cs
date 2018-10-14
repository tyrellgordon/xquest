using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialougeManager : MonoBehaviour {

    public Text nameText;
    public Text dialougeText;
    public Text buttonText;

    public Animator animator;

   private Queue<string> sentences; 

	// Use this for initialization
	void Start () {

        sentences = new Queue<string>();
		
	}

    public void StartDialouge(Dialouge dialouge){

        animator.SetBool("IsOpen", true);
    
        nameText.text = dialouge.name;

        sentences.Clear();

        foreach (string sentence in dialouge.sentences){

            sentences.Enqueue(sentence);

        }

        DisplayNextSentence();
    }
	
    public void DisplayNextSentence (){

        if (sentences.Count == 0){
            EndDialouge();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();

        StartCoroutine(TypeSentence(sentence));


    }

    IEnumerator TypeSentence(string sentence){
        dialougeText.text = "";

        foreach (char letter in sentence.ToCharArray()){

            dialougeText.text += letter;

            yield return null;

        }

    }

    void EndDialouge(){

        animator.SetBool("IsOpen", false);
        nameText.CrossFadeAlpha(0.0f, 0.05f, false);
        dialougeText.CrossFadeAlpha(0.0f, 0.05f, false);
        buttonText.CrossFadeAlpha(0.0f, 0.05f, false);

    }


}
