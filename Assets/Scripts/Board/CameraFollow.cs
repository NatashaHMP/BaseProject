using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class CameraFollow : MonoBehaviour 
{
    private GameObject objPlayer;

	private float currentCameraPositionZ;

	private void Start()
	{
		LoadResorces();
	}

	private void Update()
	{
		MoveCamera();  
	}

	private void LoadResorces() 
	{
		currentCameraPositionZ = transform.position.z;
        objPlayer = GameObject.FindWithTag(Constants.ObjectName.PLAYER);
	}

	// move camera
	private void MoveCamera()
	{
        if(objPlayer != null)
        {
            transform.position = new Vector3(LimitHorizontalMoveWithPlayer(),
                                             Constants.CameraProperties.CAMERA_POSITION_Y,
            currentCameraPositionZ);
        }
	}

	// limiting move in x with the move of player
	private float LimitHorizontalMoveWithPlayer() 
	{
		float playerHorizontalPosition = objPlayer.transform.position.x;
        float moveIn = Mathf.Clamp(playerHorizontalPosition, Constants.CameraProperties.MIN_X, Constants.CameraProperties.MAX_X);

		return moveIn;
	}
}
