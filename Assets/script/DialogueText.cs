using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class DialogueText : MonoBehaviour
{
    private Story story;
    public TextAsset inkJSONAsset;

    public Text text;
    public Button button;
    public Image DialogueBox;
    public Image ButtonBox;

    public Text NameText;

    public Animator Portrait;

    private const string SPEAKER_TAG = "speaker";
    private const string PORTRAIT_TAG = "portrait";






    // Start is called before the first frame update
    void Start()
    {

        story = new Story(inkJSONAsset.text);

    }

    // Update is called once per frame
    void Update()
    {
        refreshUI();




    }

    void refreshUI()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (story.canContinue)
            {

                Portrait.gameObject.SetActive(true);
                DialogueBox.gameObject.SetActive(true);
                NameText.gameObject.SetActive(true);
                clearUI();

                Debug.Log("스페이스바");


                Text storyText = Instantiate(text) as Text;
                storyText.text = loadStoryChunk();
                storyText.transform.SetParent(DialogueBox.transform, false);

                HandleTag(story.currentTags);

                foreach (Choice Choice in story.currentChoices)
                {
                    Button choiceButton = Instantiate(button) as Button;
                    Text choiceText = button.GetComponentInChildren<Text>();
                    choiceText.text = Choice.text;
                    choiceButton.transform.SetParent(ButtonBox.transform, false);

                    choiceButton.onClick.AddListener(delegate
                    {
                        chooseStoryChoice(Choice);
                    });


                }
            }
            else
            {
                DialogueBox.gameObject.SetActive(false);
                NameText.gameObject.SetActive(false);
                Portrait.gameObject.SetActive(false);
            }
            


        }
    }

    void HandleTag(List<string> currentTags)
    {
        foreach(string tag in currentTags)
        {
            string[] splitTag = tag.Split(':');

            string tagKey = splitTag[0]; //trim
            string tagValue = splitTag[1];
            
            switch(tagKey)
            {
                case SPEAKER_TAG:
                    NameText.text = tagValue;
                    break;
                case PORTRAIT_TAG:
                    Portrait.Play(tagValue);
                    break;
            }


        }
    }


    void chooseStoryChoice(Choice Choice)
    {
        story.ChooseChoiceIndex(Choice.index);
        clearButton();
        refreshUI();
    }

    void clearButton()
    {

        int childCount = ButtonBox.transform.childCount;
        for (int i = childCount - 1; i >= 0; --i)
        {
            GameObject.Destroy(ButtonBox.transform.GetChild(i).gameObject);
        }

    }
    void clearUI()
    {

        int childCount = DialogueBox.transform.childCount;
        for (int i = childCount - 1; i >= 0; --i)
        {
            GameObject.Destroy(DialogueBox.transform.GetChild(i).gameObject);
        }

    }


    string loadStoryChunk()
    {


        string text = "";
        if (story.canContinue)
        {
            text = story.Continue();
        }
        return text;
    }

    


}

