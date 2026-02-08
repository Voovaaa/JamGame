using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Game game;
    public Options options;
    public SoundEffects se;

    public void Activate()
    {
        this.gameObject.SetActive(true);
    }

    public void NewGame()
    {
        se.Play("click");
        game.Initialize();
        DialogueSystem dialogue = GameObject.Find("UI").GetComponent<DialogueSystem>();
        dialogue.replics = new List<string>();
        dialogue.replics.Add("Good morning.. i guess");
        dialogue.replics.Add("Here i live.");
        dialogue.replics.Add("Didn't talk for a while, don't know what to say.");
        dialogue.startDialogue();

        this.gameObject.SetActive(false);
    }

    public void Options()
    {
        se.Play("click");
        this.options.Activate();
    }

    public void Quit()
    {
        se.Play("click");
        Application.Quit();
    }
}


