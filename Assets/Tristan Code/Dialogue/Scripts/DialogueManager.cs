﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    //Text Stuff: Names and Text and yeah :D
    public Text nameText;
    public Animator nameBorderText;
    public Text dialogueText;

    //Visual Stuff: Sprites, Backgrounds, Actual Box for text
    public Animator textBox;
    public GameObject CharacterFrameObject;
    public Animator CharacterFrame;
    public Animator Background;


    private int sceneNumber;
    //Queue for names and sentances to know which ones go in order
    private Queue<string> names;
    private Queue<string> sentences;
    private Queue<AudioClip> voices;
    private Queue<Sprite> sprites;
    private Queue<Sprite> BGSprites;

    //Player access for making them stop moving n stuff
    public GameObject Player;
    public PauseScript pauseMenu;
    public SceneChanger sceneChanger;

    public Image CharacterSprite;
    public Image BGSprite;

    private Tutorial tutorial;

    //checks if ur in a convo
    private bool isActive;
    //checks if the text has ended
    private bool endText;
    private bool tutorialTrigger;
    private bool bossTrigger;
    private bool sceneTransition;

    public static DialogueManager Instance;

    public LoadBattle loadBattle;
    void Start()
    {
        endText = false;
        isActive = false;
        sceneTransition = false;
        names = new Queue<string>();
        sentences = new Queue<string>();
        voices = new Queue<AudioClip>();
        sprites = new Queue<Sprite>();
        //BGSprites = new Queue<Sprite>();
        tutorialTrigger = false;

        loadBattle = GameObject.FindGameObjectWithTag("player").GetComponent<LoadBattle>();

        CharacterFrameObject.SetActive(false);
    }
    public IEnumerator StartDialogue(Dialogue dialogue)
    {
        endText = false;
        sceneNumber = dialogue.sceneNumber;
        tutorialTrigger = dialogue.tutorialTrigger;
        bossTrigger = dialogue.bossTrigger;
        tutorial = dialogue.tutorial;
        sceneTransition = dialogue.sceneTransition;

        if (Player != null)
        {
            Player.GetComponent<PlayerMovementFinal>().enabled = false;
            Player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Player.GetComponent<Rigidbody2D>().velocity.y);

            Player.GetComponent<Animator>().SetBool("inJump", false);
            Player.GetComponent<Animator>().SetFloat("walkSpeed", 0f);

            if (pauseMenu != null)
            {
                pauseMenu.enabled = false;
            }
        }

        names.Clear();
        foreach (string name in dialogue.names)
        {
            names.Enqueue(name);
        }
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        voices.Clear();
        foreach (AudioClip voice in dialogue.voices)
        {
            voices.Enqueue(voice);
        }
        sprites.Clear();
        foreach (Sprite sprite in dialogue.sprites)
        {
            sprites.Enqueue(sprite);
        }

        //BGSprites.Clear();
        //foreach (Sprite BGSprite in dialogue.BGsprites)
        //{
        //    BGSprites.Enqueue(BGSprite);
        //}

        textBox.SetBool("isOpen", true);
        DisplayNextSentence();

        //Enabling all visual components
        if (Background != null)
        {
            Background.SetBool("isOpen", true);
        }
        CharacterFrameObject.SetActive(true);
        CharacterFrame.SetBool("isOpen", true);

        yield return new WaitForSeconds(0.3f);
        textBox.SetBool("isOpen", true);
        yield return new WaitForSeconds(0.3f);
    }



    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        string name = names.Dequeue();

        StopAllCoroutines();
        
        StartCoroutine(TypeSentence(sentence, name));
    }

    IEnumerator TypeSentence(string sentence, string name)
    {
        //Setting up image stuff

        Sprite CurrentSprite = sprites.Dequeue();
        //Sprite CurrentBG = BGSprites.Dequeue();
        
        CharacterSprite.sprite = CurrentSprite;

        //Setting Up name stuff
        string prevName = nameText.text;
        dialogueText.text = "";
        nameText.text = "";


        //Visual flare to indicate a different person is talking
        if (prevName != name && name != "null")
        {
            //Setting Name
            nameBorderText.SetBool("isOpen", false);
            CharacterFrame.SetBool("isOpen", false);
            yield return new WaitForSeconds(0.01f);
            nameBorderText.SetBool("isOpen", true);
            CharacterFrame.SetBool("isOpen", true);
            nameText.text = name;

        } else if(name == "null")
        {
            Debug.Log("bruh");
            nameBorderText.SetBool("isOpen", false);
            CharacterFrame.SetBool("isOpen", false);
        }

        //BGSprite.sprite = CurrentBG;
        CharacterSprite.sprite = CurrentSprite;

        //Setting name and sprite
        nameBorderText.SetBool("isOpen", true);
        nameText.text = name;

        //Typing letter by letter
        foreach (char letter in sentence.ToCharArray())
        { 
            if (endText == true)
            {
                CharacterFrame.SetBool("isOpen", false);
                textBox.SetBool("isOpen", false);
                CharacterFrameObject.SetActive(false);
                nameBorderText.SetBool("isOpen", false);
            }
            
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        //enables menu
        endText = true;
        Player.GetComponent<PlayerMovementFinal>().enabled = true;
        Player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        //disables menu
        if (pauseMenu != null)
        {
            pauseMenu.enabled = true;
        }
        if (Background != null)
        {
            Background.SetBool("isOpen", false);
        }

        nameBorderText.SetBool("isOpen", false);
        CharacterFrame.SetBool("isOpen", false);
        textBox.SetBool("isOpen", false);
        CharacterFrameObject.SetActive(false);

        //Triggers tutorial if tutorialTrigger = true
        if(tutorialTrigger == true && tutorial != null)
        {
            FindObjectOfType<TutorialManager>().StartTutorial(tutorial);
        }

        //Triggers boss if bossTrigger = true
        if(bossTrigger == true)
        {
            loadBattle.StartCoroutine("BattleSetup");

            if (GameObject.FindGameObjectsWithTag("Boss1").Length >= 1)
            {
                EnemyHolder.bossNumber = 1;
            }
            else if(GameObject.FindGameObjectsWithTag("Boss2").Length >= 1)
            {
                EnemyHolder.bossNumber = 2;
            }
            else if(GameObject.FindGameObjectsWithTag("Boss3").Length >= 1)
            {
                EnemyHolder.bossNumber = 3;
            }

        }

        if (sceneTransition == true)
        {
            sceneChanger.FadeToLevel(sceneNumber);
        }
    }

    private void Update()
    {
        if (isActive == true && Input.GetKeyDown(KeyCode.Return))
        {
            DisplayNextSentence();
        }
        
        if(isActive == true && Input.GetKeyDown(KeyCode.Escape))
        {
            EndDialogue();
        }
    }
}
