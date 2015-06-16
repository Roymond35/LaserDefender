﻿using UnityEngine;
using System.Collections;

public class GameConstants : MonoBehaviour {

	//Random
	public static Random rand = new Random();


	//Controlling the player object speeds
	public static float PLAYER_MOVEMENT_SPEED = 10f;
	public static float LASER_MOVEMENT_SPEED = 10f;

	//Controlling the rate at which the laser fires.
	public static float FIRE_DELAY = 0.25f;

	public static float DESTROYER_BUFFER = 1f;


	//Enemy Movement
	public static float ENEMY_HORZ_SPEED = 5f;
	public static float ENEMY_VERT_SPEED = 0.5f;
	public static float ENEMY2_HORZ_SPEED = 5f;
	public static float ENEMY2_VERT_SPEED = 5f;
	public static float ENEMY_SPAWN_RATE = 7f;

	//Enemy Damage
	public static float ENEMY_LASER_DAMAGE = 10.0f;
	public static float ENEMY_SHIP_DAMAGE = 20f;

	//Enemy Firing
	public static float ENEMY_FIRE_RATE = 0.5f;
	public static int NUM_OF_FORMATIONS = 3;


	//Formation Widths
	public static float PENTAGON_WIDTH = 3.0f;
	public static float V_WIDTH = 5.0f;
	public static float W_WIDTH = 7.0f;


}
