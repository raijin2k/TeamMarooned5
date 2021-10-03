using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public void LoadScene()
{
    switch (CurrentDifficulty)
    {
        case DifficultyLevel.Easy:
            SceneManager.LoadScene("Easy");
            break;
        case DifficultyLevel.Medium:
            SceneManager.LoadScene("Medium");
            break;
        case DifficultyLevel.Hard:
            SceneManager.LoadScene("Hard");
            break;
        case DifficultyLevel.Nightmare:
            SceneManager.LoadScene("Nightmare");
            break;
    }
}