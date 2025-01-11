using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField]
    private Color initialColor;

    [SerializeField]
    private Color endColor;

    [SerializeField]
    private float totalLerpDuration;


    private SpriteRenderer spriteRenderer;

    private float timeElapsed = 0.0f;
    private bool changeColor = true;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        StartCoroutine(ChangeColorOverTime());
    }

    private IEnumerator ChangeColorOverTime()
    {
        timeElapsed = 0.0f;
        while (changeColor)
        {
            timeElapsed += Time.deltaTime;
            spriteRenderer.color = Color.Lerp(initialColor, endColor, timeElapsed / totalLerpDuration);
            
            if(timeElapsed > totalLerpDuration)
                changeColor = false;
            yield return null;
        }
        yield return null;
        
    }
}
