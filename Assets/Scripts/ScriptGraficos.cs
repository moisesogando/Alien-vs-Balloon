using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGraficos : MonoBehaviour
{
    public void GraficosBajos() {
        QualitySettings.currentLevel = QualityLevel.Fastest;
    }

    public void GraficosMedios()
    {
        QualitySettings.currentLevel = QualityLevel.Good;
    }

    public void GraficosAltos()
    {
        QualitySettings.currentLevel = QualityLevel.Beautiful;
    }


}
