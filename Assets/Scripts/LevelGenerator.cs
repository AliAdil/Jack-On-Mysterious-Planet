using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	// Use this for initialization
    public static LevelGenerator instance;
    //all level pieces blueprints used to copy from
    public List<LevelPiece> levelPrefabs = new List<LevelPiece>();
    // starting point of the very first level piece
    public Transform levelStartPoint;
    // all level piece that are currently in the level
    public List<LevelPiece> pieces = new List<LevelPiece>();

    void Awake()
    {
        instance = this;
    }
}
