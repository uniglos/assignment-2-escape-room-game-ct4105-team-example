using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<string> puzzleNames;

    void Start()
    {

        createPuzzleList();

    }
    
    public void createPuzzleList()
    {

        foreach( string puzzle in puzzleNames)
        {

            if( !PlayerPrefs.HasKey( puzzle ) )
            {

                PlayerPrefs.SetString( puzzle, "" );

            }
            
        }

        checkPuzzleStatus();

    }

    public void checkPuzzleStatus()
    {

        foreach( string puzzle in puzzleNames)
        {

            var status = "Incomplete";

            if( PlayerPrefs.GetString( puzzle ) != "" )
            {

                status = "Complete";
                
            }
            
            print( "Puzzle " + puzzle + " is: " + status);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deletePlayerPrefs()
    {

        PlayerPrefs.DeleteAll();

        print( "PlayerPrefs deleted." );

    }

}
