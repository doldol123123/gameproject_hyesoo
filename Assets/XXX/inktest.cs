using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class inktest : MonoBehaviour
{
    private Story story;
    public TextAsset inkJSONAsset;

    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkJSONAsset.text);
        Debug.Log(loadStoryChunk());

        for(int i = 0; i < story.currentChoices.Count; i++)
        {
            Debug.Log(story.currentChoices[i].text);
        }

        story.ChooseChoiceIndex(1);

        Debug.Log(loadStoryChunk());
    }

    // Update is called once per frame
    void Update()
    {

    }

    string loadStoryChunk()
    {
        string text = "";
        if(story.canContinue)
        {
            text = story.ContinueMaximally();
        }
        return text;
    }
}
