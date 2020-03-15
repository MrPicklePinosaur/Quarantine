﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

    [HideInInspector] public Rigidbody2D rb;

    
    [HideInInspector] public Vector2 moveInput;
    [HideInInspector] public float jumpInput;


    //Children
    [HideInInspector] public GameObject sprite;

    [Range(0f,1f)] public float inputThreshold;
    public List<Vector2> pastMoves;
    public List<float> pastJumps;

    void Awake() {
        sprite = GetComponentInChildren<Animator>().gameObject;

        rb = GetComponent<Rigidbody2D>();
        pastMoves= new List<Vector2>();
        pastJumps = new List<float>();

    }

    void Update() {

        pastMoves.Add(moveInput);
        pastJumps.Add(jumpInput);
    }

    
}
