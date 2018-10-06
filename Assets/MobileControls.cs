
using UnityEngine;

public class MobileControls : MonoBehaviour
{
    /// <summary>
    /// Reference to player movement script to force player to move based on UI
    /// </summary>
    private PlayerMovement playerMovement;

	// Use this for initialization
	void Start () {

        playerMovement = FindObjectOfType<PlayerMovement>();
	}


    /// <summary>
    /// Starting holding left button, move player left
    /// </summary>
    public void OnLeftButtonHold()
    {
        playerMovement.isMovingLeft = true;
    }

    /// <summary>
    /// Stopped holding left button, stop movement 
    /// </summary>
    public void OnLeftButtonRelease()
    {
        playerMovement.isMovingLeft = false;
    }

    /// <summary>
    /// Started holding right button, move player right
    /// </summary>
    public void OnRightButtonHold()
    {
        playerMovement.isMovingRight = true;
    }

    /// <summary>
    /// Stopped holding right button, stop movement
    /// </summary>
    public void OnRightButtonRelease()
    {
        playerMovement.isMovingRight = false;
    }


    public void OnThinButtonHold()
    {
        playerMovement.isThin = true;
    }

    public void OnThinButtonRelease()
    {
        playerMovement.isThin = false;
    }

    public void OnFlatButtonHold()
    {
        playerMovement.isFlat = true;
    }

    public void OnFlatButtonRelease()
    {
        playerMovement.isFlat = false;
    }
    
    public void OnClickButton()
    {
        playerMovement.isClickingJump = true;
    }

   
    /// <summary>
    /// Enable the mobile controls screen
    /// </summary>
    public void EnableMobileControlsUi()
    {
        Debug.Log("turning on mobile controls");
        gameObject.SetActive(true);
    }

    /// <summary>
    /// Disable the mobile controls UI
    /// </summary>
    public void DisableMobileControlsUi()
    {
        Debug.Log("turning off mobile controls");
        gameObject.SetActive(false);
    }
}
