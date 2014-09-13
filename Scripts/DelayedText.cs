using UnityEngine;
using System.Collections;

public class DelayedText : MonoBehaviour {

    public float letterPause = 0.05f;
    public AudioClip sound;
    string message;
    string delayText;
     
    void Start ()
    {
        message = "Welcome new warrior! This is a blue screen, you must fight your way out! " +
        "Without any hands or other parts. This may take some time...";
        delayText = "";

        StartCoroutine(TypeText(message));
    }
     
    IEnumerator TypeText (string text, bool reset = false)
    {
        // Resets the message back to blank
        delayText = "";

        foreach (char letter in text.ToCharArray())
        {
            delayText += letter;
            
            if (sound)
                audio.PlayOneShot (sound);

            yield return 0;
            yield return new WaitForSeconds (letterPause);
        }
        // Reset text back to blank
        // text = "";
    }
     
    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 4, Screen.height / 4, 256, 1024), delayText);
    }
     
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Return))
        {
            StopAllCoroutines();
            delayText = message;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            StopAllCoroutines();
            StartCoroutine(TypeText("More test messaging! More test messaging! More test messaging! More test messaging! More test messaging! More test messaging! More test messaging! More test messaging! More test messaging! More test messaging! More test messaging! "));
        }
    }
}

