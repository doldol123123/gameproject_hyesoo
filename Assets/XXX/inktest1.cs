using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;

public class inktest1 : MonoBehaviour
{
    private Story story;
    public TextAsset inkJSONAsset;

    public Text text;
    //public Button choice;



    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkJSONAsset.text);

        Text storyText = Instantiate(text) as Text;
        storyText.text = loadStoryChunk();
        storyText.transform.SetParent(this.transform, false);

        loadStoryChunk();


        for (int i = 0; i < story.currentChoices.Count; i++)
        {
            Debug.Log(story.currentChoices[i].text);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("스페이스바");
            loadStoryChunk();
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
