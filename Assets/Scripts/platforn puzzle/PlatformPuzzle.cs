using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using State = PuzzleState;

public class PlatformPuzzle : MonoBehaviour{
    public State State { get; private set; }
    public static Platforms lastPlatform;
    public static bool puzzleComplete = false;
    public GameObject PuzzleDoor;

    void Start(){
        lastPlatform = Platforms.NONE;
        State = State.IDLE;
    }

    void Update(){
        if (lastPlatform == Platforms.NONE){
            return;
        }
        switch (State){
            case State.IDLE:
                if (lastPlatform == Platforms.MIDDLE){
                    ChangeState(State._1_MIDDLE);
                }
                else {
                    ChangeState(State.ERROR);
                }
                break;
            case State._1_MIDDLE:
                if (lastPlatform == Platforms.LEFT){
                    ChangeState(State._2_LEFT);
                }
                else {
                    ChangeState(State.ERROR);
                }
                break;
            case State._2_LEFT:
                if (lastPlatform == Platforms.RIGHT){
                    ChangeState(State._3_RIGHT_FINISHED);
                }
                else{
                    ChangeState(State.ERROR);
                }
                break;
            case State.ERROR:
                ChangeState(State.IDLE);
                break;
        }
        lastPlatform = Platforms.NONE;
    }

    private void ChangeState(State newState){
        Debug.Log("Changing state");
        if (State != newState){
            State = newState;
            switch (newState){
                case State.IDLE:
                //do nothing
                    break;
                case State._1_MIDDLE:
                    SoundManager.Play(SoundType.CORRECT);
                    print ("got 1");
                    break;
                case State._2_LEFT:
                    print ("Got 2");
                    SoundManager.Play(SoundType.CORRECT);
                    break;
                case State._3_RIGHT_FINISHED:
                    print ("Got all 3!");
                    SoundManager.Play(SoundType.FINISHED);
                    puzzleComplete = true;
                    PuzzleDoor.SetActive(false);
                    break;
                case State.ERROR:
                    SoundManager.Play(SoundType.WRONG);
                    ChangeState(State.IDLE);
                    break;
            }
        }
    }
    public static void Press(Platforms platforms){
        Debug.Log("Setting platform to " + platforms);
        lastPlatform = platforms;
    }
}
