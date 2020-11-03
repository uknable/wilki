﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 6f;
	public float gravity = 9.81f;
	public CharacterController controller;
	public Transform groundCheck;
	public float groundDistance = 0.3f;
	public LayerMask groundMask;
	
	public Vector3 move;

	Vector3 velocity;
	bool isGrounded;


	void Update () {
		isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

		if (isGrounded && velocity.y < 0) {
			velocity.y = -2f;
		}

		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		move = transform.right * x + transform.forward * z;
		move.Normalize();

		controller.Move(move * moveSpeed * Time.deltaTime);

		velocity.y -= gravity * Time.deltaTime;

		controller.Move(velocity * Time.deltaTime);
	}
}
