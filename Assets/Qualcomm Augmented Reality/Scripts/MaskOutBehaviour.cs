/*==============================================================================
Copyright (c) 2010-2013 QUALCOMM Austria Research Center GmbH.
All Rights Reserved.
Confidential and Proprietary - QUALCOMM Austria Research Center GmbH.
==============================================================================*/

using UnityEngine;

/// <summary>
/// Helper behaviour used to hide augmented objects behind the video background.
/// </summary>
public class MaskOutBehaviour : MonoBehaviour
{

    #region PUBLIC_MEMBER_VARIABLES

    public Material maskMaterial;

    #endregion // PUBLIC_MEMBER_VARIABLES


    #region UNITY_MONOBEHAVIOUR_METHODS

    void Start ()
    {
        if (QCARRuntimeUtilities.IsQCAREnabled())
        {
            int numMaterials = this.renderer.materials.Length;
            if (numMaterials == 1)
            {
                this.renderer.sharedMaterial = maskMaterial;
            }
            else
            {
                Material[] maskMaterials = new Material[numMaterials];
                for (int i = 0; i < numMaterials; i++)
                    maskMaterials[i] = maskMaterial;

                this.renderer.sharedMaterials = maskMaterials;
            }
        }
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS
}
